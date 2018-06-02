using System;
using System.ComponentModel.DataAnnotations;
using Data.Interfaces;

namespace Data.Dto
{
    public class Player : IEntity
    {
        [Key]
        public Guid Id { get; set; }
        public string UserId { get; set; }
    }
}
