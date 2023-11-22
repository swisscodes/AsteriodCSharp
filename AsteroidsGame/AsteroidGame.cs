

namespace AsteroidsProject;

internal class AsteroidsGame(Asteroid[] asteroids)
{
    private readonly Asteroid[] _asteroids = asteroids;
    public void Run()
    {
        while (true)
        {
            foreach (Asteroid asteroid in _asteroids)
            {
                asteroid.Update();
            }
        }
    }
};
