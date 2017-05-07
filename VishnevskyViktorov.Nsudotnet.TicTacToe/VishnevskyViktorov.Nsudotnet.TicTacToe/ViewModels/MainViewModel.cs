using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Caliburn.Micro;
using System.Windows;

namespace VishnevskyViktorov.Nsudotnet.TicTacToe.ViewModels {
    public class MainViewModel : PropertyChangedBase {
        public MainViewModel() {
            HelloWorld = "Hello World";
        }

        private string _helloworld;

        public string HelloWorld {
            get {
                return _helloworld;
            }
            set {
                _helloworld = value;
                NotifyOfPropertyChange(() => HelloWorld);
            }
        }

        //Don't use this code in production
        public void ShowMessage() {
            HelloWorld = "AA";
            MessageBox.Show("Test Caliburn.Micro");
        }
    }
}
