using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows;

namespace TreasureHunterApp
{
    public static class TextBoxExtensions
    {
        public static double TextWidth(this TextBox textBox, FontFamily fontFamily, FontStyle fontStyle, FontWeight fontWeight, FontStretch fontStretch, double fontSize)
        {
            FormattedText formattedText = new FormattedText(
                textBox.Text,
                CultureInfo.CurrentCulture,
                textBox.FlowDirection,
                new Typeface(fontFamily, fontStyle, fontWeight, fontStretch),
                fontSize,
                Brushes.Black,
                new NumberSubstitution(),
                TextFormattingMode.Display);

            return formattedText.Width;
        }
    }
}
