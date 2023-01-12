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
	public enum msdyn_customcontrolextendedsettingsState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Active = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Inactive = 1,
	}
	
	/// <summary>
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("msdyn_customcontrolextendedsettings")]
	public partial class msdyn_customcontrolextendedsettings : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string msdyn_customcontrolextendedsettingsId = "msdyn_customcontrolextendedsettingsid";
			public const string Id = "msdyn_customcontrolextendedsettingsid";
			public const string msdyn_name = "msdyn_name";
			public const string msdyn_rte_userpersonalizationsettings = "msdyn_rte_userpersonalizationsettings";
			public const string msdyn_timelineWall_isAutoExpanded = "msdyn_timelineWall_isAutoExpanded";
			public const string msdyn_timelineWall_isFilterPaneOpen = "msdyn_timelineWall_isFilterPaneOpen";
			public const string msdyn_timelineWall_isSortOrderNewerToOlder = "msdyn_timelineWall_isSortOrderNewerToOlder";
			public const string msdyn_timelineWall_searchTermApplied = "msdyn_timelineWall_searchTermApplied";
			public const string msdyn_timelineWall_userFilters = "msdyn_timelineWall_userFilters";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string OwnerId = "ownerid";
			public const string OwningBusinessUnit = "owningbusinessunit";
			public const string OwningTeam = "owningteam";
			public const string OwningUser = "owninguser";
			public const string StateCode = "statecode";
			public const string StatusCode = "statuscode";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string VersionNumber = "versionnumber";
			public const string business_unit_msdyn_customcontrolextendedsettings = "business_unit_msdyn_customcontrolextendedsettings";
			public const string lk_msdyn_customcontrolextendedsettings_createdby = "lk_msdyn_customcontrolextendedsettings_createdby";
			public const string lk_msdyn_customcontrolextendedsettings_createdonbehalfby = "lk_msdyn_customcontrolextendedsettings_createdonbehalfby";
			public const string lk_msdyn_customcontrolextendedsettings_modifiedby = "lk_msdyn_customcontrolextendedsettings_modifiedby";
			public const string lk_msdyn_customcontrolextendedsettings_modifiedonbehalfby = "lk_msdyn_customcontrolextendedsettings_modifiedonbehalfby";
			public const string owner_msdyn_customcontrolextendedsettings = "owner_msdyn_customcontrolextendedsettings";
			public const string team_msdyn_customcontrolextendedsettings = "team_msdyn_customcontrolextendedsettings";
			public const string user_msdyn_customcontrolextendedsettings = "user_msdyn_customcontrolextendedsettings";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msdyn_customcontrolextendedsettings() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "msdyn_customcontrolextendedsettings";
		
		public const string EntitySchemaName = "msdyn_customcontrolextendedsettings";
		
		public const string PrimaryIdAttribute = "msdyn_customcontrolextendedsettingsid";
		
		public const string PrimaryNameAttribute = "msdyn_name";
		
		public const string EntityLogicalCollectionName = "msdyn_customcontrolextendedsettingses";
		
		public const string EntitySetName = "msdyn_customcontrolextendedsettingses";
		
		public const int EntityTypeCode = 10243;
		
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
		/// Unique identifier for entity instances
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_customcontrolextendedsettingsid")]
		public System.Nullable<System.Guid> msdyn_customcontrolextendedsettingsId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("msdyn_customcontrolextendedsettingsid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_customcontrolextendedsettingsId");
				this.SetAttributeValue("msdyn_customcontrolextendedsettingsid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("msdyn_customcontrolextendedsettingsId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_customcontrolextendedsettingsid")]
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
				this.msdyn_customcontrolextendedsettingsId = value;
			}
		}
		
		/// <summary>
		/// The name of the custom entity.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_name")]
		public string msdyn_name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyn_name");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_name");
				this.SetAttributeValue("msdyn_name", value);
				this.OnPropertyChanged("msdyn_name");
			}
		}
		
		/// <summary>
		/// User configured personal settings for Rich Text Editor
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_rte_userpersonalizationsettings")]
		public string msdyn_rte_userpersonalizationsettings
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyn_rte_userpersonalizationsettings");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_rte_userpersonalizationsettings");
				this.SetAttributeValue("msdyn_rte_userpersonalizationsettings", value);
				this.OnPropertyChanged("msdyn_rte_userpersonalizationsettings");
			}
		}
		
		/// <summary>
		/// User configured expand state for TimelineWall
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_timelineWall_isAutoExpanded")]
		public System.Nullable<bool> msdyn_timelineWall_isAutoExpanded
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_timelineWall_isAutoExpanded");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_timelineWall_isAutoExpanded");
				this.SetAttributeValue("msdyn_timelineWall_isAutoExpanded", value);
				this.OnPropertyChanged("msdyn_timelineWall_isAutoExpanded");
			}
		}
		
		/// <summary>
		/// Will the filter pane open by default on TimelineWall load
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_timelineWall_isFilterPaneOpen")]
		public System.Nullable<bool> msdyn_timelineWall_isFilterPaneOpen
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_timelineWall_isFilterPaneOpen");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_timelineWall_isFilterPaneOpen");
				this.SetAttributeValue("msdyn_timelineWall_isFilterPaneOpen", value);
				this.OnPropertyChanged("msdyn_timelineWall_isFilterPaneOpen");
			}
		}
		
		/// <summary>
		/// Is TimelineWall set to sort by newer to older records
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_timelineWall_isSortOrderNewerToOlder")]
		public System.Nullable<bool> msdyn_timelineWall_isSortOrderNewerToOlder
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("msdyn_timelineWall_isSortOrderNewerToOlder");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_timelineWall_isSortOrderNewerToOlder");
				this.SetAttributeValue("msdyn_timelineWall_isSortOrderNewerToOlder", value);
				this.OnPropertyChanged("msdyn_timelineWall_isSortOrderNewerToOlder");
			}
		}
		
		/// <summary>
		/// Search term to be applied on TimelineWall load
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_timelineWall_searchTermApplied")]
		public string msdyn_timelineWall_searchTermApplied
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyn_timelineWall_searchTermApplied");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_timelineWall_searchTermApplied");
				this.SetAttributeValue("msdyn_timelineWall_searchTermApplied", value);
				this.OnPropertyChanged("msdyn_timelineWall_searchTermApplied");
			}
		}
		
		/// <summary>
		/// User configured filter settings for TimelineWall
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_timelineWall_userFilters")]
		public string msdyn_timelineWall_userFilters
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("msdyn_timelineWall_userFilters");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_timelineWall_userFilters");
				this.SetAttributeValue("msdyn_timelineWall_userFilters", value);
				this.OnPropertyChanged("msdyn_timelineWall_userFilters");
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
		/// Unique identifier for the business unit that owns the record
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
		}
		
		/// <summary>
		/// Status of the Timeline Wall Extended Setting
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statecode")]
		public System.Nullable<CrmEarlyBound.msdyn_customcontrolextendedsettingsState> StateCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				Microsoft.Xrm.Sdk.OptionSetValue optionSet = this.GetAttributeValue<Microsoft.Xrm.Sdk.OptionSetValue>("statecode");
				if ((optionSet != null))
				{
					return ((CrmEarlyBound.msdyn_customcontrolextendedsettingsState)(System.Enum.ToObject(typeof(CrmEarlyBound.msdyn_customcontrolextendedsettingsState), optionSet.Value)));
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
		/// Reason for the status of the Timeline Wall Extended Setting
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("statuscode")]
		public virtual msdyn_customcontrolextendedsettings_StatusCode? StatusCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((msdyn_customcontrolextendedsettings_StatusCode?)(EntityOptionSetEnum.GetEnum(this, "statuscode")));
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
		/// 1:N msdyn_customcontrolextendedsettings_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_customcontrolextendedsettings_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.AsyncOperation> msdyn_customcontrolextendedsettings_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.AsyncOperation>("msdyn_customcontrolextendedsettings_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_customcontrolextendedsettings_AsyncOperations");
				this.SetRelatedEntities<CrmEarlyBound.AsyncOperation>("msdyn_customcontrolextendedsettings_AsyncOperations", null, value);
				this.OnPropertyChanged("msdyn_customcontrolextendedsettings_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_customcontrolextendedsettings_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_customcontrolextendedsettings_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.BulkDeleteFailure> msdyn_customcontrolextendedsettings_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.BulkDeleteFailure>("msdyn_customcontrolextendedsettings_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_customcontrolextendedsettings_BulkDeleteFailures");
				this.SetRelatedEntities<CrmEarlyBound.BulkDeleteFailure>("msdyn_customcontrolextendedsettings_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("msdyn_customcontrolextendedsettings_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_customcontrolextendedsettings_DuplicateBaseRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_customcontrolextendedsettings_DuplicateBaseRecord")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.DuplicateRecord> msdyn_customcontrolextendedsettings_DuplicateBaseRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.DuplicateRecord>("msdyn_customcontrolextendedsettings_DuplicateBaseRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_customcontrolextendedsettings_DuplicateBaseRecord");
				this.SetRelatedEntities<CrmEarlyBound.DuplicateRecord>("msdyn_customcontrolextendedsettings_DuplicateBaseRecord", null, value);
				this.OnPropertyChanged("msdyn_customcontrolextendedsettings_DuplicateBaseRecord");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_customcontrolextendedsettings_DuplicateMatchingRecord
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_customcontrolextendedsettings_DuplicateMatchingRecord")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.DuplicateRecord> msdyn_customcontrolextendedsettings_DuplicateMatchingRecord
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.DuplicateRecord>("msdyn_customcontrolextendedsettings_DuplicateMatchingRecord", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_customcontrolextendedsettings_DuplicateMatchingRecord");
				this.SetRelatedEntities<CrmEarlyBound.DuplicateRecord>("msdyn_customcontrolextendedsettings_DuplicateMatchingRecord", null, value);
				this.OnPropertyChanged("msdyn_customcontrolextendedsettings_DuplicateMatchingRecord");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_customcontrolextendedsettings_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_customcontrolextendedsettings_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.MailboxTrackingFolder> msdyn_customcontrolextendedsettings_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.MailboxTrackingFolder>("msdyn_customcontrolextendedsettings_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_customcontrolextendedsettings_MailboxTrackingFolders");
				this.SetRelatedEntities<CrmEarlyBound.MailboxTrackingFolder>("msdyn_customcontrolextendedsettings_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("msdyn_customcontrolextendedsettings_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_customcontrolextendedsettings_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_customcontrolextendedsettings_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.PrincipalObjectAttributeAccess> msdyn_customcontrolextendedsettings_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.PrincipalObjectAttributeAccess>("msdyn_customcontrolextendedsettings_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_customcontrolextendedsettings_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<CrmEarlyBound.PrincipalObjectAttributeAccess>("msdyn_customcontrolextendedsettings_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("msdyn_customcontrolextendedsettings_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_customcontrolextendedsettings_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_customcontrolextendedsettings_ProcessSession")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.ProcessSession> msdyn_customcontrolextendedsettings_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.ProcessSession>("msdyn_customcontrolextendedsettings_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_customcontrolextendedsettings_ProcessSession");
				this.SetRelatedEntities<CrmEarlyBound.ProcessSession>("msdyn_customcontrolextendedsettings_ProcessSession", null, value);
				this.OnPropertyChanged("msdyn_customcontrolextendedsettings_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_customcontrolextendedsettings_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_customcontrolextendedsettings_SyncErrors")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.SyncError> msdyn_customcontrolextendedsettings_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.SyncError>("msdyn_customcontrolextendedsettings_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_customcontrolextendedsettings_SyncErrors");
				this.SetRelatedEntities<CrmEarlyBound.SyncError>("msdyn_customcontrolextendedsettings_SyncErrors", null, value);
				this.OnPropertyChanged("msdyn_customcontrolextendedsettings_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_customcontrolextendedsettings_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_customcontrolextendedsettings_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> msdyn_customcontrolextendedsettings_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("msdyn_customcontrolextendedsettings_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_customcontrolextendedsettings_UserEntityInstanceDatas");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("msdyn_customcontrolextendedsettings_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("msdyn_customcontrolextendedsettings_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 business_unit_msdyn_customcontrolextendedsettings
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningbusinessunit")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("business_unit_msdyn_customcontrolextendedsettings")]
		public CrmEarlyBound.BusinessUnit business_unit_msdyn_customcontrolextendedsettings
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.BusinessUnit>("business_unit_msdyn_customcontrolextendedsettings", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_customcontrolextendedsettings_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_customcontrolextendedsettings_createdby")]
		public CrmEarlyBound.SystemUser lk_msdyn_customcontrolextendedsettings_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_msdyn_customcontrolextendedsettings_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_customcontrolextendedsettings_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_customcontrolextendedsettings_createdonbehalfby")]
		public CrmEarlyBound.SystemUser lk_msdyn_customcontrolextendedsettings_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_msdyn_customcontrolextendedsettings_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_customcontrolextendedsettings_createdonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_msdyn_customcontrolextendedsettings_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_customcontrolextendedsettings_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_customcontrolextendedsettings_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_customcontrolextendedsettings_modifiedby")]
		public CrmEarlyBound.SystemUser lk_msdyn_customcontrolextendedsettings_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_msdyn_customcontrolextendedsettings_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_msdyn_customcontrolextendedsettings_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_msdyn_customcontrolextendedsettings_modifiedonbehalfby")]
		public CrmEarlyBound.SystemUser lk_msdyn_customcontrolextendedsettings_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_msdyn_customcontrolextendedsettings_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_msdyn_customcontrolextendedsettings_modifiedonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_msdyn_customcontrolextendedsettings_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_msdyn_customcontrolextendedsettings_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 owner_msdyn_customcontrolextendedsettings
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ownerid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("owner_msdyn_customcontrolextendedsettings")]
		public CrmEarlyBound.Owner owner_msdyn_customcontrolextendedsettings
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Owner>("owner_msdyn_customcontrolextendedsettings", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("owner_msdyn_customcontrolextendedsettings");
				this.SetRelatedEntity<CrmEarlyBound.Owner>("owner_msdyn_customcontrolextendedsettings", null, value);
				this.OnPropertyChanged("owner_msdyn_customcontrolextendedsettings");
			}
		}
		
		/// <summary>
		/// N:1 team_msdyn_customcontrolextendedsettings
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owningteam")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("team_msdyn_customcontrolextendedsettings")]
		public CrmEarlyBound.Team team_msdyn_customcontrolextendedsettings
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Team>("team_msdyn_customcontrolextendedsettings", null);
			}
		}
		
		/// <summary>
		/// N:1 user_msdyn_customcontrolextendedsettings
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("owninguser")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_msdyn_customcontrolextendedsettings")]
		public CrmEarlyBound.SystemUser user_msdyn_customcontrolextendedsettings
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("user_msdyn_customcontrolextendedsettings", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msdyn_customcontrolextendedsettings(object anonymousType) : 
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
                        Attributes["msdyn_customcontrolextendedsettingsid"] = base.Id;
                        break;
                    case "msdyn_customcontrolextendedsettingsid":
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