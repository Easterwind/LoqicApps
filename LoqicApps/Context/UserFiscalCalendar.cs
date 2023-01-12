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
	/// Custom fiscal calendar used for tracking sales quotas.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("userfiscalcalendar")]
	public partial class UserFiscalCalendar : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string BusinessUnitId = "businessunitid";
			public const string CreatedBy = "createdby";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string EffectiveOn = "effectiveon";
			public const string ExchangeRate = "exchangerate";
			public const string FiscalPeriodType = "fiscalperiodtype";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string Period1 = "period1";
			public const string Period1_Base = "period1_base";
			public const string Period10 = "period10";
			public const string Period10_Base = "period10_base";
			public const string Period11 = "period11";
			public const string Period11_Base = "period11_base";
			public const string Period12 = "period12";
			public const string Period12_Base = "period12_base";
			public const string Period13 = "period13";
			public const string Period13_Base = "period13_base";
			public const string Period2 = "period2";
			public const string Period2_Base = "period2_base";
			public const string Period3 = "period3";
			public const string Period3_Base = "period3_base";
			public const string Period4 = "period4";
			public const string Period4_Base = "period4_base";
			public const string Period5 = "period5";
			public const string Period5_Base = "period5_base";
			public const string Period6 = "period6";
			public const string Period6_Base = "period6_base";
			public const string Period7 = "period7";
			public const string Period7_Base = "period7_base";
			public const string Period8 = "period8";
			public const string Period8_Base = "period8_base";
			public const string Period9 = "period9";
			public const string Period9_Base = "period9_base";
			public const string SalesPersonId = "salespersonid";
			public const string TimeZoneRuleVersionNumber = "timezoneruleversionnumber";
			public const string TransactionCurrencyId = "transactioncurrencyid";
			public const string UserFiscalCalendarId = "userfiscalcalendarid";
			public const string Id = "userfiscalcalendarid";
			public const string UTCConversionTimeZoneCode = "utcconversiontimezonecode";
			public const string lk_userfiscalcalendar_businessunit = "lk_userfiscalcalendar_businessunit";
			public const string lk_userfiscalcalendar_createdby = "lk_userfiscalcalendar_createdby";
			public const string lk_userfiscalcalendar_createdonbehalfby = "lk_userfiscalcalendar_createdonbehalfby";
			public const string lk_userfiscalcalendar_modifiedby = "lk_userfiscalcalendar_modifiedby";
			public const string lk_userfiscalcalendar_modifiedonbehalfby = "lk_userfiscalcalendar_modifiedonbehalfby";
			public const string system_user_quotas = "system_user_quotas";
			public const string transactioncurrency_userfiscalcalendar = "transactioncurrency_userfiscalcalendar";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public UserFiscalCalendar() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "userfiscalcalendar";
		
		public const string EntitySchemaName = "UserFiscalCalendar";
		
		public const string PrimaryIdAttribute = "userfiscalcalendarid";
		
		public const string EntityLogicalCollectionName = "userfiscalcalendars";
		
		public const string EntitySetName = "userfiscalcalendars";
		
		public const int EntityTypeCode = 1086;
		
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
		/// Unique identifier of the business unit with which the user fiscal calendar is associated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		public System.Nullable<System.Guid> BusinessUnitId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("businessunitid");
			}
		}
		
		/// <summary>
		/// Unique identifier of the user who created the fiscal calendar.
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
		/// Date and time when the fiscal calendar was created.
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
		/// Unique identifier of the delegate user who created the userfiscalcalendar.
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
		/// Date and time when the fiscal calendar takes effect.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("effectiveon")]
		public System.Nullable<System.DateTime> EffectiveOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("effectiveon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("EffectiveOn");
				this.SetAttributeValue("effectiveon", value);
				this.OnPropertyChanged("EffectiveOn");
			}
		}
		
		/// <summary>
		/// Exchange rate for the currency associated with the user fiscal calendar with respect to the base currency.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("exchangerate")]
		public System.Nullable<decimal> ExchangeRate
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<decimal>>("exchangerate");
			}
		}
		
		/// <summary>
		/// Type of fiscal period used in the fiscal calendar.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("fiscalperiodtype")]
		public System.Nullable<int> FiscalPeriodType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("fiscalperiodtype");
			}
		}
		
		/// <summary>
		/// Unique identifier of the data import or data migration that created this record.
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
		/// Unique identifier of the user who last modified the fiscal calendar.
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
		/// Date and time when the fiscal calendar was last modified.
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
		/// Unique identifier of the delegate user who last modified the userfiscalcalendar.
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
		/// Sales quota for the first period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period1")]
		public Microsoft.Xrm.Sdk.Money Period1
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period1");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Period1");
				this.SetAttributeValue("period1", value);
				this.OnPropertyChanged("Period1");
			}
		}
		
		/// <summary>
		/// Base currency equivalent of the sales quota for the first period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period1_base")]
		public Microsoft.Xrm.Sdk.Money Period1_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period1_base");
			}
		}
		
		/// <summary>
		/// Sales quota for the tenth period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period10")]
		public Microsoft.Xrm.Sdk.Money Period10
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period10");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Period10");
				this.SetAttributeValue("period10", value);
				this.OnPropertyChanged("Period10");
			}
		}
		
		/// <summary>
		/// Base currency equivalent of the sales quota for the tenth period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period10_base")]
		public Microsoft.Xrm.Sdk.Money Period10_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period10_base");
			}
		}
		
		/// <summary>
		/// Sales quota for the eleventh period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period11")]
		public Microsoft.Xrm.Sdk.Money Period11
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period11");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Period11");
				this.SetAttributeValue("period11", value);
				this.OnPropertyChanged("Period11");
			}
		}
		
		/// <summary>
		/// Base currency equivalent of the sales quota for the eleventh period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period11_base")]
		public Microsoft.Xrm.Sdk.Money Period11_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period11_base");
			}
		}
		
		/// <summary>
		/// Sales quota for the twelfth period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period12")]
		public Microsoft.Xrm.Sdk.Money Period12
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period12");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Period12");
				this.SetAttributeValue("period12", value);
				this.OnPropertyChanged("Period12");
			}
		}
		
		/// <summary>
		/// Base currency equivalent of the sales quota for the twelfth period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period12_base")]
		public Microsoft.Xrm.Sdk.Money Period12_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period12_base");
			}
		}
		
		/// <summary>
		/// Sales quota for the thirteenth period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period13")]
		public Microsoft.Xrm.Sdk.Money Period13
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period13");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Period13");
				this.SetAttributeValue("period13", value);
				this.OnPropertyChanged("Period13");
			}
		}
		
		/// <summary>
		/// Base currency equivalent of the sales quota for the thirteenth period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period13_base")]
		public Microsoft.Xrm.Sdk.Money Period13_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period13_base");
			}
		}
		
		/// <summary>
		/// Sales quota for the second period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period2")]
		public Microsoft.Xrm.Sdk.Money Period2
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period2");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Period2");
				this.SetAttributeValue("period2", value);
				this.OnPropertyChanged("Period2");
			}
		}
		
		/// <summary>
		/// Base currency equivalent of the sales quota for the second period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period2_base")]
		public Microsoft.Xrm.Sdk.Money Period2_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period2_base");
			}
		}
		
		/// <summary>
		/// Sales quota for the third period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period3")]
		public Microsoft.Xrm.Sdk.Money Period3
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period3");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Period3");
				this.SetAttributeValue("period3", value);
				this.OnPropertyChanged("Period3");
			}
		}
		
		/// <summary>
		/// Base currency equivalent of the sales quota for the third period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period3_base")]
		public Microsoft.Xrm.Sdk.Money Period3_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period3_base");
			}
		}
		
		/// <summary>
		/// Sales quota for the fourth period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period4")]
		public Microsoft.Xrm.Sdk.Money Period4
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period4");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Period4");
				this.SetAttributeValue("period4", value);
				this.OnPropertyChanged("Period4");
			}
		}
		
		/// <summary>
		/// Base currency equivalent of the sales quota for the fourth period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period4_base")]
		public Microsoft.Xrm.Sdk.Money Period4_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period4_base");
			}
		}
		
		/// <summary>
		/// Sales quota for the fifth period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period5")]
		public Microsoft.Xrm.Sdk.Money Period5
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period5");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Period5");
				this.SetAttributeValue("period5", value);
				this.OnPropertyChanged("Period5");
			}
		}
		
		/// <summary>
		/// Base currency equivalent of the sales quota for the fifth period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period5_base")]
		public Microsoft.Xrm.Sdk.Money Period5_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period5_base");
			}
		}
		
		/// <summary>
		/// Sales quota for the sixth period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period6")]
		public Microsoft.Xrm.Sdk.Money Period6
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period6");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Period6");
				this.SetAttributeValue("period6", value);
				this.OnPropertyChanged("Period6");
			}
		}
		
		/// <summary>
		/// Base currency equivalent of the sales quota for the sixth period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period6_base")]
		public Microsoft.Xrm.Sdk.Money Period6_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period6_base");
			}
		}
		
		/// <summary>
		/// Sales quota for the seventh period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period7")]
		public Microsoft.Xrm.Sdk.Money Period7
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period7");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Period7");
				this.SetAttributeValue("period7", value);
				this.OnPropertyChanged("Period7");
			}
		}
		
		/// <summary>
		/// Base currency equivalent of the sales quota for the seventh period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period7_base")]
		public Microsoft.Xrm.Sdk.Money Period7_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period7_base");
			}
		}
		
		/// <summary>
		/// Sales quota for the eighth period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period8")]
		public Microsoft.Xrm.Sdk.Money Period8
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period8");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Period8");
				this.SetAttributeValue("period8", value);
				this.OnPropertyChanged("Period8");
			}
		}
		
		/// <summary>
		/// Base currency equivalent of the sales quota for the eighth period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period8_base")]
		public Microsoft.Xrm.Sdk.Money Period8_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period8_base");
			}
		}
		
		/// <summary>
		/// Sales quota for the ninth period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period9")]
		public Microsoft.Xrm.Sdk.Money Period9
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period9");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Period9");
				this.SetAttributeValue("period9", value);
				this.OnPropertyChanged("Period9");
			}
		}
		
		/// <summary>
		/// Base currency equivalent of the sales quota for the ninth period in the fiscal year.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("period9_base")]
		public Microsoft.Xrm.Sdk.Money Period9_Base
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.Money>("period9_base");
			}
		}
		
		/// <summary>
		/// Unique identifier of the salesperson to whom the fiscal calendar is assigned.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salespersonid")]
		public Microsoft.Xrm.Sdk.EntityReference SalesPersonId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("salespersonid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SalesPersonId");
				this.SetAttributeValue("salespersonid", value);
				this.OnPropertyChanged("SalesPersonId");
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
		/// Unique identifier of the currency associated with the user fiscal calendar.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		public Microsoft.Xrm.Sdk.EntityReference TransactionCurrencyId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("transactioncurrencyid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("TransactionCurrencyId");
				this.SetAttributeValue("transactioncurrencyid", value);
				this.OnPropertyChanged("TransactionCurrencyId");
			}
		}
		
		/// <summary>
		/// Unique identifier for the fiscal calendar.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userfiscalcalendarid")]
		public System.Nullable<System.Guid> UserFiscalCalendarId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("userfiscalcalendarid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UserFiscalCalendarId");
				this.SetAttributeValue("userfiscalcalendarid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("UserFiscalCalendarId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userfiscalcalendarid")]
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
				this.UserFiscalCalendarId = value;
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
		/// 1:N userentityinstancedata_userfiscalcalendar
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_userfiscalcalendar")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> userentityinstancedata_userfiscalcalendar
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_userfiscalcalendar", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_userfiscalcalendar");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_userfiscalcalendar", null, value);
				this.OnPropertyChanged("userentityinstancedata_userfiscalcalendar");
			}
		}
		
		/// <summary>
		/// N:1 lk_userfiscalcalendar_businessunit
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessunitid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userfiscalcalendar_businessunit")]
		public CrmEarlyBound.BusinessUnit lk_userfiscalcalendar_businessunit
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.BusinessUnit>("lk_userfiscalcalendar_businessunit", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_userfiscalcalendar_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userfiscalcalendar_createdby")]
		public CrmEarlyBound.SystemUser lk_userfiscalcalendar_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_userfiscalcalendar_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_userfiscalcalendar_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userfiscalcalendar_createdonbehalfby")]
		public CrmEarlyBound.SystemUser lk_userfiscalcalendar_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_userfiscalcalendar_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_userfiscalcalendar_createdonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_userfiscalcalendar_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_userfiscalcalendar_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_userfiscalcalendar_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userfiscalcalendar_modifiedby")]
		public CrmEarlyBound.SystemUser lk_userfiscalcalendar_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_userfiscalcalendar_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_userfiscalcalendar_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_userfiscalcalendar_modifiedonbehalfby")]
		public CrmEarlyBound.SystemUser lk_userfiscalcalendar_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_userfiscalcalendar_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_userfiscalcalendar_modifiedonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_userfiscalcalendar_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_userfiscalcalendar_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 system_user_quotas
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("salespersonid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("system_user_quotas")]
		public CrmEarlyBound.SystemUser system_user_quotas
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("system_user_quotas", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("system_user_quotas");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("system_user_quotas", null, value);
				this.OnPropertyChanged("system_user_quotas");
			}
		}
		
		/// <summary>
		/// N:1 transactioncurrency_userfiscalcalendar
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("transactioncurrencyid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("transactioncurrency_userfiscalcalendar")]
		public CrmEarlyBound.TransactionCurrency transactioncurrency_userfiscalcalendar
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.TransactionCurrency>("transactioncurrency_userfiscalcalendar", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("transactioncurrency_userfiscalcalendar");
				this.SetRelatedEntity<CrmEarlyBound.TransactionCurrency>("transactioncurrency_userfiscalcalendar", null, value);
				this.OnPropertyChanged("transactioncurrency_userfiscalcalendar");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public UserFiscalCalendar(object anonymousType) : 
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
                        Attributes["userfiscalcalendarid"] = base.Id;
                        break;
                    case "userfiscalcalendarid":
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