namespace Assets.Scripts.ECS
{
    public sealed class GameSystems:Feature
    {
        public GameSystems(Contexts contexts)
        {
            //InitializeSystems
            Add(new CreateUnitySystem(contexts));
            
            //ReactiveSystems
            Add(new PositionLoggerSystem(contexts.game));
            Add(new HealthLoggerSystem(contexts.game));
        }
    }
}