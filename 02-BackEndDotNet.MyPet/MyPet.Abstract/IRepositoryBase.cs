using System;
using System.Collections.Generic;
using System.Text;

namespace MyPet.Abstract
{
    public interface IRepositoryBase
    {
        IEnumerable<Entities.EntityIdBase> GetAll();
        Entities.EntityIdBase Get(Guid Id);
        void Insert(Entities.EntityIdBase entity);
        void Update(Entities.EntityIdBase entity);
        void Delete(Guid id);
    }
}
