using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using  System.Globalization;
using  System.Threading;

namespace System.Globalization_Example
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Calendar
            DateTime dt1 = DateTime.Now;
            ;

            Calendar cal;
            DateTime dt = new DateTime(2021, 1, 21, new GregorianCalendar());
            dt.AddHours(3);

            DateTime dt2 = DateTime.Now;

            TimeSpan t = dt2.Subtract(dt1);
            #endregion

            #region CultureInfo

            CultureInfo ci = new CultureInfo("pt-BR");

            //ci.DateTimeFormat.DayNames.ToString();

            #endregion

            #region CultureInfo - Threading

            CultureInfo cit = System.Threading.Thread.CurrentThread.CurrentCulture;

            CultureInfo ciUI = Thread.CurrentThread.CurrentUICulture;


            //Thread.CurrentThread.CurrentUICulture = ci; //Ingles
            Thread.CurrentThread.CurrentCulture = ci; //Portugues

            Thread.CurrentThread.CurrentUICulture = ci;

            CultureInfo cinv = CultureInfo.InvariantCulture;

            Console.WriteLine(System.Globalization_Example.Main.DESCRICAO);
            
            Console.ReadKey();

            #endregion


        }
    }
}
