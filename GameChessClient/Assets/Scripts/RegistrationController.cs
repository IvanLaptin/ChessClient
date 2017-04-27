using NetworkLevel.Messages;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegistrationController : MonoBehaviour
{
    //public static Main main;

    public InputField mc_login;
    public InputField mc_name;
    public InputField mc_email;
    public InputField mc_password;
    public InputField mc_returnPassword;

    public GameObject mc_Current;
    public GameObject mc_Next;


    void Start ()
    {
        Client.currentClient.MessageReceived += CurrentClient_MessageReceived;
       // print(1);
        Main.main.Test();

	}

    private void CurrentClient_MessageReceived(NetworkLevel.User user, Message message)
    {
        switch (message.Type)
        {
            case MessageType.Registration:
                break;
            case MessageType.RegistrationAnswer:
                Main.main.RegAnswer((message as MessageRegistrationAnswer).Answer);
                break;
            case MessageType.LogIn:
                break;
            case MessageType.LogInAnswer:
                break;
            case MessageType.LogOut:
                break;
            case MessageType.StartGameWithTheBot:
                break;
            case MessageType.StartGameOnline:
                break;
            case MessageType.StartGameOnlineAnswer:
                break;
            case MessageType.Move:
                break;
            case MessageType.FinishGame:
                break;
            case MessageType.YourMove:
                break;
            case MessageType.GetGameTables:
                break;
            case MessageType.ChangePasswordSettings:
                break;
            case MessageType.Disconnect:
                break;
            default:
                break;
        }
    }


    public void f_Registration()
    {

        if (mc_login.text.Length > 0 && mc_name.text.Length > 0 && mc_email.text.Length > 0 &&
           mc_password.text.Length > 0 && mc_returnPassword.text.Length > 0)
        {
            Client.currentClient.Send(new MessageRegistration() {  Login = mc_login.text, Email = mc_email.text, FullName = mc_name.text, Password = mc_password.text});
        }
        
        else print("error");

    }


    public void f_goLogin()
    {
        mc_Current.SetActive(false);
        mc_Next.SetActive(true);
    }


}
