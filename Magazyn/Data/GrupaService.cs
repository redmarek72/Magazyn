using Magazyn.Models;
using Microsoft.EntityFrameworkCore;
using Syncfusion.Blazor.Schedule;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Magazyn.Data
{
    public class GrupaService
    {
        private readonly MczeContext _db;

        public GrupaService(MczeContext db)


        {
            _db = db;

        }

        //  public List<Tbgrupa> GetGrupa()

        //  {
        //    var grupaList = _db.Tbgrupa.ToList();
        //   return grupaList;

        // }

      



    }
}
