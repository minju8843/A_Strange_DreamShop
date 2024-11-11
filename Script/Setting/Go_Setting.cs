using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Go_Setting : MonoBehaviour
{

    public GameObject Setting;

    public void Let_Go_Setting()
    {
        Setting.SetActive(true);
    }

    public void go_Back_Game()
    {
        Setting.SetActive(false);
    }
}
