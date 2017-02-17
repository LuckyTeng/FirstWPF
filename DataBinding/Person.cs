using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using DataBinding.Annotations;

/* This example show how to impl the INotifyPropertyChanged and ObservableCollection<T>
 * If the collection impl the ObservableCollection<T>, it don't need to be impl. the INotifyPropertyChanged in the collection item
 */
namespace DataBinding
{
    public class Person :IDataErrorInfo, INotifyPropertyChanged
    {
        private string name;

        public string PersonName { get { return name;} set
        {
            name = value;
            OnPropertyChanged("PersonName"); /* same as the property name */
        } }

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

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
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
