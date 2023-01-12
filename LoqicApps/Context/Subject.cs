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
	/// Information regarding subjects available in the system.
	/// </summary>
	[System.Runtime.Serialization.DataContractAttribute()]
	[Microsoft.Xrm.Sdk.Client.EntityLogicalNameAttribute("subject")]
	public partial class Subject : Microsoft.Xrm.Sdk.Entity, System.ComponentModel.INotifyPropertyChanging, System.ComponentModel.INotifyPropertyChanged
	{
		
		public static class Fields
		{
			public const string CreatedBy = "createdby";
			public const string CreatedByExternalParty = "createdbyexternalparty";
			public const string CreatedOn = "createdon";
			public const string CreatedOnBehalfBy = "createdonbehalfby";
			public const string Description = "description";
			public const string FeatureMask = "featuremask";
			public const string ImportSequenceNumber = "importsequencenumber";
			public const string ModifiedBy = "modifiedby";
			public const string ModifiedByExternalParty = "modifiedbyexternalparty";
			public const string ModifiedOn = "modifiedon";
			public const string ModifiedOnBehalfBy = "modifiedonbehalfby";
			public const string OrganizationId = "organizationid";
			public const string OverriddenCreatedOn = "overriddencreatedon";
			public const string ParentSubject = "parentsubject";
			public const string SubjectId = "subjectid";
			public const string Id = "subjectid";
			public const string Title = "title";
			public const string VersionNumber = "versionnumber";
			public const string lk_externalparty_subject_createdby = "lk_externalparty_subject_createdby";
			public const string lk_externalparty_subject_modifiedby = "lk_externalparty_subject_modifiedby";
			public const string lk_subject_createdonbehalfby = "lk_subject_createdonbehalfby";
			public const string lk_subject_modifiedonbehalfby = "lk_subject_modifiedonbehalfby";
			public const string lk_subjectbase_createdby = "lk_subjectbase_createdby";
			public const string lk_subjectbase_modifiedby = "lk_subjectbase_modifiedby";
			public const string organization_subjects = "organization_subjects";
			public const string Referencingsubject_parent_subject = "subject_parent_subject";
		}
		
		/// <summary>
		/// Default Constructor.
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Subject() : 
				base(EntityLogicalName)
		{
		}
		
		public const string EntityLogicalName = "subject";
		
		public const string EntitySchemaName = "Subject";
		
		public const string PrimaryIdAttribute = "subjectid";
		
		public const string PrimaryNameAttribute = "title";
		
		public const string EntityLogicalCollectionName = "subjects";
		
		public const string EntitySetName = "subjects";
		
		public const int EntityTypeCode = 129;
		
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
		/// Unique identifier of the user who created the subject.
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
		/// Shows the external party who created the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference CreatedByExternalParty
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("createdbyexternalparty");
			}
		}
		
		/// <summary>
		/// Date and time when the subject was created.
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
		/// Unique identifier of the delegate user who created the subject.
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
		/// Description of the subject.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("description")]
		public string Description
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("description");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Description");
				this.SetAttributeValue("description", value);
				this.OnPropertyChanged("Description");
			}
		}
		
		/// <summary>
		/// Information that specifies when the subject will be displayed in lists of subjects.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("featuremask")]
		public System.Nullable<int> FeatureMask
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<int>>("featuremask");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("FeatureMask");
				this.SetAttributeValue("featuremask", value);
				this.OnPropertyChanged("FeatureMask");
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
		/// Unique identifier of the user who last modified the subject.
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
		/// Shows the external party who modified the record.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyexternalparty")]
		public Microsoft.Xrm.Sdk.EntityReference ModifiedByExternalParty
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("modifiedbyexternalparty");
			}
		}
		
		/// <summary>
		/// Date and time when the subject was last modified.
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
		/// Unique identifier of the delegate user who last modified the subject.
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
		/// Unique identifier for the organization associated with the subject.
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
		/// Date and time that the record was migrated.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("overriddencreatedon")]
		public System.Nullable<System.DateTime> OverriddenCreatedOn
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.DateTime>>("overriddencreatedon");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("OverriddenCreatedOn");
				this.SetAttributeValue("overriddencreatedon", value);
				this.OnPropertyChanged("OverriddenCreatedOn");
			}
		}
		
		/// <summary>
		/// Unique identifier of the parent subject.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsubject")]
		public Microsoft.Xrm.Sdk.EntityReference ParentSubject
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<Microsoft.Xrm.Sdk.EntityReference>("parentsubject");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("ParentSubject");
				this.SetAttributeValue("parentsubject", value);
				this.OnPropertyChanged("ParentSubject");
			}
		}
		
		/// <summary>
		/// Unique identifier of the subject.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subjectid")]
		public System.Nullable<System.Guid> SubjectId
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<System.Nullable<System.Guid>>("subjectid");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("SubjectId");
				this.SetAttributeValue("subjectid", value);
				if (value.HasValue)
				{
					base.Id = value.Value;
				}
				else
				{
					base.Id = System.Guid.Empty;
				}
				this.OnPropertyChanged("SubjectId");
			}
		}
		
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("subjectid")]
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
				this.SubjectId = value;
			}
		}
		
		/// <summary>
		/// Title of the subject.
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("title")]
		public string Title
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetAttributeValue<string>("title");
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Title");
				this.SetAttributeValue("title", value);
				this.OnPropertyChanged("Title");
			}
		}
		
		/// <summary>
		/// Version number of the subject.
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
		/// 1:N adx_subject_webfile
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_subject_webfile")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.Adx_webfile> adx_subject_webfile
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.Adx_webfile>("adx_subject_webfile", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_subject_webfile");
				this.SetRelatedEntities<CrmEarlyBound.Adx_webfile>("adx_subject_webfile", null, value);
				this.OnPropertyChanged("adx_subject_webfile");
			}
		}
		
		/// <summary>
		/// 1:N adx_subject_webpage
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("adx_subject_webpage")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.Adx_webpage> adx_subject_webpage
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.Adx_webpage>("adx_subject_webpage", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("adx_subject_webpage");
				this.SetRelatedEntities<CrmEarlyBound.Adx_webpage>("adx_subject_webpage", null, value);
				this.OnPropertyChanged("adx_subject_webpage");
			}
		}
		
		/// <summary>
		/// 1:N is_primary_subject_for
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("is_primary_subject_for")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.DocumentIndex> is_primary_subject_for
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.DocumentIndex>("is_primary_subject_for", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("is_primary_subject_for");
				this.SetRelatedEntities<CrmEarlyBound.DocumentIndex>("is_primary_subject_for", null, value);
				this.OnPropertyChanged("is_primary_subject_for");
			}
		}
		
		/// <summary>
		/// 1:N msdyn_subject_knowledgearticletemplate_subjectid
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("msdyn_subject_knowledgearticletemplate_subjectid")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.msdyn_knowledgearticletemplate> msdyn_subject_knowledgearticletemplate_subjectid
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.msdyn_knowledgearticletemplate>("msdyn_subject_knowledgearticletemplate_subjectid", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("msdyn_subject_knowledgearticletemplate_subjectid");
				this.SetRelatedEntities<CrmEarlyBound.msdyn_knowledgearticletemplate>("msdyn_subject_knowledgearticletemplate_subjectid", null, value);
				this.OnPropertyChanged("msdyn_subject_knowledgearticletemplate_subjectid");
			}
		}
		
		/// <summary>
		/// 1:N Subject_AsyncOperations
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Subject_AsyncOperations")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.AsyncOperation> Subject_AsyncOperations
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.AsyncOperation>("Subject_AsyncOperations", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Subject_AsyncOperations");
				this.SetRelatedEntities<CrmEarlyBound.AsyncOperation>("Subject_AsyncOperations", null, value);
				this.OnPropertyChanged("Subject_AsyncOperations");
			}
		}
		
		/// <summary>
		/// 1:N Subject_BulkDeleteFailures
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Subject_BulkDeleteFailures")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.BulkDeleteFailure> Subject_BulkDeleteFailures
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.BulkDeleteFailure>("Subject_BulkDeleteFailures", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Subject_BulkDeleteFailures");
				this.SetRelatedEntities<CrmEarlyBound.BulkDeleteFailure>("Subject_BulkDeleteFailures", null, value);
				this.OnPropertyChanged("Subject_BulkDeleteFailures");
			}
		}
		
		/// <summary>
		/// 1:N subject_kb_articles
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("subject_kb_articles")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.KbArticle> subject_kb_articles
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.KbArticle>("subject_kb_articles", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("subject_kb_articles");
				this.SetRelatedEntities<CrmEarlyBound.KbArticle>("subject_kb_articles", null, value);
				this.OnPropertyChanged("subject_kb_articles");
			}
		}
		
		/// <summary>
		/// 1:N subject_knowledgearticles
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("subject_knowledgearticles")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.KnowledgeArticle> subject_knowledgearticles
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.KnowledgeArticle>("subject_knowledgearticles", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("subject_knowledgearticles");
				this.SetRelatedEntities<CrmEarlyBound.KnowledgeArticle>("subject_knowledgearticles", null, value);
				this.OnPropertyChanged("subject_knowledgearticles");
			}
		}
		
		/// <summary>
		/// 1:N subject_parent_subject
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("subject_parent_subject", Microsoft.Xrm.Sdk.EntityRole.Referenced)]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.Subject> Referencedsubject_parent_subject
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.Subject>("subject_parent_subject", Microsoft.Xrm.Sdk.EntityRole.Referenced);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencedsubject_parent_subject");
				this.SetRelatedEntities<CrmEarlyBound.Subject>("subject_parent_subject", Microsoft.Xrm.Sdk.EntityRole.Referenced, value);
				this.OnPropertyChanged("Referencedsubject_parent_subject");
			}
		}
		
		/// <summary>
		/// 1:N Subject_ProcessSessions
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Subject_ProcessSessions")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.ProcessSession> Subject_ProcessSessions
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.ProcessSession>("Subject_ProcessSessions", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Subject_ProcessSessions");
				this.SetRelatedEntities<CrmEarlyBound.ProcessSession>("Subject_ProcessSessions", null, value);
				this.OnPropertyChanged("Subject_ProcessSessions");
			}
		}
		
		/// <summary>
		/// 1:N Subject_SyncErrors
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("Subject_SyncErrors")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.SyncError> Subject_SyncErrors
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.SyncError>("Subject_SyncErrors", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Subject_SyncErrors");
				this.SetRelatedEntities<CrmEarlyBound.SyncError>("Subject_SyncErrors", null, value);
				this.OnPropertyChanged("Subject_SyncErrors");
			}
		}
		
		/// <summary>
		/// 1:N userentityinstancedata_subject
		/// </summary>
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("userentityinstancedata_subject")]
		public System.Collections.Generic.IEnumerable<CrmEarlyBound.UserEntityInstanceData> userentityinstancedata_subject
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_subject", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("userentityinstancedata_subject");
				this.SetRelatedEntities<CrmEarlyBound.UserEntityInstanceData>("userentityinstancedata_subject", null, value);
				this.OnPropertyChanged("userentityinstancedata_subject");
			}
		}
		
		/// <summary>
		/// N:1 lk_externalparty_subject_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdbyexternalparty")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_externalparty_subject_createdby")]
		public CrmEarlyBound.ExternalParty lk_externalparty_subject_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.ExternalParty>("lk_externalparty_subject_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_externalparty_subject_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedbyexternalparty")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_externalparty_subject_modifiedby")]
		public CrmEarlyBound.ExternalParty lk_externalparty_subject_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.ExternalParty>("lk_externalparty_subject_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_subject_createdonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_subject_createdonbehalfby")]
		public CrmEarlyBound.SystemUser lk_subject_createdonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_subject_createdonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_subject_createdonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_subject_createdonbehalfby", null, value);
				this.OnPropertyChanged("lk_subject_createdonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_subject_modifiedonbehalfby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedonbehalfby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_subject_modifiedonbehalfby")]
		public CrmEarlyBound.SystemUser lk_subject_modifiedonbehalfby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_subject_modifiedonbehalfby", null);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("lk_subject_modifiedonbehalfby");
				this.SetRelatedEntity<CrmEarlyBound.SystemUser>("lk_subject_modifiedonbehalfby", null, value);
				this.OnPropertyChanged("lk_subject_modifiedonbehalfby");
			}
		}
		
		/// <summary>
		/// N:1 lk_subjectbase_createdby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("createdby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_subjectbase_createdby")]
		public CrmEarlyBound.SystemUser lk_subjectbase_createdby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_subjectbase_createdby", null);
			}
		}
		
		/// <summary>
		/// N:1 lk_subjectbase_modifiedby
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("modifiedby")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("lk_subjectbase_modifiedby")]
		public CrmEarlyBound.SystemUser lk_subjectbase_modifiedby
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.SystemUser>("lk_subjectbase_modifiedby", null);
			}
		}
		
		/// <summary>
		/// N:1 organization_subjects
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("organizationid")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("organization_subjects")]
		public CrmEarlyBound.Organization organization_subjects
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Organization>("organization_subjects", null);
			}
		}
		
		/// <summary>
		/// N:1 subject_parent_subject
		/// </summary>
		[Microsoft.Xrm.Sdk.AttributeLogicalNameAttribute("parentsubject")]
		[Microsoft.Xrm.Sdk.RelationshipSchemaNameAttribute("subject_parent_subject", Microsoft.Xrm.Sdk.EntityRole.Referencing)]
		public CrmEarlyBound.Subject Referencingsubject_parent_subject
		{
			[System.Diagnostics.DebuggerNonUserCode()]
			get
			{
				return this.GetRelatedEntity<CrmEarlyBound.Subject>("subject_parent_subject", Microsoft.Xrm.Sdk.EntityRole.Referencing);
			}
			[System.Diagnostics.DebuggerNonUserCode()]
			set
			{
				this.OnPropertyChanging("Referencingsubject_parent_subject");
				this.SetRelatedEntity<CrmEarlyBound.Subject>("subject_parent_subject", Microsoft.Xrm.Sdk.EntityRole.Referencing, value);
				this.OnPropertyChanged("Referencingsubject_parent_subject");
			}
		}
		
		/// <summary>
		/// Constructor for populating via LINQ queries given a LINQ anonymous type
		/// <param name="anonymousType">LINQ anonymous type.</param>
		/// </summary>
		[System.Diagnostics.DebuggerNonUserCode()]
		public Subject(object anonymousType) : 
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
                        Attributes["subjectid"] = base.Id;
                        break;
                    case "subjectid":
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