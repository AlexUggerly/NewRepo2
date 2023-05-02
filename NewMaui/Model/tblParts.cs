using System.ComponentModel;

namespace NewMaui.Model
{

    public class tblParts : INotifyPropertyChanged
    {
        private int _partID;
        private string _partName;
        private int _numberInStock;
        private double _partPrice;

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
