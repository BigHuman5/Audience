using Audience.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Audience.DAL.Interfaces
{
    public interface IUnitOfWork
    {
        IRepository<Audiences> Audiences { get; }
        IRepository<Class> Class { get; }
        IRepository<Lecturer> Lecturer { get; }
        void Save();
    }
}
