﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Magazyn.Models
{
    public partial class Tbdokument
    {
        public Tbdokument()
        {
            Tbprzyjecie = new HashSet<Tbprzyjecie>();
            Tbrozchod = new HashSet<Tbrozchod>();
        }

        [Key]
        public int Iddokument { get; set; }
        public string Nazwa { get; set; }
        public string Symbol { get; set; }
        public string EanDokument { get; set; }

        public virtual ICollection<Tbprzyjecie> Tbprzyjecie { get; set; }
        public virtual ICollection<Tbrozchod> Tbrozchod { get; set; }
    }
}