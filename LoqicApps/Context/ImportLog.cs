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
	
	[System.Runtime.Serialization.DataContractAttribute()]
	public enum ImportLogState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
	}
	
	/// <summary>
	/// Failure reason and other detailed information for a record that failed to import.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("importlog")]
	public partial class ImportLog : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string AdditionalInfo = "additionalinfo";
			public const string ColumnValue = "columnvalue";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ErrorDescription = "errordescription";
			public const string ErrorNumber = "errornumber";
			public const string HeaderColumn = "headercolumn";
			public const string ImportDataId = "importdataid";
			public const string ImportFileId = "importfileid";
			public const string ImportLogId = "importlogid";
			public const string Id = "importlogid";
			public const string LineNumber = "linenumber";
			public const string LogPhaseCode = "logphasecode";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string SequenceNumber = "sequencenumber";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string BusinessUnit_ImportLogs = "BusinessUnit_ImportLogs";
			public const string ImportLog_ImportData = "ImportLog_ImportData";
			public const string ImportLog_ImportFile = "ImportLog_ImportFile";
			public const string lk_importlog_createdonbehalfby = "lk_importlog_createdonbehalfby";
			public const string lk_importlog_modifiedonbehalfby = "lk_importlog_modifiedonbehalfby";
			public const string lk_importlogbase_createdby = "lk_importlogbase_createdby";
			public const string lk_importlogbase_modifiedby = "lk_importlogbase_modifiedby";
			public const string owner_importlogs = "owner_importlogs";
			public const string SystemUser_ImportLogs = "SystemUser_ImportLogs";
			public const string team_ImportLogs = "team_ImportLogs";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ImportLog() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "importlog";
		
		public const string EntitySchemaName = "ImportLog";
		
		public const string PrimaryIdAttribute = "importlogid";
		
		public const string EntityLogicalCollectionName = "importlogs";
		
		public const string EntitySetName = "importlogs";
		
		public const int EntityTypeCode = 4423;
		
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
		/// Additional information related to the error.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("additionalinfo")]
		public string AdditionalInfo
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("additionalinfo");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AdditionalInfo");
				this.SetAttributeValue("additionalinfo", value);
				this.OnPropertyChanged("AdditionalInfo");
			}
		}
		
		/// <summary>
		/// Value in the column.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("columnvalue")]
		public string ColumnValue
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("columnvalue");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ColumnValue");
				this.SetAttributeValue("columnvalue", value);
				this.OnPropertyChanged("ColumnValue");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the import log.
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
		/// Date and time when the import log was created.
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
		/// Unique identifier of the delegate user who created the importlog.
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
		/// Description of an error.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("errordescription")]
		public string ErrorDescription
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("errordescription");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ErrorDescription");
				this.SetAttributeValue("errordescription", value);
				this.OnPropertyChanged("ErrorDescription");
			}
		}
		
		/// <summary>
		/// Error code of an error.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("errornumber")]
		public System.Nullable<int> ErrorNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("errornumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ErrorNumber");
				this.SetAttributeValue("errornumber", value);
				this.OnPropertyChanged("ErrorNumber");
			}
		}
		
		/// <summary>
		/// Name of the column heading.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("headercolumn")]
		public string HeaderColumn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("headercolumn");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("HeaderColumn");
				this.SetAttributeValue("headercolumn", value);
				this.OnPropertyChanged("HeaderColumn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the import data for this import log.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importdataid")]
		public Microsoft.Xrm.Sdk.EntityReference ImportDataId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("importdataid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportDataId");
				this.SetAttributeValue("importdataid", value);
				this.OnPropertyChanged("ImportDataId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the import file for this import log.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importfileid")]
		public Microsoft.Xrm.Sdk.EntityReference ImportFileId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("importfileid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportFileId");
				this.SetAttributeValue("importfileid", value);
				this.OnPropertyChanged("ImportFileId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the import log.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importlogid")]
		public System.Nullable<System.Guid> ImportLogId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("importlogid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportLogId");
				this.SetAttributeValue("importlogid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ImportLogId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importlogid")]
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
				this.ImportLogId = value;
			}
		}
		
		/// <summary>
		/// Original line number of the data used in this log.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("linenumber")]
		public System.Nullable<int> LineNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("linenumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LineNumber");
				this.SetAttributeValue("linenumber", value);
				this.OnPropertyChanged("LineNumber");
			}
		}
		
		/// <summary>
		/// Phase for which the log is recorded.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("logphasecode")]
		public virtual ImportLog_LogPhaseCode? LogPhaseCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ImportLog_LogPhaseCode?)(EntityOptionSetEnum.GetEnum(this, "logphasecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("LogPhaseCode");
				this.SetAttributeValue("logphasecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("LogPhaseCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the import log.
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
		/// Date and time when the import log was last modified.
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
		/// Unique identifier of the delegate user who last modified the importlog.
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
		/// Unique identifier of the user or team who owns the import log.
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
		/// Business unit that owns the import log.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public Microsoft.Xrm.Sdk.EntityReference OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Unique identifier of the team who owns the import log.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who owns the import log.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
		}
		
		/// <summary>
		/// Sequence number of the error in this log.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sequencenumber")]
		public System.Nullable<int> SequenceNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("sequencenumber");
			}
		}
		
		/// <summary>
		/// Status of the import log.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<CrmEarlyBound.ImportLogState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((CrmEarlyBound.ImportLogState)(System.Enum.ToObject(typeof(CrmEarlyBound.ImportLogState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
		}
		
		/// <summary>
		/// Reason for the status of the import log.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual ImportLog_StatusCode? StatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ImportLog_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StatusCode");
				this.SetAttributeValue("statuscode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("StatusCode");
			}
		}
		
		/// <summary>
		/// 1:N ImportLog_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportLog_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.AsyncOperation> ImportLog_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.AsyncOperation>("ImportLog_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportLog_AsyncOperations");
				this.SetRelatedEntities<CrmEarlyBound.AsyncOperation>("ImportLog_AsyncOperations", null, value);
				this.OnPropertyChanged("ImportLog_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N ImportLog_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportLog_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.BulkDeleteFailure> ImportLog_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.BulkDeleteFailure>("ImportLog_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportLog_BulkDeleteFailures");
				this.SetRelatedEntities<CrmEarlyBound.BulkDeleteFailure>("ImportLog_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("ImportLog_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_importlog
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_importlog")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> userentityinstancedata_importlog
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_importlog", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_importlog");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_importlog", null, value);
				this.OnPropertyChanged("userentityinstancedata_importlog");
			}
		}
		
		/// <summary>
		/// N:1 BusinessUnit_ImportLogs
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("BusinessUnit_ImportLogs")]
		public CrmEarlyBound.BusinessUnit BusinessUnit_ImportLogs
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.BusinessUnit>("BusinessUnit_ImportLogs", null);
			}
		}
		
		/// <summary>
		/// N:1 ImportLog_ImportData
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importdataid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportLog_ImportData")]
		public CrmEarlyBound.ImportData ImportLog_ImportData
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.ImportData>("ImportLog_ImportData", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportLog_ImportData");
				this.SetRelatedEntity<CrmEarlyBound.ImportData>("ImportLog_ImportData", null, value);
				this.OnPropertyChanged("ImportLog_ImportData");
			}
		}
		
		/// <summary>
		/// N:1 ImportLog_ImportFile
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importfileid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ImportLog_ImportFile")]
		public CrmEarlyBound.ImportFile ImportLog_ImportFile
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.ImportFile>("ImportLog_ImportFile", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportLog_ImportFile");
				this.SetRelatedEntity<CrmEarlyBound.ImportFile>("ImportLog_ImportFile", null, value);
				this.OnPropertyChanged("ImportLog_ImportFile");
			}
		}
		
		/// <summary>
		/// N:1 lk_importlog_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importlog_createdonbehalfby")]
		public CrmEarlyBound.SystemUser lk_importlog_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_importlog_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_importlog_createdonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_importlog_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_importlog_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_importlog_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importlog_modifiedonbehalfby")]
		public CrmEarlyBound.SystemUser lk_importlog_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_importlog_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_importlog_modifiedonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_importlog_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_importlog_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_importlogbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importlogbase_createdby")]
		public CrmEarlyBound.SystemUser lk_importlogbase_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_importlogbase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_importlogbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_importlogbase_modifiedby")]
		public CrmEarlyBound.SystemUser lk_importlogbase_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_importlogbase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 owner_importlogs
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("owner_importlogs")]
		public CrmEarlyBound.Owner owner_importlogs
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Owner>("owner_importlogs", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("owner_importlogs");
				this.SetRelatedEntity<CrmEarlyBound.Owner>("owner_importlogs", null, value);
				this.OnPropertyChanged("owner_importlogs");
			}
		}
		
		/// <summary>
		/// N:1 SystemUser_ImportLogs
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("SystemUser_ImportLogs")]
		public CrmEarlyBound.SystemUser SystemUser_ImportLogs
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("SystemUser_ImportLogs", null);
			}
		}
		
		/// <summary>
		/// N:1 team_ImportLogs
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_ImportLogs")]
		public CrmEarlyBound.Team team_ImportLogs
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Team>("team_ImportLogs", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ImportLog(object anonymousType) : 
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
                        Attributes["importlogid"] = base.Id;
                        break;
                    case "importlogid":
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