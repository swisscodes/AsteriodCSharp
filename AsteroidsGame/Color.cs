
namespace AsteroidsProject;

internal class Color((byte R, byte G, byte B) color)
{
    public static readonly Color White = new((255, 255, 255));
    public static readonly Color Black = new((0,  0, 0));
    public static readonly Color Red = new((255, 0, 0));
    public static readonly Color Orange = new((255, 165, 0));
    public static readonly Color Yellow = new((255, 255, 0));
    public static readonly Color Green = new((0, 128, 0));
    public static readonly Color Blue = new((0, 0, 255));
    public static readonly Color Purple = new((128, 0, 128));
    public byte R = color.R;
    public byte G = color.G;
    public byte B = color.B;
}
