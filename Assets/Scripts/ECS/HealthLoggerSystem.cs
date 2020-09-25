using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthLoggerSystem : ReactiveSystem<GameEntity>
{
    public HealthLoggerSystem(IContext<GameEntity> context) : base(context)
    {
    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var item in entities)
        {
            Debug.Log(item.health.Value);
        }
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasHealth;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Health);
    }
}
