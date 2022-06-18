using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


    public class Items
    {
        public Items(){}
        public Items(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
        public int ID { get; set; }
    }
