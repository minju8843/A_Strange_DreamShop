using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Next_Turn : MonoBehaviour
{
    public CameraZoom zoom;

    //현재 문제

    //핑크 시작 시
    //핑크가 종료 조건이 되었을 경우
    //파랑이까지 하고 넘어가야 하나
    //파랑이에서 주문 처리 안 된 것이 없어지거나 처리되지 않는 문제 발생
    //개수도 하나 적게 나옴

    //핑크 시작 시
    //블루가 종료 조건이 되었을 경우
    //다음 턴 넘길 때 바로 점수 계산 판이 나와야 하지만
    //2번 정도 더 돌려야지만 점수 판이 나옴



    public GameObject Rotate_board;
    public RectTransform board;

    public GameObject Go_Player1_B;//블루 버튼
    public GameObject Go_Player2_B;//핑크 버튼

    public RectTransform Plate_Back;//판 원래 위치로

    public Card_Move card_move;

    public Turn_Count Click_Button;//버튼을 몇 번 눌렀는지 확인하기 위한 거
    
    //08.07새로 추가
    public Blue_Pink blue_pink;

    public GameObject Coin_Pink_1;

    public GameObject Coin_Blue_1;


    public GameObject Good_Bad_Pink_1;
    public GameObject Good_Bad_Pink_2;

    public GameObject Good_Bad_Blue_1;
    public GameObject Good_Bad_Blue_2;

    public GameObject Blue_Material_Canvas;
    public GameObject Pink_Material_Canvas;

    public Move_Player move_player;

    public Upgrade_Tile upgrade_tile;
    public Upgrade_Tile_Blue upgrade_tile_blue;

    public Move_Material move_material;

    public GameObject blue;
    public GameObject pink;

    public Turn_Count turn_count;

    public Next_Turn next_turn;

    public Good_Bad good_bad;

    public Menu menu;

    public GameObject Score;


    public GameObject Stay_Curtain_Left;
    public GameObject Stay_Curtain_Right;

    public GameObject Open_Curtain_Left;
    public GameObject Open_Curtain_Right;

    public GameObject Close_Curtain_Left;
    public GameObject Close_Curtain_Right;

    public GameObject Text_Game_Result;
    public GameObject Text_Pink_Team_Win;
    public GameObject Text_Blue_Team_Win;
    public GameObject Text_Darw;

    public GameObject About_Blue;
    public GameObject About_Pink;

    
    public GameObject Wall;

    //여기부터는 아직 안함
    //여기부터 핑크 점수 계산 관련된 거

    //업그레이드 타일 숫자
    //업그레이드 타일 + (다 계산한 거 앞에 있는 +)
    public GameObject Pink_Plus_Upgrate_Tile;//플러스만 있는 거

    //업그레이드 타일 다 계산한 거
    public GameObject Pink_Upgrate_Tile_Total;
    public Text Pink_Upgrate_Tile_Total_Text;

    //업그레이드 타일 +( 2 x )
    public GameObject Pink_Plus_brackets_Upgrate_Tile;//괄호 업그레이드 타일

    //업그레이드 타일 4
    public GameObject Pink_Upgrate_Tile_Four;
    public Text Pink_Upgrate_Tile_Four_Text;

    //주문 완료한 횟수 +
    public GameObject Pink_Plus_Good_Count;//플러스만 있는 거

    //주문 완료한 횟수 숫자
    public GameObject Pink_Good_Count;
    public Text Pink_Good_Count_Text;

    //주문 실패한 횟수 -
    public GameObject Pink_Minus_Bad_Count;//마이너스만 있는 거

    //주문 실해한 횟수 숫자
    public GameObject Pink_Bad_Count;
    public Text Pink_Bad_Count_Text;

    //러시 코인 () - 한 자릿수
    public GameObject Pink_Plus_Gold_Count_One_brackets;//플러스만 있는 거

    //러시 코인 숫자 - 한 자릿수
    public GameObject Pink_Plus_Gold_Count_One;
    public Text Pink_Plus_Gold_Count_One_Text;

    //러시 코인 () - 두 자릿수
    public GameObject Pink_Plus_Gold_Count_Two_brackets;

    //러시 코인 숫자 - 두 자리 수
    public GameObject Pink_Plus_Gold_Count_Two;//괄호 코인
    public Text Pink_Plus_Gold_Count_Two_Text;

    //갈색 네모
    public GameObject Pink_Brown_Line;

    //전체 점수 작게
    public GameObject Pink_Total_Small;
    public Text Pink_Total_Small_Text;

    //전체 점수 크게
    public GameObject Pink_Total_Big;
    public Text Pink_Total_Big_Text;


    // ** 여기부터는 노랑 판 **

    //업그레이드 타일
    public GameObject Pink_Upgrate_Tile_Yellow;

    //주문 처리 카드
    public GameObject Pink_Good_Count_Yellow;

    //주문 실패 카드
    public GameObject Pink_Bad_Count_Yellow;

    //러시 코인
    public GameObject Pink_Gold_Count_Yellow;

    //총 점수
    public GameObject Pink_Total_Yellow;

    // *** 여기부터 파란 거 ***
    public GameObject Blue_Plus_Upgrate_Tile;//플러스만 있는 거

    //업그레이드 타일 다 계산한 거
    public GameObject Blue_Upgrate_Tile_Total;
    public Text Blue_Upgrate_Tile_Total_Text;

    //업그레이드 타일 +( 2 x )
    public GameObject Blue_Plus_brackets_Upgrate_Tile;//괄호 업그레이드 타일

    //업그레이드 타일 4
    public GameObject Blue_Upgrate_Tile_Four;
    public Text Blue_Upgrate_Tile_Four_Text;

    //주문 완료한 횟수 +
    public GameObject Blue_Plus_Good_Count;//플러스만 있는 거

    //주문 완료한 횟수 숫자
    public GameObject Blue_Good_Count;
    public Text Blue_Good_Count_Text;

    //주문 실패한 횟수 -
    public GameObject Blue_Minus_Bad_Count;//마이너스만 있는 거

    //주문 실해한 횟수 숫자
    public GameObject Blue_Bad_Count;
    public Text Blue_Bad_Count_Text;

    //러시 코인 () - 한 자릿수
    public GameObject Blue_Plus_Gold_Count_One_brackets;//플러스만 있는 거

    //러시 코인 숫자 - 한 자릿수
    public GameObject Blue_Plus_Gold_Count_One;//플러스만 있는 거
    public Text Blue_Plus_Gold_Count_One_Text;

    //러시 코인 () - 두 자릿수
    public GameObject Blue_Plus_Gold_Count_Two_brackets;

    //러시 코인 숫자 - 두 자리 수
    public GameObject Blue_Plus_Gold_Count_Two;//괄호 코인
    public Text Blue_Plus_Gold_Count_Two_Text;

    //갈색 네모
    public GameObject Blue_Brown_Line;

    //전체 점수 작게
    public GameObject Blue_Total_Small;
    public Text Blue_Total_Small_Text;

    //전체 점수 크게
    public GameObject Blue_Total_Big;
    public Text Blue_Total_Big_Text;

    //업그레이드
    public GameObject Blue_Upgrate_Tile_Yellow;

    //주문 처리 카드
    public GameObject Blue_Good_Count_Yellow;

    //주문 실패 카드
    public GameObject Blue_Bad_Count_Yellow;

    //러시 코인
    public GameObject Blue_Gold_Count_Yellow;

    //총 점수
    public GameObject Blue_Total_Yellow;

    //파랑 말이 이겼을 때
    public GameObject Blue_Win;

    //분홍 말이 이겼을 때
    public GameObject Pink_Win;

    //무승부일때
    public GameObject Draw;


    public GameObject Pink_Score_Coin_brackets_Two;//최종 점수 옆에 있는 골드 - 두 자릿수
    public GameObject Pink_Score_Coin_Two;
    public Text Pink_Score_Coin_Two_Text;

    public GameObject Pink_Score_Coin_brackets_One;//최종 점수 옆에 있는 골드 - 한 자릿수
    public GameObject Pink_Score_Coin_One;
    public Text Pink_Score_Coin_One_Text;

    public GameObject Blue_Score_Coin_brackets_Two;//최종 점수 옆에 있는 골드 - 두 자릿 수
    public GameObject Blue_Score_Coin_Two;
    public Text Blue_Score_Coin_Two_Text;

    public GameObject Blue_Score_Coin_brackets_One;//최종 점수 옆에 있는 골드 - 한 자릿 수
    public GameObject Blue_Score_Coin_One;
    public Text Blue_Score_Coin_One_Text;


    public Score score;

    //파이널 오픈
    public GameObject Final_Curtain_Open_0;
    public GameObject Final_Curtain_Open_1;


    void Start()
    {

        Go_Player1_B.SetActive(false); ;//블루
        Go_Player2_B.SetActive(false);
        //<핑크가 먼저 시작한다고 했을 때>
        //만약 현재 회전하는 판의 위치가 0f, 15.6f이라면
        //버튼을 눌렀을 때 0, 0으로 돌아가야 하고 (파란색이 오른쪽)

        //그 다음 버튼을 눌렀을 때(분홍색이 오른쪽)
        //0, 15.6의 위치가 되어야 함.

        //그 다음 버튼을 눌렀을 땐(파랑이 오른쪽)
        //다시 0으로

        


    }


    public void Go_Player1()//핑크확정
    {

        Debug.Log("눌려졌다 오버");

        //PC에서는 실행되는 코드입니다
        //확대, 축소 코드
        /*zoom.isZoomedIn = false;//줌인 상태가 아님
        zoom.zoomCount = 0; //짝수번째
        zoom.ZoomOut();//줌 아웃
        */
        //12.9에서 z축이 180도 돌아간 상황이었음 빨간 버튼 누르니 12.9에 아무 회전도 없는 거 나오는데
        //0, 0, 0위치에 아무 회전도 없는거여야 함

        zoom.ResetToOriginalSize();

        Vector2 currentPosition = board.anchoredPosition;//현재 오브젝트 위치를 가져와서 currentPosition에 적용

        // 만약 현재 위치가 (0, 0)라면
        if (currentPosition.x == 0 && currentPosition.y == 0)
        {
           

            if(Click_Button.Click_Count<4)
            {
                Click_Button.Click_Count++;//1번 추가
                Click_Button.UpdateClickCountText();
                StartCoroutine(Go_Player_1_1());

                IEnumerator Go_Player_1_1()
                {
                    yield return new WaitForSeconds(0.0f);//0.5였음

                    Rotate_board.transform.Rotate(0f, 0f, 180f);
                    // 현재 위치를 (0, 15.6)으로 변경
                    board.anchoredPosition = new Vector2(0f, 12.9f);//15.6였는디

  
                    Go_Player1_B.SetActive(true);//블루
                    Go_Player2_B.SetActive(false);
                    //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                    //0813
                    blue.SetActive(true);
                    pink.SetActive(false);

                    //Player1_Cup.SetActive(true);
                    //Player2_Cup.SetActive(false);
                    //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)

                    //08.11.금
                    if (move_material.Pink_24[0].transform.childCount == 2 ||
                        move_material.Pink_24[1].transform.childCount == 2 ||
                        move_material.Pink_24[2].transform.childCount == 2 ||
                        move_material.Pink_24[3].transform.childCount == 2 ||
                        move_material.Pink_24[4].transform.childCount == 2 ||
                        move_material.Pink_24[5].transform.childCount == 2 ||
                        move_material.Pink_24[6].transform.childCount == 2 ||
                        move_material.Pink_24[7].transform.childCount == 2 ||
                        move_material.Pink_24[8].transform.childCount == 2 ||
                        move_material.Pink_24[9].transform.childCount == 2 ||
                        move_material.Pink_24[10].transform.childCount == 2 ||
                        move_material.Pink_24[11].transform.childCount == 2 ||
                        move_material.Pink_24[12].transform.childCount == 2 ||
                        move_material.Pink_24[13].transform.childCount == 2 ||
                        move_material.Pink_24[14].transform.childCount == 2 ||
                        move_material.Pink_24[15].transform.childCount == 2)
                    {
                        if (move_material.Pink_24[0].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[0].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[1].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[1].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[2].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[2].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[3].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[3].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[4].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[4].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[5].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[5].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[6].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[6].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[7].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[7].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[8].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[8].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[9].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[9].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[10].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[10].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[11].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[11].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[12].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[12].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[13].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[13].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[14].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[14].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[15].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[15].transform.GetChild(1).gameObject);
                        }
                    }

                }
            }

            else if(Click_Button.Click_Count > 3 &&
                (card_move.Pink_Fourth_Line[0].transform.childCount == 1
                || card_move.Pink_Fourth_Line[1].transform.childCount == 1
                || card_move.Pink_Fourth_Line[2].transform.childCount == 1
                || card_move.Pink_Fourth_Line[3].transform.childCount == 1
                || card_move.Pink_Fourth_Line[4].transform.childCount == 1
                || card_move.Pink_Fourth_Line[5].transform.childCount == 1
                || card_move.Pink_Fourth_Line[6].transform.childCount == 1))//클릭 카운트가 4 이상일 때 //4번째 줄 자식이 있는게 하나 이상일 때
            {
                if((move_player.Player_Positions[30].childCount != 0 && move_player.Player_Positions[31].childCount != 0)
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//같은 칸에 말이 2개 있을 때
                {
                    //핑크
                    upgrade_tile.No_Double_Player();
                }

                else
                {
                    Click_Button.Click_Count++;//1번 추가
                    Click_Button.UpdateClickCountText();

                    StartCoroutine(Go_Player_1_1());
                    Score.SetActive(false);

                    Stay_Curtain_Left.SetActive(false);
                    Stay_Curtain_Right.SetActive(false);

                    Open_Curtain_Left.SetActive(false);
                    Open_Curtain_Right.SetActive(false);

                    Close_Curtain_Left.SetActive(false);
                    Close_Curtain_Right.SetActive(false);

                    Text_Game_Result.SetActive(false);
                    Text_Pink_Team_Win.SetActive(false);
                    Text_Blue_Team_Win.SetActive(false);

                    About_Blue.SetActive(false);
                    About_Pink.SetActive(false);


                    IEnumerator Go_Player_1_1()
                    {
                        yield return new WaitForSeconds(2.8f);//0.5였음

                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        // 현재 위치를 (0, 15.6)으로 변경
                        board.anchoredPosition = new Vector2(0f, 12.9f);//15.6였는디

                        

                        Go_Player1_B.SetActive(true);//블루
                        Go_Player2_B.SetActive(false);
                        //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                        //08.07.새로 추가
                        Blue_Material_Canvas.SetActive(true);
                        Pink_Material_Canvas.SetActive(false);

                        //0813
                        blue.SetActive(true);
                        pink.SetActive(false);

                        Good_Bad_Blue_1.SetActive(true);
                        Good_Bad_Blue_2.SetActive(true);
                        //Good_Bad_Pink.SetActive(false);

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

                        //08.11.금
                        if (move_material.Pink_24[0].transform.childCount == 2 ||
                            move_material.Pink_24[1].transform.childCount == 2 ||
                            move_material.Pink_24[2].transform.childCount == 2 ||
                            move_material.Pink_24[3].transform.childCount == 2 ||
                            move_material.Pink_24[4].transform.childCount == 2 ||
                            move_material.Pink_24[5].transform.childCount == 2 ||
                            move_material.Pink_24[6].transform.childCount == 2 ||
                            move_material.Pink_24[7].transform.childCount == 2 ||
                            move_material.Pink_24[8].transform.childCount == 2 ||
                            move_material.Pink_24[9].transform.childCount == 2 ||
                            move_material.Pink_24[10].transform.childCount == 2 ||
                            move_material.Pink_24[11].transform.childCount == 2 ||
                            move_material.Pink_24[12].transform.childCount == 2 ||
                            move_material.Pink_24[13].transform.childCount == 2 ||
                            move_material.Pink_24[14].transform.childCount == 2 ||
                            move_material.Pink_24[15].transform.childCount == 2)
                        {
                            if (move_material.Pink_24[0].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[0].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[1].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[1].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[2].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[2].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[3].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[3].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[4].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[4].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[5].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[5].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[6].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[6].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[7].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[7].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[8].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[8].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[9].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[9].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[10].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[10].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[11].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[11].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[12].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[12].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[13].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[13].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[14].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[14].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[15].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[15].transform.GetChild(1).gameObject);
                            }
                        }

                        //Player1_Cup.SetActive(true);
                        //Player2_Cup.SetActive(false);
                        //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                    }
                }
                
            }

            

            else if (Click_Button.Click_Count > 3 &&
                card_move.Pink_Fourth_Line[0].transform.childCount == 0
                && card_move.Pink_Fourth_Line[1].transform.childCount == 0
                && card_move.Pink_Fourth_Line[2].transform.childCount == 0
                && card_move.Pink_Fourth_Line[3].transform.childCount == 0
                && card_move.Pink_Fourth_Line[4].transform.childCount == 0
                && card_move.Pink_Fourth_Line[5].transform.childCount == 0
                && card_move.Pink_Fourth_Line[6].transform.childCount == 0)//클릭 카운트가 4 이상일 때 //4번째 줄 자식이 있는게 하나도 없는 경우
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//같은 칸에 말이 2개 있을 때
                {
                    //핑크
                    upgrade_tile.No_Double_Player();
                }

                else
                {


                    Click_Button.Click_Count++;//1번 추가
                    Click_Button.UpdateClickCountText();

                    StartCoroutine(Go_Player_1_1());
                    Score.SetActive(false);

                    Stay_Curtain_Left.SetActive(false);
                    Stay_Curtain_Right.SetActive(false);

                    Open_Curtain_Left.SetActive(false);
                    Open_Curtain_Right.SetActive(false);

                    Close_Curtain_Left.SetActive(false);
                    Close_Curtain_Right.SetActive(false);

                    Text_Game_Result.SetActive(false);
                    Text_Pink_Team_Win.SetActive(false);
                    Text_Blue_Team_Win.SetActive(false);

                    About_Blue.SetActive(false);
                    About_Pink.SetActive(false);



                    IEnumerator Go_Player_1_1()
                    {
                        yield return new WaitForSeconds(0.5f);//0.5였음

                        Debug.Log("2번 실행되었다 오버");

                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        // 현재 위치를 (0, 15.6)으로 변경
                         board.anchoredPosition = new Vector2(0f, 12.9f);//12.9였는디

                        

                        Go_Player1_B.SetActive(true); //블루
                        Go_Player2_B.SetActive(false);
                        //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                        //08.07.새로 추가
                        Blue_Material_Canvas.SetActive(true);
                        Pink_Material_Canvas.SetActive(false);

                        Good_Bad_Blue_1.SetActive(true);
                        Good_Bad_Blue_2.SetActive(true);
                        //Good_Bad_Pink.SetActive(false);

                        Good_Bad_Pink_1.SetActive(false);
                        Good_Bad_Pink_2.SetActive(false);

                        //0813
                        blue.SetActive(true);
                        pink.SetActive(false);

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

                        //08.11.금
                        if (move_material.Pink_24[0].transform.childCount == 2 ||
                            move_material.Pink_24[1].transform.childCount == 2 ||
                            move_material.Pink_24[2].transform.childCount == 2 ||
                            move_material.Pink_24[3].transform.childCount == 2 ||
                            move_material.Pink_24[4].transform.childCount == 2 ||
                            move_material.Pink_24[5].transform.childCount == 2 ||
                            move_material.Pink_24[6].transform.childCount == 2 ||
                            move_material.Pink_24[7].transform.childCount == 2 ||
                            move_material.Pink_24[8].transform.childCount == 2 ||
                            move_material.Pink_24[9].transform.childCount == 2 ||
                            move_material.Pink_24[10].transform.childCount == 2 ||
                            move_material.Pink_24[11].transform.childCount == 2 ||
                            move_material.Pink_24[12].transform.childCount == 2 ||
                            move_material.Pink_24[13].transform.childCount == 2 ||
                            move_material.Pink_24[14].transform.childCount == 2 ||
                            move_material.Pink_24[15].transform.childCount == 2)
                        {
                            if (move_material.Pink_24[0].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[0].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[1].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[1].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[2].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[2].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[3].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[3].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[4].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[4].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[5].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[5].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[6].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[6].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[7].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[7].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[8].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[8].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[9].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[9].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[10].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[10].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[11].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[11].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[12].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[12].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[13].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[13].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[14].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[14].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[15].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[15].transform.GetChild(1).gameObject);
                            }
                        }

                        //Player1_Cup.SetActive(true);
                        //Player2_Cup.SetActive(false);
                        //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                    }
                }
                
            }

        }

        //수정하고 있는거
        else if(currentPosition.x == 0 && currentPosition.y == 12.9)
        {
            

            if (Click_Button.Click_Count < 3)//4였음
            {
                Click_Button.Click_Count++;//1번 추가
                Click_Button.UpdateClickCountText();

                StartCoroutine(Go_Player_1_2());

                IEnumerator Go_Player_1_2()
                {
                    yield return new WaitForSeconds(0.0f);//0.5였음




                    Rotate_board.transform.Rotate(0f, 0f, 180f);
                    // 현재 위치를 (0, 15.6)으로 변경
                    board.anchoredPosition = new Vector2(0f, 0f);//0.0였는디

                    Go_Player1_B.SetActive(true); ;//블루
                    Go_Player2_B.SetActive(false);

                    //0813
                    blue.SetActive(true);
                    pink.SetActive(false);

                   

                    //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                    //08.11.금
                    if (move_material.Pink_24[0].transform.childCount == 2 ||
                        move_material.Pink_24[1].transform.childCount == 2 ||
                        move_material.Pink_24[2].transform.childCount == 2 ||
                        move_material.Pink_24[3].transform.childCount == 2 ||
                        move_material.Pink_24[4].transform.childCount == 2 ||
                        move_material.Pink_24[5].transform.childCount == 2 ||
                        move_material.Pink_24[6].transform.childCount == 2 ||
                        move_material.Pink_24[7].transform.childCount == 2 ||
                        move_material.Pink_24[8].transform.childCount == 2 ||
                        move_material.Pink_24[9].transform.childCount == 2 ||
                        move_material.Pink_24[10].transform.childCount == 2 ||
                        move_material.Pink_24[11].transform.childCount == 2 ||
                        move_material.Pink_24[12].transform.childCount == 2 ||
                        move_material.Pink_24[13].transform.childCount == 2 ||
                        move_material.Pink_24[14].transform.childCount == 2 ||
                        move_material.Pink_24[15].transform.childCount == 2)
                    {
                        if (move_material.Pink_24[0].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[0].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[1].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[1].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[2].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[2].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[3].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[3].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[4].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[4].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[5].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[5].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[6].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[6].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[7].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[7].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[8].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[8].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[9].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[9].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[10].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[10].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[11].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[11].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[12].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[12].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[13].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[13].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[14].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[14].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[15].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[15].transform.GetChild(1).gameObject);
                        }
                    }

                    //Player1_Cup.SetActive(true);
                    //Player2_Cup.SetActive(false);
                    //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                }
            }

            //새로추가 0814
            //3일때
            else if (Click_Button.Click_Count == 3)
            {
                Click_Button.Click_Count++;//1번 추가
                Click_Button.UpdateClickCountText();

                //Debug.Log("핑크 얼만디" + Click_Button.Click_Count);
                //실행되지 않음

                StartCoroutine(Go_Player_1_2());

                IEnumerator Go_Player_1_2()
                {
                    yield return new WaitForSeconds(0.0f);//0.5였음


                    //Rotate_board.transform.Rotate(0f, 0f, 180f);
                    // 현재 위치를 (0, 15.6)으로 변경
                    board.anchoredPosition = new Vector2(0f, 12.9f);//0.0였는디

                    Go_Player1_B.SetActive(false); //블루
                    Go_Player2_B.SetActive(true);

                    //0813
                    blue.SetActive(false);
                    pink.SetActive(true);



                    //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                    //08.11.금
                    if (move_material.Pink_24[0].transform.childCount == 2 ||
                        move_material.Pink_24[1].transform.childCount == 2 ||
                        move_material.Pink_24[2].transform.childCount == 2 ||
                        move_material.Pink_24[3].transform.childCount == 2 ||
                        move_material.Pink_24[4].transform.childCount == 2 ||
                        move_material.Pink_24[5].transform.childCount == 2 ||
                        move_material.Pink_24[6].transform.childCount == 2 ||
                        move_material.Pink_24[7].transform.childCount == 2 ||
                        move_material.Pink_24[8].transform.childCount == 2 ||
                        move_material.Pink_24[9].transform.childCount == 2 ||
                        move_material.Pink_24[10].transform.childCount == 2 ||
                        move_material.Pink_24[11].transform.childCount == 2 ||
                        move_material.Pink_24[12].transform.childCount == 2 ||
                        move_material.Pink_24[13].transform.childCount == 2 ||
                        move_material.Pink_24[14].transform.childCount == 2 ||
                        move_material.Pink_24[15].transform.childCount == 2)
                    {
                        if (move_material.Pink_24[0].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[0].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[1].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[1].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[2].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[2].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[3].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[3].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[4].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[4].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[5].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[5].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[6].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[6].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[7].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[7].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[8].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[8].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[9].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[9].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[10].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[10].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[11].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[11].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[12].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[12].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[13].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[13].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[14].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[14].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[15].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[15].transform.GetChild(1).gameObject);
                        }
                    }

                    //Player1_Cup.SetActive(true);
                    //Player2_Cup.SetActive(false);
                    //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                }
            }

            //여기 아래부터는 원래 있던 거

            else if (Click_Button.Click_Count > 3 &&
                (card_move.Pink_Fourth_Line[0].transform.childCount == 1
                || card_move.Pink_Fourth_Line[1].transform.childCount == 1
                || card_move.Pink_Fourth_Line[2].transform.childCount == 1
                || card_move.Pink_Fourth_Line[3].transform.childCount == 1
                || card_move.Pink_Fourth_Line[4].transform.childCount == 1
                || card_move.Pink_Fourth_Line[5].transform.childCount == 1
                || card_move.Pink_Fourth_Line[6].transform.childCount == 1))
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//같은 칸에 말이 2개 있을 때
                {
                    //핑크
                    upgrade_tile.No_Double_Player();
                }

                else
                {


                    Click_Button.Click_Count++;//1번 추가
                    Click_Button.UpdateClickCountText();

                    StartCoroutine(Go_Player_1_2());
                    Score.SetActive(false);

                    Stay_Curtain_Left.SetActive(false);
                    Stay_Curtain_Right.SetActive(false);

                    Open_Curtain_Left.SetActive(false);
                    Open_Curtain_Right.SetActive(false);

                    Close_Curtain_Left.SetActive(false);
                    Close_Curtain_Right.SetActive(false);

                    Text_Game_Result.SetActive(false);
                    Text_Pink_Team_Win.SetActive(false);
                    Text_Blue_Team_Win.SetActive(false);

                    About_Blue.SetActive(false);
                    About_Pink.SetActive(false);

                    IEnumerator Go_Player_1_2()
                    {
                        yield return new WaitForSeconds(2.8f);//0.5였음

                        Debug.Log("3번 실행되었다 오버");

                  


                        //Rotate_board.transform.Rotate(0f, 0f, 180f);
                        // 현재 위치를 (0, 15.6)으로 변경
                        board.anchoredPosition = new Vector2(0f, 12.9f);//0.0였는디

                        Go_Player1_B.SetActive(false); ;//블루
                        Go_Player2_B.SetActive(true);
                        //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                        //08.07.새로 추가
                        Blue_Material_Canvas.SetActive(false);
                        Pink_Material_Canvas.SetActive(true);

                        Good_Bad_Blue_1.SetActive(false);
                        Good_Bad_Blue_2.SetActive(false);
                        //Good_Bad_Pink.SetActive(true);

                        Good_Bad_Pink_1.SetActive(true);
                        Good_Bad_Pink_2.SetActive(true);

                        //0813
                        blue.SetActive(false);
                        pink.SetActive(true);

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

                        //08.11.금
                        if (move_material.Pink_24[0].transform.childCount == 2 ||
                            move_material.Pink_24[1].transform.childCount == 2 ||
                            move_material.Pink_24[2].transform.childCount == 2 ||
                            move_material.Pink_24[3].transform.childCount == 2 ||
                            move_material.Pink_24[4].transform.childCount == 2 ||
                            move_material.Pink_24[5].transform.childCount == 2 ||
                            move_material.Pink_24[6].transform.childCount == 2 ||
                            move_material.Pink_24[7].transform.childCount == 2 ||
                            move_material.Pink_24[8].transform.childCount == 2 ||
                            move_material.Pink_24[9].transform.childCount == 2 ||
                            move_material.Pink_24[10].transform.childCount == 2 ||
                            move_material.Pink_24[11].transform.childCount == 2 ||
                            move_material.Pink_24[12].transform.childCount == 2 ||
                            move_material.Pink_24[13].transform.childCount == 2 ||
                            move_material.Pink_24[14].transform.childCount == 2 ||
                            move_material.Pink_24[15].transform.childCount == 2)
                        {
                            if (move_material.Pink_24[0].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[0].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[1].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[1].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[2].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[2].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[3].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[3].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[4].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[4].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[5].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[5].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[6].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[6].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[7].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[7].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[8].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[8].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[9].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[9].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[10].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[10].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[11].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[11].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[12].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[12].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[13].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[13].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[14].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[14].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[15].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[15].transform.GetChild(1).gameObject);
                            }
                        }

                        //Player1_Cup.SetActive(true);
                        //Player2_Cup.SetActive(false);
                        //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                    }
                }

                
            }

            else if (Click_Button.Click_Count > 3 &&
                card_move.Pink_Fourth_Line[0].transform.childCount == 0
                && card_move.Pink_Fourth_Line[1].transform.childCount == 0
                && card_move.Pink_Fourth_Line[2].transform.childCount == 0
                && card_move.Pink_Fourth_Line[3].transform.childCount == 0
                && card_move.Pink_Fourth_Line[4].transform.childCount == 0
                && card_move.Pink_Fourth_Line[5].transform.childCount == 0
                && card_move.Pink_Fourth_Line[6].transform.childCount == 0)
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//같은 칸에 말이 2개 있을 때
                {
                    //핑크
                    upgrade_tile.No_Double_Player();
                }

                else
                {

                    Click_Button.Click_Count++;//1번 추가
                    Click_Button.UpdateClickCountText();

                    StartCoroutine(Go_Player_1_2());
                    Score.SetActive(false);

                    Stay_Curtain_Left.SetActive(false);
                    Stay_Curtain_Right.SetActive(false);

                    Open_Curtain_Left.SetActive(false);
                    Open_Curtain_Right.SetActive(false);

                    Close_Curtain_Left.SetActive(false);
                    Close_Curtain_Right.SetActive(false);

                    Text_Game_Result.SetActive(false);
                    Text_Pink_Team_Win.SetActive(false);
                    Text_Blue_Team_Win.SetActive(false);

                    About_Blue.SetActive(false);
                    About_Pink.SetActive(false);

                    IEnumerator Go_Player_1_2()
                    {
                        yield return new WaitForSeconds(0.5f);//0.5였음

                        Debug.Log("4번 실행되었다 오버");

                       // Rotate_board.transform.Rotate(0f, 0f, 180f);
                        // 현재 위치를 (0, 15.6)으로 변경
                        board.anchoredPosition = new Vector2(0f, 12.9f);//0.0였는디
                        //0.0이었음


                        Go_Player1_B.SetActive(false); ;//블루
                        Go_Player2_B.SetActive(true);

                        //0813
                        blue.SetActive(false);
                        pink.SetActive(true);
                        //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                        //08.07.새로 추가
                        Blue_Material_Canvas.SetActive(false);
                        Pink_Material_Canvas.SetActive(true);

                        Good_Bad_Blue_1.SetActive(false);
                        Good_Bad_Blue_2.SetActive(false);
                        //Good_Bad_Pink.SetActive(true);

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

                        //08.11.금
                        if (move_material.Pink_24[0].transform.childCount == 2 ||
                            move_material.Pink_24[1].transform.childCount == 2 ||
                            move_material.Pink_24[2].transform.childCount == 2 ||
                            move_material.Pink_24[3].transform.childCount == 2 ||
                            move_material.Pink_24[4].transform.childCount == 2 ||
                            move_material.Pink_24[5].transform.childCount == 2 ||
                            move_material.Pink_24[6].transform.childCount == 2 ||
                            move_material.Pink_24[7].transform.childCount == 2 ||
                            move_material.Pink_24[8].transform.childCount == 2 ||
                            move_material.Pink_24[9].transform.childCount == 2 ||
                            move_material.Pink_24[10].transform.childCount == 2 ||
                            move_material.Pink_24[11].transform.childCount == 2 ||
                            move_material.Pink_24[12].transform.childCount == 2 ||
                            move_material.Pink_24[13].transform.childCount == 2 ||
                            move_material.Pink_24[14].transform.childCount == 2 ||
                            move_material.Pink_24[15].transform.childCount == 2)
                        {
                            if (move_material.Pink_24[0].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[0].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[1].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[1].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[2].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[2].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[3].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[3].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[4].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[4].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[5].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[5].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[6].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[6].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[7].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[7].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[8].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[8].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[9].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[9].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[10].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[10].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[11].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[11].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[12].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[12].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[13].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[13].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[14].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[14].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[15].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[15].transform.GetChild(1).gameObject);
                            }
                        }

                        //Player1_Cup.SetActive(true);
                        //Player2_Cup.SetActive(false);
                        //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                    }
                }
                
            }

        }


        else//이거 있을 때 없을때 시험해보고 이상하면 지우기 
        {
            if (Click_Button.Click_Count < 3)//4였음
            {
                Click_Button.Click_Count++;//1번 추가
                Click_Button.UpdateClickCountText();

                StartCoroutine(Go_Player_1());

                IEnumerator Go_Player_1()
                {
                    yield return new WaitForSeconds(0.0f);//0.5였음

                    Rotate_board.transform.Rotate(0f, 0f, 180f);
                    board.anchoredPosition = new Vector2(0f, 0.0f);//0.0였는디
                    //1초 후 z축 0도로 돌리기

                    Go_Player1_B.SetActive(true); ;//블루
                    Go_Player2_B.SetActive(false);

                    //0813
                    blue.SetActive(true);
                    pink.SetActive(false);
                    //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                    //08.11.금
                    if (move_material.Pink_24[0].transform.childCount == 2 ||
                        move_material.Pink_24[1].transform.childCount == 2 ||
                        move_material.Pink_24[2].transform.childCount == 2 ||
                        move_material.Pink_24[3].transform.childCount == 2 ||
                        move_material.Pink_24[4].transform.childCount == 2 ||
                        move_material.Pink_24[5].transform.childCount == 2 ||
                        move_material.Pink_24[6].transform.childCount == 2 ||
                        move_material.Pink_24[7].transform.childCount == 2 ||
                        move_material.Pink_24[8].transform.childCount == 2 ||
                        move_material.Pink_24[9].transform.childCount == 2 ||
                        move_material.Pink_24[10].transform.childCount == 2 ||
                        move_material.Pink_24[11].transform.childCount == 2 ||
                        move_material.Pink_24[12].transform.childCount == 2 ||
                        move_material.Pink_24[13].transform.childCount == 2 ||
                        move_material.Pink_24[14].transform.childCount == 2 ||
                        move_material.Pink_24[15].transform.childCount == 2)
                    {
                        if (move_material.Pink_24[0].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[0].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[1].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[1].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[2].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[2].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[3].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[3].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[4].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[4].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[5].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[5].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[6].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[6].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[7].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[7].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[8].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[8].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[9].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[9].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[10].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[10].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[11].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[11].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[12].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[12].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[13].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[13].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[14].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[14].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[15].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[15].transform.GetChild(1).gameObject);
                        }
                    }

                    //Player1_Cup.SetActive(true);
                    //Player2_Cup.SetActive(false);
                    //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                }
            }

            //여긴 새로 만든 거 0814
            else if (Click_Button.Click_Count ==3)//3
            {
                Debug.Log("핑크 클릭 카운트 4나와랏 얍");

                Click_Button.Click_Count++;//1번 추가
                Click_Button.UpdateClickCountText();

                StartCoroutine(Go_Player_1());

                IEnumerator Go_Player_1()
                {
                    yield return new WaitForSeconds(0.0f);//0.5였음

                    //Rotate_board.transform.Rotate(0f, 0f, 180f);
                    board.anchoredPosition = new Vector2(0f, 12.9f);//0.0였는디
                    //1초 후 z축 0도로 돌리기

                    Go_Player1_B.SetActive(false); //블루
                    Go_Player2_B.SetActive(true);

                    //0813
                    blue.SetActive(false);
                    pink.SetActive(true);
                    //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                    //08.11.금
                    if (move_material.Pink_24[0].transform.childCount == 2 ||
                        move_material.Pink_24[1].transform.childCount == 2 ||
                        move_material.Pink_24[2].transform.childCount == 2 ||
                        move_material.Pink_24[3].transform.childCount == 2 ||
                        move_material.Pink_24[4].transform.childCount == 2 ||
                        move_material.Pink_24[5].transform.childCount == 2 ||
                        move_material.Pink_24[6].transform.childCount == 2 ||
                        move_material.Pink_24[7].transform.childCount == 2 ||
                        move_material.Pink_24[8].transform.childCount == 2 ||
                        move_material.Pink_24[9].transform.childCount == 2 ||
                        move_material.Pink_24[10].transform.childCount == 2 ||
                        move_material.Pink_24[11].transform.childCount == 2 ||
                        move_material.Pink_24[12].transform.childCount == 2 ||
                        move_material.Pink_24[13].transform.childCount == 2 ||
                        move_material.Pink_24[14].transform.childCount == 2 ||
                        move_material.Pink_24[15].transform.childCount == 2)
                    {
                        if (move_material.Pink_24[0].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[0].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[1].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[1].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[2].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[2].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[3].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[3].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[4].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[4].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[5].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[5].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[6].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[6].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[7].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[7].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[8].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[8].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[9].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[9].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[10].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[10].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[11].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[11].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[12].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[12].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[13].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[13].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[14].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[14].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Pink_24[15].transform.childCount == 2)
                        {
                            Destroy(move_material.Pink_24[15].transform.GetChild(1).gameObject);
                        }
                    }

                    //Player1_Cup.SetActive(true);
                    //Player2_Cup.SetActive(false);
                    //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                }
            }

            //여긴 원래 있던 거
            else if (Click_Button.Click_Count > 3 &&
                (card_move.Pink_Fourth_Line[0].transform.childCount == 1
                || card_move.Pink_Fourth_Line[1].transform.childCount == 1
                || card_move.Pink_Fourth_Line[2].transform.childCount == 1
                || card_move.Pink_Fourth_Line[3].transform.childCount == 1
                || card_move.Pink_Fourth_Line[4].transform.childCount == 1
                || card_move.Pink_Fourth_Line[5].transform.childCount == 1
                || card_move.Pink_Fourth_Line[6].transform.childCount == 1))
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//같은 칸에 말이 2개 있을 때
                {
                    //핑크
                    upgrade_tile.No_Double_Player();
                }

                else
                {

                    Click_Button.Click_Count++;//1번 추가
                    Click_Button.UpdateClickCountText();

                    StartCoroutine(Go_Player_1());
                    Score.SetActive(false);

                    Stay_Curtain_Left.SetActive(false);
                    Stay_Curtain_Right.SetActive(false);

                    Open_Curtain_Left.SetActive(false);
                    Open_Curtain_Right.SetActive(false);

                    Close_Curtain_Left.SetActive(false);
                    Close_Curtain_Right.SetActive(false);

                    Text_Game_Result.SetActive(false);
                    Text_Pink_Team_Win.SetActive(false);
                    Text_Blue_Team_Win.SetActive(false);

                    About_Blue.SetActive(false);
                    About_Pink.SetActive(false);

                    IEnumerator Go_Player_1()
                    {
                        yield return new WaitForSeconds(2.8f);//0.5였음

                        Debug.Log("5번 실행되었다 오버");

                      

                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        board.anchoredPosition = new Vector2(0f, 0.0f);//0.0였는디
                                                                     //1초 후 z축 0도로 돌리기

                        Go_Player1_B.SetActive(true); ;//블루
                        Go_Player2_B.SetActive(false);

                        //0813
                        blue.SetActive(true);
                        pink.SetActive(false);
                        //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                        //08.07.새로 추가
                        Blue_Material_Canvas.SetActive(true);
                        Pink_Material_Canvas.SetActive(false);

                        Good_Bad_Blue_1.SetActive(true);
                        Good_Bad_Blue_2.SetActive(true);
                        //Good_Bad_Pink.SetActive(false);

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

                        //08.11.금
                        if (move_material.Pink_24[0].transform.childCount == 2 ||
                            move_material.Pink_24[1].transform.childCount == 2 ||
                            move_material.Pink_24[2].transform.childCount == 2 ||
                            move_material.Pink_24[3].transform.childCount == 2 ||
                            move_material.Pink_24[4].transform.childCount == 2 ||
                            move_material.Pink_24[5].transform.childCount == 2 ||
                            move_material.Pink_24[6].transform.childCount == 2 ||
                            move_material.Pink_24[7].transform.childCount == 2 ||
                            move_material.Pink_24[8].transform.childCount == 2 ||
                            move_material.Pink_24[9].transform.childCount == 2 ||
                            move_material.Pink_24[10].transform.childCount == 2 ||
                            move_material.Pink_24[11].transform.childCount == 2 ||
                            move_material.Pink_24[12].transform.childCount == 2 ||
                            move_material.Pink_24[13].transform.childCount == 2 ||
                            move_material.Pink_24[14].transform.childCount == 2 ||
                            move_material.Pink_24[15].transform.childCount == 2)
                        {
                            if (move_material.Pink_24[0].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[0].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[1].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[1].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[2].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[2].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[3].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[3].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[4].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[4].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[5].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[5].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[6].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[6].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[7].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[7].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[8].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[8].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[9].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[9].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[10].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[10].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[11].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[11].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[12].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[12].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[13].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[13].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[14].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[14].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[15].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[15].transform.GetChild(1).gameObject);
                            }
                        }

                        //Player1_Cup.SetActive(true);
                        //Player2_Cup.SetActive(false);
                        //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                    }
                }
                
            }

            else if (Click_Button.Click_Count > 3 &&
                card_move.Pink_Fourth_Line[0].transform.childCount == 0
                && card_move.Pink_Fourth_Line[1].transform.childCount == 0
                && card_move.Pink_Fourth_Line[2].transform.childCount == 0
                && card_move.Pink_Fourth_Line[3].transform.childCount == 0
                && card_move.Pink_Fourth_Line[4].transform.childCount == 0
                && card_move.Pink_Fourth_Line[5].transform.childCount == 0
                && card_move.Pink_Fourth_Line[6].transform.childCount == 0)
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//같은 칸에 말이 2개 있을 때
                {
                    //핑크
                    upgrade_tile.No_Double_Player();
                }

                else
                {


                    Click_Button.Click_Count++;//1번 추가
                    Click_Button.UpdateClickCountText();

                    StartCoroutine(Go_Player_1());
                    Score.SetActive(false);

                    Stay_Curtain_Left.SetActive(false);
                    Stay_Curtain_Right.SetActive(false);

                    Open_Curtain_Left.SetActive(false);
                    Open_Curtain_Right.SetActive(false);

                    Close_Curtain_Left.SetActive(false);
                    Close_Curtain_Right.SetActive(false);

                    Text_Game_Result.SetActive(false);
                    Text_Pink_Team_Win.SetActive(false);
                    Text_Blue_Team_Win.SetActive(false);

                    About_Blue.SetActive(false);
                    About_Pink.SetActive(false);

                    IEnumerator Go_Player_1()
                    {
                        yield return new WaitForSeconds(0.5f);//0.5였음

                        Debug.Log("6번 실행되었다 오버");

                       


                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        board.anchoredPosition = new Vector2(0f, 0.0f);//0.0였는디
                                                                     //1초 후 z축 0도로 돌리기

                        Go_Player1_B.SetActive(true); ;//블루
                        Go_Player2_B.SetActive(false);

                        //0813
                        blue.SetActive(true);
                        pink.SetActive(false);
                        //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                        //08.07.새로 추가
                        Blue_Material_Canvas.SetActive(true);
                        Pink_Material_Canvas.SetActive(false);

                        Good_Bad_Blue_1.SetActive(true);
                        Good_Bad_Blue_2.SetActive(true);
                        //Good_Bad_Pink.SetActive(false);

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

                        //08.11.금
                        if (move_material.Pink_24[0].transform.childCount == 2 ||
                            move_material.Pink_24[1].transform.childCount == 2 ||
                            move_material.Pink_24[2].transform.childCount == 2 ||
                            move_material.Pink_24[3].transform.childCount == 2 ||
                            move_material.Pink_24[4].transform.childCount == 2 ||
                            move_material.Pink_24[5].transform.childCount == 2 ||
                            move_material.Pink_24[6].transform.childCount == 2 ||
                            move_material.Pink_24[7].transform.childCount == 2 ||
                            move_material.Pink_24[8].transform.childCount == 2 ||
                            move_material.Pink_24[9].transform.childCount == 2 ||
                            move_material.Pink_24[10].transform.childCount == 2 ||
                            move_material.Pink_24[11].transform.childCount == 2 ||
                            move_material.Pink_24[12].transform.childCount == 2 ||
                            move_material.Pink_24[13].transform.childCount == 2 ||
                            move_material.Pink_24[14].transform.childCount == 2 ||
                            move_material.Pink_24[15].transform.childCount == 2)
                        {
                            if (move_material.Pink_24[0].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[0].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[1].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[1].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[2].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[2].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[3].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[3].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[4].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[4].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[5].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[5].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[6].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[6].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[7].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[7].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[8].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[8].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[9].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[9].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[10].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[10].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[11].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[11].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[12].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[12].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[13].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[13].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[14].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[14].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Pink_24[15].transform.childCount == 2)
                            {
                                Destroy(move_material.Pink_24[15].transform.GetChild(1).gameObject);
                            }
                        }

                        //Player1_Cup.SetActive(true);
                        //Player2_Cup.SetActive(false);
                        //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                    }
                }
                
            }
 
        }



        Plate_Back.anchoredPosition = new Vector2(1.0f, 3.8147e-05f);
    }

    //
    public void Go_Player2()//블루에서 핑크로
    {

        Debug.Log("눌려졌다 오버");

        //PC에서는 실행되는 코드입니다
        //확대, 축소 코드
        /*zoom.isZoomedIn = false;//줌인 상태가 아님
        zoom.zoomCount = 0; //짝수번째
        zoom.ZoomOut();//줌 아웃
        */
        zoom.ResetToOriginalSize();

        //12.9에서 z축이 180도 돌아간 상황이었음 빨간 버튼 누르니 12.9에 아무 회전도 없는 거 나오는데
        //0, 0, 0위치에 아무 회전도 없는거여야 함

        Vector2 currentPosition = board.anchoredPosition;//현재 오브젝트 위치를 가져와서 currentPosition에 적용

        // 만약 현재 위치가 (0, 0)라면
        if (currentPosition.x == 0 && currentPosition.y == 0)
        {


            if (Click_Button.Click_Count < 3)
            {
                Click_Button.Click_Count++;//1번 추가
                Click_Button.UpdateClickCountText();
                StartCoroutine(Go_Player_1_1());

                IEnumerator Go_Player_1_1()
                {
                    yield return new WaitForSeconds(0.0f);//0.5였음

                    Rotate_board.transform.Rotate(0f, 0f, 180f);
                    // 현재 위치를 (0, 15.6)으로 변경
                    board.anchoredPosition = new Vector2(0f, 12.9f);//15.6였는디


                    Go_Player1_B.SetActive(false);//블루
                    Go_Player2_B.SetActive(true);
                    //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                    //0813
                    blue.SetActive(false);
                    pink.SetActive(true);

                    //Player1_Cup.SetActive(true);
                    //Player2_Cup.SetActive(false);
                    //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)

                    //08.11.금
                    if (move_material.Blue_24[0].transform.childCount == 2 ||
                        move_material.Blue_24[1].transform.childCount == 2 ||
                        move_material.Blue_24[2].transform.childCount == 2 ||
                        move_material.Blue_24[3].transform.childCount == 2 ||
                        move_material.Blue_24[4].transform.childCount == 2 ||
                        move_material.Blue_24[5].transform.childCount == 2 ||
                        move_material.Blue_24[6].transform.childCount == 2 ||
                        move_material.Blue_24[7].transform.childCount == 2 ||
                        move_material.Blue_24[8].transform.childCount == 2 ||
                        move_material.Blue_24[9].transform.childCount == 2 ||
                        move_material.Blue_24[10].transform.childCount == 2 ||
                        move_material.Blue_24[11].transform.childCount == 2 ||
                        move_material.Blue_24[12].transform.childCount == 2 ||
                        move_material.Blue_24[13].transform.childCount == 2 ||
                        move_material.Blue_24[14].transform.childCount == 2 ||
                        move_material.Blue_24[15].transform.childCount == 2)
                    {
                        if (move_material.Blue_24[0].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[1].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[2].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[3].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[4].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[5].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[6].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[7].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[8].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[9].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[10].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[11].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[12].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[13].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[14].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[15].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                        }
                    }

                }
            }
            
            //새로 만듦 0822
            else if (Click_Button.Click_Count == 3)
            {
                Click_Button.Click_Count++;//1번 추가
                Click_Button.UpdateClickCountText();
                StartCoroutine(Go_Player_1_1());

                Debug.Log("이거 실행되어야 하는딩");

                IEnumerator Go_Player_1_1()
                {
                    yield return new WaitForSeconds(0.0f);//0.5였음

                    //Rotate_board.transform.Rotate(0f, 0f, 180f);
                    // 현재 위치를 (0, 15.6)으로 변경
                    board.anchoredPosition = new Vector2(0f, 0.0f);//15.6였는디


                    Go_Player1_B.SetActive(true);//블루
                    Go_Player2_B.SetActive(false);
                    //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                    //0813
                    blue.SetActive(true);
                    pink.SetActive(false);

                    //Player1_Cup.SetActive(true);
                    //Player2_Cup.SetActive(false);
                    //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)

                    //08.11.금
                    if (move_material.Blue_24[0].transform.childCount == 2 ||
                        move_material.Blue_24[1].transform.childCount == 2 ||
                        move_material.Blue_24[2].transform.childCount == 2 ||
                        move_material.Blue_24[3].transform.childCount == 2 ||
                        move_material.Blue_24[4].transform.childCount == 2 ||
                        move_material.Blue_24[5].transform.childCount == 2 ||
                        move_material.Blue_24[6].transform.childCount == 2 ||
                        move_material.Blue_24[7].transform.childCount == 2 ||
                        move_material.Blue_24[8].transform.childCount == 2 ||
                        move_material.Blue_24[9].transform.childCount == 2 ||
                        move_material.Blue_24[10].transform.childCount == 2 ||
                        move_material.Blue_24[11].transform.childCount == 2 ||
                        move_material.Blue_24[12].transform.childCount == 2 ||
                        move_material.Blue_24[13].transform.childCount == 2 ||
                        move_material.Blue_24[14].transform.childCount == 2 ||
                        move_material.Blue_24[15].transform.childCount == 2)
                    {
                        if (move_material.Blue_24[0].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[1].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[2].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[3].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[4].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[5].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[6].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[7].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[8].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[9].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[10].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[11].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[12].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[13].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[14].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[15].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                        }
                    }

                }
            }

            else if (Click_Button.Click_Count > 3 &&
                (card_move.Blue_Fourth_Line[0].transform.childCount == 1
                || card_move.Blue_Fourth_Line[1].transform.childCount == 1
                || card_move.Blue_Fourth_Line[2].transform.childCount == 1
                || card_move.Blue_Fourth_Line[3].transform.childCount == 1
                || card_move.Blue_Fourth_Line[4].transform.childCount == 1
                || card_move.Blue_Fourth_Line[5].transform.childCount == 1
                || card_move.Blue_Fourth_Line[6].transform.childCount == 1))//클릭 카운트가 4 이상일 때 //4번째 줄 자식이 있는게 하나 이상일 때
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//같은 칸에 말이 2개 있을 때
                {
                    //핑크
                    upgrade_tile.No_Double_Player();
                }

                else
                {
                    Click_Button.Click_Count++;//1번 추가
                    Click_Button.UpdateClickCountText();

                    StartCoroutine(Go_Player_1_1());
                    Score.SetActive(false);

                    Stay_Curtain_Left.SetActive(false);
                    Stay_Curtain_Right.SetActive(false);

                    Open_Curtain_Left.SetActive(false);
                    Open_Curtain_Right.SetActive(false);

                    Close_Curtain_Left.SetActive(false);
                    Close_Curtain_Right.SetActive(false);

                    Text_Game_Result.SetActive(false);
                    Text_Pink_Team_Win.SetActive(false);
                    Text_Blue_Team_Win.SetActive(false);

                    About_Blue.SetActive(false);
                    About_Pink.SetActive(false);


                    IEnumerator Go_Player_1_1()
                    {
                        yield return new WaitForSeconds(2.8f);//0.5였음

                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        // 현재 위치를 (0, 15.6)으로 변경
                        board.anchoredPosition = new Vector2(0f, 12.9f);//15.6였는디



                        Go_Player1_B.SetActive(false);//블루
                        Go_Player2_B.SetActive(true);
                        //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                        //08.07.새로 추가
                        Blue_Material_Canvas.SetActive(false);
                        Pink_Material_Canvas.SetActive(true);

                        //0813
                        blue.SetActive(false);
                        pink.SetActive(true);

                        Good_Bad_Blue_1.SetActive(false);
                        Good_Bad_Blue_2.SetActive(false);
                        //Good_Bad_Pink.SetActive(false);

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

                        //08.11.금
                        if (move_material.Blue_24[0].transform.childCount == 2 ||
                            move_material.Blue_24[1].transform.childCount == 2 ||
                            move_material.Blue_24[2].transform.childCount == 2 ||
                            move_material.Blue_24[3].transform.childCount == 2 ||
                            move_material.Blue_24[4].transform.childCount == 2 ||
                            move_material.Blue_24[5].transform.childCount == 2 ||
                            move_material.Blue_24[6].transform.childCount == 2 ||
                            move_material.Blue_24[7].transform.childCount == 2 ||
                            move_material.Blue_24[8].transform.childCount == 2 ||
                            move_material.Blue_24[9].transform.childCount == 2 ||
                            move_material.Blue_24[10].transform.childCount == 2 ||
                            move_material.Blue_24[11].transform.childCount == 2 ||
                            move_material.Blue_24[12].transform.childCount == 2 ||
                            move_material.Blue_24[13].transform.childCount == 2 ||
                            move_material.Blue_24[14].transform.childCount == 2 ||
                            move_material.Blue_24[15].transform.childCount == 2)
                        {
                            if (move_material.Blue_24[0].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[1].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[2].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[3].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[4].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[5].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[6].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[7].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[8].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[9].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[10].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[11].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[12].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[13].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[14].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[15].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                            }
                        }

                        //Player1_Cup.SetActive(true);
                        //Player2_Cup.SetActive(false);
                        //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                    }
                }

            }



            else if (Click_Button.Click_Count > 3 &&
                card_move.Blue_Fourth_Line[0].transform.childCount == 0
                && card_move.Blue_Fourth_Line[1].transform.childCount == 0
                && card_move.Blue_Fourth_Line[2].transform.childCount == 0
                && card_move.Blue_Fourth_Line[3].transform.childCount == 0
                && card_move.Blue_Fourth_Line[4].transform.childCount == 0
                && card_move.Blue_Fourth_Line[5].transform.childCount == 0
                && card_move.Blue_Fourth_Line[6].transform.childCount == 0)//클릭 카운트가 4 이상일 때 //4번째 줄 자식이 있는게 하나도 없는 경우
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//같은 칸에 말이 2개 있을 때
                {
                    //핑크
                    upgrade_tile.No_Double_Player();
                }

                else
                {


                    Click_Button.Click_Count++;//1번 추가
                    Click_Button.UpdateClickCountText();

                    StartCoroutine(Go_Player_1_1());
                    Score.SetActive(false);

                    Stay_Curtain_Left.SetActive(false);
                    Stay_Curtain_Right.SetActive(false);

                    Open_Curtain_Left.SetActive(false);
                    Open_Curtain_Right.SetActive(false);

                    Close_Curtain_Left.SetActive(false);
                    Close_Curtain_Right.SetActive(false);

                    Text_Game_Result.SetActive(false);
                    Text_Pink_Team_Win.SetActive(false);
                    Text_Blue_Team_Win.SetActive(false);

                    About_Blue.SetActive(false);
                    About_Pink.SetActive(false);



                    IEnumerator Go_Player_1_1()
                    {
                        yield return new WaitForSeconds(0.5f);//0.5였음

                        Debug.Log("2번 실행되었다 오버");

                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        // 현재 위치를 (0, 15.6)으로 변경
                        board.anchoredPosition = new Vector2(0f, 12.9f);//12.9였는디



                        Go_Player1_B.SetActive(false); //블루
                        Go_Player2_B.SetActive(true);
                        //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                        //08.07.새로 추가
                        Blue_Material_Canvas.SetActive(false);
                        Pink_Material_Canvas.SetActive(true);

                        Good_Bad_Blue_1.SetActive(false);
                        Good_Bad_Blue_2.SetActive(false);
                        //Good_Bad_Pink.SetActive(false);

                        Good_Bad_Pink_1.SetActive(true);
                        Good_Bad_Pink_2.SetActive(true);

                        //0813
                        blue.SetActive(false);
                        pink.SetActive(true);

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

                        //08.11.금
                        if (move_material.Blue_24[0].transform.childCount == 2 ||
                            move_material.Blue_24[1].transform.childCount == 2 ||
                            move_material.Blue_24[2].transform.childCount == 2 ||
                            move_material.Blue_24[3].transform.childCount == 2 ||
                            move_material.Blue_24[4].transform.childCount == 2 ||
                            move_material.Blue_24[5].transform.childCount == 2 ||
                            move_material.Blue_24[6].transform.childCount == 2 ||
                            move_material.Blue_24[7].transform.childCount == 2 ||
                            move_material.Blue_24[8].transform.childCount == 2 ||
                            move_material.Blue_24[9].transform.childCount == 2 ||
                            move_material.Blue_24[10].transform.childCount == 2 ||
                            move_material.Blue_24[11].transform.childCount == 2 ||
                            move_material.Blue_24[12].transform.childCount == 2 ||
                            move_material.Blue_24[13].transform.childCount == 2 ||
                            move_material.Blue_24[14].transform.childCount == 2 ||
                            move_material.Blue_24[15].transform.childCount == 2)
                        {
                            if (move_material.Blue_24[0].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[1].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[2].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[3].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[4].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[5].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[6].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[7].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[8].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[9].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[10].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[11].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[12].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[13].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[14].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[15].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                            }
                        }

                        //Player1_Cup.SetActive(true);
                        //Player2_Cup.SetActive(false);
                        //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                    }
                }

            }

        }

        //수정하고 있는거
        else if (currentPosition.x == 0 && currentPosition.y == 12.9)
        {


            if (Click_Button.Click_Count < 4)//4였음
            {
                Click_Button.Click_Count++;//1번 추가
                Click_Button.UpdateClickCountText();

                StartCoroutine(Go_Player_1_2());

                IEnumerator Go_Player_1_2()
                {
                    yield return new WaitForSeconds(0.0f);//0.5였음




                    Rotate_board.transform.Rotate(0f, 0f, 180f);
                    // 현재 위치를 (0, 15.6)으로 변경
                    board.anchoredPosition = new Vector2(0f, 0f);//0.0였는디

                    Go_Player1_B.SetActive(false); ;//블루
                    Go_Player2_B.SetActive(true);

                    //0813
                    blue.SetActive(false);
                    pink.SetActive(true);



                    //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                    //08.11.금
                    if (move_material.Blue_24[0].transform.childCount == 2 ||
                        move_material.Blue_24[1].transform.childCount == 2 ||
                        move_material.Blue_24[2].transform.childCount == 2 ||
                        move_material.Blue_24[3].transform.childCount == 2 ||
                        move_material.Blue_24[4].transform.childCount == 2 ||
                        move_material.Blue_24[5].transform.childCount == 2 ||
                        move_material.Blue_24[6].transform.childCount == 2 ||
                        move_material.Blue_24[7].transform.childCount == 2 ||
                        move_material.Blue_24[8].transform.childCount == 2 ||
                        move_material.Blue_24[9].transform.childCount == 2 ||
                        move_material.Blue_24[10].transform.childCount == 2 ||
                        move_material.Blue_24[11].transform.childCount == 2 ||
                        move_material.Blue_24[12].transform.childCount == 2 ||
                        move_material.Blue_24[13].transform.childCount == 2 ||
                        move_material.Blue_24[14].transform.childCount == 2 ||
                        move_material.Blue_24[15].transform.childCount == 2)
                    {
                        if (move_material.Blue_24[0].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[1].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[2].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[3].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[4].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[5].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[6].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[7].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[8].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[9].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[10].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[11].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[12].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[13].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[14].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[15].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                        }
                    }

                    //Player1_Cup.SetActive(true);
                    //Player2_Cup.SetActive(false);
                    //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                }
            }

            //새로추가 0814
            //3일때
            else if (Click_Button.Click_Count == 3)
            {
                Click_Button.Click_Count++;//1번 추가
                Click_Button.UpdateClickCountText();

                //Debug.Log("핑크 얼만디" + Click_Button.Click_Count);
                //실행되지 않음

                StartCoroutine(Go_Player_1_2());

                IEnumerator Go_Player_1_2()
                {
                    yield return new WaitForSeconds(0.0f);//0.5였음


                    //Rotate_board.transform.Rotate(0f, 0f, 180f);
                    // 현재 위치를 (0, 15.6)으로 변경
                    board.anchoredPosition = new Vector2(0f, 0.0f);//0.0였는디

                    Go_Player1_B.SetActive(true); //블루
                    Go_Player2_B.SetActive(false);

                    //0813
                    blue.SetActive(true);
                    pink.SetActive(false);



                    //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                    //08.11.금
                    if (move_material.Blue_24[0].transform.childCount == 2 ||
                        move_material.Blue_24[1].transform.childCount == 2 ||
                        move_material.Blue_24[2].transform.childCount == 2 ||
                        move_material.Blue_24[3].transform.childCount == 2 ||
                        move_material.Blue_24[4].transform.childCount == 2 ||
                        move_material.Blue_24[5].transform.childCount == 2 ||
                        move_material.Blue_24[6].transform.childCount == 2 ||
                        move_material.Blue_24[7].transform.childCount == 2 ||
                        move_material.Blue_24[8].transform.childCount == 2 ||
                        move_material.Blue_24[9].transform.childCount == 2 ||
                        move_material.Blue_24[10].transform.childCount == 2 ||
                        move_material.Blue_24[11].transform.childCount == 2 ||
                        move_material.Blue_24[12].transform.childCount == 2 ||
                        move_material.Blue_24[13].transform.childCount == 2 ||
                        move_material.Blue_24[14].transform.childCount == 2 ||
                        move_material.Blue_24[15].transform.childCount == 2)
                    {
                        if (move_material.Blue_24[0].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[1].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[2].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[3].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[4].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[5].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[6].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[7].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[8].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[9].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[10].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[11].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[12].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[13].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[14].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[15].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                        }
                    }

                    //Player1_Cup.SetActive(true);
                    //Player2_Cup.SetActive(false);
                    //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                }
            }

            //여기 아래부터는 원래 있던 거

            else if (Click_Button.Click_Count > 3 &&
                (card_move.Blue_Fourth_Line[0].transform.childCount == 1
                || card_move.Blue_Fourth_Line[1].transform.childCount == 1
                || card_move.Blue_Fourth_Line[2].transform.childCount == 1
                || card_move.Blue_Fourth_Line[3].transform.childCount == 1
                || card_move.Blue_Fourth_Line[4].transform.childCount == 1
                || card_move.Blue_Fourth_Line[5].transform.childCount == 1
                || card_move.Blue_Fourth_Line[6].transform.childCount == 1))
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//같은 칸에 말이 2개 있을 때
                {
                    //핑크
                    upgrade_tile.No_Double_Player();
                }

                else
                {


                    Click_Button.Click_Count++;//1번 추가
                    Click_Button.UpdateClickCountText();

                    StartCoroutine(Go_Player_1_2());
                    Score.SetActive(false);

                    Stay_Curtain_Left.SetActive(false);
                    Stay_Curtain_Right.SetActive(false);

                    Open_Curtain_Left.SetActive(false);
                    Open_Curtain_Right.SetActive(false);

                    Close_Curtain_Left.SetActive(false);
                    Close_Curtain_Right.SetActive(false);

                    Text_Game_Result.SetActive(false);
                    Text_Pink_Team_Win.SetActive(false);
                    Text_Blue_Team_Win.SetActive(false);

                    About_Blue.SetActive(false);
                    About_Pink.SetActive(false);

                    IEnumerator Go_Player_1_2()
                    {
                        yield return new WaitForSeconds(2.8f);//0.5였음

                        Debug.Log("3번 실행되었다 오버");




                        //Rotate_board.transform.Rotate(0f, 0f, 180f);
                        // 현재 위치를 (0, 15.6)으로 변경
                        board.anchoredPosition = new Vector2(0f, 12.9f);//0.0였는디

                        Go_Player1_B.SetActive(false); ;//블루
                        Go_Player2_B.SetActive(true);
                        //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                        //08.07.새로 추가
                        Blue_Material_Canvas.SetActive(false);
                        Pink_Material_Canvas.SetActive(true);

                        Good_Bad_Blue_1.SetActive(false);
                        Good_Bad_Blue_2.SetActive(false);
                        //Good_Bad_Pink.SetActive(true);

                        Good_Bad_Pink_1.SetActive(true);
                        Good_Bad_Pink_2.SetActive(true);

                        //0813
                        blue.SetActive(false);
                        pink.SetActive(true);

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

                        //08.11.금
                        if (move_material.Blue_24[0].transform.childCount == 2 ||
                            move_material.Blue_24[1].transform.childCount == 2 ||
                            move_material.Blue_24[2].transform.childCount == 2 ||
                            move_material.Blue_24[3].transform.childCount == 2 ||
                            move_material.Blue_24[4].transform.childCount == 2 ||
                            move_material.Blue_24[5].transform.childCount == 2 ||
                            move_material.Blue_24[6].transform.childCount == 2 ||
                            move_material.Blue_24[7].transform.childCount == 2 ||
                            move_material.Blue_24[8].transform.childCount == 2 ||
                            move_material.Blue_24[9].transform.childCount == 2 ||
                            move_material.Blue_24[10].transform.childCount == 2 ||
                            move_material.Blue_24[11].transform.childCount == 2 ||
                            move_material.Blue_24[12].transform.childCount == 2 ||
                            move_material.Blue_24[13].transform.childCount == 2 ||
                            move_material.Blue_24[14].transform.childCount == 2 ||
                            move_material.Blue_24[15].transform.childCount == 2)
                        {
                            if (move_material.Blue_24[0].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[1].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[2].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[3].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[4].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[5].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[6].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[7].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[8].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[9].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[10].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[11].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[12].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[13].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[14].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[15].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                            }
                        }

                        //Player1_Cup.SetActive(true);
                        //Player2_Cup.SetActive(false);
                        //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                    }
                }


            }

            else if (Click_Button.Click_Count > 3 &&
                card_move.Blue_Fourth_Line[0].transform.childCount == 0
                && card_move.Blue_Fourth_Line[1].transform.childCount == 0
                && card_move.Blue_Fourth_Line[2].transform.childCount == 0
                && card_move.Blue_Fourth_Line[3].transform.childCount == 0
                && card_move.Blue_Fourth_Line[4].transform.childCount == 0
                && card_move.Blue_Fourth_Line[5].transform.childCount == 0
                && card_move.Blue_Fourth_Line[6].transform.childCount == 0)
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//같은 칸에 말이 2개 있을 때
                {
                    //핑크
                    upgrade_tile.No_Double_Player();
                }

                else
                {

                    Click_Button.Click_Count++;//1번 추가
                    Click_Button.UpdateClickCountText();

                    StartCoroutine(Go_Player_1_2());
                    Score.SetActive(false);

                    Stay_Curtain_Left.SetActive(false);
                    Stay_Curtain_Right.SetActive(false);

                    Open_Curtain_Left.SetActive(false);
                    Open_Curtain_Right.SetActive(false);

                    Close_Curtain_Left.SetActive(false);
                    Close_Curtain_Right.SetActive(false);

                    Text_Game_Result.SetActive(false);
                    Text_Pink_Team_Win.SetActive(false);
                    Text_Blue_Team_Win.SetActive(false);

                    About_Blue.SetActive(false);
                    About_Pink.SetActive(false);

                    IEnumerator Go_Player_1_2()
                    {
                        yield return new WaitForSeconds(0.5f);//0.5였음

                        Debug.Log("4번 실행되었다 오버");

                        // Rotate_board.transform.Rotate(0f, 0f, 180f);
                        // 현재 위치를 (0, 15.6)으로 변경
                        board.anchoredPosition = new Vector2(0f, 12.9f);//0.0였는디
                        //0.0이었음


                        Go_Player1_B.SetActive(false); ;//블루
                        Go_Player2_B.SetActive(true);

                        //0813
                        blue.SetActive(false);
                        pink.SetActive(true);
                        //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                        //08.07.새로 추가
                        Blue_Material_Canvas.SetActive(false);
                        Pink_Material_Canvas.SetActive(true);

                        Good_Bad_Blue_1.SetActive(false);
                        Good_Bad_Blue_2.SetActive(false);
                        //Good_Bad_Pink.SetActive(true);

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

                        //08.11.금
                        if (move_material.Blue_24[0].transform.childCount == 2 ||
                            move_material.Blue_24[1].transform.childCount == 2 ||
                            move_material.Blue_24[2].transform.childCount == 2 ||
                            move_material.Blue_24[3].transform.childCount == 2 ||
                            move_material.Blue_24[4].transform.childCount == 2 ||
                            move_material.Blue_24[5].transform.childCount == 2 ||
                            move_material.Blue_24[6].transform.childCount == 2 ||
                            move_material.Blue_24[7].transform.childCount == 2 ||
                            move_material.Blue_24[8].transform.childCount == 2 ||
                            move_material.Blue_24[9].transform.childCount == 2 ||
                            move_material.Blue_24[10].transform.childCount == 2 ||
                            move_material.Blue_24[11].transform.childCount == 2 ||
                            move_material.Blue_24[12].transform.childCount == 2 ||
                            move_material.Blue_24[13].transform.childCount == 2 ||
                            move_material.Blue_24[14].transform.childCount == 2 ||
                            move_material.Blue_24[15].transform.childCount == 2)
                        {
                            if (move_material.Blue_24[0].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[1].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[2].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[3].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[4].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[5].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[6].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[7].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[8].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[9].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[10].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[11].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[12].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[13].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[14].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[15].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                            }
                        }

                        //Player1_Cup.SetActive(true);
                        //Player2_Cup.SetActive(false);
                        //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                    }
                }

            }

        }


        else//이거 있을 때 없을때 시험해보고 이상하면 지우기 
        {
            if (Click_Button.Click_Count < 3)//4였음
            {
                Click_Button.Click_Count++;//1번 추가
                Click_Button.UpdateClickCountText();

                StartCoroutine(Go_Player_1());

                IEnumerator Go_Player_1()
                {
                    yield return new WaitForSeconds(0.0f);//0.5였음

                    Rotate_board.transform.Rotate(0f, 0f, 180f);
                    board.anchoredPosition = new Vector2(0f, 12.9f);//0.0였는디
                    //1초 후 z축 0도로 돌리기

                    Go_Player1_B.SetActive(false); ;//블루
                    Go_Player2_B.SetActive(true);

                    //0813
                    blue.SetActive(false);
                    pink.SetActive(true);
                    //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                    //08.11.금
                    if (move_material.Blue_24[0].transform.childCount == 2 ||
                        move_material.Blue_24[1].transform.childCount == 2 ||
                        move_material.Blue_24[2].transform.childCount == 2 ||
                        move_material.Blue_24[3].transform.childCount == 2 ||
                        move_material.Blue_24[4].transform.childCount == 2 ||
                        move_material.Blue_24[5].transform.childCount == 2 ||
                        move_material.Blue_24[6].transform.childCount == 2 ||
                        move_material.Blue_24[7].transform.childCount == 2 ||
                        move_material.Blue_24[8].transform.childCount == 2 ||
                        move_material.Blue_24[9].transform.childCount == 2 ||
                        move_material.Blue_24[10].transform.childCount == 2 ||
                        move_material.Blue_24[11].transform.childCount == 2 ||
                        move_material.Blue_24[12].transform.childCount == 2 ||
                        move_material.Blue_24[13].transform.childCount == 2 ||
                        move_material.Blue_24[14].transform.childCount == 2 ||
                        move_material.Blue_24[15].transform.childCount == 2)
                    {
                        if (move_material.Blue_24[0].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[1].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[2].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[3].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[4].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[5].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[6].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[7].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[8].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[9].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[10].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[11].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[12].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[13].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[14].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[15].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                        }
                    }

                    //Player1_Cup.SetActive(true);
                    //Player2_Cup.SetActive(false);
                    //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                }
            }

            //여긴 새로 만든 거 0814
            else if (Click_Button.Click_Count == 3)//3
            {
                Debug.Log("블루 클릭 카운트 4나와랏 얍");

                Click_Button.Click_Count++;//1번 추가
                Click_Button.UpdateClickCountText();

                StartCoroutine(Go_Player_1());

                IEnumerator Go_Player_1()
                {
                    yield return new WaitForSeconds(0.0f);//0.5였음

                    Rotate_board.transform.Rotate(0f, 0f, 180f);
                    board.anchoredPosition = new Vector2(0f, 0.0f);//0.0였는디
                    //1초 후 z축 0도로 돌리기

                    Go_Player1_B.SetActive(true); //블루
                    Go_Player2_B.SetActive(false);

                    //0813
                    blue.SetActive(true);
                    pink.SetActive(false);
                    //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                    //08.11.금
                    if (move_material.Blue_24[0].transform.childCount == 2 ||
                        move_material.Blue_24[1].transform.childCount == 2 ||
                        move_material.Blue_24[2].transform.childCount == 2 ||
                        move_material.Blue_24[3].transform.childCount == 2 ||
                        move_material.Blue_24[4].transform.childCount == 2 ||
                        move_material.Blue_24[5].transform.childCount == 2 ||
                        move_material.Blue_24[6].transform.childCount == 2 ||
                        move_material.Blue_24[7].transform.childCount == 2 ||
                        move_material.Blue_24[8].transform.childCount == 2 ||
                        move_material.Blue_24[9].transform.childCount == 2 ||
                        move_material.Blue_24[10].transform.childCount == 2 ||
                        move_material.Blue_24[11].transform.childCount == 2 ||
                        move_material.Blue_24[12].transform.childCount == 2 ||
                        move_material.Blue_24[13].transform.childCount == 2 ||
                        move_material.Blue_24[14].transform.childCount == 2 ||
                        move_material.Blue_24[15].transform.childCount == 2)
                    {
                        if (move_material.Blue_24[0].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[1].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[2].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[3].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[4].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[5].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[6].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[7].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[8].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[9].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[10].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[11].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[12].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[13].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[14].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[15].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                        }
                    }

                    //Player1_Cup.SetActive(true);
                    //Player2_Cup.SetActive(false);
                    //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                }
            }

            //여긴 원래 있던 거
            else if (Click_Button.Click_Count > 3 &&
                (card_move.Blue_Fourth_Line[0].transform.childCount == 1
                || card_move.Blue_Fourth_Line[1].transform.childCount == 1
                || card_move.Blue_Fourth_Line[2].transform.childCount == 1
                || card_move.Blue_Fourth_Line[3].transform.childCount == 1
                || card_move.Blue_Fourth_Line[4].transform.childCount == 1
                || card_move.Blue_Fourth_Line[5].transform.childCount == 1
                || card_move.Blue_Fourth_Line[6].transform.childCount == 1))
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//같은 칸에 말이 2개 있을 때
                {
                    //핑크
                    upgrade_tile.No_Double_Player();
                }

                else
                {

                    Click_Button.Click_Count++;//1번 추가
                    Click_Button.UpdateClickCountText();

                    StartCoroutine(Go_Player_1());
                    Score.SetActive(false);

                    Stay_Curtain_Left.SetActive(false);
                    Stay_Curtain_Right.SetActive(false);

                    Open_Curtain_Left.SetActive(false);
                    Open_Curtain_Right.SetActive(false);

                    Close_Curtain_Left.SetActive(false);
                    Close_Curtain_Right.SetActive(false);

                    Text_Game_Result.SetActive(false);
                    Text_Pink_Team_Win.SetActive(false);
                    Text_Blue_Team_Win.SetActive(false);

                    About_Blue.SetActive(false);
                    About_Pink.SetActive(false);

                    IEnumerator Go_Player_1()
                    {
                        yield return new WaitForSeconds(2.8f);//0.5였음

                        Debug.Log("5번 실행되었다 오버");



                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        board.anchoredPosition = new Vector2(0f, 12.9f);//0.0였는디
                                                                       //1초 후 z축 0도로 돌리기

                        Go_Player1_B.SetActive(false); ;//블루
                        Go_Player2_B.SetActive(true);

                        //0813
                        blue.SetActive(false);
                        pink.SetActive(true);
                        //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                        //08.07.새로 추가
                        Blue_Material_Canvas.SetActive(false);
                        Pink_Material_Canvas.SetActive(true);

                        Good_Bad_Blue_1.SetActive(false);
                        Good_Bad_Blue_2.SetActive(false);
                        //Good_Bad_Pink.SetActive(false);

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

                        //08.11.금
                        if (move_material.Blue_24[0].transform.childCount == 2 ||
                            move_material.Blue_24[1].transform.childCount == 2 ||
                            move_material.Blue_24[2].transform.childCount == 2 ||
                            move_material.Blue_24[3].transform.childCount == 2 ||
                            move_material.Blue_24[4].transform.childCount == 2 ||
                            move_material.Blue_24[5].transform.childCount == 2 ||
                            move_material.Blue_24[6].transform.childCount == 2 ||
                            move_material.Blue_24[7].transform.childCount == 2 ||
                            move_material.Blue_24[8].transform.childCount == 2 ||
                            move_material.Blue_24[9].transform.childCount == 2 ||
                            move_material.Blue_24[10].transform.childCount == 2 ||
                            move_material.Blue_24[11].transform.childCount == 2 ||
                            move_material.Blue_24[12].transform.childCount == 2 ||
                            move_material.Blue_24[13].transform.childCount == 2 ||
                            move_material.Blue_24[14].transform.childCount == 2 ||
                            move_material.Blue_24[15].transform.childCount == 2)
                        {
                            if (move_material.Blue_24[0].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[1].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[2].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[3].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[4].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[5].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[6].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[7].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[8].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[9].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[10].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[11].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[12].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[13].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[14].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[15].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                            }
                        }

                        //Player1_Cup.SetActive(true);
                        //Player2_Cup.SetActive(false);
                        //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                    }
                }

            }

            else if (Click_Button.Click_Count > 3 &&
                card_move.Blue_Fourth_Line[0].transform.childCount == 0
                && card_move.Blue_Fourth_Line[1].transform.childCount == 0
                && card_move.Blue_Fourth_Line[2].transform.childCount == 0
                && card_move.Blue_Fourth_Line[3].transform.childCount == 0
                && card_move.Blue_Fourth_Line[4].transform.childCount == 0
                && card_move.Blue_Fourth_Line[5].transform.childCount == 0
                && card_move.Blue_Fourth_Line[6].transform.childCount == 0)
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//같은 칸에 말이 2개 있을 때
                {
                    //핑크
                    upgrade_tile.No_Double_Player();
                }

                else
                {


                    Click_Button.Click_Count++;//1번 추가
                    Click_Button.UpdateClickCountText();

                    StartCoroutine(Go_Player_1());
                    Score.SetActive(false);

                    Stay_Curtain_Left.SetActive(false);
                    Stay_Curtain_Right.SetActive(false);

                    Open_Curtain_Left.SetActive(false);
                    Open_Curtain_Right.SetActive(false);

                    Close_Curtain_Left.SetActive(false);
                    Close_Curtain_Right.SetActive(false);

                    Text_Game_Result.SetActive(false);
                    Text_Pink_Team_Win.SetActive(false);
                    Text_Blue_Team_Win.SetActive(false);

                    About_Blue.SetActive(false);
                    About_Pink.SetActive(false);

                    IEnumerator Go_Player_1()
                    {
                        yield return new WaitForSeconds(0.5f);//0.5였음

                        Debug.Log("6번 실행되었다 오버");




                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        board.anchoredPosition = new Vector2(0f, 12.9f);//0.0였는디
                                                                       //1초 후 z축 0도로 돌리기

                        Go_Player1_B.SetActive(false); ;//블루
                        Go_Player2_B.SetActive(true);

                        //0813
                        blue.SetActive(false);
                        pink.SetActive(true);
                        //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                        //08.07.새로 추가
                        Blue_Material_Canvas.SetActive(false);
                        Pink_Material_Canvas.SetActive(true);

                        Good_Bad_Blue_1.SetActive(false);
                        Good_Bad_Blue_2.SetActive(false);
                        //Good_Bad_Pink.SetActive(false);

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

                        //08.11.금
                        if (move_material.Blue_24[0].transform.childCount == 2 ||
                            move_material.Blue_24[1].transform.childCount == 2 ||
                            move_material.Blue_24[2].transform.childCount == 2 ||
                            move_material.Blue_24[3].transform.childCount == 2 ||
                            move_material.Blue_24[4].transform.childCount == 2 ||
                            move_material.Blue_24[5].transform.childCount == 2 ||
                            move_material.Blue_24[6].transform.childCount == 2 ||
                            move_material.Blue_24[7].transform.childCount == 2 ||
                            move_material.Blue_24[8].transform.childCount == 2 ||
                            move_material.Blue_24[9].transform.childCount == 2 ||
                            move_material.Blue_24[10].transform.childCount == 2 ||
                            move_material.Blue_24[11].transform.childCount == 2 ||
                            move_material.Blue_24[12].transform.childCount == 2 ||
                            move_material.Blue_24[13].transform.childCount == 2 ||
                            move_material.Blue_24[14].transform.childCount == 2 ||
                            move_material.Blue_24[15].transform.childCount == 2)
                        {
                            if (move_material.Blue_24[0].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[1].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[2].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[3].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[4].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[5].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[6].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[7].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[8].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[9].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[10].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[11].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[12].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[13].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[14].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[15].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                            }
                        }

                        //Player1_Cup.SetActive(true);
                        //Player2_Cup.SetActive(false);
                        //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                    }
                }

            }

        }



        Plate_Back.anchoredPosition = new Vector2(1.0f, 3.8147e-05f);
    }

    /*public void Go_Player2()//블루 확정
    {

        Vector2 currentPosition = board.anchoredPosition;//현재 오브젝트 위치를 가져와서 currentPosition에 적용

        // 만약 현재 위치가 (0, 15.6)라면
        if (currentPosition.x == 0 && currentPosition.y == 12.9f)
        {
            if (Click_Button.Click_Count < 4)
            {
                Click_Button.Click_Count++;//1번 추가
                Click_Button.UpdateClickCountText();

                StartCoroutine(Go_Player_2_1());

                IEnumerator Go_Player_2_1()
                {
                    yield return new WaitForSeconds(0.0f);//0.5였음

                    

                    Rotate_board.transform.Rotate(0f, 0f, 180f);
                    // 현재 위치를 (0, 0)으로 변경
                    board.anchoredPosition = new Vector2(0f, 0);//-0.1f였는디

                    Go_Player2_B.SetActive(true);
                    Go_Player1_B.SetActive(false); ;//블루
                                                    //1초 후 다음 턴 버튼을 2플레이어 때 나타나는 걸로 바꾸기

                    //0813
                    blue.SetActive(false);
                    pink.SetActive(true);
                    //Player2_Cup.SetActive(true);
                    //Player1_Cup.SetActive(false);
                    //1초 후 컵 2플레이어 걸로 바꾸기(저장된 거 불러오기)

                    //08.11.금
                    if (move_material.Blue_24[0].transform.childCount == 2 ||
                        move_material.Blue_24[1].transform.childCount == 2 ||
                        move_material.Blue_24[2].transform.childCount == 2 ||
                        move_material.Blue_24[3].transform.childCount == 2 ||
                        move_material.Blue_24[4].transform.childCount == 2 ||
                        move_material.Blue_24[5].transform.childCount == 2 ||
                        move_material.Blue_24[6].transform.childCount == 2 ||
                        move_material.Blue_24[7].transform.childCount == 2 ||
                        move_material.Blue_24[8].transform.childCount == 2 ||
                        move_material.Blue_24[9].transform.childCount == 2 ||
                        move_material.Blue_24[10].transform.childCount == 2 ||
                        move_material.Blue_24[11].transform.childCount == 2 ||
                        move_material.Blue_24[12].transform.childCount == 2 ||
                        move_material.Blue_24[13].transform.childCount == 2 ||
                        move_material.Blue_24[14].transform.childCount == 2 ||
                        move_material.Blue_24[15].transform.childCount == 2)
                    {
                        if (move_material.Blue_24[0].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[1].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[2].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[3].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[4].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[5].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[6].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[7].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[8].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[9].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[10].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[11].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[12].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[13].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[14].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[15].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                        }
                    }
                }
            }


            else if (Click_Button.Click_Count > 3 &&
                (card_move.Blue_Fourth_Line[0].transform.childCount == 1
                || card_move.Blue_Fourth_Line[1].transform.childCount == 1
                || card_move.Blue_Fourth_Line[2].transform.childCount == 1
                || card_move.Blue_Fourth_Line[3].transform.childCount == 1
                || card_move.Blue_Fourth_Line[4].transform.childCount == 1
                || card_move.Blue_Fourth_Line[5].transform.childCount == 1
                || card_move.Blue_Fourth_Line[6].transform.childCount == 1))//클릭 카운트가 4 이상일 때 //4번째 줄 자식이 있는게 하나 이상일 때
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//같은 칸에 말이 2개 있을 때
                {
                    //블루
                    upgrade_tile_blue.No_Double_Player();
                }

                else
                {



                    Click_Button.Click_Count++;//1번 추가
                    Click_Button.UpdateClickCountText();

                    StartCoroutine(Go_Player_2_1());
                    Score.SetActive(false);

                    Stay_Curtain_Left.SetActive(false);
                    Stay_Curtain_Right.SetActive(false);

                    Open_Curtain_Left.SetActive(false);
                    Open_Curtain_Right.SetActive(false);

                    Close_Curtain_Left.SetActive(false);
                    Close_Curtain_Right.SetActive(false);

                    Text_Game_Result.SetActive(false);
                    Text_Pink_Team_Win.SetActive(false);
                    Text_Blue_Team_Win.SetActive(false);

                    About_Blue.SetActive(false);
                    About_Pink.SetActive(false);


                    IEnumerator Go_Player_2_1()
                    {
                        yield return new WaitForSeconds(2.8f);//0.5였음

                        Debug.Log("7번 실행되었다 오버");

                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        // 현재 위치를 (0, 0)으로 변경
                        board.anchoredPosition = new Vector2(0f, 0);//-0.1f였는디

                        Go_Player2_B.SetActive(true);
                        Go_Player1_B.SetActive(false); ;//블루
                                                        //1초 후 다음 턴 버튼을 2플레이어 때 나타나는 걸로 바꾸기

                        //08.07.새로 추가
                        Blue_Material_Canvas.SetActive(false);
                        Pink_Material_Canvas.SetActive(true);

                        Good_Bad_Blue.SetActive(false);
                        //Good_Bad_Pink.SetActive(true);

                        Good_Bad_Pink_1.SetActive(true);
                        Good_Bad_Pink_2.SetActive(true);

                        Coin_Blue.SetActive(false);
                        Coin_Pink.SetActive(true);

                        //0813
                        blue.SetActive(false);
                        pink.SetActive(true);

                        blue_pink.Pink_Cups[0].SetActive(true);
                        blue_pink.Pink_Cups[1].SetActive(false);
                        blue_pink.Blue_Cups[0].SetActive(false);
                        blue_pink.Blue_Cups[1].SetActive(false);

                        //08.11.금
                        if (move_material.Blue_24[0].transform.childCount == 2 ||
                            move_material.Blue_24[1].transform.childCount == 2 ||
                            move_material.Blue_24[2].transform.childCount == 2 ||
                            move_material.Blue_24[3].transform.childCount == 2 ||
                            move_material.Blue_24[4].transform.childCount == 2 ||
                            move_material.Blue_24[5].transform.childCount == 2 ||
                            move_material.Blue_24[6].transform.childCount == 2 ||
                            move_material.Blue_24[7].transform.childCount == 2 ||
                            move_material.Blue_24[8].transform.childCount == 2 ||
                            move_material.Blue_24[9].transform.childCount == 2 ||
                            move_material.Blue_24[10].transform.childCount == 2 ||
                            move_material.Blue_24[11].transform.childCount == 2 ||
                            move_material.Blue_24[12].transform.childCount == 2 ||
                            move_material.Blue_24[13].transform.childCount == 2 ||
                            move_material.Blue_24[14].transform.childCount == 2 ||
                            move_material.Blue_24[15].transform.childCount == 2)
                        {
                            if (move_material.Blue_24[0].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[1].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[2].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[3].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[4].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[5].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[6].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[7].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[8].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[9].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[10].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[11].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[12].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[13].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[14].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[15].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                            }
                        }

                        //Player2_Cup.SetActive(true);
                        //Player1_Cup.SetActive(false);
                        //1초 후 컵 2플레이어 걸로 바꾸기(저장된 거 불러오기)
                    }
                }
                


            }

            else if (Click_Button.Click_Count > 3 &&
                (card_move.Blue_Fourth_Line[0].transform.childCount == 0
                && card_move.Blue_Fourth_Line[1].transform.childCount == 0
                && card_move.Blue_Fourth_Line[2].transform.childCount == 0
                && card_move.Blue_Fourth_Line[3].transform.childCount == 0
                && card_move.Blue_Fourth_Line[4].transform.childCount == 0
                && card_move.Blue_Fourth_Line[5].transform.childCount == 0
                && card_move.Blue_Fourth_Line[6].transform.childCount == 0))//클릭 카운트가 4 이상일 때 //4번째 줄 자식이 있는게 하나 이상일 때
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//같은 칸에 말이 2개 있을 때
                {
                    //블루
                    upgrade_tile_blue.No_Double_Player();
                }

                else
                {



                    Click_Button.Click_Count++;//1번 추가
                    Click_Button.UpdateClickCountText();

                    StartCoroutine(Go_Player_2_1());
                    Score.SetActive(false);

                    Stay_Curtain_Left.SetActive(false);
                    Stay_Curtain_Right.SetActive(false);

                    Open_Curtain_Left.SetActive(false);
                    Open_Curtain_Right.SetActive(false);

                    Close_Curtain_Left.SetActive(false);
                    Close_Curtain_Right.SetActive(false);

                    Text_Game_Result.SetActive(false);
                    Text_Pink_Team_Win.SetActive(false);
                    Text_Blue_Team_Win.SetActive(false);

                    About_Blue.SetActive(false);
                    About_Pink.SetActive(false);

                    IEnumerator Go_Player_2_1()
                    {
                        yield return new WaitForSeconds(0.5f);//0.5였음

                        Debug.Log("8번 실행되었다 오버");

                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        // 현재 위치를 (0, 0)으로 변경
                        board.anchoredPosition = new Vector2(0f, 0);//-0.1f였는디

                        Go_Player2_B.SetActive(true);
                        Go_Player1_B.SetActive(false); ;//블루
                                                        //1초 후 다음 턴 버튼을 2플레이어 때 나타나는 걸로 바꾸기

                        //Player2_Cup.SetActive(true);
                        //Player1_Cup.SetActive(false);
                        //1초 후 컵 2플레이어 걸로 바꾸기(저장된 거 불러오기)

                        //08.07.새로 추가
                        Blue_Material_Canvas.SetActive(false);
                        Pink_Material_Canvas.SetActive(true);

                        Good_Bad_Blue.SetActive(false);
                        //Good_Bad_Pink.SetActive(true);

                        Good_Bad_Pink_1.SetActive(true);
                        Good_Bad_Pink_2.SetActive(true);

                        //0813
                        blue.SetActive(false);
                        pink.SetActive(true);

                        Coin_Blue.SetActive(false);
                        Coin_Pink.SetActive(true);

                        blue_pink.Pink_Cups[0].SetActive(true);
                        blue_pink.Pink_Cups[1].SetActive(false);
                        blue_pink.Blue_Cups[0].SetActive(false);
                        blue_pink.Blue_Cups[1].SetActive(false);

                        //08.11.금
                        if (move_material.Blue_24[0].transform.childCount == 2 ||
                            move_material.Blue_24[1].transform.childCount == 2 ||
                            move_material.Blue_24[2].transform.childCount == 2 ||
                            move_material.Blue_24[3].transform.childCount == 2 ||
                            move_material.Blue_24[4].transform.childCount == 2 ||
                            move_material.Blue_24[5].transform.childCount == 2 ||
                            move_material.Blue_24[6].transform.childCount == 2 ||
                            move_material.Blue_24[7].transform.childCount == 2 ||
                            move_material.Blue_24[8].transform.childCount == 2 ||
                            move_material.Blue_24[9].transform.childCount == 2 ||
                            move_material.Blue_24[10].transform.childCount == 2 ||
                            move_material.Blue_24[11].transform.childCount == 2 ||
                            move_material.Blue_24[12].transform.childCount == 2 ||
                            move_material.Blue_24[13].transform.childCount == 2 ||
                            move_material.Blue_24[14].transform.childCount == 2 ||
                            move_material.Blue_24[15].transform.childCount == 2)
                        {
                            if (move_material.Blue_24[0].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[1].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[2].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[3].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[4].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[5].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[6].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[7].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[8].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[9].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[10].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[11].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[12].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[13].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[14].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[15].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                            }
                        }
                    }
                }
                


            }




        }

        if (currentPosition.x == 0 && currentPosition.y == 0)
        {
            if (Click_Button.Click_Count < 3)//4였음
            {
                Click_Button.Click_Count++;//1번 추가
                Click_Button.UpdateClickCountText();

                StartCoroutine(Go_Player_2());
                //StartCoroutine(RotateAndMove2());


                IEnumerator Go_Player_2()
                {
                    yield return new WaitForSeconds(0.0f);//0.5였음

                  


                    // 오브젝트를 z축으로 180도 회전
                    Rotate_board.transform.Rotate(0f, 0f, 180f);
                    board.anchoredPosition = new Vector2(0f, 12.9f);//12.9였는디

                    Go_Player2_B.SetActive(true);
                    Go_Player1_B.SetActive(false); ;//블루

                    //0813
                    blue.SetActive(false);
                    pink.SetActive(true);

                    //08.11.금
                    if (move_material.Blue_24[0].transform.childCount == 2 ||
                        move_material.Blue_24[1].transform.childCount == 2 ||
                        move_material.Blue_24[2].transform.childCount == 2 ||
                        move_material.Blue_24[3].transform.childCount == 2 ||
                        move_material.Blue_24[4].transform.childCount == 2 ||
                        move_material.Blue_24[5].transform.childCount == 2 ||
                        move_material.Blue_24[6].transform.childCount == 2 ||
                        move_material.Blue_24[7].transform.childCount == 2 ||
                        move_material.Blue_24[8].transform.childCount == 2 ||
                        move_material.Blue_24[9].transform.childCount == 2 ||
                        move_material.Blue_24[10].transform.childCount == 2 ||
                        move_material.Blue_24[11].transform.childCount == 2 ||
                        move_material.Blue_24[12].transform.childCount == 2 ||
                        move_material.Blue_24[13].transform.childCount == 2 ||
                        move_material.Blue_24[14].transform.childCount == 2 ||
                        move_material.Blue_24[15].transform.childCount == 2)
                    {
                        if (move_material.Blue_24[0].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[1].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[2].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[3].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[4].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[5].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[6].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[7].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[8].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[9].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[10].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[11].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[12].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[13].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[14].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[15].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                        }
                    }
                    //1초 후 다음 턴 버튼을 2플레이어 때 나타나는 걸로 바꾸기

                    //Player2_Cup.SetActive(true);
                    //Player1_Cup.SetActive(false);
                    //1초 후 컵 2플레이어 걸로 바꾸기(저장된 거 불러오기)

                }
            }

            //여기는 새로 추가한 거0814
            else if (Click_Button.Click_Count == 3)
            {
                Debug.Log("이거 실행되면 안됨");

                //Click_Button.Click_Count++;//1번 추가
                //Click_Button.UpdateClickCountText();

                Debug.Log("블루 얼만디 앞" + Click_Button.Click_Count);

                Click_Button.Click_Count++;//1번 추가
                Click_Button.UpdateClickCountText();

                Debug.Log("블루 얼만디 뒤" + Click_Button.Click_Count);

                StartCoroutine(Go_Player_2());
                //StartCoroutine(RotateAndMove2());


                IEnumerator Go_Player_2()
                {
                    yield return new WaitForSeconds(0.0f);//0.5였음

                    // 오브젝트를 z축으로 180도 회전
                    //Rotate_board.transform.Rotate(0f, 0f, 180f);
                    board.anchoredPosition = new Vector2(0f, 0.0f);//12.9였는디

                    Go_Player2_B.SetActive(false);
                    Go_Player1_B.SetActive(true); //블루

                    //0813
                    blue.SetActive(true);
                    pink.SetActive(false);

                    //08.11.금
                    if (move_material.Blue_24[0].transform.childCount == 2 ||
                        move_material.Blue_24[1].transform.childCount == 2 ||
                        move_material.Blue_24[2].transform.childCount == 2 ||
                        move_material.Blue_24[3].transform.childCount == 2 ||
                        move_material.Blue_24[4].transform.childCount == 2 ||
                        move_material.Blue_24[5].transform.childCount == 2 ||
                        move_material.Blue_24[6].transform.childCount == 2 ||
                        move_material.Blue_24[7].transform.childCount == 2 ||
                        move_material.Blue_24[8].transform.childCount == 2 ||
                        move_material.Blue_24[9].transform.childCount == 2 ||
                        move_material.Blue_24[10].transform.childCount == 2 ||
                        move_material.Blue_24[11].transform.childCount == 2 ||
                        move_material.Blue_24[12].transform.childCount == 2 ||
                        move_material.Blue_24[13].transform.childCount == 2 ||
                        move_material.Blue_24[14].transform.childCount == 2 ||
                        move_material.Blue_24[15].transform.childCount == 2)
                    {
                        if (move_material.Blue_24[0].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[1].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[2].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[3].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[4].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[5].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[6].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[7].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[8].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[9].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[10].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[11].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[12].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[13].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[14].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[15].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                        }
                    }
                    //1초 후 다음 턴 버튼을 2플레이어 때 나타나는 걸로 바꾸기

                    //Player2_Cup.SetActive(true);
                    //Player1_Cup.SetActive(false);
                    //1초 후 컵 2플레이어 걸로 바꾸기(저장된 거 불러오기)

                }
            }



            //여기는 원래 있었던 거
            if (Click_Button.Click_Count > 3 &&
                (card_move.Blue_Fourth_Line[0].transform.childCount == 1
                || card_move.Blue_Fourth_Line[1].transform.childCount == 1
                || card_move.Blue_Fourth_Line[2].transform.childCount == 1
                || card_move.Blue_Fourth_Line[3].transform.childCount == 1
                || card_move.Blue_Fourth_Line[4].transform.childCount == 1
                || card_move.Blue_Fourth_Line[5].transform.childCount == 1
                || card_move.Blue_Fourth_Line[6].transform.childCount == 1))//클릭 카운트가 4 이상일 때 //4번째 줄 자식이 있는게 하나 이상일 때
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//같은 칸에 말이 2개 있을 때
                {
                    //블루
                    upgrade_tile_blue.No_Double_Player();
                }

                else
                {

                    Click_Button.Click_Count++;//1번 추가
                    Click_Button.UpdateClickCountText();

                    StartCoroutine(Go_Player_2());
                    Score.SetActive(false);

                    Stay_Curtain_Left.SetActive(false);
                    Stay_Curtain_Right.SetActive(false);

                    Open_Curtain_Left.SetActive(false);
                    Open_Curtain_Right.SetActive(false);

                    Close_Curtain_Left.SetActive(false);
                    Close_Curtain_Right.SetActive(false);

                    Text_Game_Result.SetActive(false);
                    Text_Pink_Team_Win.SetActive(false);
                    Text_Blue_Team_Win.SetActive(false);

                    About_Blue.SetActive(false);
                    About_Pink.SetActive(false);

                    //StartCoroutine(RotateAndMove2());


                    IEnumerator Go_Player_2()
                    {
                        yield return new WaitForSeconds(2.8f);//0.5였음

                        Debug.Log("9번 실행되었다 오버");

                        // 오브젝트를 z축으로 180도 회전
                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        board.anchoredPosition = new Vector2(0f, 12.9f);//12.9였는디

                        Go_Player2_B.SetActive(true);
                        Go_Player1_B.SetActive(false); //블루
                                                        //1초 후 다음 턴 버튼을 2플레이어 때 나타나는 걸로 바꾸기

                        //Player2_Cup.SetActive(true);
                        //Player1_Cup.SetActive(false);
                        //1초 후 컵 2플레이어 걸로 바꾸기(저장된 거 불러오기)

                        //08.07.새로 추가
                        Blue_Material_Canvas.SetActive(false);
                        Pink_Material_Canvas.SetActive(true);

                        Good_Bad_Blue.SetActive(false);
                        //Good_Bad_Pink.SetActive(true);

                        Good_Bad_Pink_1.SetActive(true);
                        Good_Bad_Pink_2.SetActive(true);

                        //0813
                        blue.SetActive(false);
                        pink.SetActive(true);

                        Coin_Blue.SetActive(false);
                        Coin_Pink.SetActive(true);

                        blue_pink.Pink_Cups[0].SetActive(true);
                        blue_pink.Pink_Cups[1].SetActive(false);
                        blue_pink.Blue_Cups[0].SetActive(false);
                        blue_pink.Blue_Cups[1].SetActive(false);

                        //08.11.금
                        if (move_material.Blue_24[0].transform.childCount == 2 ||
                            move_material.Blue_24[1].transform.childCount == 2 ||
                            move_material.Blue_24[2].transform.childCount == 2 ||
                            move_material.Blue_24[3].transform.childCount == 2 ||
                            move_material.Blue_24[4].transform.childCount == 2 ||
                            move_material.Blue_24[5].transform.childCount == 2 ||
                            move_material.Blue_24[6].transform.childCount == 2 ||
                            move_material.Blue_24[7].transform.childCount == 2 ||
                            move_material.Blue_24[8].transform.childCount == 2 ||
                            move_material.Blue_24[9].transform.childCount == 2 ||
                            move_material.Blue_24[10].transform.childCount == 2 ||
                            move_material.Blue_24[11].transform.childCount == 2 ||
                            move_material.Blue_24[12].transform.childCount == 2 ||
                            move_material.Blue_24[13].transform.childCount == 2 ||
                            move_material.Blue_24[14].transform.childCount == 2 ||
                            move_material.Blue_24[15].transform.childCount == 2)
                        {
                            if (move_material.Blue_24[0].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[1].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[2].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[3].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[4].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[5].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[6].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[7].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[8].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[9].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[10].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[11].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[12].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[13].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[14].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[15].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                            }


                        }

                    }
                }

            }

            if (Click_Button.Click_Count > 3 &&
                (card_move.Blue_Fourth_Line[0].transform.childCount == 0
                && card_move.Blue_Fourth_Line[1].transform.childCount == 0
                && card_move.Blue_Fourth_Line[2].transform.childCount == 0
                && card_move.Blue_Fourth_Line[3].transform.childCount == 0
                && card_move.Blue_Fourth_Line[4].transform.childCount == 0
                && card_move.Blue_Fourth_Line[5].transform.childCount == 0
                && card_move.Blue_Fourth_Line[6].transform.childCount == 0))//클릭 카운트가 4 이상일 때 //4번째 줄 자식이 있는게 하나 이상일 때
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//같은 칸에 말이 2개 있을 때
                {
                    //블루
                    upgrade_tile_blue.No_Double_Player();
                }

                else
                {



                    Click_Button.Click_Count++;//1번 추가
                    Click_Button.UpdateClickCountText();

                    StartCoroutine(Go_Player_2());
                    Score.SetActive(false);

                    Stay_Curtain_Left.SetActive(false);
                    Stay_Curtain_Right.SetActive(false);

                    Open_Curtain_Left.SetActive(false);
                    Open_Curtain_Right.SetActive(false);

                    Close_Curtain_Left.SetActive(false);
                    Close_Curtain_Right.SetActive(false);

                    Text_Game_Result.SetActive(false);
                    Text_Pink_Team_Win.SetActive(false);
                    Text_Blue_Team_Win.SetActive(false);

                    About_Blue.SetActive(false);
                    About_Pink.SetActive(false);

                    //StartCoroutine(RotateAndMove2());


                    IEnumerator Go_Player_2()
                    {
                        yield return new WaitForSeconds(0.5f);//0.5였음


                        // Debug.Log("10번 실행되었다 오버");
                        // 오브젝트를 z축으로 180도 회전
                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        board.anchoredPosition = new Vector2(0f, 12.9f);//12.9였는디

                        Go_Player2_B.SetActive(true);
                        Go_Player1_B.SetActive(false); ;//블루
                                                        //1초 후 다음 턴 버튼을 2플레이어 때 나타나는 걸로 바꾸기

                        //Player2_Cup.SetActive(true);
                        //Player1_Cup.SetActive(false);
                        //1초 후 컵 2플레이어 걸로 바꾸기(저장된 거 불러오기)

                        //08.07.새로 추가
                        Blue_Material_Canvas.SetActive(false);
                        Pink_Material_Canvas.SetActive(true);

                        Good_Bad_Blue.SetActive(false);
                        //Good_Bad_Pink.SetActive(true);

                        Good_Bad_Pink_1.SetActive(true);
                        Good_Bad_Pink_2.SetActive(true);

                        Coin_Blue.SetActive(false);
                        Coin_Pink.SetActive(true);
                        //0813
                        blue.SetActive(false);
                        pink.SetActive(true);

                        blue_pink.Pink_Cups[0].SetActive(true);
                        blue_pink.Pink_Cups[1].SetActive(false);
                        blue_pink.Blue_Cups[0].SetActive(false);
                        blue_pink.Blue_Cups[1].SetActive(false);

                        //08.11.금
                        if (move_material.Blue_24[0].transform.childCount == 2 ||
                            move_material.Blue_24[1].transform.childCount == 2 ||
                            move_material.Blue_24[2].transform.childCount == 2 ||
                            move_material.Blue_24[3].transform.childCount == 2 ||
                            move_material.Blue_24[4].transform.childCount == 2 ||
                            move_material.Blue_24[5].transform.childCount == 2 ||
                            move_material.Blue_24[6].transform.childCount == 2 ||
                            move_material.Blue_24[7].transform.childCount == 2 ||
                            move_material.Blue_24[8].transform.childCount == 2 ||
                            move_material.Blue_24[9].transform.childCount == 2 ||
                            move_material.Blue_24[10].transform.childCount == 2 ||
                            move_material.Blue_24[11].transform.childCount == 2 ||
                            move_material.Blue_24[12].transform.childCount == 2 ||
                            move_material.Blue_24[13].transform.childCount == 2 ||
                            move_material.Blue_24[14].transform.childCount == 2 ||
                            move_material.Blue_24[15].transform.childCount == 2)
                        {
                            if (move_material.Blue_24[0].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[1].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[2].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[3].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[4].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[5].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[6].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[7].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[8].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[9].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[10].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[11].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[12].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[13].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[14].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[15].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                            }
                        }

                    }
                }

            }

        }

        //새로 추가해봄 0814
        else//이거 있을 때 없을때 시험해보고 이상하면 지우기 
        {
            if (Click_Button.Click_Count < 3)//4였음
            {
                Debug.Log("이거 실행은 되냐?");

                Click_Button.Click_Count++;//1번 추가
                Click_Button.UpdateClickCountText();

                StartCoroutine(Go_Player_1());

                IEnumerator Go_Player_1()
                {
                    yield return new WaitForSeconds(0.0f);//0.5였음



                    Rotate_board.transform.Rotate(0f, 0f, 180f);
                    board.anchoredPosition = new Vector2(0f, 0.0f);//0.0였는디
                    //1초 후 z축 0도로 돌리기

                    Go_Player1_B.SetActive(false); //블루
                    Go_Player2_B.SetActive(true);

                    //0813
                    blue.SetActive(false);
                    pink.SetActive(true);
                    //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                    //08.11.금
                    if (move_material.Blue_24[0].transform.childCount == 2 ||
                        move_material.Blue_24[1].transform.childCount == 2 ||
                        move_material.Blue_24[2].transform.childCount == 2 ||
                        move_material.Blue_24[3].transform.childCount == 2 ||
                        move_material.Blue_24[4].transform.childCount == 2 ||
                        move_material.Blue_24[5].transform.childCount == 2 ||
                        move_material.Blue_24[6].transform.childCount == 2 ||
                        move_material.Blue_24[7].transform.childCount == 2 ||
                        move_material.Blue_24[8].transform.childCount == 2 ||
                        move_material.Blue_24[9].transform.childCount == 2 ||
                        move_material.Blue_24[10].transform.childCount == 2 ||
                        move_material.Blue_24[11].transform.childCount == 2 ||
                        move_material.Blue_24[12].transform.childCount == 2 ||
                        move_material.Blue_24[13].transform.childCount == 2 ||
                        move_material.Blue_24[14].transform.childCount == 2 ||
                        move_material.Blue_24[15].transform.childCount == 2)
                    {
                        if (move_material.Blue_24[0].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[1].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[2].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[3].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[4].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[5].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[6].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[7].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[8].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[9].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[10].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[11].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[12].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[13].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[14].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[15].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                        }
                    }

                    //Player1_Cup.SetActive(true);
                    //Player2_Cup.SetActive(false);
                    //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                }
            }

            //여긴 내가 새로 만듦0814
            else if (Click_Button.Click_Count == 3)//3
            {
                Debug.Log("블루 클릭 카운트 4나와랏 얍");

                Click_Button.Click_Count++;//1번 추가
                Click_Button.UpdateClickCountText();

                StartCoroutine(Go_Player_1());

                IEnumerator Go_Player_1()
                {
                    yield return new WaitForSeconds(0.0f);//0.5였음

                   
                    //Rotate_board.transform.Rotate(0f, 0f, 180f);
                    board.anchoredPosition = new Vector2(0f, 0.0f);//0.0였는디
                    //1초 후 z축 0도로 돌리기

                    Go_Player1_B.SetActive(true); //블루
                    Go_Player2_B.SetActive(false);

                    //0813
                    blue.SetActive(true);
                    pink.SetActive(false);
                    //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                    //08.11.금
                    if (move_material.Blue_24[0].transform.childCount == 2 ||
                        move_material.Blue_24[1].transform.childCount == 2 ||
                        move_material.Blue_24[2].transform.childCount == 2 ||
                        move_material.Blue_24[3].transform.childCount == 2 ||
                        move_material.Blue_24[4].transform.childCount == 2 ||
                        move_material.Blue_24[5].transform.childCount == 2 ||
                        move_material.Blue_24[6].transform.childCount == 2 ||
                        move_material.Blue_24[7].transform.childCount == 2 ||
                        move_material.Blue_24[8].transform.childCount == 2 ||
                        move_material.Blue_24[9].transform.childCount == 2 ||
                        move_material.Blue_24[10].transform.childCount == 2 ||
                        move_material.Blue_24[11].transform.childCount == 2 ||
                        move_material.Blue_24[12].transform.childCount == 2 ||
                        move_material.Blue_24[13].transform.childCount == 2 ||
                        move_material.Blue_24[14].transform.childCount == 2 ||
                        move_material.Blue_24[15].transform.childCount == 2)
                    {
                        if (move_material.Blue_24[0].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[1].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[2].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[3].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[4].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[5].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[6].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[7].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[8].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[9].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[10].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[11].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[12].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[13].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[14].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                        }

                        if (move_material.Blue_24[15].transform.childCount == 2)
                        {
                            Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                        }
                    }

                    //Player1_Cup.SetActive(true);
                    //Player2_Cup.SetActive(false);
                    //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                }
            }


            //여긴 원래 있었음
            else if (Click_Button.Click_Count > 3 &&
                (card_move.Blue_Fourth_Line[0].transform.childCount == 1
                || card_move.Blue_Fourth_Line[1].transform.childCount == 1
                || card_move.Blue_Fourth_Line[2].transform.childCount == 1
                || card_move.Blue_Fourth_Line[3].transform.childCount == 1
                || card_move.Blue_Fourth_Line[4].transform.childCount == 1
                || card_move.Blue_Fourth_Line[5].transform.childCount == 1
                || card_move.Blue_Fourth_Line[6].transform.childCount == 1))
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//같은 칸에 말이 2개 있을 때
                {
                    //핑크
                    upgrade_tile.No_Double_Player();
                }

                else
                {

                    Click_Button.Click_Count++;//1번 추가
                    Click_Button.UpdateClickCountText();

                    StartCoroutine(Go_Player_1());
                    Score.SetActive(false);

                    Stay_Curtain_Left.SetActive(false);
                    Stay_Curtain_Right.SetActive(false);

                    Open_Curtain_Left.SetActive(false);
                    Open_Curtain_Right.SetActive(false);

                    Close_Curtain_Left.SetActive(false);
                    Close_Curtain_Right.SetActive(false);

                    Text_Game_Result.SetActive(false);
                    Text_Pink_Team_Win.SetActive(false);
                    Text_Blue_Team_Win.SetActive(false);

                    About_Blue.SetActive(false);
                    About_Pink.SetActive(false);

                    IEnumerator Go_Player_1()
                    {
                        yield return new WaitForSeconds(2.8f);//0.5였음

                        Debug.Log("5번 실행되었다 오버");



                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        board.anchoredPosition = new Vector2(0f, 12.9f);//0.0였는디
                                                                       //1초 후 z축 0도로 돌리기

                        Go_Player1_B.SetActive(false); //블루
                        Go_Player2_B.SetActive(true);

                        //0813
                        blue.SetActive(false);
                        pink.SetActive(true);
                        //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                        //08.07.새로 추가
                        Blue_Material_Canvas.SetActive(false);
                        Pink_Material_Canvas.SetActive(true);

                        Good_Bad_Blue.SetActive(false);
                        //Good_Bad_Pink.SetActive(true);

                        Good_Bad_Pink_1.SetActive(true);
                        Good_Bad_Pink_2.SetActive(true);

                        Coin_Blue.SetActive(false);
                        Coin_Pink.SetActive(true);

                        blue_pink.Pink_Cups[0].SetActive(true);
                        blue_pink.Pink_Cups[1].SetActive(false);
                        blue_pink.Blue_Cups[0].SetActive(false);
                        blue_pink.Blue_Cups[1].SetActive(false);

                        //08.11.금
                        if (move_material.Blue_24[0].transform.childCount == 2 ||
                            move_material.Blue_24[1].transform.childCount == 2 ||
                            move_material.Blue_24[2].transform.childCount == 2 ||
                            move_material.Blue_24[3].transform.childCount == 2 ||
                            move_material.Blue_24[4].transform.childCount == 2 ||
                            move_material.Blue_24[5].transform.childCount == 2 ||
                            move_material.Blue_24[6].transform.childCount == 2 ||
                            move_material.Blue_24[7].transform.childCount == 2 ||
                            move_material.Blue_24[8].transform.childCount == 2 ||
                            move_material.Blue_24[9].transform.childCount == 2 ||
                            move_material.Blue_24[10].transform.childCount == 2 ||
                            move_material.Blue_24[11].transform.childCount == 2 ||
                            move_material.Blue_24[12].transform.childCount == 2 ||
                            move_material.Blue_24[13].transform.childCount == 2 ||
                            move_material.Blue_24[14].transform.childCount == 2 ||
                            move_material.Blue_24[15].transform.childCount == 2)
                        {
                            if (move_material.Blue_24[0].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[1].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[2].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[3].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[4].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[5].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[6].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[7].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[8].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[9].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[10].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[11].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[12].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[13].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[14].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[15].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                            }
                        }

                        //Player1_Cup.SetActive(true);
                        //Player2_Cup.SetActive(false);
                        //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                    }
                }

            }

            else if (Click_Button.Click_Count > 3 &&
                card_move.Blue_Fourth_Line[0].transform.childCount == 0
                && card_move.Blue_Fourth_Line[1].transform.childCount == 0
                && card_move.Blue_Fourth_Line[2].transform.childCount == 0
                && card_move.Blue_Fourth_Line[3].transform.childCount == 0
                && card_move.Blue_Fourth_Line[4].transform.childCount == 0
                && card_move.Blue_Fourth_Line[5].transform.childCount == 0
                && card_move.Blue_Fourth_Line[6].transform.childCount == 0)
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//같은 칸에 말이 2개 있을 때
                {
                    //핑크
                    upgrade_tile.No_Double_Player();
                }

                else
                {
                    Click_Button.Click_Count++;//1번 추가
                    Click_Button.UpdateClickCountText();

                    StartCoroutine(Go_Player_1());
                    Score.SetActive(false);

                    Stay_Curtain_Left.SetActive(false);
                    Stay_Curtain_Right.SetActive(false);

                    Open_Curtain_Left.SetActive(false);
                    Open_Curtain_Right.SetActive(false);

                    Close_Curtain_Left.SetActive(false);
                    Close_Curtain_Right.SetActive(false);

                    Text_Game_Result.SetActive(false);
                    Text_Pink_Team_Win.SetActive(false);
                    Text_Blue_Team_Win.SetActive(false);

                    About_Blue.SetActive(false);
                    About_Pink.SetActive(false);

                    IEnumerator Go_Player_1()
                    {
                        yield return new WaitForSeconds(0.5f);//0.5였음

                        Debug.Log("6번 실행되었다 오버");




                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        board.anchoredPosition = new Vector2(0f, 12.9f);//0.0였는디
                                                                       //1초 후 z축 0도로 돌리기

                        Go_Player1_B.SetActive(false); ;//블루
                        Go_Player2_B.SetActive(transform);

                        //0813
                        blue.SetActive(false);
                        pink.SetActive(true);
                        //1초 후 다음 턴 버튼을 1플레이어 때 나타나는 걸로 바꾸기

                        //08.07.새로 추가
                        Blue_Material_Canvas.SetActive(false);
                        Pink_Material_Canvas.SetActive(true);

                        Good_Bad_Blue.SetActive(false);
                        //Good_Bad_Pink.SetActive(true);

                        Good_Bad_Pink_1.SetActive(true);
                        Good_Bad_Pink_2.SetActive(true);

                        Coin_Blue.SetActive(false);
                        Coin_Pink.SetActive(true);

                        blue_pink.Pink_Cups[0].SetActive(true);
                        blue_pink.Pink_Cups[1].SetActive(false);
                        blue_pink.Blue_Cups[0].SetActive(false);
                        blue_pink.Blue_Cups[1].SetActive(false);

                        //08.11.금
                        if (move_material.Blue_24[0].transform.childCount == 2 ||
                            move_material.Blue_24[1].transform.childCount == 2 ||
                            move_material.Blue_24[2].transform.childCount == 2 ||
                            move_material.Blue_24[3].transform.childCount == 2 ||
                            move_material.Blue_24[4].transform.childCount == 2 ||
                            move_material.Blue_24[5].transform.childCount == 2 ||
                            move_material.Blue_24[6].transform.childCount == 2 ||
                            move_material.Blue_24[7].transform.childCount == 2 ||
                            move_material.Blue_24[8].transform.childCount == 2 ||
                            move_material.Blue_24[9].transform.childCount == 2 ||
                            move_material.Blue_24[10].transform.childCount == 2 ||
                            move_material.Blue_24[11].transform.childCount == 2 ||
                            move_material.Blue_24[12].transform.childCount == 2 ||
                            move_material.Blue_24[13].transform.childCount == 2 ||
                            move_material.Blue_24[14].transform.childCount == 2 ||
                            move_material.Blue_24[15].transform.childCount == 2)
                        {
                            if (move_material.Blue_24[0].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[0].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[1].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[1].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[2].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[2].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[3].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[3].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[4].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[4].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[5].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[5].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[6].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[6].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[7].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[7].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[8].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[8].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[9].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[9].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[10].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[10].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[11].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[11].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[12].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[12].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[13].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[13].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[14].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[14].transform.GetChild(1).gameObject);
                            }

                            if (move_material.Blue_24[15].transform.childCount == 2)
                            {
                                Destroy(move_material.Blue_24[15].transform.GetChild(1).gameObject);
                            }
                        }

                        //Player1_Cup.SetActive(true);
                        //Player2_Cup.SetActive(false);
                        //1초 후 컵 1플레이어걸로 바꾸기(저장된 거 불러오기)
                    }
                }

            }
        }


        //얘는 원래 있었음
        Plate_Back.anchoredPosition = new Vector2(1.0f, 3.8147e-05f);

        
    }*/


}
