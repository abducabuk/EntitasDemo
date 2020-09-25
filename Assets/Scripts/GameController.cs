using Entitas;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Systems _systems;
    private Contexts _contexts;

    void Start()
    {
        _contexts = Contexts.sharedInstance;
        _systems = CreateSystems();
        _systems.Initialize();
        
    }

    private void Update()
    {
        _systems.Execute();
    }

    private Systems CreateSystems()
    {
        return new Feature()
            .Add(new CreateUnitySystem(_contexts))
            .Add(new PositionLoggerSystem(_contexts.game))
            .Add(new HealthLoggerSystem(_contexts.game));
    }
}
