﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProgrammingClub.Models.DBObjects
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="clubmembership")]
	public partial class ClubMembershipModelsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMember(Member instance);
    partial void UpdateMember(Member instance);
    partial void DeleteMember(Member instance);
    partial void InsertMembership(Membership instance);
    partial void UpdateMembership(Membership instance);
    partial void DeleteMembership(Membership instance);
    partial void InsertMembershipType(MembershipType instance);
    partial void UpdateMembershipType(MembershipType instance);
    partial void DeleteMembershipType(MembershipType instance);
    partial void InsertAnnouncement(Announcement instance);
    partial void UpdateAnnouncement(Announcement instance);
    partial void DeleteAnnouncement(Announcement instance);
    partial void InsertCodeSnippet(CodeSnippet instance);
    partial void UpdateCodeSnippet(CodeSnippet instance);
    partial void DeleteCodeSnippet(CodeSnippet instance);
    #endregion
		
		public ClubMembershipModelsDataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["clubmembershipConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public ClubMembershipModelsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClubMembershipModelsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClubMembershipModelsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public ClubMembershipModelsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Member> Members
		{
			get
			{
				return this.GetTable<Member>();
			}
		}
		
		public System.Data.Linq.Table<Membership> Memberships
		{
			get
			{
				return this.GetTable<Membership>();
			}
		}
		
		public System.Data.Linq.Table<MembershipType> MembershipTypes
		{
			get
			{
				return this.GetTable<MembershipType>();
			}
		}
		
		public System.Data.Linq.Table<Announcement> Announcements
		{
			get
			{
				return this.GetTable<Announcement>();
			}
		}
		
		public System.Data.Linq.Table<CodeSnippet> CodeSnippets
		{
			get
			{
				return this.GetTable<CodeSnippet>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Members")]
	public partial class Member : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IDMember;
		
		private string _Name;
		
		private string _Title;
		
		private string _Position;
		
		private string _Description;
		
		private string _Resume;
		
		private EntitySet<Membership> _Memberships;
		
		private EntitySet<CodeSnippet> _CodeSnippets;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDMemberChanging(System.Guid value);
    partial void OnIDMemberChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnPositionChanging(string value);
    partial void OnPositionChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnResumeChanging(string value);
    partial void OnResumeChanged();
    #endregion
		
		public Member()
		{
			this._Memberships = new EntitySet<Membership>(new Action<Membership>(this.attach_Memberships), new Action<Membership>(this.detach_Memberships));
			this._CodeSnippets = new EntitySet<CodeSnippet>(new Action<CodeSnippet>(this.attach_CodeSnippets), new Action<CodeSnippet>(this.detach_CodeSnippets));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDMember", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IDMember
		{
			get
			{
				return this._IDMember;
			}
			set
			{
				if ((this._IDMember != value))
				{
					this.OnIDMemberChanging(value);
					this.SendPropertyChanging();
					this._IDMember = value;
					this.SendPropertyChanged("IDMember");
					this.OnIDMemberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Position", DbType="VarChar(250) NOT NULL", CanBeNull=false)]
		public string Position
		{
			get
			{
				return this._Position;
			}
			set
			{
				if ((this._Position != value))
				{
					this.OnPositionChanging(value);
					this.SendPropertyChanging();
					this._Position = value;
					this.SendPropertyChanged("Position");
					this.OnPositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="VarChar(1050)")]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Resume", DbType="VarChar(MAX)")]
		public string Resume
		{
			get
			{
				return this._Resume;
			}
			set
			{
				if ((this._Resume != value))
				{
					this.OnResumeChanging(value);
					this.SendPropertyChanging();
					this._Resume = value;
					this.SendPropertyChanged("Resume");
					this.OnResumeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Member_Membership", Storage="_Memberships", ThisKey="IDMember", OtherKey="IDMember")]
		public EntitySet<Membership> Memberships
		{
			get
			{
				return this._Memberships;
			}
			set
			{
				this._Memberships.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Member_CodeSnippets", Storage="_CodeSnippets", ThisKey="IDMember", OtherKey="IDMember")]
		public EntitySet<CodeSnippet> CodeSnippets
		{
			get
			{
				return this._CodeSnippets;
			}
			set
			{
				this._CodeSnippets.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Memberships(Membership entity)
		{
			this.SendPropertyChanging();
			entity.Member = this;
		}
		
		private void detach_Memberships(Membership entity)
		{
			this.SendPropertyChanging();
			entity.Member = null;
		}
		
		private void attach_CodeSnippets(CodeSnippet entity)
		{
			this.SendPropertyChanging();
			entity.Member = this;
		}
		
		private void detach_CodeSnippets(CodeSnippet entity)
		{
			this.SendPropertyChanging();
			entity.Member = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Memberships")]
	public partial class Membership : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IDMembership;
		
		private System.Guid _IDMember;
		
		private System.Guid _IDMembershipType;
		
		private System.DateTime _StartDate;
		
		private System.DateTime _EndDate;
		
		private int _Level;
		
		private EntityRef<Member> _Member;
		
		private EntityRef<MembershipType> _MembershipType;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDMembershipChanging(System.Guid value);
    partial void OnIDMembershipChanged();
    partial void OnIDMemberChanging(System.Guid value);
    partial void OnIDMemberChanged();
    partial void OnIDMembershipTypeChanging(System.Guid value);
    partial void OnIDMembershipTypeChanged();
    partial void OnStartDateChanging(System.DateTime value);
    partial void OnStartDateChanged();
    partial void OnEndDateChanging(System.DateTime value);
    partial void OnEndDateChanged();
    partial void OnLevelChanging(int value);
    partial void OnLevelChanged();
    #endregion
		
		public Membership()
		{
			this._Member = default(EntityRef<Member>);
			this._MembershipType = default(EntityRef<MembershipType>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDMembership", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IDMembership
		{
			get
			{
				return this._IDMembership;
			}
			set
			{
				if ((this._IDMembership != value))
				{
					this.OnIDMembershipChanging(value);
					this.SendPropertyChanging();
					this._IDMembership = value;
					this.SendPropertyChanged("IDMembership");
					this.OnIDMembershipChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDMember", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid IDMember
		{
			get
			{
				return this._IDMember;
			}
			set
			{
				if ((this._IDMember != value))
				{
					if (this._Member.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDMemberChanging(value);
					this.SendPropertyChanging();
					this._IDMember = value;
					this.SendPropertyChanged("IDMember");
					this.OnIDMemberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDMembershipType", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid IDMembershipType
		{
			get
			{
				return this._IDMembershipType;
			}
			set
			{
				if ((this._IDMembershipType != value))
				{
					if (this._MembershipType.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDMembershipTypeChanging(value);
					this.SendPropertyChanging();
					this._IDMembershipType = value;
					this.SendPropertyChanged("IDMembershipType");
					this.OnIDMembershipTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartDate", DbType="DateTime NOT NULL")]
		public System.DateTime StartDate
		{
			get
			{
				return this._StartDate;
			}
			set
			{
				if ((this._StartDate != value))
				{
					this.OnStartDateChanging(value);
					this.SendPropertyChanging();
					this._StartDate = value;
					this.SendPropertyChanged("StartDate");
					this.OnStartDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndDate", DbType="DateTime NOT NULL")]
		public System.DateTime EndDate
		{
			get
			{
				return this._EndDate;
			}
			set
			{
				if ((this._EndDate != value))
				{
					this.OnEndDateChanging(value);
					this.SendPropertyChanging();
					this._EndDate = value;
					this.SendPropertyChanged("EndDate");
					this.OnEndDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Level]", Storage="_Level", DbType="Int NOT NULL")]
		public int Level
		{
			get
			{
				return this._Level;
			}
			set
			{
				if ((this._Level != value))
				{
					this.OnLevelChanging(value);
					this.SendPropertyChanging();
					this._Level = value;
					this.SendPropertyChanged("Level");
					this.OnLevelChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Member_Membership", Storage="_Member", ThisKey="IDMember", OtherKey="IDMember", IsForeignKey=true)]
		public Member Member
		{
			get
			{
				return this._Member.Entity;
			}
			set
			{
				Member previousValue = this._Member.Entity;
				if (((previousValue != value) 
							|| (this._Member.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Member.Entity = null;
						previousValue.Memberships.Remove(this);
					}
					this._Member.Entity = value;
					if ((value != null))
					{
						value.Memberships.Add(this);
						this._IDMember = value.IDMember;
					}
					else
					{
						this._IDMember = default(System.Guid);
					}
					this.SendPropertyChanged("Member");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MembershipType_Membership", Storage="_MembershipType", ThisKey="IDMembershipType", OtherKey="IDMembershipType", IsForeignKey=true)]
		public MembershipType MembershipType
		{
			get
			{
				return this._MembershipType.Entity;
			}
			set
			{
				MembershipType previousValue = this._MembershipType.Entity;
				if (((previousValue != value) 
							|| (this._MembershipType.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._MembershipType.Entity = null;
						previousValue.Memberships.Remove(this);
					}
					this._MembershipType.Entity = value;
					if ((value != null))
					{
						value.Memberships.Add(this);
						this._IDMembershipType = value.IDMembershipType;
					}
					else
					{
						this._IDMembershipType = default(System.Guid);
					}
					this.SendPropertyChanged("MembershipType");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.MembershipTypes")]
	public partial class MembershipType : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IDMembershipType;
		
		private string _Name;
		
		private string _Description;
		
		private int _SubscriptionLengthInMonths;
		
		private EntitySet<Membership> _Memberships;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDMembershipTypeChanging(System.Guid value);
    partial void OnIDMembershipTypeChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnDescriptionChanging(string value);
    partial void OnDescriptionChanged();
    partial void OnSubscriptionLengthInMonthsChanging(int value);
    partial void OnSubscriptionLengthInMonthsChanged();
    #endregion
		
		public MembershipType()
		{
			this._Memberships = new EntitySet<Membership>(new Action<Membership>(this.attach_Memberships), new Action<Membership>(this.detach_Memberships));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDMembershipType", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IDMembershipType
		{
			get
			{
				return this._IDMembershipType;
			}
			set
			{
				if ((this._IDMembershipType != value))
				{
					this.OnIDMembershipTypeChanging(value);
					this.SendPropertyChanging();
					this._IDMembershipType = value;
					this.SendPropertyChanged("IDMembershipType");
					this.OnIDMembershipTypeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Name
		{
			get
			{
				return this._Name;
			}
			set
			{
				if ((this._Name != value))
				{
					this.OnNameChanging(value);
					this.SendPropertyChanging();
					this._Name = value;
					this.SendPropertyChanged("Name");
					this.OnNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Description", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Description
		{
			get
			{
				return this._Description;
			}
			set
			{
				if ((this._Description != value))
				{
					this.OnDescriptionChanging(value);
					this.SendPropertyChanging();
					this._Description = value;
					this.SendPropertyChanged("Description");
					this.OnDescriptionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubscriptionLengthInMonths", DbType="Int NOT NULL")]
		public int SubscriptionLengthInMonths
		{
			get
			{
				return this._SubscriptionLengthInMonths;
			}
			set
			{
				if ((this._SubscriptionLengthInMonths != value))
				{
					this.OnSubscriptionLengthInMonthsChanging(value);
					this.SendPropertyChanging();
					this._SubscriptionLengthInMonths = value;
					this.SendPropertyChanged("SubscriptionLengthInMonths");
					this.OnSubscriptionLengthInMonthsChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="MembershipType_Membership", Storage="_Memberships", ThisKey="IDMembershipType", OtherKey="IDMembershipType")]
		public EntitySet<Membership> Memberships
		{
			get
			{
				return this._Memberships;
			}
			set
			{
				this._Memberships.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Memberships(Membership entity)
		{
			this.SendPropertyChanging();
			entity.MembershipType = this;
		}
		
		private void detach_Memberships(Membership entity)
		{
			this.SendPropertyChanging();
			entity.MembershipType = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Announcements")]
	public partial class Announcement : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IDAnnouncement;
		
		private System.DateTime _ValidFrom;
		
		private System.DateTime _ValidTo;
		
		private string _Title;
		
		private string _Text;
		
		private System.Nullable<System.DateTime> _EventDateTime;
		
		private string _Tags;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDAnnouncementChanging(System.Guid value);
    partial void OnIDAnnouncementChanged();
    partial void OnValidFromChanging(System.DateTime value);
    partial void OnValidFromChanged();
    partial void OnValidToChanging(System.DateTime value);
    partial void OnValidToChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnTextChanging(string value);
    partial void OnTextChanged();
    partial void OnEventDateTimeChanging(System.Nullable<System.DateTime> value);
    partial void OnEventDateTimeChanged();
    partial void OnTagsChanging(string value);
    partial void OnTagsChanged();
    #endregion
		
		public Announcement()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDAnnouncement", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IDAnnouncement
		{
			get
			{
				return this._IDAnnouncement;
			}
			set
			{
				if ((this._IDAnnouncement != value))
				{
					this.OnIDAnnouncementChanging(value);
					this.SendPropertyChanging();
					this._IDAnnouncement = value;
					this.SendPropertyChanged("IDAnnouncement");
					this.OnIDAnnouncementChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ValidFrom", DbType="DateTime NOT NULL")]
		public System.DateTime ValidFrom
		{
			get
			{
				return this._ValidFrom;
			}
			set
			{
				if ((this._ValidFrom != value))
				{
					this.OnValidFromChanging(value);
					this.SendPropertyChanging();
					this._ValidFrom = value;
					this.SendPropertyChanged("ValidFrom");
					this.OnValidFromChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ValidTo", DbType="DateTime NOT NULL")]
		public System.DateTime ValidTo
		{
			get
			{
				return this._ValidTo;
			}
			set
			{
				if ((this._ValidTo != value))
				{
					this.OnValidToChanging(value);
					this.SendPropertyChanging();
					this._ValidTo = value;
					this.SendPropertyChanged("ValidTo");
					this.OnValidToChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="NVarChar(200) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Text", DbType="NVarChar(MAX) NOT NULL", CanBeNull=false)]
		public string Text
		{
			get
			{
				return this._Text;
			}
			set
			{
				if ((this._Text != value))
				{
					this.OnTextChanging(value);
					this.SendPropertyChanging();
					this._Text = value;
					this.SendPropertyChanged("Text");
					this.OnTextChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EventDateTime", DbType="DateTime")]
		public System.Nullable<System.DateTime> EventDateTime
		{
			get
			{
				return this._EventDateTime;
			}
			set
			{
				if ((this._EventDateTime != value))
				{
					this.OnEventDateTimeChanging(value);
					this.SendPropertyChanging();
					this._EventDateTime = value;
					this.SendPropertyChanged("EventDateTime");
					this.OnEventDateTimeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Tags", DbType="NVarChar(MAX)")]
		public string Tags
		{
			get
			{
				return this._Tags;
			}
			set
			{
				if ((this._Tags != value))
				{
					this.OnTagsChanging(value);
					this.SendPropertyChanging();
					this._Tags = value;
					this.SendPropertyChanged("Tags");
					this.OnTagsChanged();
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CodeSnippets")]
	public partial class CodeSnippet : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private System.Guid _IDCodeSnippet;
		
		private string _Title;
		
		private string _ContentCode;
		
		private System.Guid _IDMember;
		
		private int _Revision;
		
		private EntityRef<Member> _Member;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIDCodeSnippetChanging(System.Guid value);
    partial void OnIDCodeSnippetChanged();
    partial void OnTitleChanging(string value);
    partial void OnTitleChanged();
    partial void OnContentCodeChanging(string value);
    partial void OnContentCodeChanged();
    partial void OnIDMemberChanging(System.Guid value);
    partial void OnIDMemberChanged();
    partial void OnRevisionChanging(int value);
    partial void OnRevisionChanged();
    #endregion
		
		public CodeSnippet()
		{
			this._Member = default(EntityRef<Member>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDCodeSnippet", DbType="UniqueIdentifier NOT NULL", IsPrimaryKey=true)]
		public System.Guid IDCodeSnippet
		{
			get
			{
				return this._IDCodeSnippet;
			}
			set
			{
				if ((this._IDCodeSnippet != value))
				{
					this.OnIDCodeSnippetChanging(value);
					this.SendPropertyChanging();
					this._IDCodeSnippet = value;
					this.SendPropertyChanged("IDCodeSnippet");
					this.OnIDCodeSnippetChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Title", DbType="VarChar(100) NOT NULL", CanBeNull=false)]
		public string Title
		{
			get
			{
				return this._Title;
			}
			set
			{
				if ((this._Title != value))
				{
					this.OnTitleChanging(value);
					this.SendPropertyChanging();
					this._Title = value;
					this.SendPropertyChanged("Title");
					this.OnTitleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_ContentCode", DbType="VarChar(MAX) NOT NULL", CanBeNull=false)]
		public string ContentCode
		{
			get
			{
				return this._ContentCode;
			}
			set
			{
				if ((this._ContentCode != value))
				{
					this.OnContentCodeChanging(value);
					this.SendPropertyChanging();
					this._ContentCode = value;
					this.SendPropertyChanged("ContentCode");
					this.OnContentCodeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_IDMember", DbType="UniqueIdentifier NOT NULL")]
		public System.Guid IDMember
		{
			get
			{
				return this._IDMember;
			}
			set
			{
				if ((this._IDMember != value))
				{
					if (this._Member.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnIDMemberChanging(value);
					this.SendPropertyChanging();
					this._IDMember = value;
					this.SendPropertyChanged("IDMember");
					this.OnIDMemberChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Revision", DbType="Int NOT NULL")]
		public int Revision
		{
			get
			{
				return this._Revision;
			}
			set
			{
				if ((this._Revision != value))
				{
					this.OnRevisionChanging(value);
					this.SendPropertyChanging();
					this._Revision = value;
					this.SendPropertyChanged("Revision");
					this.OnRevisionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Member_CodeSnippets", Storage="_Member", ThisKey="IDMember", OtherKey="IDMember", IsForeignKey=true)]
		public Member Member
		{
			get
			{
				return this._Member.Entity;
			}
			set
			{
				Member previousValue = this._Member.Entity;
				if (((previousValue != value) 
							|| (this._Member.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Member.Entity = null;
						previousValue.CodeSnippets.Remove(this);
					}
					this._Member.Entity = value;
					if ((value != null))
					{
						value.CodeSnippets.Add(this);
						this._IDMember = value.IDMember;
					}
					else
					{
						this._IDMember = default(System.Guid);
					}
					this.SendPropertyChanged("Member");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
}
#pragma warning restore 1591
