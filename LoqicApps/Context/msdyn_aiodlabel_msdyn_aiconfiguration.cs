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
	/// 
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("msdyn_aiodlabel_msdyn_aiconfiguration")]
	public partial class msdyn_aiodlabel_msdyn_aiconfiguration : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string msdyn_aiconfigurationid = "msdyn_aiconfigurationid";
			public const string msdyn_aiodlabel_msdyn_aiconfigurationId = "msdyn_aiodlabel_msdyn_aiconfigurationid";
			public const string Id = "msdyn_aiodlabel_msdyn_aiconfigurationid";
			public const string msdyn_aiodlabelid = "msdyn_aiodlabelid";
			public const string VersionNumber = "versionnumber";
		}
		
		public static class Relationships
		{
			public const string msdyn_aiodlabel_msdyn_aiconfiguration1 = "msdyn_aiodlabel_msdyn_aiconfiguration";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msdyn_aiodlabel_msdyn_aiconfiguration() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "msdyn_aiodlabel_msdyn_aiconfiguration";
		
		public const string EntitySchemaName = "msdyn_aiodlabel_msdyn_aiconfiguration";
		
		public const string PrimaryIdAttribute = "msdyn_aiodlabel_msdyn_aiconfigurationid";
		
		public const string EntityLogicalCollectionName = null;
		
		public const string EntitySetName = "msdyn_aiodlabel_msdyn_aiconfigurationset";
		
		public const int EntityTypeCode = 10071;
		
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
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_aiconfigurationid")]
		public System.Nullable<System.Guid> msdyn_aiconfigurationid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("msdyn_aiconfigurationid");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_aiodlabel_msdyn_aiconfigurationid")]
		public System.Nullable<System.Guid> msdyn_aiodlabel_msdyn_aiconfigurationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("msdyn_aiodlabel_msdyn_aiconfigurationid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_aiodlabel_msdyn_aiconfigurationid")]
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
				base.Id = value;
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("msdyn_aiodlabelid")]
		public System.Nullable<System.Guid> msdyn_aiodlabelid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("msdyn_aiodlabelid");
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
		/// N:N msdyn_aiodlabel_msdyn_aiconfiguration
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_aiodlabel_msdyn_aiconfiguration")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.msdyn_AIOdLabel> msdyn_aiodlabel_msdyn_aiconfiguration1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.msdyn_AIOdLabel>("msdyn_aiodlabel_msdyn_aiconfiguration", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_aiodlabel_msdyn_aiconfiguration1");
				this.SetRelatedEntities<CrmEarlyBound.msdyn_AIOdLabel>("msdyn_aiodlabel_msdyn_aiconfiguration", null, value);
				this.OnPropertyChanged("msdyn_aiodlabel_msdyn_aiconfiguration1");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public msdyn_aiodlabel_msdyn_aiconfiguration(object anonymousType) : 
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
                        Attributes["msdyn_aiodlabel_msdyn_aiconfigurationid"] = base.Id;
                        break;
                    case "msdyn_aiodlabel_msdyn_aiconfigurationid":
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