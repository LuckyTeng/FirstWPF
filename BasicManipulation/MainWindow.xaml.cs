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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using PatientHelper;
using SDKSample;

namespace BasicManipulation
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow :Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        void Window_ManipulationStarting(object sender, ManipulationStartingEventArgs e)
        {
            e.ManipulationContainer = this;
            e.Handled = true;
        }

        void Window_ManipulationDelta(object sender, ManipulationDeltaEventArgs e)
        {

            // Get the Rectangle and its RenderTransform matrix.
            Rectangle rectToMove = e.OriginalSource as Rectangle;
            Matrix rectsMatrix = ( (MatrixTransform)rectToMove.RenderTransform ).Matrix;

            // Rotate the Rectangle.
            rectsMatrix.RotateAt(e.DeltaManipulation.Rotation,
                                 e.ManipulationOrigin.X,
                                 e.ManipulationOrigin.Y);

            // Resize the Rectangle.  Keep it square 
            // so use only the X value of Scale.
            rectsMatrix.ScaleAt(e.DeltaManipulation.Scale.X,
                                e.DeltaManipulation.Scale.X,
                                e.ManipulationOrigin.X,
                                e.ManipulationOrigin.Y);

            // Move the Rectangle.
            rectsMatrix.Translate(e.DeltaManipulation.Translation.X,
                                  e.DeltaManipulation.Translation.Y);

            // Apply the changes to the Rectangle.
            rectToMove.RenderTransform = new MatrixTransform(rectsMatrix);

            Rect containingRect =
        new Rect(( (FrameworkElement)e.ManipulationContainer ).RenderSize);

            Rect shapeBounds =
        rectToMove.RenderTransform.TransformBounds(
                    new Rect(rectToMove.RenderSize));

            // Check if the rectangle is completely in the window.
            // If it is not and intertia is occuring, stop the manipulation.
            if (e.IsInertial && !containingRect.Contains(shapeBounds))
            {
                e.Complete();
            }


            e.Handled = true;
        }

        void Window_InertiaStarting(object sender, ManipulationInertiaStartingEventArgs e)
        {

            // Decrease the velocity of the Rectangle's movement by 
            // 10 inches per second every second.
            // (10 inches * 96 pixels per inch / 1000ms^2)
            e.TranslationBehavior.DesiredDeceleration = 10.0 * 96.0 / ( 1000.0 * 1000.0 );

            // Decrease the velocity of the Rectangle's resizing by 
            // 0.1 inches per second every second.
            // (0.1 inches * 96 pixels per inch / (1000ms^2)
            e.ExpansionBehavior.DesiredDeceleration = 0.1 * 96 / ( 1000.0 * 1000.0 );

            // Decrease the velocity of the Rectangle's rotation rate by 
            // 2 rotations per second every second.
            // (2 * 360 degrees / (1000ms^2)
            e.RotationBehavior.DesiredDeceleration = 720 / ( 1000.0 * 1000.0 );

            e.Handled = true;
        }

        private Brush _oldBrush = null;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var p = new Person("teng", "cool");
            textBox1.DataContext = p;

            DispatcherTimer timer = new DispatcherTimer();
            timer.Tick += new EventHandler(timer_Tick);
            timer.Interval = TimeSpan.FromMilliseconds(250);
            timer.Start();

            _oldBrush = button1.Background;

            Keyboard.Focus(textBox1);

            var myAdornerLayer = AdornerLayer.GetAdornerLayer(textBox1);
            myAdornerLayer.Add(new SimpleCircleAdorner(textBox1));
        }

        void timer_Tick(object sender, EventArgs e)
        {
            button1.Background = _oldBrush;

            if ((Keyboard.GetKeyStates(Key.Return) & KeyStates.Down) > 0)
            {
                button1.Background = Brushes.Red;
            }

            if (Mouse.LeftButton == MouseButtonState.Pressed)
            {
                button1.Background = Brushes.BlueViolet;
            }
        }

        private void OnButtonKeyDown(object sender, KeyEventArgs e)
        {
            Button source = e.Source as Button;
            if (source != null)
            {
                if (e.Key == Key.Left)
                {
                    source.Background = Brushes.LemonChiffon;
                }
                else
                {
                    source.Background = Brushes.AliceBlue;
                }
            }

        }

        private void OnMouseExampleMouseEnter(object sender, MouseEventArgs e)
        {
            // Cast the source of the event to a Button.
            Button source = e.Source as Button;

            // If source is a Button.
            if (source != null)
            {
                source.Background = Brushes.SlateGray;
            }
        }

        private void OnMosueExampleMouseLeave(object sender, MouseEventArgs e)
        {
            // Cast the source of the event to a Button.
            Button source = e.Source as Button;

            // If source is a Button.
            if (source != null)
            {
                source.Background = Brushes.AliceBlue;
            }
        }

        private void OnTextInputKeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.O && Keyboard.Modifiers == ModifierKeys.Control)
            {
                handle();
                e.Handled = true;
            }
        }

        private void OnTextInputButtonClick(object sender, RoutedEventArgs e)
        {
            handle();
            //e.Handled = true;
        }

        public void handle()
        {
            MessageBox.Show("Pretend this opens a file");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            DockPanelWindow dpw = new DockPanelWindow();
            dpw.Show();

            DataTemplateWindow wnd = new DataTemplateWindow();
            wnd.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EllipseEventHandlingWindow wnd = new EllipseEventHandlingWindow();
            wnd.Show();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            StylingIntroSample sis = new StylingIntroSample();
            sis.Show();
        }

        private void PatientOverview3D_FlipCompleted(object sender, EventArgs e)
        {
            PatientOverview3D.Visibility = Visibility.Collapsed;
            MessageBox.Show("PatientOverview3D_FlipCompleted");
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            Brush brush = Transition3DHelper.CreateBrushFromUIElementWithBitmap(My2D);

            Uri lien = new Uri("pack://application:,,,/Images/LIEN.jpg", UriKind.Absolute);

            ImageBrush ib = new ImageBrush();
            BitmapImage bi = new BitmapImage(lien);
            ib.ImageSource = bi;
            ib.ViewportUnits = BrushMappingMode.Absolute;
            brush = ib;

            if (brush != null)
            {
                DiffuseMaterial dm = new DiffuseMaterial(brush);
                PatientOverview3D.Visibility = Visibility.Visible;
                PatientOverview3D.Flip(dm, dm);
            }
        }
    }

    class Person
    {
        private string _name;
        public string Title;

        public Person(string name, string title)
        {
            this.Name = name;
            this.Title = title;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
    }

    public class SimpleCircleAdorner : Adorner
    {
        // Be sure to call the base class constructor.

        public SimpleCircleAdorner(UIElement adornedElement)
            : base(adornedElement)
        {
        }

        // A common way to implement an adorner's rendering behavior is to override the OnRender

        // method, which is called by the layout system as part of a rendering pass.

        protected override void OnRender(DrawingContext drawingContext)
        {
            Rect adornedElementRect = new Rect(this.AdornedElement.DesiredSize);

            // Some arbitrary drawing implements.

            SolidColorBrush renderBrush = new SolidColorBrush(Colors.Green);
            renderBrush.Opacity = 0.2;
            Pen renderPen = new Pen(new SolidColorBrush(Colors.Navy), 1.5);
            double renderRadius = 5.0;

            // Draw a circle at each corner.

            drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.TopLeft, renderRadius, renderRadius);
            drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.TopRight, renderRadius, renderRadius);
            drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.BottomLeft, renderRadius, renderRadius);
            drawingContext.DrawEllipse(renderBrush, renderPen, adornedElementRect.BottomRight, renderRadius, renderRadius);
        }


    }
}
