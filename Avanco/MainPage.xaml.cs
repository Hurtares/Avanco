using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Avanco
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
            List<Peca> pecas = new List<Peca>();
        public MainPage() {
            this.InitializeComponent();
            var ellipse1 = new Ellipse();
            ellipse1.Fill = new SolidColorBrush(Windows.UI.Colors.SteelBlue);
            ellipse1.Width = 200;
            ellipse1.Height = 200;
            ellipse1.Margin = new Thickness(0, 400, 0, 0);
            RotateBehavior.CenterX = 100;
            cubo.Margin = new Thickness(10, 10, 0, 0);
            //layoutRoot.Children.Remove(cubo);
            DrawBoard();
            Rectangle temp1 = new Rectangle();
            temp1.Fill = new SolidColorBrush(Windows.UI.Colors.Beige);
            temp1.Width = 50;
            temp1.Height = 50;
            layoutRoot.Children.Add(temp1);
            // When you create a XAML element in code, you have to add
            // it to the XAML visual tree. This example assumes you have
            // a panel named 'layoutRoot' in your XAML file, like this:
            // <Grid x:Name="layoutRoot>
            layoutRoot.Children.Add(ellipse1);
            for (int i = 0; i < 14; i++) {
                var test = new Peca(false,i);
                layoutRoot.Children.Add(test.Ellipse);
                pecas.Add(test);
            }
            for (int i = 35; i < 49; i++) {
                var test = new Peca(true, i);
                layoutRoot.Children.Add(test.Ellipse);
                pecas.Add(test);
            }
        }
        private void DrawBoard() {
            for (int i = 0; i < 7; i++) {
                for (int j = 0; j < 7; j++) {
                    Rectangle temp = new Rectangle();
                    temp.Fill = new SolidColorBrush(Windows.UI.Colors.AliceBlue);
                    temp.Width = 100;
                    temp.Height = 100;
                    temp.VerticalAlignment = VerticalAlignment.Top;
                    temp.HorizontalAlignment = HorizontalAlignment.Left;
                    temp.Margin = new Thickness(40 + i * 120, 40 + j * 120, 0, 0);
                    layoutRoot.Children.Add(temp);
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e) {
            layoutRoot.Children.Remove(pecas[4].Ellipse);
        }
    }
}
