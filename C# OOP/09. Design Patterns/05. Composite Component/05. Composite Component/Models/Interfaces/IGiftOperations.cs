using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05._Composite_Component.Models.Interfaces
{
    public interface IGiftOperations
    {
        void Add(GiftBase gift);

        void Remove(GiftBase gift);
    }
}