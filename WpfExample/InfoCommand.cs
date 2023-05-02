using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace WpfExample
{
    public class InfoCommand: ICommand
    {
        public void Execute(object parameter)
        {
            MessageBox.Show("Hello, world!");
        }
        public bool CanExecute(object parameter)
        {
            return true;
        }
        public event EventHandler CanExecuteChanged;
        private InfoCommand _infoCommand = new InfoCommand();
        public InfoCommand InformationCommand
        {
            get { return _infoCommand; }
        }
    }
}
