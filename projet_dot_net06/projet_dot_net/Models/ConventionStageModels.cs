using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Models
{
    public class ConventionStageModels
    {
        public int Id { get; set; }
        public string Sujet{ get; set; }
        public decimal remuneration { get; set; }
        public string memoire { get; set; }
        public int duree { get; set; }
    }
}

