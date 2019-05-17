using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class BaseEntity
    {
        public Guid ID { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
