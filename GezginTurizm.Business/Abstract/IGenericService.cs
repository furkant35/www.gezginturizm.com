using GezginTurizm.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GezginTurizm.Business.Abstract
{
    public interface IGenericService<Entity> where Entity : class, IEntity, new()
    {
        void Add(Entity entity);
        void Delete(Entity entity);
        void Update(Entity entity);
        Entity GetById(int id);
        List<Entity> GetAll();
    }
}
