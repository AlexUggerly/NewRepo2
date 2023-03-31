/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMaui.Model
{
    public class tblCustomersMachinesParts : INotifyPropertyChanged  
    {
        private int _customerId;
        private string _customerName;
        private string _customerAddress;
        private string _phoneNumber;

        public int customerId
        {
            get { return _customerId; }
            set
            {
                if (_customerId != value)
                {
                    _customerId = value;
                    OnPropertyChanged("customerID");
                }
            }
        }

        public string customerName
        {
            get { return _customerName; }
            set
            {
                if (_customerName != value)
                {
                    _customerName = value;
                    OnPropertyChanged("customerName");
                }
            }
        }

        public string customerAddress
        {
            get { return _customerAddress; }
            set
            {
                if (_customerAddress != value)
                {
                    _customerAddress = value;
                    OnPropertyChanged("customerAddress");
                }
            }
        }

        public string phoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    OnPropertyChanged("phoneNumber");
                }
            }
        }
        public string email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged("email");
                }
            }
        }
        public int machineID
        {
            get { return _machineID; }
            set
            {
                if (_machineID != value)
                {
                    _machineID = value;
                    OnPropertyChanged("machineID");
                }
            }
        }
        public string machineName
        {
            get { return _phoneNumeber; }
            set
            {
                if (_phoneNumeber != value)
                {
                    _phoneNumeber = value;
                    OnPropertyChanged("partPrice");
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
*/