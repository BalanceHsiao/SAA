using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace NewMonitorCPU
{
    

    class ThreadWorker
    {
        public string _sGetText;
        public string SGetText
        {
            get
            {
                return _sGetText;
            }
            set
            {
                _sGetText = value;
                
            }
        }
        Thread _thread;
        ManualResetEvent _shutdownEvent;
        ManualResetEvent _pauseEvent;

        public void ThreadJob()
        {
            while (true)
            {
                // pause event : if WaitHandle is false, it will wait and return false
                _pauseEvent.WaitOne(Timeout.Infinite);
                // stop event
                if (_shutdownEvent.WaitOne(0)) break;

                // work here
                Console.WriteLine(DateTime.Now);

                // like Thread.Sleep(1000), but higher efficiency
                SpinWait.SpinUntil(() => false, 1000);
            }

            SGetText = "ABCDE";
        }

        public void Start()
        {
            Console.WriteLine("Add a new thread");
            _thread = new Thread(ThreadJob);
            _shutdownEvent = new ManualResetEvent(false);
            _pauseEvent = new ManualResetEvent(true);

            _thread.IsBackground = true;
            _thread.Start();
        }

        public void Pause()
        {
            // Set WaitHandle false
            _pauseEvent.Reset();
        }

        public void Resume()
        {
            // Set WaitHandle true
            _pauseEvent.Set();
        }

        public void Stop()
        {
            // trigger stop
            _shutdownEvent.Set();
            // if thread suspend, let it resume.
            _pauseEvent.Set();
            _thread.Join();
            _thread = null;
        }
    }
}
