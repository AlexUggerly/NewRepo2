using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewMaui.Model
{
    public class tblService : INotifyPropertyChanged
    {
		private DateTime _serviceDate;

		public DateTime ServiceDate
		{
			get { return _serviceDate; }
			set
			{
				if (_serviceDate != value)
				{
					_serviceDate = value;
					OnPropertyChanged("ServiceDate");
				}
			}
		}
        private int _transportTimeUsed;
        public int TransportTimeUsed
        {
            get { return _transportTimeUsed; }
            set
            {
                if (_transportTimeUsed != value)
                {
                    _transportTimeUsed = value;
                    OnPropertyChanged("TransportTimeUsed");
                }
            }
        }
        private int _transportKmUsed;
        public int TransportKmUsed
        {
            get { return _transportKmUsed; }
            set
            {
                if (_transportKmUsed != value)
                {
                    _transportKmUsed = value;
                    OnPropertyChanged("TransportKmUsed");
                }
            }
        }
        private int _workTimeUsed;
        public int WorkTimeUsed
        {
            get { return _workTimeUsed; }
            set
            {
                if (_workTimeUsed != value)
                {
                    _transportKmUsed = value;
                    OnPropertyChanged("WorkTimeUsed");
                }
            }
        }
        private string _serviceImage;
        public string ServiceImage
        {
            get { return _serviceImage; }
            set
            {
                if (_serviceImage != value)
                {
                    _serviceImage = value;
                    OnPropertyChanged("ServiceImage");
                }
            }
        }
        private int _machineID;
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
        private int _customerID;
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
        private int _serviceID;
        public int ServiceID
        {
            get { return _serviceID; }
            set
            {
                if (_customerID != value)
                {
                    _customerID = value;
                    OnPropertyChanged("ServiceID");
                }
            }
        }
        private string _machineSerialNumber;
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
        private string _note;
        public string Note
        {
            get { return _note; }
            set
            {
                if (_note != value)
                {
                    _note = value;
                    OnPropertyChanged("Note");
                }
            }
        }
        private string _machineStatus;
        public string MachineStatus
        {
            get { return _machineStatus; }
            set
            {
                if (_machineStatus != value)
                {
                    _machineStatus = value;
                    OnPropertyChanged("MachineStatus");
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
