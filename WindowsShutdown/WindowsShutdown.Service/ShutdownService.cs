using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace WindowsShutdown.Service
{
    public partial class ShutdownService : ServiceBase
    {
        Timer shutDownTimer;

        public ShutdownService()
        {
            InitializeComponent();
            this.AutoLog = false;
        }

        protected override void OnStart(string[] args)
        {
            shutDownTimer = new Timer();
            shutDownTimer.Interval = 600000;
            shutDownTimer.Elapsed += (eventSender, eventArgs) =>
            {
                //notifyWindowsShutDown.ShowBalloonTip
            };
            shutDownTimer.Start();
            windowsShutdownEventLog.WriteEntry("Windows Shutdown Service OnStart");
        }

        protected override void OnStop()
        {
            windowsShutdownEventLog.WriteEntry("Windows Shutdown Service OnStop");
        }
    }
}
