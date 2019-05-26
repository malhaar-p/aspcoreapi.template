using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Category : BaseEntity
    {
        public string Name { get; set; }


        // relatives
        public virtual ICollection<Product> Products { get; set; }
    }
}
