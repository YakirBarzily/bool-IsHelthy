using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bool_IsHelthy
{
    class Box
    {
        int fat;
         int cal;
        private string name;

        public Box(string name, int cal, int fat)
        {
            this.name = name;
            this.cal = cal;
            this.fat = fat;
        }

        public bool IsHelthy()
        {
            return this.cal < 130 && this.fat < 5;
        }
    }
}
