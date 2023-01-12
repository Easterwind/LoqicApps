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
	/// Internal authorization table to track user authorization changes
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("systemuserauthorizationchangetracker")]
	public partial class SystemUserAuthorizationChangeTracker : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ChangedOn = "changedon";
			public const string ChangedVersionNumber = "changedversionnumber";
			public const string ComputedOn = "computedon";
			public const string ComputedVersionNumber = "computedversionnumber";
			public const string SystemUserId = "systemuserid";
			public const string Id = "systemuserid";
			public const string user_userauthztracker = "user_userauthztracker";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SystemUserAuthorizationChangeTracker() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "systemuserauthorizationchangetracker";
		
		public const string EntitySchemaName = "SystemUserAuthorizationChangeTracker";
		
		public const string PrimaryIdAttribute = "systemuserid";
		
		public const string EntityLogicalCollectionName = "systemuserauthorizationchangetrackers";
		
		public const string EntitySetName = "systemuserauthorizationchangetrackers";
		
		public const int EntityTypeCode = 60;
		
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
		/// Date and time when the column ChangedVersionNumber was changed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("changedon")]
		public System.Nullable<System.DateTime> ChangedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("changedon");
			}
		}
		
		/// <summary>
		/// Database time stamp when user authorization settings were changed
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("changedversionnumber")]
		public System.Nullable<long> ChangedVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("changedversionnumber");
			}
		}
		
		/// <summary>
		/// Date and time when the column ComputedVersionNumber was changed.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("computedon")]
		public System.Nullable<System.DateTime> ComputedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("computedon");
			}
		}
		
		/// <summary>
		/// Database time stamp when user authorization data were started recompute
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("computedversionnumber")]
		public System.Nullable<long> ComputedVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("computedversionnumber");
			}
		}
		
		/// <summary>
		/// Unique identifier for the user
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
		public System.Nullable<System.Guid> SystemUserId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SystemUserId");
				this.SetAttributeValue("systemuserid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SystemUserId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
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
				this.SystemUserId = value;
			}
		}
		
		/// <summary>
		/// 1:N systemuserauthorizationchangetracker_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuserauthorizationchangetracker_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.AsyncOperation> systemuserauthorizationchangetracker_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.AsyncOperation>("systemuserauthorizationchangetracker_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("systemuserauthorizationchangetracker_AsyncOperations");
				this.SetRelatedEntities<CrmEarlyBound.AsyncOperation>("systemuserauthorizationchangetracker_AsyncOperations", null, value);
				this.OnPropertyChanged("systemuserauthorizationchangetracker_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N systemuserauthorizationchangetracker_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuserauthorizationchangetracker_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.BulkDeleteFailure> systemuserauthorizationchangetracker_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.BulkDeleteFailure>("systemuserauthorizationchangetracker_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("systemuserauthorizationchangetracker_BulkDeleteFailures");
				this.SetRelatedEntities<CrmEarlyBound.BulkDeleteFailure>("systemuserauthorizationchangetracker_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("systemuserauthorizationchangetracker_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N systemuserauthorizationchangetracker_MailboxTrackingFolders
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuserauthorizationchangetracker_MailboxTrackingFolders")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.MailboxTrackingFolder> systemuserauthorizationchangetracker_MailboxTrackingFolders
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.MailboxTrackingFolder>("systemuserauthorizationchangetracker_MailboxTrackingFolders", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("systemuserauthorizationchangetracker_MailboxTrackingFolders");
				this.SetRelatedEntities<CrmEarlyBound.MailboxTrackingFolder>("systemuserauthorizationchangetracker_MailboxTrackingFolders", null, value);
				this.OnPropertyChanged("systemuserauthorizationchangetracker_MailboxTrackingFolders");
			}
		}
		
		/// <summary>
		/// 1:N systemuserauthorizationchangetracker_PrincipalObjectAttributeAccesses
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuserauthorizationchangetracker_PrincipalObjectAttributeAccesses")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.PrincipalObjectAttributeAccess> systemuserauthorizationchangetracker_PrincipalObjectAttributeAccesses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.PrincipalObjectAttributeAccess>("systemuserauthorizationchangetracker_PrincipalObjectAttributeAccesses", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("systemuserauthorizationchangetracker_PrincipalObjectAttributeAccesses");
				this.SetRelatedEntities<CrmEarlyBound.PrincipalObjectAttributeAccess>("systemuserauthorizationchangetracker_PrincipalObjectAttributeAccesses", null, value);
				this.OnPropertyChanged("systemuserauthorizationchangetracker_PrincipalObjectAttributeAccesses");
			}
		}
		
		/// <summary>
		/// 1:N systemuserauthorizationchangetracker_ProcessSession
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuserauthorizationchangetracker_ProcessSession")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.ProcessSession> systemuserauthorizationchangetracker_ProcessSession
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.ProcessSession>("systemuserauthorizationchangetracker_ProcessSession", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("systemuserauthorizationchangetracker_ProcessSession");
				this.SetRelatedEntities<CrmEarlyBound.ProcessSession>("systemuserauthorizationchangetracker_ProcessSession", null, value);
				this.OnPropertyChanged("systemuserauthorizationchangetracker_ProcessSession");
			}
		}
		
		/// <summary>
		/// 1:N systemuserauthorizationchangetracker_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuserauthorizationchangetracker_SyncErrors")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.SyncError> systemuserauthorizationchangetracker_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.SyncError>("systemuserauthorizationchangetracker_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("systemuserauthorizationchangetracker_SyncErrors");
				this.SetRelatedEntities<CrmEarlyBound.SyncError>("systemuserauthorizationchangetracker_SyncErrors", null, value);
				this.OnPropertyChanged("systemuserauthorizationchangetracker_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N systemuserauthorizationchangetracker_UserEntityInstanceDatas
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("systemuserauthorizationchangetracker_UserEntityInstanceDatas")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> systemuserauthorizationchangetracker_UserEntityInstanceDatas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("systemuserauthorizationchangetracker_UserEntityInstanceDatas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("systemuserauthorizationchangetracker_UserEntityInstanceDatas");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("systemuserauthorizationchangetracker_UserEntityInstanceDatas", null, value);
				this.OnPropertyChanged("systemuserauthorizationchangetracker_UserEntityInstanceDatas");
			}
		}
		
		/// <summary>
		/// N:1 user_userauthztracker
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("user_userauthztracker")]
		public CrmEarlyBound.SystemUser user_userauthztracker
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("user_userauthztracker", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("user_userauthztracker");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("user_userauthztracker", null, value);
				this.OnPropertyChanged("user_userauthztracker");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public SystemUserAuthorizationChangeTracker(object anonymousType) : 
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
                        Attributes["systemuserid"] = base.Id;
                        break;
                    case "systemuserid":
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