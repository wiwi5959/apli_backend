using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace apli_backend.Services.Impl
{
    using Models;
    using Repositories;

    public class VoitureImplService : VoitureService
    {
        private static List<Voiture> voitures = new List<Voiture>();
        private PersonneService personneService;
        private VoitureRepository repository;


        public IEnumerable<Voiture> TrouverTous()
        {
            return voitures.Where(v => v != null);
        }

        public Voiture TrouverUn(int id)
        {
            return voitures[id];
        }

        public Voiture Save(Voiture v)
        {
            return this.repository.Save(voitures);
        }

        public Voiture Modifier(Voiture v)
        {
            return this.repository.Update(voitures);
        }


        public void Supprimer(int id)
        {

            return this.repository.Delete(id);
        }
    }
    
}
