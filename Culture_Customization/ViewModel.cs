using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GettingStartedDemo
{
    public class ViewModel
    {
        public ViewModel()
        {
            this.StockPriceDetails = new ObservableCollection<Model>();
            DateTime date = new DateTime(2012, 1, 1);
            Random rd = new Random();

            for (int i = 0; i < 20; i++)
            {
                this.StockPriceDetails.Add(new Model() { XValue = date.AddHours(i), YValue = rd.Next(100, 900) });
            }

        }

        public ObservableCollection<Model> StockPriceDetails { get; set; }

    }
}
