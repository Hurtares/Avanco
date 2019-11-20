using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Shapes;

namespace Avanco
{
    class Peca
    {
        public bool White { get; }
        public int Position { get; set; }
        public Ellipse Ellipse { get; set; }

        public Peca(bool white,int position) {
            White = white;
            Position = position;
            CreatePeace();
        }

        private void CreatePeace() {
            int i = Position % 7;
            int j = Position/7;
            Ellipse = new Ellipse {
                Name = Position.ToString(),
                Fill = new SolidColorBrush(Windows.UI.Colors.Black),
                Width = 80,
                Height = 80,
                VerticalAlignment = VerticalAlignment.Top,
                HorizontalAlignment = HorizontalAlignment.Left,
                Margin = new Thickness(50 + i * 120, 50 + j * 120, 0, 0)
            };
            if (White) {
                Ellipse.Fill = new SolidColorBrush(Windows.UI.Colors.BurlyWood);
            } else {
                Ellipse.Fill = new SolidColorBrush(Windows.UI.Colors.Black);
            }
        }
    }
}
