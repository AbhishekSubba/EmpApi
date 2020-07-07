﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace EMPApi.Models
{
    [Table("tblemployees")]
    public class Employee
    {
        public int EmpId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        //public Int32 DepartmentId { get; set; }
    }
}