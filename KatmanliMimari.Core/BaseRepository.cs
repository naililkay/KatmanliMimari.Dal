using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatmanliMimari.Dal;
using Microsoft.EntityFrameworkCore;

namespace KatmanliMimari.Core
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        MyContext _db;
        public BaseRepository(MyContext db)
        {
            _db = db;
        }
        public bool Add(T entity)
        {

            try
            {
                Set().Add(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(int Id)
        {
            try
            {
                //var ent = Find(Id);
                //Set().Remove(ent);
                Set().Remove(Find(Id));
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool Delete(string Id)
        {
            try
            {
                //var ent = Find(Id);
                //Set().Remove(ent);
                Set().Remove(Find(Id));
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }


        public bool Delete(T entity)
        {
            try
            {
                
                Set().Remove(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public T Find(int Id)
        {

            return Set().Find(Id);
        }
        public T Find(string Id)
        {
            return Set().Find(Id);
        }
        public List<T> List()
        {
            return Set().ToList();
        }

        public DbSet<T> Set()
        {
            return _db.Set<T>();
        }

        public bool Update(T entity)
        {
            try
            {
                Set().Update(entity);
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }



    }

}

   

