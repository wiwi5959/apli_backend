using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace apli_backend.Repositories.Impl
{
    using Models;

    public class VoitureListRepository : VoitureRepository  // class contenant les méthodes qui ont le rôle de requêtes SQL déjà préparées
    {
        private List<Voiture> voitures = new List<Voiture>(); // ce code permet de lister les objets voitures 

        public void Delete(int id) // cette méthode permet de supprimer l'id d'une voiture
        {
            this.voitures[id] = null;
        }

        public void Delete(Voiture v) // cette méthode permet de supprimer une voiture précise
        {
            this.voitures[v.Id] = null;
        }

        public IEnumerable<Voiture> FindAll()  // cette méthode permet de lister toutes les voitures existantes
        {
            return this.voitures.Where(v => v != null);
        }

        public Voiture FindById(int id) // cette méthode permet de trouver les voitures par leur id qui est unique
        {
            return this.voitures[id];
        }

        public Voiture Save(Voiture v) // cette méthode permet d'enregistrer sur le serveur une nouvelle voiture
        {
            v.Id = this.voitures.Count();
            this.voitures.Add(v);
            return v;
        }

        public Voiture Update(Voiture v) // cette méthode permet de mettre à jour sur le serveur une voiture
        {
            this.voitures[v.Id] = v;
            return v;
        }
    }
}


