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

namespace Aplikasi_Project_Apotek_Kimia_Farma
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
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="UAS_Visprog")]
	public partial class DataClasses1DataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    partial void InsertMedicine(Medicine instance);
    partial void UpdateMedicine(Medicine instance);
    partial void DeleteMedicine(Medicine instance);
    partial void InsertSuplier(Suplier instance);
    partial void UpdateSuplier(Suplier instance);
    partial void DeleteSuplier(Suplier instance);
    partial void InsertCustomer(Customer instance);
    partial void UpdateCustomer(Customer instance);
    partial void DeleteCustomer(Customer instance);
    partial void InsertEmployee(Employee instance);
    partial void UpdateEmployee(Employee instance);
    partial void DeleteEmployee(Employee instance);
    partial void InsertTransactionDetail(TransactionDetail instance);
    partial void UpdateTransactionDetail(TransactionDetail instance);
    partial void DeleteTransactionDetail(TransactionDetail instance);
    partial void InsertTransaksi(Transaksi instance);
    partial void UpdateTransaksi(Transaksi instance);
    partial void DeleteTransaksi(Transaksi instance);
    #endregion
		
		public DataClasses1DataContext() : 
				base(global::Aplikasi_Project_Apotek_Kimia_Farma.Properties.Settings.Default.UAS_VisprogConnectionString, mappingSource)
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
		
		public System.Data.Linq.Table<Medicine> Medicines
		{
			get
			{
				return this.GetTable<Medicine>();
			}
		}
		
		public System.Data.Linq.Table<Suplier> Supliers
		{
			get
			{
				return this.GetTable<Suplier>();
			}
		}
		
		public System.Data.Linq.Table<Customer> Customers
		{
			get
			{
				return this.GetTable<Customer>();
			}
		}
		
		public System.Data.Linq.Table<Employee> Employees
		{
			get
			{
				return this.GetTable<Employee>();
			}
		}
		
		public System.Data.Linq.Table<TransactionDetail> TransactionDetails
		{
			get
			{
				return this.GetTable<TransactionDetail>();
			}
		}
		
		public System.Data.Linq.Table<Transaksi> Transaksis
		{
			get
			{
				return this.GetTable<Transaksi>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Medicine")]
	public partial class Medicine : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _MedicineID;
		
		private string _MedicineName;
		
		private int _MedicinePrice;
		
		private int _MedicineQty;
		
		private string _MedicineDate;
		
		private EntitySet<TransactionDetail> _TransactionDetails;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnMedicineIDChanging(string value);
    partial void OnMedicineIDChanged();
    partial void OnMedicineNameChanging(string value);
    partial void OnMedicineNameChanged();
    partial void OnMedicinePriceChanging(int value);
    partial void OnMedicinePriceChanged();
    partial void OnMedicineQtyChanging(int value);
    partial void OnMedicineQtyChanged();
    partial void OnMedicineDateChanging(string value);
    partial void OnMedicineDateChanged();
    #endregion
		
		public Medicine()
		{
			this._TransactionDetails = new EntitySet<TransactionDetail>(new Action<TransactionDetail>(this.attach_TransactionDetails), new Action<TransactionDetail>(this.detach_TransactionDetails));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedicineID", DbType="VarChar(8) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string MedicineID
		{
			get
			{
				return this._MedicineID;
			}
			set
			{
				if ((this._MedicineID != value))
				{
					this.OnMedicineIDChanging(value);
					this.SendPropertyChanging();
					this._MedicineID = value;
					this.SendPropertyChanged("MedicineID");
					this.OnMedicineIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedicineName", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string MedicineName
		{
			get
			{
				return this._MedicineName;
			}
			set
			{
				if ((this._MedicineName != value))
				{
					this.OnMedicineNameChanging(value);
					this.SendPropertyChanging();
					this._MedicineName = value;
					this.SendPropertyChanged("MedicineName");
					this.OnMedicineNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedicinePrice", DbType="Int NOT NULL")]
		public int MedicinePrice
		{
			get
			{
				return this._MedicinePrice;
			}
			set
			{
				if ((this._MedicinePrice != value))
				{
					this.OnMedicinePriceChanging(value);
					this.SendPropertyChanging();
					this._MedicinePrice = value;
					this.SendPropertyChanged("MedicinePrice");
					this.OnMedicinePriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedicineQty", DbType="Int NOT NULL")]
		public int MedicineQty
		{
			get
			{
				return this._MedicineQty;
			}
			set
			{
				if ((this._MedicineQty != value))
				{
					this.OnMedicineQtyChanging(value);
					this.SendPropertyChanging();
					this._MedicineQty = value;
					this.SendPropertyChanged("MedicineQty");
					this.OnMedicineQtyChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedicineDate", DbType="VarChar(50)")]
		public string MedicineDate
		{
			get
			{
				return this._MedicineDate;
			}
			set
			{
				if ((this._MedicineDate != value))
				{
					this.OnMedicineDateChanging(value);
					this.SendPropertyChanging();
					this._MedicineDate = value;
					this.SendPropertyChanged("MedicineDate");
					this.OnMedicineDateChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Medicine_TransactionDetail", Storage="_TransactionDetails", ThisKey="MedicineID", OtherKey="MedicineID")]
		public EntitySet<TransactionDetail> TransactionDetails
		{
			get
			{
				return this._TransactionDetails;
			}
			set
			{
				this._TransactionDetails.Assign(value);
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
		
		private void attach_TransactionDetails(TransactionDetail entity)
		{
			this.SendPropertyChanging();
			entity.Medicine = this;
		}
		
		private void detach_TransactionDetails(TransactionDetail entity)
		{
			this.SendPropertyChanging();
			entity.Medicine = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Suplier")]
	public partial class Suplier : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _SuplierID;
		
		private string _SuplierName;
		
		private string _SuplierAddress;
		
		private string _SuplierPhone;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnSuplierIDChanging(string value);
    partial void OnSuplierIDChanged();
    partial void OnSuplierNameChanging(string value);
    partial void OnSuplierNameChanged();
    partial void OnSuplierAddressChanging(string value);
    partial void OnSuplierAddressChanged();
    partial void OnSuplierPhoneChanging(string value);
    partial void OnSuplierPhoneChanged();
    #endregion
		
		public Suplier()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SuplierID", DbType="VarChar(8) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string SuplierID
		{
			get
			{
				return this._SuplierID;
			}
			set
			{
				if ((this._SuplierID != value))
				{
					this.OnSuplierIDChanging(value);
					this.SendPropertyChanging();
					this._SuplierID = value;
					this.SendPropertyChanged("SuplierID");
					this.OnSuplierIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SuplierName", DbType="VarChar(20)")]
		public string SuplierName
		{
			get
			{
				return this._SuplierName;
			}
			set
			{
				if ((this._SuplierName != value))
				{
					this.OnSuplierNameChanging(value);
					this.SendPropertyChanging();
					this._SuplierName = value;
					this.SendPropertyChanged("SuplierName");
					this.OnSuplierNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SuplierAddress", DbType="VarChar(40)")]
		public string SuplierAddress
		{
			get
			{
				return this._SuplierAddress;
			}
			set
			{
				if ((this._SuplierAddress != value))
				{
					this.OnSuplierAddressChanging(value);
					this.SendPropertyChanging();
					this._SuplierAddress = value;
					this.SendPropertyChanged("SuplierAddress");
					this.OnSuplierAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SuplierPhone", DbType="VarChar(20)")]
		public string SuplierPhone
		{
			get
			{
				return this._SuplierPhone;
			}
			set
			{
				if ((this._SuplierPhone != value))
				{
					this.OnSuplierPhoneChanging(value);
					this.SendPropertyChanging();
					this._SuplierPhone = value;
					this.SendPropertyChanged("SuplierPhone");
					this.OnSuplierPhoneChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Customer")]
	public partial class Customer : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _CustID;
		
		private string _CustName;
		
		private string _CustAddress;
		
		private string _CustPhone;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnCustIDChanging(string value);
    partial void OnCustIDChanged();
    partial void OnCustNameChanging(string value);
    partial void OnCustNameChanged();
    partial void OnCustAddressChanging(string value);
    partial void OnCustAddressChanged();
    partial void OnCustPhoneChanging(string value);
    partial void OnCustPhoneChanged();
    #endregion
		
		public Customer()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustID", DbType="VarChar(8) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string CustID
		{
			get
			{
				return this._CustID;
			}
			set
			{
				if ((this._CustID != value))
				{
					this.OnCustIDChanging(value);
					this.SendPropertyChanging();
					this._CustID = value;
					this.SendPropertyChanged("CustID");
					this.OnCustIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustName", DbType="VarChar(20)")]
		public string CustName
		{
			get
			{
				return this._CustName;
			}
			set
			{
				if ((this._CustName != value))
				{
					this.OnCustNameChanging(value);
					this.SendPropertyChanging();
					this._CustName = value;
					this.SendPropertyChanged("CustName");
					this.OnCustNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustAddress", DbType="VarChar(30)")]
		public string CustAddress
		{
			get
			{
				return this._CustAddress;
			}
			set
			{
				if ((this._CustAddress != value))
				{
					this.OnCustAddressChanging(value);
					this.SendPropertyChanging();
					this._CustAddress = value;
					this.SendPropertyChanged("CustAddress");
					this.OnCustAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_CustPhone", DbType="VarChar(30)")]
		public string CustPhone
		{
			get
			{
				return this._CustPhone;
			}
			set
			{
				if ((this._CustPhone != value))
				{
					this.OnCustPhoneChanging(value);
					this.SendPropertyChanging();
					this._CustPhone = value;
					this.SendPropertyChanged("CustPhone");
					this.OnCustPhoneChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Employee")]
	public partial class Employee : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _EmployeeID;
		
		private string _EmployeeName;
		
		private string _EmployeePosition;
		
		private string _EmployeeAddress;
		
		private string _UserName;
		
		private string _Pasword;
		
		private string _Email;
		
		private string _Date;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnEmployeeIDChanging(string value);
    partial void OnEmployeeIDChanged();
    partial void OnEmployeeNameChanging(string value);
    partial void OnEmployeeNameChanged();
    partial void OnEmployeePositionChanging(string value);
    partial void OnEmployeePositionChanged();
    partial void OnEmployeeAddressChanging(string value);
    partial void OnEmployeeAddressChanged();
    partial void OnUserNameChanging(string value);
    partial void OnUserNameChanged();
    partial void OnPaswordChanging(string value);
    partial void OnPaswordChanged();
    partial void OnEmailChanging(string value);
    partial void OnEmailChanged();
    partial void OnDateChanging(string value);
    partial void OnDateChanged();
    #endregion
		
		public Employee()
		{
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeID", DbType="VarChar(8) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string EmployeeID
		{
			get
			{
				return this._EmployeeID;
			}
			set
			{
				if ((this._EmployeeID != value))
				{
					this.OnEmployeeIDChanging(value);
					this.SendPropertyChanging();
					this._EmployeeID = value;
					this.SendPropertyChanged("EmployeeID");
					this.OnEmployeeIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeName", DbType="VarChar(25)")]
		public string EmployeeName
		{
			get
			{
				return this._EmployeeName;
			}
			set
			{
				if ((this._EmployeeName != value))
				{
					this.OnEmployeeNameChanging(value);
					this.SendPropertyChanging();
					this._EmployeeName = value;
					this.SendPropertyChanged("EmployeeName");
					this.OnEmployeeNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeePosition", DbType="VarChar(10)")]
		public string EmployeePosition
		{
			get
			{
				return this._EmployeePosition;
			}
			set
			{
				if ((this._EmployeePosition != value))
				{
					this.OnEmployeePositionChanging(value);
					this.SendPropertyChanging();
					this._EmployeePosition = value;
					this.SendPropertyChanged("EmployeePosition");
					this.OnEmployeePositionChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_EmployeeAddress", DbType="VarChar(50)")]
		public string EmployeeAddress
		{
			get
			{
				return this._EmployeeAddress;
			}
			set
			{
				if ((this._EmployeeAddress != value))
				{
					this.OnEmployeeAddressChanging(value);
					this.SendPropertyChanging();
					this._EmployeeAddress = value;
					this.SendPropertyChanged("EmployeeAddress");
					this.OnEmployeeAddressChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_UserName", DbType="VarChar(20)")]
		public string UserName
		{
			get
			{
				return this._UserName;
			}
			set
			{
				if ((this._UserName != value))
				{
					this.OnUserNameChanging(value);
					this.SendPropertyChanging();
					this._UserName = value;
					this.SendPropertyChanged("UserName");
					this.OnUserNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Pasword", DbType="VarChar(40)")]
		public string Pasword
		{
			get
			{
				return this._Pasword;
			}
			set
			{
				if ((this._Pasword != value))
				{
					this.OnPaswordChanging(value);
					this.SendPropertyChanging();
					this._Pasword = value;
					this.SendPropertyChanged("Pasword");
					this.OnPaswordChanged();
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
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Date", DbType="VarChar(50)")]
		public string Date
		{
			get
			{
				return this._Date;
			}
			set
			{
				if ((this._Date != value))
				{
					this.OnDateChanging(value);
					this.SendPropertyChanging();
					this._Date = value;
					this.SendPropertyChanged("Date");
					this.OnDateChanged();
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TransactionDetail")]
	public partial class TransactionDetail : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TransactionID;
		
		private string _MedicineID;
		
		private string _Quantity;
		
		private EntityRef<Medicine> _Medicine;
		
		private EntityRef<Transaksi> _Transaksi;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTransactionIDChanging(string value);
    partial void OnTransactionIDChanged();
    partial void OnMedicineIDChanging(string value);
    partial void OnMedicineIDChanged();
    partial void OnQuantityChanging(string value);
    partial void OnQuantityChanged();
    #endregion
		
		public TransactionDetail()
		{
			this._Medicine = default(EntityRef<Medicine>);
			this._Transaksi = default(EntityRef<Transaksi>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionID", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TransactionID
		{
			get
			{
				return this._TransactionID;
			}
			set
			{
				if ((this._TransactionID != value))
				{
					if (this._Transaksi.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTransactionIDChanging(value);
					this.SendPropertyChanging();
					this._TransactionID = value;
					this.SendPropertyChanged("TransactionID");
					this.OnTransactionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedicineID", DbType="VarChar(8) NOT NULL", CanBeNull=false)]
		public string MedicineID
		{
			get
			{
				return this._MedicineID;
			}
			set
			{
				if ((this._MedicineID != value))
				{
					if (this._Medicine.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnMedicineIDChanging(value);
					this.SendPropertyChanging();
					this._MedicineID = value;
					this.SendPropertyChanged("MedicineID");
					this.OnMedicineIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Quantity", DbType="VarChar(10) NOT NULL", CanBeNull=false)]
		public string Quantity
		{
			get
			{
				return this._Quantity;
			}
			set
			{
				if ((this._Quantity != value))
				{
					this.OnQuantityChanging(value);
					this.SendPropertyChanging();
					this._Quantity = value;
					this.SendPropertyChanged("Quantity");
					this.OnQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Medicine_TransactionDetail", Storage="_Medicine", ThisKey="MedicineID", OtherKey="MedicineID", IsForeignKey=true)]
		public Medicine Medicine
		{
			get
			{
				return this._Medicine.Entity;
			}
			set
			{
				Medicine previousValue = this._Medicine.Entity;
				if (((previousValue != value) 
							|| (this._Medicine.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Medicine.Entity = null;
						previousValue.TransactionDetails.Remove(this);
					}
					this._Medicine.Entity = value;
					if ((value != null))
					{
						value.TransactionDetails.Add(this);
						this._MedicineID = value.MedicineID;
					}
					else
					{
						this._MedicineID = default(string);
					}
					this.SendPropertyChanged("Medicine");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Transaksi_TransactionDetail", Storage="_Transaksi", ThisKey="TransactionID", OtherKey="TransactionID", IsForeignKey=true)]
		public Transaksi Transaksi
		{
			get
			{
				return this._Transaksi.Entity;
			}
			set
			{
				Transaksi previousValue = this._Transaksi.Entity;
				if (((previousValue != value) 
							|| (this._Transaksi.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Transaksi.Entity = null;
						previousValue.TransactionDetail = null;
					}
					this._Transaksi.Entity = value;
					if ((value != null))
					{
						value.TransactionDetail = this;
						this._TransactionID = value.TransactionID;
					}
					else
					{
						this._TransactionID = default(string);
					}
					this.SendPropertyChanged("Transaksi");
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
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Transaksi")]
	public partial class Transaksi : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private string _TransactionID;
		
		private string _MedicineName;
		
		private System.Nullable<int> _MedicinePrice;
		
		private System.Nullable<int> _MedicineQuantity;
		
		private System.Nullable<int> _Totalharga;
		
		private EntityRef<TransactionDetail> _TransactionDetail;
		
    #region Extensibility Method Definitions
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnTransactionIDChanging(string value);
    partial void OnTransactionIDChanged();
    partial void OnMedicineNameChanging(string value);
    partial void OnMedicineNameChanged();
    partial void OnMedicinePriceChanging(System.Nullable<int> value);
    partial void OnMedicinePriceChanged();
    partial void OnMedicineQuantityChanging(System.Nullable<int> value);
    partial void OnMedicineQuantityChanged();
    partial void OnTotalhargaChanging(System.Nullable<int> value);
    partial void OnTotalhargaChanged();
    #endregion
		
		public Transaksi()
		{
			this._TransactionDetail = default(EntityRef<TransactionDetail>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TransactionID", DbType="VarChar(10) NOT NULL", CanBeNull=false, IsPrimaryKey=true)]
		public string TransactionID
		{
			get
			{
				return this._TransactionID;
			}
			set
			{
				if ((this._TransactionID != value))
				{
					this.OnTransactionIDChanging(value);
					this.SendPropertyChanging();
					this._TransactionID = value;
					this.SendPropertyChanged("TransactionID");
					this.OnTransactionIDChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedicineName", DbType="VarChar(30)")]
		public string MedicineName
		{
			get
			{
				return this._MedicineName;
			}
			set
			{
				if ((this._MedicineName != value))
				{
					this.OnMedicineNameChanging(value);
					this.SendPropertyChanging();
					this._MedicineName = value;
					this.SendPropertyChanged("MedicineName");
					this.OnMedicineNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedicinePrice", DbType="Int")]
		public System.Nullable<int> MedicinePrice
		{
			get
			{
				return this._MedicinePrice;
			}
			set
			{
				if ((this._MedicinePrice != value))
				{
					this.OnMedicinePriceChanging(value);
					this.SendPropertyChanging();
					this._MedicinePrice = value;
					this.SendPropertyChanged("MedicinePrice");
					this.OnMedicinePriceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_MedicineQuantity", DbType="Int")]
		public System.Nullable<int> MedicineQuantity
		{
			get
			{
				return this._MedicineQuantity;
			}
			set
			{
				if ((this._MedicineQuantity != value))
				{
					this.OnMedicineQuantityChanging(value);
					this.SendPropertyChanging();
					this._MedicineQuantity = value;
					this.SendPropertyChanged("MedicineQuantity");
					this.OnMedicineQuantityChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Totalharga", DbType="Int")]
		public System.Nullable<int> Totalharga
		{
			get
			{
				return this._Totalharga;
			}
			set
			{
				if ((this._Totalharga != value))
				{
					this.OnTotalhargaChanging(value);
					this.SendPropertyChanging();
					this._Totalharga = value;
					this.SendPropertyChanged("Totalharga");
					this.OnTotalhargaChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Transaksi_TransactionDetail", Storage="_TransactionDetail", ThisKey="TransactionID", OtherKey="TransactionID", IsUnique=true, IsForeignKey=false)]
		public TransactionDetail TransactionDetail
		{
			get
			{
				return this._TransactionDetail.Entity;
			}
			set
			{
				TransactionDetail previousValue = this._TransactionDetail.Entity;
				if (((previousValue != value) 
							|| (this._TransactionDetail.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._TransactionDetail.Entity = null;
						previousValue.Transaksi = null;
					}
					this._TransactionDetail.Entity = value;
					if ((value != null))
					{
						value.Transaksi = this;
					}
					this.SendPropertyChanged("TransactionDetail");
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