using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DynastyTradeAnalyzer.Entities
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public float Age { get; set; }
        public string Team { get; set; }
        public string Position { get; set; }
        public List<Ranking> Rankings { get; set; }
        public int TradeValue  { get; set; }

    }
}
