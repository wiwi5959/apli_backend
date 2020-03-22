using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apli_backend.DTO
{
    public class PersonneDTO
    {
        public int Id { get; set; }
        public string Nom { get; set; }
        public string Prénom { get; set; }
        public int Age { get; set; }
        public int PropriétaireId { get; set; }
        public PersonneDTO Propriétaire { get; set; }
    }
}


