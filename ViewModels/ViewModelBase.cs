using System.ComponentModel;

namespace MailTools.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        #region Implementation of INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyPropertyChanged(string propertyName)
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }

        protected virtual void OnPropertyChanged(string propertyName) 
        { 
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName)); 
        }

        protected virtual void OnPropertyChanged(PropertyChangedEventArgs args)
        { 
            var handler = PropertyChanged; 
            if (handler != null)            
                handler(this, args); 
        }

        #endregion
    }
}
