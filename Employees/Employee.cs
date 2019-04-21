using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    [Serializable]
    public class Employee
    {
        int age;
        string name;
        string country;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0) age = -value;
                age = value;
            }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public Employee()
        {

        }
    }
}
