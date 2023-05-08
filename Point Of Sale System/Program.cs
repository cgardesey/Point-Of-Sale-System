using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Point_Of_Sale_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new SplashScreen());
            //Application.Run(new SalesReturnReport());
            //Application.Run(new YearlySalesReport());
            //Application.Run(new MonthlySalesReport());
            //Application.Run(new AddDebtor());
            //Application.Run(new DebtorsReport());
            //Application.Run(new CreditorsReport());
            //Application.Run(new EditCreditor());
            //Application.Run(new Expired());
        }
    }
}
