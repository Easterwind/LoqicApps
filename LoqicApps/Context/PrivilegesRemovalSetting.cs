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
	/// Privileges Removal Setting
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("privilegesremovalsetting")]
	public partial class PrivilegesRemovalSetting : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ComponentIdUnique = "componentidunique";
			public const string ComponentState = "componentstate";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ExtensionOfRecordId = "extensionofrecordid";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string IsAppendRemoved = "isappendremoved";
			public const string IsAppendToRemoved = "isappendtoremoved";
			public const string IsAssignRemoved = "isassignremoved";
			public const string IsCreateRemoved = "iscreateremoved";
			public const string IsCustomizable = "iscustomizable";
			public const string IsDeleteRemoved = "isdeleteremoved";
			public const string IsManaged = "ismanaged";
			public const string IsReadRemoved = "isreadremoved";
			public const string IsWriteRemoved = "iswriteremoved";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Name = "name";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OverwriteTime = "overwritetime";
			public const string PrivilegesRemovalSettingId = "privilegesremovalsettingid";
			public const string Id = "privilegesremovalsettingid";
			public const string SolutionId = "solutionid";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string lk_privilegesremovalsetting_createdby = "lk_privilegesremovalsetting_createdby";
			public const string lk_privilegesremovalsetting_createdonbehalfby = "lk_privilegesremovalsetting_createdonbehalfby";
			public const string lk_privilegesremovalsetting_modifiedby = "lk_privilegesremovalsetting_modifiedby";
			public const string lk_privilegesremovalsetting_modifiedonbehalfby = "lk_privilegesremovalsetting_modifiedonbehalfby";
			public const string organization_privilegesremovalsetting = "organization_privilegesremovalsetting";
			public const string privilegesremovalsetting_extensionofrecordid = "privilegesremovalsetting_extensionofrecordid";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public PrivilegesRemovalSetting() : 
				base(EntityLogicalName)
		{
		}
		
		public const string AlternateKeys = "componentstate,extensionofrecordid,overwritetime";
		
		public const string EntityLogicalName = "privilegesremovalsetting";
		
		public const string EntitySchemaName = "PrivilegesRemovalSetting";
		
		public const string PrimaryIdAttribute = "privilegesremovalsettingid";
		
		public const string PrimaryNameAttribute = "name";
		
		public const string EntityLogicalCollectionName = "privilegesremovalsettings";
		
		public const string EntitySetName = "privilegesremovalsettings";
		
		public const int EntityTypeCode = 103;
		
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
		/// Unique identifier of the Entity record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("extensionofrecordid")]
		public Microsoft.Xrm.Sdk.EntityReference ExtensionOfRecordId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("extensionofrecordid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ExtensionOfRecordId");
				this.SetAttributeValue("extensionofrecordid", value);
				this.OnPropertyChanged("ExtensionOfRecordId");
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
		/// Not Supported
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isappendremoved")]
		public System.Nullable<bool> IsAppendRemoved
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isappendremoved");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsAppendRemoved");
				this.SetAttributeValue("isappendremoved", value);
				this.OnPropertyChanged("IsAppendRemoved");
			}
		}
		
		/// <summary>
		/// Not Supported
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isappendtoremoved")]
		public System.Nullable<bool> IsAppendToRemoved
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isappendtoremoved");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsAppendToRemoved");
				this.SetAttributeValue("isappendtoremoved", value);
				this.OnPropertyChanged("IsAppendToRemoved");
			}
		}
		
		/// <summary>
		/// Not Supported
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isassignremoved")]
		public System.Nullable<bool> IsAssignRemoved
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isassignremoved");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsAssignRemoved");
				this.SetAttributeValue("isassignremoved", value);
				this.OnPropertyChanged("IsAssignRemoved");
			}
		}
		
		/// <summary>
		/// Skip Create Privilege Check for the Entity, which means all authenticated users could create entity records
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscreateremoved")]
		public System.Nullable<bool> IsCreateRemoved
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("iscreateremoved");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsCreateRemoved");
				this.SetAttributeValue("iscreateremoved", value);
				this.OnPropertyChanged("IsCreateRemoved");
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
		/// Skip Delete Privilege Check for the Entity, which means all authenticated users could delete entity records
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isdeleteremoved")]
		public System.Nullable<bool> IsDeleteRemoved
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isdeleteremoved");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsDeleteRemoved");
				this.SetAttributeValue("isdeleteremoved", value);
				this.OnPropertyChanged("IsDeleteRemoved");
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
		/// Skip Read Privilege Check for the Entity, which means all authenticated users could read all entity records
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("isreadremoved")]
		public System.Nullable<bool> IsReadRemoved
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("isreadremoved");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsReadRemoved");
				this.SetAttributeValue("isreadremoved", value);
				this.OnPropertyChanged("IsReadRemoved");
			}
		}
		
		/// <summary>
		/// Skip Write Privilege Check for the Entity, which means all authenticated users could write to any entity records
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iswriteremoved")]
		public System.Nullable<bool> IsWriteRemoved
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("iswriteremoved");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("IsWriteRemoved");
				this.SetAttributeValue("iswriteremoved", value);
				this.OnPropertyChanged("IsWriteRemoved");
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
		/// Name
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
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("privilegesremovalsettingid")]
		public System.Nullable<System.Guid> PrivilegesRemovalSettingId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("privilegesremovalsettingid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PrivilegesRemovalSettingId");
				this.SetAttributeValue("privilegesremovalsettingid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("PrivilegesRemovalSettingId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("privilegesremovalsettingid")]
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
				this.PrivilegesRemovalSettingId = value;
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
		/// 1:N privilegesremovalsetting_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("privilegesremovalsetting_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.AsyncOperation> privilegesremovalsetting_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.AsyncOperation>("privilegesremovalsetting_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("privilegesremovalsetting_AsyncOperations");
				this.SetRelatedEntities<CrmEarlyBound.AsyncOperation>("privilegesremovalsetting_AsyncOperations", null, value);
				this.OnPropertyChanged("privilegesremovalsetting_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N privilegesremovalsetting_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("privilegesremovalsetting_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.BulkDeleteFailure> privilegesremovalsetting_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.BulkDeleteFailure>("privilegesremovalsetting_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("privilegesremovalsetting_BulkDeleteFailures");
				this.SetRelatedEntities<CrmEarlyBound.BulkDeleteFailure>("privilegesremovalsetting_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("privilegesremovalsetting_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N privilegesremovalsetting_DuplicateBaseRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("privilegesremovalsetting_DuplicateBaseRecord")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.DuplicateRecord> privilegesremovalsetting_DuplicateBaseRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.DuplicateRecord>("privilegesremovalsetting_DuplicateBaseRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("privilegesremovalsetting_DuplicateBaseRecord");
				this.SetRelatedEntities<CrmEarlyBound.DuplicateRecord>("privilegesremovalsetting_DuplicateBaseRecord", null, value);
				this.OnPropertyChanged("privilegesremovalsetting_DuplicateBaseRecord");
			}
		}
		
		/// <summary>
		/// 1:N privilegesremovalsetting_DuplicateMatchingRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("privilegesremovalsetting_DuplicateMatchingRecord")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.DuplicateRecord> privilegesremovalsetting_DuplicateMatchingRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.DuplicateRecord>("privilegesremovalsetting_DuplicateMatchingRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("privilegesremovalsetting_DuplicateMatchingRecord");
				this.SetRelatedEntities<CrmEarlyBound.DuplicateRecord>("privilegesremovalsetting_DuplicateMatchingRecord", null, value);
				this.OnPropertyChanged("privilegesremovalsetting_DuplicateMatchingRecord");
			}
		}
		
		/// <summary>
		/// 1:N privilegesremovalsetting_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("privilegesremovalsetting_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.MailboxTrackingFolder> privilegesremovalsetting_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.MailboxTrackingFolder>("privilegesremovalsetting_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("privilegesremovalsetting_MailboxTrackingFolders");
				this.SetRelatedEntities<CrmEarlyBound.MailboxTrackingFolder>("privilegesremovalsetting_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("privilegesremovalsetting_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N privilegesremovalsetting_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("privilegesremovalsetting_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.PrincipalObjectAttributeAccess> privilegesremovalsetting_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.PrincipalObjectAttributeAccess>("privilegesremovalsetting_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("privilegesremovalsetting_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<CrmEarlyBound.PrincipalObjectAttributeAccess>("privilegesremovalsetting_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("privilegesremovalsetting_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N privilegesremovalsetting_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("privilegesremovalsetting_ProcessSession")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.ProcessSession> privilegesremovalsetting_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.ProcessSession>("privilegesremovalsetting_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("privilegesremovalsetting_ProcessSession");
				this.SetRelatedEntities<CrmEarlyBound.ProcessSession>("privilegesremovalsetting_ProcessSession", null, value);
				this.OnPropertyChanged("privilegesremovalsetting_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N privilegesremovalsetting_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("privilegesremovalsetting_SyncErrors")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.SyncError> privilegesremovalsetting_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.SyncError>("privilegesremovalsetting_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("privilegesremovalsetting_SyncErrors");
				this.SetRelatedEntities<CrmEarlyBound.SyncError>("privilegesremovalsetting_SyncErrors", null, value);
				this.OnPropertyChanged("privilegesremovalsetting_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N privilegesremovalsetting_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("privilegesremovalsetting_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> privilegesremovalsetting_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("privilegesremovalsetting_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("privilegesremovalsetting_UserEntityInstanceDatas");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("privilegesremovalsetting_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("privilegesremovalsetting_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 lk_privilegesremovalsetting_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_privilegesremovalsetting_createdby")]
		public CrmEarlyBound.SystemUser lk_privilegesremovalsetting_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_privilegesremovalsetting_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_privilegesremovalsetting_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_privilegesremovalsetting_createdonbehalfby")]
		public CrmEarlyBound.SystemUser lk_privilegesremovalsetting_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_privilegesremovalsetting_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_privilegesremovalsetting_createdonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_privilegesremovalsetting_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_privilegesremovalsetting_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_privilegesremovalsetting_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_privilegesremovalsetting_modifiedby")]
		public CrmEarlyBound.SystemUser lk_privilegesremovalsetting_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_privilegesremovalsetting_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_privilegesremovalsetting_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_privilegesremovalsetting_modifiedonbehalfby")]
		public CrmEarlyBound.SystemUser lk_privilegesremovalsetting_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_privilegesremovalsetting_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_privilegesremovalsetting_modifiedonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_privilegesremovalsetting_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_privilegesremovalsetting_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 organization_privilegesremovalsetting
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_privilegesremovalsetting")]
		public CrmEarlyBound.Organization organization_privilegesremovalsetting
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Organization>("organization_privilegesremovalsetting", null);
			}
		}
		
		/// <summary>
		/// N:1 privilegesremovalsetting_extensionofrecordid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("extensionofrecordid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("privilegesremovalsetting_extensionofrecordid")]
		public CrmEarlyBound.Entity_Ent privilegesremovalsetting_extensionofrecordid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Entity_Ent>("privilegesremovalsetting_extensionofrecordid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("privilegesremovalsetting_extensionofrecordid");
				this.SetRelatedEntity<CrmEarlyBound.Entity_Ent>("privilegesremovalsetting_extensionofrecordid", null, value);
				this.OnPropertyChanged("privilegesremovalsetting_extensionofrecordid");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public PrivilegesRemovalSetting(object anonymousType) : 
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
                        Attributes["privilegesremovalsettingid"] = base.Id;
                        break;
                    case "privilegesremovalsettingid":
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