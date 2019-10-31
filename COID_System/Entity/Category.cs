using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COID_System.Entity
{
    class Category
    {
        public Category()
        {
        }

        private int id;
        private string name;
        private string description;

        public Category(int id, string name, string description)
        {
            this.id = id;
            this.name = name;
            this.description = description;
        }

        public int Id
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
    }
}
