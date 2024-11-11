using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Total_Audio : MonoBehaviour
{
    public GameObject[] Audio_Object;//저장기능을 위해 만듦...
    //public int BGM_Index;//저장기능을 위해 만듦...

    //public GameObject[] SFX_Object;//저장기능을 위해 만듦...
    //public int SFX_Index;//저장기능을 위해 만듦...

    //public SFX_2023 sfx_Manager;
    public BGM_2023 bgm;

    public GameObject menuSet;

    public GameObject main;


    private void Update()
    {


        if (Input.GetButtonDown("Cancel"))//ESC누르면 메뉴 보이도록
        {
            if (menuSet.activeSelf)//메뉴가 켜져 있다면
                menuSet.SetActive(false);//다시 꺼지도록
            else
                menuSet.SetActive(true);
        }

        if(main.activeSelf==true)
        {
            Audio_Object[0].gameObject.SetActive(true);//메뉴
            Audio_Object[1].gameObject.SetActive(false);//튜토리얼
            Audio_Object[2].gameObject.SetActive(false);//게임중
        }

        else if (main.activeSelf == false)
        {
            Audio_Object[0].gameObject.SetActive(false);//메뉴
            Audio_Object[1].gameObject.SetActive(false);//튜토리얼
            Audio_Object[2].gameObject.SetActive(true);//게임중

        }

        /*if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            Audio_Object[0].gameObject.SetActive(false);//메뉴
            Audio_Object[1].gameObject.SetActive(false);//튜토리얼
            Audio_Object[2].gameObject.SetActive(true);//게임중
        }

        else if (SceneManager.GetActiveScene().name == "Main")
        {
            return;
        }*/

    }

}
