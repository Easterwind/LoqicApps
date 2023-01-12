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
	/// For internal use only.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("subscription")]
	public partial class Subscription : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string ClientVersion = "clientversion";
			public const string CompletedSyncStartedOn = "completedsyncstartedon";
			public const string CompletedSyncVersionNumber = "completedsyncversionnumber";
			public const string LastSyncStartedOn = "lastsyncstartedon";
			public const string MachineName = "machinename";
			public const string ReInitialize = "reinitialize";
			public const string ResetForCreate = "resetforcreate";
			public const string SubscriptionId = "subscriptionid";
			public const string Id = "subscriptionid";
			public const string SubscriptionType = "subscriptiontype";
			public const string SyncEntryTableName = "syncentrytablename";
			public const string SystemUserId = "systemuserid";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
		}
		
		public static class Relationships
		{
			public const string contact_subscription_association = "contact_subscription_association";
			public const string task_subscription_association = "task_subscription_association";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Subscription() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "subscription";
		
		public const string EntitySchemaName = "Subscription";
		
		public const string PrimaryIdAttribute = "subscriptionid";
		
		public const string EntityLogicalCollectionName = "subscriptions";
		
		public const string EntitySetName = "subscriptions";
		
		public const int EntityTypeCode = 29;
		
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
		/// Client Version.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("clientversion")]
		public string ClientVersion
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("clientversion");
			}
		}
		
		/// <summary>
		/// UTC time when the last successfully completed synchronization was started. This is the difference between local time and standard Coordinated Universal Time.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completedsyncstartedon")]
		public System.Nullable<System.DateTime> CompletedSyncStartedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("completedsyncstartedon");
			}
		}
		
		/// <summary>
		/// Database time stamp at the start time of the last successfully completed synchronization.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("completedsyncversionnumber")]
		public System.Nullable<long> CompletedSyncVersionNumber
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<long>>("completedsyncversionnumber");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("lastsyncstartedon")]
		public System.Nullable<System.DateTime> LastSyncStartedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("lastsyncstartedon");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("machinename")]
		public string MachineName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("machinename");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MachineName");
				this.SetAttributeValue("machinename", value);
				this.OnPropertyChanged("MachineName");
			}
		}
		
		/// <summary>
		/// Database time stamp at the start time of the last successfully completed synchronization.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("reinitialize")]
		public System.Nullable<bool> ReInitialize
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("reinitialize");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ReInitialize");
				this.SetAttributeValue("reinitialize", value);
				this.OnPropertyChanged("ReInitialize");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("resetforcreate")]
		public System.Nullable<bool> ResetForCreate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("resetforcreate");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ResetForCreate");
				this.SetAttributeValue("resetforcreate", value);
				this.OnPropertyChanged("ResetForCreate");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subscriptionid")]
		public System.Nullable<System.Guid> SubscriptionId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("subscriptionid");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subscriptionid")]
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
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subscriptiontype")]
		public System.Nullable<int> SubscriptionType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("subscriptiontype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SubscriptionType");
				this.SetAttributeValue("subscriptiontype", value);
				this.OnPropertyChanged("SubscriptionType");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("syncentrytablename")]
		public string SyncEntryTableName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("syncentrytablename");
			}
		}
		
		/// <summary>
		/// For internal use only.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("systemuserid")]
		public System.Nullable<System.Guid> SystemUserId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("systemuserid");
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
		/// 1:N subscription_subscriptionsyncinfo
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("subscription_subscriptionsyncinfo")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.SubscriptionSyncInfo> subscription_subscriptionsyncinfo
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.SubscriptionSyncInfo>("subscription_subscriptionsyncinfo", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("subscription_subscriptionsyncinfo");
				this.SetRelatedEntities<CrmEarlyBound.SubscriptionSyncInfo>("subscription_subscriptionsyncinfo", null, value);
				this.OnPropertyChanged("subscription_subscriptionsyncinfo");
			}
		}
		
		/// <summary>
		/// 1:N subscriptionclients_subscription
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("subscriptionclients_subscription")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.SubscriptionClients> subscriptionclients_subscription
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.SubscriptionClients>("subscriptionclients_subscription", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("subscriptionclients_subscription");
				this.SetRelatedEntities<CrmEarlyBound.SubscriptionClients>("subscriptionclients_subscription", null, value);
				this.OnPropertyChanged("subscriptionclients_subscription");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_subscription
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_subscription")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> userentityinstancedata_subscription
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_subscription", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_subscription");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_subscription", null, value);
				this.OnPropertyChanged("userentityinstancedata_subscription");
			}
		}
		
		/// <summary>
		/// N:N contact_subscription_association
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("contact_subscription_association")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.Contact> contact_subscription_association
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.Contact>("contact_subscription_association", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("contact_subscription_association");
				this.SetRelatedEntities<CrmEarlyBound.Contact>("contact_subscription_association", null, value);
				this.OnPropertyChanged("contact_subscription_association");
			}
		}
		
		/// <summary>
		/// N:N task_subscription_association
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("task_subscription_association")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.Task> task_subscription_association
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.Task>("task_subscription_association", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("task_subscription_association");
				this.SetRelatedEntities<CrmEarlyBound.Task>("task_subscription_association", null, value);
				this.OnPropertyChanged("task_subscription_association");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Subscription(object anonymousType) : 
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
                        Attributes["subscriptionid"] = base.Id;
                        break;
                    case "subscriptionid":
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