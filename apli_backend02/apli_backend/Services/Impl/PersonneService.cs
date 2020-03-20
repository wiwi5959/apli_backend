using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apli_backend.Services.Impl
{
    using Models;

    interface PersonneService
    {
        public IEnumerable<Personne> TrouverTous();
        public Personne TrouverUn(int id);
        public Personne Modifier(Personne p);
        public Personne Save(Personne p);
        public void Supprimer(int id);



    }
}
