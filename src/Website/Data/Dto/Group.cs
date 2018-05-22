using System;
using System.Collections.Generic;

namespace Data.Dto
{
    public class Group
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual HashSet<Team> Teams { get; set; }
    }
}
