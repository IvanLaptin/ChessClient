using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackButton : MonoBehaviour
{
    public GameObject mc_Current;
    public GameObject mc_Next;

    public void f_NextMenuButton()
    {
        mc_Current.SetActive(false);
        mc_Next.SetActive(true);
    }
    

}
