using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Win.Commands;

namespace Win.Presenters
{
    public class ExamplePresenter
    {
        private IExampleView exampleView;
        private ICommand command;

        public ExamplePresenter(IExampleView exampleView, ICommand command)
        {
            this.exampleView = exampleView;
            this.command = command;

            exampleView.SetViewTitle( "An Example Form");
    
            exampleView.SubmitButton().Click += new EventHandler(SubmitButton_OnClick);
        }

        public void SubmitButton_OnClick(object sender, EventArgs e)
        {
            command.Execute();
        }
    }

}

