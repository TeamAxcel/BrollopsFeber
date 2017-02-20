using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using brollopsfeber.Domain.Entites;

namespace brollopsfeber.Domain.Abstract
{
    public interface IExhibitorRepository
    {
        IEnumerable<Exhibitor> Exhibitors { get; }
    }
}
