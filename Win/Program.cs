using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win.Commands;
using Win.Presenters;

namespace Win
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
            var formObject = new ExampleView();
            var commandObject = new SimpleMessageBoxCommand(formObject);
            var presenterObject = new ExamplePresenter(formObject, commandObject);
            Application.Run(formObject);
        }
    }
}
