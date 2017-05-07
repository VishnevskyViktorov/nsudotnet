using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using VishnevskyViktorov.Nsudotnet.TicTacToe.ViewModels;

namespace VishnevskyViktorov.Nsudotnet.TicTacToe {
    public class ShellBootstrapper : BootstrapperBase {
        public ShellBootstrapper()
            : base(true) {
            Initialize();
        }

        protected override void OnStartup(object sender, StartupEventArgs e) {
            DisplayRootViewFor<MainViewModel>();
        }
    }
}
