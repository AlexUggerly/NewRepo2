using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMaui.Model
{
    public class tblMachineParts : INotifyPropertyChanged
    {
        private int _machineID;
        private string _machineName;
        private int _partID;
        private string _partName;
        private int _amountPartMachine;
        private int _numberInStock;
        private double _partPrice;

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
            get { return _machineName; }
            set
            {
                if (_machineName != value)
                {
                    _machineName = value;
                    OnPropertyChanged("machineName");
                }
            }
        }

        public int partID
        {
            get { return _partID; }
            set
            {
                if (_partID != value)
                {
                    _partID = value;
                    OnPropertyChanged("partID");
                }
            }
        }

        public string partName
        {
            get { return _partName; }
            set
            {
                if (_partName != value)
                {
                    _partName = value;
                    OnPropertyChanged("partName");
                }
            }
        }

        public int amountPartMachine
        {
            get { return _amountPartMachine; }
            set
            {
                if (_amountPartMachine != value)
                {
                    _amountPartMachine = value;
                    OnPropertyChanged("amountPartMachine");
                }
            }
        }

        public int numberInStock
        {
            get { return _numberInStock; }
            set
            {
                if (_numberInStock != value)
                {
                    _numberInStock = value;
                    OnPropertyChanged("numberInStock");
                }
            }
        }

        public double partPrice
        {
            get { return _partPrice; }
            set
            {
                if (_partPrice != value)
                {
                    _partPrice = value;
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
}


