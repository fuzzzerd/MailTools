using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;

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

        private ObservableCollection<string> _log;
        public ObservableCollection<String> Log
        {
            get { return _log; }
            set { _log = value; OnPropertyChanged("Log"); }
        }

        public MainWindowViewModel() { Log = new ObservableCollection<string>(); }

        public ICommand SendMessage
        {
            get { return new RelayCommand((x) => { this.Send(); }); }
        }

        protected void Send()
        {
            try
            {
                var smtp = new System.Net.Mail.SmtpClient(SettingsVM.SmtpServer, SettingsVM.SmtpPort);
                smtp.EnableSsl = SettingsVM.UseSsl;

                var mm = new System.Net.Mail.MailMessage(SettingsVM.FromAddress, MessageVM.ToAddresses, MessageVM.Subject, MessageVM.Body);
                mm.IsBodyHtml = MessageVM.IsHtmlBody;
                mm.CC.Add(MessageVM.CarbonCopyAddresses);
                mm.Bcc.Add(MessageVM.BlindCarbonCopyAddresses);
                mm.ReplyTo = new System.Net.Mail.MailAddress(SettingsVM.ReplyAddress);

                smtp.Send(mm);

                Log.Add("Message sent successfully.");
            }
            catch (Exception ex)
            {
                Log.Add("Exception: " + ex.Message);
            }
        }
    }
}