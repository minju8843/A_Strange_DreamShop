using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Blue_Pink : MonoBehaviour
{
    public CameraZoom zoom;

    public GameObject Choose_Color;
    public GameObject Choose_Start_Color;

    public GameObject Plate;//색 선택에 따라 판을 회전시키기 위해 필요
    public RectTransform plate;//색 선택에 따라 판을 회전시키기 위해 필요

    public GameObject Start_Pink;//시작 토큰이 핑크냐
    public GameObject Start_Blue;//시작 토큰이 블루에 있어야 하느냐

    public Card_Move card_move;


    public GameObject[] Pink_Cups1;
    public GameObject[] Pink_Cups2;

    public GameObject[] Blue_Cups1;
    public GameObject[] Blue_Cups2;

    public Next_Turn next_turn;

    public SFX_2023 sfx;


    public GameObject blue;
    public GameObject pink;

    public Turn_Count turn_count;

    public GameObject Go_Black;
    public GameObject Go_Empty;

    public void Start()
    {
     
    }

    public void Pick_Pink()//내가 할 말 선택-핑크
    {
        Choose_Color.SetActive(false);//말 색상 선택화면 지우기
        Choose_Start_Color.SetActive(true);//어떤 색 먼저 시작할 건지 선택화면 나타내기

        sfx.SFX_Button();

    }

    public void Pink_Start()//어떤 색부터 먼저 시작할 건지-핑크
    {
        //Plate.transform.Rotate(0f, 0f, 180f);

        //PC에서는 실행되는 코드입니다
        //확대, 축소 코드
        /*zoom.isZoomedIn = false;//줌인 상태가 아님
        zoom.zoomCount = 0; //짝수번째
        zoom.ZoomOut();//줌 아웃
        */
        zoom.ResetToOriginalSize();


        Start_Pink.SetActive(true);//시작 토큰
        Start_Blue.SetActive(false);//시작 토큰

        Pink_Cups1[0].SetActive(false);//핑크 흰
        Pink_Cups1[1].SetActive(false);
        Pink_Cups1[2].SetActive(false);

        Pink_Cups2[0].SetActive(false);//핑크 분홍
        Pink_Cups2[1].SetActive(false);
        Pink_Cups2[2].SetActive(false);

        Blue_Cups1[0].SetActive(true);//블루 흰
        Blue_Cups1[1].SetActive(true);
        Blue_Cups1[2].SetActive(true);

        Blue_Cups2[0].SetActive(false);//블루 블루
        Blue_Cups2[1].SetActive(false);
        Blue_Cups2[2].SetActive(false);


        //Object_Place.Start_Pink();
        card_move.Start_Pink();

        StartCoroutine(Right_Pink());
        StartCoroutine(WaitSecond_1());
        StartCoroutine(WaitSecond_2());

        IEnumerator Right_Pink()
        {
            yield return new WaitForSeconds(0.0f);//0.5였음

            Go_Black.SetActive(true);//없음->검정//새로 추가

            //Choose_Start_Color.SetActive(false);

            next_turn.Go_Player2_B.SetActive(false);
            next_turn.Go_Player1_B.SetActive(true);

            sfx.SFX_Button();

            //0813
            blue.SetActive(true);
            pink.SetActive(false);


            //0814
            turn_count.Pink_1.SetActive(false);
            turn_count.Pink_2.SetActive(false);

            turn_count.Blue_1.SetActive(false);
            turn_count.Blue_2.SetActive(true);

        }

        IEnumerator WaitSecond_1()
        {
            yield return new WaitForSeconds(1.0f);
            Go_Empty.SetActive(true);//검정->없음
            Go_Black.SetActive(false);

            Choose_Start_Color.SetActive(false);//새로추가
        }

        IEnumerator WaitSecond_2()
        {
            yield return new WaitForSeconds(2.5f);
            Go_Empty.SetActive(false);//검정->없음
            Go_Black.SetActive(false);
        }

    }

    public void Pick_Blue()//내가 할 말 선택-블루
    {

        Choose_Color.SetActive(false);//말 색상 선택화면 지우기
        Choose_Start_Color.SetActive(true);

        sfx.SFX_Button();

    }

    public void Blue_Start()//어떤 색부터 먼저 시작할 건지-블루
    {
        //PC에서는 실행되는 코드입니다
        //확대, 축소 코드
        /*zoom.isZoomedIn = false;//줌인 상태가 아님
        zoom.zoomCount = 0; //짝수번째
        zoom.ZoomOut();//줌 아웃
        */
        zoom.ResetToOriginalSize();

        //0813
        Plate.transform.Rotate(0f, 0f, 180f);
        plate.anchoredPosition = new Vector2(0f, 12.9f);//15.6이었는디...

        Start_Pink.SetActive(false);
        Start_Blue.SetActive(true);

        //블루가 먼저면 게임 준비 시에는 핑크가 먼저 나와야 함
        Pink_Cups1[0].SetActive(true);//핑크 흰
        Pink_Cups1[1].SetActive(true);//핑크 흰
        Pink_Cups1[2].SetActive(true);//핑크 흰

        Pink_Cups2[0].SetActive(false);//핑크 핑크
        Pink_Cups2[1].SetActive(false);//핑크 핑크
        Pink_Cups2[2].SetActive(false);//핑크 핑크

        Blue_Cups1[0].SetActive(false);//블루 흰
        Blue_Cups1[1].SetActive(false);//블루 흰
        Blue_Cups1[2].SetActive(false);//블루 흰

        Blue_Cups2[0].SetActive(false);//블루 블루
        Blue_Cups2[1].SetActive(false);//블루 블루
        Blue_Cups2[2].SetActive(false);//블루 블루

        //Object_Place.Start_Blue();
        card_move.Start_Blue();

        StartCoroutine(Right_Blue());
        StartCoroutine(WaitSecond_1());
        StartCoroutine(WaitSecond_2());

        IEnumerator Right_Blue()
        {
            yield return new WaitForSeconds(0.0f);//0.5였음

            Go_Black.SetActive(true);//없음->검정

            //Choose_Start_Color.SetActive(false);

            next_turn.Go_Player1_B.SetActive(false);
            next_turn.Go_Player2_B.SetActive(true);

            sfx.SFX_Button();

            //0813
            blue.SetActive(false);
            pink.SetActive(true);

            //0814
            turn_count.Pink_1.SetActive(false);
            turn_count.Pink_2.SetActive(true);

            turn_count.Blue_1.SetActive(false);
            turn_count.Blue_2.SetActive(false);

        }

        IEnumerator WaitSecond_1()
        {
            yield return new WaitForSeconds(1.0f);
            Choose_Start_Color.SetActive(false);//새로추가

            Go_Empty.SetActive(true);//검정->없음
            Go_Black.SetActive(false);
        }

        IEnumerator WaitSecond_2()
        {
            yield return new WaitForSeconds(2.5f);
            Go_Empty.SetActive(false);//검정->없음
            Go_Black.SetActive(false);
        }

    }
}
