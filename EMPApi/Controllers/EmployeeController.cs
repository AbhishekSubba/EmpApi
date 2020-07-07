using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using System.Data.Objects;
using EMPApi.Models;

namespace EMPApi.Controllers
{
    public class EmployeeController : ApiController
    {
        // GET api/Employee
        public IEnumerable<Employee> GetEmployee()
        {
           IEnumerable<Employee> Result = new List<Employee>();
           empEntities db = new empEntities();
           Result = db.tblemployees.Select(employee => new Employee { FirstName = employee.FirstName, LastName = employee.LastName, Gender = employee.Gender,Salary=(int)(employee.Salary)}).AsEnumerable<Employee>();

            return Result;
        }
        // POST api/Employee
        public string InsertEmployee(string FirstName, string LastName, string Gender, int Salary)
        {
            /*Employee employee = new Employee
            {
                FirstName=emp.FirstName,
                LastName=emp.LastName,
                Gender = emp.Gender,
                Salary=emp.Salary,
                DepartmentId=emp.DepartmentId
            };*/
            string strResult = "";
            try
            {
                
                Employee employee = new Employee
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    Gender = Gender,
                    Salary = Salary
                };
                using (empEntities db = new empEntities())
                {
                    db.AddObject("tblemployees",employee);
                    db.SaveChanges();

                };
            }
            catch(Exception ex)
            {
                strResult = ex.Message;
            }

            return null;
        }
        // PUT api/Employee/
        public string UpdateEmployee(int EmpID, string FirstName, string LastName, string Gender, int Salary)
        {
            
            string strResult = "";
            try
            {
                empEntities db = new empEntities();
                var Results = db.tblemployees.Single(x => x.EmpId == (int)EmpID);
                Results.FirstName = FirstName;
                Results.LastName = LastName;
                Results.Gender = Gender;
                Results.Salary = Salary;
                db.SaveChanges();
                strResult = "Changes Updated Successfully";
            }
            catch (Exception ex)
            {
                strResult = ex.Message;
            }
            return strResult;
        }
        // DELETE api/Employee/3
        public string DeleteEmployee(int EmpID)
        {

            string strResult = "";
            try
            {
                empEntities db = new empEntities();
                var Results = db.tblemployees.Single(x => x.EmpId == (int)EmpID);
                db.tblemployees.DeleteObject(Results);
                db.SaveChanges();
                strResult = "Deleted Successfully";
            }
            catch (Exception ex)
            {
                strResult = ex.Message;
            }
            return strResult;
        }
    }
}
