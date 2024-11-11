using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turn_Count : MonoBehaviour
{
    public Text Button_Click;
    public int Click_Count;//몇번째 턴인지 확인


    public GameObject[] objects;


    public GameObject Open_Pink;
    public GameObject Close_Pink;

    public GameObject Open_Blue;
    public GameObject Close_Blue;


    public GameObject Blue_Material_Canvas;
    public GameObject Pink_Material_Canvas;

    public Player_Move_Count move_count;

    public GameObject Pink_1;
    public GameObject Pink_2;
    public GameObject Blue_1;
    public GameObject Blue_2;

    public Blue_Pink blue_pink;

    public GameObject Good_Bad_Pink_1;
    public GameObject Good_Bad_Pink_2;

    public GameObject Good_Bad_Blue_1;
    public GameObject Good_Bad_Blue_2;

    public GameObject Coin_Pink_1;

    public GameObject Coin_Blue_1;

    public Cup cup;

    public Card_Move card_move;

    public Good_Bad good_bad;

    public Move_Player move_player;

    public SFX_2023 sfx;

    public Next_Turn next_turn;




    void Start()
    {
        Click_Count = 0;
        UpdateClickCountText();
    }



    private void Update()
    {




        if (Open_Pink.activeSelf == true || Close_Pink.activeSelf == true)//핑크가 시작
        {
            //Open_Pink.activeSelf==true || Close_Pink.activeSelf == true 이거였음

            //짝수인데 0인 경우
            //바로 나타나게

            //짝수인데 0이 아닌 경우
            //3초 뒤에 실행되도록

            //짝수 번째 클릭했는데 각도가 0, 0, 180이라면 핑크는 나타내고 파랑은 지우기
            if (Click_Count % 2 == 0 && Click_Count != 0 && Click_Count != 2 && Click_Count != 4)//짝수일 때
            {

                blue_pink.Pink_Cups1[0].SetActive(true);
                blue_pink.Pink_Cups1[1].SetActive(true);
                blue_pink.Pink_Cups1[2].SetActive(true);

                blue_pink.Pink_Cups2[0].SetActive(false);
                blue_pink.Pink_Cups2[1].SetActive(false);
                blue_pink.Pink_Cups2[2].SetActive(false);

                blue_pink.Blue_Cups1[0].SetActive(false);
                blue_pink.Blue_Cups1[1].SetActive(false);
                blue_pink.Blue_Cups1[2].SetActive(false);

                blue_pink.Blue_Cups2[0].SetActive(false);
                blue_pink.Blue_Cups2[1].SetActive(false);
                blue_pink.Blue_Cups2[2].SetActive(false);



                StartCoroutine(Go_Next1());


                IEnumerator Go_Next1()
                {
                    yield return new WaitForSeconds(0.5f);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);



                    //이건 PC일때만 적용되는 코드...
                    /*BoxCollider2D boxCollider1 = objects[0].GetComponent<BoxCollider2D>();//핑크1 콜라이더
                    boxCollider1.enabled = true;

                    BoxCollider2D boxCollider2 = objects[1].GetComponent<BoxCollider2D>();//핑크2 콜라이더
                    boxCollider2.enabled = true;

                    BoxCollider2D boxCollider3 = objects[2].GetComponent<BoxCollider2D>();//파랑1 콜라이더
                    boxCollider3.enabled = false;

                    BoxCollider2D boxCollider4 = objects[3].GetComponent<BoxCollider2D>();//파랑2 콜라이더
                    boxCollider4.enabled = false;*/

                    //파랑 재료 칸을 false하고 

                    //분홍 재료 칸을 true로 만들기
                    /*Blue_Material_Canvas.SetActive(false);
                    Pink_Material_Canvas.SetActive(true);

                    Good_Bad_Blue.SetActive(false);
                    Good_Bad_Pink.SetActive(true);

                    Coin_Blue.SetActive(false);
                    Coin_Pink.SetActive(true);*/






                }



                if (move_count.Can_Move_Count == 0)//플레이어가 움직일 수 있는 수가 0이라면
                {
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);
                    /*BoxCollider2D boxCollider5 = objects[0].GetComponent<BoxCollider2D>();//핑크1 콜라이더
                    boxCollider5.enabled = false;

                    BoxCollider2D boxCollider6 = objects[1].GetComponent<BoxCollider2D>();//핑크2 콜라이더
                    boxCollider6.enabled = false;

                    BoxCollider2D boxCollider7 = objects[2].GetComponent<BoxCollider2D>();//파랑1 콜라이더
                    boxCollider7.enabled = false;

                    BoxCollider2D boxCollider8 = objects[3].GetComponent<BoxCollider2D>();//파랑2 콜라이더
                    boxCollider8.enabled = false;*/
                }




            }

            //07.28추가해봄
            else if (Click_Count != 0 && Click_Count != 2 && Click_Count == 4)//짝수일 때, 4일 때만
            {
                Debug.Log("핑크가 선일때 4라면");

                Blue_Material_Canvas.SetActive(false);
                Pink_Material_Canvas.SetActive(true);

                Good_Bad_Blue_1.SetActive(false);
                Good_Bad_Blue_2.SetActive(false);

                Good_Bad_Pink_1.SetActive(true);
                Good_Bad_Pink_2.SetActive(true);

                Coin_Blue_1.SetActive(false);


                Coin_Pink_1.SetActive(true);
             

                Blue_1.SetActive(false);//파랑 선택됨 표시
                Blue_2.SetActive(false);//파랑 선택됨 표시

                blue_pink.Pink_Cups1[0].SetActive(true);
                blue_pink.Pink_Cups1[1].SetActive(true);
                blue_pink.Pink_Cups1[2].SetActive(true);

                blue_pink.Pink_Cups2[0].SetActive(false);
                blue_pink.Pink_Cups2[1].SetActive(false);
                blue_pink.Pink_Cups2[2].SetActive(false);

                blue_pink.Blue_Cups1[0].SetActive(false);
                blue_pink.Blue_Cups1[1].SetActive(false);
                blue_pink.Blue_Cups1[2].SetActive(false);

                blue_pink.Blue_Cups2[0].SetActive(false);
                blue_pink.Blue_Cups2[1].SetActive(false);
                blue_pink.Blue_Cups2[2].SetActive(false);


                next_turn.Go_Player1_B.SetActive(false);//블루 턴 끝내기
                next_turn.Go_Player2_B.SetActive(true);//핑크 턴 끝내기

                //next_turn.Rotate_board.transform.Rotate(0f, 0f, 180f);
                // 현재 위치를 (0, 15.6)으로 변경
                //next_turn.board.anchoredPosition = new Vector2(0f, 12.9f);//15.6였는디


                next_turn.blue.SetActive(false);//블루 
                next_turn.pink.SetActive(true);//핑크 

                //핑크가 오른쪽에 오도록

                //blue_pink.Plate.transform.Rotate(0f, 0f, 180f);
                // blue_pink.plate.anchoredPosition = new Vector2(0f, 12.9f);//15.6이었는디...


                if (move_count.Can_Move_Count == 0)//플레이어가 움직일 수 있는 수가 0이라면
                {
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);



                }




            }

            else if (Click_Count == 0 && Click_Count != 4)//짝수일 때, 0, 2일때만
            {//파랑이가 먼저임
                Blue_Material_Canvas.SetActive(true);
                Pink_Material_Canvas.SetActive(false);

                Good_Bad_Blue_1.SetActive(true);
                Good_Bad_Blue_2.SetActive(true);

                Good_Bad_Pink_1.SetActive(false);
                Good_Bad_Pink_2.SetActive(false);

                Coin_Blue_1.SetActive(true);
               

                Coin_Pink_1.SetActive(false);
         

                Pink_1.SetActive(false);//파랑 선택됨 표시
                Pink_2.SetActive(false);//파랑 선택됨 표시

                Blue_1.SetActive(false);//파랑 선택됨 표시
                Blue_2.SetActive(true);//0일때

                blue_pink.Pink_Cups1[0].SetActive(false);
                blue_pink.Pink_Cups1[1].SetActive(false);
                blue_pink.Pink_Cups1[2].SetActive(false);

                blue_pink.Pink_Cups2[0].SetActive(false);
                blue_pink.Pink_Cups2[1].SetActive(false);
                blue_pink.Pink_Cups2[2].SetActive(false);

                blue_pink.Blue_Cups1[0].SetActive(true);
                blue_pink.Blue_Cups1[1].SetActive(true);
                blue_pink.Blue_Cups1[2].SetActive(true);

                blue_pink.Blue_Cups2[0].SetActive(false);
                blue_pink.Blue_Cups2[1].SetActive(false);
                blue_pink.Blue_Cups2[2].SetActive(false);


                if (move_count.Can_Move_Count == 0)//플레이어가 움직일 수 있는 수가 0이라면
                {
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                }




            }

            else if (Click_Count == 2 && Click_Count != 4)//짝수일 때, 0, 2일때만
            {//파랑이가 먼저임
                Blue_Material_Canvas.SetActive(true);
                Pink_Material_Canvas.SetActive(false);

                Good_Bad_Blue_1.SetActive(true);
                Good_Bad_Blue_2.SetActive(true);

                Good_Bad_Pink_1.SetActive(false);
                Good_Bad_Pink_2.SetActive(false);

                Coin_Blue_1.SetActive(true);
            

                Coin_Pink_1.SetActive(false);
            

                Pink_1.SetActive(false);//파랑 선택됨 표시
                Pink_2.SetActive(false);//파랑 선택됨 표시

                Blue_1.SetActive(true);//파랑 선택됨 표시
                Blue_2.SetActive(false);//2일때

                blue_pink.Pink_Cups1[0].SetActive(false);
                blue_pink.Pink_Cups1[1].SetActive(false);
                blue_pink.Pink_Cups1[2].SetActive(false);

                blue_pink.Pink_Cups2[0].SetActive(false);
                blue_pink.Pink_Cups2[1].SetActive(false);
                blue_pink.Pink_Cups2[2].SetActive(false);

                blue_pink.Blue_Cups1[0].SetActive(true);
                blue_pink.Blue_Cups1[1].SetActive(true);
                blue_pink.Blue_Cups1[2].SetActive(true);

                blue_pink.Blue_Cups2[0].SetActive(false);
                blue_pink.Blue_Cups2[1].SetActive(false);
                blue_pink.Blue_Cups2[2].SetActive(false);


                if (move_count.Can_Move_Count == 0)//플레이어가 움직일 수 있는 수가 0이라면
                {
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                }




            }

            //여긴 원래 있던 거
            else if (Click_Count % 2 != 0 && Click_Count != 1 && Click_Count != 3)//홀수일 때
            {

                blue_pink.Pink_Cups1[0].SetActive(false);
                blue_pink.Pink_Cups1[1].SetActive(false);
                blue_pink.Pink_Cups1[2].SetActive(false);

                blue_pink.Pink_Cups2[0].SetActive(false);
                blue_pink.Pink_Cups2[1].SetActive(false);
                blue_pink.Pink_Cups2[2].SetActive(false);

                blue_pink.Blue_Cups1[0].SetActive(true);
                blue_pink.Blue_Cups1[1].SetActive(true);
                blue_pink.Blue_Cups1[2].SetActive(true);

                blue_pink.Blue_Cups2[0].SetActive(false);
                blue_pink.Blue_Cups2[1].SetActive(false);
                blue_pink.Blue_Cups2[2].SetActive(false);
                StartCoroutine(Go_Next1());




                IEnumerator Go_Next1()
                {
                    yield return new WaitForSeconds(0.5f);
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);




                    /*BoxCollider2D boxCollider1 = objects[0].GetComponent<BoxCollider2D>();//핑크1 콜라이더
                    boxCollider1.enabled = false;

                    BoxCollider2D boxCollider2 = objects[1].GetComponent<BoxCollider2D>();//핑크2 콜라이더
                    boxCollider2.enabled = false;

                    BoxCollider2D boxCollider3 = objects[2].GetComponent<BoxCollider2D>();//파랑1 콜라이더
                    boxCollider3.enabled = true;

                    BoxCollider2D boxCollider4 = objects[3].GetComponent<BoxCollider2D>();//파랑2 콜라이더
                    boxCollider4.enabled = true;*/

                    //파랑 재료 칸을 true하고 
                    //분홍 재료 칸을 false로 만들기

                    /*Blue_Material_Canvas.SetActive(true);
                    Pink_Material_Canvas.SetActive(false);

                    Good_Bad_Blue.SetActive(true);
                    Good_Bad_Pink.SetActive(false);

                    Coin_Blue.SetActive(true);
                    Coin_Pink.SetActive(false);*/


                }






                if (move_count.Can_Move_Count == 0)//플레이어가 움직일 수 있는 수가 0이라면
                {
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                    /* BoxCollider2D boxCollider5 = objects[0].GetComponent<BoxCollider2D>();//핑크1 콜라이더
                     boxCollider5.enabled = false;

                     BoxCollider2D boxCollider6 = objects[1].GetComponent<BoxCollider2D>();//핑크2 콜라이더
                     boxCollider6.enabled = false;

                     BoxCollider2D boxCollider7 = objects[2].GetComponent<BoxCollider2D>();//파랑1 콜라이더
                     boxCollider7.enabled = false;

                     BoxCollider2D boxCollider8 = objects[3].GetComponent<BoxCollider2D>();//파랑2 콜라이더
                     boxCollider8.enabled = false;*/
                }


            }

            //07.28.추가해봄
            else if (Click_Count == 1)//홀수일 때
            {//분홍이 차례임

                Blue_1.SetActive(false);
                Blue_2.SetActive(false);

                Pink_1.SetActive(false);
                Pink_2.SetActive(true);

                //파랑 재료 칸을 true하고 
                //분홍 재료 칸을 false로 만들기

                Blue_Material_Canvas.SetActive(false);
                Pink_Material_Canvas.SetActive(true);

                Good_Bad_Blue_1.SetActive(false);
                Good_Bad_Blue_2.SetActive(false);

                Good_Bad_Pink_1.SetActive(true);
                Good_Bad_Pink_2.SetActive(true);

                Coin_Blue_1.SetActive(false);
                

                Coin_Pink_1.SetActive(true);
         

                blue_pink.Pink_Cups1[0].SetActive(true);
                blue_pink.Pink_Cups1[1].SetActive(true);
                blue_pink.Pink_Cups1[2].SetActive(true);

                blue_pink.Pink_Cups2[0].SetActive(false);
                blue_pink.Pink_Cups2[1].SetActive(false);
                blue_pink.Pink_Cups2[2].SetActive(false);

                blue_pink.Blue_Cups1[0].SetActive(false);
                blue_pink.Blue_Cups1[1].SetActive(false);
                blue_pink.Blue_Cups1[2].SetActive(false);

                blue_pink.Blue_Cups2[0].SetActive(false);
                blue_pink.Blue_Cups2[1].SetActive(false);
                blue_pink.Blue_Cups2[2].SetActive(false);

                if (move_count.Can_Move_Count == 0)//플레이어가 움직일 수 있는 수가 0이라면
                {
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                }


            }

            else if (Click_Count == 3)//홀수일 때
            {//분홍이 차례임



                Blue_1.SetActive(false);
                Blue_2.SetActive(false);

                Pink_1.SetActive(true);
                Pink_2.SetActive(false);

                //파랑 재료 칸을 true하고 
                //분홍 재료 칸을 false로 만들기

                Blue_Material_Canvas.SetActive(false);
                Pink_Material_Canvas.SetActive(true);

                Good_Bad_Blue_1.SetActive(false);
                Good_Bad_Blue_2.SetActive(false);

                Good_Bad_Pink_1.SetActive(true);
                Good_Bad_Pink_2.SetActive(true);

                Coin_Blue_1.SetActive(false);
            

                Coin_Pink_1.SetActive(true);
          

                blue_pink.Pink_Cups1[0].SetActive(true);
                blue_pink.Pink_Cups1[1].SetActive(true);
                blue_pink.Pink_Cups1[2].SetActive(true);

                blue_pink.Pink_Cups2[0].SetActive(false);
                blue_pink.Pink_Cups2[1].SetActive(false);
                blue_pink.Pink_Cups2[2].SetActive(false);

                blue_pink.Blue_Cups1[0].SetActive(false);
                blue_pink.Blue_Cups1[1].SetActive(false);
                blue_pink.Blue_Cups1[2].SetActive(false);

                blue_pink.Blue_Cups2[0].SetActive(false);
                blue_pink.Blue_Cups2[1].SetActive(false);
                blue_pink.Blue_Cups2[2].SetActive(false);

                if (move_count.Can_Move_Count == 0)//플레이어가 움직일 수 있는 수가 0이라면
                {
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                }


            }
        }

        if (Open_Blue.activeSelf == true || Close_Blue.activeSelf == true)//블루가 시작
        {
            //Open_Blue.activeSelf == true || Close_Blue.activeSelf == true 이거였음

            //짝수번째 클릭했는데 각도가 0, 0, 0이라면 파랑이 나타내고 분홍 지우기
            if (Click_Count % 2 == 0 && Click_Count != 0 && Click_Count != 2 && Click_Count != 4)//짝수일 때
            {
                blue_pink.Pink_Cups1[0].SetActive(false);
                blue_pink.Pink_Cups1[1].SetActive(false);
                blue_pink.Pink_Cups1[2].SetActive(false);

                blue_pink.Pink_Cups2[0].SetActive(false);
                blue_pink.Pink_Cups2[1].SetActive(false);
                blue_pink.Pink_Cups2[2].SetActive(false);

                blue_pink.Blue_Cups1[0].SetActive(true);
                blue_pink.Blue_Cups1[1].SetActive(true);
                blue_pink.Blue_Cups1[2].SetActive(true);

                blue_pink.Blue_Cups2[0].SetActive(false);
                blue_pink.Blue_Cups2[1].SetActive(false);
                blue_pink.Blue_Cups2[2].SetActive(false);

                StartCoroutine(Go_Next1());


                IEnumerator Go_Next1()
                {
                    yield return new WaitForSeconds(0.5f);
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);



                    /*BoxCollider2D boxCollider1 = objects[0].GetComponent<BoxCollider2D>();//핑크1 콜라이더
                    boxCollider1.enabled = false;

                    BoxCollider2D boxCollider2 = objects[1].GetComponent<BoxCollider2D>();//핑크2 콜라이더
                    boxCollider2.enabled = false;

                    BoxCollider2D boxCollider3 = objects[2].GetComponent<BoxCollider2D>();//파랑1 콜라이더
                    boxCollider3.enabled = true;

                    BoxCollider2D boxCollider4 = objects[3].GetComponent<BoxCollider2D>();//파랑2 콜라이더
                    boxCollider4.enabled = true;*/

                    //파랑 재료 칸을 true하고 
                    //분홍 재료 칸을 false로 만들기

                    /* Blue_Material_Canvas.SetActive(true);
                     Pink_Material_Canvas.SetActive(false);

                     Good_Bad_Blue.SetActive(true);
                     Good_Bad_Pink.SetActive(false);

                     Coin_Blue.SetActive(true);
                     Coin_Pink.SetActive(false);*/


                }




                if (move_count.Can_Move_Count == 0)//플레이어가 움직일 수 있는 수가 0이라면
                {
                    /*BoxCollider2D boxCollider5 = objects[0].GetComponent<BoxCollider2D>();//핑크1 콜라이더
                    boxCollider5.enabled = false;

                    BoxCollider2D boxCollider6 = objects[1].GetComponent<BoxCollider2D>();//핑크2 콜라이더
                    boxCollider6.enabled = false;

                    BoxCollider2D boxCollider7 = objects[2].GetComponent<BoxCollider2D>();//파랑1 콜라이더
                    boxCollider7.enabled = false;

                    BoxCollider2D boxCollider8 = objects[3].GetComponent<BoxCollider2D>();//파랑2 콜라이더
                    boxCollider8.enabled = false;*/

                    Pink_1.SetActive(false);//빨강 선택됨 표시
                    Pink_2.SetActive(false);//빨강 선택됨 표시
                    Blue_1.SetActive(false);//파랑 선택됨 표시
                    Blue_2.SetActive(false);//파랑 선택됨 표시
                }
            }

            //07.28.추가해봄
            if (Click_Count != 0 && Click_Count != 2 && Click_Count == 4 && Click_Count % 2 == 0)//짝수일 때, 4일때만
            {
                Pink_1.SetActive(false);//빨강 선택됨 표시
                Pink_2.SetActive(false);//빨강 선택됨 표시

                Blue_Material_Canvas.SetActive(true);
                Pink_Material_Canvas.SetActive(false);

                Good_Bad_Blue_1.SetActive(true);
                Good_Bad_Blue_2.SetActive(true);

                Good_Bad_Pink_1.SetActive(false);
                Good_Bad_Pink_2.SetActive(false);

                Coin_Blue_1.SetActive(true);
            

                Coin_Pink_1.SetActive(false);
           

                blue_pink.Pink_Cups1[0].SetActive(false);
                blue_pink.Pink_Cups1[1].SetActive(false);
                blue_pink.Pink_Cups1[2].SetActive(false);

                blue_pink.Pink_Cups2[0].SetActive(false);
                blue_pink.Pink_Cups2[1].SetActive(false);
                blue_pink.Pink_Cups2[2].SetActive(false);

                blue_pink.Blue_Cups1[0].SetActive(true);
                blue_pink.Blue_Cups1[1].SetActive(true);
                blue_pink.Blue_Cups1[2].SetActive(true);

                blue_pink.Blue_Cups2[0].SetActive(false);
                blue_pink.Blue_Cups2[1].SetActive(false);
                blue_pink.Blue_Cups2[2].SetActive(false);

                next_turn.Go_Player1_B.SetActive(true);//블루 턴 끝내기
                next_turn.Go_Player2_B.SetActive(false);//핑크 턴 끝내기

                next_turn.blue.SetActive(true);//블루 
                next_turn.pink.SetActive(false);//핑크 

                // next_turn.Rotate_board.transform.Rotate(0f, 0f, 180f);
                // 현재 위치를 (0, 15.6)으로 변경
                //next_turn.board.anchoredPosition = new Vector2(0f, 0f);//15.6였는디

                if (move_count.Can_Move_Count == 0)//플레이어가 움직일 수 있는 수가 0이라면
                {

                    Pink_1.SetActive(false);//빨강 선택됨 표시
                    Pink_2.SetActive(false);//빨강 선택됨 표시
                    Blue_1.SetActive(false);//파랑 선택됨 표시
                    Blue_2.SetActive(false);//파랑 선택됨 표시


                }

            }



            //4 아닐때
            else if (Click_Count == 0 && Click_Count != 4)
            {//분홍이 가 실행되도록
                Blue_1.SetActive(false);//빨강 선택됨 표시
                Blue_2.SetActive(false);//빨강 선택됨 표시

                Pink_1.SetActive(false);//빨강 선택됨 표시
                Pink_2.SetActive(true);//빨강 선택됨 표시

                Blue_Material_Canvas.SetActive(false);
                Pink_Material_Canvas.SetActive(true);

                Good_Bad_Blue_1.SetActive(false);
                Good_Bad_Blue_2.SetActive(false);

                Good_Bad_Pink_1.SetActive(true);
                Good_Bad_Pink_2.SetActive(true);

                Coin_Blue_1.SetActive(false);
        

                Coin_Pink_1.SetActive(true);
       

                blue_pink.Pink_Cups1[0].SetActive(true);
                blue_pink.Pink_Cups1[1].SetActive(true);
                blue_pink.Pink_Cups1[2].SetActive(true);

                blue_pink.Pink_Cups2[0].SetActive(false);
                blue_pink.Pink_Cups2[1].SetActive(false);
                blue_pink.Pink_Cups2[2].SetActive(false);

                blue_pink.Blue_Cups1[0].SetActive(false);
                blue_pink.Blue_Cups1[1].SetActive(false);
                blue_pink.Blue_Cups1[2].SetActive(false);

                blue_pink.Blue_Cups2[0].SetActive(false);
                blue_pink.Blue_Cups2[1].SetActive(false);
                blue_pink.Blue_Cups2[2].SetActive(false);



                if (move_count.Can_Move_Count == 0)//플레이어가 움직일 수 있는 수가 0이라면
                {

                    Pink_1.SetActive(false);//빨강 선택됨 표시
                    Pink_2.SetActive(false);//빨강 선택됨 표시
                    Blue_1.SetActive(false);//파랑 선택됨 표시
                    Blue_2.SetActive(false);//파랑 선택됨 표시
                }

            }

            if (Click_Count == 2 && Click_Count != 4)
            {//분홍이 가 실행되도록
                Blue_1.SetActive(false);//빨강 선택됨 표시
                Blue_2.SetActive(false);//빨강 선택됨 표시

                Pink_1.SetActive(true);//빨강 선택됨 표시
                Pink_2.SetActive(false);//빨강 선택됨 표시

                Blue_Material_Canvas.SetActive(false);
                Pink_Material_Canvas.SetActive(true);

                Good_Bad_Blue_1.SetActive(false);
                Good_Bad_Blue_2.SetActive(false);

                Good_Bad_Pink_1.SetActive(true);
                Good_Bad_Pink_2.SetActive(true);

                Coin_Blue_1.SetActive(false);
     

                Coin_Pink_1.SetActive(true);
             

                blue_pink.Pink_Cups1[0].SetActive(true);
                blue_pink.Pink_Cups1[1].SetActive(true);
                blue_pink.Pink_Cups1[2].SetActive(true);

                blue_pink.Pink_Cups2[0].SetActive(false);
                blue_pink.Pink_Cups2[1].SetActive(false);
                blue_pink.Pink_Cups2[2].SetActive(false);

                blue_pink.Blue_Cups1[0].SetActive(false);
                blue_pink.Blue_Cups1[1].SetActive(false);
                blue_pink.Blue_Cups1[2].SetActive(false);

                blue_pink.Blue_Cups2[0].SetActive(false);
                blue_pink.Blue_Cups2[1].SetActive(false);
                blue_pink.Blue_Cups2[2].SetActive(false);



                if (move_count.Can_Move_Count == 0)//플레이어가 움직일 수 있는 수가 0이라면
                {

                    Pink_1.SetActive(false);//빨강 선택됨 표시
                    Pink_2.SetActive(false);//빨강 선택됨 표시
                    Blue_1.SetActive(false);//파랑 선택됨 표시
                    Blue_2.SetActive(false);//파랑 선택됨 표시
                }

            }

            //여긴 원래 있던 거
            else if (Click_Count % 2 != 0 && Click_Count != 1 && Click_Count != 3)//홀수일 때
            {
                blue_pink.Pink_Cups1[0].SetActive(true);
                blue_pink.Pink_Cups1[1].SetActive(true);
                blue_pink.Pink_Cups1[2].SetActive(true);

                blue_pink.Pink_Cups2[0].SetActive(false);
                blue_pink.Pink_Cups2[1].SetActive(false);
                blue_pink.Pink_Cups2[2].SetActive(false);

                blue_pink.Blue_Cups1[0].SetActive(false);
                blue_pink.Blue_Cups1[1].SetActive(false);
                blue_pink.Blue_Cups1[2].SetActive(false);

                blue_pink.Blue_Cups2[0].SetActive(false);
                blue_pink.Blue_Cups2[1].SetActive(false);
                blue_pink.Blue_Cups2[2].SetActive(false);

                StartCoroutine(Go_Next1());


                IEnumerator Go_Next1()
                {
                    yield return new WaitForSeconds(0.5f);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);



                    /*BoxCollider2D boxCollider1 = objects[0].GetComponent<BoxCollider2D>();//핑크1 콜라이더
                    boxCollider1.enabled = true;

                    BoxCollider2D boxCollider2 = objects[1].GetComponent<BoxCollider2D>();//핑크2 콜라이더
                    boxCollider2.enabled = true;

                    BoxCollider2D boxCollider3 = objects[2].GetComponent<BoxCollider2D>();//파랑1 콜라이더
                    boxCollider3.enabled = false;

                    BoxCollider2D boxCollider4 = objects[3].GetComponent<BoxCollider2D>();//파랑2 콜라이더
                    boxCollider4.enabled = false;*/

                    //파랑 재료 칸을 false하고 
                    //분홍 재료 칸을 true로 만들기

                    /*Blue_Material_Canvas.SetActive(false);
                     Pink_Material_Canvas.SetActive(true);

                     Good_Bad_Blue.SetActive(false);
                     Good_Bad_Pink.SetActive(true);

                     Coin_Blue.SetActive(false);
                     Coin_Pink.SetActive(true);*/


                }




                if (move_count.Can_Move_Count == 0)//플레이어가 움직일 수 있는 수가 0이라면
                {
                    /*BoxCollider2D boxCollider5 = objects[0].GetComponent<BoxCollider2D>();//핑크1 콜라이더
                    boxCollider5.enabled = false;

                    BoxCollider2D boxCollider6 = objects[1].GetComponent<BoxCollider2D>();//핑크2 콜라이더
                    boxCollider6.enabled = false;

                    BoxCollider2D boxCollider7 = objects[2].GetComponent<BoxCollider2D>();//파랑1 콜라이더
                    boxCollider7.enabled = false;

                    BoxCollider2D boxCollider8 = objects[3].GetComponent<BoxCollider2D>();//파랑2 콜라이더
                    boxCollider8.enabled = false;*/

                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);
                }



            }

            //07.28.새로 추가
            else if (Click_Count == 1 && Click_Count != 3)//홀수일 때
            {
                //파랑이가 실행되어야 함
                Pink_1.SetActive(false);
                Pink_2.SetActive(false);

                Pink_1.SetActive(false);
                Pink_2.SetActive(true);

                //파랑 재료 칸을 false하고 
                //분홍 재료 칸을 true로 만들기

                Blue_Material_Canvas.SetActive(true);
                Pink_Material_Canvas.SetActive(false);

                Good_Bad_Blue_1.SetActive(true);
                Good_Bad_Blue_2.SetActive(true);

                Good_Bad_Pink_1.SetActive(false);
                Good_Bad_Pink_2.SetActive(false);

                Coin_Blue_1.SetActive(true);
               

                Coin_Pink_1.SetActive(false);
               

                blue_pink.Pink_Cups1[0].SetActive(false);
                blue_pink.Pink_Cups1[1].SetActive(false);
                blue_pink.Pink_Cups1[2].SetActive(false);

                blue_pink.Pink_Cups2[0].SetActive(false);
                blue_pink.Pink_Cups2[1].SetActive(false);
                blue_pink.Pink_Cups2[2].SetActive(false);

                blue_pink.Blue_Cups1[0].SetActive(true);
                blue_pink.Blue_Cups1[1].SetActive(true);
                blue_pink.Blue_Cups1[2].SetActive(true);

                blue_pink.Blue_Cups2[0].SetActive(false);
                blue_pink.Blue_Cups2[1].SetActive(false);
                blue_pink.Blue_Cups2[2].SetActive(false);


                if (move_count.Can_Move_Count == 0)//플레이어가 움직일 수 있는 수가 0이라면
                {
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);
                }

            }

            else if (Click_Count == 3 && Click_Count != 1)//홀수일 때
            {
                //파랑이가 실행되어야 함
                Pink_1.SetActive(false);
                Pink_2.SetActive(false);

                Pink_1.SetActive(true);
                Pink_2.SetActive(false);

                //파랑 재료 칸을 false하고 
                //분홍 재료 칸을 true로 만들기

                Blue_Material_Canvas.SetActive(true);
                Pink_Material_Canvas.SetActive(false);

                Good_Bad_Blue_1.SetActive(true);
                Good_Bad_Blue_2.SetActive(true);

                Good_Bad_Pink_1.SetActive(false);
                Good_Bad_Pink_2.SetActive(false);

                Coin_Blue_1.SetActive(true);
      

                Coin_Pink_1.SetActive(false);
         

                blue_pink.Pink_Cups1[0].SetActive(false);
                blue_pink.Pink_Cups1[1].SetActive(false);
                blue_pink.Pink_Cups1[2].SetActive(false);

                blue_pink.Pink_Cups2[0].SetActive(false);
                blue_pink.Pink_Cups2[1].SetActive(false);
                blue_pink.Pink_Cups2[2].SetActive(false);

                blue_pink.Blue_Cups1[0].SetActive(true);
                blue_pink.Blue_Cups1[1].SetActive(true);
                blue_pink.Blue_Cups1[2].SetActive(true);

                blue_pink.Blue_Cups2[0].SetActive(false);
                blue_pink.Blue_Cups2[1].SetActive(false);
                blue_pink.Blue_Cups2[2].SetActive(false);


                if (move_count.Can_Move_Count == 0)//플레이어가 움직일 수 있는 수가 0이라면
                {
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);
                }

            }
        }




    }


    public void UpdateClickCountText()
    {//몇 번 클릭했는지 확인하기 위해 만든 코드
        Button_Click.text = " " + Click_Count.ToString();

        if (Click_Count == 1)//만약 클릭 카운트가 0, 1, 2, 3이라면 
        {
            move_count.Can_Move_Count = 1;
        }

        if (Click_Count == 2)//만약 클릭 카운트가 0, 1, 2, 3이라면 
        {
            move_count.Can_Move_Count = 1;
        }

        if (Click_Count == 3)//만약 클릭 카운트가 0, 1, 2, 3이라면 
        {
            move_count.Can_Move_Count = 1;
        }

        if (Click_Count > 3)//만약 클릭 카운트가 4이상 이라면 
        {
            move_count.Can_Move_Count = 3;
        }
    }

    public void Down_Card()//다음 턴 되면 카드 아래로 넘기는 거 //턴 넘기는 버튼에 추가할 거임
    {
        //클릭 카운트가 0, 1, 2, 3일때는 자리 그대로 유지

        //클릭 카운트가 4 이상이면서 
        //클릭 카운트가 0, 1, 2, 3일때 0, 2에서 분홍 재료가 true였다면 
        //버튼 누르는 순간 카드 한 칸씩 내려가고 4번째 줄에 있던 거는 Bad 숫자로 옮기기

        //Bad되기 전에 빨강 깜박깜박 거리는 거 실행시키고 싶다

        if (Open_Pink.activeSelf == true || Close_Pink.activeSelf == true)//핑크가 시작
                                                                          // Open_Pink.activeSelf == true || Close_Pink.activeSelf == true 이거였음 

        //시작이 0
        {

            //짝수 번째 클릭했는데 각도가 0, 0, 180이라면 핑크는 나타내고 파랑은 지우기
            if (Click_Count % 2 == 0 && Click_Count != 0 && Click_Count != 2 && Click_Count > 4)//짝수이면서 0, 2가 아니라면
            {
                if (card_move.Blue_Fourth_Line[0].transform.childCount == 1
                    || card_move.Blue_Fourth_Line[1].transform.childCount == 1
                    || card_move.Blue_Fourth_Line[2].transform.childCount == 1
                    || card_move.Blue_Fourth_Line[3].transform.childCount == 1
                    || card_move.Blue_Fourth_Line[4].transform.childCount == 1
                    || card_move.Blue_Fourth_Line[5].transform.childCount == 1
                    || card_move.Blue_Fourth_Line[6].transform.childCount == 1)

                {
                    if ((move_player.Player_Positions[30].childCount != 0 && move_player.Player_Positions[31].childCount != 0)
                    || (move_player.Player_Positions[28].childCount != 0 && move_player.Player_Positions[29].childCount != 0)
                    || (move_player.Player_Positions[26].childCount != 0 && move_player.Player_Positions[27].childCount != 0)
                    || (move_player.Player_Positions[24].childCount != 0 && move_player.Player_Positions[25].childCount != 0)
                    || (move_player.Player_Positions[22].childCount != 0 && move_player.Player_Positions[23].childCount != 0)
                    || (move_player.Player_Positions[20].childCount != 0 && move_player.Player_Positions[21].childCount != 0)
                    || (move_player.Player_Positions[18].childCount != 0 && move_player.Player_Positions[19].childCount != 0)
                    || (move_player.Player_Positions[16].childCount != 0 && move_player.Player_Positions[17].childCount != 0)
                    || (move_player.Player_Positions[14].childCount != 0 && move_player.Player_Positions[15].childCount != 0)
                    || (move_player.Player_Positions[12].childCount != 0 && move_player.Player_Positions[13].childCount != 0)
                    || (move_player.Player_Positions[10].childCount != 0 && move_player.Player_Positions[11].childCount != 0)
                    || (move_player.Player_Positions[8].childCount != 0 && move_player.Player_Positions[9].childCount != 0)
                    || (move_player.Player_Positions[6].childCount != 0 && move_player.Player_Positions[7].childCount != 0)
                    || (move_player.Player_Positions[4].childCount != 0 && move_player.Player_Positions[5].childCount != 0)
                    || (move_player.Player_Positions[2].childCount != 0 && move_player.Player_Positions[3].childCount != 0)
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))
                    {
                        return;
                    }

                    else
                    {
                        PlayAnimationOnFirstChildObjects_Blue(card_move.Blue_Fourth_Line[0].transform);
                        PlayAnimationOnFirstChildObjects_Blue(card_move.Blue_Fourth_Line[1].transform);
                        PlayAnimationOnFirstChildObjects_Blue(card_move.Blue_Fourth_Line[2].transform);
                        PlayAnimationOnFirstChildObjects_Blue(card_move.Blue_Fourth_Line[3].transform);
                        PlayAnimationOnFirstChildObjects_Blue(card_move.Blue_Fourth_Line[4].transform);
                        PlayAnimationOnFirstChildObjects_Blue(card_move.Blue_Fourth_Line[5].transform);
                        PlayAnimationOnFirstChildObjects_Blue(card_move.Blue_Fourth_Line[6].transform);


                        //여기에 뭐 넣어야 할 듯

                        StartCoroutine(Go_Next());


                        IEnumerator Go_Next()
                        {
                            yield return new WaitForSeconds(2.8f);

                            Blue_1.SetActive(false);
                            Blue_2.SetActive(false);

                            //파랑 재료 칸을 false하고 

                            //분홍 재료 칸을 true로 만들기

                            Blue_Material_Canvas.SetActive(false);
                            Pink_Material_Canvas.SetActive(true);//분홍 재료 true
                                                                 //이 때는 분홍이의 위치를 옮기거나 애니메이션이 실행되서는 안됨

                            Good_Bad_Blue_1.SetActive(false);
                            Good_Bad_Blue_2.SetActive(false);

                            Good_Bad_Pink_1.SetActive(true);
                            Good_Bad_Pink_2.SetActive(true);

                            Coin_Blue_1.SetActive(false);
                

                            Coin_Pink_1.SetActive(true);
                    



                            blue_pink.Pink_Cups1[0].SetActive(true);
                            blue_pink.Pink_Cups1[1].SetActive(true);
                            blue_pink.Pink_Cups1[2].SetActive(true);

                            blue_pink.Pink_Cups2[0].SetActive(false);
                            blue_pink.Pink_Cups2[1].SetActive(false);
                            blue_pink.Pink_Cups2[2].SetActive(false);

                            blue_pink.Blue_Cups1[0].SetActive(false);
                            blue_pink.Blue_Cups1[1].SetActive(false);
                            blue_pink.Blue_Cups1[2].SetActive(false);

                            blue_pink.Blue_Cups2[0].SetActive(false);
                            blue_pink.Blue_Cups2[1].SetActive(false);
                            blue_pink.Blue_Cups2[2].SetActive(false);
                        }
                    }

                }

                else if (card_move.Blue_Fourth_Line[0].transform.childCount == 0
                    && card_move.Blue_Fourth_Line[1].transform.childCount == 0
                    && card_move.Blue_Fourth_Line[2].transform.childCount == 0
                    && card_move.Blue_Fourth_Line[3].transform.childCount == 0
                    && card_move.Blue_Fourth_Line[4].transform.childCount == 0
                    && card_move.Blue_Fourth_Line[5].transform.childCount == 0
                    && card_move.Blue_Fourth_Line[6].transform.childCount == 0
                    )
                {

                    if ((move_player.Player_Positions[30].childCount != 0 && move_player.Player_Positions[31].childCount != 0)
                    || (move_player.Player_Positions[28].childCount != 0 && move_player.Player_Positions[29].childCount != 0)
                    || (move_player.Player_Positions[26].childCount != 0 && move_player.Player_Positions[27].childCount != 0)
                    || (move_player.Player_Positions[24].childCount != 0 && move_player.Player_Positions[25].childCount != 0)
                    || (move_player.Player_Positions[22].childCount != 0 && move_player.Player_Positions[23].childCount != 0)
                    || (move_player.Player_Positions[20].childCount != 0 && move_player.Player_Positions[21].childCount != 0)
                    || (move_player.Player_Positions[18].childCount != 0 && move_player.Player_Positions[19].childCount != 0)
                    || (move_player.Player_Positions[16].childCount != 0 && move_player.Player_Positions[17].childCount != 0)
                    || (move_player.Player_Positions[14].childCount != 0 && move_player.Player_Positions[15].childCount != 0)
                    || (move_player.Player_Positions[12].childCount != 0 && move_player.Player_Positions[13].childCount != 0)
                    || (move_player.Player_Positions[10].childCount != 0 && move_player.Player_Positions[11].childCount != 0)
                    || (move_player.Player_Positions[8].childCount != 0 && move_player.Player_Positions[9].childCount != 0)
                    || (move_player.Player_Positions[6].childCount != 0 && move_player.Player_Positions[7].childCount != 0)
                    || (move_player.Player_Positions[4].childCount != 0 && move_player.Player_Positions[5].childCount != 0)
                    || (move_player.Player_Positions[2].childCount != 0 && move_player.Player_Positions[3].childCount != 0)
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))
                    {
                        return;
                    }

                    else
                    {
                        PlayAnimationOnFirstChildObjects_1_Blue();

                        //여기에 뭐 넣어야 할 듯

                        StartCoroutine(Go_Next());


                        IEnumerator Go_Next()
                        {
                            yield return new WaitForSeconds(0.5f);

                            Blue_1.SetActive(false);
                            Blue_2.SetActive(false);

                            //파랑 재료 칸을 false하고 

                            //분홍 재료 칸을 true로 만들기

                            Blue_Material_Canvas.SetActive(false);
                            Pink_Material_Canvas.SetActive(true);//분홍 재료 true
                                                                 //이 때는 분홍이의 위치를 옮기거나 애니메이션이 실행되서는 안됨

                            Good_Bad_Blue_1.SetActive(false);
                            Good_Bad_Blue_2.SetActive(false);

                            Good_Bad_Pink_1.SetActive(true);
                            Good_Bad_Pink_2.SetActive(true);

                            Coin_Blue_1.SetActive(false);
                         

                            Coin_Pink_1.SetActive(true);
                      



                            blue_pink.Pink_Cups1[0].SetActive(true);
                            blue_pink.Pink_Cups1[1].SetActive(true);
                            blue_pink.Pink_Cups1[2].SetActive(true);

                            blue_pink.Pink_Cups2[0].SetActive(false);
                            blue_pink.Pink_Cups2[1].SetActive(false);
                            blue_pink.Pink_Cups2[2].SetActive(false);

                            blue_pink.Blue_Cups1[0].SetActive(false);
                            blue_pink.Blue_Cups1[1].SetActive(false);
                            blue_pink.Blue_Cups1[2].SetActive(false);

                            blue_pink.Blue_Cups2[0].SetActive(false);
                            blue_pink.Blue_Cups2[1].SetActive(false);
                            blue_pink.Blue_Cups2[2].SetActive(false);
                        }
                    }


                }

                /*StartCoroutine(Go_Next());


                IEnumerator Go_Next()
                {
                    yield return new WaitForSeconds(0.0f);

                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                    //파랑 재료 칸을 false하고 

                    //분홍 재료 칸을 true로 만들기

                    Blue_Material_Canvas.SetActive(false);
                    Pink_Material_Canvas.SetActive(true);//분홍 재료 true
                                                         //이 때는 분홍이의 위치를 옮기거나 애니메이션이 실행되서는 안됨

                    Good_Bad_Blue.SetActive(false);
                    Good_Bad_Pink.SetActive(true);

                    Coin_Blue.SetActive(false);
                    Coin_Pink.SetActive(true);



                    blue_pink.Pink_Cups[0].SetActive(true);
                    blue_pink.Pink_Cups[1].SetActive(false);
                    blue_pink.Blue_Cups[0].SetActive(false);
                    blue_pink.Blue_Cups[1].SetActive(false);
                }*/

            }


            else if (Click_Count != 0 && Click_Count == 2)// 0, 2라면
            {//핑크가 시작일 땐 파랑이 먼저 실행되어야 함
                StartCoroutine(Go_Next());


                IEnumerator Go_Next()
                {
                    yield return new WaitForSeconds(0.0f);

                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);

                    Blue_1.SetActive(true);
                    Blue_2.SetActive(false);

                    //파랑 재료 칸을 false하고 

                    //분홍 재료 칸을 true로 만들기

                    Blue_Material_Canvas.SetActive(true);
                    Pink_Material_Canvas.SetActive(false);//분홍 재료 true
                                                          //이 때는 분홍이의 위치를 옮기거나 애니메이션이 실행되서는 안됨

                    Good_Bad_Blue_1.SetActive(true);
                    Good_Bad_Blue_2.SetActive(true);

                    Good_Bad_Pink_1.SetActive(false);
                    Good_Bad_Pink_2.SetActive(false);

                    Coin_Blue_1.SetActive(true);
               

                    Coin_Pink_1.SetActive(false);
                    



                    blue_pink.Pink_Cups1[0].SetActive(false);
                    blue_pink.Pink_Cups1[1].SetActive(false);
                    blue_pink.Pink_Cups1[2].SetActive(false);

                    blue_pink.Pink_Cups2[0].SetActive(false);
                    blue_pink.Pink_Cups2[1].SetActive(false);
                    blue_pink.Pink_Cups2[2].SetActive(false);

                    blue_pink.Blue_Cups1[0].SetActive(true);
                    blue_pink.Blue_Cups1[1].SetActive(true);
                    blue_pink.Blue_Cups1[2].SetActive(true);

                    blue_pink.Blue_Cups2[0].SetActive(false);
                    blue_pink.Blue_Cups2[1].SetActive(false);
                    blue_pink.Blue_Cups2[2].SetActive(false);
                }

            }

            else if (Click_Count == 0 && Click_Count != 2)// 0, 2라면
            {//핑크가 시작일 땐 파랑이 먼저 실행되어야 함
                StartCoroutine(Go_Next());


                IEnumerator Go_Next()
                {
                    yield return new WaitForSeconds(0.0f);

                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);

                    Blue_1.SetActive(false);
                    Blue_2.SetActive(true);

                    //파랑 재료 칸을 false하고 

                    //분홍 재료 칸을 true로 만들기

                    Blue_Material_Canvas.SetActive(true);
                    Pink_Material_Canvas.SetActive(false);//분홍 재료 true
                                                          //이 때는 분홍이의 위치를 옮기거나 애니메이션이 실행되서는 안됨

                    Good_Bad_Blue_1.SetActive(true);
                    Good_Bad_Blue_2.SetActive(true);

                    Good_Bad_Pink_1.SetActive(false);
                    Good_Bad_Pink_2.SetActive(false);

                    Coin_Blue_1.SetActive(true);
          

                    Coin_Pink_1.SetActive(false);
                



                    blue_pink.Pink_Cups1[0].SetActive(false);
                    blue_pink.Pink_Cups1[1].SetActive(false);
                    blue_pink.Pink_Cups1[2].SetActive(false);

                    blue_pink.Pink_Cups2[0].SetActive(false);
                    blue_pink.Pink_Cups2[1].SetActive(false);
                    blue_pink.Pink_Cups2[2].SetActive(false);

                    blue_pink.Blue_Cups1[0].SetActive(true);
                    blue_pink.Blue_Cups1[1].SetActive(true);
                    blue_pink.Blue_Cups1[2].SetActive(true);

                    blue_pink.Blue_Cups2[0].SetActive(false);
                    blue_pink.Blue_Cups2[1].SetActive(false);
                    blue_pink.Blue_Cups2[2].SetActive(false);
                }

            }


            //0814
            else if (Click_Count != 0 && Click_Count != 2 && Click_Count == 4)// 4라면
            {//핑크가 시작일 땐 파랑이 먼저 실행되어야 함
                StartCoroutine(Go_Next());


                IEnumerator Go_Next()
                {
                    yield return new WaitForSeconds(0.0f);

                    //Pink_1.SetActive(false);
                    //Pink_2.SetActive(false);

                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                    //파랑 재료 칸을 false하고 

                    //분홍 재료 칸을 true로 만들기

                    Blue_Material_Canvas.SetActive(false);
                    Pink_Material_Canvas.SetActive(true);//분홍 재료 true
                                                         //이 때는 분홍이의 위치를 옮기거나 애니메이션이 실행되서는 안됨

                    Good_Bad_Blue_1.SetActive(false);
                    Good_Bad_Blue_2.SetActive(false);

                    Good_Bad_Pink_1.SetActive(true);
                    Good_Bad_Pink_2.SetActive(true);

                    Coin_Blue_1.SetActive(false);
                 

                    Coin_Pink_1.SetActive(true);
         

                    // blue_pink.Plate.transform.Rotate(0f, 0f, 180f);
                    // blue_pink.plate.anchoredPosition = new Vector2(0f, 12.9f);//15.6이었는디...

                    //
                    next_turn.Go_Player1_B.SetActive(false);//블루 턴 끝내기
                    next_turn.Go_Player2_B.SetActive(true);//핑크 턴 끝내기

                    next_turn.blue.SetActive(false);//블루 
                    next_turn.pink.SetActive(true);//핑크 

                    blue_pink.Pink_Cups1[0].SetActive(true);
                    blue_pink.Pink_Cups1[1].SetActive(true);
                    blue_pink.Pink_Cups1[2].SetActive(true);

                    blue_pink.Pink_Cups2[0].SetActive(false);
                    blue_pink.Pink_Cups2[1].SetActive(false);
                    blue_pink.Pink_Cups2[2].SetActive(false);

                    blue_pink.Blue_Cups1[0].SetActive(false);
                    blue_pink.Blue_Cups1[1].SetActive(false);
                    blue_pink.Blue_Cups1[2].SetActive(false);

                    blue_pink.Blue_Cups2[0].SetActive(false);
                    blue_pink.Blue_Cups2[1].SetActive(false);
                    blue_pink.Blue_Cups2[2].SetActive(false);
                }

            }

            if (Click_Count % 2 != 0 && Click_Count != 1 && Click_Count != 3 && Click_Count > 4)//홀수면서 1, 3이 아니라면
            {


                //턴이 핑크에서 파랑으로 넘어간 것이므로 여기서 코드 실행해야 함
                /*for (int i = 0; i < 7; i++)
                {
                    // 조건이 만족하는 경우에만 실행
                    if (card_move.Pink_Fourth_Line[i].transform.childCount == 1)
                    {
                        // "PlayAnimationOnFirstChildObjects" 메서드를 호출하여 애니메이션 실행
                        PlayAnimationOnFirstChildObjects(card_move.Pink_Fourth_Line[i].transform);
                    }
                }*/

                if (card_move.Pink_Fourth_Line[0].transform.childCount == 1
                    || card_move.Pink_Fourth_Line[1].transform.childCount == 1
                    || card_move.Pink_Fourth_Line[2].transform.childCount == 1
                    || card_move.Pink_Fourth_Line[3].transform.childCount == 1
                    || card_move.Pink_Fourth_Line[4].transform.childCount == 1
                    || card_move.Pink_Fourth_Line[5].transform.childCount == 1
                    || card_move.Pink_Fourth_Line[6].transform.childCount == 1)

                {

                    if ((move_player.Player_Positions[30].childCount != 0 && move_player.Player_Positions[31].childCount != 0)
                    || (move_player.Player_Positions[28].childCount != 0 && move_player.Player_Positions[29].childCount != 0)
                    || (move_player.Player_Positions[26].childCount != 0 && move_player.Player_Positions[27].childCount != 0)
                    || (move_player.Player_Positions[24].childCount != 0 && move_player.Player_Positions[25].childCount != 0)
                    || (move_player.Player_Positions[22].childCount != 0 && move_player.Player_Positions[23].childCount != 0)
                    || (move_player.Player_Positions[20].childCount != 0 && move_player.Player_Positions[21].childCount != 0)
                    || (move_player.Player_Positions[18].childCount != 0 && move_player.Player_Positions[19].childCount != 0)
                    || (move_player.Player_Positions[16].childCount != 0 && move_player.Player_Positions[17].childCount != 0)
                    || (move_player.Player_Positions[14].childCount != 0 && move_player.Player_Positions[15].childCount != 0)
                    || (move_player.Player_Positions[12].childCount != 0 && move_player.Player_Positions[13].childCount != 0)
                    || (move_player.Player_Positions[10].childCount != 0 && move_player.Player_Positions[11].childCount != 0)
                    || (move_player.Player_Positions[8].childCount != 0 && move_player.Player_Positions[9].childCount != 0)
                    || (move_player.Player_Positions[6].childCount != 0 && move_player.Player_Positions[7].childCount != 0)
                    || (move_player.Player_Positions[4].childCount != 0 && move_player.Player_Positions[5].childCount != 0)
                    || (move_player.Player_Positions[2].childCount != 0 && move_player.Player_Positions[3].childCount != 0)
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))
                    {
                        return;
                    }

                    else
                    {
                        PlayAnimationOnFirstChildObjects(card_move.Pink_Fourth_Line[0].transform);
                        PlayAnimationOnFirstChildObjects(card_move.Pink_Fourth_Line[1].transform);
                        PlayAnimationOnFirstChildObjects(card_move.Pink_Fourth_Line[2].transform);
                        PlayAnimationOnFirstChildObjects(card_move.Pink_Fourth_Line[3].transform);
                        PlayAnimationOnFirstChildObjects(card_move.Pink_Fourth_Line[4].transform);
                        PlayAnimationOnFirstChildObjects(card_move.Pink_Fourth_Line[5].transform);
                        PlayAnimationOnFirstChildObjects(card_move.Pink_Fourth_Line[6].transform);

                        StartCoroutine(Go_Next1());


                        IEnumerator Go_Next1()
                        {
                            yield return new WaitForSeconds(2.8f);

                            Pink_1.SetActive(false);
                            Pink_2.SetActive(false);


                            //파랑 재료 칸을 true하고 
                            //분홍 재료 칸을 false로 만들기

                            Blue_Material_Canvas.SetActive(true);
                            Pink_Material_Canvas.SetActive(false);//핑크 비활성

                            Good_Bad_Blue_1.SetActive(true);
                            Good_Bad_Blue_2.SetActive(true);

                            Good_Bad_Pink_1.SetActive(false);
                            Good_Bad_Pink_2.SetActive(false);

                            Coin_Blue_1.SetActive(true);
                     

                            Coin_Pink_1.SetActive(false);
                    

                            blue_pink.Pink_Cups1[0].SetActive(false);
                            blue_pink.Pink_Cups1[1].SetActive(false);
                            blue_pink.Pink_Cups1[2].SetActive(false);

                            blue_pink.Pink_Cups2[0].SetActive(false);
                            blue_pink.Pink_Cups2[1].SetActive(false);
                            blue_pink.Pink_Cups2[2].SetActive(false);

                            blue_pink.Blue_Cups1[0].SetActive(true);
                            blue_pink.Blue_Cups1[1].SetActive(true);
                            blue_pink.Blue_Cups1[2].SetActive(true);

                            blue_pink.Blue_Cups2[0].SetActive(false);
                            blue_pink.Blue_Cups2[1].SetActive(false);
                            blue_pink.Blue_Cups2[2].SetActive(false);

                        }
                    }

                }

                if (card_move.Pink_Fourth_Line[0].transform.childCount == 0
                    && card_move.Pink_Fourth_Line[1].transform.childCount == 0
                    && card_move.Pink_Fourth_Line[2].transform.childCount == 0
                    && card_move.Pink_Fourth_Line[3].transform.childCount == 0
                    && card_move.Pink_Fourth_Line[4].transform.childCount == 0
                    && card_move.Pink_Fourth_Line[5].transform.childCount == 0
                    && card_move.Pink_Fourth_Line[6].transform.childCount == 0
                    )
                {

                    if ((move_player.Player_Positions[30].childCount != 0 && move_player.Player_Positions[31].childCount != 0)
                    || (move_player.Player_Positions[28].childCount != 0 && move_player.Player_Positions[29].childCount != 0)
                    || (move_player.Player_Positions[26].childCount != 0 && move_player.Player_Positions[27].childCount != 0)
                    || (move_player.Player_Positions[24].childCount != 0 && move_player.Player_Positions[25].childCount != 0)
                    || (move_player.Player_Positions[22].childCount != 0 && move_player.Player_Positions[23].childCount != 0)
                    || (move_player.Player_Positions[20].childCount != 0 && move_player.Player_Positions[21].childCount != 0)
                    || (move_player.Player_Positions[18].childCount != 0 && move_player.Player_Positions[19].childCount != 0)
                    || (move_player.Player_Positions[16].childCount != 0 && move_player.Player_Positions[17].childCount != 0)
                    || (move_player.Player_Positions[14].childCount != 0 && move_player.Player_Positions[15].childCount != 0)
                    || (move_player.Player_Positions[12].childCount != 0 && move_player.Player_Positions[13].childCount != 0)
                    || (move_player.Player_Positions[10].childCount != 0 && move_player.Player_Positions[11].childCount != 0)
                    || (move_player.Player_Positions[8].childCount != 0 && move_player.Player_Positions[9].childCount != 0)
                    || (move_player.Player_Positions[6].childCount != 0 && move_player.Player_Positions[7].childCount != 0)
                    || (move_player.Player_Positions[4].childCount != 0 && move_player.Player_Positions[5].childCount != 0)
                    || (move_player.Player_Positions[2].childCount != 0 && move_player.Player_Positions[3].childCount != 0)
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))
                    {
                        return;
                    }

                    else
                    {
                        PlayAnimationOnFirstChildObjects_1();

                        StartCoroutine(Go_Next1());
                        IEnumerator Go_Next1()
                        {
                            yield return new WaitForSeconds(0.5f);

                            Pink_1.SetActive(false);
                            Pink_2.SetActive(false);


                            //파랑 재료 칸을 true하고 
                            //분홍 재료 칸을 false로 만들기

                            Blue_Material_Canvas.SetActive(true);
                            Pink_Material_Canvas.SetActive(false);//핑크 비활성

                            Good_Bad_Blue_1.SetActive(true);
                            Good_Bad_Blue_2.SetActive(true);

                            Good_Bad_Pink_1.SetActive(false);
                            Good_Bad_Pink_2.SetActive(false);

                            Coin_Blue_1.SetActive(true);
                    

                            Coin_Pink_1.SetActive(false);
                 

                            blue_pink.Pink_Cups1[0].SetActive(false);
                            blue_pink.Pink_Cups1[1].SetActive(false);
                            blue_pink.Pink_Cups1[2].SetActive(false);

                            blue_pink.Pink_Cups2[0].SetActive(false);
                            blue_pink.Pink_Cups2[1].SetActive(false);
                            blue_pink.Pink_Cups2[2].SetActive(false);

                            blue_pink.Blue_Cups1[0].SetActive(true);
                            blue_pink.Blue_Cups1[1].SetActive(true);
                            blue_pink.Blue_Cups1[2].SetActive(true);

                            blue_pink.Blue_Cups2[0].SetActive(false);
                            blue_pink.Blue_Cups2[1].SetActive(false);
                            blue_pink.Blue_Cups2[2].SetActive(false);

                        }
                    }

                }







            }

            if (Click_Count == 1 && Click_Count != 3)//1, 3이라면
            {
                //핑크가 시작일 때 홀수면 핑크임


                StartCoroutine(Go_Next1());


                IEnumerator Go_Next1()
                {
                    yield return new WaitForSeconds(0.0f);

                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                    Pink_1.SetActive(false);
                    Pink_2.SetActive(true);


                    //파랑 재료 칸을 true하고 
                    //분홍 재료 칸을 false로 만들기

                    Blue_Material_Canvas.SetActive(false);
                    Pink_Material_Canvas.SetActive(true);//핑크 비활성

                    Good_Bad_Blue_1.SetActive(false);
                    Good_Bad_Blue_2.SetActive(false);

                    Good_Bad_Pink_1.SetActive(true);
                    Good_Bad_Pink_2.SetActive(true);

                    Coin_Blue_1.SetActive(false);
           

                    Coin_Pink_1.SetActive(true);
         

                    blue_pink.Pink_Cups1[0].SetActive(true);
                    blue_pink.Pink_Cups1[1].SetActive(true);
                    blue_pink.Pink_Cups1[2].SetActive(true);

                    blue_pink.Pink_Cups2[0].SetActive(false);
                    blue_pink.Pink_Cups2[1].SetActive(false);
                    blue_pink.Pink_Cups2[2].SetActive(false);

                    blue_pink.Blue_Cups1[0].SetActive(false);
                    blue_pink.Blue_Cups1[1].SetActive(false);
                    blue_pink.Blue_Cups1[2].SetActive(false);

                    blue_pink.Blue_Cups2[0].SetActive(false);
                    blue_pink.Blue_Cups2[1].SetActive(false);
                    blue_pink.Blue_Cups2[2].SetActive(false);

                }



            }

            if (Click_Count != 1 && Click_Count == 3)//1, 3이라면
            {
                //핑크가 시작일 때 홀수면 핑크임


                StartCoroutine(Go_Next1());


                IEnumerator Go_Next1()
                {
                    yield return new WaitForSeconds(0.0f);

                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                    Pink_1.SetActive(true);
                    Pink_2.SetActive(false);


                    //파랑 재료 칸을 true하고 
                    //분홍 재료 칸을 false로 만들기

                    Blue_Material_Canvas.SetActive(false);
                    Pink_Material_Canvas.SetActive(true);//핑크 비활성

                    Good_Bad_Blue_1.SetActive(false);
                    Good_Bad_Blue_2.SetActive(false);

                    Good_Bad_Pink_1.SetActive(true);
                    Good_Bad_Pink_2.SetActive(true);

                    Coin_Blue_1.SetActive(false);
              

                    Coin_Pink_1.SetActive(true);
                

                    blue_pink.Pink_Cups1[0].SetActive(true);
                    blue_pink.Pink_Cups1[1].SetActive(true);
                    blue_pink.Pink_Cups1[2].SetActive(true);

                    blue_pink.Pink_Cups2[0].SetActive(false);
                    blue_pink.Pink_Cups2[1].SetActive(false);
                    blue_pink.Pink_Cups2[2].SetActive(false);

                    blue_pink.Blue_Cups1[0].SetActive(false);
                    blue_pink.Blue_Cups1[1].SetActive(false);
                    blue_pink.Blue_Cups1[2].SetActive(false);

                    blue_pink.Blue_Cups2[0].SetActive(false);
                    blue_pink.Blue_Cups2[1].SetActive(false);
                    blue_pink.Blue_Cups2[2].SetActive(false);

                }



            }
        }


        if (Open_Blue.activeSelf == true || Close_Blue.activeSelf == true)//블루가 시작
        {
            //Open_Blue.activeSelf == true || Close_Blue.activeSelf == true 이거였음

            //짝수번째 클릭했는데 각도가 0, 0, 0이라면 파랑이 나타내고 분홍 지우기
            //4가 
            if (Click_Count % 2 == 0 && Click_Count != 0 && Click_Count != 2 && Click_Count > 4) //짝수일 때
            {

                //수정중. 카드 무브 1있는 걸 안으로 옮길거임
                if (card_move.Pink_Fourth_Line[0].transform.childCount == 1
                    || card_move.Pink_Fourth_Line[1].transform.childCount == 1
                    || card_move.Pink_Fourth_Line[2].transform.childCount == 1
                    || card_move.Pink_Fourth_Line[3].transform.childCount == 1
                    || card_move.Pink_Fourth_Line[4].transform.childCount == 1
                    || card_move.Pink_Fourth_Line[5].transform.childCount == 1
                    || card_move.Pink_Fourth_Line[6].transform.childCount == 1)

                {
                    if ((move_player.Player_Positions[30].childCount != 0 && move_player.Player_Positions[31].childCount != 0)
                    || (move_player.Player_Positions[28].childCount != 0 && move_player.Player_Positions[29].childCount != 0)
                    || (move_player.Player_Positions[26].childCount != 0 && move_player.Player_Positions[27].childCount != 0)
                    || (move_player.Player_Positions[24].childCount != 0 && move_player.Player_Positions[25].childCount != 0)
                    || (move_player.Player_Positions[22].childCount != 0 && move_player.Player_Positions[23].childCount != 0)
                    || (move_player.Player_Positions[20].childCount != 0 && move_player.Player_Positions[21].childCount != 0)
                    || (move_player.Player_Positions[18].childCount != 0 && move_player.Player_Positions[19].childCount != 0)
                    || (move_player.Player_Positions[16].childCount != 0 && move_player.Player_Positions[17].childCount != 0)
                    || (move_player.Player_Positions[14].childCount != 0 && move_player.Player_Positions[15].childCount != 0)
                    || (move_player.Player_Positions[12].childCount != 0 && move_player.Player_Positions[13].childCount != 0)
                    || (move_player.Player_Positions[10].childCount != 0 && move_player.Player_Positions[11].childCount != 0)
                    || (move_player.Player_Positions[8].childCount != 0 && move_player.Player_Positions[9].childCount != 0)
                    || (move_player.Player_Positions[6].childCount != 0 && move_player.Player_Positions[7].childCount != 0)
                    || (move_player.Player_Positions[4].childCount != 0 && move_player.Player_Positions[5].childCount != 0)
                    || (move_player.Player_Positions[2].childCount != 0 && move_player.Player_Positions[3].childCount != 0)
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))
                    {



                        return;
                    }

                    else
                    {
                        PlayAnimationOnFirstChildObjects(card_move.Pink_Fourth_Line[0].transform);
                        PlayAnimationOnFirstChildObjects(card_move.Pink_Fourth_Line[1].transform);
                        PlayAnimationOnFirstChildObjects(card_move.Pink_Fourth_Line[2].transform);
                        PlayAnimationOnFirstChildObjects(card_move.Pink_Fourth_Line[3].transform);
                        PlayAnimationOnFirstChildObjects(card_move.Pink_Fourth_Line[4].transform);
                        PlayAnimationOnFirstChildObjects(card_move.Pink_Fourth_Line[5].transform);
                        PlayAnimationOnFirstChildObjects(card_move.Pink_Fourth_Line[6].transform);

                        StartCoroutine(Go_Next1());


                        IEnumerator Go_Next1()
                        {
                            yield return new WaitForSeconds(2.8f);
                            Pink_1.SetActive(false);
                            Pink_2.SetActive(false);

                            //파랑 재료 칸을 true하고 
                            //분홍 재료 칸을 false로 만들기

                            Blue_Material_Canvas.SetActive(true);
                            Pink_Material_Canvas.SetActive(false);//분홍 재료가 false일 때 코드 실행

                            Good_Bad_Blue_1.SetActive(true);
                            Good_Bad_Blue_2.SetActive(true);

                            Good_Bad_Pink_1.SetActive(false);
                            Good_Bad_Pink_2.SetActive(false);

                            Coin_Blue_1.SetActive(true);
                           

                            Coin_Pink_1.SetActive(false);
                    

                            blue_pink.Pink_Cups1[0].SetActive(false);
                            blue_pink.Pink_Cups1[1].SetActive(false);
                            blue_pink.Pink_Cups1[2].SetActive(false);

                            blue_pink.Pink_Cups2[0].SetActive(false);
                            blue_pink.Pink_Cups2[1].SetActive(false);
                            blue_pink.Pink_Cups2[2].SetActive(false);

                            blue_pink.Blue_Cups1[0].SetActive(true);
                            blue_pink.Blue_Cups1[1].SetActive(true);
                            blue_pink.Blue_Cups1[2].SetActive(true);

                            blue_pink.Blue_Cups2[0].SetActive(false);
                            blue_pink.Blue_Cups2[1].SetActive(false);
                            blue_pink.Blue_Cups2[2].SetActive(false);
                        }
                    }


                }

                else if (card_move.Pink_Fourth_Line[0].transform.childCount == 0
                    && card_move.Pink_Fourth_Line[1].transform.childCount == 0
                    && card_move.Pink_Fourth_Line[2].transform.childCount == 0
                    && card_move.Pink_Fourth_Line[3].transform.childCount == 0
                    && card_move.Pink_Fourth_Line[4].transform.childCount == 0
                    && card_move.Pink_Fourth_Line[5].transform.childCount == 0
                    && card_move.Pink_Fourth_Line[6].transform.childCount == 0
                    )
                {
                    if ((move_player.Player_Positions[30].childCount != 0 && move_player.Player_Positions[31].childCount != 0)
                    || (move_player.Player_Positions[28].childCount != 0 && move_player.Player_Positions[29].childCount != 0)
                    || (move_player.Player_Positions[26].childCount != 0 && move_player.Player_Positions[27].childCount != 0)
                    || (move_player.Player_Positions[24].childCount != 0 && move_player.Player_Positions[25].childCount != 0)
                    || (move_player.Player_Positions[22].childCount != 0 && move_player.Player_Positions[23].childCount != 0)
                    || (move_player.Player_Positions[20].childCount != 0 && move_player.Player_Positions[21].childCount != 0)
                    || (move_player.Player_Positions[18].childCount != 0 && move_player.Player_Positions[19].childCount != 0)
                    || (move_player.Player_Positions[16].childCount != 0 && move_player.Player_Positions[17].childCount != 0)
                    || (move_player.Player_Positions[14].childCount != 0 && move_player.Player_Positions[15].childCount != 0)
                    || (move_player.Player_Positions[12].childCount != 0 && move_player.Player_Positions[13].childCount != 0)
                    || (move_player.Player_Positions[10].childCount != 0 && move_player.Player_Positions[11].childCount != 0)
                    || (move_player.Player_Positions[8].childCount != 0 && move_player.Player_Positions[9].childCount != 0)
                    || (move_player.Player_Positions[6].childCount != 0 && move_player.Player_Positions[7].childCount != 0)
                    || (move_player.Player_Positions[4].childCount != 0 && move_player.Player_Positions[5].childCount != 0)
                    || (move_player.Player_Positions[2].childCount != 0 && move_player.Player_Positions[3].childCount != 0)
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))
                    {
                        return;
                    }

                    else
                    {
                        PlayAnimationOnFirstChildObjects_1();


                        StartCoroutine(Go_Next1());


                        IEnumerator Go_Next1()
                        {
                            yield return new WaitForSeconds(0.5f);
                            Pink_1.SetActive(false);
                            Pink_2.SetActive(false);

                            //파랑 재료 칸을 true하고 
                            //분홍 재료 칸을 false로 만들기

                            Blue_Material_Canvas.SetActive(true);
                            Pink_Material_Canvas.SetActive(false);//분홍 재료가 false일 때 코드 실행

                            Good_Bad_Blue_1.SetActive(true);
                            Good_Bad_Blue_2.SetActive(true);

                            Good_Bad_Pink_1.SetActive(false);
                            Good_Bad_Pink_2.SetActive(false);

                            Coin_Blue_1.SetActive(true);
                

                            Coin_Pink_1.SetActive(false);
                        

                            blue_pink.Pink_Cups1[0].SetActive(false);
                            blue_pink.Pink_Cups1[1].SetActive(false);
                            blue_pink.Pink_Cups1[2].SetActive(false);

                            blue_pink.Pink_Cups2[0].SetActive(false);
                            blue_pink.Pink_Cups2[1].SetActive(false);
                            blue_pink.Pink_Cups2[2].SetActive(false);

                            blue_pink.Blue_Cups1[0].SetActive(true);
                            blue_pink.Blue_Cups1[1].SetActive(true);
                            blue_pink.Blue_Cups1[2].SetActive(true);

                            blue_pink.Blue_Cups2[0].SetActive(false);
                            blue_pink.Blue_Cups2[1].SetActive(false);
                            blue_pink.Blue_Cups2[2].SetActive(false);
                        }
                    }


                }



                //턴이 핑크에서 파랑으로 넘어간 것이므로 여기서 코드 실행해야 함
                /* for (int i = 0; i < 7; i++)
                 {
                     // 조건이 만족하는 경우에만 실행
                     if (card_move.Pink_Fourth_Line[i].transform.childCount == 1)
                     {
                         // "PlayAnimationOnFirstChildObjects" 메서드를 호출하여 애니메이션 실행
                         PlayAnimationOnFirstChildObjects(card_move.Pink_Fourth_Line[i].transform);
                     }

                     if (card_move.Pink_Fourth_Line[i].transform.childCount == 0)
                     {
                         // "PlayAnimationOnFirstChildObjects" 메서드를 호출하여 애니메이션 실행
                         PlayAnimationOnFirstChildObjects_1(card_move.Pink_Fourth_Line[i].transform);
                     }
                 }*/






            }

            else if (Click_Count == 0 && Click_Count != 2)//짝수일 때
            {//블루가 시작인데 짝수면 핑크가 먼저
                StartCoroutine(Go_Next1());


                IEnumerator Go_Next1()
                {
                    yield return new WaitForSeconds(0.0f);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                    Pink_1.SetActive(false);
                    Pink_2.SetActive(true);



                    //파랑 재료 칸을 true하고 
                    //분홍 재료 칸을 false로 만들기

                    Blue_Material_Canvas.SetActive(false);
                    Pink_Material_Canvas.SetActive(true);//분홍 재료가 false일 때 코드 실행

                    Good_Bad_Blue_1.SetActive(false);
                    Good_Bad_Blue_2.SetActive(false);

                    Good_Bad_Pink_1.SetActive(true);
                    Good_Bad_Pink_2.SetActive(true);

                    Coin_Blue_1.SetActive(false);
        

                    Coin_Pink_1.SetActive(true);
             

                    blue_pink.Pink_Cups1[0].SetActive(true);
                    blue_pink.Pink_Cups1[1].SetActive(true);
                    blue_pink.Pink_Cups1[2].SetActive(true);

                    blue_pink.Pink_Cups2[0].SetActive(false);
                    blue_pink.Pink_Cups2[1].SetActive(false);
                    blue_pink.Pink_Cups2[2].SetActive(false);

                    blue_pink.Blue_Cups1[0].SetActive(false);
                    blue_pink.Blue_Cups1[1].SetActive(false);
                    blue_pink.Blue_Cups1[2].SetActive(false);

                    blue_pink.Blue_Cups2[0].SetActive(false);
                    blue_pink.Blue_Cups2[1].SetActive(false);
                    blue_pink.Blue_Cups2[2].SetActive(false);
                }




            }

            else if (Click_Count != 0 && Click_Count == 2)//짝수일 때
            {//블루가 시작인데 짝수면 핑크가 먼저
                StartCoroutine(Go_Next1());


                IEnumerator Go_Next1()
                {
                    yield return new WaitForSeconds(0.0f);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                    Pink_1.SetActive(true);
                    Pink_2.SetActive(false);



                    //파랑 재료 칸을 true하고 
                    //분홍 재료 칸을 false로 만들기

                    Blue_Material_Canvas.SetActive(false);
                    Pink_Material_Canvas.SetActive(true);//분홍 재료가 false일 때 코드 실행

                    Good_Bad_Blue_1.SetActive(false);
                    Good_Bad_Blue_2.SetActive(false);

                    Good_Bad_Pink_1.SetActive(true);
                    Good_Bad_Pink_2.SetActive(true);

                    Coin_Blue_1.SetActive(false);
         

                    Coin_Pink_1.SetActive(true);
               

                    blue_pink.Pink_Cups1[0].SetActive(true);
                    blue_pink.Pink_Cups1[1].SetActive(true);
                    blue_pink.Pink_Cups1[2].SetActive(true);

                    blue_pink.Pink_Cups2[0].SetActive(false);
                    blue_pink.Pink_Cups2[1].SetActive(false);
                    blue_pink.Pink_Cups2[2].SetActive(false);

                    blue_pink.Blue_Cups1[0].SetActive(false);
                    blue_pink.Blue_Cups1[1].SetActive(false);
                    blue_pink.Blue_Cups1[2].SetActive(false);

                    blue_pink.Blue_Cups2[0].SetActive(false);
                    blue_pink.Blue_Cups2[1].SetActive(false);
                    blue_pink.Blue_Cups2[2].SetActive(false);
                }




            }


            //0814
            else if (Click_Count != 0 && Click_Count != 2 && Click_Count == 4)//4일 때
            {//블루가 시작인데 짝수면 핑크가 먼저
                StartCoroutine(Go_Next1());


                IEnumerator Go_Next1()
                {
                    yield return new WaitForSeconds(0.0f);
                    //Blue_1.SetActive(false);
                    //Blue_2.SetActive(false);

                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);



                    //파랑 재료 칸을 true하고 
                    //분홍 재료 칸을 false로 만들기

                    Blue_Material_Canvas.SetActive(true);
                    Pink_Material_Canvas.SetActive(false);//분홍 재료가 false일 때 코드 실행

                    Good_Bad_Blue_1.SetActive(true);
                    Good_Bad_Blue_2.SetActive(true);

                    Good_Bad_Pink_1.SetActive(false);
                    Good_Bad_Pink_2.SetActive(false);

                    Coin_Blue_1.SetActive(true);


                    Coin_Pink_1.SetActive(false);
                   

                    // next_turn.Rotate_board.transform.Rotate(0f, 0f, 180f);
                    // 현재 위치를 (0, 15.6)으로 변경
                    //next_turn.board.anchoredPosition = new Vector2(0f, 0f);//15.6였는디



                    //
                    next_turn.Go_Player1_B.SetActive(true);//블루 턴 끝내기
                    next_turn.Go_Player2_B.SetActive(false);//핑크 턴 끝내기

                    next_turn.blue.SetActive(true);//블루 
                    next_turn.pink.SetActive(false);//핑크 

                    blue_pink.Pink_Cups1[0].SetActive(false);
                    blue_pink.Pink_Cups1[1].SetActive(false);
                    blue_pink.Pink_Cups1[2].SetActive(false);

                    blue_pink.Pink_Cups2[0].SetActive(false);
                    blue_pink.Pink_Cups2[1].SetActive(false);
                    blue_pink.Pink_Cups2[2].SetActive(false);

                    blue_pink.Blue_Cups1[0].SetActive(true);
                    blue_pink.Blue_Cups1[1].SetActive(true);
                    blue_pink.Blue_Cups1[2].SetActive(true);

                    blue_pink.Blue_Cups2[0].SetActive(false);
                    blue_pink.Blue_Cups2[1].SetActive(false);
                    blue_pink.Blue_Cups2[2].SetActive(false);
                }




            }

            else if (Click_Count % 2 != 0 && Click_Count != 1 && Click_Count != 3 && Click_Count > 4)//홀수일 때
            {
                if (card_move.Blue_Fourth_Line[0].transform.childCount == 1
                    || card_move.Blue_Fourth_Line[1].transform.childCount == 1
                    || card_move.Blue_Fourth_Line[2].transform.childCount == 1
                    || card_move.Blue_Fourth_Line[3].transform.childCount == 1
                    || card_move.Blue_Fourth_Line[4].transform.childCount == 1
                    || card_move.Blue_Fourth_Line[5].transform.childCount == 1
                    || card_move.Blue_Fourth_Line[6].transform.childCount == 1)

                {

                    if ((move_player.Player_Positions[30].childCount != 0 && move_player.Player_Positions[31].childCount != 0)
                    || (move_player.Player_Positions[28].childCount != 0 && move_player.Player_Positions[29].childCount != 0)
                    || (move_player.Player_Positions[26].childCount != 0 && move_player.Player_Positions[27].childCount != 0)
                    || (move_player.Player_Positions[24].childCount != 0 && move_player.Player_Positions[25].childCount != 0)
                    || (move_player.Player_Positions[22].childCount != 0 && move_player.Player_Positions[23].childCount != 0)
                    || (move_player.Player_Positions[20].childCount != 0 && move_player.Player_Positions[21].childCount != 0)
                    || (move_player.Player_Positions[18].childCount != 0 && move_player.Player_Positions[19].childCount != 0)
                    || (move_player.Player_Positions[16].childCount != 0 && move_player.Player_Positions[17].childCount != 0)
                    || (move_player.Player_Positions[14].childCount != 0 && move_player.Player_Positions[15].childCount != 0)
                    || (move_player.Player_Positions[12].childCount != 0 && move_player.Player_Positions[13].childCount != 0)
                    || (move_player.Player_Positions[10].childCount != 0 && move_player.Player_Positions[11].childCount != 0)
                    || (move_player.Player_Positions[8].childCount != 0 && move_player.Player_Positions[9].childCount != 0)
                    || (move_player.Player_Positions[6].childCount != 0 && move_player.Player_Positions[7].childCount != 0)
                    || (move_player.Player_Positions[4].childCount != 0 && move_player.Player_Positions[5].childCount != 0)
                    || (move_player.Player_Positions[2].childCount != 0 && move_player.Player_Positions[3].childCount != 0)
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))
                    {
                        return;
                    }

                    else
                    {


                        PlayAnimationOnFirstChildObjects_Blue(card_move.Blue_Fourth_Line[0].transform);
                        PlayAnimationOnFirstChildObjects_Blue(card_move.Blue_Fourth_Line[1].transform);
                        PlayAnimationOnFirstChildObjects_Blue(card_move.Blue_Fourth_Line[2].transform);
                        PlayAnimationOnFirstChildObjects_Blue(card_move.Blue_Fourth_Line[3].transform);
                        PlayAnimationOnFirstChildObjects_Blue(card_move.Blue_Fourth_Line[4].transform);
                        PlayAnimationOnFirstChildObjects_Blue(card_move.Blue_Fourth_Line[5].transform);
                        PlayAnimationOnFirstChildObjects_Blue(card_move.Blue_Fourth_Line[6].transform);

                        StartCoroutine(Go_Next1());


                        IEnumerator Go_Next1()
                        {
                            yield return new WaitForSeconds(2.8f);
                            Blue_1.SetActive(false);
                            Blue_2.SetActive(false);

                            //파랑 재료 칸을 false하고 
                            //분홍 재료 칸을 true로 만들기

                            Blue_Material_Canvas.SetActive(false);
                            Pink_Material_Canvas.SetActive(true);
                            //코드 실행하지 않음-분홍

                            Good_Bad_Blue_1.SetActive(false);
                            Good_Bad_Blue_2.SetActive(false);

                            Good_Bad_Pink_1.SetActive(true);
                            Good_Bad_Pink_2.SetActive(true);

                            Coin_Blue_1.SetActive(false);
                       

                            Coin_Pink_1.SetActive(true);
                    

                            blue_pink.Pink_Cups1[0].SetActive(true);
                            blue_pink.Pink_Cups1[1].SetActive(true);
                            blue_pink.Pink_Cups1[2].SetActive(true);

                            blue_pink.Pink_Cups2[0].SetActive(false);
                            blue_pink.Pink_Cups2[1].SetActive(false);
                            blue_pink.Pink_Cups2[2].SetActive(false);

                            blue_pink.Blue_Cups1[0].SetActive(false);
                            blue_pink.Blue_Cups1[1].SetActive(false);
                            blue_pink.Blue_Cups1[2].SetActive(false);

                            blue_pink.Blue_Cups2[0].SetActive(false);
                            blue_pink.Blue_Cups2[1].SetActive(false);
                            blue_pink.Blue_Cups2[2].SetActive(false);
                        }
                    }

                }

                else if (card_move.Blue_Fourth_Line[0].transform.childCount == 0
                    && card_move.Blue_Fourth_Line[1].transform.childCount == 0
                    && card_move.Blue_Fourth_Line[2].transform.childCount == 0
                    && card_move.Blue_Fourth_Line[3].transform.childCount == 0
                    && card_move.Blue_Fourth_Line[4].transform.childCount == 0
                    && card_move.Blue_Fourth_Line[5].transform.childCount == 0
                    && card_move.Blue_Fourth_Line[6].transform.childCount == 0
                    )
                {

                    if ((move_player.Player_Positions[30].childCount != 0 && move_player.Player_Positions[31].childCount != 0)
                   || (move_player.Player_Positions[28].childCount != 0 && move_player.Player_Positions[29].childCount != 0)
                   || (move_player.Player_Positions[26].childCount != 0 && move_player.Player_Positions[27].childCount != 0)
                   || (move_player.Player_Positions[24].childCount != 0 && move_player.Player_Positions[25].childCount != 0)
                   || (move_player.Player_Positions[22].childCount != 0 && move_player.Player_Positions[23].childCount != 0)
                   || (move_player.Player_Positions[20].childCount != 0 && move_player.Player_Positions[21].childCount != 0)
                   || (move_player.Player_Positions[18].childCount != 0 && move_player.Player_Positions[19].childCount != 0)
                   || (move_player.Player_Positions[16].childCount != 0 && move_player.Player_Positions[17].childCount != 0)
                   || (move_player.Player_Positions[14].childCount != 0 && move_player.Player_Positions[15].childCount != 0)
                   || (move_player.Player_Positions[12].childCount != 0 && move_player.Player_Positions[13].childCount != 0)
                   || (move_player.Player_Positions[10].childCount != 0 && move_player.Player_Positions[11].childCount != 0)
                   || (move_player.Player_Positions[8].childCount != 0 && move_player.Player_Positions[9].childCount != 0)
                   || (move_player.Player_Positions[6].childCount != 0 && move_player.Player_Positions[7].childCount != 0)
                   || (move_player.Player_Positions[4].childCount != 0 && move_player.Player_Positions[5].childCount != 0)
                   || (move_player.Player_Positions[2].childCount != 0 && move_player.Player_Positions[3].childCount != 0)
                   || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))
                    {
                        return;
                    }

                    else
                    {
                        Debug.Log("설마 너야?");

                        PlayAnimationOnFirstChildObjects_1_Blue();

                        StartCoroutine(Go_Next1());


                        IEnumerator Go_Next1()
                        {
                            yield return new WaitForSeconds(0.5f);
                            Blue_1.SetActive(false);
                            Blue_2.SetActive(false);

                            //파랑 재료 칸을 false하고 
                            //분홍 재료 칸을 true로 만들기

                            Blue_Material_Canvas.SetActive(false);
                            Pink_Material_Canvas.SetActive(true);
                            //코드 실행하지 않음-분홍

                            Good_Bad_Blue_1.SetActive(false);
                            Good_Bad_Blue_2.SetActive(false);

                            Good_Bad_Pink_1.SetActive(true);
                            Good_Bad_Pink_2.SetActive(true);

                            Coin_Blue_1.SetActive(false);
                         

                            Coin_Pink_1.SetActive(true);
                        

                            blue_pink.Pink_Cups1[0].SetActive(true);
                            blue_pink.Pink_Cups1[1].SetActive(true);
                            blue_pink.Pink_Cups1[2].SetActive(true);

                            blue_pink.Pink_Cups2[0].SetActive(false);
                            blue_pink.Pink_Cups2[1].SetActive(false);
                            blue_pink.Pink_Cups2[2].SetActive(false);

                            blue_pink.Blue_Cups1[0].SetActive(false);
                            blue_pink.Blue_Cups1[1].SetActive(false);
                            blue_pink.Blue_Cups1[2].SetActive(false);

                            blue_pink.Blue_Cups2[0].SetActive(false);
                            blue_pink.Blue_Cups2[1].SetActive(false);
                            blue_pink.Blue_Cups2[2].SetActive(false);
                        }
                    }

                }


            }

            else if (Click_Count == 1 && Click_Count != 3)//홀수일 때
            {//폴수일 때 블루가 먼저면 블루가 실행
                StartCoroutine(Go_Next1());


                IEnumerator Go_Next1()
                {
                    yield return new WaitForSeconds(0.0f);
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);

                    Blue_1.SetActive(false);
                    Blue_2.SetActive(true);

                    //파랑 재료 칸을 false하고 
                    //분홍 재료 칸을 true로 만들기

                    Blue_Material_Canvas.SetActive(true);
                    Pink_Material_Canvas.SetActive(false);
                    //코드 실행하지 않음-분홍

                    Good_Bad_Blue_1.SetActive(true);
                    Good_Bad_Blue_2.SetActive(true);

                    Good_Bad_Pink_1.SetActive(false);
                    Good_Bad_Pink_2.SetActive(false);

                    Coin_Blue_1.SetActive(true);
            

                    Coin_Pink_1.SetActive(false);
              

                    blue_pink.Pink_Cups1[0].SetActive(false);
                    blue_pink.Pink_Cups1[1].SetActive(false);
                    blue_pink.Pink_Cups1[2].SetActive(false);

                    blue_pink.Pink_Cups2[0].SetActive(false);
                    blue_pink.Pink_Cups2[1].SetActive(false);
                    blue_pink.Pink_Cups2[2].SetActive(false);

                    blue_pink.Blue_Cups1[0].SetActive(true);
                    blue_pink.Blue_Cups1[1].SetActive(true);
                    blue_pink.Blue_Cups1[2].SetActive(true);

                    blue_pink.Blue_Cups2[0].SetActive(false);
                    blue_pink.Blue_Cups2[1].SetActive(false);
                    blue_pink.Blue_Cups2[2].SetActive(false);
                }


            }

            else if (Click_Count != 1 && Click_Count == 3)//홀수일 때
            {//폴수일 때 블루가 먼저면 블루가 실행

                StartCoroutine(Go_Next1());


                IEnumerator Go_Next1()
                {
                    yield return new WaitForSeconds(0.0f);
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);

                    Blue_1.SetActive(true);
                    Blue_2.SetActive(false);

                    //파랑 재료 칸을 false하고 
                    //분홍 재료 칸을 true로 만들기

                    Blue_Material_Canvas.SetActive(true);
                    Pink_Material_Canvas.SetActive(false);
                    //코드 실행하지 않음-분홍

                    Good_Bad_Blue_1.SetActive(true);
                    Good_Bad_Blue_2.SetActive(true);

                    Good_Bad_Pink_1.SetActive(false);
                    Good_Bad_Pink_2.SetActive(false);

                    Coin_Blue_1.SetActive(true);
                   

                    Coin_Pink_1.SetActive(false);
             

                    blue_pink.Pink_Cups1[0].SetActive(false);
                    blue_pink.Pink_Cups1[1].SetActive(false);
                    blue_pink.Pink_Cups1[2].SetActive(false);

                    blue_pink.Pink_Cups2[0].SetActive(false);
                    blue_pink.Pink_Cups2[1].SetActive(false);
                    blue_pink.Pink_Cups2[2].SetActive(false);

                    blue_pink.Blue_Cups1[0].SetActive(true);
                    blue_pink.Blue_Cups1[1].SetActive(true);
                    blue_pink.Blue_Cups1[2].SetActive(true);

                    blue_pink.Blue_Cups2[0].SetActive(false);
                    blue_pink.Blue_Cups2[1].SetActive(false);
                    blue_pink.Blue_Cups2[2].SetActive(false);
                }


            }
        }

    }


    public void PlayAnimationOnFirstChildObjects(Transform parentTransform)
    {
        // parentTransform 오브젝트의 모든 첫 번째 자식들의 Animator 컴포넌트를 찾기
        Animator[] childAnimators = parentTransform.GetComponentsInChildren<Animator>();

        // 찾은 Animator 컴포넌트들에 "Go_Red" 애니메이션을 실행
        foreach (Animator animator in childAnimators)
        {
            // Animator 컴포넌트가 존재하고, 애니메이션을 재생할 준비가 되었는지 확인
            if (animator != null && animator.runtimeAnimatorController != null)
            {


                // "Go_Red" 애니메이션을 실행
                animator.SetBool("Go_Red", true);

                StartCoroutine(Stop_Anim());

                StartCoroutine(Next_Card1());
                StartCoroutine(Next_Card2());




                IEnumerator Stop_Anim()
                {
                    yield return new WaitForSeconds(2.0f);
                    animator.SetBool("Go_Red", false);


                    good_bad.Bad_Ccount++; // 배드 추가
                    good_bad.Update_Bad_Count(); // 배드 추가 출력 코드

                    good_bad.Ccoin_Count++;//코인 추가
                    good_bad.Update_Coin_Count();//코인 추가 출력 코드




                    //배드 카운트가 5 이상이면
                    //만약 핑크가 선일때
                    //즉 Open이 되어있는 경우
                    if (Open_Pink.activeSelf == true && Close_Pink.activeSelf == false)
                    {
                        if (good_bad.Bad_Ccount == 5 || good_bad.Bad_Ccount > 5 || card_move.usedCardCount == 80)
                        {
                            //핑크가 빨갛게 되는 거 
                            //핑크가 시작되는데 핑크가 5개일때
                            Open_Pink.SetActive(false);
                            Close_Pink.SetActive(true);

                            Debug.Log("핑크 닫힘 활성화");
                        }

                        else
                        {
                            Open_Pink.SetActive(true);
                            Close_Pink.SetActive(false);


                        }
                    }

                    //만약 블루가 선일때
                    //즉 Open이 되어있는 경우
                    else if (Open_Blue.activeSelf == true && Close_Blue.activeSelf == false)
                    {
                        if (good_bad.Bad_Ccount == 5 || good_bad.Bad_Ccount > 5 || card_move.usedCardCount == 80)
                        {
                            Open_Blue.SetActive(false);
                            Close_Blue.SetActive(true);

                            Debug.Log("블루 닫힘 활성화");

                        }

                        else
                        {
                            Open_Blue.SetActive(true);
                            Close_Blue.SetActive(false);


                        }
                    }

                    else if (Close_Pink.activeSelf == true)
                    {
                        //빨강 클로오즈드가 활성화
                        //참고로 이건 핑크에서 블루 넘어가는 코드에 있는 거다.
                        Debug.Log("핑크 코인 개수는 증가하되 이 다음 블루가 마지막 턴임");


                        //여기서 새로운 변수의 숫자를 추가해주장

                        //핑크가 시작인데
                        //핑크에서 다음으로 넘어가는 버튼인데 
                        //이미 끝났다면 

                        ;
                    }

                    else if (Close_Blue.activeSelf == true)
                    {
                        //빨강 클로오즈드가 활성화
                        //참고로 이건 핑크에서 블루 넘어가는 코드에 있는 거다.

                        //계속 진행
                        Debug.Log("핑크 마지막 턴 - 이 다음부터는 바로 스코어 나와야 함.");


                    }





                    sfx.SFX_Fail_Menu();

                    //여기서 밑에 있는 for문 없애고 수정
                    //0827

                    if ((card_move.Pink_Fourth_Line[0].transform.childCount == 1)
                    || (card_move.Pink_Fourth_Line[1].transform.childCount == 1)
                    || (card_move.Pink_Fourth_Line[2].transform.childCount == 1)
                    || (card_move.Pink_Fourth_Line[3].transform.childCount == 1)
                    || (card_move.Pink_Fourth_Line[4].transform.childCount == 1)
                    || (card_move.Pink_Fourth_Line[5].transform.childCount == 1)
                    || (card_move.Pink_Fourth_Line[6].transform.childCount == 1))
                    {
                        if (Close_Pink.activeSelf == true)
                        {
                            //만약 핑크가 선인데
                            //핑크가 닫혔을 때

                            //더 이상 아무것도 하지 않는다
                            //Debug.Log("아무것도 하지 않음");
                            if (card_move.Pink_Fourth_Line[0].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[0].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Pink_Fourth_Line[1].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[1].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Pink_Fourth_Line[2].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[2].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Pink_Fourth_Line[3].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[3].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Pink_Fourth_Line[4].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[4].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Pink_Fourth_Line[5].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[5].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Pink_Fourth_Line[6].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[6].transform.GetChild(0).gameObject);
                            }
                        }

                        else if (Close_Blue.activeSelf == true)
                        {
                            //만약 블루가 선인데 블루가 닫혔을 때
                            if (card_move.Pink_Fourth_Line[0].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[0].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Pink_Fourth_Line[1].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[1].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Pink_Fourth_Line[2].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[2].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Pink_Fourth_Line[3].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[3].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Pink_Fourth_Line[4].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[4].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Pink_Fourth_Line[5].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[5].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Pink_Fourth_Line[6].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[6].transform.GetChild(0).gameObject);
                            }

                            Debug.Log("이 핑크가 마지막 턴. 이 핑크 턴 하고 이제 스코어 나타내기");

                            StartCoroutine(Show_Score());
                            IEnumerator Show_Score()
                            {
                                yield return new WaitForSeconds(0.25f);
                                next_turn.Score.SetActive(true);

                                next_turn.Stay_Curtain_Left.SetActive(true);
                                next_turn.Stay_Curtain_Right.SetActive(true);

                                next_turn.Open_Curtain_Left.SetActive(false);
                                next_turn.Open_Curtain_Right.SetActive(false);

                                next_turn.Close_Curtain_Left.SetActive(false);
                                next_turn.Close_Curtain_Right.SetActive(false);

                                next_turn.Text_Game_Result.SetActive(true);
                                next_turn.Text_Pink_Team_Win.SetActive(false);
                                next_turn.Text_Blue_Team_Win.SetActive(false);

                                next_turn.About_Blue.SetActive(true);
                                next_turn.About_Pink.SetActive(true);
                            }



                            StartCoroutine(Show_Wall());
                            StartCoroutine(Show_Wall_Next());
                            IEnumerator Show_Wall()
                            {
                                yield return new WaitForSeconds(1.25f);

                                next_turn.Wall.SetActive(true);

                                next_turn.Open_Curtain_Left.SetActive(true);
                                next_turn.Open_Curtain_Right.SetActive(true);

                                next_turn.Stay_Curtain_Left.SetActive(false);
                                next_turn.Stay_Curtain_Right.SetActive(false);
                            }


                            IEnumerator Show_Wall_Next()
                            {
                                yield return new WaitForSeconds(1.2505f);
                                next_turn.score.Update_Score();
                            }
                        }

                        else
                        {
                            if (card_move.Pink_Fourth_Line[0].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[0].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Pink_Fourth_Line[1].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[1].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Pink_Fourth_Line[2].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[2].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Pink_Fourth_Line[3].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[3].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Pink_Fourth_Line[4].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[4].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Pink_Fourth_Line[5].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[5].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Pink_Fourth_Line[6].transform.childCount > 0)
                            {
                                Destroy(card_move.Pink_Fourth_Line[6].transform.GetChild(0).gameObject);
                            }
                        }

                        //Destroy(card_move.Pink_Fourth_Line[i].transform.GetChild(0).gameObject);
                    }

                    /*else if ((card_move.Pink_Fourth_Line[0].transform.childCount == 0)
                    && (card_move.Pink_Fourth_Line[1].transform.childCount == 0)
                    && (card_move.Pink_Fourth_Line[2].transform.childCount == 0)
                    && (card_move.Pink_Fourth_Line[3].transform.childCount == 0)
                    && (card_move.Pink_Fourth_Line[4].transform.childCount == 0)
                    && (card_move.Pink_Fourth_Line[5].transform.childCount == 0)
                    && (card_move.Pink_Fourth_Line[6].transform.childCount == 0))
                   {
                        //Debug.Log("자식 없음");

                        //새로 추가0827
                        if (Close_Pink.activeSelf == true)
                        {
                            //만약 핑크가 선인데
                            //핑크가 닫혔을 때

                            //더 이상 아무것도 하지 않는다
                            //Debug.Log("아무것도 하지 않음");
                            Debug.Log("자식 없음");
                        }

                        else if (Close_Blue.activeSelf == true)
                        {
                            //만약 블루가 선인데 블루가 닫혔을 때
                            //Destroy(card_move.Pink_Fourth_Line[i].transform.GetChild(0).gameObject);

                            Debug.Log("이 핑크가 마지막 턴. 이 핑크 턴 하고 이제 스코어 나타내기");

                            StartCoroutine(Show_Score());
                            IEnumerator Show_Score()
                            {
                                yield return new WaitForSeconds(0.25f);
                                next_turn.Score.SetActive(true);

                                next_turn.Stay_Curtain_Left.SetActive(true);
                                next_turn.Stay_Curtain_Right.SetActive(true);

                                next_turn.Open_Curtain_Left.SetActive(false);
                                next_turn.Open_Curtain_Right.SetActive(false);

                                next_turn.Close_Curtain_Left.SetActive(false);
                                next_turn.Close_Curtain_Right.SetActive(false);

                                next_turn.Text_Game_Result.SetActive(true);
                                next_turn.Text_Pink_Team_Win.SetActive(false);
                                next_turn.Text_Blue_Team_Win.SetActive(false);

                                next_turn.About_Blue.SetActive(true);
                                next_turn.About_Pink.SetActive(true);
                            }



                            StartCoroutine(Show_Wall());
                            StartCoroutine(Show_Wall_Next());
                            IEnumerator Show_Wall()
                            {
                                yield return new WaitForSeconds(1.25f);

                                next_turn.Wall.SetActive(true);

                                next_turn.Open_Curtain_Left.SetActive(true);
                                next_turn.Open_Curtain_Right.SetActive(true);

                                next_turn.Stay_Curtain_Left.SetActive(false);
                                next_turn.Stay_Curtain_Right.SetActive(false);
                            }


                            IEnumerator Show_Wall_Next()
                            {
                                yield return new WaitForSeconds(1.2505f);
                                next_turn.score.Update_Score();
                            }
                        }

                        else
                        {
                            Debug.Log("자식 없음");
                            //Destroy(card_move.Pink_Fourth_Line[i].transform.GetChild(0).gameObject);
                        }
                    }*/





                    //주문 처리 못한 거 삭제
                    /*for (int i = 0; i < card_move.Pink_Fourth_Line.Length; i++)
                    {
                        if (card_move.Pink_Fourth_Line[i].transform.childCount == 1)
                        {
                            if (Close_Pink.activeSelf == true)
                            {
                                //만약 핑크가 선인데
                                //핑크가 닫혔을 때

                                //더 이상 아무것도 하지 않는다
                                //Debug.Log("아무것도 하지 않음");
                                Destroy(card_move.Pink_Fourth_Line[i].transform.GetChild(0).gameObject);
                            }

                            else if (Close_Blue.activeSelf == true)
                            {
                                //만약 블루가 선인데 블루가 닫혔을 때
                                Destroy(card_move.Pink_Fourth_Line[i].transform.GetChild(0).gameObject);

                                Debug.Log("이 핑크가 마지막 턴. 이 핑크 턴 하고 이제 스코어 나타내기");

                                StartCoroutine(Show_Score());
                                IEnumerator Show_Score()
                                {
                                    yield return new WaitForSeconds(0.25f);
                                    next_turn.Score.SetActive(true);

                                    next_turn.Stay_Curtain_Left.SetActive(true);
                                    next_turn.Stay_Curtain_Right.SetActive(true);

                                    next_turn.Open_Curtain_Left.SetActive(false);
                                    next_turn.Open_Curtain_Right.SetActive(false);

                                    next_turn.Close_Curtain_Left.SetActive(false);
                                    next_turn.Close_Curtain_Right.SetActive(false);

                                    next_turn.Text_Game_Result.SetActive(true);
                                    next_turn.Text_Pink_Team_Win.SetActive(false);
                                    next_turn.Text_Blue_Team_Win.SetActive(false);

                                    next_turn.About_Blue.SetActive(true);
                                    next_turn.About_Pink.SetActive(true);
                                }

                                 

                                StartCoroutine(Show_Wall());
                                StartCoroutine(Show_Wall_Next());
                                IEnumerator Show_Wall()
                                {
                                    yield return new WaitForSeconds(1.25f);

                                    next_turn.Wall.SetActive(true);

                                    next_turn.Open_Curtain_Left.SetActive(true);
                                    next_turn.Open_Curtain_Right.SetActive(true);

                                    next_turn.Stay_Curtain_Left.SetActive(false);
                                    next_turn.Stay_Curtain_Right.SetActive(false);
                                }


                                IEnumerator Show_Wall_Next()
                                {
                                    yield return new WaitForSeconds(1.2505f);
                                    next_turn.score.Update_Score();
                                }
                            }

                            else
                            {
                                Destroy(card_move.Pink_Fourth_Line[i].transform.GetChild(0).gameObject);
                            }

                            //Destroy(card_move.Pink_Fourth_Line[i].transform.GetChild(0).gameObject);
                        }

                        else if (card_move.Pink_Fourth_Line[i].transform.childCount == 0)
                        {
                            //Debug.Log("자식 없음");

                            //새로 추가0827
                            if (Close_Pink.activeSelf == true)
                            {
                                //만약 핑크가 선인데
                                //핑크가 닫혔을 때

                                //더 이상 아무것도 하지 않는다
                                //Debug.Log("아무것도 하지 않음");
                                Debug.Log("자식 없음");
                            }

                            else if (Close_Blue.activeSelf == true)
                            {
                                //만약 블루가 선인데 블루가 닫혔을 때
                                //Destroy(card_move.Pink_Fourth_Line[i].transform.GetChild(0).gameObject);

                                Debug.Log("이 핑크가 마지막 턴. 이 핑크 턴 하고 이제 스코어 나타내기");

                                StartCoroutine(Show_Score());
                                IEnumerator Show_Score()
                                {
                                    yield return new WaitForSeconds(0.25f);
                                    next_turn.Score.SetActive(true);

                                    next_turn.Stay_Curtain_Left.SetActive(true);
                                    next_turn.Stay_Curtain_Right.SetActive(true);

                                    next_turn.Open_Curtain_Left.SetActive(false);
                                    next_turn.Open_Curtain_Right.SetActive(false);

                                    next_turn.Close_Curtain_Left.SetActive(false);
                                    next_turn.Close_Curtain_Right.SetActive(false);

                                    next_turn.Text_Game_Result.SetActive(true);
                                    next_turn.Text_Pink_Team_Win.SetActive(false);
                                    next_turn.Text_Blue_Team_Win.SetActive(false);

                                    next_turn.About_Blue.SetActive(true);
                                    next_turn.About_Pink.SetActive(true);
                                }



                                StartCoroutine(Show_Wall());
                                StartCoroutine(Show_Wall_Next());
                                IEnumerator Show_Wall()
                                {
                                    yield return new WaitForSeconds(1.25f);

                                    next_turn.Wall.SetActive(true);

                                    next_turn.Open_Curtain_Left.SetActive(true);
                                    next_turn.Open_Curtain_Right.SetActive(true);

                                    next_turn.Stay_Curtain_Left.SetActive(false);
                                    next_turn.Stay_Curtain_Right.SetActive(false);
                                }


                                IEnumerator Show_Wall_Next()
                                {
                                    yield return new WaitForSeconds(1.2505f);
                                    next_turn.score.Update_Score();
                                }
                            }

                            else
                            {
                                Debug.Log("자식 없음");
                                //Destroy(card_move.Pink_Fourth_Line[i].transform.GetChild(0).gameObject);
                            }
                        }


                    }*/



                    //세 번째 줄에 있던 거 네 번쨰 줄로 이동
                    for (int i = 0; i < card_move.Pink_Third_Line.Length; i++)
                    {
                        if (card_move.Pink_Third_Line[i].transform.childCount == 1)
                        {
                            if (Close_Pink.activeSelf == true)
                            {
                                //만약 핑크가 선인데
                                //핑크가 닫혔을 때

                                Transform childToMove = card_move.Pink_Third_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Pink_Fourth_Line[i].transform, false);

                                //더 이상 아무것도 하지 않는다
                                // Debug.Log("아무것도 하지 않음");
                            }

                            else if (Close_Blue.activeSelf == true)
                            {
                                //만약 블루가 선인데 블루가 닫혔을 때
                                Transform childToMove = card_move.Pink_Third_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Pink_Fourth_Line[i].transform, false);

                                Debug.Log("이 핑크가 마지막 턴. 이 핑크 턴 하고 이제 스코어 나타내기");
                            }

                            else
                            {
                                Transform childToMove = card_move.Pink_Third_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Pink_Fourth_Line[i].transform, false);
                            }

                            // Pink_Third_Line[i]에 자식이 1개 있는 경우
                            // 해당 자식을 Pink_Fourth_Line[i]의 첫 번째 자식으로 옮김
                            /*Transform childToMove = card_move.Pink_Third_Line[i].transform.GetChild(0);

                            childToMove.SetParent(card_move.Pink_Fourth_Line[i].transform, false);*/



                        }

                        else if (card_move.Pink_Third_Line[i].transform.childCount == 0)
                        {
                            Debug.Log("자식 없음");
                        }
                    }

                }

                IEnumerator Next_Card1()
                {
                    yield return new WaitForSeconds(2.005f);
                    //두 번째 줄에 있던 거 세 번째 줄로 이동
                    for (int i = 0; i < card_move.Pink_Second_Line.Length; i++)
                    {
                        if (card_move.Pink_Second_Line[i].transform.childCount == 1)
                        {
                            if (Close_Pink.activeSelf == true)
                            {
                                //만약 핑크가 선인데
                                //핑크가 닫혔을 때

                                Transform childToMove = card_move.Pink_Second_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Pink_Third_Line[i].transform, false);

                                //더 이상 아무것도 하지 않는다
                                //Debug.Log("아무것도 하지 않음");
                            }

                            else if (Close_Blue.activeSelf == true)
                            {
                                //만약 블루가 선인데 블루가 닫혔을 때
                                Transform childToMove = card_move.Pink_Second_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Pink_Third_Line[i].transform, false);

                                Debug.Log("이 핑크가 마지막 턴. 이 핑크 턴 하고 이제 스코어 나타내기");


                            }

                            else
                            {
                                Transform childToMove = card_move.Pink_Second_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Pink_Third_Line[i].transform, false);
                            }

                            // Pink_Second_Line[i]에 자식이 1개 있는 경우
                            // 해당 자식을 Pink_Third_Line[i]의 첫 번째 자식으로 옮김
                            /*Transform childToMove = card_move.Pink_Second_Line[i].transform.GetChild(0);
                            childToMove.SetParent(card_move.Pink_Third_Line[i].transform, false);*/
                        }

                        else if (card_move.Pink_Second_Line[i].transform.childCount == 0)
                        {
                            Debug.Log("자식 없음");
                        }
                    }
                }

                IEnumerator Next_Card2()
                {
                    yield return new WaitForSeconds(2.01f);
                    //첫 번째 줄에 있던 거 두 번쨰 줄로 이동
                    for (int i = 0; i < card_move.Pink_First_Line.Length; i++)
                    {
                        if (card_move.Pink_First_Line[i].transform.childCount == 1)
                        {

                            if (Close_Pink.activeSelf == true)
                            {
                                //만약 핑크가 선인데
                                //핑크가 닫혔을 때

                                Transform childToMove2 = card_move.Pink_First_Line[i].transform.GetChild(0);
                                childToMove2.SetParent(card_move.Pink_Second_Line[i].transform, false);

                                //더 이상 아무것도 하지 않는다
                                //Debug.Log("아무것도 하지 않음");
                            }

                            else if (Close_Blue.activeSelf == true)
                            {
                                //만약 블루가 선인데 블루가 닫혔을 때
                                Transform childToMove2 = card_move.Pink_First_Line[i].transform.GetChild(0);
                                childToMove2.SetParent(card_move.Pink_Second_Line[i].transform, false);

                                Debug.Log("이 핑크가 마지막 턴. 이 핑크 턴 하고 이제 스코어 나타내기");
                            }

                            else
                            {
                                Transform childToMove2 = card_move.Pink_First_Line[i].transform.GetChild(0);
                                childToMove2.SetParent(card_move.Pink_Second_Line[i].transform, false);
                            }
                            // Pink_Third_Line[i]에 자식이 1개 있는 경우
                            // 해당 자식을 Pink_Fourth_Line[i]의 첫 번째 자식으로 옮김
                            /* Transform childToMove2 = card_move.Pink_First_Line[i].transform.GetChild(0);
                             childToMove2.SetParent(card_move.Pink_Second_Line[i].transform, false);*/
                        }

                        else if (card_move.Pink_First_Line[i].transform.childCount == 0)//자식이 없는 경우의 로직도 짜야함
                        {
                            Debug.Log("자식 없음");
                        }
                    }
                }
            }




        }
    }

    public void PlayAnimationOnFirstChildObjects_1()//네 번째 줄에 자식이 없는 경우
    {
        // parentTransform 오브젝트의 모든 첫 번째 자식들의 Animator 컴포넌트를 찾기

        StartCoroutine(Stop_Anim());

        StartCoroutine(Next_Card1());
        StartCoroutine(Next_Card2());


        IEnumerator Stop_Anim()
        {
            yield return new WaitForSeconds(0.0f);

            if ((card_move.Pink_Fourth_Line[0].transform.childCount == 0)
                        && (card_move.Pink_Fourth_Line[1].transform.childCount == 0)
                        && (card_move.Pink_Fourth_Line[2].transform.childCount == 0)
                        && (card_move.Pink_Fourth_Line[3].transform.childCount == 0)
                        && (card_move.Pink_Fourth_Line[4].transform.childCount == 0)
                        && (card_move.Pink_Fourth_Line[5].transform.childCount == 0)
                        && (card_move.Pink_Fourth_Line[6].transform.childCount == 0))
            {
                //Debug.Log("자식 없음");

                //새로 추가0827
                if (Close_Pink.activeSelf == true)
                {
                    //만약 핑크가 선인데
                    //핑크가 닫혔을 때

                    //더 이상 아무것도 하지 않는다
                    //Debug.Log("아무것도 하지 않음");
                    Debug.Log("자식 없음");
                }

                else if (Close_Blue.activeSelf == true)
                {
                    //만약 블루가 선인데 블루가 닫혔을 때
                    //Destroy(card_move.Pink_Fourth_Line[i].transform.GetChild(0).gameObject);

                    Debug.Log("이 핑크가 마지막 턴. 이 핑크 턴 하고 이제 스코어 나타내기");

                    StartCoroutine(Show_Score());
                    IEnumerator Show_Score()
                    {
                        yield return new WaitForSeconds(0.25f);
                        next_turn.Score.SetActive(true);

                        next_turn.Stay_Curtain_Left.SetActive(true);
                        next_turn.Stay_Curtain_Right.SetActive(true);

                        next_turn.Open_Curtain_Left.SetActive(false);
                        next_turn.Open_Curtain_Right.SetActive(false);

                        next_turn.Close_Curtain_Left.SetActive(false);
                        next_turn.Close_Curtain_Right.SetActive(false);

                        next_turn.Text_Game_Result.SetActive(true);
                        next_turn.Text_Pink_Team_Win.SetActive(false);
                        next_turn.Text_Blue_Team_Win.SetActive(false);

                        next_turn.About_Blue.SetActive(true);
                        next_turn.About_Pink.SetActive(true);
                    }



                    StartCoroutine(Show_Wall());
                    StartCoroutine(Show_Wall_Next());
                    IEnumerator Show_Wall()
                    {
                        yield return new WaitForSeconds(1.25f);

                        next_turn.Wall.SetActive(true);

                        next_turn.Open_Curtain_Left.SetActive(true);
                        next_turn.Open_Curtain_Right.SetActive(true);

                        next_turn.Stay_Curtain_Left.SetActive(false);
                        next_turn.Stay_Curtain_Right.SetActive(false);
                    }


                    IEnumerator Show_Wall_Next()
                    {
                        yield return new WaitForSeconds(1.2505f);
                        next_turn.score.Update_Score();
                    }
                }

                else
                {
                    Debug.Log("자식 없음");
                    //Destroy(card_move.Pink_Fourth_Line[i].transform.GetChild(0).gameObject);
                }
            }

            //세 번째 줄에 있던 거 네 번쨰 줄로 이동
            for (int i = 0; i < card_move.Pink_Third_Line.Length; i++)
            {
                if (card_move.Pink_Third_Line[i].transform.childCount == 1)
                {
                    if (Close_Pink.activeSelf == true)
                    {
                        //만약 핑크가 선인데
                        //핑크가 닫혔을 때

                        //더 이상 아무것도 하지 않는다
                        //Debug.Log("아무것도 하지 않음");

                        Transform childToMove = card_move.Pink_Third_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Pink_Fourth_Line[i].transform, false);
                    }

                    else if (Close_Blue.activeSelf == true)
                    {
                        //만약 블루가 선인데 블루가 닫혔을 때
                        Transform childToMove = card_move.Pink_Third_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Pink_Fourth_Line[i].transform, false);

                        Debug.Log("이 핑크가 마지막 턴. 이 핑크 턴 하고 이제 스코어 나타내기");
                    }

                    else
                    {
                        Transform childToMove = card_move.Pink_Third_Line[i].transform.GetChild(0);

                        childToMove.SetParent(card_move.Pink_Fourth_Line[i].transform, false);
                    }

                    // Pink_Third_Line[i]에 자식이 1개 있는 경우
                    // 해당 자식을 Pink_Fourth_Line[i]의 첫 번째 자식으로 옮김
                    /*Transform childToMove = card_move.Pink_Third_Line[i].transform.GetChild(0);

                    childToMove.SetParent(card_move.Pink_Fourth_Line[i].transform, false);*/



                }

                else if (card_move.Pink_Third_Line[i].transform.childCount == 0)
                {
                    Debug.Log("자식 없음");
                }
            }

        }

        IEnumerator Next_Card1()
        {
            yield return new WaitForSeconds(0.005f);
            //두 번째 줄에 있던 거 세 번째 줄로 이동
            for (int i = 0; i < card_move.Pink_Second_Line.Length; i++)
            {
                if (card_move.Pink_Second_Line[i].transform.childCount == 1)
                {
                    if (Close_Pink.activeSelf == true)
                    {
                        //만약 핑크가 선인데
                        //핑크가 닫혔을 때

                        Transform childToMove = card_move.Pink_Second_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Pink_Third_Line[i].transform, false);

                        //더 이상 아무것도 하지 않는다
                        //Debug.Log("아무것도 하지 않음");
                    }

                    else if (Close_Blue.activeSelf == true)
                    {
                        //만약 블루가 선인데 블루가 닫혔을 때
                        Transform childToMove = card_move.Pink_Second_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Pink_Third_Line[i].transform, false);

                        Debug.Log("이 핑크가 마지막 턴. 이 핑크 턴 하고 이제 스코어 나타내기");
                    }

                    else
                    {
                        Transform childToMove = card_move.Pink_Second_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Pink_Third_Line[i].transform, false);
                    }

                    // Pink_Second_Line[i]에 자식이 1개 있는 경우
                    // 해당 자식을 Pink_Third_Line[i]의 첫 번째 자식으로 옮김
                    /*Transform childToMove = card_move.Pink_Second_Line[i].transform.GetChild(0);
                    childToMove.SetParent(card_move.Pink_Third_Line[i].transform, false);*/
                }

                else if (card_move.Pink_Second_Line[i].transform.childCount == 0)
                {
                    Debug.Log("자식 없음");
                }
            }
        }

        IEnumerator Next_Card2()
        {
            yield return new WaitForSeconds(0.01f);
            //첫 번째 줄에 있던 거 두 번쨰 줄로 이동
            for (int i = 0; i < card_move.Pink_First_Line.Length; i++)
            {
                if (card_move.Pink_First_Line[i].transform.childCount == 1)
                {
                    if (Close_Pink.activeSelf == true)
                    {
                        //만약 핑크가 선인데
                        //핑크가 닫혔을 때

                        Transform childToMove2 = card_move.Pink_First_Line[i].transform.GetChild(0);
                        childToMove2.SetParent(card_move.Pink_Second_Line[i].transform, false);

                        //더 이상 아무것도 하지 않는다
                        //Debug.Log("아무것도 하지 않음");
                    }

                    else if (Close_Blue.activeSelf == true)
                    {
                        //만약 블루가 선인데 블루가 닫혔을 때
                        Transform childToMove2 = card_move.Pink_First_Line[i].transform.GetChild(0);
                        childToMove2.SetParent(card_move.Pink_Second_Line[i].transform, false);

                        Debug.Log("이 핑크가 마지막 턴. 이 핑크 턴 하고 이제 스코어 나타내기");
                    }

                    else
                    {
                        Transform childToMove2 = card_move.Pink_First_Line[i].transform.GetChild(0);
                        childToMove2.SetParent(card_move.Pink_Second_Line[i].transform, false);
                    }

                    // Pink_Third_Line[i]에 자식이 1개 있는 경우
                    // 해당 자식을 Pink_Fourth_Line[i]의 첫 번째 자식으로 옮김
                    /*Transform childToMove2 = card_move.Pink_First_Line[i].transform.GetChild(0);
                    childToMove2.SetParent(card_move.Pink_Second_Line[i].transform, false);*/

                }

                else if (card_move.Pink_First_Line[i].transform.childCount == 0)//자식이 없는 경우의 로직도 짜야함
                {
                    Debug.Log("자식 없음");
                }
            }
        }



    }


    public void PlayAnimationOnFirstChildObjects_Blue(Transform parentTransform)
    {
        // parentTransform 오브젝트의 모든 첫 번째 자식들의 Animator 컴포넌트를 찾기
        Animator[] childAnimators = parentTransform.GetComponentsInChildren<Animator>();

        // 찾은 Animator 컴포넌트들에 "Go_Red" 애니메이션을 실행
        foreach (Animator animator in childAnimators)
        {
            // Animator 컴포넌트가 존재하고, 애니메이션을 재생할 준비가 되었는지 확인
            if (animator != null && animator.runtimeAnimatorController != null)
            {

                //여긴 원래 있던 거
                // "Go_Red" 애니메이션을 실행
                animator.SetBool("Go_Red", true);



                StartCoroutine(Stop_Anim_Blue());

                StartCoroutine(Next_Card1_Blue());
                StartCoroutine(Next_Card2_Blue());


                IEnumerator Stop_Anim_Blue()
                {
                    yield return new WaitForSeconds(2.0f);
                    animator.SetBool("Go_Red", false);


                    good_bad.Bad_Ccount_Blue++; // 배드 추가
                    good_bad.Update_Bad_Count_Blue(); // 배드 추가 출력 코드

                    good_bad.Ccoin_Count_Blue++;//코인 추가
                    good_bad.Update_Coin_Count_Blue();//코인 추가 출력 코드



                    //배드 카운트가 5 이상이면
                    //만약 핑크가 선일때
                    //즉 Open이 되어있는 경우
                    if (Open_Pink.activeSelf == true && Close_Pink.activeSelf == false)
                    {
                        if (good_bad.Bad_Ccount_Blue == 5 || good_bad.Bad_Ccount_Blue > 5 || card_move.usedCardCount == 80)
                        {
                            Open_Pink.SetActive(false);
                            Close_Pink.SetActive(true);

                            Debug.Log("핑크 닫힘 활성화");
                        }

                        else
                        {
                            Open_Pink.SetActive(true);
                            Close_Pink.SetActive(false);

                        }
                    }

                    //만약 블루가 선일때
                    //즉 Open이 되어있는 경우
                    else if (Open_Blue.activeSelf == true && Close_Blue.activeSelf == false)
                    {
                        if (good_bad.Bad_Ccount_Blue == 5 || good_bad.Bad_Ccount_Blue > 5 || card_move.usedCardCount == 80)
                        {
                            Open_Blue.SetActive(false);
                            Close_Blue.SetActive(true);

                            Debug.Log("블루 닫힘 활성화");

                        }

                        else
                        {
                            Open_Blue.SetActive(true);
                            Close_Blue.SetActive(false);

                        }
                    }

                    else if (Close_Blue.activeSelf == true)
                    {
                        //블루가 선일 때
                        //블루 닫힘이 활성화 되어있을 땨

                        //다음으로 넘기기
                        Debug.Log("블루는 계속 진행, 다음 핑크가 마지막 턴");
                    }

                    else if (Close_Pink.activeSelf == true)
                    {
                        //핑크가 선일 때
                        //핑크 닫힘이 활성화 되어있을 때

                        // 블루는 계속 진행되어야 함
                        Debug.Log("이 블루가 마지막 턴. 이 블루 턴 하고 이제 스코어 나타내기");
                    }


                    sfx.SFX_Fail_Menu();

                    //새로 변경0827
                    /* for (int i = 0; i < card_move.Blue_Fourth_Line.Length; i++)
                     {*/
                    if ((card_move.Blue_Fourth_Line[0].transform.childCount == 1)
                    || (card_move.Blue_Fourth_Line[1].transform.childCount == 1)
                    || (card_move.Blue_Fourth_Line[2].transform.childCount == 1)
                    || (card_move.Blue_Fourth_Line[3].transform.childCount == 1)
                    || (card_move.Blue_Fourth_Line[4].transform.childCount == 1)
                    || (card_move.Blue_Fourth_Line[5].transform.childCount == 1)
                    || (card_move.Blue_Fourth_Line[6].transform.childCount == 1))
                    {
                        if (Close_Pink.activeSelf == true)
                        {

                            if (card_move.Blue_Fourth_Line[0].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[0].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Blue_Fourth_Line[1].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[1].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Blue_Fourth_Line[2].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[2].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Blue_Fourth_Line[3].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[3].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Blue_Fourth_Line[4].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[4].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Blue_Fourth_Line[5].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[5].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Blue_Fourth_Line[6].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[6].transform.GetChild(0).gameObject);
                            }

                            Debug.Log("이 블루가 마지막 턴. 이 블루 턴 하고 이제 스코어 나타내기");

                            //여기부터 새로 추가
                            Debug.Log("이제 스코어 나타내기");

                            StartCoroutine(Show_Score());
                            IEnumerator Show_Score()
                            {
                                yield return new WaitForSeconds(0.25f);
                                next_turn.Score.SetActive(true);

                                next_turn.Stay_Curtain_Left.SetActive(true);
                                next_turn.Stay_Curtain_Right.SetActive(true);

                                next_turn.Open_Curtain_Left.SetActive(false);
                                next_turn.Open_Curtain_Right.SetActive(false);

                                next_turn.Close_Curtain_Left.SetActive(false);
                                next_turn.Close_Curtain_Right.SetActive(false);

                                next_turn.Text_Game_Result.SetActive(true);
                                next_turn.Text_Pink_Team_Win.SetActive(false);
                                next_turn.Text_Blue_Team_Win.SetActive(false);

                                next_turn.About_Blue.SetActive(true);
                                next_turn.About_Pink.SetActive(true);
                            }

                            StartCoroutine(Show_Wall());
                            StartCoroutine(Show_Wall_Next());
                            IEnumerator Show_Wall()
                            {
                                yield return new WaitForSeconds(1.25f);

                                next_turn.Wall.SetActive(true);

                                next_turn.Open_Curtain_Left.SetActive(true);
                                next_turn.Open_Curtain_Right.SetActive(true);

                                next_turn.Stay_Curtain_Left.SetActive(false);
                                next_turn.Stay_Curtain_Right.SetActive(false);
                            }


                            IEnumerator Show_Wall_Next()
                            {
                                yield return new WaitForSeconds(1.2505f);
                                next_turn.score.Update_Score();
                            }
                        }//여기까지 새로 추가한 거

                        else if (Close_Blue.activeSelf == true)
                        {
                            //만약 블루가 선인데 블루가 닫혔을 때
                            //더 이상 아무것도 하지 않는다
                            //Debug.Log("아무것도 하지 않음");
                            if (card_move.Blue_Fourth_Line[0].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[0].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Blue_Fourth_Line[1].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[1].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Blue_Fourth_Line[2].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[2].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Blue_Fourth_Line[3].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[3].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Blue_Fourth_Line[4].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[4].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Blue_Fourth_Line[5].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[5].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Blue_Fourth_Line[6].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[6].transform.GetChild(0).gameObject);
                            }
                        }

                        else
                        {
                            if (card_move.Blue_Fourth_Line[0].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[0].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Blue_Fourth_Line[1].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[1].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Blue_Fourth_Line[2].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[2].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Blue_Fourth_Line[3].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[3].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Blue_Fourth_Line[4].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[4].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Blue_Fourth_Line[5].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[5].transform.GetChild(0).gameObject);
                            }

                            if (card_move.Blue_Fourth_Line[6].transform.childCount > 0)
                            {
                                Destroy(card_move.Blue_Fourth_Line[6].transform.GetChild(0).gameObject);
                            }
                        }

                        //Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                    }

                    /* else if ((card_move.Blue_Fourth_Line[0].transform.childCount == 0)
                     || (card_move.Blue_Fourth_Line[1].transform.childCount == 0)
                     || (card_move.Blue_Fourth_Line[2].transform.childCount == 0)
                     || (card_move.Blue_Fourth_Line[3].transform.childCount == 0)
                     || (card_move.Blue_Fourth_Line[4].transform.childCount == 0)
                     || (card_move.Blue_Fourth_Line[5].transform.childCount == 0)
                     || (card_move.Blue_Fourth_Line[6].transform.childCount == 0))
                 {
                         if (Close_Pink.activeSelf == true)
                         {
                             //만약 핑크가 선인데
                             //핑크가 닫혔을 때
                             Debug.Log("자식 없음");
                             Debug.Log("이 블루가 마지막 턴. 이 블루 턴 하고 이제 스코어 나타내기");

                             //여기부터 새로 추가
                             Debug.Log("이제 스코어 나타내기");

                             StartCoroutine(Show_Score());
                             IEnumerator Show_Score()
                             {
                                 yield return new WaitForSeconds(0.25f);
                                 next_turn.Score.SetActive(true);

                                 next_turn.Stay_Curtain_Left.SetActive(true);
                                 next_turn.Stay_Curtain_Right.SetActive(true);

                                 next_turn.Open_Curtain_Left.SetActive(false);
                                 next_turn.Open_Curtain_Right.SetActive(false);

                                 next_turn.Close_Curtain_Left.SetActive(false);
                                 next_turn.Close_Curtain_Right.SetActive(false);

                                 next_turn.Text_Game_Result.SetActive(true);
                                 next_turn.Text_Pink_Team_Win.SetActive(false);
                                 next_turn.Text_Blue_Team_Win.SetActive(false);

                                 next_turn.About_Blue.SetActive(true);
                                 next_turn.About_Pink.SetActive(true);
                             }

                             StartCoroutine(Show_Wall());
                             StartCoroutine(Show_Wall_Next());
                             IEnumerator Show_Wall()
                             {
                                 yield return new WaitForSeconds(1.25f);

                                 next_turn.Wall.SetActive(true);

                                 next_turn.Open_Curtain_Left.SetActive(true);
                                 next_turn.Open_Curtain_Right.SetActive(true);

                                 next_turn.Stay_Curtain_Left.SetActive(false);
                                 next_turn.Stay_Curtain_Right.SetActive(false);
                             }


                             IEnumerator Show_Wall_Next()
                             {
                                 yield return new WaitForSeconds(1.2505f);
                                 next_turn.score.Update_Score();
                             }
                         }//여기까지 새로 추가한 거

                         else if (Close_Blue.activeSelf == true)
                         {
                             //만약 블루가 선인데 블루가 닫혔을 때
                             //더 이상 아무것도 하지 않는다
                             //Debug.Log("아무것도 하지 않음");
                             //Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                             Debug.Log("자식 없음");
                         }

                         else
                         {
                             //Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                             Debug.Log("자식 없음");
                         }

                         //Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                     }*/

                    /*else
                    {
                        Debug.Log("자식 없음");
                    }*/


                    // }



                    //주문 처리 못한 거 삭제
                    /* for (int i = 0; i < card_move.Blue_Fourth_Line.Length; i++)
                     {
                         if (card_move.Blue_Fourth_Line[i].transform.childCount == 1)
                         {
                             if(Close_Pink.activeSelf == true)
                             {
                                 //만약 핑크가 선인데
                                 //핑크가 닫혔을 때
                                 Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                                 Debug.Log("이 블루가 마지막 턴. 이 블루 턴 하고 이제 스코어 나타내기");

                                 //여기부터 새로 추가
                                 Debug.Log("이제 스코어 나타내기");

                                 StartCoroutine(Show_Score());
                                 IEnumerator Show_Score()
                                 {
                                     yield return new WaitForSeconds(0.25f);
                                     next_turn.Score.SetActive(true);

                                     next_turn.Stay_Curtain_Left.SetActive(true);
                                     next_turn.Stay_Curtain_Right.SetActive(true);

                                     next_turn.Open_Curtain_Left.SetActive(false);
                                     next_turn.Open_Curtain_Right.SetActive(false);

                                     next_turn.Close_Curtain_Left.SetActive(false);
                                     next_turn.Close_Curtain_Right.SetActive(false);

                                     next_turn.Text_Game_Result.SetActive(true);
                                     next_turn.Text_Pink_Team_Win.SetActive(false);
                                     next_turn.Text_Blue_Team_Win.SetActive(false);

                                     next_turn.About_Blue.SetActive(true);
                                     next_turn.About_Pink.SetActive(true);
                                 }

                                 StartCoroutine(Show_Wall());
                                 StartCoroutine(Show_Wall_Next());
                                 IEnumerator Show_Wall()
                                 {
                                     yield return new WaitForSeconds(1.25f);

                                     next_turn.Wall.SetActive(true);

                                     next_turn.Open_Curtain_Left.SetActive(true);
                                     next_turn.Open_Curtain_Right.SetActive(true);

                                     next_turn.Stay_Curtain_Left.SetActive(false);
                                     next_turn.Stay_Curtain_Right.SetActive(false);
                                 }


                                 IEnumerator Show_Wall_Next()
                                 {
                                     yield return new WaitForSeconds(1.2505f);
                                     next_turn.score.Update_Score();
                                 }
                             }//여기까지 새로 추가한 거

                             else if (Close_Blue.activeSelf == true)
                             {
                                 //만약 블루가 선인데 블루가 닫혔을 때
                                 //더 이상 아무것도 하지 않는다
                                 //Debug.Log("아무것도 하지 않음");
                                 Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);

                             }

                             else
                             {
                                 Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                             }

                                 //Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                         }

                         else if (card_move.Blue_Fourth_Line[i].transform.childCount == 0)
                         {
                             if (Close_Pink.activeSelf == true)
                             {
                                 //만약 핑크가 선인데
                                 //핑크가 닫혔을 때
                                 Debug.Log("자식 없음");
                                 Debug.Log("이 블루가 마지막 턴. 이 블루 턴 하고 이제 스코어 나타내기");

                                 //여기부터 새로 추가
                                 Debug.Log("이제 스코어 나타내기");

                                 StartCoroutine(Show_Score());
                                 IEnumerator Show_Score()
                                 {
                                     yield return new WaitForSeconds(0.25f);
                                     next_turn.Score.SetActive(true);

                                     next_turn.Stay_Curtain_Left.SetActive(true);
                                     next_turn.Stay_Curtain_Right.SetActive(true);

                                     next_turn.Open_Curtain_Left.SetActive(false);
                                     next_turn.Open_Curtain_Right.SetActive(false);

                                     next_turn.Close_Curtain_Left.SetActive(false);
                                     next_turn.Close_Curtain_Right.SetActive(false);

                                     next_turn.Text_Game_Result.SetActive(true);
                                     next_turn.Text_Pink_Team_Win.SetActive(false);
                                     next_turn.Text_Blue_Team_Win.SetActive(false);

                                     next_turn.About_Blue.SetActive(true);
                                     next_turn.About_Pink.SetActive(true);
                                 }

                                 StartCoroutine(Show_Wall());
                                 StartCoroutine(Show_Wall_Next());
                                 IEnumerator Show_Wall()
                                 {
                                     yield return new WaitForSeconds(1.25f);

                                     next_turn.Wall.SetActive(true);

                                     next_turn.Open_Curtain_Left.SetActive(true);
                                     next_turn.Open_Curtain_Right.SetActive(true);

                                     next_turn.Stay_Curtain_Left.SetActive(false);
                                     next_turn.Stay_Curtain_Right.SetActive(false);
                                 }


                                 IEnumerator Show_Wall_Next()
                                 {
                                     yield return new WaitForSeconds(1.2505f);
                                     next_turn.score.Update_Score();
                                 }
                             }//여기까지 새로 추가한 거

                             else if (Close_Blue.activeSelf == true)
                             {
                                 //만약 블루가 선인데 블루가 닫혔을 때
                                 //더 이상 아무것도 하지 않는다
                                 //Debug.Log("아무것도 하지 않음");
                                 //Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                                 Debug.Log("자식 없음");
                             }

                             else
                             {
                                 //Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                                 Debug.Log("자식 없음");
                             }

                             //Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                         }

                         //else
                         //{
                           //  Debug.Log("자식 없음");
                         //}


                     }*/



                    //세 번째 줄에 있던 거 네 번쨰 줄로 이동
                    for (int i = 0; i < card_move.Blue_Third_Line.Length; i++)
                    {
                        if (card_move.Blue_Third_Line[i].transform.childCount == 1)
                        {
                            //새로 만들어봄
                            if (Close_Pink.activeSelf == true)
                            {
                                //만약 핑크가 선인데
                                //핑크가 닫혔을 때
                                Transform childToMove = card_move.Blue_Third_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Blue_Fourth_Line[i].transform, false);
                                Debug.Log("이 블루가 마지막 턴. 이 블루 턴 하고 이제 스코어 나타내기");
                            }

                            else if (Close_Blue.activeSelf == true)
                            {
                                //만약 블루가 선인데 블루가 닫혔을 때
                                //더 이상 아무것도 하지 않는다
                                //Debug.Log("아무것도 하지 않음");
                                Transform childToMove = card_move.Blue_Third_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Blue_Fourth_Line[i].transform, false);
                            }

                            else
                            {
                                Transform childToMove = card_move.Blue_Third_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Blue_Fourth_Line[i].transform, false);
                            }


                            // Pink_Third_Line[i]에 자식이 1개 있는 경우
                            // 해당 자식을 Pink_Fourth_Line[i]의 첫 번째 자식으로 옮김
                            /*Transform childToMove = card_move.Blue_Third_Line[i].transform.GetChild(0);

                            childToMove.SetParent(card_move.Blue_Fourth_Line[i].transform, false);*/



                        }

                        else if (card_move.Blue_Third_Line[i].transform.childCount == 0)
                        {
                            Debug.Log("자식 없음");
                        }
                    }

                }

                IEnumerator Next_Card1_Blue()
                {
                    yield return new WaitForSeconds(2.005f);
                    //두 번째 줄에 있던 거 세 번째 줄로 이동
                    for (int i = 0; i < card_move.Blue_Second_Line.Length; i++)
                    {
                        if (card_move.Blue_Second_Line[i].transform.childCount == 1)
                        {
                            //새로 만듦
                            if (Close_Pink.activeSelf == true)
                            {
                                //만약 핑크가 선인데
                                //핑크가 닫혔을 때
                                Transform childToMove = card_move.Blue_Second_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Blue_Third_Line[i].transform, false);
                                Debug.Log("이 블루가 마지막 턴. 이 블루 턴 하고 이제 스코어 나타내기");
                            }

                            else if (Close_Blue.activeSelf == true)
                            {
                                //만약 블루가 선인데 블루가 닫혔을 때
                                //더 이상 아무것도 하지 않는다
                                //Debug.Log("아무것도 하지 않음");
                                Transform childToMove = card_move.Blue_Second_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Blue_Third_Line[i].transform, false);
                            }

                            else
                            {
                                Transform childToMove = card_move.Blue_Second_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Blue_Third_Line[i].transform, false);
                            }


                            // Pink_Second_Line[i]에 자식이 1개 있는 경우
                            // 해당 자식을 Pink_Third_Line[i]의 첫 번째 자식으로 옮김
                            /*Transform childToMove = card_move.Blue_Second_Line[i].transform.GetChild(0);
                            childToMove.SetParent(card_move.Blue_Third_Line[i].transform, false);*/
                        }

                        else if (card_move.Blue_Second_Line[i].transform.childCount == 0)
                        {
                            Debug.Log("자식 없음");
                        }
                    }
                }

                IEnumerator Next_Card2_Blue()
                {
                    yield return new WaitForSeconds(2.01f);
                    //첫 번째 줄에 있던 거 두 번쨰 줄로 이동
                    for (int i = 0; i < card_move.Blue_First_Line.Length; i++)
                    {
                        if (card_move.Blue_First_Line[i].transform.childCount == 1)
                        {
                            //새로 만듦
                            if (Close_Pink.activeSelf == true)
                            {
                                //만약 핑크가 선인데
                                //핑크가 닫혔을 때
                                Transform childToMove2 = card_move.Blue_First_Line[i].transform.GetChild(0);
                                childToMove2.SetParent(card_move.Blue_Second_Line[i].transform, false);
                                Debug.Log("이 블루가 마지막 턴. 이 블루 턴 하고 이제 스코어 나타내기");
                            }

                            else if (Close_Blue.activeSelf == true)
                            {
                                //만약 블루가 선인데 블루가 닫혔을 때
                                //더 이상 아무것도 하지 않는다
                                //Debug.Log("아무것도 하지 않음");
                                Transform childToMove2 = card_move.Blue_First_Line[i].transform.GetChild(0);
                                childToMove2.SetParent(card_move.Blue_Second_Line[i].transform, false);
                            }

                            else
                            {
                                Transform childToMove2 = card_move.Blue_First_Line[i].transform.GetChild(0);
                                childToMove2.SetParent(card_move.Blue_Second_Line[i].transform, false);
                            }

                            // Pink_Third_Line[i]에 자식이 1개 있는 경우
                            // 해당 자식을 Pink_Fourth_Line[i]의 첫 번째 자식으로 옮김
                            /*Transform childToMove2 = card_move.Blue_First_Line[i].transform.GetChild(0);
                            childToMove2.SetParent(card_move.Blue_Second_Line[i].transform, false);*/

                        }

                        else if (card_move.Blue_First_Line[i].transform.childCount == 0)//자식이 없는 경우의 로직도 짜야함
                        {
                            Debug.Log("자식 없음");
                        }
                    }
                }
            }




        }
    }


    public void PlayAnimationOnFirstChildObjects_1_Blue()//네 번째 줄에 자식이 없는 경우
    {
        // parentTransform 오브젝트의 모든 첫 번째 자식들의 Animator 컴포넌트를 찾기

        StartCoroutine(Stop_Anim_Blue());

        StartCoroutine(Next_Card1_Blue());
        StartCoroutine(Next_Card2_Blue());


        IEnumerator Stop_Anim_Blue()
        {
            yield return new WaitForSeconds(0.0f);

            if ((card_move.Blue_Fourth_Line[0].transform.childCount == 0)
                        || (card_move.Blue_Fourth_Line[1].transform.childCount == 0)
                        || (card_move.Blue_Fourth_Line[2].transform.childCount == 0)
                        || (card_move.Blue_Fourth_Line[3].transform.childCount == 0)
                        || (card_move.Blue_Fourth_Line[4].transform.childCount == 0)
                        || (card_move.Blue_Fourth_Line[5].transform.childCount == 0)
                        || (card_move.Blue_Fourth_Line[6].transform.childCount == 0))
            {
                if (Close_Pink.activeSelf == true)
                {
                    //만약 핑크가 선인데
                    //핑크가 닫혔을 때
                    Debug.Log("자식 없음");
                    Debug.Log("이 블루가 마지막 턴. 이 블루 턴 하고 이제 스코어 나타내기");

                    //여기부터 새로 추가
                    Debug.Log("이제 스코어 나타내기");

                    StartCoroutine(Show_Score());
                    IEnumerator Show_Score()
                    {
                        yield return new WaitForSeconds(0.25f);
                        next_turn.Score.SetActive(true);

                        next_turn.Stay_Curtain_Left.SetActive(true);
                        next_turn.Stay_Curtain_Right.SetActive(true);

                        next_turn.Open_Curtain_Left.SetActive(false);
                        next_turn.Open_Curtain_Right.SetActive(false);

                        next_turn.Close_Curtain_Left.SetActive(false);
                        next_turn.Close_Curtain_Right.SetActive(false);

                        next_turn.Text_Game_Result.SetActive(true);
                        next_turn.Text_Pink_Team_Win.SetActive(false);
                        next_turn.Text_Blue_Team_Win.SetActive(false);

                        next_turn.About_Blue.SetActive(true);
                        next_turn.About_Pink.SetActive(true);
                    }

                    StartCoroutine(Show_Wall());
                    StartCoroutine(Show_Wall_Next());
                    IEnumerator Show_Wall()
                    {
                        yield return new WaitForSeconds(1.25f);

                        next_turn.Wall.SetActive(true);

                        next_turn.Open_Curtain_Left.SetActive(true);
                        next_turn.Open_Curtain_Right.SetActive(true);

                        next_turn.Stay_Curtain_Left.SetActive(false);
                        next_turn.Stay_Curtain_Right.SetActive(false);
                    }


                    IEnumerator Show_Wall_Next()
                    {
                        yield return new WaitForSeconds(1.2505f);
                        next_turn.score.Update_Score();
                    }
                }//여기까지 새로 추가한 거

                else if (Close_Blue.activeSelf == true)
                {
                    //만약 블루가 선인데 블루가 닫혔을 때
                    //더 이상 아무것도 하지 않는다
                    //Debug.Log("아무것도 하지 않음");
                    //Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                    Debug.Log("자식 없음");
                }

                else
                {
                    //Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                    Debug.Log("자식 없음");
                }

                //Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
            }

            //세 번째 줄에 있던 거 네 번쨰 줄로 이동
            for (int i = 0; i < card_move.Blue_Third_Line.Length; i++)
            {
                if (card_move.Blue_Third_Line[i].transform.childCount == 1)
                {
                    //새로 만듦
                    if (Close_Pink.activeSelf == true)
                    {
                        //만약 핑크가 선인데
                        //핑크가 닫혔을 때
                        Transform childToMove = card_move.Blue_Third_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Blue_Fourth_Line[i].transform, false);
                        Debug.Log("이 블루가 마지막 턴. 이 블루 턴 하고 이제 스코어 나타내기");
                    }

                    else if (Close_Blue.activeSelf == true)
                    {
                        Transform childToMove = card_move.Blue_Third_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Blue_Fourth_Line[i].transform, false);
                        //만약 블루가 선인데 블루가 닫혔을 때
                        //더 이상 아무것도 하지 않는다
                        //Debug.Log("아무것도 하지 않음");
                    }

                    else
                    {
                        Transform childToMove = card_move.Blue_Third_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Blue_Fourth_Line[i].transform, false);
                    }

                    // Pink_Third_Line[i]에 자식이 1개 있는 경우
                    // 해당 자식을 Pink_Fourth_Line[i]의 첫 번째 자식으로 옮김
                    /*Transform childToMove = card_move.Blue_Third_Line[i].transform.GetChild(0);

                    childToMove.SetParent(card_move.Blue_Fourth_Line[i].transform, false);*/



                }

                else if (card_move.Blue_Third_Line[i].transform.childCount == 0)
                {
                    Debug.Log("자식 없음");
                }
            }

        }

        IEnumerator Next_Card1_Blue()
        {
            yield return new WaitForSeconds(0.005f);
            //두 번째 줄에 있던 거 세 번째 줄로 이동
            for (int i = 0; i < card_move.Blue_Second_Line.Length; i++)
            {
                if (card_move.Blue_Second_Line[i].transform.childCount == 1)
                {
                    //새로 만듦
                    if (Close_Pink.activeSelf == true)
                    {
                        //만약 핑크가 선인데
                        //핑크가 닫혔을 때
                        Transform childToMove = card_move.Blue_Second_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Blue_Third_Line[i].transform, false);
                        Debug.Log("이 블루가 마지막 턴. 이 블루 턴 하고 이제 스코어 나타내기");
                    }

                    else if (Close_Blue.activeSelf == true)
                    {
                        //만약 블루가 선인데 블루가 닫혔을 때
                        //더 이상 아무것도 하지 않는다
                        //Debug.Log("아무것도 하지 않음");
                        Transform childToMove = card_move.Blue_Second_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Blue_Third_Line[i].transform, false);
                    }

                    else
                    {
                        Transform childToMove = card_move.Blue_Second_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Blue_Third_Line[i].transform, false);
                    }

                    // Pink_Second_Line[i]에 자식이 1개 있는 경우
                    // 해당 자식을 Pink_Third_Line[i]의 첫 번째 자식으로 옮김
                    /*Transform childToMove = card_move.Blue_Second_Line[i].transform.GetChild(0);
                    childToMove.SetParent(card_move.Blue_Third_Line[i].transform, false);*/
                }

                else if (card_move.Blue_Second_Line[i].transform.childCount == 0)
                {
                    Debug.Log("자식 없음");
                }
            }
        }

        IEnumerator Next_Card2_Blue()
        {
            yield return new WaitForSeconds(0.01f);
            //첫 번째 줄에 있던 거 두 번쨰 줄로 이동
            for (int i = 0; i < card_move.Blue_First_Line.Length; i++)
            {
                if (card_move.Blue_First_Line[i].transform.childCount == 1)
                {
                    //새로 만듦
                    if (Close_Pink.activeSelf == true)
                    {
                        //만약 핑크가 선인데
                        //핑크가 닫혔을 때
                        Transform childToMove2 = card_move.Blue_First_Line[i].transform.GetChild(0);
                        childToMove2.SetParent(card_move.Blue_Second_Line[i].transform, false);
                        Debug.Log("이 블루가 마지막 턴. 이 블루 턴 하고 이제 스코어 나타내기");
                    }

                    else if (Close_Blue.activeSelf == true)
                    {
                        //만약 블루가 선인데 블루가 닫혔을 때
                        //더 이상 아무것도 하지 않는다
                        //Debug.Log("아무것도 하지 않음");
                        Transform childToMove2 = card_move.Blue_First_Line[i].transform.GetChild(0);
                        childToMove2.SetParent(card_move.Blue_Second_Line[i].transform, false);
                    }

                    else
                    {
                        Transform childToMove2 = card_move.Blue_First_Line[i].transform.GetChild(0);
                        childToMove2.SetParent(card_move.Blue_Second_Line[i].transform, false);
                    }

                    // Pink_Third_Line[i]에 자식이 1개 있는 경우
                    // 해당 자식을 Pink_Fourth_Line[i]의 첫 번째 자식으로 옮김
                    /*Transform childToMove2 = card_move.Blue_First_Line[i].transform.GetChild(0);
                    childToMove2.SetParent(card_move.Blue_Second_Line[i].transform, false);*/

                }

                else if (card_move.Blue_First_Line[i].transform.childCount == 0)//자식이 없는 경우의 로직도 짜야함
                {
                    Debug.Log("자식 없음");
                }
            }
        }



    }


}
