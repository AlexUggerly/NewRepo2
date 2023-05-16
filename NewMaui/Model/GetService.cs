using System.ComponentModel;
using NewMaui.Model;

namespace NewMaui.Model
{
    public class GetService : INotifyPropertyChanged
    {
        private int _serviceID;
        private DateTime _serviceDate;
        private string _customerName;
        private string _machineName;
        private string _machineSerialNumber;
        private List<Part> _parts;
        private List<Image> _images;
        private int _transportTimeUsed;
        private int _transportKmUsed;
        private int _workTimeUsed;
        private string _imagePath;
        private string _note;
        private string _machineStatus;

        public int ServiceID
        {
            get { return _serviceID; }
            set
            {
                if (_serviceID != value)
                {
                    _serviceID = value;
                    OnPropertyChanged("ServiceID");
                }
            }
        }

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
        public string ShortServiceDate
        {
            get { return ServiceDate.ToString().Substring(0, 10); }
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

        public List<Image> Images
        {
            get { return _images; }
            set
            {
                if (_images != value)
                {
                    _images = value;
                    OnPropertyChanged("Images");
                }
            }
        }

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

        public int WorkTimeUsed
        {
            get { return _workTimeUsed; }
            set
            {
                if (_workTimeUsed != value)
                {
                    _workTimeUsed = value;
                    OnPropertyChanged("WorkTimeUsed");
                }
            }
        }

        public string ImagePath
        {
            get { return _imagePath; }
            set
            {
                if (_imagePath != value)
                {
                    _imagePath = value;
                    OnPropertyChanged("ImagePath");
                }
            }
        }

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
