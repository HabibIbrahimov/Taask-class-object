using System;
using System.Collections.Generic;
using System.Text;

namespace Taask_class_object
{
    class Computer:Desktop_computer
    {
      

        public Computer()
        {
            
        }

        public Computer(string model, string storage, string operatingsystem, int ram):this()
        {
            this.model = model;
            this.storage = storage;
            this.operatingsystem = operatingsystem;
            this.ram = ram;
        }
        
    }
}
