using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apli_backend.Services.Impl
{
    using Models;

    public interface VoitureService
    {

        public IEnumerable<Voiture> TrouverTous();
        public Voiture TrouverUn(int id);
        public Voiture Modifier(Voiture v);
        public Voiture Save(Voiture v);
        public void Supprimer(int id);

    }
}




    

