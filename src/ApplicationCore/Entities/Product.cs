using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public byte[] Image { get; set; }
        public string ImagesUrl { get; set; }

        // more fields related to prodct size, dimension, etc.


        // relatives
        public Guid CategoryID { get; set; }
        public virtual Category Category { get; set; }

    }
}
