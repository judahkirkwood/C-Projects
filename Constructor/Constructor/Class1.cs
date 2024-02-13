using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor
{
    class DefaultName
    {
        public string Name { get; set; }

        // Default constructor
        public DefaultName()
            : this("DefaultName") // Calls another constructor with a default value
        {
        }

        // Constructor with parameter
        public DefaultName(string name)
        {
            Name = name;
        }
    }
}

