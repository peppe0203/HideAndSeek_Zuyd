using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace HideAndSeek
{
    class ThreadingClass
    {
        static int NumerOfThreads;
        private int WaitTime;

        public ThreadingClass(int numberOfThreads)
        {
            NumerOfThreads = 0;
        }

        public void SetWaitTime(int waitTime)
        {
            WaitTime = waitTime;
        }

        public void WaitThread(object data)
        {
            int numberOfSeconds = 0;
            while (numberOfSeconds < (int)data)
            {
                Thread.Sleep(1000);
                numberOfSeconds++;
            }
            MessageBox.Show("I ran for " + data + " seconds");
        }


        public void DomThread(object data)
        {
            if ((int) data == 0)
            {
                HttpWebRequest request =
                    WebRequest.Create("http://" + Play.IP + "/json.htm?type=command&param=switchscene&idx=7&switchcmd=On") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                response.Close();
            }
            if ((int)data == 1)
            {
                HttpWebRequest request =
                    WebRequest.Create("http://" + Play.IP + "/json.htm?type=command&param=switchscene&idx=6&switchcmd=On") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                response.Close();
            }
            if ((int)data == 2)
            {
                HttpWebRequest request =
                    WebRequest.Create("http://" + Play.IP + "/json.htm?type=command&param=switchscene&idx=8&switchcmd=On") as HttpWebRequest;
                HttpWebResponse response = request.GetResponse() as HttpWebResponse;
                response.Close();
            }
        }
    }
}
