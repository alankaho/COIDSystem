using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COID_System.Entity
{
    class Food
    {
        private string id;
        private string name;
        private string description;
        private double price;
        private int categoryId;

        public Food()
        {
        }

        public Food(string id, string name, string description, double price, int categoryId)
        {
            this.id = id;
            this.name = name;
            this.description = description;
            this.price = price;
            this.categoryId = categoryId;
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

        public int CategoryId
        {
            get => categoryId;
            set => categoryId = value;
        }
    }
}
