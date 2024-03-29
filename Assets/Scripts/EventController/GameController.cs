using DefaultNamespace;
using EventController;
using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private Data _data;
    
    private Controllers _controllers;

    private void Start()
    {
        _controllers = new Controllers();
        new GameInit(_controllers, _data);
        _controllers?.Initialization();
    }
    
    
    private void Update()
    {
        var deltaTime = Time.deltaTime;
        _controllers?.Execute(deltaTime);
    }

    private void FixedUpdate()
    {
        var deltaTime = Time.deltaTime;
        _controllers?.FixedExecute(deltaTime);
    }

    private void LateUpdate()
    {
        var delta = Time.deltaTime;
        _controllers?.LateExecute(delta);
    }

    private void OnDestroy()
    {
        _controllers?.Cleanup();
    }
}
