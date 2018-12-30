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

namespace LinqToSQL_Demo_Auto
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="Northwind")]
	public partial class NorthwindDbDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertTable_Kategori(Table_Kategori instance);
    partial void UpdateTable_Kategori(Table_Kategori instance);
    partial void DeleteTable_Kategori(Table_Kategori instance);
    partial void InsertTable_Urun(Table_Urun instance);
    partial void UpdateTable_Urun(Table_Urun instance);
    partial void DeleteTable_Urun(Table_Urun instance);
    #endregion
		
		public NorthwindDbDataContext() : 
				base(global::LinqToSQL_Demo_Auto.Properties.Settings.Default.NorthwindConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public NorthwindDbDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NorthwindDbDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NorthwindDbDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public NorthwindDbDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Table_Kategori> Table_Kategoris
		{
			get
			{
				return this.GetTable<Table_Kategori>();
			}
		}
		
		public System.Data.Linq.Table<Table_Urun> Table_Uruns
		{
			get
			{
				return this.GetTable<Table_Urun>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.EnUzunSatistakiUrun")]
		public ISingleResult<EnUzunSatistakiUrunResult> EnUzunSatistakiUrun()
		{
			IExecuteResult result = this.ExecuteMethodCall(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())));
			return ((ISingleResult<EnUzunSatistakiUrunResult>)(result.ReturnValue));
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Table_Kategori")]
	public partial class Table_Kategori : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _KategoriId;
		
		private string _KategoriAdi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnKategoriIdChanging(int value);
    partial void OnKategoriIdChanged();
    partial void OnKategoriAdiChanging(string value);
    partial void OnKategoriAdiChanged();
    #endregion
		
		public Table_Kategori()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KategoriId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int KategoriId
		{
			get
			{
				return this._KategoriId;
			}
			set
			{
				if ((this._KategoriId != value))
				{
					this.OnKategoriIdChanging(value);
					this.SendPropertyChanging();
					this._KategoriId = value;
					this.SendPropertyChanged("KategoriId");
					this.OnKategoriIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KategoriAdi", DbType="NVarChar(50)")]
		public string KategoriAdi
		{
			get
			{
				return this._KategoriAdi;
			}
			set
			{
				if ((this._KategoriAdi != value))
				{
					this.OnKategoriAdiChanging(value);
					this.SendPropertyChanging();
					this._KategoriAdi = value;
					this.SendPropertyChanged("KategoriAdi");
					this.OnKategoriAdiChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Table_Urun")]
	public partial class Table_Urun : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _UrunId;
		
		private string _UrunAdi;
		
		private System.Nullable<decimal> _Fiyat;
		
		private System.Nullable<int> _KategoriId;
		
		private System.Nullable<System.DateTime> _SatisBaslangicTarihi;
		
		private System.Nullable<System.DateTime> _SatisBitisTarihi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnUrunIdChanging(int value);
    partial void OnUrunIdChanged();
    partial void OnUrunAdiChanging(string value);
    partial void OnUrunAdiChanged();
    partial void OnFiyatChanging(System.Nullable<decimal> value);
    partial void OnFiyatChanged();
    partial void OnKategoriIdChanging(System.Nullable<int> value);
    partial void OnKategoriIdChanged();
    partial void OnSatisBaslangicTarihiChanging(System.Nullable<System.DateTime> value);
    partial void OnSatisBaslangicTarihiChanged();
    partial void OnSatisBitisTarihiChanging(System.Nullable<System.DateTime> value);
    partial void OnSatisBitisTarihiChanged();
    #endregion
		
		public Table_Urun()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UrunId", DbType="Int NOT NULL", IsPrimaryKey=true)]
		public int UrunId
		{
			get
			{
				return this._UrunId;
			}
			set
			{
				if ((this._UrunId != value))
				{
					this.OnUrunIdChanging(value);
					this.SendPropertyChanging();
					this._UrunId = value;
					this.SendPropertyChanged("UrunId");
					this.OnUrunIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UrunAdi", DbType="NVarChar(50)")]
		public string UrunAdi
		{
			get
			{
				return this._UrunAdi;
			}
			set
			{
				if ((this._UrunAdi != value))
				{
					this.OnUrunAdiChanging(value);
					this.SendPropertyChanging();
					this._UrunAdi = value;
					this.SendPropertyChanged("UrunAdi");
					this.OnUrunAdiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fiyat", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Fiyat
		{
			get
			{
				return this._Fiyat;
			}
			set
			{
				if ((this._Fiyat != value))
				{
					this.OnFiyatChanging(value);
					this.SendPropertyChanging();
					this._Fiyat = value;
					this.SendPropertyChanged("Fiyat");
					this.OnFiyatChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KategoriId", DbType="Int")]
		public System.Nullable<int> KategoriId
		{
			get
			{
				return this._KategoriId;
			}
			set
			{
				if ((this._KategoriId != value))
				{
					this.OnKategoriIdChanging(value);
					this.SendPropertyChanging();
					this._KategoriId = value;
					this.SendPropertyChanged("KategoriId");
					this.OnKategoriIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SatisBaslangicTarihi", DbType="DateTime")]
		public System.Nullable<System.DateTime> SatisBaslangicTarihi
		{
			get
			{
				return this._SatisBaslangicTarihi;
			}
			set
			{
				if ((this._SatisBaslangicTarihi != value))
				{
					this.OnSatisBaslangicTarihiChanging(value);
					this.SendPropertyChanging();
					this._SatisBaslangicTarihi = value;
					this.SendPropertyChanged("SatisBaslangicTarihi");
					this.OnSatisBaslangicTarihiChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SatisBitisTarihi", DbType="DateTime")]
		public System.Nullable<System.DateTime> SatisBitisTarihi
		{
			get
			{
				return this._SatisBitisTarihi;
			}
			set
			{
				if ((this._SatisBitisTarihi != value))
				{
					this.OnSatisBitisTarihiChanging(value);
					this.SendPropertyChanging();
					this._SatisBitisTarihi = value;
					this.SendPropertyChanged("SatisBitisTarihi");
					this.OnSatisBitisTarihiChanged();
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
	
	public partial class EnUzunSatistakiUrunResult
	{
		
		private int _UrunId;
		
		private string _UrunAdi;
		
		private System.Nullable<decimal> _Fiyat;
		
		private System.Nullable<int> _KategoriId;
		
		private System.Nullable<System.DateTime> _SatisBaslangicTarihi;
		
		private System.Nullable<System.DateTime> _SatisBitisTarihi;
		
		public EnUzunSatistakiUrunResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UrunId", DbType="Int NOT NULL")]
		public int UrunId
		{
			get
			{
				return this._UrunId;
			}
			set
			{
				if ((this._UrunId != value))
				{
					this._UrunId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UrunAdi", DbType="NVarChar(50)")]
		public string UrunAdi
		{
			get
			{
				return this._UrunAdi;
			}
			set
			{
				if ((this._UrunAdi != value))
				{
					this._UrunAdi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Fiyat", DbType="Decimal(18,0)")]
		public System.Nullable<decimal> Fiyat
		{
			get
			{
				return this._Fiyat;
			}
			set
			{
				if ((this._Fiyat != value))
				{
					this._Fiyat = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_KategoriId", DbType="Int")]
		public System.Nullable<int> KategoriId
		{
			get
			{
				return this._KategoriId;
			}
			set
			{
				if ((this._KategoriId != value))
				{
					this._KategoriId = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SatisBaslangicTarihi", DbType="DateTime")]
		public System.Nullable<System.DateTime> SatisBaslangicTarihi
		{
			get
			{
				return this._SatisBaslangicTarihi;
			}
			set
			{
				if ((this._SatisBaslangicTarihi != value))
				{
					this._SatisBaslangicTarihi = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SatisBitisTarihi", DbType="DateTime")]
		public System.Nullable<System.DateTime> SatisBitisTarihi
		{
			get
			{
				return this._SatisBitisTarihi;
			}
			set
			{
				if ((this._SatisBitisTarihi != value))
				{
					this._SatisBitisTarihi = value;
				}
			}
		}
	}
}
#pragma warning restore 1591