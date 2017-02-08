using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace DataBinding
{
    /// <summary>
    /// DefaultView.xaml 的互動邏輯
    /// </summary>
    public partial class DefaultView :Window
    {
        private CollectionView _myCollectionView;

        public DefaultView()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _myCollectionView = (CollectionView)
                                CollectionViewSource.GetDefaultView(stackpanel1.DataContext);
        }

        private void OnButton(object sender, RoutedEventArgs e)
        {
            Button b = sender as Button;

            switch (b.Name)
            {
                case "Previous":
                    _myCollectionView.MoveCurrentToPrevious();

                    if (_myCollectionView.IsCurrentBeforeFirst)
                    {
                        _myCollectionView.MoveCurrentToLast();
                    }
                    break;

                case "Next":
                    _myCollectionView.MoveCurrentToNext();
                    if (_myCollectionView.IsCurrentAfterLast)
                    {
                        _myCollectionView.MoveCurrentToFirst();
                    }
                    break;

                    //var o = _myCollectionView.CurrentItem as GreekGod;
            }

        }

        public bool Contains(object de)
        {
            Order order = de as Order;
            //Return members whose Orders have not been filled

            return ( order.Filled== "No" );
        }

        private void checkBox1_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void checkBox1_Click(object sender, RoutedEventArgs e)
        {
            if (checkBox1.IsChecked.HasValue && checkBox1.IsChecked.Value)
            {
                _myCollectionView.Filter = new Predicate<Object>(Contains);
            }
            else
            {
                _myCollectionView.Filter = null;
            }
        }
    }
}   
