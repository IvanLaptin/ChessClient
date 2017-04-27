using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using NetworkLevel;
using NetworkLevel.Messages;

public class Main : MonoBehaviour
{
    public static Main main;

    public bool registr;
    public bool registrAnswer;

    void Start ()
    {
        main = new Main();
        Client.currentClient = new Client();
        Client.currentClient.Connect();

        StartCoroutine(DoCheck());
    }

    IEnumerator DoCheck()
    {
        while (true)
        {

            if (main.registr == true)
            {
                print(3);
                main.registr = false;
            }
            else if(main.registrAnswer == true)
            {
                main.registrAnswer = false;
            }

            yield return null;

        }
        
    }

    public void Test()
    {
        print(2);
        
        
        main.registr = true;
    }


    public void RegAnswer(bool Reason)
    {
        print(Reason);

        main.registrAnswer = true;
    }

}
