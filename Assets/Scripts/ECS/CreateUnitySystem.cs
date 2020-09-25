using System.Collections;
using System.Collections.Generic;
using Entitas;
using UnityEngine;

public class CreateUnitySystem : IInitializeSystem
{
    private Contexts _contexts;

    public CreateUnitySystem(Contexts contexts)
    {
        this._contexts = contexts;
    }
    
    public void Initialize()
    {
        var e = _contexts.game.CreateEntity();
        e.AddPosition(Vector3.zero);
        e.AddHealth(100f);
    }
}
