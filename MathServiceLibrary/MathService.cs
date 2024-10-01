using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.IO;
namespace MathServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class MathService : IMathService
    {
        public int Add(MyNumbers obj)
        {
            return (obj.Number1 + obj.Number2);
        }

        public int Sutract(MyNumbers obj)
        {
            return (obj.Number1 - obj.Number2);
        }

        public void SignIn(string UserName)
        {
            System.Threading.Thread.Sleep(5000);//Wait for 5 seconds
            var str = new StringWriter();
            str.WriteLine("{0} has loaded the form at {1:t}",
                UserName, DateTime.Now.ToString("hh:mm:ss"));

            File.AppendAllText(@"C:\Users\Libhongo\Desktop\UserLog.txt", str.ToString());
        }

        public void SignOut(string UserName)
        {
            System.Threading.Thread.Sleep(5000);//Wait for 5 seconds
            var str = new StringWriter();
            str.WriteLine("{0} has closed the form at {1:t}",
                UserName, DateTime.Now.ToString("hh:mm:ss"));

            File.AppendAllText(@"C:\Users\Libhongo\Desktop\UserLog.txt", str.ToString());
        }

        //Gets called by the WinFormsClient
        public void StartPrintingLogFile(string message)
        {
            IMathServiceCallback Mscallback =
                OperationContext.Current.GetCallbackChannel<
                    IMathServiceCallback>();

            //After the printing is done the client will be notified after 5 seconds
            System.Threading.Thread.Sleep(new TimeSpan(0, 0, 5));
            Mscallback.NotifyClientWhenPrintingIsDone(message);
        }

        public void StartPrintingLogFiles(string message)
        {
            IMathServiceCallback Mscallback =
               OperationContext.Current.GetCallbackChannel<
                   IMathServiceCallback>();

            //After the printing is done the client will be notified after 5 seconds
            System.Threading.Thread.Sleep(new TimeSpan(0, 0, 5));
            Mscallback.NotifyClientWhenPrintingIsDone(message);
        }
    }
}
