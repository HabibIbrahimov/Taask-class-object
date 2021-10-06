using System;
using System.Collections.Generic;
using System.Text;

namespace Taask_class_object
{
    class Desktop_computer
    {
        public string model;
        public string storage;
        public string operatingsystem;
        public int ram;
        public string Detail()
        {
            return $"{model}  {storage} {operatingsystem}  {ram}";
        }
    }
}
