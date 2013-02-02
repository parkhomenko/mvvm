using mvvm.Utils;
using mvvm.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace mvvm.ViewModels
{
    class MainViewModel : PropertyNotifier
    {
        private UserControl currentUserControl;

        private static StudentsInformationView studentsInformation = new StudentsInformationView();

        public UserControl CurrentUserControl
        {
            get { return currentUserControl; }
            set
            {
                if (currentUserControl != value)
                {
                    currentUserControl = value;
                    RaisePropertyChanged("CurrentUserControl");
                }
            }
        }

        void StudentsInformationViewCommandExecute() { CurrentUserControl = studentsInformation; }

        public ICommand StudentsInformationViewCommand { get { return new RelayCommand(StudentsInformationViewCommandExecute); } }
    }
}