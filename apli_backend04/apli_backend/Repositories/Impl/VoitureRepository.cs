﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apli_backend.Repositories.Impl
{
    using Models;

    public interface VoitureRepository
    {
        public Voiture Save(Voiture v);
        public IEnumerable<Voiture> FindAll();
        public Voiture FindById(int id);
        public Voiture Update(Voiture v);
        public void Delete(int id);
        public void Delete(Voiture v);
    }
}

