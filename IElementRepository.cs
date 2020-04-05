using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace core
{
    public interface IElementRepository<TEntity> where TEntity : class
    {
        TEntity GetElement(object id);
        void CreateElement(TEntity entity);
        void DeleteElement(object id);
    }
}
