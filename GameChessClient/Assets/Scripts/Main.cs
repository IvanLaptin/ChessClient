using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NetworkLevel;
using NetworkLevel.Messages;

public class Main
{
    public static Main main;

    public Main()
    {
        main = new Main();

        var client = new Client();
        client.MessageReceived += Client_MessageReceived;

        client.Connect();
    }   


    
	void Start ()
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
