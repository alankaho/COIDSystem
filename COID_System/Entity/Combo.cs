using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COID_System.Entity
{
    class Combo
    {
        private string id;
        private string name;
        private string description;
        private double price;
        private double discount_price;

        public Combo(string id, string name, string description, double price, double discountPrice)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            discount_price = discountPrice;
        }

        public string Id
        {
            get => id;
            set => id = value;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }

        public string Description
        {
            get => description;
            set => description = value;
        }

        public double Price
        {
            get => price;
            set => price = value;
        }

        public double DiscountPrice
        {
            get => discount_price;
            set => discount_price = value;
        }
    }
}
