

namespace AsteroidsProject;

internal class Asteroid(float positionX, float positionY, float velocityX, float velocityY)
{
    public float PositionX { get; private set; } = positionX;
    public float PositionY { get; private set; } = positionY;
    public float VelocityX { get; private set; } = velocityX;
    public float VelocityY { get; private set; } = velocityY;

    public void Update()
    {
        PositionX += VelocityX;
        PositionY += VelocityY;
    }


}
