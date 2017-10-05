using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_day4Class
{
    class Cat
    {
        //STATES
        //feilds
        private string name;

        //properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }

        }

        //BEHAVIORS

        //constructors
        public Cat()
        {
            //defualt contructor because it takes no
            //parameters in the parentheses
        }
    }
}
