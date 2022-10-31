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

namespace WebApplication2
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Paintings")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void DeleteAuthor(Author instance);
    partial void InsertUsersInformation(UsersInformation instance);
    partial void UpdateUsersInformation(UsersInformation instance);
    partial void DeleteUsersInformation(UsersInformation instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::System.Configuration.ConfigurationManager.ConnectionStrings["PaintingsConnectionString"].ConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataClasses1DataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Authors_Painting> Authors_Paintings
		{
			get
			{
				return this.GetTable<Authors_Painting>();
			}
		}
		
		public System.Data.Linq.Table<Author> Authors
		{
			get
			{
				return this.GetTable<Author>();
			}
		}
		
		public System.Data.Linq.Table<UsersInformation> UsersInformations
		{
			get
			{
				return this.GetTable<UsersInformation>();
			}
		}
		
		private void InsertAuthors_Painting(Authors_Painting obj)
		{
			this.Insert_Info(((System.Nullable<int>)(obj.AuthorID)), obj.NameOfPainting, ((System.Nullable<System.DateTime>)(obj.MadeIn)), obj.Medium);
		}
		
		private void UpdateAuthors_Painting(Authors_Painting obj)
		{
			this.Update_Authors_Paintings(((System.Nullable<int>)(obj.AuthorID)), ((System.Nullable<int>)(obj.PaintingID)), obj.FirstName, obj.MiddleName, obj.LastName, obj.PaintingStyle, ((System.Nullable<System.DateTime>)(obj.YearBorn)), obj.NameOfPainting, ((System.Nullable<System.DateTime>)(obj.MadeIn)), obj.Medium);
		}
		
		private void InsertAuthor(Author obj)
		{
			this.Delete_Author(((System.Nullable<int>)(obj.AuthorID)));
		}
		
		private void UpdateAuthor(Author obj)
		{
			this.Update_Authors(((System.Nullable<int>)(obj.AuthorID)), obj.FirstName, obj.MiddleName, obj.LastName, obj.PaintingStyle, ((System.Nullable<System.DateTime>)(obj.YearBorn)));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Delete_Painting")]
		public int Delete_Painting([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> painting_id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), painting_id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Update_Authors_Paintings")]
		public int Update_Authors_Paintings([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> author_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> painting_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(255)")] string author_first_name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(255)")] string author_middle_name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(255)")] string author_last_name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(255)")] string author_painting_style, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> author_yb, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(255)")] string name_painting, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Date")] System.Nullable<System.DateTime> year_made, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(255)")] string medium)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), author_id, painting_id, author_first_name, author_middle_name, author_last_name, author_painting_style, author_yb, name_painting, year_made, medium);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Select_Authors_Paintings")]
		public ISingleResult<Select_Authors_PaintingsResult> Select_Authors_Paintings()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<Select_Authors_PaintingsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Insert_Info")]
		public int Insert_Info([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> author_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(255)")] string painting_name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> painting_ym, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(255)")] string painting_medium)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), author_id, painting_name, painting_ym, painting_medium);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Select_Author_ID")]
		public ISingleResult<Select_Author_IDResult> Select_Author_ID([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> authorid)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), authorid);
			return ((ISingleResult<Select_Author_IDResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Delete_Author")]
		public int Delete_Author([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> author_id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), author_id);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Insert_Authors")]
		public int Insert_Authors([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(255)")] string author_first_name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(255)")] string author_middle_name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(255)")] string author_last_name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(255)")] string author_painting_style, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> author_yb)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), author_first_name, author_middle_name, author_last_name, author_painting_style, author_yb);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Select_All_Authors")]
		public ISingleResult<Select_All_AuthorsResult> Select_All_Authors()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<Select_All_AuthorsResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Update_Authors")]
		public int Update_Authors([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> author_id, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(255)")] string author_first_name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(255)")] string author_middle_name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(255)")] string author_last_name, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(255)")] string author_painting_style, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="DateTime")] System.Nullable<System.DateTime> author_yb)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), author_id, author_first_name, author_middle_name, author_last_name, author_painting_style, author_yb);
			return ((int)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.Author_Search")]
		public ISingleResult<Author_SearchResult> Author_Search([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> author_id)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), author_id);
			return ((ISingleResult<Author_SearchResult>)(result.ReturnValue));
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.User_check")]
		public int User_check([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(255)")] string username, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="VarChar(255)")] string password)
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), username, password);
			return ((int)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Authors_Paintings")]
	public partial class Authors_Painting
	{
		
		private int _AuthorID;
		
		private string _FirstName;
		
		private string _MiddleName;
		
		private string _LastName;
		
		private string _PaintingStyle;
		
		private System.Nullable<System.DateTime> _YearBorn;
		
		private int _PaintingID;
		
		private string _NameOfPainting;
		
		private System.Nullable<System.DateTime> _MadeIn;
		
		private string _Medium;
		
		public Authors_Painting()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuthorID", DbType="Int NOT NULL")]
		public int AuthorID
		{
			get
			{
				return this._AuthorID;
			}
			set
			{
				if ((this._AuthorID != value))
				{
					this._AuthorID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(255)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this._FirstName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MiddleName", DbType="VarChar(255)")]
		public string MiddleName
		{
			get
			{
				return this._MiddleName;
			}
			set
			{
				if ((this._MiddleName != value))
				{
					this._MiddleName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(255)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this._LastName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaintingStyle", DbType="VarChar(255)")]
		public string PaintingStyle
		{
			get
			{
				return this._PaintingStyle;
			}
			set
			{
				if ((this._PaintingStyle != value))
				{
					this._PaintingStyle = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YearBorn", DbType="Date")]
		public System.Nullable<System.DateTime> YearBorn
		{
			get
			{
				return this._YearBorn;
			}
			set
			{
				if ((this._YearBorn != value))
				{
					this._YearBorn = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaintingID", DbType="Int NOT NULL")]
		public int PaintingID
		{
			get
			{
				return this._PaintingID;
			}
			set
			{
				if ((this._PaintingID != value))
				{
					this._PaintingID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameOfPainting", DbType="VarChar(255)")]
		public string NameOfPainting
		{
			get
			{
				return this._NameOfPainting;
			}
			set
			{
				if ((this._NameOfPainting != value))
				{
					this._NameOfPainting = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MadeIn", DbType="DateTime")]
		public System.Nullable<System.DateTime> MadeIn
		{
			get
			{
				return this._MadeIn;
			}
			set
			{
				if ((this._MadeIn != value))
				{
					this._MadeIn = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Medium", DbType="VarChar(255)")]
		public string Medium
		{
			get
			{
				return this._Medium;
			}
			set
			{
				if ((this._Medium != value))
				{
					this._Medium = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Authors")]
	public partial class Author : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _AuthorID;
		
		private string _FirstName;
		
		private string _MiddleName;
		
		private string _LastName;
		
		private string _PaintingStyle;
		
		private System.Nullable<System.DateTime> _YearBorn;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnAuthorIDChanging(int value);
    partial void OnAuthorIDChanged();
    partial void OnFirstNameChanging(string value);
    partial void OnFirstNameChanged();
    partial void OnMiddleNameChanging(string value);
    partial void OnMiddleNameChanged();
    partial void OnLastNameChanging(string value);
    partial void OnLastNameChanged();
    partial void OnPaintingStyleChanging(string value);
    partial void OnPaintingStyleChanged();
    partial void OnYearBornChanging(System.Nullable<System.DateTime> value);
    partial void OnYearBornChanged();
    #endregion
		
		public Author()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuthorID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int AuthorID
		{
			get
			{
				return this._AuthorID;
			}
			set
			{
				if ((this._AuthorID != value))
				{
					this.OnAuthorIDChanging(value);
					this.SendPropertyChanging();
					this._AuthorID = value;
					this.SendPropertyChanged("AuthorID");
					this.OnAuthorIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_FirstName", DbType="VarChar(255)")]
		public string FirstName
		{
			get
			{
				return this._FirstName;
			}
			set
			{
				if ((this._FirstName != value))
				{
					this.OnFirstNameChanging(value);
					this.SendPropertyChanging();
					this._FirstName = value;
					this.SendPropertyChanged("FirstName");
					this.OnFirstNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MiddleName", DbType="VarChar(255)")]
		public string MiddleName
		{
			get
			{
				return this._MiddleName;
			}
			set
			{
				if ((this._MiddleName != value))
				{
					this.OnMiddleNameChanging(value);
					this.SendPropertyChanging();
					this._MiddleName = value;
					this.SendPropertyChanged("MiddleName");
					this.OnMiddleNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_LastName", DbType="VarChar(255)")]
		public string LastName
		{
			get
			{
				return this._LastName;
			}
			set
			{
				if ((this._LastName != value))
				{
					this.OnLastNameChanging(value);
					this.SendPropertyChanging();
					this._LastName = value;
					this.SendPropertyChanged("LastName");
					this.OnLastNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaintingStyle", DbType="VarChar(255)")]
		public string PaintingStyle
		{
			get
			{
				return this._PaintingStyle;
			}
			set
			{
				if ((this._PaintingStyle != value))
				{
					this.OnPaintingStyleChanging(value);
					this.SendPropertyChanging();
					this._PaintingStyle = value;
					this.SendPropertyChanged("PaintingStyle");
					this.OnPaintingStyleChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_YearBorn", DbType="Date")]
		public System.Nullable<System.DateTime> YearBorn
		{
			get
			{
				return this._YearBorn;
			}
			set
			{
				if ((this._YearBorn != value))
				{
					this.OnYearBornChanging(value);
					this.SendPropertyChanging();
					this._YearBorn = value;
					this.SendPropertyChanged("YearBorn");
					this.OnYearBornChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.UsersInformation")]
	public partial class UsersInformation : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UserID;
		
		private string _Username;
		
		private string _User_password;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUserIDChanging(int value);
    partial void OnUserIDChanged();
    partial void OnUsernameChanging(string value);
    partial void OnUsernameChanged();
    partial void OnUser_passwordChanging(string value);
    partial void OnUser_passwordChanged();
    #endregion
		
		public UsersInformation()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserID", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int UserID
		{
			get
			{
				return this._UserID;
			}
			set
			{
				if ((this._UserID != value))
				{
					this.OnUserIDChanging(value);
					this.SendPropertyChanging();
					this._UserID = value;
					this.SendPropertyChanged("UserID");
					this.OnUserIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Username", DbType="VarChar(255)")]
		public string Username
		{
			get
			{
				return this._Username;
			}
			set
			{
				if ((this._Username != value))
				{
					this.OnUsernameChanging(value);
					this.SendPropertyChanging();
					this._Username = value;
					this.SendPropertyChanged("Username");
					this.OnUsernameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_User_password", DbType="VarChar(255)")]
		public string User_password
		{
			get
			{
				return this._User_password;
			}
			set
			{
				if ((this._User_password != value))
				{
					this.OnUser_passwordChanging(value);
					this.SendPropertyChanging();
					this._User_password = value;
					this.SendPropertyChanged("User_password");
					this.OnUser_passwordChanged();
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
	
	public partial class Select_Authors_PaintingsResult
	{
		
		private int _AuthorID;
		
		private int _PaintingID;
		
		private string _Име;
		
		private string _Презиме;
		
		private string _Фамилия;
		
		private string _Стил_на_рисуване;
		
		private System.Nullable<System.DateTime> _Дата_на_раждане;
		
		private string _Име_на_картината;
		
		private System.Nullable<System.DateTime> _Дата_на_създаване_на_картината;
		
		private string _Използван_материал;
		
		public Select_Authors_PaintingsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuthorID", DbType="Int NOT NULL")]
		public int AuthorID
		{
			get
			{
				return this._AuthorID;
			}
			set
			{
				if ((this._AuthorID != value))
				{
					this._AuthorID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_PaintingID", DbType="Int NOT NULL")]
		public int PaintingID
		{
			get
			{
				return this._PaintingID;
			}
			set
			{
				if ((this._PaintingID != value))
				{
					this._PaintingID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Име", DbType="VarChar(255)")]
		public string Име
		{
			get
			{
				return this._Име;
			}
			set
			{
				if ((this._Име != value))
				{
					this._Име = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Презиме", DbType="VarChar(255)")]
		public string Презиме
		{
			get
			{
				return this._Презиме;
			}
			set
			{
				if ((this._Презиме != value))
				{
					this._Презиме = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Фамилия", DbType="VarChar(255)")]
		public string Фамилия
		{
			get
			{
				return this._Фамилия;
			}
			set
			{
				if ((this._Фамилия != value))
				{
					this._Фамилия = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Стил на рисуване]", Storage="_Стил_на_рисуване", DbType="VarChar(255)")]
		public string Стил_на_рисуване
		{
			get
			{
				return this._Стил_на_рисуване;
			}
			set
			{
				if ((this._Стил_на_рисуване != value))
				{
					this._Стил_на_рисуване = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Дата на раждане]", Storage="_Дата_на_раждане", DbType="Date")]
		public System.Nullable<System.DateTime> Дата_на_раждане
		{
			get
			{
				return this._Дата_на_раждане;
			}
			set
			{
				if ((this._Дата_на_раждане != value))
				{
					this._Дата_на_раждане = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Име на картината]", Storage="_Име_на_картината", DbType="VarChar(255)")]
		public string Име_на_картината
		{
			get
			{
				return this._Име_на_картината;
			}
			set
			{
				if ((this._Име_на_картината != value))
				{
					this._Име_на_картината = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Дата на създаване на картината]", Storage="_Дата_на_създаване_на_картината", DbType="Date")]
		public System.Nullable<System.DateTime> Дата_на_създаване_на_картината
		{
			get
			{
				return this._Дата_на_създаване_на_картината;
			}
			set
			{
				if ((this._Дата_на_създаване_на_картината != value))
				{
					this._Дата_на_създаване_на_картината = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Използван материал]", Storage="_Използван_материал", DbType="VarChar(255)")]
		public string Използван_материал
		{
			get
			{
				return this._Използван_материал;
			}
			set
			{
				if ((this._Използван_материал != value))
				{
					this._Използван_материал = value;
				}
			}
		}
	}
	
	public partial class Select_Author_IDResult
	{
		
		private int _AuthorID;
		
		private string _Име;
		
		private string _Презиме;
		
		private string _Фамилия;
		
		private string _Стил_на_рисуване;
		
		private System.Nullable<System.DateTime> _Дата_на_раждане;
		
		public Select_Author_IDResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuthorID", DbType="Int NOT NULL")]
		public int AuthorID
		{
			get
			{
				return this._AuthorID;
			}
			set
			{
				if ((this._AuthorID != value))
				{
					this._AuthorID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Име", DbType="VarChar(255)")]
		public string Име
		{
			get
			{
				return this._Име;
			}
			set
			{
				if ((this._Име != value))
				{
					this._Име = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Презиме", DbType="VarChar(255)")]
		public string Презиме
		{
			get
			{
				return this._Презиме;
			}
			set
			{
				if ((this._Презиме != value))
				{
					this._Презиме = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Фамилия", DbType="VarChar(255)")]
		public string Фамилия
		{
			get
			{
				return this._Фамилия;
			}
			set
			{
				if ((this._Фамилия != value))
				{
					this._Фамилия = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Стил на рисуване]", Storage="_Стил_на_рисуване", DbType="VarChar(255)")]
		public string Стил_на_рисуване
		{
			get
			{
				return this._Стил_на_рисуване;
			}
			set
			{
				if ((this._Стил_на_рисуване != value))
				{
					this._Стил_на_рисуване = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Дата на раждане]", Storage="_Дата_на_раждане", DbType="DateTime")]
		public System.Nullable<System.DateTime> Дата_на_раждане
		{
			get
			{
				return this._Дата_на_раждане;
			}
			set
			{
				if ((this._Дата_на_раждане != value))
				{
					this._Дата_на_раждане = value;
				}
			}
		}
	}
	
	public partial class Select_All_AuthorsResult
	{
		
		private int _AuthorID;
		
		private string _Име;
		
		private string _Презиме;
		
		private string _Фамилия;
		
		private string _Стил_на_рисуване;
		
		private System.Nullable<System.DateTime> _Дата_на_раждане;
		
		public Select_All_AuthorsResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_AuthorID", DbType="Int NOT NULL")]
		public int AuthorID
		{
			get
			{
				return this._AuthorID;
			}
			set
			{
				if ((this._AuthorID != value))
				{
					this._AuthorID = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Име", DbType="VarChar(255)")]
		public string Име
		{
			get
			{
				return this._Име;
			}
			set
			{
				if ((this._Име != value))
				{
					this._Име = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Презиме", DbType="VarChar(255)")]
		public string Презиме
		{
			get
			{
				return this._Презиме;
			}
			set
			{
				if ((this._Презиме != value))
				{
					this._Презиме = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Фамилия", DbType="VarChar(255)")]
		public string Фамилия
		{
			get
			{
				return this._Фамилия;
			}
			set
			{
				if ((this._Фамилия != value))
				{
					this._Фамилия = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Стил на рисуване]", Storage="_Стил_на_рисуване", DbType="VarChar(255)")]
		public string Стил_на_рисуване
		{
			get
			{
				return this._Стил_на_рисуване;
			}
			set
			{
				if ((this._Стил_на_рисуване != value))
				{
					this._Стил_на_рисуване = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[Дата на раждане]", Storage="_Дата_на_раждане", DbType="DateTime")]
		public System.Nullable<System.DateTime> Дата_на_раждане
		{
			get
			{
				return this._Дата_на_раждане;
			}
			set
			{
				if ((this._Дата_на_раждане != value))
				{
					this._Дата_на_раждане = value;
				}
			}
		}
	}
	
	public partial class Author_SearchResult
	{
		
		private string _NameOfPainting;
		
		public Author_SearchResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_NameOfPainting", DbType="VarChar(255)")]
		public string NameOfPainting
		{
			get
			{
				return this._NameOfPainting;
			}
			set
			{
				if ((this._NameOfPainting != value))
				{
					this._NameOfPainting = value;
				}
			}
		}
	}
}
#pragma warning restore 1591