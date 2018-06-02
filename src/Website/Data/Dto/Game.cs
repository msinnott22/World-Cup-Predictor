using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Data.Interfaces;

namespace Data.Dto
{
    public class Game : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string AdminUserId { get; set; }
        [MaxLength(20)]
        public string Name { get; set; }
        public virtual HashSet<Prediction> Predictions { get; set; }
        public int TotalPoints { get; set; }
        public DateTime Created { get; set; }
        [MaxLength(8)]
        public string JoinCode { get; set; }
        public virtual List<Player> Players { get; set; }
    }
}
