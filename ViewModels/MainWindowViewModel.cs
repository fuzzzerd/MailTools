using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MailTools.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private SettingsViewModel _settingsVM;
        public SettingsViewModel SettingsVM
        {
            get { return _settingsVM; }
            set
            {
                _settingsVM = value;
                OnPropertyChanged("SettingsVM");
            }
        }

        private MessageViewModel _messageVM;
        public MessageViewModel MessageVM
        {
            get { return _messageVM; }
            set
            {
                _messageVM = value;
                OnPropertyChanged("MessageVM");
            }
        }

        private string _log;
        public String Log
        {
            get { return _log; }
            set { _log = value; OnPropertyChanged("Log"); }
        }
    }
}