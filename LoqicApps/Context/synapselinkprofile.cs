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
	public enum synapselinkprofileState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// Synapse Link Profile
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("synapselinkprofile")]
	public partial class synapselinkprofile : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ActivationTime = "activationtime";
			public const string ComponentIdUnique = "componentidunique";
			public const string ComponentState = "componentstate";
			public const string CopyAttachments = "copyattachments";
			public const string CopyFiles = "copyfiles";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string datalakefolder = "datalakefolder";
			public const string ExtendedProperties = "extendedproperties";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IsCustomizable = "iscustomizable";
			public const string IsManaged = "ismanaged";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OverwriteTime = "overwritetime";
			public const string ProfileState = "profilestate";
			public const string ProfileType = "profiletype";
			public const string ProfileUpdatedTime = "profileupdatedtime";
			public const string ProfileVersion = "profileversion";
			public const string SnapshotsToPersist = "snapshotstopersist";
			public const string SolutionId = "solutionid";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string synapselinkprofileId = "synapselinkprofileid";
			public const string Id = "synapselinkprofileid";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UniqueName = "uniquename";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string lk_synapselinkprofile_createdby = "lk_synapselinkprofile_createdby";
			public const string lk_synapselinkprofile_createdonbehalfby = "lk_synapselinkprofile_createdonbehalfby";
			public const string lk_synapselinkprofile_modifiedby = "lk_synapselinkprofile_modifiedby";
			public const string lk_synapselinkprofile_modifiedonbehalfby = "lk_synapselinkprofile_modifiedonbehalfby";
			public const string organization_synapselinkprofile = "organization_synapselinkprofile";
			public const string synapselinkprofiles = "synapselinkprofiles";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public synapselinkprofile() : 
				base(EntityLogicalName)
		{
		}
		
		public const string AlternateKeys = "componentstate,overwritetime,uniquename|componentstate,datalakefolder,overwriteti" +
			"me";
		
		public const string EntityLogicalName = "synapselinkprofile";
		
		public const string EntitySchemaName = "synapselinkprofile";
		
		public const string PrimaryIdAttribute = "synapselinkprofileid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const string EntityLogicalCollectionName = "synapselinkprofiles";
		
		public const string EntitySetName = "synapselinkprofiles";
		
		public const int EntityTypeCode = 10034;
		
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
		/// Activation time of profile
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("activationtime")]
		public System.Nullable<System.DateTime> ActivationTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("activationtime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ActivationTime");
				this.SetAttributeValue("activationtime", value);
				this.OnPropertyChanged("ActivationTime");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentidunique")]
		public System.Nullable<System.Guid> ComponentIdUnique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("componentidunique");
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
		/// Enable Copy Attachments
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("copyattachments")]
		public System.Nullable<bool> CopyAttachments
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("copyattachments");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CopyAttachments");
				this.SetAttributeValue("copyattachments", value);
				this.OnPropertyChanged("CopyAttachments");
			}
		}
		
		/// <summary>
		/// Enable Copy Files
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("copyfiles")]
		public System.Nullable<bool> CopyFiles
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("copyfiles");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CopyFiles");
				this.SetAttributeValue("copyfiles", value);
				this.OnPropertyChanged("CopyFiles");
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
		/// Unique identifier for Data Lake Folder associated with Synapse Link Profile.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("datalakefolder")]
		public Microsoft.Xrm.Sdk.EntityReference datalakefolder
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("datalakefolder");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("datalakefolder");
				this.SetAttributeValue("datalakefolder", value);
				this.OnPropertyChanged("datalakefolder");
			}
		}
		
		/// <summary>
		/// Extended properties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("extendedproperties")]
		public string ExtendedProperties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("extendedproperties");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ExtendedProperties");
				this.SetAttributeValue("extendedproperties", value);
				this.OnPropertyChanged("ExtendedProperties");
			}
		}
		
		/// <summary>
		/// Sequence number of the import that created this record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("importsequencenumber")]
		public System.Nullable<int> ImportSequenceNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("importsequencenumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImportSequenceNumber");
				this.SetAttributeValue("importsequencenumber", value);
				this.OnPropertyChanged("ImportSequenceNumber");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscustomizable")]
		public Microsoft.Xrm.Sdk.BooleanManagedProperty IsCustomizable
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.BooleanManagedProperty>("iscustomizable");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsCustomizable");
				this.SetAttributeValue("iscustomizable", value);
				this.OnPropertyChanged("IsCustomizable");
			}
		}
		
		/// <summary>
		/// Indicates whether the solution component is part of a managed solution.
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
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("name")]
		public string name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("name");
				this.SetAttributeValue("name", value);
				this.OnPropertyChanged("name");
			}
		}
		
		/// <summary>
		/// Unique identifier for the organization
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		public Microsoft.Xrm.Sdk.EntityReference OrganizationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("organizationid");
			}
		}
		
		/// <summary>
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
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
		/// State of the profile
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("profilestate")]
		public virtual SynapseLinkProfileState? ProfileState
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((SynapseLinkProfileState?)(EntityOptionSetEnum.GetEnum(this, "profilestate")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProfileState");
				this.SetAttributeValue("profilestate", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("ProfileState");
			}
		}
		
		/// <summary>
		/// Type of profile
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("profiletype")]
		public virtual SynapseLinkProfileType? ProfileType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((SynapseLinkProfileType?)(EntityOptionSetEnum.GetEnum(this, "profiletype")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProfileType");
				this.SetAttributeValue("profiletype", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("ProfileType");
			}
		}
		
		/// <summary>
		/// Profile Updated Time
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("profileupdatedtime")]
		public System.Nullable<System.DateTime> ProfileUpdatedTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("profileupdatedtime");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProfileUpdatedTime");
				this.SetAttributeValue("profileupdatedtime", value);
				this.OnPropertyChanged("ProfileUpdatedTime");
			}
		}
		
		/// <summary>
		/// Profile version
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("profileversion")]
		public string ProfileVersion
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("profileversion");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ProfileVersion");
				this.SetAttributeValue("profileversion", value);
				this.OnPropertyChanged("ProfileVersion");
			}
		}
		
		/// <summary>
		/// Number of snapshots To persist
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("snapshotstopersist")]
		public System.Nullable<int> SnapshotsToPersist
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("snapshotstopersist");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SnapshotsToPersist");
				this.SetAttributeValue("snapshotstopersist", value);
				this.OnPropertyChanged("SnapshotsToPersist");
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
		/// Status of the Synapse Link Profile
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<CrmEarlyBound.synapselinkprofileState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((CrmEarlyBound.synapselinkprofileState)(System.Enum.ToObject(typeof(CrmEarlyBound.synapselinkprofileState), optionSet.Value)));
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
		/// Reason for the status of the Synapse Link Profile
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual synapselinkprofile_StatusCode? StatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((synapselinkprofile_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("synapselinkprofileid")]
		public System.Nullable<System.Guid> synapselinkprofileId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("synapselinkprofileid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("synapselinkprofileId");
				this.SetAttributeValue("synapselinkprofileid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("synapselinkprofileId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("synapselinkprofileid")]
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
				this.synapselinkprofileId = value;
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezoneruleversionnumber")]
		public System.Nullable<int> TimeZoneRuleVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezoneruleversionnumber");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneRuleVersionNumber");
				this.SetAttributeValue("timezoneruleversionnumber", value);
				this.OnPropertyChanged("TimeZoneRuleVersionNumber");
			}
		}
		
		/// <summary>
		/// Unique name
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("uniquename")]
		public string UniqueName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("uniquename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UniqueName");
				this.SetAttributeValue("uniquename", value);
				this.OnPropertyChanged("UniqueName");
			}
		}
		
		/// <summary>
		/// Time zone code that was in use when the record was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("utcconversiontimezonecode")]
		public System.Nullable<int> UTCConversionTimeZoneCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("utcconversiontimezonecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UTCConversionTimeZoneCode");
				this.SetAttributeValue("utcconversiontimezonecode", value);
				this.OnPropertyChanged("UTCConversionTimeZoneCode");
			}
		}
		
		/// <summary>
		/// Version Number
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
		/// 1:N profileentities
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("profileentities")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.synapselinkprofileentity> profileentities
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.synapselinkprofileentity>("profileentities", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("profileentities");
				this.SetRelatedEntities<CrmEarlyBound.synapselinkprofileentity>("profileentities", null, value);
				this.OnPropertyChanged("profileentities");
			}
		}
		
		/// <summary>
		/// 1:N profileentitystates
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("profileentitystates")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.synapselinkprofileentitystate> profileentitystates
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.synapselinkprofileentitystate>("profileentitystates", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("profileentitystates");
				this.SetRelatedEntities<CrmEarlyBound.synapselinkprofileentitystate>("profileentitystates", null, value);
				this.OnPropertyChanged("profileentitystates");
			}
		}
		
		/// <summary>
		/// 1:N profileschedules
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("profileschedules")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.synapselinkschedule> profileschedules
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.synapselinkschedule>("profileschedules", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("profileschedules");
				this.SetRelatedEntities<CrmEarlyBound.synapselinkschedule>("profileschedules", null, value);
				this.OnPropertyChanged("profileschedules");
			}
		}
		
		/// <summary>
		/// 1:N synapselinkprofile_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("synapselinkprofile_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.AsyncOperation> synapselinkprofile_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.AsyncOperation>("synapselinkprofile_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("synapselinkprofile_AsyncOperations");
				this.SetRelatedEntities<CrmEarlyBound.AsyncOperation>("synapselinkprofile_AsyncOperations", null, value);
				this.OnPropertyChanged("synapselinkprofile_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N synapselinkprofile_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("synapselinkprofile_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.BulkDeleteFailure> synapselinkprofile_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.BulkDeleteFailure>("synapselinkprofile_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("synapselinkprofile_BulkDeleteFailures");
				this.SetRelatedEntities<CrmEarlyBound.BulkDeleteFailure>("synapselinkprofile_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("synapselinkprofile_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N synapselinkprofile_DuplicateBaseRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("synapselinkprofile_DuplicateBaseRecord")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.DuplicateRecord> synapselinkprofile_DuplicateBaseRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.DuplicateRecord>("synapselinkprofile_DuplicateBaseRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("synapselinkprofile_DuplicateBaseRecord");
				this.SetRelatedEntities<CrmEarlyBound.DuplicateRecord>("synapselinkprofile_DuplicateBaseRecord", null, value);
				this.OnPropertyChanged("synapselinkprofile_DuplicateBaseRecord");
			}
		}
		
		/// <summary>
		/// 1:N synapselinkprofile_DuplicateMatchingRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("synapselinkprofile_DuplicateMatchingRecord")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.DuplicateRecord> synapselinkprofile_DuplicateMatchingRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.DuplicateRecord>("synapselinkprofile_DuplicateMatchingRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("synapselinkprofile_DuplicateMatchingRecord");
				this.SetRelatedEntities<CrmEarlyBound.DuplicateRecord>("synapselinkprofile_DuplicateMatchingRecord", null, value);
				this.OnPropertyChanged("synapselinkprofile_DuplicateMatchingRecord");
			}
		}
		
		/// <summary>
		/// 1:N synapselinkprofile_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("synapselinkprofile_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.MailboxTrackingFolder> synapselinkprofile_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.MailboxTrackingFolder>("synapselinkprofile_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("synapselinkprofile_MailboxTrackingFolders");
				this.SetRelatedEntities<CrmEarlyBound.MailboxTrackingFolder>("synapselinkprofile_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("synapselinkprofile_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N synapselinkprofile_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("synapselinkprofile_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.PrincipalObjectAttributeAccess> synapselinkprofile_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.PrincipalObjectAttributeAccess>("synapselinkprofile_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("synapselinkprofile_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<CrmEarlyBound.PrincipalObjectAttributeAccess>("synapselinkprofile_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("synapselinkprofile_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N synapselinkprofile_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("synapselinkprofile_ProcessSession")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.ProcessSession> synapselinkprofile_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.ProcessSession>("synapselinkprofile_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("synapselinkprofile_ProcessSession");
				this.SetRelatedEntities<CrmEarlyBound.ProcessSession>("synapselinkprofile_ProcessSession", null, value);
				this.OnPropertyChanged("synapselinkprofile_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N synapselinkprofile_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("synapselinkprofile_SyncErrors")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.SyncError> synapselinkprofile_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.SyncError>("synapselinkprofile_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("synapselinkprofile_SyncErrors");
				this.SetRelatedEntities<CrmEarlyBound.SyncError>("synapselinkprofile_SyncErrors", null, value);
				this.OnPropertyChanged("synapselinkprofile_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N synapselinkprofile_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("synapselinkprofile_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> synapselinkprofile_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("synapselinkprofile_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("synapselinkprofile_UserEntityInstanceDatas");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("synapselinkprofile_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("synapselinkprofile_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 lk_synapselinkprofile_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_synapselinkprofile_createdby")]
		public CrmEarlyBound.SystemUser lk_synapselinkprofile_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_synapselinkprofile_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_synapselinkprofile_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_synapselinkprofile_createdonbehalfby")]
		public CrmEarlyBound.SystemUser lk_synapselinkprofile_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_synapselinkprofile_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_synapselinkprofile_createdonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_synapselinkprofile_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_synapselinkprofile_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_synapselinkprofile_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_synapselinkprofile_modifiedby")]
		public CrmEarlyBound.SystemUser lk_synapselinkprofile_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_synapselinkprofile_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_synapselinkprofile_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_synapselinkprofile_modifiedonbehalfby")]
		public CrmEarlyBound.SystemUser lk_synapselinkprofile_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_synapselinkprofile_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_synapselinkprofile_modifiedonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_synapselinkprofile_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_synapselinkprofile_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_synapselinkprofile
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_synapselinkprofile")]
		public CrmEarlyBound.Organization organization_synapselinkprofile
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Organization>("organization_synapselinkprofile", null);
			}
		}
		
		/// <summary>
		/// N:1 synapselinkprofiles
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("datalakefolder")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("synapselinkprofiles")]
		public CrmEarlyBound.datalakefolder synapselinkprofiles
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.datalakefolder>("synapselinkprofiles", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("synapselinkprofiles");
				this.SetRelatedEntity<CrmEarlyBound.datalakefolder>("synapselinkprofiles", null, value);
				this.OnPropertyChanged("synapselinkprofiles");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public synapselinkprofile(object anonymousType) : 
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
                        Attributes["synapselinkprofileid"] = base.Id;
                        break;
                    case "synapselinkprofileid":
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