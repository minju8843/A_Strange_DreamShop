using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SFX_2023 : MonoBehaviour
{
    public Slider back_SFX_Volume;
    public AudioSource sfx1;//버튼소리
    public AudioSource sfx2;//때리는 소리
    public AudioSource sfx3;// 벨 소리
    public AudioSource sfx4;// 발자국 소리
    public AudioSource sfx5;// 발자국 소리
    public AudioSource sfx6;// 발자국 소리

    public Slider backVolume_1;


    public float back_SFX_Vol = 0.5001f;//원래 private였는데 수정함

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


        Debug.Log("스타트에 위치한 효과음(DisableGetFloat) 크기는" + back_SFX_Vol + "다.");

        //새로 만듦 08.12
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

        Debug.Log("스타트에 위치한 효과음(EnableGetFloat) 크기는" + back_SFX_Vol + "다.");

        //새로 만듦 08.12
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

        //새로 추가해봄 08.12
        backVolume_1.value = back_SFX_Vol;

        back_SFX_Vol = PlayerPrefs.GetFloat("back_SFX_Vol", 0.5001f);

        sfx1.volume = back_SFX_Volume.value;
        sfx2.volume = back_SFX_Volume.value;
        sfx3.volume = back_SFX_Volume.value;
        sfx4.volume = back_SFX_Volume.value;
        sfx5.volume = back_SFX_Volume.value;
        sfx6.volume = back_SFX_Volume.value;

        Debug.Log("스타트에 위치한 효과음(Start) 크기는" + back_SFX_Vol + "다.");

        //새로 만듦 08.12
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

    public void SoundSlider()//슬라이더 기능이 될 함수
    {
        

        back_SFX_Vol = back_SFX_Volume.value;


        sfx1.volume = back_SFX_Volume.value;
        sfx2.volume = back_SFX_Volume.value;
        sfx3.volume = back_SFX_Volume.value;
        sfx4.volume = back_SFX_Volume.value;
        sfx5.volume = back_SFX_Volume.value;
        sfx6.volume = back_SFX_Volume.value;

        //새로 만듦 08.12
        back_SFX_Vol = backVolume_1.value;
        backVolume_1.value = sfx1.volume;
        backVolume_1.value = sfx2.volume;
        backVolume_1.value = sfx3.volume;
        backVolume_1.value = sfx4.volume;
        backVolume_1.value = sfx5.volume;
        backVolume_1.value = sfx6.volume;

        PlayerPrefs.SetFloat("back_SFX_Vol", back_SFX_Vol);
  

        PlayerPrefs.Save();
        Debug.Log("효과음 크기는(SetFloat)" + back_SFX_Vol + "다.");


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
