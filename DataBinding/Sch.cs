using System;
using System.Windows;

namespace DataBinding
{
    public class Sch
    {
        public DateTime StartDate { get; set; }

        public Sch()
        {
            StartDate = DateTime.Now;
        }
    }
}