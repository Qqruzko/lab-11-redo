using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Distance
    {
        public int feet { get; set; }
        public double inches { get; set; }
        public override string ToString()
        {
            return String.Format("{0} - {1}", feet, inches);
        }
        public static bool operator !=(Distance A1, Distance A2)
        {
            if (A1.feet == A2.feet)
                return true;
            return false;
        }
        public static bool operator ==(Distance A1, Distance A2)
        {
            if (A1.feet != A2.feet)
                return true;
            return false;
        }
        public override bool Equals(object o)
        {  
       return true;  
         }
        public override int GetHashCode()
        {
            return 0;
        }
    }
}
        
