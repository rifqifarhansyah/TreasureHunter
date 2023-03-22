using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace TreasureHunterApp
{
    public static class ColorExtensions
    {
        public static Color Darken(this Color color, double factor)
        {
            byte r = (byte)(color.R * (1 - factor));
            byte g = (byte)(color.G * (1 - factor));
            byte b = (byte)(color.B * (1 - factor));

            return Color.FromArgb(color.A, r, g, b);
        }

        public static Color Lighten(this Color color, double factor)
        {
            byte r = (byte)(color.R + (255 - color.R) * factor);
            byte g = (byte)(color.G + (255 - color.G) * factor);
            byte b = (byte)(color.B + (255 - color.B) * factor);

            return Color.FromArgb(color.A, r, g, b);
        }
    }
}
