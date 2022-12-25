using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatmanliMimari.Dal;
using KatmanliMimari.Repos.Abstract;

namespace KatmanliMimari.Uow
{
    public class UnitOfWork : IUnitOfWork
    {
        MyContext _db;
        public IPersonelRep _PersonelRep { get; set; }

      

        public void Commit()
        {
            _db.SaveChanges();
        }

        public UnitOfWork(MyContext db,IPersonelRep PersonelRep)
        {
            _db=db;
            _PersonelRep = PersonelRep;
        }
    }
}
