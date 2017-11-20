using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Win
{
    public partial class ExampleView : Form, IExampleView
    {
        public ExampleView()
        {
            InitializeComponent();
        }

        public Button SubmitButton()
        {
            return this.btnSubmit;
        }

        public TextBox ViewTextBox()
        {
            return this.txtFreetext;
        }

        public void SetViewTitle(string titleText)
        {
            this.Text = titleText;
        }
    }

    public interface IExampleView
    {
        Button SubmitButton();
        TextBox ViewTextBox();
        void SetViewTitle(string titleText);
    }
}
