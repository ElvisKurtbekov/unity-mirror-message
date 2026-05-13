using Mirror;
using Zenject;
using UnityEngine;

public class ServerBootstrap : MonoBehaviour
{
    [Inject] private ServerLogic server;

    private void Start()
    {
        Debug.Log("Сервер запущен");
        NetworkManager.singleton.StartServer();
        server.Init();
    }
}