using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Commands
{
    public class SimpleMessageBoxCommand : ICommand
    {
        private IExampleView exampleView;

        public SimpleMessageBoxCommand(IExampleView exampleView)
        {
            this.exampleView = exampleView;
        }

        public void Execute()
        {
            var textString = exampleView.ViewTextBox().Text;
            MessageBox.Show(textString);
            exampleView.ViewTextBox().Focus();
        }
    }
}
