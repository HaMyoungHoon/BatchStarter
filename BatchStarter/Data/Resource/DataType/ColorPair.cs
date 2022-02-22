using BatchStarter.Data.Resource.Helper;
using System.Windows.Media;

namespace BatchStarter.Data.Resource
{
    public struct ColorPair
    {
        public Color Color { get; set; }

        public Color? ForegroundColor { get; set; }

        public static implicit operator ColorPair(Color color) => new(color);

        public ColorPair(Color color)
        {
            Color = color;
            ForegroundColor = null;
        }

        public ColorPair(Color color, Color? foreground)
        {
            Color = color;
            ForegroundColor = foreground;
        }

        public Color GetForegroundColor() => ForegroundColor ?? Color.ContrastingForegroundColor();
    }
}
