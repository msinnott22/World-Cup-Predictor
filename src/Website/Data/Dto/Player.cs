using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Data.Interfaces;

namespace Data.Dto
{
    public class Player : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string UserId { get; set; }
        public Guid GameId { get; set; }
        public virtual Game Game { get; set; }
        public virtual HashSet<Prediction> Predictions { get; set; }
    }
}
