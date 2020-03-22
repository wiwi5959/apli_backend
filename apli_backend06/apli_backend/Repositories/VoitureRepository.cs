using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apli_backend.Repositories.Impl
{
    using Models;

    public interface VoitureRepository // il s'agit de l'interface contenant les méthodes qui ont le rôle de requêtes SQL déjà préparées
    {
        public Voiture Save(Voiture v); // sauvegarder 
        public IEnumerable<Voiture> FindAll(); // Lister les voitures
        public Voiture FindById(int id); // Chercher
        public Voiture Update(Voiture v); // Mettre à jour
        public void Delete(int id); // supprimer
        public void Delete(Voiture v);
    }
}

