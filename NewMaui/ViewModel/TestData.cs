using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace NewMaui.ViewModel
{
    public class TestData
    {
        

        private string itemName;

        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        private int priceOld;

        public int PriceOld
        {
            get { return priceOld; }
            set { priceOld = value; }
        }
        private int priceNew;

        public int PriceNew
        {
            get { return priceNew; }
            set { priceNew = value; }
        }

        public TestData(string itemName, int priceOld, int priceNew)
        {
            this.itemName = itemName;
            this.priceOld = priceOld;
            this.priceNew = priceNew;
        }
        
        public List<TestData> Prices = new List<TestData>();
        
       public List<TestData> AddToList()
        {
            Prices.Add(this);
            return Prices;
        }


    }
}
