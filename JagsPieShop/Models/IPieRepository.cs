using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JagsPieShop.Models
{
    public interface IPieRepository
    {
        public IEnumerable<Pie> AllPies { get; }
        public IEnumerable<Pie> PiesOfTheWeek { get; }
        public Pie GetPieById(int pieId);
    }
}
