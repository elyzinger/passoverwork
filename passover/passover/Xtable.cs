using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passover
{
    class Xtable
    {
        public int ID { get; set; }
        public int xValue { get; set; }
        public static bool operator ==(Xtable c1, Xtable c2)
        {
            if (ReferenceEquals(c1, null) && ReferenceEquals(c2, null))
                return true;
            if (ReferenceEquals(c1, null) || ReferenceEquals(c2, null))
                return false;

            return (c1.ID == c2.ID);
        }
        public static bool operator !=(Xtable c1, Xtable c2)
        {
            return !(c1 == c2);
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(obj, null))
                return false;

            if (obj == null)
                return false;
            Xtable c = obj as Xtable;
            if (c == null)
                return false;

            return this.ID == c.ID;
        }

        public override int GetHashCode()
        {
            return this.ID;
        }
        public override string ToString()
        {
            return $"id {ID} xValue{xValue}";
        }
    }
}
