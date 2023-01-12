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
	/// A ribbon client metadata.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("ribbonclientmetadata")]
	public partial class RibbonClientMetadata : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ComponentState = "componentstate";
			public const string EntityLogicalName1 = "entitylogicalname";
			public const string RibbonContext = "ribboncontext";
			public const string RibbonId = "ribbonid";
			public const string Id = "ribbonid";
			public const string RibbonIdUnique = "ribbonidunique";
			public const string RibbonJson = "ribbonjson";
			public const string RibbonJsonFileRef = "ribbonjsonfileref";
			public const string RibbonJsonFileRef_Name = "ribbonjsonfileref_name";
			public const string SolutionId = "solutionid";
			public const string VersionNumber = "versionnumber";
			public const string FileAttachment_RibbonClientMetadata_RibbonJsonFileRef = "FileAttachment_RibbonClientMetadata_RibbonJsonFileRef";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public RibbonClientMetadata() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "ribbonclientmetadata";
		
		public const string EntitySchemaName = "RibbonClientMetadata";
		
		public const string PrimaryIdAttribute = "ribbonid";
		
		public const string EntityLogicalCollectionName = "ribbonclientmetadata";
		
		public const string EntitySetName = "ribbonclientmetadata";
		
		public const int EntityTypeCode = 4579;
		
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
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("componentstate")]
		public System.Nullable<int> ComponentState
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("componentstate");
			}
		}
		
		/// <summary>
		/// Entity logical name
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("entitylogicalname")]
		public string EntityLogicalName1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("entitylogicalname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EntityLogicalName1");
				this.SetAttributeValue("entitylogicalname", value);
				this.OnPropertyChanged("EntityLogicalName1");
			}
		}
		
		/// <summary>
		/// Ribbon context
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ribboncontext")]
		public string RibbonContext
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("ribboncontext");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RibbonContext");
				this.SetAttributeValue("ribboncontext", value);
				this.OnPropertyChanged("RibbonContext");
			}
		}
		
		/// <summary>
		/// Unique identifier of a ribbon client metadata.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ribbonid")]
		public System.Nullable<System.Guid> RibbonId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("ribbonid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RibbonId");
				this.SetAttributeValue("ribbonid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("RibbonId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ribbonid")]
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
				this.RibbonId = value;
			}
		}
		
		/// <summary>
		/// Unique identifier of the Ribbon client Metadata
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ribbonidunique")]
		public System.Nullable<System.Guid> RibbonIdUnique
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("ribbonidunique");
			}
		}
		
		/// <summary>
		/// Ribbon representation in JSON format.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ribbonjson")]
		public string RibbonJson
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("ribbonjson");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("RibbonJson");
				this.SetAttributeValue("ribbonjson", value);
				this.OnPropertyChanged("RibbonJson");
			}
		}
		
		/// <summary>
		/// Reference to the Ribbon JSON file on Azure.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ribbonjsonfileref")]
		public object RibbonJsonFileRef
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<object>("ribbonjsonfileref");
			}
		}
		
		/// <summary>
		/// 
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ribbonjsonfileref_name")]
		public string RibbonJsonFileRef_Name
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("ribbonjsonfileref_name");
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
		/// 1:N ribbonclientmetadata_FileAttachments
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("ribbonclientmetadata_FileAttachments")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.FileAttachment> ribbonclientmetadata_FileAttachments
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.FileAttachment>("ribbonclientmetadata_FileAttachments", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ribbonclientmetadata_FileAttachments");
				this.SetRelatedEntities<CrmEarlyBound.FileAttachment>("ribbonclientmetadata_FileAttachments", null, value);
				this.OnPropertyChanged("ribbonclientmetadata_FileAttachments");
			}
		}
		
		/// <summary>
		/// N:1 FileAttachment_RibbonClientMetadata_RibbonJsonFileRef
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("ribbonjsonfileref")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("FileAttachment_RibbonClientMetadata_RibbonJsonFileRef")]
		public CrmEarlyBound.FileAttachment FileAttachment_RibbonClientMetadata_RibbonJsonFileRef
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.FileAttachment>("FileAttachment_RibbonClientMetadata_RibbonJsonFileRef", null);
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public RibbonClientMetadata(object anonymousType) : 
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
                        Attributes["ribbonid"] = base.Id;
                        break;
                    case "ribbonid":
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