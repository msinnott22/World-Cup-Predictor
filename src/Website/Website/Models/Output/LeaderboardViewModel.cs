using System.Collections.Generic;

namespace Website.Models.Output
{
    public class LeaderboardViewModel
    {
        public List<Row> Rows { get; set; }
    }

    public class Row
    {
        public int Position { get; set; }
        public string Name { get; set; }
        public int Points { get; set; }
    }
}