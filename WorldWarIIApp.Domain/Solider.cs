using System.Collections.Generic;

namespace WorldWarIIApp.Domain
{
    public class Solider
    {
        public Solider()
        {
            Quotes = new List<Quote>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Quote> Quotes { get; set; }
        public int BattleId { get; set; }
    }
}