using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;



namespace sampleService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            ConsoleApp1.Program p = new ConsoleApp1.Program();
            

            //Console.WriteLine("Hello You started a service");
            //Console.ReadLine();
            
        }

        protected override void OnStop()
        {
            //Console.ReadLine();
        }
    }
}
