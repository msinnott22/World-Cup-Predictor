using System;
using System.Collections.Generic;
using Data.Interfaces;

namespace Data.Dto
{
    public class Group : IEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual HashSet<Team> Teams { get; set; }
    }
}
