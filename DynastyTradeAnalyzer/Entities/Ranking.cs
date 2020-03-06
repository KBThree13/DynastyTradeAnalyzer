using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynastyTradeAnalyzer.Entities
{
    public class Ranking
    {
        public Player PlayerID { get; set; }
        public int Rank { get; set; }
        public int PositionRank { get; set; }
        public string Source { get; set; }

    }
}
