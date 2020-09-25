using Entitas;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.ECS;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private Systems _systems;
    private Contexts _contexts;

    void Start()
    {
        _contexts = Contexts.sharedInstance;
        _systems = new GameSystems(_contexts);
        _systems.Initialize();
        
    }

    private void Update()
    {
        _systems.Execute();
    }
    
}
