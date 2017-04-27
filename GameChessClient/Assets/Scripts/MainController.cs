using NetworkLevel.Messages;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainController : MonoBehaviour
{

    public static MainController main;

    public MainController()
    {
        main = new MainController();

        var client = new Client();
        client.MessageReceived += Client_MessageReceived;

        client.Connect();
    }



    void Start()
    {

    }




    private void Client_MessageReceived(NetworkLevel.User user, NetworkLevel.Messages.Message message)
    {

        switch (message.Type)
        {
            case MessageType.Registration:
                break;
            case MessageType.RegistrationAnswer:
                //print("RegistrationAnswer - " + (message as MessageRegistrationAnswer));
                break;
            case MessageType.LogIn:
                break;
            case MessageType.LogInAnswer:
                //print("MessageLogInAnswer - " + (message as MessageLogInAnswer));
                break;
            default:
                break;
        }

    }

    public void Test()
    {

    }

}
