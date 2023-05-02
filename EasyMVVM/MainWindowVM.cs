using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace EasyMVVM
{
    public class MainWindowVM : DependencyObject, INotifyPropertyChanged
    {
        private ObservableCollection<string>? _boundProperty;

        public ObservableCollection<string> BoundProperty
        {
            get { return _boundProperty; }
            set { _boundProperty = value; PropChanged("BoundProperty"); }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void PropChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public MainWindowVM()
        {
            Model m = new Model();
            BoundProperty = m.getData();
        }
    }
    }
