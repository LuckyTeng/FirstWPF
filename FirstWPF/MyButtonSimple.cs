using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;

namespace FirstWPF
{
    /// <summary>
    /// Example of implementing RoutedEvent
    /// </summary>
    public class MyButtonSimple : Button
    {
        public static readonly RoutedEvent TapEvent = EventManager.RegisterRoutedEvent("Tap", RoutingStrategy.Bubble,
                                                                                       typeof (RoutedEventHandler),
                                                                                       typeof (MyButtonSimple));

        public event RoutedEventHandler Tap
        {
            add { AddHandler(TapEvent, value); }
            remove { RemoveHandler(TapEvent, value); }
        }

        void RaiseTapEvent()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(MyButtonSimple.TapEvent);
            RaiseEvent(newEventArgs);
        }

        protected override void OnClick()
        {
            RaiseTapEvent();
        }
    }
}
