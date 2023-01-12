//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace CrmEarlyBound
{
	
	/// <summary>
	/// Used to store Office Documents in database in binary format.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("officedocument")]
	public partial class OfficeDocument : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ClientData = "clientdata";
			public const string Content = "content";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string DocumentType = "documenttype";
			public const string FileLockState = "filelockstate";
			public const string FileSize = "filesize";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string ObjectId = "objectid";
			public const string OfficeDocumentId = "officedocumentid";
			public const string Id = "officedocumentid";
			public const string OwnerId = "ownerid";
			public const string SHA256 = "sha256";
			public const string VersionNumber = "versionnumber";
			public const string lk_officedocumentbase_createdonbehalfby = "lk_officedocumentbase_createdonbehalfby";
			public const string lk_officedocumentbase_modifiedonbehalfby = "lk_officedocumentbase_modifiedonbehalfby";
			public const string owner_officedocument = "owner_officedocument";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public OfficeDocument() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "officedocument";
		
		public const string EntitySchemaName = "OfficeDocument";
		
		public const string PrimaryIdAttribute = "officedocumentid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const string EntityLogicalCollectionName = "officedocuments";
		
		public const string EntitySetName = "officedocuments";
		
		public const int EntityTypeCode = 4490;
		
		public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
		
		public event System.ComponentModel.PropertyChangingEventHandler PropertyChanging;
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanged(string propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}
		
		[System.Diagnostics.DebuggerNonUserCode()]
		private void OnPropertyChanging(string propertyName)
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, new System.ComponentModel.PropertyChangingEventArgs(propertyName));
			}
		}
		
		/// <summary>
		/// Client data regarding this office document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("clientdata")]
		public string ClientData
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("clientdata");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ClientData");
				this.SetAttributeValue("clientdata", value);
				this.OnPropertyChanged("ClientData");
			}
		}
		
		/// <summary>
		/// Bytes of the office document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("content")]
		public string Content
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("content");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Content");
				this.SetAttributeValue("content", value);
				this.OnPropertyChanged("Content");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the office document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdby");
			}
		}
		
		/// <summary>
		/// Date and time when the office document was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdon")]
		public System.Nullable<System.DateTime> CreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createdon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who created the office document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CreatedOnBehalfBy");
				this.SetAttributeValue("createdonbehalfby", value);
				this.OnPropertyChanged("CreatedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Option set for selecting the type of the office document
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("documenttype")]
		public virtual officedocument_DocumentType? DocumentType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((officedocument_DocumentType?)(EntityOptionSetEnum.GetEnum(this, "documenttype")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DocumentType");
				this.SetAttributeValue("documenttype", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("DocumentType");
			}
		}
		
		/// <summary>
		/// Lock state of file.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filelockstate")]
		public System.Nullable<int> FileLockState
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("filelockstate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FileLockState");
				this.SetAttributeValue("filelockstate", value);
				this.OnPropertyChanged("FileLockState");
			}
		}
		
		/// <summary>
		/// File Size.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("filesize")]
		public System.Nullable<int> FileSize
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("filesize");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FileSize");
				this.SetAttributeValue("filesize", value);
				this.OnPropertyChanged("FileSize");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the office document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedby");
			}
		}
		
		/// <summary>
		/// Date and time when the office document was last modified.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedon")]
		public System.Nullable<System.DateTime> ModifiedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("modifiedon");
			}
		}
		
		/// <summary>
		/// Unique identifier of the delegate user who modified the office document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedOnBehalfBy
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedonbehalfby");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ModifiedOnBehalfBy");
				this.SetAttributeValue("modifiedonbehalfby", value);
				this.OnPropertyChanged("ModifiedOnBehalfBy");
			}
		}
		
		/// <summary>
		/// Name of the office document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("Name");
			}
		}
		
		/// <summary>
		/// Object Id.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("objectid")]
		public Microsoft.Xrm.Sdk.EntityReference ObjectId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("objectid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ObjectId");
				this.SetAttributeValue("objectid", value);
				this.OnPropertyChanged("ObjectId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the office document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("officedocumentid")]
		public System.Nullable<System.Guid> OfficeDocumentId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("officedocumentid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OfficeDocumentId");
				this.SetAttributeValue("officedocumentid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("OfficeDocumentId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("officedocumentid")]
		public override System.Guid Id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return base.Id;
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OfficeDocumentId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the user or team who owns the office document.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwnerId");
				this.SetAttributeValue("ownerid", value);
				this.OnPropertyChanged("OwnerId");
			}
		}
		
		/// <summary>
		/// Stores the SHA256 Hash key value.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sha256")]
		public string SHA256
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("sha256");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SHA256");
				this.SetAttributeValue("sha256", value);
				this.OnPropertyChanged("SHA256");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("versionnumber")]
		public System.Nullable<long> VersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("versionnumber");
			}
		}
		
		/// <summary>
		/// N:1 lk_officedocumentbase_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_officedocumentbase_createdonbehalfby")]
		public CrmEarlyBound.SystemUser lk_officedocumentbase_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_officedocumentbase_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_officedocumentbase_createdonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_officedocumentbase_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_officedocumentbase_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_officedocumentbase_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_officedocumentbase_modifiedonbehalfby")]
		public CrmEarlyBound.SystemUser lk_officedocumentbase_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_officedocumentbase_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_officedocumentbase_modifiedonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_officedocumentbase_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_officedocumentbase_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 owner_officedocument
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("owner_officedocument")]
		public CrmEarlyBound.Owner owner_officedocument
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Owner>("owner_officedocument", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("owner_officedocument");
				this.SetRelatedEntity<CrmEarlyBound.Owner>("owner_officedocument", null, value);
				this.OnPropertyChanged("owner_officedocument");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public OfficeDocument(object anonymousType) : 
				this()
		{
            foreach (var p in anonymousType.GetType().GetProperties())
            {
                var value = p.GetValue(anonymousType, null);
                var name = p.Name.ToLower();
            
                if (name.EndsWith("enum") && value.GetType().BaseType == typeof(System.Enum))
                {
                    value = new Microsoft.Xrm.Sdk.OptionSetValue((int) value);
                    name = name.Remove(name.Length - "enum".Length);
                }
            
                switch (name)
                {
                    case "id":
                        base.Id = (System.Guid)value;
                        Attributes["officedocumentid"] = base.Id;
                        break;
                    case "officedocumentid":
                        var id = (System.Nullable<System.Guid>) value;
                        if(id == null){ continue; }
                        base.Id = id.Value;
                        Attributes[name] = base.Id;
                        break;
                    case "formattedvalues":
                        // Add Support for FormattedValues
                        FormattedValues.AddRange((Microsoft.Xrm.Sdk.FormattedValueCollection)value);
                        break;
                    default:
                        Attributes[name] = value;
                        break;
                }
            }
		}
	}
}