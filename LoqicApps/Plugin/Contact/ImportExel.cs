using CrmEarlyBound;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using LogiqApps.CustomEntity;
using LogiqApps.Models;
using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Query;
using Newtonsoft.Json;
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
            //var referral = localPluginContext.Target<ipg_referral>();
            //CreateNoteOnRejectReferral(referral.Id, localPluginContext.OrganizationService);
            //string tempFile = string.Empty;
            //ImportProcessDto gateProcessDto = JsonConvert.DeserializeObject<ImportProcessDto>(args);
            //var context = localPluginContext.PluginExecutionContext;
            //var service = localPluginContext.OrganizationService;
            IPluginExecutionContext context = localPluginContext.PluginExecutionContext;
            //IOrganizationServiceFactory factory = (IOrganizationServiceFactory)serviceProvider.GetService(typeof(IOrganizationServiceFactory));
            //IPluginExecutionContext context = localContext.PluginExecutionContext;
            //IOrganizationService organizationService = localContext.OrganizationService;
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
                    /*Workbook workbook = new Workbook(ms);
                    workbook.Save(filePath + “.out.xlsx”);
                    workbook.Save(filePath + “.out.pdf”, SaveFormat.Pdf);*/
                    var doc = SpreadsheetDocument.Open(ms, false);
                    WorkbookPart workbookPart = doc.WorkbookPart;
                    WorksheetPart worksheetPart = workbookPart.WorksheetParts.First();
                    SheetData thisSheet = worksheetPart.Worksheet.Elements<SheetData>().First();
                    System.Text.StringBuilder text = new System.Text.StringBuilder();
                    List<string> actualColumnName = new List<string>();
                    for (int i = 1; i < thisSheet.Elements<Row>().Count(); i++)
                    {
                        var contactId = Guid.TryParse(ReadExcelCell(thisSheet.Elements<Row>().ElementAt(i).Elements<Cell>().ElementAt(4), workbookPart), out var newGuid);
                        if (contactId)
                        {
                            for (int j = 0; j < thisSheet.Elements<Row>().ElementAt(i).Elements<Cell>().Count(); j++)
                            {
                                var c = thisSheet.Elements<Row>().ElementAt(0).Elements<Cell>().ElementAt(4);
                                if (i == 0)
                                {
                                    string value = c.InnerText;
                                    actualColumnName.Add(value);
                                    if (c.DataType.Value == CellValues.SharedString)
                                    {
                                        /* var stringTable = workbookPart.GetPartsOfType<SharedStringTablePart>()
                                             .FirstOrDefault();
                                         if (stringTable != null)
                                             value = stringTable.SharedStringTable.ElementAt(int.Parse(value)).InnerText;
                                         columnName.Add(value);*/
                                    }
                                }
                            }
                            var contact = new Entity("contact", newGuid);
                            bool isChanged = false;
                            var actualContact = organizationService.Retrieve(contact.LogicalName, newGuid, new ColumnSet("fullname", "emailaddress1", "telephone1", "statecode"));
                            var fullname = ReadExcelCell(thisSheet.Elements<Row>().ElementAt(i).Elements<Cell>().ElementAt(0), workbookPart);
                            var email = ReadExcelCell(thisSheet.Elements<Row>().ElementAt(i).Elements<Cell>().ElementAt(1), workbookPart);
                            var phone = ReadExcelCell(thisSheet.Elements<Row>().ElementAt(i).Elements<Cell>().ElementAt(2), workbookPart);
                            //var status = ReadExcelCell(thisSheet.Elements<Row>().ElementAt(i).Elements<Cell>().ElementAt(2), workbookPart);
                            if (fullname != (string)actualContact["fullname"])
                            {
                                contact["fullname"] = fullname;
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
                            if (isChanged)
                                organizationService.Update(contact);
                        }
                        else
                        {
                            //add to responce
                        }
                        var contacta = new Entity("contact", newGuid);
                        var afterContact = organizationService.Retrieve(contacta.LogicalName, newGuid, new ColumnSet("fullname", "emailaddress1", "telephone1", "statecode"));
                    }
                }
            }
            //return JsonConvert.SerializeObject(gateProcessDto).ToCustomEntityCollection();
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
        private void ValidateRecords(Guid referralId, IOrganizationService service)
        {
        }
        private bool isExist(Guid referralId, IOrganizationService service)
        {
            return true;
        }
        private void UpdateRecord(Guid referralId, IOrganizationService service)
        {
        }
        private void ParseExel(Guid referralId, IOrganizationService service)
        {
        }
    }
}