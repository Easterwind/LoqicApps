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
	/// Stage associated with a process.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("processstage")]
	public partial class ProcessStage : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ClientData = "clientdata";
			public const string Connector = "connector";
			public const string IsTrigger = "istrigger";
			public const string OperationId = "operationid";
			public const string OperationKind = "operationkind";
			public const string OperationType = "operationtype";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string PrimaryEntityTypeCode = "primaryentitytypecode";
			public const string ProcessId = "processid";
			public const string ProcessStageId = "processstageid";
			public const string Id = "processstageid";
			public const string StageCategory = "stagecategory";
			public const string StageName = "stagename";
			public const string VersionNumber = "versionnumber";
			public const string process_processstage = "process_processstage";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ProcessStage() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "processstage";
		
		public const string EntitySchemaName = "ProcessStage";
		
		public const string PrimaryIdAttribute = "processstageid";
		
		public const string PrimaryNameAttribute = "stagename";
		
		public const string EntityLogicalCollectionName = "processstages";
		
		public const string EntitySetName = "processstages";
		
		public const int EntityTypeCode = 4724;
		
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
		/// Step metadata for process stage
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("clientdata")]
		public string ClientData
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("clientdata");
			}
		}
		
		/// <summary>
		/// The connector associated with the stage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("connector")]
		public string Connector
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("connector");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Connector");
				this.SetAttributeValue("connector", value);
				this.OnPropertyChanged("Connector");
			}
		}
		
		/// <summary>
		/// Whether the stage is a trigger
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("istrigger")]
		public System.Nullable<bool> IsTrigger
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("istrigger");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsTrigger");
				this.SetAttributeValue("istrigger", value);
				this.OnPropertyChanged("IsTrigger");
			}
		}
		
		/// <summary>
		/// The operation id of the stage
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("operationid")]
		public string OperationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("operationid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OperationId");
				this.SetAttributeValue("operationid", value);
				this.OnPropertyChanged("OperationId");
			}
		}
		
		/// <summary>
		/// The operation kind
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("operationkind")]
		public virtual ProcessStage_OperationKind? OperationKind
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ProcessStage_OperationKind?)(EntityOptionSetEnum.GetEnum(this, "operationkind")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OperationKind");
				this.SetAttributeValue("operationkind", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("OperationKind");
			}
		}
		
		/// <summary>
		/// The type of the operation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("operationtype")]
		public virtual ProcessStage_OperationType? OperationType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ProcessStage_OperationType?)(EntityOptionSetEnum.GetEnum(this, "operationtype")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OperationType");
				this.SetAttributeValue("operationtype", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("OperationType");
			}
		}
		
		/// <summary>
		/// Enter the user or team who is assigned to manage the record. This field is updated every time the record is assigned to a different user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		public Microsoft.Xrm.Sdk.EntityReference OwnerId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("ownerid");
			}
		}
		
		/// <summary>
		/// Select the business unit that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		public System.Nullable<System.Guid> OwningBusinessUnit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("owningbusinessunit");
			}
		}
		
		/// <summary>
		/// Primary entity associated with the stage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("primaryentitytypecode")]
		public string PrimaryEntityTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("primaryentitytypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PrimaryEntityTypeCode");
				this.SetAttributeValue("primaryentitytypecode", value);
				this.OnPropertyChanged("PrimaryEntityTypeCode");
			}
		}
		
		/// <summary>
		/// Shows the ID of the process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		public Microsoft.Xrm.Sdk.EntityReference ProcessId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("processid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProcessId");
				this.SetAttributeValue("processid", value);
				this.OnPropertyChanged("ProcessId");
			}
		}
		
		/// <summary>
		/// Shows the ID of the process stage record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processstageid")]
		public System.Nullable<System.Guid> ProcessStageId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("processstageid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProcessStageId");
				this.SetAttributeValue("processstageid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ProcessStageId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processstageid")]
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
				this.ProcessStageId = value;
			}
		}
		
		/// <summary>
		/// Select the category of the sales process.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stagecategory")]
		public virtual Processstage_Category? StageCategory
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((Processstage_Category?)(EntityOptionSetEnum.GetEnum(this, "stagecategory")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StageCategory");
				this.SetAttributeValue("stagecategory", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("StageCategory");
			}
		}
		
		/// <summary>
		/// Type a name for the process stage.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("stagename")]
		public string StageName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("stagename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StageName");
				this.SetAttributeValue("stagename", value);
				this.OnPropertyChanged("StageName");
			}
		}
		
		/// <summary>
		/// Version number of the process stage.
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
		/// 1:N lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_activestageid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_activestageid")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.adx_bpf_c2857b638fa7473d8e2f112c232cebd8> lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_activestageid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.adx_bpf_c2857b638fa7473d8e2f112c232cebd8>("lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_activestageid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_activestageid");
				this.SetRelatedEntities<CrmEarlyBound.adx_bpf_c2857b638fa7473d8e2f112c232cebd8>("lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_activestageid", null, value);
				this.OnPropertyChanged("lk_adx_bpf_c2857b638fa7473d8e2f112c232cebd8_activestageid");
			}
		}
		
		/// <summary>
		/// 1:N lk_expiredprocess_activestageid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_expiredprocess_activestageid")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.ExpiredProcess> lk_expiredprocess_activestageid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.ExpiredProcess>("lk_expiredprocess_activestageid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_expiredprocess_activestageid");
				this.SetRelatedEntities<CrmEarlyBound.ExpiredProcess>("lk_expiredprocess_activestageid", null, value);
				this.OnPropertyChanged("lk_expiredprocess_activestageid");
			}
		}
		
		/// <summary>
		/// 1:N lk_newprocess_activestageid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_newprocess_activestageid")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.NewProcess> lk_newprocess_activestageid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.NewProcess>("lk_newprocess_activestageid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_newprocess_activestageid");
				this.SetRelatedEntities<CrmEarlyBound.NewProcess>("lk_newprocess_activestageid", null, value);
				this.OnPropertyChanged("lk_newprocess_activestageid");
			}
		}
		
		/// <summary>
		/// 1:N lk_translationprocess_activestageid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_translationprocess_activestageid")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.TranslationProcess> lk_translationprocess_activestageid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.TranslationProcess>("lk_translationprocess_activestageid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_translationprocess_activestageid");
				this.SetRelatedEntities<CrmEarlyBound.TranslationProcess>("lk_translationprocess_activestageid", null, value);
				this.OnPropertyChanged("lk_translationprocess_activestageid");
			}
		}
		
		/// <summary>
		/// 1:N processstage_account
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_account")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.Account> processstage_account
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.Account>("processstage_account", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_account");
				this.SetRelatedEntities<CrmEarlyBound.Account>("processstage_account", null, value);
				this.OnPropertyChanged("processstage_account");
			}
		}
		
		/// <summary>
		/// 1:N processstage_adx_portalcomment
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_adx_portalcomment")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.adx_portalcomment> processstage_adx_portalcomment
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.adx_portalcomment>("processstage_adx_portalcomment", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_adx_portalcomment");
				this.SetRelatedEntities<CrmEarlyBound.adx_portalcomment>("processstage_adx_portalcomment", null, value);
				this.OnPropertyChanged("processstage_adx_portalcomment");
			}
		}
		
		/// <summary>
		/// 1:N processstage_appointments
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_appointments")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.Appointment> processstage_appointments
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.Appointment>("processstage_appointments", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_appointments");
				this.SetRelatedEntities<CrmEarlyBound.Appointment>("processstage_appointments", null, value);
				this.OnPropertyChanged("processstage_appointments");
			}
		}
		
		/// <summary>
		/// 1:N processstage_contact
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_contact")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.Contact> processstage_contact
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.Contact>("processstage_contact", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_contact");
				this.SetRelatedEntities<CrmEarlyBound.Contact>("processstage_contact", null, value);
				this.OnPropertyChanged("processstage_contact");
			}
		}
		
		/// <summary>
		/// 1:N processstage_emails
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_emails")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.Email> processstage_emails
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.Email>("processstage_emails", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_emails");
				this.SetRelatedEntities<CrmEarlyBound.Email>("processstage_emails", null, value);
				this.OnPropertyChanged("processstage_emails");
			}
		}
		
		/// <summary>
		/// 1:N processstage_faxes
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_faxes")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.Fax> processstage_faxes
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.Fax>("processstage_faxes", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_faxes");
				this.SetRelatedEntities<CrmEarlyBound.Fax>("processstage_faxes", null, value);
				this.OnPropertyChanged("processstage_faxes");
			}
		}
		
		/// <summary>
		/// 1:N processstage_knowledgearticle
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_knowledgearticle")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.KnowledgeArticle> processstage_knowledgearticle
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.KnowledgeArticle>("processstage_knowledgearticle", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_knowledgearticle");
				this.SetRelatedEntities<CrmEarlyBound.KnowledgeArticle>("processstage_knowledgearticle", null, value);
				this.OnPropertyChanged("processstage_knowledgearticle");
			}
		}
		
		/// <summary>
		/// 1:N processstage_letters
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_letters")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.Letter> processstage_letters
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.Letter>("processstage_letters", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_letters");
				this.SetRelatedEntities<CrmEarlyBound.Letter>("processstage_letters", null, value);
				this.OnPropertyChanged("processstage_letters");
			}
		}
		
		/// <summary>
		/// 1:N processstage_phonecalls
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_phonecalls")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.PhoneCall> processstage_phonecalls
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.PhoneCall>("processstage_phonecalls", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_phonecalls");
				this.SetRelatedEntities<CrmEarlyBound.PhoneCall>("processstage_phonecalls", null, value);
				this.OnPropertyChanged("processstage_phonecalls");
			}
		}
		
		/// <summary>
		/// 1:N processstage_processstageparameter
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_processstageparameter")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.processstageparameter> processstage_processstageparameter
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.processstageparameter>("processstage_processstageparameter", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_processstageparameter");
				this.SetRelatedEntities<CrmEarlyBound.processstageparameter>("processstage_processstageparameter", null, value);
				this.OnPropertyChanged("processstage_processstageparameter");
			}
		}
		
		/// <summary>
		/// 1:N processstage_recurringappointmentmasters
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_recurringappointmentmasters")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.RecurringAppointmentMaster> processstage_recurringappointmentmasters
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.RecurringAppointmentMaster>("processstage_recurringappointmentmasters", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_recurringappointmentmasters");
				this.SetRelatedEntities<CrmEarlyBound.RecurringAppointmentMaster>("processstage_recurringappointmentmasters", null, value);
				this.OnPropertyChanged("processstage_recurringappointmentmasters");
			}
		}
		
		/// <summary>
		/// 1:N ProcessStage_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ProcessStage_SyncErrors")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.SyncError> ProcessStage_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.SyncError>("ProcessStage_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProcessStage_SyncErrors");
				this.SetRelatedEntities<CrmEarlyBound.SyncError>("ProcessStage_SyncErrors", null, value);
				this.OnPropertyChanged("ProcessStage_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N processstage_systemusers
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_systemusers")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.SystemUser> processstage_systemusers
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.SystemUser>("processstage_systemusers", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_systemusers");
				this.SetRelatedEntities<CrmEarlyBound.SystemUser>("processstage_systemusers", null, value);
				this.OnPropertyChanged("processstage_systemusers");
			}
		}
		
		/// <summary>
		/// 1:N processstage_tasks
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_tasks")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.Task> processstage_tasks
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.Task>("processstage_tasks", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_tasks");
				this.SetRelatedEntities<CrmEarlyBound.Task>("processstage_tasks", null, value);
				this.OnPropertyChanged("processstage_tasks");
			}
		}
		
		/// <summary>
		/// 1:N processstage_teams
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("processstage_teams")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.Team> processstage_teams
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.Team>("processstage_teams", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("processstage_teams");
				this.SetRelatedEntities<CrmEarlyBound.Team>("processstage_teams", null, value);
				this.OnPropertyChanged("processstage_teams");
			}
		}
		
		/// <summary>
		/// N:1 process_processstage
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("processid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("process_processstage")]
		public CrmEarlyBound.Workflow process_processstage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Workflow>("process_processstage", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("process_processstage");
				this.SetRelatedEntity<CrmEarlyBound.Workflow>("process_processstage", null, value);
				this.OnPropertyChanged("process_processstage");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ProcessStage(object anonymousType) : 
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
                        Attributes["processstageid"] = base.Id;
                        break;
                    case "processstageid":
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