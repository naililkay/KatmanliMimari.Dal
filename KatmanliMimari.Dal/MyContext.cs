using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatmanliMimari.Entity;
using Microsoft.EntityFrameworkCore;

namespace KatmanliMimari.Dal
{
    public class MyContext :DbContext
    {
        public MyContext(DbContextOptions<MyContext> db) : base(db)
        {

        }

        //DBSET
        DbSet<Personel> Personel { get; set; }  
    }
}
