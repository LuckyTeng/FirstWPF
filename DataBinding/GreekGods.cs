using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace DataBinding
{
    class  GreekGod
    {
        public string Name { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }

    class GreekGods :ObservableCollection<GreekGod>
    {
        public GreekGods()
        {
            GreekGod c = new GreekGod {Name = "I am Greek God 1"};
            this.Add(c);
            c = new GreekGod { Name = "I am Greek God 2" };
            this.Add(c);
        }
    }
}
