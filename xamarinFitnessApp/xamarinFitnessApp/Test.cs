using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace xamarinFitnessApp
{
    class Test
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }


        public override string ToString()
        {
            return this.Name + "(" + this.Address + ")";
        }
    }
}
