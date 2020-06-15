using Magazyn.Models;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Blazor.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magazyn.Data
{
    public class TowarService
    {
        private readonly MczeContext _db;

        public TowarService(MczeContext db)


        {
            _db = db;

        }

        public List<Tbtowar> GetTowar()
             
        {
          var towList = _db.Tbtowar .ToList();
          return towList;
         
        }

      

        public string Create(Tbtowar objTowar)
        {
            _db.Tbtowar.Add(objTowar);
            _db.SaveChanges();
            return "ok";

        }

        public Tbtowar GetTbtowarById(int id)
        {
            Tbtowar towary = _db.Tbtowar.FirstOrDefault(s => s.Idtowar == id);
            return towary;
        }

        public string UpdateTowary(Tbtowar objTowar)
        {
            _db.Tbtowar.Update(objTowar);
            _db.SaveChanges();
            return "update";
        }

        public string DeleteTowar(Tbtowar objTowar)
        {
            _db.Remove(objTowar);
            _db.SaveChanges();
            return "delete";
        }



       

        }


    }










