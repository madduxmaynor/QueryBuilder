using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QueryBuilderStarter;

namespace QueryBuilder
{
    public class BannedGames : IClassModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Series { get; set; }
        public string Country { get; set; }
        public string Reason { get; set; }
        public string extra { get; set; }
    }
}
