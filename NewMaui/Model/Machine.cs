using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NewMaui.Model
{
    public class Machine : INotifyPropertyChanged
    {
        private int _machineID;
        private string _machineName;
        private string _partsMustChange;
        private int _serviceInterval;
        private List<Part> _parts;
        private int _customerID;
        private string _nextService;
        private string _machineSerialNumber;

        public int MachineID
        {
            get { return _machineID; }
            set
            {
                if (_machineID != value)
                {
                    _machineID = value;
                    OnPropertyChanged("MachineID");
                }
            }
        }

        public string MachineName
        {
            get { return _machineName; }
            set
            {
                if (_machineName != value)
                {
                    _machineName = value;
                    OnPropertyChanged("MachineName");
                }
            }
        }

        public string PartsMustChange
        {
            get { return _partsMustChange; }
            set
            {
                if (_partsMustChange != value)
                {
                    _partsMustChange = value;
                    OnPropertyChanged("PartsMustChange");
                }
            }
        }

        public int ServiceInterval
        {
            get { return _serviceInterval; }
            set
            {
                if (_serviceInterval != value)
                {
                    _serviceInterval = value;
                    OnPropertyChanged("ServiceInterval");
                }
            }
        }

        public List<Part> Parts
        {
            get { return _parts; }
            set
            {
                if (_parts != value)
                {
                    _parts = value;
                    OnPropertyChanged("Parts");
                }
            }
        }

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

        public string NextService
        {
            get { return _nextService; }
            set
            {
                if (_nextService != value)
                {
                    _nextService = value;
                    OnPropertyChanged("NextService");
                }
            }
        }

        public string MachineSerialNumber
        {
            get { return _machineSerialNumber; }
            set
            {
                if (_machineSerialNumber != value)
                {
                    _machineSerialNumber = value;
                    OnPropertyChanged("MachineSerialNumber");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
