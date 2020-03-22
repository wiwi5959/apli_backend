using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace apli_backend.Services.Impl
{
    using Models;
    using Repositories.Impl;

    public class VoitureImplService : VoitureService   //voitureimplservice hérite de VoitureService , les "repositories" sont injectés dans les services par l'injection de dépendances
    {
        private static List<Voiture> voitures = new List<Voiture>(); // champs contenant la liste d'objets Voitures
        public VoitureRepository repository; // champs contenant les voitures des repositories
        // private PersonneService personneService; // champs contenant les personne

        public IEnumerable<Voiture> TrouverTous() // cette méthode est l'équivalente de FindAll des repositories , idem pour les autres méthodes
        {
            return voitures.Where(v => v != null);
        }

        public Voiture TrouverUn(int id)
        {
            return voitures[id];
        }

        public Voiture Save(Voiture v)
        {
            return this.repository.Save(v);
        }

        public Voiture Modifier(Voiture v)
        {
            return this.repository.Update(v);
        }

        public void Supprimer(int id)
        {

            this.repository.Delete(id);
        }
    }
    
}
