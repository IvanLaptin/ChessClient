using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RegistrationController : MonoBehaviour
{

    public InputField mc_login;
    public InputField mc_name;
    public InputField mc_email;
    public InputField mc_password;
    public InputField mc_returnPassword;

    void Start ()
    {
		
	}
	
	void Update ()
    {
		
	}


    public void f_Registration()
    {
        //Main.main.Test();

        if (mc_login.text.Length > 0 && mc_name.text.Length > 0 && mc_email.text.Length > 0 &&
           mc_password.text.Length > 0 && mc_returnPassword.text.Length > 0)
        {
            print(22);

        }

        else print("error");

    }



}
