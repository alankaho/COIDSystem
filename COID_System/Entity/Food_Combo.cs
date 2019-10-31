using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COID_System.Entity
{
    class Food_Combo
    {
        private string idFood;
        private string idCombo;
        private int id;

        public string IdCombo
        {
            get => idCombo;
            set => idCombo = value;
        }

        public int Id
        {
            get => id;
            set => id = value;
        }

        public string IdFood
        {
            get => idFood;
            set => idFood = value;
        }
    }
}
