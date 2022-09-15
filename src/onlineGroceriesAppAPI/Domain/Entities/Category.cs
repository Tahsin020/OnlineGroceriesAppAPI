using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Category : Entity
    {
        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }

        public virtual ICollection<Product> Products { get; set; }

        public Category()
        {

        }

        public Category(int id, string categoryName, string description, string imageUrl, bool status) : this()
        {
            Id = id;
            CategoryName = categoryName;
            Description = description;
            ImageUrl = imageUrl;
            Status = status;
        }
    }
}
