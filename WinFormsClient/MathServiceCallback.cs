using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsClient
{
    class MathServiceCallback : MathServiceReference.IMathServiceCallback
    {
        public void NotifyClientWhenPrintingIsDone(string message)
        {
            System.Windows.Forms.MessageBox.Show(message);
        }
    }
}
