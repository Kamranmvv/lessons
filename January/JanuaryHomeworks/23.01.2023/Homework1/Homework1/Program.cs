using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Homework 1:
             5 dənə dəyişəni Implicit Conversion,
             5 dənə dəyişəni Explicit Conversion,
             5 dənə dəyişəni Helper Class Conversion vasitəsilə convert edin. Dəyişən tiplərini və dəyərlərini özünüz seçin.
            */

            #region Implicit

            {
                int i = 2000;
                float f = i;

                long l = 50000000;
                float f1 = l;

                float f2 = 21.8f;
                double d2 = f2;

                byte b = 21;
                short s = b;

                short s2 = 14241;
                decimal de = s2;
   }
            #endregion


            #region Explicit
            {
                int i = 5000;
                short s = (short)i;

                double d = 5124.5d;
                float f = (float)d;

                short s1 = 2133;
                byte b = (byte)s1;

                long l = 42141;
                int i1 = (int)l;
            }
            #endregion

            #region helper class
            {
                int i;
                 i = Convert.ToInt32("20");
                i = Convert.ToInt32(true);


                bool b;
                b = Convert.ToBoolean("true");
                b= Convert.ToBoolean(false);
                b = Convert.ToBoolean(null);

                string s ="121";
                int i1 = Convert.ToInt32(s);

                bool t = true;
                string true1 = t.ToString();
                


            }
            #endregion
        }
    }
}
