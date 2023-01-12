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
	/// Represents the objects with which a trace record is associated. For internal use only.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("traceassociation")]
	public partial class TraceAssociation : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string OrganizationId = "organizationid";
			public const string RegardingObjectId = "regardingobjectid";
			public const string TraceAssociationId = "traceassociationid";
			public const string Id = "traceassociationid";
			public const string TraceLogId = "tracelogid";
			public const string organization_traceassociation = "organization_traceassociation";
			public const string traceassociation_TraceLog = "traceassociation_TraceLog";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public TraceAssociation() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "traceassociation";
		
		public const string EntitySchemaName = "TraceAssociation";
		
		public const string PrimaryIdAttribute = "traceassociationid";
		
		public const string EntityLogicalCollectionName = "traceassociations";
		
		public const string EntitySetName = "traceassociations";
		
		public const int EntityTypeCode = 8051;
		
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
		/// Unique identifier of the organization associated with the trace association.
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
		/// Unique identifier of the object the trace association is regarding.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("regardingobjectid")]
		public Microsoft.Xrm.Sdk.EntityReference RegardingObjectId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("regardingobjectid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RegardingObjectId");
				this.SetAttributeValue("regardingobjectid", value);
				this.OnPropertyChanged("RegardingObjectId");
			}
		}
		
		/// <summary>
		/// Unique identifier of the trace association.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traceassociationid")]
		public System.Nullable<System.Guid> TraceAssociationId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("traceassociationid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TraceAssociationId");
				this.SetAttributeValue("traceassociationid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("TraceAssociationId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("traceassociationid")]
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
				this.TraceAssociationId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the trace.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tracelogid")]
		public Microsoft.Xrm.Sdk.EntityReference TraceLogId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("tracelogid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TraceLogId");
				this.SetAttributeValue("tracelogid", value);
				this.OnPropertyChanged("TraceLogId");
			}
		}
		
		/// <summary>
		/// N:1 organization_traceassociation
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_traceassociation")]
		public CrmEarlyBound.Organization organization_traceassociation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Organization>("organization_traceassociation", null);
			}
		}
		
		/// <summary>
		/// N:1 traceassociation_TraceLog
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("tracelogid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("traceassociation_TraceLog")]
		public CrmEarlyBound.TraceLog traceassociation_TraceLog
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.TraceLog>("traceassociation_TraceLog", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("traceassociation_TraceLog");
				this.SetRelatedEntity<CrmEarlyBound.TraceLog>("traceassociation_TraceLog", null, value);
				this.OnPropertyChanged("traceassociation_TraceLog");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public TraceAssociation(object anonymousType) : 
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
                        Attributes["traceassociationid"] = base.Id;
                        break;
                    case "traceassociationid":
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