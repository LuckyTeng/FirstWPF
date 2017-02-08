using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace DataBinding
{
    public class Order
    {
        public string Name { get; set; }
        public string Customer { get; set; }
        public string Object { get; set; }
        public string Location { get; set; }
        public string Filled { get; set; }
    }

    public class Orders : ObservableCollection<Order>
    {
        public Orders()
        {
            Order[] o = new[] { new Order { Name = "NonKon", Customer = "Hook", Object = "Thing", Location = "Landon", Filled="No" },
                                new Order { Name = "O..O", Customer = "Best", Object = "Ya", Location = "Landon", Filled="Yes" },
                                new Order { Name = ">--<", Customer = "Better", Object = "How", Location = "Landon", Filled="Yes" }};


            foreach (var order in o)
            {
                this.Add(order);
            }
        }
    }
}
