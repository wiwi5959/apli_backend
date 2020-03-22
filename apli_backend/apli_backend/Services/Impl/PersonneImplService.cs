using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apli_backend.Services.Impl
{
    using Models;
    using Repositories;

    public class PersonneImplService : PersonneService
    {
        private static List<Personne> voitures = new List<Personne>();
        private VoitureService voitureService;
        private PersonneRepository repository;
      

        public IEnumerable<Personne> TrouverTous()
        {
            return personnes.Where(p => p != null);
        }

        public Personne TrouverUn(int id)
        {
            return personnes.[id];
        }

        public Personne Save(Personne p)
        {
            return this.repository.Save(p);
        }

        public Personne Modifier(Personne p)
        {
            return this.repository.Update(p);
        }


        public void Supprimer(int id)
        {

            return this.repository.Delete(id);
        }
    }

}

