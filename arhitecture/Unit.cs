using core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infrastructure
{
    class Unit: IUnit
    {
        private SomeContext context;
        private ElementRepository<Element> _elemRep;

        public SomeContext DbContext
        {
            get
            {
                if (context == null)
                {
                    context = new SomeContext();
                }
                return context;
            }
        }

        public ElementRepository<Element> ElemRep
        {
            get
            {

                if (this._elemRep == null)
                {
                    this._elemRep = new ElementRepository<Element>(DbContext);
                }
                return _elemRep;
            }
        }
        public void Save()
        {
            DbContext.SaveChanges();
        }
    }
}
