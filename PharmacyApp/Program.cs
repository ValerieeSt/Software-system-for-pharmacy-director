using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PharmacyApp
{
    internal static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            Form1 form = new Form1();
            ProductManagerForm productManagerForm = new ProductManagerForm();
            ProviderManagerForm providerManagerForm = new ProviderManagerForm();

            productManagerForm.Show();
            providerManagerForm.Show();

            Application.Run(form);
        }
    }
}
