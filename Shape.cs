using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
   

    public class Shape
    {
        // Virtual method to calculate the area (returns 0 by default)
        public virtual float CalculateArea()
        {
            return 0;
        }
    }

    
}
