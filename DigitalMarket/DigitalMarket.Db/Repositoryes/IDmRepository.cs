using DigitalMarket.Db.Entityes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DigitalMarket.Db.Repositoryes
{
    public interface IDmRepository<Entity> where Entity : EntityBase
    {
        void Insert(Entity entity);
        void Update(Entity entity);
        void Delete(Entity entity);
    }
}
