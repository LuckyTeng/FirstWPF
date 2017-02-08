using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace DataBinding
{
    public class Person :IDataErrorInfo
    {
        public string PersonName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string HomeTown { get; set; }
        public int Age { get; set; }

        public Person()
        {
            this.PersonName = String.Empty;
            this.FirstName = String.Empty;
            this.LastName = String.Empty;
            this.HomeTown = String.Empty;
        }

        public Person(string personName) : base()
        {
            this.PersonName = personName;
        }

        public override string ToString()
        {
            return FirstName; 
        }

        public string this[string name]
        {
            get
            {
                string result = null;

                if (name == "Age")
                {
                    if (this.Age < 0 || this.Age > 150)
                    {
                        result = "Age must not be less than 0 or greater than 150.";
                    }
                }
                return result;
            }

        }

        public string Error
        {
            get
            {
                return null;
            }
        }
    }

    public class People :ObservableCollection<Person>
    {
        public People()
        {
            Person p = new Person();
            p.FirstName = "Christina";
            p.LastName = "Lee";
            p.HomeTown = "Kirkland";

            this.Add(p);

            p = new Person();
            p.FirstName = "Jacky";
            p.LastName = "Chen";
            p.HomeTown = "China";

            this.Add(p);

            p = new Person();
            p.FirstName = "Teng";
            p.LastName = "Cool";
            p.HomeTown = "Ghost Island";

            this.Add(p);
        }
    }
}
