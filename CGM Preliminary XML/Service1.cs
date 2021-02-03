using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace CGM_Preliminary_XML
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        public static void WriteToLogFile(string message)
        {

        }

        protected override void OnStart(string[] args)
        {
            WriteToLogFile("Service is running");
        }

        protected override void OnStop()
        {
        }
    }
}
