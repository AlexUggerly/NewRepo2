using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMaui.Model
{
    public class tblCustomers : INotifyPropertyChanged
    {
        private int _customerID;
        private string _customerName;
        private string _customerAddress;
        private string _phoneNumber;
        private string _email;
        public int CustomerID
        {
            get { return _customerID; }
            set
            {
                if (_customerID != value)
                {
                    _customerID = value;
                    OnPropertyChanged("CustomerID");
                }
            }
        }
        public string CustomerName
        {
            get { return _customerName; }

            set 
            {
                if (_customerName != value)
                {
                    _customerName = value;
                    OnPropertyChanged("CustomerName");
                }
            }
        }


        public string CustomerAddress
        {
            get { return _customerAddress; }
            set 
            {
                if (_customerAddress != value)
                {
                    _customerAddress = value;
                    OnPropertyChanged("CustomerAddress");
                }
            }
        }


        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set 
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    OnPropertyChanged("PhoneNumber");
                }
            }
        }


        public string Email
        {
            get { return _email; }
            set 
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged("Email");
                }
            }
        }


        

        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
