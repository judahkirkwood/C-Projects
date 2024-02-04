using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            // Check if both objects are null or if their IDs are equal
            return ReferenceEquals(employee1, null) && ReferenceEquals(employee2, null) ||
                   !ReferenceEquals(employee1, null) && !ReferenceEquals(employee2, null) &&
                   employee1.ID == employee2.ID;
        }
        // Overload the "!=" and "==" operators
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }
    }
}
