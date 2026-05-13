using Mirror;
using UnityEngine;

public class ServerLogic
{
    public void Init()
    {
        NetworkServer.RegisterHandler<SubscribeMessage>(OnSubscribe);
    }

    private void OnSubscribe(NetworkConnectionToClient conn, SubscribeMessage msg)
    {
        conn.Send(new HelloMessage
        {
            Text = "Hello Client!"
        });
        Debug.Log("Сообщение отправлено клиенту");
    }
}