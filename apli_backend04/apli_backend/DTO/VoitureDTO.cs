using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apli_backend.DTO
{
    public class VoitureDTO
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Marque { get; set; }
        public int Immatriculation { get; set; }
        public PersonneDTO Propriétaire { get; set; }
    }
}

