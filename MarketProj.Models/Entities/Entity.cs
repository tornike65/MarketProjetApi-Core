using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MarketProj.Models.Entities
{
    public class Entity
    {
        [Key]
        public Guid Id { get; set; }
        public Entity()
        {
            if (Id == default)
            {
                Id = Guid.NewGuid();
            }
        }
    }
}
