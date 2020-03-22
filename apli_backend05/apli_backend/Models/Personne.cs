using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apli_backend.Models
{
    public class Personne // il s'agit de la class Personne avec ses champs/attributs + les mutateurs(Set) et accesseurs (Get)
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }
        public int Age { get; set; }
    }
}
