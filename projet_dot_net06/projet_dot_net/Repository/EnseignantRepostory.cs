
using projet_dot_net.Domaine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace projet_dot_net.Repository
{
    using App.Domaine;
    
    public class Enseignant : CrudRepository <Enseignant>
    {
        private System.App.Domaine.appContext context;

        public Enseignant(System.App.Domaine.appContext context)
        {
            this.context = context;
        }

        public IQueryable<Enseignant> Filter(Enseignant model)
        {
            throw new NotImplementedException();
        }

        public IQueryable<Enseignant> FindAll()
        {
          
            return this.context.Enseignant;
        }

        public Enseignant FindByID(int id)
        {
           
            return this.context.Enseignant
                .Where(enseignant => enseignant.Id == id)
                .First();
        }

        public void Remove(int id)
        {
           
            this.context.Remove(this.FindByID(id));
            this.context.SaveChanges();
        }

        public Enseignant Save(Enseignant model)
        {
           
            this.context.Add(model);
            this.context.SaveChanges();

            return model;
        }

        public Enseignant Update(Enseignant model)
        {
           
            this.context.Update(model);
            this.context.SaveChanges();

            return model;
        }
    }
}

