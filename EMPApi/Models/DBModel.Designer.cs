﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.ComponentModel;
using System.Data.EntityClient;
using System.Data.Objects;
using System.Data.Objects.DataClasses;
using System.Linq;
using System.Runtime.Serialization;
using System.Xml.Serialization;

[assembly: EdmSchemaAttribute()]
namespace EMPApi.Models
{
    #region Contexts
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    public partial class empEntities : ObjectContext
    {
        #region Constructors
    
        /// <summary>
        /// Initializes a new empEntities object using the connection string found in the 'empEntities' section of the application configuration file.
        /// </summary>
        public empEntities() : base("name=empEntities", "empEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new empEntities object.
        /// </summary>
        public empEntities(string connectionString) : base(connectionString, "empEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        /// <summary>
        /// Initialize a new empEntities object.
        /// </summary>
        public empEntities(EntityConnection connection) : base(connection, "empEntities")
        {
            this.ContextOptions.LazyLoadingEnabled = true;
            OnContextCreated();
        }
    
        #endregion
    
        #region Partial Methods
    
        partial void OnContextCreated();
    
        #endregion
    
        #region ObjectSet Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tbldepartment> tbldepartments
        {
            get
            {
                if ((_tbldepartments == null))
                {
                    _tbldepartments = base.CreateObjectSet<tbldepartment>("tbldepartments");
                }
                return _tbldepartments;
            }
        }
        private ObjectSet<tbldepartment> _tbldepartments;
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        public ObjectSet<tblemployee> tblemployees
        {
            get
            {
                if ((_tblemployees == null))
                {
                    _tblemployees = base.CreateObjectSet<tblemployee>("tblemployees");
                }
                return _tblemployees;
            }
        }
        private ObjectSet<tblemployee> _tblemployees;

        #endregion

        #region AddTo Methods
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tbldepartments EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotbldepartments(tbldepartment tbldepartment)
        {
            base.AddObject("tbldepartments", tbldepartment);
        }
    
        /// <summary>
        /// Deprecated Method for adding a new object to the tblemployees EntitySet. Consider using the .Add method of the associated ObjectSet&lt;T&gt; property instead.
        /// </summary>
        public void AddTotblemployees(tblemployee tblemployee)
        {
            base.AddObject("tblemployees", tblemployee);
        }

        #endregion

    }

    #endregion

    #region Entities
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="empModel", Name="tbldepartment")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tbldepartment : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tbldepartment object.
        /// </summary>
        /// <param name="departmentId">Initial value of the DepartmentId property.</param>
        /// <param name="departmentName">Initial value of the DepartmentName property.</param>
        public static tbldepartment Createtbldepartment(global::System.Int32 departmentId, global::System.String departmentName)
        {
            tbldepartment tbldepartment = new tbldepartment();
            tbldepartment.DepartmentId = departmentId;
            tbldepartment.DepartmentName = departmentName;
            return tbldepartment;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 DepartmentId
        {
            get
            {
                return _DepartmentId;
            }
            set
            {
                if (_DepartmentId != value)
                {
                    OnDepartmentIdChanging(value);
                    ReportPropertyChanging("DepartmentId");
                    _DepartmentId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("DepartmentId");
                    OnDepartmentIdChanged();
                }
            }
        }
        private global::System.Int32 _DepartmentId;
        partial void OnDepartmentIdChanging(global::System.Int32 value);
        partial void OnDepartmentIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String DepartmentName
        {
            get
            {
                return _DepartmentName;
            }
            set
            {
                OnDepartmentNameChanging(value);
                ReportPropertyChanging("DepartmentName");
                _DepartmentName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("DepartmentName");
                OnDepartmentNameChanged();
            }
        }
        private global::System.String _DepartmentName;
        partial void OnDepartmentNameChanging(global::System.String value);
        partial void OnDepartmentNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String Location
        {
            get
            {
                return _Location;
            }
            set
            {
                OnLocationChanging(value);
                ReportPropertyChanging("Location");
                _Location = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("Location");
                OnLocationChanged();
            }
        }
        private global::System.String _Location;
        partial void OnLocationChanging(global::System.String value);
        partial void OnLocationChanged();

        #endregion

    
    }
    
    /// <summary>
    /// No Metadata Documentation available.
    /// </summary>
    [EdmEntityTypeAttribute(NamespaceName="empModel", Name="tblemployee")]
    [Serializable()]
    [DataContractAttribute(IsReference=true)]
    public partial class tblemployee : EntityObject
    {
        #region Factory Method
    
        /// <summary>
        /// Create a new tblemployee object.
        /// </summary>
        /// <param name="empId">Initial value of the EmpId property.</param>
        /// <param name="firstName">Initial value of the FirstName property.</param>
        /// <param name="gender">Initial value of the Gender property.</param>
        public static tblemployee Createtblemployee(global::System.Int32 empId, global::System.String firstName, global::System.String gender)
        {
            tblemployee tblemployee = new tblemployee();
            tblemployee.EmpId = empId;
            tblemployee.FirstName = firstName;
            tblemployee.Gender = gender;
            return tblemployee;
        }

        #endregion

        #region Primitive Properties
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=true, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.Int32 EmpId
        {
            get
            {
                return _EmpId;
            }
            set
            {
                if (_EmpId != value)
                {
                    OnEmpIdChanging(value);
                    ReportPropertyChanging("EmpId");
                    _EmpId = StructuralObject.SetValidValue(value);
                    ReportPropertyChanged("EmpId");
                    OnEmpIdChanged();
                }
            }
        }
        private global::System.Int32 _EmpId;
        partial void OnEmpIdChanging(global::System.Int32 value);
        partial void OnEmpIdChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String FirstName
        {
            get
            {
                return _FirstName;
            }
            set
            {
                OnFirstNameChanging(value);
                ReportPropertyChanging("FirstName");
                _FirstName = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("FirstName");
                OnFirstNameChanged();
            }
        }
        private global::System.String _FirstName;
        partial void OnFirstNameChanging(global::System.String value);
        partial void OnFirstNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public global::System.String LastName
        {
            get
            {
                return _LastName;
            }
            set
            {
                OnLastNameChanging(value);
                ReportPropertyChanging("LastName");
                _LastName = StructuralObject.SetValidValue(value, true);
                ReportPropertyChanged("LastName");
                OnLastNameChanged();
            }
        }
        private global::System.String _LastName;
        partial void OnLastNameChanging(global::System.String value);
        partial void OnLastNameChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=false)]
        [DataMemberAttribute()]
        public global::System.String Gender
        {
            get
            {
                return _Gender;
            }
            set
            {
                OnGenderChanging(value);
                ReportPropertyChanging("Gender");
                _Gender = StructuralObject.SetValidValue(value, false);
                ReportPropertyChanged("Gender");
                OnGenderChanged();
            }
        }
        private global::System.String _Gender;
        partial void OnGenderChanging(global::System.String value);
        partial void OnGenderChanged();
    
        /// <summary>
        /// No Metadata Documentation available.
        /// </summary>
        [EdmScalarPropertyAttribute(EntityKeyProperty=false, IsNullable=true)]
        [DataMemberAttribute()]
        public Nullable<global::System.Int32> Salary
        {
            get
            {
                return _Salary;
            }
            set
            {
                OnSalaryChanging(value);
                ReportPropertyChanging("Salary");
                _Salary = StructuralObject.SetValidValue(value);
                ReportPropertyChanged("Salary");
                OnSalaryChanged();
            }
        }
        private Nullable<global::System.Int32> _Salary;
        partial void OnSalaryChanging(Nullable<global::System.Int32> value);
        partial void OnSalaryChanged();

        #endregion

    
    }

    #endregion

    
}
