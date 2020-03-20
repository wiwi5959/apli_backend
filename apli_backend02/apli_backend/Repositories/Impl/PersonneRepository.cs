using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace apli_backend.Repositories.Impl
{
    using Models;

    public interface PersonneRepository
    {
    public Personne Save(Personne p);
    public IEnumerable<Personne> FindAll();
    public Personne FindById(int id);
    public Personne Update(Personne p);
    public void Delete(int id);
    public void Delete(Personne p);
    }
}
