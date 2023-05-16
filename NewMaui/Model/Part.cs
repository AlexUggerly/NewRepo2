using System.ComponentModel;

namespace NewMaui.Model
{
    public class Part : INotifyPropertyChanged
    {
        private int _partID;
        private string _partName;
        private int _numberInStock;
        private double _partPrice;
        private int _amountPartMachine;

        public int PartID
        {
            get { return _partID; }
            set
            {
                if (_partID != value)
                {
                    _partID = value;
                    OnPropertyChanged("PartID");
                }
            }
        }

        public string PartName
        {
            get { return _partName; }
            set
            {
                if (_partName != value)
                {
                    _partName = value;
                    OnPropertyChanged("PartName");
                }
            }
        }

        public int NumberInStock
        {
            get { return _numberInStock; }
            set
            {
                if (_numberInStock != value)
                {
                    _numberInStock = value;
                    OnPropertyChanged("NumberInStock");
                }
            }
        }

        public double PartPrice
        {
            get { return _partPrice; }
            set
            {
                if (_partPrice != value)
                {
                    _partPrice = value;
                    OnPropertyChanged("PartPrice");
                }
            }
        }

        public int AmountPartMachine
        {
            get { return _amountPartMachine; }
            set
            {
                if (_amountPartMachine != value)
                {
                    _amountPartMachine = value;
                    OnPropertyChanged("AmountPartMachine");
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
