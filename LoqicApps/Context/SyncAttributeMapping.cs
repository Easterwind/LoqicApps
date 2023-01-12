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
	/// Group of Sync-Attribute Mappings used to provide Attribute mappings during sync for a particular user
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("syncattributemapping")]
	public partial class SyncAttributeMapping : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string AllowedSyncDirection = "allowedsyncdirection";
			public const string AttributeCRMName = "attributecrmname";
			public const string AttributeExchangeName = "attributeexchangename";
			public const string ComponentState = "componentstate";
			public const string ComputedProperties = "computedproperties";
			public const string DefaultSyncDirection = "defaultsyncdirection";
			public const string EntityTypeCode1 = "entitytypecode";
			public const string IsComputed = "iscomputed";
			public const string IsManaged = "ismanaged";
			public const string MappingName = "mappingname";
			public const string OrganizationId = "organizationid";
			public const string OverwriteTime = "overwritetime";
			public const string ParentSyncAttributeMappingId = "parentsyncattributemappingid";
			public const string SolutionId = "solutionid";
			public const string SyncAttributeMappingId = "syncattributemappingid";
			public const string Id = "syncattributemappingid";
			public const string SyncAttributeMappingIdUnique = "syncattributemappingidunique";
			public const string SyncAttributeMappingProfileId = "syncattributemappingprofileid";
			public const string SyncDirection = "syncdirection";
			public const string lk_syncattributemapping_syncattributemappingprofileid = "lk_syncattributemapping_syncattributemappingprofileid";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SyncAttributeMapping() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "syncattributemapping";
		
		public const string EntitySchemaName = "SyncAttributeMapping";
		
		public const string PrimaryIdAttribute = "syncattributemappingid";
		
		public const string EntityLogicalCollectionName = "syncattributemappings";
		
		public const string EntitySetName = "syncattributemappings";
		
		public const int EntityTypeCode = 1401;
		
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
		/// Allowed Sync Directions
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("allowedsyncdirection")]
		public System.Nullable<int> AllowedSyncDirection
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("allowedsyncdirection");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AllowedSyncDirection");
				this.SetAttributeValue("allowedsyncdirection", value);
				this.OnPropertyChanged("AllowedSyncDirection");
			}
		}
		
		/// <summary>
		/// CRM Attribute Name.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attributecrmname")]
		public string AttributeCRMName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("attributecrmname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AttributeCRMName");
				this.SetAttributeValue("attributecrmname", value);
				this.OnPropertyChanged("AttributeCRMName");
			}
		}
		
		/// <summary>
		/// Exchange Attribute Name.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("attributeexchangename")]
		public string AttributeExchangeName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("attributeexchangename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AttributeExchangeName");
				this.SetAttributeValue("attributeexchangename", value);
				this.OnPropertyChanged("AttributeExchangeName");
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
		/// Computed Properties.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("computedproperties")]
		public string ComputedProperties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("computedproperties");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ComputedProperties");
				this.SetAttributeValue("computedproperties", value);
				this.OnPropertyChanged("ComputedProperties");
			}
		}
		
		/// <summary>
		/// Default Sync Direction
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("defaultsyncdirection")]
		public virtual SyncAttributeMapping_SyncDirection? DefaultSyncDirection
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((SyncAttributeMapping_SyncDirection?)(EntityOptionSetEnum.GetEnum(this, "defaultsyncdirection")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DefaultSyncDirection");
				this.SetAttributeValue("defaultsyncdirection", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("DefaultSyncDirection");
			}
		}
		
		/// <summary>
		/// Entity name.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitytypecode")]
		public string EntityTypeCode1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("entitytypecode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EntityTypeCode1");
				this.SetAttributeValue("entitytypecode", value);
				this.OnPropertyChanged("EntityTypeCode1");
			}
		}
		
		/// <summary>
		/// Indicates whether the mapping is a computed property
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("iscomputed")]
		public System.Nullable<bool> IsComputed
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("iscomputed");
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
		/// Attribute Name.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mappingname")]
		public string MappingName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("mappingname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MappingName");
				this.SetAttributeValue("mappingname", value);
				this.OnPropertyChanged("MappingName");
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
		/// Parent Sync-Attribute Mapping to which this mapping belongs
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsyncattributemappingid")]
		public Microsoft.Xrm.Sdk.EntityReference ParentSyncAttributeMappingId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentsyncattributemappingid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ParentSyncAttributeMappingId");
				this.SetAttributeValue("parentsyncattributemappingid", value);
				this.OnPropertyChanged("ParentSyncAttributeMappingId");
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
		/// Unique identifier of the Sync-Attribute Mapping.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("syncattributemappingid")]
		public System.Nullable<System.Guid> SyncAttributeMappingId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("syncattributemappingid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SyncAttributeMappingId");
				this.SetAttributeValue("syncattributemappingid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SyncAttributeMappingId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("syncattributemappingid")]
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
				this.SyncAttributeMappingId = value;
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("syncattributemappingidunique")]
		public System.Nullable<System.Guid> SyncAttributeMappingIdUnique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("syncattributemappingidunique");
			}
		}
		
		/// <summary>
		/// Unique identifier of profile to which this mapping belongs.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("syncattributemappingprofileid")]
		public Microsoft.Xrm.Sdk.EntityReference SyncAttributeMappingProfileId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("syncattributemappingprofileid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SyncAttributeMappingProfileId");
				this.SetAttributeValue("syncattributemappingprofileid", value);
				this.OnPropertyChanged("SyncAttributeMappingProfileId");
			}
		}
		
		/// <summary>
		/// Sync Direction
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("syncdirection")]
		public virtual SyncAttributeMapping_SyncDirection? SyncDirection
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return ((SyncAttributeMapping_SyncDirection?)(EntityOptionSetEnum.GetEnum(this, "syncdirection")));
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SyncDirection");
				this.SetAttributeValue("syncdirection", value.HasValue ? new Microsoft.Xrm.Sdk.OptionSetValue((int)value) : null);
				this.OnPropertyChanged("SyncDirection");
			}
		}
		
		/// <summary>
		/// N:1 lk_syncattributemapping_syncattributemappingprofileid
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("syncattributemappingprofileid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_syncattributemapping_syncattributemappingprofileid")]
		public CrmEarlyBound.SyncAttributeMappingProfile lk_syncattributemapping_syncattributemappingprofileid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SyncAttributeMappingProfile>("lk_syncattributemapping_syncattributemappingprofileid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_syncattributemapping_syncattributemappingprofileid");
				this.SetRelatedEntity<CrmEarlyBound.SyncAttributeMappingProfile>("lk_syncattributemapping_syncattributemappingprofileid", null, value);
				this.OnPropertyChanged("lk_syncattributemapping_syncattributemappingprofileid");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SyncAttributeMapping(object anonymousType) : 
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
                        Attributes["syncattributemappingid"] = base.Id;
                        break;
                    case "syncattributemappingid":
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