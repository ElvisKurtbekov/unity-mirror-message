using Mirror;
using UnityEngine;

public class ClientBootstrap : MonoBehaviour
{
    private void Start()
    {
        Debug.Log("Клиент запущен");
        NetworkClient.RegisterHandler<HelloMessage>(OnHello);
        NetworkManager.singleton.StartClient();
        NetworkClient.OnConnectedEvent += OnConnected;
    }

    private void OnConnected()
    {
        Debug.Log("Клиент подключился к серверу");
        NetworkClient.Send(new SubscribeMessage());
    }

    private void OnHello(HelloMessage msg)
    {
        Debug.Log("Получено сообщение от сервера: " + msg.Text);
    }
}