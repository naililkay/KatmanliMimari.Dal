using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KatmanliMimari.Repos.Abstract;

namespace KatmanliMimari.Uow
{
    public interface IUnitOfWork
    {
        IPersonelRep _PersonelRep { get; }

        void Commit();
    }
}
