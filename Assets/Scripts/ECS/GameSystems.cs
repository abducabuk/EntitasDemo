namespace Assets.Scripts.ECS
{
    public sealed class GameSystems:Feature
    {
        public GameSystems(Contexts contexts)
        {
            // Input executes first
            Add(new CreateUnitySystem(contexts));
            
            // Update 
            Add(new PositionLoggerSystem(contexts.game));
            Add(new HealthLoggerSystem(contexts.game));
            
            // Render executes after game logic 

            // Destroy executes last

        }
    }
}