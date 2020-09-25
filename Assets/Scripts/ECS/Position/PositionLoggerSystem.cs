using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class PositionLoggerSystem : ReactiveSystem<GameEntity>
{
    Contexts _contexts;

    public PositionLoggerSystem(IContext<GameEntity> context) : base(context)
    {

    }

    protected override void Execute(List<GameEntity> entities)
    {
        foreach (var item in entities)
        {
            Debug.Log(item.position.Value);
        }
    }

    protected override bool Filter(GameEntity entity)
    {
        return entity.hasPosition;
    }

    protected override ICollector<GameEntity> GetTrigger(IContext<GameEntity> context)
    {
        return context.CreateCollector(GameMatcher.Position);

    }


}
