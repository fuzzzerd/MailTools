using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MailTools.ViewModels
{
    public class SettingsViewModel : ViewModelBase
    {
        private string _smtpServer;
        public String SmtpServer
        {
            get { return _smtpServer; }
            set
            {
                _smtpServer = value;
                OnPropertyChanged("SmtpServer");
            }
        }

        private int _smtpPort;
        public int SmtpPort
        {
            get { return _smtpPort; }
            set
            {
                _smtpPort = value;
                OnPropertyChanged("SmtpPort");
            }
        }

        private bool _useSsl;
        public bool UseSsl
        {
            get { return _useSsl; }
            set
            {
                _useSsl = value;
                OnPropertyChanged("UseSsl");
            }
        }

        private string _fromAddress;
        public String FromAddress
        {
            get { return _fromAddress; }
            set
            {
                _fromAddress = value;
                OnPropertyChanged("FromAddress");
            }
        }

        private string _replyAddress;
        public String ReplyAddress
        {
            get { return _replyAddress; }
            set
            {
                _replyAddress = value;
                OnPropertyChanged("ReplyAddress");
            }
        }
    }
}
