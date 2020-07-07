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
    public class DepartmentController : ApiController
    {
        // GET api/department
        public IEnumerable<Department> GetDepartment()
        {
            IEnumerable<Department> Result = new List<Department>();
            empEntities db = new empEntities();
            Result = db.tbldepartments.Select(depart => new Department { DepartmentId = depart.DepartmentId, DepartmentName = depart.DepartmentName, Location = depart.Location }).AsEnumerable<Department>();

            return Result;
        }

       
        // POST api/department
        public string AddDepartment(string DepartmentName, string Location)
        {
            string strResult = "";
            try
            {

                Department depart = new Department
                {
                    DepartmentName = DepartmentName,
                    Location = Location
                };
                using (empEntities db = new empEntities())
                {
                    db.AddObject("tbldepartments", depart);
                    db.SaveChanges();

                };
            }
            catch (Exception ex)
            {
                strResult = ex.Message;
            }

            return null;
        }

        // PUT api/department/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/department/5
        public void Delete(int id)
        {
        }
    }
}
