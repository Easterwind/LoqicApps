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
	/// Time zone definition, including name and time zone code.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("timezonedefinition")]
	public partial class TimeZoneDefinition : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string Bias = "bias";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string DaylightName = "daylightname";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OrganizationId = "organizationid";
			public const string RetiredOrder = "retiredorder";
			public const string StandardName = "standardname";
			public const string TimeZoneCode = "timezonecode";
			public const string TimeZoneDefinitionId = "timezonedefinitionid";
			public const string Id = "timezonedefinitionid";
			public const string UserInterfaceName = "userinterfacename";
			public const string VersionNumber = "versionnumber";
			public const string lk_timezonedefinition_createdby = "lk_timezonedefinition_createdby";
			public const string lk_timezonedefinition_createdonbehalfby = "lk_timezonedefinition_createdonbehalfby";
			public const string lk_timezonedefinition_modifiedby = "lk_timezonedefinition_modifiedby";
			public const string lk_timezonedefinition_modifiedonbehalfby = "lk_timezonedefinition_modifiedonbehalfby";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public TimeZoneDefinition() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "timezonedefinition";
		
		public const string EntitySchemaName = "TimeZoneDefinition";
		
		public const string PrimaryIdAttribute = "timezonedefinitionid";
		
		public const string PrimaryNameAttribute = "userinterfacename";
		
		public const string EntityLogicalCollectionName = "timezonedefinitions";
		
		public const string EntitySetName = "timezonedefinitions";
		
		public const int EntityTypeCode = 4810;
		
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
		/// Base time bias of the time zone.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("bias")]
		public System.Nullable<int> Bias
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("bias");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Bias");
				this.SetAttributeValue("bias", value);
				this.OnPropertyChanged("Bias");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the time zone record.
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
		/// Date and time when the time zone record was created.
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
		/// Unique identifier of the delegate user who created the timezonedefinition.
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
		/// Time zone name for the daylight time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("daylightname")]
		public string DaylightName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("daylightname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DaylightName");
				this.SetAttributeValue("daylightname", value);
				this.OnPropertyChanged("DaylightName");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who last modified the time zone record.
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
		/// Date and time when the time zone record was modified.
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
		/// Unique identifier of the delegate user who last modified the timezonedefinition.
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
		/// Unique identifier of the organization associated with the time zone definition.
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
		/// Order an entry for a time zone definition is retired. 0 for the latest entry.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("retiredorder")]
		public System.Nullable<int> RetiredOrder
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("retiredorder");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RetiredOrder");
				this.SetAttributeValue("retiredorder", value);
				this.OnPropertyChanged("RetiredOrder");
			}
		}
		
		/// <summary>
		/// Time zone name for the standard time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("standardname")]
		public string StandardName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("standardname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StandardName");
				this.SetAttributeValue("standardname", value);
				this.OnPropertyChanged("StandardName");
			}
		}
		
		/// <summary>
		/// Time zone identification code.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonecode")]
		public System.Nullable<int> TimeZoneCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("timezonecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneCode");
				this.SetAttributeValue("timezonecode", value);
				this.OnPropertyChanged("TimeZoneCode");
			}
		}
		
		/// <summary>
		/// Unique identifier of the time zone record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonedefinitionid")]
		public System.Nullable<System.Guid> TimeZoneDefinitionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("timezonedefinitionid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TimeZoneDefinitionId");
				this.SetAttributeValue("timezonedefinitionid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("TimeZoneDefinitionId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("timezonedefinitionid")]
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
				this.TimeZoneDefinitionId = value;
			}
		}
		
		/// <summary>
		/// Display name for the time zone in the Microsoft Windows registry.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userinterfacename")]
		public string UserInterfaceName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("userinterfacename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UserInterfaceName");
				this.SetAttributeValue("userinterfacename", value);
				this.OnPropertyChanged("UserInterfaceName");
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
		/// 1:N lk_timezonelocalizedname_timezonedefinitionid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonelocalizedname_timezonedefinitionid")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.TimeZoneLocalizedName> lk_timezonelocalizedname_timezonedefinitionid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.TimeZoneLocalizedName>("lk_timezonelocalizedname_timezonedefinitionid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_timezonelocalizedname_timezonedefinitionid");
				this.SetRelatedEntities<CrmEarlyBound.TimeZoneLocalizedName>("lk_timezonelocalizedname_timezonedefinitionid", null, value);
				this.OnPropertyChanged("lk_timezonelocalizedname_timezonedefinitionid");
			}
		}
		
		/// <summary>
		/// 1:N lk_timezonerule_timezonedefinitionid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonerule_timezonedefinitionid")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.TimeZoneRule> lk_timezonerule_timezonedefinitionid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.TimeZoneRule>("lk_timezonerule_timezonedefinitionid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_timezonerule_timezonedefinitionid");
				this.SetRelatedEntities<CrmEarlyBound.TimeZoneRule>("lk_timezonerule_timezonedefinitionid", null, value);
				this.OnPropertyChanged("lk_timezonerule_timezonedefinitionid");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_timezonedefinition
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_timezonedefinition")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> userentityinstancedata_timezonedefinition
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_timezonedefinition", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_timezonedefinition");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_timezonedefinition", null, value);
				this.OnPropertyChanged("userentityinstancedata_timezonedefinition");
			}
		}
		
		/// <summary>
		/// N:1 lk_timezonedefinition_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonedefinition_createdby")]
		public CrmEarlyBound.SystemUser lk_timezonedefinition_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_timezonedefinition_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_timezonedefinition_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonedefinition_createdonbehalfby")]
		public CrmEarlyBound.SystemUser lk_timezonedefinition_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_timezonedefinition_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_timezonedefinition_createdonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_timezonedefinition_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_timezonedefinition_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_timezonedefinition_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonedefinition_modifiedby")]
		public CrmEarlyBound.SystemUser lk_timezonedefinition_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_timezonedefinition_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_timezonedefinition_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_timezonedefinition_modifiedonbehalfby")]
		public CrmEarlyBound.SystemUser lk_timezonedefinition_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_timezonedefinition_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_timezonedefinition_modifiedonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_timezonedefinition_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_timezonedefinition_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public TimeZoneDefinition(object anonymousType) : 
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
                        Attributes["timezonedefinitionid"] = base.Id;
                        break;
                    case "timezonedefinitionid":
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