﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.0
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;



[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="ezdrivedb")]
public partial class EasyDrivedbDataContext : System.Data.Linq.DataContext
{
	
	private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
	
  #region Extensibility Method Definitions
  partial void OnCreated();
  partial void InsertCheckin(Checkin instance);
  partial void UpdateCheckin(Checkin instance);
  partial void DeleteCheckin(Checkin instance);
  partial void InsertCheckinType(CheckinType instance);
  partial void UpdateCheckinType(CheckinType instance);
  partial void DeleteCheckinType(CheckinType instance);
  partial void InsertSchedule(Schedule instance);
  partial void UpdateSchedule(Schedule instance);
  partial void DeleteSchedule(Schedule instance);
  partial void InsertUsers(Users instance);
  partial void UpdateUsers(Users instance);
  partial void DeleteUsers(Users instance);
  #endregion
	
	public EasyDrivedbDataContext() : 
			base(global::System.Configuration.ConfigurationManager.ConnectionStrings["ezdrivedbConnectionString"].ConnectionString, mappingSource)
	{
		OnCreated();
	}
	
	public EasyDrivedbDataContext(string connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public EasyDrivedbDataContext(System.Data.IDbConnection connection) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public EasyDrivedbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public EasyDrivedbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
			base(connection, mappingSource)
	{
		OnCreated();
	}
	
	public System.Data.Linq.Table<Checkin> Checkins
	{
		get
		{
			return this.GetTable<Checkin>();
		}
	}
	
	public System.Data.Linq.Table<CheckinType> CheckinTypes
	{
		get
		{
			return this.GetTable<CheckinType>();
		}
	}
	
	public System.Data.Linq.Table<Schedule> Schedules
	{
		get
		{
			return this.GetTable<Schedule>();
		}
	}
	
	public System.Data.Linq.Table<Users> Users
	{
		get
		{
			return this.GetTable<Users>();
		}
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Checkin")]
public partial class Checkin : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Checkin_ID;
	
	private string _Long;
	
	private string _Lat;
	
	private int _User_ID;
	
	private System.DateTime _Time;
	
	private int _Type_ID;
	
	private string _Severity;
	
	private System.Nullable<int> _SpamCount;
	
	private string _Location;
	
	private string _Side;
	
	private EntityRef<CheckinType> _CheckinType;
	
	private EntityRef<Users> _Users;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCheckin_IDChanging(int value);
    partial void OnCheckin_IDChanged();
    partial void OnLongChanging(string value);
    partial void OnLongChanged();
    partial void OnLatChanging(string value);
    partial void OnLatChanged();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnTimeChanging(System.DateTime value);
    partial void OnTimeChanged();
    partial void OnType_IDChanging(int value);
    partial void OnType_IDChanged();
    partial void OnSeverityChanging(string value);
    partial void OnSeverityChanged();
    partial void OnSpamCountChanging(System.Nullable<int> value);
    partial void OnSpamCountChanged();
    partial void OnLocationChanging(string value);
    partial void OnLocationChanged();
    partial void OnSideChanging(string value);
    partial void OnSideChanged();
    #endregion
	
	public Checkin()
	{
		this._CheckinType = default(EntityRef<CheckinType>);
		this._Users = default(EntityRef<Users>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Checkin_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Checkin_ID
	{
		get
		{
			return this._Checkin_ID;
		}
		set
		{
			if ((this._Checkin_ID != value))
			{
				this.OnCheckin_IDChanging(value);
				this.SendPropertyChanging();
				this._Checkin_ID = value;
				this.SendPropertyChanged("Checkin_ID");
				this.OnCheckin_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Long", DbType="NChar(10)")]
	public string Long
	{
		get
		{
			return this._Long;
		}
		set
		{
			if ((this._Long != value))
			{
				this.OnLongChanging(value);
				this.SendPropertyChanging();
				this._Long = value;
				this.SendPropertyChanged("Long");
				this.OnLongChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lat", DbType="NChar(10)")]
	public string Lat
	{
		get
		{
			return this._Lat;
		}
		set
		{
			if ((this._Lat != value))
			{
				this.OnLatChanging(value);
				this.SendPropertyChanging();
				this._Lat = value;
				this.SendPropertyChanged("Lat");
				this.OnLatChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int NOT NULL")]
	public int User_ID
	{
		get
		{
			return this._User_ID;
		}
		set
		{
			if ((this._User_ID != value))
			{
				if (this._Users.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUser_IDChanging(value);
				this.SendPropertyChanging();
				this._User_ID = value;
				this.SendPropertyChanged("User_ID");
				this.OnUser_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Time", DbType="DateTime NOT NULL")]
	public System.DateTime Time
	{
		get
		{
			return this._Time;
		}
		set
		{
			if ((this._Time != value))
			{
				this.OnTimeChanging(value);
				this.SendPropertyChanging();
				this._Time = value;
				this.SendPropertyChanged("Time");
				this.OnTimeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type_ID", DbType="Int NOT NULL")]
	public int Type_ID
	{
		get
		{
			return this._Type_ID;
		}
		set
		{
			if ((this._Type_ID != value))
			{
				if (this._CheckinType.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnType_IDChanging(value);
				this.SendPropertyChanging();
				this._Type_ID = value;
				this.SendPropertyChanged("Type_ID");
				this.OnType_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Severity", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Severity
	{
		get
		{
			return this._Severity;
		}
		set
		{
			if ((this._Severity != value))
			{
				this.OnSeverityChanging(value);
				this.SendPropertyChanging();
				this._Severity = value;
				this.SendPropertyChanged("Severity");
				this.OnSeverityChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SpamCount", DbType="Int")]
	public System.Nullable<int> SpamCount
	{
		get
		{
			return this._SpamCount;
		}
		set
		{
			if ((this._SpamCount != value))
			{
				this.OnSpamCountChanging(value);
				this.SendPropertyChanging();
				this._SpamCount = value;
				this.SendPropertyChanged("SpamCount");
				this.OnSpamCountChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Location", DbType="VarChar(50)")]
	public string Location
	{
		get
		{
			return this._Location;
		}
		set
		{
			if ((this._Location != value))
			{
				this.OnLocationChanging(value);
				this.SendPropertyChanging();
				this._Location = value;
				this.SendPropertyChanged("Location");
				this.OnLocationChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Side", DbType="VarChar(50)")]
	public string Side
	{
		get
		{
			return this._Side;
		}
		set
		{
			if ((this._Side != value))
			{
				this.OnSideChanging(value);
				this.SendPropertyChanging();
				this._Side = value;
				this.SendPropertyChanged("Side");
				this.OnSideChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CheckinType_Checkin", Storage="_CheckinType", ThisKey="Type_ID", OtherKey="Type_ID", IsForeignKey=true)]
	public CheckinType CheckinType
	{
		get
		{
			return this._CheckinType.Entity;
		}
		set
		{
			CheckinType previousValue = this._CheckinType.Entity;
			if (((previousValue != value) 
						|| (this._CheckinType.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._CheckinType.Entity = null;
					previousValue.Checkins.Remove(this);
				}
				this._CheckinType.Entity = value;
				if ((value != null))
				{
					value.Checkins.Add(this);
					this._Type_ID = value.Type_ID;
				}
				else
				{
					this._Type_ID = default(int);
				}
				this.SendPropertyChanged("CheckinType");
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Checkin", Storage="_Users", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public Users Users
	{
		get
		{
			return this._Users.Entity;
		}
		set
		{
			Users previousValue = this._Users.Entity;
			if (((previousValue != value) 
						|| (this._Users.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Users.Entity = null;
					previousValue.Checkins.Remove(this);
				}
				this._Users.Entity = value;
				if ((value != null))
				{
					value.Checkins.Add(this);
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("Users");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CheckinType")]
public partial class CheckinType : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Type_ID;
	
	private string _Comment;
	
	private EntitySet<Checkin> _Checkins;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnType_IDChanging(int value);
    partial void OnType_IDChanged();
    partial void OnCommentChanging(string value);
    partial void OnCommentChanged();
    #endregion
	
	public CheckinType()
	{
		this._Checkins = new EntitySet<Checkin>(new Action<Checkin>(this.attach_Checkins), new Action<Checkin>(this.detach_Checkins));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Type_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Type_ID
	{
		get
		{
			return this._Type_ID;
		}
		set
		{
			if ((this._Type_ID != value))
			{
				this.OnType_IDChanging(value);
				this.SendPropertyChanging();
				this._Type_ID = value;
				this.SendPropertyChanged("Type_ID");
				this.OnType_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Comment", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Comment
	{
		get
		{
			return this._Comment;
		}
		set
		{
			if ((this._Comment != value))
			{
				this.OnCommentChanging(value);
				this.SendPropertyChanging();
				this._Comment = value;
				this.SendPropertyChanged("Comment");
				this.OnCommentChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="CheckinType_Checkin", Storage="_Checkins", ThisKey="Type_ID", OtherKey="Type_ID")]
	public EntitySet<Checkin> Checkins
	{
		get
		{
			return this._Checkins;
		}
		set
		{
			this._Checkins.Assign(value);
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
	
	private void attach_Checkins(Checkin entity)
	{
		this.SendPropertyChanging();
		entity.CheckinType = this;
	}
	
	private void detach_Checkins(Checkin entity)
	{
		this.SendPropertyChanging();
		entity.CheckinType = null;
	}
}

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Schedule")]
public partial class Schedule : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _Schedule_ID;
	
	private int _User_ID;
	
	private string _StartPoint;
	
	private string _EndPoint;
	
	private System.Nullable<System.DateTime> _TimeStart;
	
	private System.Nullable<System.DateTime> _TimeEnd;
	
	private string _Recurrence;
	
	private EntityRef<Users> _Users;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSchedule_IDChanging(int value);
    partial void OnSchedule_IDChanged();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnStartPointChanging(string value);
    partial void OnStartPointChanged();
    partial void OnEndPointChanging(string value);
    partial void OnEndPointChanged();
    partial void OnTimeStartChanging(System.Nullable<System.DateTime> value);
    partial void OnTimeStartChanged();
    partial void OnTimeEndChanging(System.Nullable<System.DateTime> value);
    partial void OnTimeEndChanged();
    partial void OnRecurrenceChanging(string value);
    partial void OnRecurrenceChanged();
    #endregion
	
	public Schedule()
	{
		this._Users = default(EntityRef<Users>);
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Schedule_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int Schedule_ID
	{
		get
		{
			return this._Schedule_ID;
		}
		set
		{
			if ((this._Schedule_ID != value))
			{
				this.OnSchedule_IDChanging(value);
				this.SendPropertyChanging();
				this._Schedule_ID = value;
				this.SendPropertyChanged("Schedule_ID");
				this.OnSchedule_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", DbType="Int NOT NULL")]
	public int User_ID
	{
		get
		{
			return this._User_ID;
		}
		set
		{
			if ((this._User_ID != value))
			{
				if (this._Users.HasLoadedOrAssignedValue)
				{
					throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
				}
				this.OnUser_IDChanging(value);
				this.SendPropertyChanging();
				this._User_ID = value;
				this.SendPropertyChanged("User_ID");
				this.OnUser_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_StartPoint", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string StartPoint
	{
		get
		{
			return this._StartPoint;
		}
		set
		{
			if ((this._StartPoint != value))
			{
				this.OnStartPointChanging(value);
				this.SendPropertyChanging();
				this._StartPoint = value;
				this.SendPropertyChanged("StartPoint");
				this.OnStartPointChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EndPoint", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string EndPoint
	{
		get
		{
			return this._EndPoint;
		}
		set
		{
			if ((this._EndPoint != value))
			{
				this.OnEndPointChanging(value);
				this.SendPropertyChanging();
				this._EndPoint = value;
				this.SendPropertyChanged("EndPoint");
				this.OnEndPointChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeStart", DbType="DateTime")]
	public System.Nullable<System.DateTime> TimeStart
	{
		get
		{
			return this._TimeStart;
		}
		set
		{
			if ((this._TimeStart != value))
			{
				this.OnTimeStartChanging(value);
				this.SendPropertyChanging();
				this._TimeStart = value;
				this.SendPropertyChanged("TimeStart");
				this.OnTimeStartChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TimeEnd", DbType="DateTime")]
	public System.Nullable<System.DateTime> TimeEnd
	{
		get
		{
			return this._TimeEnd;
		}
		set
		{
			if ((this._TimeEnd != value))
			{
				this.OnTimeEndChanging(value);
				this.SendPropertyChanging();
				this._TimeEnd = value;
				this.SendPropertyChanged("TimeEnd");
				this.OnTimeEndChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Recurrence", DbType="VarChar(50)")]
	public string Recurrence
	{
		get
		{
			return this._Recurrence;
		}
		set
		{
			if ((this._Recurrence != value))
			{
				this.OnRecurrenceChanging(value);
				this.SendPropertyChanging();
				this._Recurrence = value;
				this.SendPropertyChanged("Recurrence");
				this.OnRecurrenceChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Schedule", Storage="_Users", ThisKey="User_ID", OtherKey="User_ID", IsForeignKey=true)]
	public Users Users
	{
		get
		{
			return this._Users.Entity;
		}
		set
		{
			Users previousValue = this._Users.Entity;
			if (((previousValue != value) 
						|| (this._Users.HasLoadedOrAssignedValue == false)))
			{
				this.SendPropertyChanging();
				if ((previousValue != null))
				{
					this._Users.Entity = null;
					previousValue.Schedules.Remove(this);
				}
				this._Users.Entity = value;
				if ((value != null))
				{
					value.Schedules.Add(this);
					this._User_ID = value.User_ID;
				}
				else
				{
					this._User_ID = default(int);
				}
				this.SendPropertyChanged("Users");
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

[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Users")]
public partial class Users : INotifyPropertyChanging, INotifyPropertyChanged
{
	
	private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
	
	private int _User_ID;
	
	private string _Name;
	
	private string _Mobile;
	
	private string _Email;
	
	private string _VerificationCode;
	
	private string _Password;
	
	private EntitySet<Checkin> _Checkins;
	
	private EntitySet<Schedule> _Schedules;
	
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUser_IDChanging(int value);
    partial void OnUser_IDChanged();
    partial void OnNameChanging(string value);
    partial void OnNameChanged();
    partial void OnMobileChanging(string value);
    partial void OnMobileChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnVerificationCodeChanging(string value);
    partial void OnVerificationCodeChanged();
    partial void OnPasswordChanging(string value);
    partial void OnPasswordChanged();
    #endregion
	
	public Users()
	{
		this._Checkins = new EntitySet<Checkin>(new Action<Checkin>(this.attach_Checkins), new Action<Checkin>(this.detach_Checkins));
		this._Schedules = new EntitySet<Schedule>(new Action<Schedule>(this.attach_Schedules), new Action<Schedule>(this.detach_Schedules));
		OnCreated();
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_ID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
	public int User_ID
	{
		get
		{
			return this._User_ID;
		}
		set
		{
			if ((this._User_ID != value))
			{
				this.OnUser_IDChanging(value);
				this.SendPropertyChanging();
				this._User_ID = value;
				this.SendPropertyChanged("User_ID");
				this.OnUser_IDChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Name", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
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
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Mobile", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Mobile
	{
		get
		{
			return this._Mobile;
		}
		set
		{
			if ((this._Mobile != value))
			{
				this.OnMobileChanging(value);
				this.SendPropertyChanging();
				this._Mobile = value;
				this.SendPropertyChanged("Mobile");
				this.OnMobileChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Email", DbType="VarChar(50)")]
	public string Email
	{
		get
		{
			return this._Email;
		}
		set
		{
			if ((this._Email != value))
			{
				this.OnEmailChanging(value);
				this.SendPropertyChanging();
				this._Email = value;
				this.SendPropertyChanged("Email");
				this.OnEmailChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_VerificationCode", DbType="VarChar(50)")]
	public string VerificationCode
	{
		get
		{
			return this._VerificationCode;
		}
		set
		{
			if ((this._VerificationCode != value))
			{
				this.OnVerificationCodeChanging(value);
				this.SendPropertyChanging();
				this._VerificationCode = value;
				this.SendPropertyChanged("VerificationCode");
				this.OnVerificationCodeChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Password", DbType="VarChar(50) NOT NULL", CanBeNull=false)]
	public string Password
	{
		get
		{
			return this._Password;
		}
		set
		{
			if ((this._Password != value))
			{
				this.OnPasswordChanging(value);
				this.SendPropertyChanging();
				this._Password = value;
				this.SendPropertyChanged("Password");
				this.OnPasswordChanged();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Checkin", Storage="_Checkins", ThisKey="User_ID", OtherKey="User_ID")]
	public EntitySet<Checkin> Checkins
	{
		get
		{
			return this._Checkins;
		}
		set
		{
			this._Checkins.Assign(value);
		}
	}
	
	[global::System.Data.Linq.Mapping.AssociationAttribute(Name="User_Schedule", Storage="_Schedules", ThisKey="User_ID", OtherKey="User_ID")]
	public EntitySet<Schedule> Schedules
	{
		get
		{
			return this._Schedules;
		}
		set
		{
			this._Schedules.Assign(value);
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
	
	private void attach_Checkins(Checkin entity)
	{
		this.SendPropertyChanging();
		entity.Users = this;
	}
	
	private void detach_Checkins(Checkin entity)
	{
		this.SendPropertyChanging();
		entity.Users = null;
	}
	
	private void attach_Schedules(Schedule entity)
	{
		this.SendPropertyChanging();
		entity.Users = this;
	}
	
	private void detach_Schedules(Schedule entity)
	{
		this.SendPropertyChanging();
		entity.Users = null;
	}
}
#pragma warning restore 1591
