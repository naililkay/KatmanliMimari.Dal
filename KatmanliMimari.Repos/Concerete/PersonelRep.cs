using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatmanliMimari.Core;
using KatmanliMimari.Entity;
using KatmanliMimari.Repos.Abstract;
using KatmanliMimari.Dal;
using KatmanliMimari.Core;

namespace KatmanliMimari.Repos.Concerete
{
    public class PersonelRep<T> : BaseRepository<Personel>, IPersonelRep 
    {
        public PersonelRep(MyContext db):base(db)
        {

        }
    }


   
    
}
