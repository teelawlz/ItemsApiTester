using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ItemsApiTester
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
            RequestController control = new RequestController();
            ApiTesterForm ApiTesterForm = new ApiTesterForm();
            ApiTesterForm.controller = control;
            Application.Run(ApiTesterForm);            
        }
    }
}
