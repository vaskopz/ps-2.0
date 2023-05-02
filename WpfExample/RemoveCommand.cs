using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WpfExample
{
    public class RemoveCommand : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add
            {
                CommandManager.RequerySuggested += value;
            }
            remove
            {
                CommandManager.RequerySuggested -= value;
            }
        }

        public bool CanExecute(object? parameter)
        {
            var namesList = parameter as NamesList;
            return namesList != null && namesList.SelectedName != null;
        }

        public void Execute(object? parameter)
        {
            var namesList = parameter as NamesList;
            var oldName = namesList.SelectedName;
            namesList.Names.Remove(oldName);
        }
    }
}
