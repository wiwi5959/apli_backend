using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apli_backend.Models
{
    public class Voiture  // il s'agit de la class Voiture avec ses champs/attributs + les mutateurs(Set) et accesseurs (Get)
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Marque { get; set; }
        public int Immatriculation { get; set; }
        public Personne Propriétaire { get; set; }
    }
}
