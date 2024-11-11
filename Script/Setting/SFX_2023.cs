using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SFX_2023 : MonoBehaviour
{
    public Slider back_SFX_Volume;
    public AudioSource sfx1;//��ư�Ҹ�
    public AudioSource sfx2;//������ �Ҹ�
    public AudioSource sfx3;// �� �Ҹ�
    public AudioSource sfx4;// ���ڱ� �Ҹ�
    public AudioSource sfx5;// ���ڱ� �Ҹ�
    public AudioSource sfx6;// ���ڱ� �Ҹ�

    public Slider backVolume_1;


    public float back_SFX_Vol = 0.5001f;//���� private���µ� ������

    //public float B_Sound = 1.0f;

    void OnDisable()
    {
        back_SFX_Volume.value = back_SFX_Vol;

        back_SFX_Vol = PlayerPrefs.GetFloat("back_SFX_Vol", 0.5001f);

        sfx1.volume = back_SFX_Volume.value;
        sfx2.volume = back_SFX_Volume.value;
        sfx3.volume = back_SFX_Volume.value;
        sfx4.volume = back_SFX_Volume.value;
        sfx5.volume = back_SFX_Volume.value;
        sfx6.volume = back_SFX_Volume.value;


        Debug.Log("��ŸƮ�� ��ġ�� ȿ����(DisableGetFloat) ũ���" + back_SFX_Vol + "��.");

        //���� ���� 08.12
        backVolume_1.value = sfx1.volume;
        backVolume_1.value = sfx2.volume;
        backVolume_1.value = sfx3.volume;
        backVolume_1.value = sfx4.volume;
        backVolume_1.value = sfx5.volume;
        backVolume_1.value = sfx6.volume;
    }

    void OnEnable()
    {
       

        back_SFX_Volume.value = back_SFX_Vol;

        back_SFX_Vol = PlayerPrefs.GetFloat("back_SFX_Vol", 0.5001f);


        sfx1.volume = back_SFX_Volume.value;
        sfx2.volume = back_SFX_Volume.value;
        sfx3.volume = back_SFX_Volume.value;
        sfx4.volume = back_SFX_Volume.value;
        sfx5.volume = back_SFX_Volume.value;
        sfx6.volume = back_SFX_Volume.value;

        Debug.Log("��ŸƮ�� ��ġ�� ȿ����(EnableGetFloat) ũ���" + back_SFX_Vol + "��.");

        //���� ���� 08.12
        backVolume_1.value = sfx1.volume;
        backVolume_1.value = sfx2.volume;
        backVolume_1.value = sfx3.volume;
        backVolume_1.value = sfx4.volume;
        backVolume_1.value = sfx5.volume;
        backVolume_1.value = sfx6.volume;
    }


    void Start()
    {

      

        back_SFX_Volume.value = back_SFX_Vol;

        //���� �߰��غ� 08.12
        backVolume_1.value = back_SFX_Vol;

        back_SFX_Vol = PlayerPrefs.GetFloat("back_SFX_Vol", 0.5001f);

        sfx1.volume = back_SFX_Volume.value;
        sfx2.volume = back_SFX_Volume.value;
        sfx3.volume = back_SFX_Volume.value;
        sfx4.volume = back_SFX_Volume.value;
        sfx5.volume = back_SFX_Volume.value;
        sfx6.volume = back_SFX_Volume.value;

        Debug.Log("��ŸƮ�� ��ġ�� ȿ����(Start) ũ���" + back_SFX_Vol + "��.");

        //���� ���� 08.12
        backVolume_1.value = sfx1.volume;
        backVolume_1.value = sfx2.volume;
        backVolume_1.value = sfx3.volume;
        backVolume_1.value = sfx4.volume;
        backVolume_1.value = sfx5.volume;
        backVolume_1.value = sfx6.volume;
    }

    void Update()
    {
        SoundSlider();


    }

    public void SoundSlider()//�����̴� ����� �� �Լ�
    {
        

        back_SFX_Vol = back_SFX_Volume.value;


        sfx1.volume = back_SFX_Volume.value;
        sfx2.volume = back_SFX_Volume.value;
        sfx3.volume = back_SFX_Volume.value;
        sfx4.volume = back_SFX_Volume.value;
        sfx5.volume = back_SFX_Volume.value;
        sfx6.volume = back_SFX_Volume.value;

        //���� ���� 08.12
        back_SFX_Vol = backVolume_1.value;
        backVolume_1.value = sfx1.volume;
        backVolume_1.value = sfx2.volume;
        backVolume_1.value = sfx3.volume;
        backVolume_1.value = sfx4.volume;
        backVolume_1.value = sfx5.volume;
        backVolume_1.value = sfx6.volume;

        PlayerPrefs.SetFloat("back_SFX_Vol", back_SFX_Vol);
  

        PlayerPrefs.Save();
        Debug.Log("ȿ���� ũ���(SetFloat)" + back_SFX_Vol + "��.");


    }

    public void SFX_Button()
    {
        sfx1.Play();

    }

    public void SFX_Cup_Button()
    {
        sfx2.Play();

    }

    public void SFX_Trash_Button()
    {
        sfx3.Play();

    }

    public void SFX_Finsh_Coffee_Button()
    {
        sfx4.Play();

    }

    public void SFX_Player_Move_Button()
    {
        sfx5.Play();

    }

    public void SFX_Fail_Menu()
    {
        sfx6.Play();

    }
}
