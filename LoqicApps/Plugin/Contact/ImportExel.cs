using CrmEarlyBound;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace LogiqApps.Plugin.Contact
{
    public class ImportExcel : PluginBase
    {
        private Dictionary<string, string> columnName = new Dictionary<string, string>()
        {
            ["Full Name"] = "fullname",
            ["Email"] = "emailaddress1",
            ["Business Phone"] = "telephone1",
            ["id"] = "id",
            ["Status"] = "statecode"
        };
        public ImportExcel() : base(typeof(ImportExcel))
        {
            RegisterEvent(PipelineStages.PostOperation, MessageNames.Create, Annotation.EntityLogicalName, PostOperationCreateHandler);
        }
        private void PostOperationCreateHandler(LocalPluginContext localPluginContext)
        {
            IPluginExecutionContext context = localPluginContext.PluginExecutionContext;
            IOrganizationService organizationService = localPluginContext.OrganizationService;
            if (context.InputParameters.Contains("Target") &&
                context.InputParameters["Target"] is Entity)
            {
                Entity noteEntity = (Entity)context.InputParameters["Target"];
                Annotation note = noteEntity.ToEntity<Annotation>();
                if (!string.IsNullOrEmpty(note.FileName))
                {
                    var noteBody = note.DocumentBody;
                    byte[] fileContent = Convert.FromBase64String(noteBody);
                    MemoryStream ms = new MemoryStream();
                    ms.Write(fileContent, 0, fileContent.Length);
                    ms.Position = 0;
                    var doc = SpreadsheetDocument.Open(ms, false);
                    WorkbookPart workbookPart = doc.WorkbookPart;
                    WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
                    SheetData thisSheet = worksheetPart.Worksheet.Elements<SheetData>().First();
                    System.Text.StringBuilder text = new System.Text.StringBuilder();
                    List<string> actualColumnName = new List<string>();
                    for (int i = 1; i < thisSheet.Elements<Row>().Count(); i++)
                    {

                        var contactId = Guid.TryParse(ReadExcelCell(thisSheet.Elements<Row>().ElementAt(i).Elements<Cell>().ElementAt(5), workbookPart), out var newGuid);
                        var firstname = ReadExcelCell(thisSheet.Elements<Row>().ElementAt(i).Elements<Cell>().ElementAt(0), workbookPart);
                        var lastname = ReadExcelCell(thisSheet.Elements<Row>().ElementAt(i).Elements<Cell>().ElementAt(1), workbookPart);
                        var email = ReadExcelCell(thisSheet.Elements<Row>().ElementAt(i).Elements<Cell>().ElementAt(2), workbookPart);
                        var phone = ReadExcelCell(thisSheet.Elements<Row>().ElementAt(i).Elements<Cell>().ElementAt(3), workbookPart);
                        var status = ReadExcelCell(thisSheet.Elements<Row>().ElementAt(i).Elements<Cell>().ElementAt(4), workbookPart);
                        var statusEnum = status == "Active" ? Contact_StatusCode.Active : Contact_StatusCode.Inactive;

                        if (contactId)
                        {
                            var contact = new Entity("contact", newGuid);
                            bool isChanged = false;
                            var actualContact = organizationService.Retrieve(contact.LogicalName, newGuid, new ColumnSet("firstname", "lastname", "emailaddress1", "telephone1", "statecode"));
                            if (firstname != (string)actualContact["firstname"])
                            {
                                contact["firstname"] = firstname;
                                isChanged = true;
                            }
                            if (lastname != (string)actualContact["lastname"])
                            {
                                contact["lastname"] = lastname;
                                isChanged = true;
                            }

                            if (email != (string)actualContact["emailaddress1"])
                            {
                                contact["emailaddress1"] = email;
                                isChanged = true;
                            }
                            if (phone != (string)actualContact["telephone1"])
                            {
                                contact["telephone1"] = phone;
                                isChanged = true;
                            }

                            if (statusEnum.ToString() != status)
                            {
                                contact["statecode"] = status == "Active" ? Contact_StatusCode.Active : Contact_StatusCode.Inactive;
                                isChanged = true;
                            }

                            if (isChanged)
                                organizationService.Update(contact);
                        }
                        else
                        {

                            var createdcontact = new Entity("contact", newGuid);
                            createdcontact["firstname"] = firstname;
                            createdcontact["lastname"]=lastname;
                            createdcontact["emailaddress1"]=email;
                            createdcontact["telephone1"] = email;
                            
                            organizationService.Create(createdcontact);

                        }
                        var contacta = new Entity("contact", newGuid);
                        var afterContact = organizationService.Retrieve(contacta.LogicalName, newGuid, new ColumnSet("fullname", "emailaddress1", "telephone1", "statecode"));
                    }
                }
            }

        }
        private string ReadExcelCell(Cell cell, WorkbookPart workbookPart)
        {
            var cellValue = cell.CellValue;
            var text = (cellValue == null) ? cell.InnerText : cellValue.Text;
            if ((cell.DataType != null) && (cell.DataType == CellValues.SharedString))
            {
                text = workbookPart.SharedStringTablePart.SharedStringTable
                    .Elements<SharedStringItem>().ElementAt(
                        Convert.ToInt32(cell.CellValue.Text)).InnerText;
            }
            return (text ?? string.Empty).Trim();
        }

        public enum Contact_StatusCode
        {

            [System.Runtime.Serialization.EnumMemberAttribute()]
            Active = 1,

            [System.Runtime.Serialization.EnumMemberAttribute()]
            Inactive = 2,
        }
    }
}