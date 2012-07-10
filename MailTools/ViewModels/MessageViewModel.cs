using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace MailTools.ViewModels
{
    public class MessageViewModel: ViewModelBase
    {
        private string _toAddresses;
        public String ToAddresses
        {
            get { return _toAddresses; }
            set
            {
                _toAddresses = value;
                NotifyPropertyChanged("ToAddresses");
            }
        }

        private string _ccAddresses;
        public String CarbonCopyAddresses
        {
            get { return _ccAddresses; }
            set
            {
                _ccAddresses = value;
                NotifyPropertyChanged("CarbonCopyAddresses");
            }
        }

        private string _bccAddresses;
        public String BlindCarbonCopyAddresses
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