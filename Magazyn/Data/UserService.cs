using Magazyn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magazyn.Data
{
    public class UserService
    {
        private readonly MczeContext _db;

        public UserService(MczeContext db)

        {
            _db = db;

        }

        // CRUD 

        public List<Tbuser> GetEmployee()
        {
            var empList = _db.Tbuser.ToList();
            return empList;
        }

        public string Create(Tbuser objEmployee)
        {
            _db.Tbuser.Add(objEmployee);
            _db.SaveChanges();
            return "Success";
        }


        public Tbuser GetEmployeeById(int id)
        {
            Tbuser employee = _db.Tbuser.FirstOrDefault(s => s.Iduser == id);
            return employee;
        }


        public string UpdateEmployee(Tbuser objEmmployee)
        {
            _db.Tbuser.Update(objEmmployee);
            _db.SaveChanges();
            return "update";
        }


        public string DeleteEmpInfo(Tbuser objEmployee)
        {
            _db.Remove(objEmployee);
            _db.SaveChanges();
            return "Delete";

        }
        public List<Tbuser> GetAktywny()
        {
            var empList = _db.Tbuser.Where(x => x.Aktywny == 1).ToList();
            return empList;
        }
       
    }
   
}
   
