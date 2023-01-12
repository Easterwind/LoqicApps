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
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("multientitysearchentities")]
	public partial class MultiEntitySearchEntities : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string EntityName = "entityname";
			public const string EntityOrder = "entityorder";
			public const string MultiEntitySearchEntityId = "multientitysearchentityid";
			public const string Id = "multientitysearchentityid";
			public const string MultiEntitySearchId = "multientitysearchid";
			public const string VersionNumber = "versionnumber";
			public const string multientitysearch_multientitysearchentities = "multientitysearch_multientitysearchentities";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public MultiEntitySearchEntities() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "multientitysearchentities";
		
		public const string EntitySchemaName = "MultiEntitySearchEntities";
		
		public const string PrimaryIdAttribute = "multientitysearchentityid";
		
		public const string EntityLogicalCollectionName = "multientitysearchentitiescollection";
		
		public const string EntitySetName = "multientitysearchentitiescollection";
		
		public const int EntityTypeCode = 9911;
		
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
		/// Logical entity name of the entity participating in the multi entity search.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityname")]
		public string EntityName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("entityname");
			}
		}
		
		/// <summary>
		/// Order of the entity in the result collection.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entityorder")]
		public System.Nullable<int> EntityOrder
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("entityorder");
			}
		}
		
		/// <summary>
		/// Shows the entity used for the multiple entity search.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("multientitysearchentityid")]
		public System.Nullable<System.Guid> MultiEntitySearchEntityId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("multientitysearchentityid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("multientitysearchentityid")]
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
		/// Shows the ID of the multiple entity search.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("multientitysearchid")]
		public Microsoft.Xrm.Sdk.EntityReference MultiEntitySearchId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("multientitysearchid");
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
		/// N:1 multientitysearch_multientitysearchentities
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("multientitysearchid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("multientitysearch_multientitysearchentities")]
		public CrmEarlyBound.MultiEntitySearch multientitysearch_multientitysearchentities
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.MultiEntitySearch>("multientitysearch_multientitysearchentities", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public MultiEntitySearchEntities(object anonymousType) : 
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
                        Attributes["multientitysearchentityid"] = base.Id;
                        break;
                    case "multientitysearchentityid":
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