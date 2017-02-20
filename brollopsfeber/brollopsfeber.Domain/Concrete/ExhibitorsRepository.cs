using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using brollopsfeber.Domain.Abstract;
using brollopsfeber.Domain.Entites;

namespace brollopsfeber.Domain.Concrete
{
    public class ExhibitorsRepository : IExhibitorRepository
    {
        private List<Exhibitor> _Exhibitors;

        public ExhibitorsRepository()
        {
            _Exhibitors = new List<Exhibitor>();

            _Exhibitors.Add(new Exhibitor() { Name = "Jonas Strandberg" });
            _Exhibitors.Add(new Exhibitor() { Name = "Niklas Bergluva" });
        }

        public IEnumerable<Exhibitor> Exhibitors
        {
            get
            {
                return _Exhibitors;
            }
        }
    }
}
