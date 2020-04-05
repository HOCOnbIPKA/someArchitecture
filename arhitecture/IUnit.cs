using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using core;

namespace infrastructure
{
    interface IUnit
    {
        SomeContext DbContext { get; }
        ElementRepository<Element> ElemRep { get; }
        void Save();
    }
}
