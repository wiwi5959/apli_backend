﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apli_backend.Repositories.Impl
{
    using Models;

    public class PersonneListRepository : PersonneRepository
    {

        private List<Personne> personnes = new List<Personne>();

        public void Delete(int id)
        {
            this.personnes[id] = null;
        }

        public void Delete(Personne p)
        {
            this.personnes[p.Id] = null;
        }

        public IEnumerable<Personne> FindAll()
        {
            return this.personnes.Where(p => p != null);
        }

        public Personne FindById(int id)
        {
            return this.personnes[id];
        }

        public Personne Save(Personne p)
        {
            p.Id = this.personnes.Count();
            this.personnes.Add(p);
            return p;
        }

        public Personne Update(Personne p)
        {
            this.personnes[p.Id] = p;
            return p;
        }
    }
}



