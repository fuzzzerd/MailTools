using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MailTools.ViewModels
{
    public class MessageViewModel: ViewModelBase
    {
        private ObservableCollection<string> _toAddresses;
        public ObservableCollection<String> ToAddresses
        {
            get { return _toAddresses; }
            set
            {
                _toAddresses = value;
                NotifyPropertyChanged("ToAddresses");
            }
        }

        private ObservableCollection<string> _ccAddresses;
        public ObservableCollection<String> CarbonCopyAddresses
        {
            get { return _ccAddresses; }
            set
            {
                _ccAddresses = value;
                NotifyPropertyChanged("CarbonCopyAddresses");
            }
        }

        private ObservableCollection<string> _bccAddresses;
        public ObservableCollection<String> BlindCarbonCopyAddresses
        {
            get { return _bccAddresses; }
            set
            {
                _bccAddresses = value;
                NotifyPropertyChanged("BlindCarbonCopyAddresses");
            }
        }


        private string _subject;
        public String Subject
        {
            get { return _subject; }
            set
            {
                _subject = value;
                OnPropertyChanged("Subject");
            }
        }

        private string _body;
        public String Body
        {
            get { return _body; }
            set
            {
                _body = value;
                OnPropertyChanged("Body");
            }
        }

        private bool _isHtmlBody;
        public Boolean IsHtmlBody
        {
            get { return _isHtmlBody; }
            set
            {
                _isHtmlBody = value;
                OnPropertyChanged("IsHtmlBody");
            }
        }
    }
}