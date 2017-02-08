using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace DataBinding
{
    class Places : ObservableCollection<Place>
    {
        public Places()
        {
            Place p = new Place {CityName = "HCM", State = "Binh Tan"};

            Add(p);

            p = new Place { CityName = "Taipei", State = "Shin Yih" };

            Add(p);
        }
    }
}
