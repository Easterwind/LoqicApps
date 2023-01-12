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
	/// Virtual entity that represents AAD user
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("aaduser")]
	public partial class aaduser : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string aaduserId = "aaduserid";
			public const string Id = "aaduserid";
			public const string AccountEnabled = "accountenabled";
			public const string BusinessPhones = "businessphones";
			public const string City = "city";
			public const string CompanyName = "companyname";
			public const string CreatedDateTime = "createddatetime";
			public const string DisplayName = "displayname";
			public const string GivenName = "givenname";
			public const string id = "id";
			public const string ImAddresses = "imaddresses";
			public const string JobTitle = "jobtitle";
			public const string Mail = "mail";
			public const string MobilePhone = "mobilephone";
			public const string OfficeLocation = "officelocation";
			public const string PostalCode = "postalcode";
			public const string PreferredLanguage = "preferredlanguage";
			public const string StreetAddress = "streetaddress";
			public const string surname = "surname";
			public const string UserPrincipalName = "userprincipalname";
			public const string UserType = "usertype";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public aaduser() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "aaduser";
		
		public const string EntitySchemaName = "aaduser";
		
		public const string PrimaryIdAttribute = "aaduserid";
		
		public const string PrimaryNameAttribute = "displayname";
		
		public const string EntityLogicalCollectionName = "aadusers";
		
		public const string EntitySetName = "aadusers";
		
		public const int EntityTypeCode = 10017;
		
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
		/// Unique identifier of an aad user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aaduserid")]
		public System.Nullable<System.Guid> aaduserId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("aaduserid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("aaduserId");
				this.SetAttributeValue("aaduserid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("aaduserId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("aaduserid")]
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
				this.aaduserId = value;
			}
		}
		
		/// <summary>
		/// Indicates if the Account of an AAD User is enabled.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("accountenabled")]
		public System.Nullable<bool> AccountEnabled
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<bool>>("accountenabled");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("AccountEnabled");
				this.SetAttributeValue("accountenabled", value);
				this.OnPropertyChanged("AccountEnabled");
			}
		}
		
		/// <summary>
		/// Business phone number for the user
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("businessphones")]
		public string BusinessPhones
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("businessphones");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("BusinessPhones");
				this.SetAttributeValue("businessphones", value);
				this.OnPropertyChanged("BusinessPhones");
			}
		}
		
		/// <summary>
		/// City.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("city")]
		public string City
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("city");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("City");
				this.SetAttributeValue("city", value);
				this.OnPropertyChanged("City");
			}
		}
		
		/// <summary>
		/// Company Name.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("companyname")]
		public string CompanyName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("companyname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("CompanyName");
				this.SetAttributeValue("companyname", value);
				this.OnPropertyChanged("CompanyName");
			}
		}
		
		/// <summary>
		/// Date and time when the AAD user was created.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createddatetime")]
		public System.Nullable<System.DateTime> CreatedDateTime
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("createddatetime");
			}
		}
		
		/// <summary>
		/// The name displayed in the address book for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("displayname")]
		public string DisplayName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("displayname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("DisplayName");
				this.SetAttributeValue("displayname", value);
				this.OnPropertyChanged("DisplayName");
			}
		}
		
		/// <summary>
		/// The given name (first name) of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("givenname")]
		public string GivenName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("givenname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("GivenName");
				this.SetAttributeValue("givenname", value);
				this.OnPropertyChanged("GivenName");
			}
		}
		
		/// <summary>
		/// A unique identifer for AAD User
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("id")]
		public System.Nullable<System.Guid> id
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("id");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("id");
				this.SetAttributeValue("id", value);
				this.OnPropertyChanged("id");
			}
		}
		
		/// <summary>
		/// ImAddresses for the user
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("imaddresses")]
		public string ImAddresses
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("imaddresses");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ImAddresses");
				this.SetAttributeValue("imaddresses", value);
				this.OnPropertyChanged("ImAddresses");
			}
		}
		
		/// <summary>
		/// The user's job title.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("jobtitle")]
		public string JobTitle
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("jobtitle");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("JobTitle");
				this.SetAttributeValue("jobtitle", value);
				this.OnPropertyChanged("JobTitle");
			}
		}
		
		/// <summary>
		/// The SMTP address for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mail")]
		public string Mail
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("mail");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Mail");
				this.SetAttributeValue("mail", value);
				this.OnPropertyChanged("Mail");
			}
		}
		
		/// <summary>
		/// The primary cellular telephone number for the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("mobilephone")]
		public string MobilePhone
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("mobilephone");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("MobilePhone");
				this.SetAttributeValue("mobilephone", value);
				this.OnPropertyChanged("MobilePhone");
			}
		}
		
		/// <summary>
		/// The office location in the user's place of business.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("officelocation")]
		public string OfficeLocation
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("officelocation");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OfficeLocation");
				this.SetAttributeValue("officelocation", value);
				this.OnPropertyChanged("OfficeLocation");
			}
		}
		
		/// <summary>
		/// Postal Code.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("postalcode")]
		public string PostalCode
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("postalcode");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PostalCode");
				this.SetAttributeValue("postalcode", value);
				this.OnPropertyChanged("PostalCode");
			}
		}
		
		/// <summary>
		/// The preferred language for the user. Should follow ISO 639-1 Code; for example 'en-US'.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("preferredlanguage")]
		public string PreferredLanguage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("preferredlanguage");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("PreferredLanguage");
				this.SetAttributeValue("preferredlanguage", value);
				this.OnPropertyChanged("PreferredLanguage");
			}
		}
		
		/// <summary>
		/// Street Address.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("streetaddress")]
		public string StreetAddress
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("streetaddress");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("StreetAddress");
				this.SetAttributeValue("streetaddress", value);
				this.OnPropertyChanged("StreetAddress");
			}
		}
		
		/// <summary>
		/// The user's surname (family name or last name).
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("surname")]
		public string surname
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("surname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("surname");
				this.SetAttributeValue("surname", value);
				this.OnPropertyChanged("surname");
			}
		}
		
		/// <summary>
		/// The user principal name (UPN) of the user.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("userprincipalname")]
		public string UserPrincipalName
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("userprincipalname");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UserPrincipalName");
				this.SetAttributeValue("userprincipalname", value);
				this.OnPropertyChanged("UserPrincipalName");
			}
		}
		
		/// <summary>
		/// User Type.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("usertype")]
		public string UserType
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("usertype");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("UserType");
				this.SetAttributeValue("usertype", value);
				this.OnPropertyChanged("UserType");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public aaduser(object anonymousType) : 
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
                        Attributes["aaduserid"] = base.Id;
                        break;
                    case "aaduserid":
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