using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Total_Audio : MonoBehaviour
{
    public GameObject[] Audio_Object;//�������� ���� ����...
    //public int BGM_Index;//�������� ���� ����...

    //public GameObject[] SFX_Object;//�������� ���� ����...
    //public int SFX_Index;//�������� ���� ����...

    //public SFX_2023 sfx_Manager;
    public BGM_2023 bgm;

    public GameObject menuSet;

    public GameObject main;


    private void Update()
    {


        if (Input.GetButtonDown("Cancel"))//ESC������ �޴� ���̵���
        {
            if (menuSet.activeSelf)//�޴��� ���� �ִٸ�
                menuSet.SetActive(false);//�ٽ� ��������
            else
                menuSet.SetActive(true);
        }

        if(main.activeSelf==true)
        {
            Audio_Object[0].gameObject.SetActive(true);//�޴�
            Audio_Object[1].gameObject.SetActive(false);//Ʃ�丮��
            Audio_Object[2].gameObject.SetActive(false);//������
        }

        else if (main.activeSelf == false)
        {
            Audio_Object[0].gameObject.SetActive(false);//�޴�
            Audio_Object[1].gameObject.SetActive(false);//Ʃ�丮��
            Audio_Object[2].gameObject.SetActive(true);//������

        }

        /*if (SceneManager.GetActiveScene().name == "SampleScene")
        {
            Audio_Object[0].gameObject.SetActive(false);//�޴�
            Audio_Object[1].gameObject.SetActive(false);//Ʃ�丮��
            Audio_Object[2].gameObject.SetActive(true);//������
        }

        else if (SceneManager.GetActiveScene().name == "Main")
        {
            return;
        }*/

    }

}
