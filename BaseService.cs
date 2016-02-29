using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceProcess;
using QuantumConcepts.Common.WindowsService.UI.Forms;
using System.Windows.Forms;
using QuantumConcepts.Common.Extensions;
using System.Configuration.Install;
using System.Reflection;

namespace QuantumConcepts.Common.WindowsService
{
    internal abstract class BaseService : BaseApp
    {
        protected const string Arg_RunOnce = "RunOnce";
        protected const string Arg_Install = "Install";
        protected const string Arg_Uninstall = "Uninstall";
        protected const string Arg_Start = "Start";
        protected const string Arg_Stop = "Stop";
        protected const string Arg_Restart = "Restart";
        protected const string Arg_Control = "Control";

        private static readonly TimeSpan DefaultTimeout = TimeSpan.FromSeconds(60);

        public static string ServiceName { get; protected set; }
        public static bool EnableConfiguration { get; protected set; }
        public static Func<bool> ServiceConfigurationFunction { get; protected set; }

        protected bool HandleServiceArguments(string[] args)
        {
            if (!args.IsNullOrEmpty())
            {
                string firstArg = args[0];

                if (string.Equals(firstArg, Arg_Install, StringComparison.InvariantCultureIgnoreCase))
                {
                    //Install the service and then exit.
                    Install();
                    return true;
                }
                else if (string.Equals(firstArg, Arg_Uninstall, StringComparison.InvariantCultureIgnoreCase))
                {
                    //Uninstall the service and then exit.
                    Uninstall();
                    return true;
                }
                else if (string.Equals(firstArg, Arg_Start, StringComparison.InvariantCultureIgnoreCase))
                {
                    //Start the service and then exit.
                    Start();
                    return true;
                }
                else if (string.Equals(firstArg, Arg_Stop, StringComparison.InvariantCultureIgnoreCase))
                {
                    //Stop the service and then exit.
                    Stop();
                    return true;
                }
                else if (string.Equals(firstArg, Arg_Restart, StringComparison.InvariantCultureIgnoreCase))
                {
                    //Restart the service and then exit.
                    Restart();
                    return true;
                }
                else if (string.Equals(firstArg, Arg_Control, StringComparison.InvariantCultureIgnoreCase))
                {
                    //Show the service control dialog.
                    ShowServiceControlDialog();
                    return true;
                }
            }

            //Return false if nothing was handled.
            return false;
        }

        /// <summary>Installs the service based on the entry assembly.</summary>
        public static void Install()
        {
            using (AssemblyInstaller installer = new AssemblyInstaller(Assembly.GetEntryAssembly(), null))
            {
                installer.Install(null);
            }
        }

        /// <summary>Uninstalls the service based on the entry assembly.</summary>
        public static void Uninstall()
        {
            using (AssemblyInstaller installer = new AssemblyInstaller(Assembly.GetEntryAssembly(), null))
            {
                installer.Uninstall(null);
            }
        }

        public static bool Start()
        {
            return Start(BaseService.DefaultTimeout);
        }

        public static bool Start(TimeSpan timeout)
        {
            return PerformServiceAction(c => c.Start(), ServiceControllerStatus.Running, timeout);
        }

        public static bool Stop()
        {
            return Stop(BaseService.DefaultTimeout);
        }

        public static bool Stop(TimeSpan timeout)
        {
            return PerformServiceAction(c => c.Stop(), ServiceControllerStatus.Stopped, timeout);
        }

        private static bool PerformServiceAction(Action<ServiceController> action, ServiceControllerStatus status, TimeSpan timeout)
        {
            using (ServiceController controller = new ServiceController(BaseService.ServiceName))
            {
                try
                {
                    action(controller);
                    controller.WaitForStatus(status, timeout);
                }
                catch
                {
                    return false;
                }

                return true;
            }
        }

        public static ServiceControllerStatus? GetStatus()
        {
            try
            {
                using (ServiceController controller = new ServiceController(BaseService.ServiceName))
                {
                    return controller.Status;
                }
            }
            catch
            {
                return null;
            }
        }

        public static bool Restart()
        {
            Stop(BaseService.DefaultTimeout);

            return Start(BaseService.DefaultTimeout);
        }

        public static bool Restart(TimeSpan timeout)
        {
            Stop(timeout);

            return Start(timeout);
        }

        public void RunServiceControlDialog()
        {
            using (ServiceControl dialog = new ServiceControl())
            {
                Application.Run(dialog);
            }
        }

        public void ShowServiceControlDialog()
        {
            using (ServiceControl dialog = new ServiceControl())
            {
                dialog.ShowDialog();
            }
        }
    }
}
