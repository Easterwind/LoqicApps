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
	public enum RollupJobState
	{
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Ready = 0,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Suspended = 1,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Locked = 2,
		
		[System.Runtime.Serialization.EnumMemberAttribute()]
		Completed = 3,
	}
	
	/// <summary>
	/// Stores rollup jobs.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("rollupjob")]
	public partial class RollupJob : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string rollupjob_rollupproperties = "rollupjob_rollupproperties";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public RollupJob() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "rollupjob";
		
		public const string EntitySchemaName = "RollupJob";
		
		public const string PrimaryIdAttribute = "rollupjobid";
		
		public const string EntityLogicalCollectionName = "rollupjobs";
		
		public const string EntitySetName = "rollupjobs";
		
		public const int EntityTypeCode = 9511;
		
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
		/// N:1 rollupjob_rollupproperties
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("rolluppropertiesid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("rollupjob_rollupproperties")]
		public CrmEarlyBound.RollupProperties rollupjob_rollupproperties
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.RollupProperties>("rollupjob_rollupproperties", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public RollupJob(object anonymousType) : 
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
                        Attributes["rollupjobid"] = base.Id;
                        break;
                    case "rollupjobid":
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