using Core.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Product : Entity
    {
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductDetail { get; set; }
        public int StockQuantity { get; set; }
        public decimal UnitPrice { get; set; }
        public string ImageUrl { get; set; }
        public bool Status { get; set; }

        public virtual Category? Category { get; set; }
        public virtual Brand? Brand { get; set; }

        public Product()
        {

        }

        public Product(int id, int brandId, int categoryId, string productName, string productDetail, int stockQuantity, decimal unitPrice, string imageUrl, bool status) : this()
        {
            Id = id;
            BrandId = brandId;
            CategoryId = categoryId;
            ProductName = productName;
            ProductDetail = productDetail;
            StockQuantity = stockQuantity;
            UnitPrice = unitPrice;
            ImageUrl = imageUrl;
            Status = status;
        }
    }
}
