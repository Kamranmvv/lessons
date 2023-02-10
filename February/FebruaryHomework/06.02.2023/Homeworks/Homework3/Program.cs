using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  Local function'lar yaradaraq bir kalkulyator yaradın.
                Ümumi bir calculate methodu olmalıdır və o method'un içində də Toplama, Çıxma, Vurma və Bölmə local function'ları olacaq.
                Ümumi Calculate method'unun overload'ları olmalıdır və iki decimal, iki int, iki string, string-decimal, decimal-int və 
                int-string parametrləri ilə işləməlidir.
                Nümunə: İki int, iki decimal dedikdə onu nəzərdə tuturam ki, Calculate(15, 15), Calculate(15.2M, 20.5M) qaydada istifadə ediləcək.
                Ancaq string-decimal dedikdə yəni parametrin biri string digəri decimal olacaq ("15", 20.2M) yada int-string üçün (20, "15") belə.
                Bölmə zamanı divide zero exeption'dan qaçının.
                Birdə Calculator'un 2 variant faiz hesablama funksiyası da olacaq. Birinci variant A parametrinin B parametr faizi neçədir?
                Yəni 100-ün 5 faizi neçədir? hesablayacaq. İkinci variant isə A parametri B parametrinin neçə faizidir? Yəni 10 (a parametri),
                100-ün (b parametrinin) neçə faizidir?*/


            Calculate calculate = new Calculate();
            
        }
    }
}
