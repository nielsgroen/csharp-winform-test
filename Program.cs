using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing;

namespace csharp_winform_test
{
    class Program
    {
        public static void Main()
        {
            TestForm test = new TestForm();
            test.Text = "Test Form";

            TextBox testbox = new TextBox();
            testbox.Location = new Point(25, 25);
            testbox.Text = "Hanjk";

            test.Controls.Add(testbox);




            Application.Run(test);
        }
    }
}
