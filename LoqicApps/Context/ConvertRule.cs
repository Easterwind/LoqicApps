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
	public enum ConvertRuleState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Draft = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 1,
	}
	
	/// <summary>
	/// Defines the settings for automatic record creation.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("convertrule")]
	public partial class ConvertRule : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string AllowUnknownSender = "allowunknownsender";
			public const string ChannelPropertyGroupId = "channelpropertygroupid";
			public const string CheckActiveEntitlement = "checkactiveentitlement";
			public const string CheckBlockedSocialProfile = "checkblockedsocialprofile";
			public const string CheckDirectMessages = "checkdirectmessages";
			public const string CheckIfResolved = "checkifresolved";
			public const string ComponentState = "componentstate";
			public const string ConvertRuleId = "convertruleid";
			public const string Id = "convertruleid";
			public const string ConvertRuleIdUnique = "convertruleidunique";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string ExchangeRate = "exchangerate";
			public const string IsManaged = "ismanaged";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OverwriteTime = "overwritetime";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string QueueId = "queueid";
			public const string RecordVersion = "recordversion";
			public const string ResolvedSince = "resolvedsince";
			public const string ResponseTemplateId = "responsetemplateid";
			public const string SendAutomaticResponse = "sendautomaticresponse";
			public const string SolutionId = "solutionid";
			public const string SourceChannelTypeCode = "sourcechanneltypecode";
			public const string SourceTypeCode = "sourcetypecode";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string VersionNumber = "versionnumber";
			public const string WorkflowId = "workflowid";
			public const string business_unit_convertrule = "business_unit_convertrule";
			public const string channelpropertygroup_convertrule = "channelpropertygroup_convertrule";
			public const string convertrule_queue = "convertrule_queue";
			public const string emailtemplate_convertrule = "emailtemplate_convertrule";
			public const string lk_convertrule_createdby = "lk_convertrule_createdby";
			public const string lk_ConvertRule_createdonbehalfby = "lk_ConvertRule_createdonbehalfby";
			public const string lk_ConvertRule_modifiedby = "lk_ConvertRule_modifiedby";
			public const string lk_ConvertRule_modifiedonbehalfby = "lk_ConvertRule_modifiedonbehalfby";
			public const string owner_convertrule = "owner_convertrule";
			public const string team_convertrule = "team_convertrule";
			public const string TransactionCurrency_ConvertRule = "TransactionCurrency_ConvertRule";
			public const string user_convertrule = "user_convertrule";
			public const string workflowid_convertrule = "workflowid_convertrule";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ConvertRule() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "convertrule";
		
		public const string EntitySchemaName = "ConvertRule";
		
		public const string PrimaryIdAttribute = "convertruleid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const string EntityLogicalCollectionName = "convertrules";
		
		public const string EntitySetName = "convertrules";
		
		public const int EntityTypeCode = 9300;
		
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
		/// Choose whether items from unknown senders should be converted to records.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowunknownsender")]
		public System.Nullable<bool> AllowUnknownSender
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("allowunknownsender");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AllowUnknownSender");
				this.SetAttributeValue("allowunknownsender", value);
				this.OnPropertyChanged("AllowUnknownSender");
			}
		}
		
		/// <summary>
		/// channel property group associated with the convert rule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("channelpropertygroupid")]
		public Microsoft.Xrm.Sdk.EntityReference ChannelPropertyGroupId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("channelpropertygroupid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ChannelPropertyGroupId");
				this.SetAttributeValue("channelpropertygroupid", value);
				this.OnPropertyChanged("ChannelPropertyGroupId");
			}
		}
		
		/// <summary>
		/// Choose whether cases should be created for customers with active entitlements.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("checkactiveentitlement")]
		public System.Nullable<bool> CheckActiveEntitlement
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("checkactiveentitlement");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CheckActiveEntitlement");
				this.SetAttributeValue("checkactiveentitlement", value);
				this.OnPropertyChanged("CheckActiveEntitlement");
			}
		}
		
		/// <summary>
		/// Information whether record needs to be created for black listed social profiles.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("checkblockedsocialprofile")]
		public System.Nullable<bool> CheckBlockedSocialProfile
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("checkblockedsocialprofile");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CheckBlockedSocialProfile");
				this.SetAttributeValue("checkblockedsocialprofile", value);
				this.OnPropertyChanged("CheckBlockedSocialProfile");
			}
		}
		
		/// <summary>
		/// Information whether record needs to be created for direct messages.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("checkdirectmessages")]
		public System.Nullable<bool> CheckDirectMessages
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("checkdirectmessages");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CheckDirectMessages");
				this.SetAttributeValue("checkdirectmessages", value);
				this.OnPropertyChanged("CheckDirectMessages");
			}
		}
		
		/// <summary>
		/// Choose whether an item related to a resolved case should be converted to a case.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("checkifresolved")]
		public System.Nullable<bool> CheckIfResolved
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("checkifresolved");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CheckIfResolved");
				this.SetAttributeValue("checkifresolved", value);
				this.OnPropertyChanged("CheckIfResolved");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public virtual ComponentState? ComponentState
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ComponentState?)(EntityOptionSetEnum.GetEnum(this, "componentstate")));
			}
		}
		
		/// <summary>
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("convertruleid")]
		public System.Nullable<System.Guid> ConvertRuleId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("convertruleid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ConvertRuleId");
				this.SetAttributeValue("convertruleid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("ConvertRuleId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("convertruleid")]
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
				this.ConvertRuleId = value;
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("convertruleidunique")]
		public System.Nullable<System.Guid> ConvertRuleIdUnique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("convertruleidunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the record.
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
		/// Date and time when the record was created.
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
		/// Unique identifier of the delegate user who created the record.
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
		/// Type additional information to describe the rule for creating records automatically.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Exchange rate for the currency associated with the queue with respect to the base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ismanaged")]
		public System.Nullable<bool> IsManaged
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("ismanaged");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who modified the record.
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
		/// Date and time when the record was modified.
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
		/// Unique identifier of the delegate user who modified the record.
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
		/// Type a title or name of the queue for which the setting is defined.
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
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overwritetime")]
		public System.Nullable<System.DateTime> OverwriteTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overwritetime");
			}
		}
		
		/// <summary>
		/// Owner Id
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
		/// Shows the business unit that the convert rule owner belongs to.
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
		/// Unique identifier for the team that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		public Microsoft.Xrm.Sdk.EntityReference OwningTeam
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owningteam");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningTeam");
				this.SetAttributeValue("owningteam", value);
				this.OnPropertyChanged("OwningTeam");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user that owns the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		public Microsoft.Xrm.Sdk.EntityReference OwningUser
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("owninguser");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OwningUser");
				this.SetAttributeValue("owninguser", value);
				this.OnPropertyChanged("OwningUser");
			}
		}
		
		/// <summary>
		/// Choose the queue that the rule is assigned to.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
		public Microsoft.Xrm.Sdk.EntityReference QueueId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("queueid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("QueueId");
				this.SetAttributeValue("queueid", value);
				this.OnPropertyChanged("QueueId");
			}
		}
		
		/// <summary>
		/// Record Version
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("recordversion")]
		public string RecordVersion
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("recordversion");
			}
		}
		
		/// <summary>
		/// If you want to create a new case for an item associated with a resolved case, type how long a case must remain resolved before a new case is created for the associated item.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resolvedsince")]
		public System.Nullable<int> ResolvedSince
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("resolvedsince");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ResolvedSince");
				this.SetAttributeValue("resolvedsince", value);
				this.OnPropertyChanged("ResolvedSince");
			}
		}
		
		/// <summary>
		/// Choose the email template to use to create an automatic response to the customer.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("responsetemplateid")]
		public Microsoft.Xrm.Sdk.EntityReference ResponseTemplateId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("responsetemplateid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ResponseTemplateId");
				this.SetAttributeValue("responsetemplateid", value);
				this.OnPropertyChanged("ResponseTemplateId");
			}
		}
		
		/// <summary>
		/// Choose whether to send an automatic email response to the customer after a record is created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sendautomaticresponse")]
		public System.Nullable<bool> SendAutomaticResponse
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("sendautomaticresponse");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SendAutomaticResponse");
				this.SetAttributeValue("sendautomaticresponse", value);
				this.OnPropertyChanged("SendAutomaticResponse");
			}
		}
		
		/// <summary>
		/// Unique identifier of the associated solution.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("solutionid")]
		public System.Nullable<System.Guid> SolutionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("solutionid");
			}
		}
		
		/// <summary>
		/// Identifies the Dynamics 365 activity that's the source of the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourcechanneltypecode")]
		public string SourceChannelTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("sourcechanneltypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SourceChannelTypeCode");
				this.SetAttributeValue("sourcechanneltypecode", value);
				this.OnPropertyChanged("SourceChannelTypeCode");
			}
		}
		
		/// <summary>
		/// Source of the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("sourcetypecode")]
		public virtual ConvertRule_SourceTypeCode? SourceTypeCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ConvertRule_SourceTypeCode?)(EntityOptionSetEnum.GetEnum(this, "sourcetypecode")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SourceTypeCode");
				this.SetAttributeValue("sourcetypecode", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("SourceTypeCode");
			}
		}
		
		/// <summary>
		/// Status of the Convert Rule
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<CrmEarlyBound.ConvertRuleState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((CrmEarlyBound.ConvertRuleState)(System.Enum.ToObject(typeof(CrmEarlyBound.ConvertRuleState), optionSet.Value)));
				}
				else
				{
					return null;
				}
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StateCode");
				if ((value == null))
				{
					this.SetAttributeValue("statecode", null);
				}
				else
				{
					this.SetAttributeValue("statecode", new Microsoft.Xrm.Sdk.OptionSetValue(((int)(value))));
				}
				this.OnPropertyChanged("StateCode");
			}
		}
		
		/// <summary>
		/// Reason for the status of the Convert Rule
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual ConvertRule_StatusCode? StatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((ConvertRule_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
		/// Unique identifier of the currency associated with the queue.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// Version number of the convert rule.
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
		/// Shows the workflow for this rule.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowid")]
		public Microsoft.Xrm.Sdk.EntityReference WorkflowId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("workflowid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("WorkflowId");
				this.SetAttributeValue("workflowid", value);
				this.OnPropertyChanged("WorkflowId");
			}
		}
		
		/// <summary>
		/// 1:N ConvertRule_Annotation
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ConvertRule_Annotation")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.Annotation> ConvertRule_Annotation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.Annotation>("ConvertRule_Annotation", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ConvertRule_Annotation");
				this.SetRelatedEntities<CrmEarlyBound.Annotation>("ConvertRule_Annotation", null, value);
				this.OnPropertyChanged("ConvertRule_Annotation");
			}
		}
		
		/// <summary>
		/// 1:N Convertrule_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Convertrule_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.AsyncOperation> Convertrule_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.AsyncOperation>("Convertrule_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Convertrule_AsyncOperations");
				this.SetRelatedEntities<CrmEarlyBound.AsyncOperation>("Convertrule_AsyncOperations", null, value);
				this.OnPropertyChanged("Convertrule_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N convertrule_convertruleitem
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("convertrule_convertruleitem")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.ConvertRuleItem> convertrule_convertruleitem
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.ConvertRuleItem>("convertrule_convertruleitem", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("convertrule_convertruleitem");
				this.SetRelatedEntities<CrmEarlyBound.ConvertRuleItem>("convertrule_convertruleitem", null, value);
				this.OnPropertyChanged("convertrule_convertruleitem");
			}
		}
		
		/// <summary>
		/// 1:N ConvertRule_ProcessSessions
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ConvertRule_ProcessSessions")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.ProcessSession> ConvertRule_ProcessSessions
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.ProcessSession>("ConvertRule_ProcessSessions", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ConvertRule_ProcessSessions");
				this.SetRelatedEntities<CrmEarlyBound.ProcessSession>("ConvertRule_ProcessSessions", null, value);
				this.OnPropertyChanged("ConvertRule_ProcessSessions");
			}
		}
		
		/// <summary>
		/// 1:N ConvertRule_userentityinstancedatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ConvertRule_userentityinstancedatas")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> ConvertRule_userentityinstancedatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("ConvertRule_userentityinstancedatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ConvertRule_userentityinstancedatas");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("ConvertRule_userentityinstancedatas", null, value);
				this.OnPropertyChanged("ConvertRule_userentityinstancedatas");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_convertrule
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_convertrule")]
		public CrmEarlyBound.BusinessUnit business_unit_convertrule
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.BusinessUnit>("business_unit_convertrule", null);
			}
		}
		
		/// <summary>
		/// N:1 channelpropertygroup_convertrule
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("channelpropertygroupid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("channelpropertygroup_convertrule")]
		public CrmEarlyBound.ChannelPropertyGroup channelpropertygroup_convertrule
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.ChannelPropertyGroup>("channelpropertygroup_convertrule", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("channelpropertygroup_convertrule");
				this.SetRelatedEntity<CrmEarlyBound.ChannelPropertyGroup>("channelpropertygroup_convertrule", null, value);
				this.OnPropertyChanged("channelpropertygroup_convertrule");
			}
		}
		
		/// <summary>
		/// N:1 convertrule_queue
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("queueid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("convertrule_queue")]
		public CrmEarlyBound.Queue convertrule_queue
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Queue>("convertrule_queue", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("convertrule_queue");
				this.SetRelatedEntity<CrmEarlyBound.Queue>("convertrule_queue", null, value);
				this.OnPropertyChanged("convertrule_queue");
			}
		}
		
		/// <summary>
		/// N:1 emailtemplate_convertrule
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("responsetemplateid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("emailtemplate_convertrule")]
		public CrmEarlyBound.Template emailtemplate_convertrule
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Template>("emailtemplate_convertrule", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("emailtemplate_convertrule");
				this.SetRelatedEntity<CrmEarlyBound.Template>("emailtemplate_convertrule", null, value);
				this.OnPropertyChanged("emailtemplate_convertrule");
			}
		}
		
		/// <summary>
		/// N:1 lk_convertrule_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_convertrule_createdby")]
		public CrmEarlyBound.SystemUser lk_convertrule_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_convertrule_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ConvertRule_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ConvertRule_createdonbehalfby")]
		public CrmEarlyBound.SystemUser lk_ConvertRule_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_ConvertRule_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_ConvertRule_createdonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_ConvertRule_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_ConvertRule_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_ConvertRule_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ConvertRule_modifiedby")]
		public CrmEarlyBound.SystemUser lk_ConvertRule_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_ConvertRule_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_ConvertRule_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_ConvertRule_modifiedonbehalfby")]
		public CrmEarlyBound.SystemUser lk_ConvertRule_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_ConvertRule_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_ConvertRule_modifiedonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_ConvertRule_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_ConvertRule_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 owner_convertrule
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("owner_convertrule")]
		public CrmEarlyBound.Owner owner_convertrule
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Owner>("owner_convertrule", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("owner_convertrule");
				this.SetRelatedEntity<CrmEarlyBound.Owner>("owner_convertrule", null, value);
				this.OnPropertyChanged("owner_convertrule");
			}
		}
		
		/// <summary>
		/// N:1 team_convertrule
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_convertrule")]
		public CrmEarlyBound.Team team_convertrule
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Team>("team_convertrule", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("team_convertrule");
				this.SetRelatedEntity<CrmEarlyBound.Team>("team_convertrule", null, value);
				this.OnPropertyChanged("team_convertrule");
			}
		}
		
		/// <summary>
		/// N:1 TransactionCurrency_ConvertRule
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("TransactionCurrency_ConvertRule")]
		public CrmEarlyBound.TransactionCurrency TransactionCurrency_ConvertRule
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.TransactionCurrency>("TransactionCurrency_ConvertRule", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrency_ConvertRule");
				this.SetRelatedEntity<CrmEarlyBound.TransactionCurrency>("TransactionCurrency_ConvertRule", null, value);
				this.OnPropertyChanged("TransactionCurrency_ConvertRule");
			}
		}
		
		/// <summary>
		/// N:1 user_convertrule
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_convertrule")]
		public CrmEarlyBound.SystemUser user_convertrule
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("user_convertrule", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("user_convertrule");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("user_convertrule", null, value);
				this.OnPropertyChanged("user_convertrule");
			}
		}
		
		/// <summary>
		/// N:1 workflowid_convertrule
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("workflowid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("workflowid_convertrule")]
		public CrmEarlyBound.Workflow workflowid_convertrule
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Workflow>("workflowid_convertrule", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("workflowid_convertrule");
				this.SetRelatedEntity<CrmEarlyBound.Workflow>("workflowid_convertrule", null, value);
				this.OnPropertyChanged("workflowid_convertrule");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public ConvertRule(object anonymousType) : 
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
                        Attributes["convertruleid"] = base.Id;
                        break;
                    case "convertruleid":
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