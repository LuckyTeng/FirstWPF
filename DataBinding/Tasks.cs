using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace DataBinding
{
    public class Tasks :ObservableCollection<Task>
    {
        public Tasks()
        {
            var task = new Task("Hello world");
            this.Add(task);
            task = new Task("Never give up");
            this.Add(task);
            task = new Task("Are you lost mind?");
            this.Add(task);


        }
    }

    public class Task
    {
        private string _desc;

        public string Desc
        {
            get { return _desc; }
            set { _desc = value; }
        }

        public Task(string desc)
        {
            this.Desc = desc;
        }
    }
}
