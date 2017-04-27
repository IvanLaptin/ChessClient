using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NetworkLevel;
using NetworkLevel.Messages;

public class Main : MonoBehaviour
{
    public static Main main;

    public bool registr = false;

    
	void Start ()
    {
        main = new Main();
        var client = new Client();

        client.MessageReceived += Client_MessageReceived;
        
        client.Connect();

        StartCoroutine(DoCheck());
    }

    IEnumerator DoCheck()
    {
        if(main.registr == true)
        {


            main.registr = false;
        }


        else yield return new WaitForSeconds(.1f);
    }

    public void Client_MessageReceived(NetworkLevel.User user, NetworkLevel.Messages.Message message)
    {
        
        if(message.Type == MessageType.Registration)
        {
            main.registr = true;
        }


        //switch (message.Type)
        //{
        //    case MessageType.Registration:
        //        break;
        //    case MessageType.RegistrationAnswer:
        //        //print("RegistrationAnswer - " + (message as MessageRegistrationAnswer));
        //        break;
        //    case MessageType.LogIn:
        //        break;
        //    case MessageType.LogInAnswer:
        //        //print("MessageLogInAnswer - " + (message as MessageLogInAnswer));
        //        break;
        //    default:
        //        break;
        //}

    }

}
