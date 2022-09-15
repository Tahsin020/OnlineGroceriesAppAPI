using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Brand : Entity
    {
        public string BrandName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }


        public Brand()
        {

        }

        public Brand(int id, string brandName, string description, string imageUrl, bool status):this()
        {
            Id = id;
            BrandName = brandName;
            Description = description;
            ImageUrl = imageUrl;
            Status = status;
        }
    }
}
