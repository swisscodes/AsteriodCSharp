

namespace AsteroidsProject;

internal class Point(int x, int y)
{
    public int PointX { get; private set; } = x;
    public int PointY { get; private set; } = y;

    public Point() : this(0, 0)
    {

    }
}
