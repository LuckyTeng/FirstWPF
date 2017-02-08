using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

using System.Windows.Media;


namespace FirstWPF.Brushes
{
    /// <summary>
    /// MediaBrush.xaml 的互動邏輯
    /// </summary>
    public partial class MediaBrush :Window
    {
        public MediaBrush()
        {
            InitializeComponent();

            //

            // Create the Geometry to draw.

            //

            GeometryGroup ellipses = new GeometryGroup();
            ellipses.Children.Add(
                new EllipseGeometry(new Point(50, 50), 45, 20)
                );
            ellipses.Children.Add(
                new EllipseGeometry(new Point(50, 50), 20, 45)
                );


            //

            // Create a GeometryDrawing.

            //

            GeometryDrawing aGeometryDrawing = new GeometryDrawing();
            aGeometryDrawing.Geometry = ellipses;

            // Paint the drawing with a gradient.

            aGeometryDrawing.Brush = 
      new LinearGradientBrush(
                    Colors.Blue,
                    Color.FromRgb(204, 204, 255),
                    new Point(0, 0),
                    new Point(1, 1));

            // Outline the drawing with a solid color.

            aGeometryDrawing.Pen = new Pen(System.Windows.Media.Brushes.Black, 10);

        }
    }
}
