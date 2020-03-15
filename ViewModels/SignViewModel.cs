using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System;
using pr_1_Gaivoronskyi.Tools;
using pr_1_Gaivoronskyi.Models;
using pr_1_Gaivoronskyi.Processors;

namespace pr_1_Gaivoronskyi.ViewModels
{

    internal class SignViewModel : INotifyPropertyChanged
    {
        #region Fleids
        private SignModel _model = new SignModel();
        private DateTime _pickedDate = DateTime.Today;
        private DataProcessor _processor = new DataProcessor(); 
        public RelayCommand<object> _submitDate;
        #endregion

        #region Properties
        public DateTime BirthDate
        {
            get
            {
                return _pickedDate;
            }
            set
            {
                _pickedDate = value;
                OnPropertyChanged("BirthDate");
            }
        }

        public int Age
        {
            get
            {
                return _model.Age;
            }
            set
            {
                _model.Age = value;
                OnPropertyChanged();
            }
        }

        public String EasternSign
        {
            get
            {
                return _model.EasternSign;
            }
            set
            {
                OnPropertyChanged("EasternSign");
            }
        }
        public String WesternSign
        {
            get
            {
                return _model.WesternSign;
            }
            set
            {

                OnPropertyChanged();
            }
        }

        public RelayCommand<object> submitDate
        {
            get
            {
                return _submitDate ?? (_submitDate = new RelayCommand<object>(o =>
                {
                    //MessageBox
                    //    .Show
                    //        ($"Date picked: {BirthDate}");
                   Age =  _processor.calculateAge(_pickedDate);
                }, CanExecuteCommand
                       ));
            }
        }

        #endregion

        public bool CanExecuteCommand(object o)
        {
            return !(_pickedDate.Equals(null));
        }

        #region INotifyPropertyImplementation
        public event PropertyChangedEventHandler PropertyChanged;

        //[NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
