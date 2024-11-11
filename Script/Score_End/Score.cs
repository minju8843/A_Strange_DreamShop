using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Score : MonoBehaviour
{

    public Next_Turn next_turn;
    public Good_Bad good_bad;

    public int Upgrade_Tile_Pink;
    public int Upgrade_Tile_Blue;

    public int Upgrade_Tile_Pink_Total;
    public int Upgrade_Tile_Blue_Total;

    public Upgrade_Tile upgrade_Tile;
    public Upgrade_Tile_Blue upgrade_Tile_Blue;


    public int Total_Score_Pink;
    public int Total_Score_Blue;

    public END end;

    public RectTransform Pink_RectTransform;
    public RectTransform Blue_RectTransform;

    public void Update_Score()
    {
        //만약 wall이 ture상태라면
        if (next_turn.Wall.activeSelf == true)
        {
            StartCoroutine(Yellow0());
            StartCoroutine(Yellow0_1_Pink());
            StartCoroutine(Yellow0_1_Blue());
            StartCoroutine(Yellow0_2());

            StartCoroutine(Yellow1());
            StartCoroutine(Yellow1_Inside());

            StartCoroutine(Yellow2());
            StartCoroutine(Yellow2_Inside());

            StartCoroutine(Yellow3());
            StartCoroutine(Yellow3_Inside());

            StartCoroutine(Yellow4());
            StartCoroutine(Yellow4_Inside_Pink());
            StartCoroutine(Yellow4_Inside_Blue());

            StartCoroutine(Yellow5());//1초 뒤에 최종점수 노랑
            StartCoroutine(Yellow5_Inside_Pink());//0.5초 뒤에 점수 공개
            StartCoroutine(Yellow5_Inside_Blue());

            StartCoroutine(Yellow6());//2초 뒤에 커튼 닫기
            StartCoroutine(Yellow7());//2초 뒤에 커튼 열기 //열면서 우승자 (핑크 혹은 블루)가 보이도록

            StartCoroutine(Yellow8());//0.5초 뒤에 **누구의 승리!** 하고 ** 폭죽 ** 보여주기


            IEnumerator Yellow0()
            {
                //업그레이드 타일 계산 - 핑크, 블루

                //먼저 업그레이드 타일 노랑이 띄우고 (1초 후에)

                yield return new WaitForSeconds(1.0f);

                next_turn.Blue_Upgrate_Tile_Yellow.SetActive(true);
                next_turn.Pink_Upgrate_Tile_Yellow.SetActive(true);
            }

            IEnumerator Yellow0_1_Pink()
            {
                //괄호 있는거 띄우면서 동시에 블루와 핑크가 각각 몇 개의 업그레이드 타일을 활성화 했는지 숫자 넣기
                //(0.5초 후에 나타내기)

                yield return new WaitForSeconds(2.0f);

                next_turn.Pink_Plus_brackets_Upgrate_Tile.SetActive(true);
                next_turn.Pink_Upgrate_Tile_Four.SetActive(true);

                //1
                if(upgrade_Tile.Double_Player_Tile[2].activeSelf ==true && upgrade_Tile.Diagonal_Line_Tile[2].activeSelf ==false
                    && upgrade_Tile.Vertex_Tile[2].activeSelf ==false && upgrade_Tile.Speciality_Tile[2].activeSelf ==false)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Pink = 1;
                    next_turn.Pink_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Pink.ToString();
                }


                //2
                else if (upgrade_Tile.Double_Player_Tile[2].activeSelf == false && upgrade_Tile.Diagonal_Line_Tile[2].activeSelf == true
                    && upgrade_Tile.Vertex_Tile[2].activeSelf == false && upgrade_Tile.Speciality_Tile[2].activeSelf == false)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Pink = 1;
                    next_turn.Pink_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Pink.ToString();
                }

                //3
                else if (upgrade_Tile.Double_Player_Tile[2].activeSelf == false && upgrade_Tile.Diagonal_Line_Tile[2].activeSelf == false
                    && upgrade_Tile.Vertex_Tile[2].activeSelf == true && upgrade_Tile.Speciality_Tile[2].activeSelf == false)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Pink = 1;
                    next_turn.Pink_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Pink.ToString();
                }

                //4
                else if (upgrade_Tile.Double_Player_Tile[2].activeSelf == false && upgrade_Tile.Diagonal_Line_Tile[2].activeSelf == false
                    && upgrade_Tile.Vertex_Tile[2].activeSelf == false && upgrade_Tile.Speciality_Tile[2].activeSelf == true)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Pink = 1;
                    next_turn.Pink_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Pink.ToString();
                }

                //123
                else if (upgrade_Tile.Double_Player_Tile[2].activeSelf == true && upgrade_Tile.Diagonal_Line_Tile[2].activeSelf == true
                    && upgrade_Tile.Vertex_Tile[2].activeSelf == true && upgrade_Tile.Speciality_Tile[2].activeSelf == false)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Pink = 3;
                    next_turn.Pink_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Pink.ToString();
                }

                //124
                else if (upgrade_Tile.Double_Player_Tile[2].activeSelf == true && upgrade_Tile.Diagonal_Line_Tile[2].activeSelf == true
                    && upgrade_Tile.Vertex_Tile[2].activeSelf == false && upgrade_Tile.Speciality_Tile[2].activeSelf == true)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Pink = 3;
                    next_turn.Pink_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Pink.ToString();
                }

                //134
                else if (upgrade_Tile.Double_Player_Tile[2].activeSelf == true && upgrade_Tile.Diagonal_Line_Tile[2].activeSelf == false
                    && upgrade_Tile.Vertex_Tile[2].activeSelf == true && upgrade_Tile.Speciality_Tile[2].activeSelf == true)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Pink = 3;
                    next_turn.Pink_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Pink.ToString();
                }

                //234
                else if (upgrade_Tile.Double_Player_Tile[2].activeSelf == false && upgrade_Tile.Diagonal_Line_Tile[2].activeSelf == true
                    && upgrade_Tile.Vertex_Tile[2].activeSelf == true && upgrade_Tile.Speciality_Tile[2].activeSelf == true)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Pink = 3;
                    next_turn.Pink_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Pink.ToString();
                }

                //1234
                else if (upgrade_Tile.Double_Player_Tile[2].activeSelf == true && upgrade_Tile.Diagonal_Line_Tile[2].activeSelf == true
                    && upgrade_Tile.Vertex_Tile[2].activeSelf == true && upgrade_Tile.Speciality_Tile[2].activeSelf == true)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Pink = 4;
                    next_turn.Pink_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Pink.ToString();
                }

                //12
                else if (upgrade_Tile.Double_Player_Tile[2].activeSelf == true && upgrade_Tile.Diagonal_Line_Tile[2].activeSelf == true
                    && upgrade_Tile.Vertex_Tile[2].activeSelf == false && upgrade_Tile.Speciality_Tile[2].activeSelf == false)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Pink = 2;
                    next_turn.Pink_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Pink.ToString();
                }

                //13
                else if (upgrade_Tile.Double_Player_Tile[2].activeSelf == true && upgrade_Tile.Diagonal_Line_Tile[2].activeSelf == false
                    && upgrade_Tile.Vertex_Tile[2].activeSelf == true && upgrade_Tile.Speciality_Tile[2].activeSelf == false)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Pink = 2;
                    next_turn.Pink_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Pink.ToString();
                }


                //14
                else if (upgrade_Tile.Double_Player_Tile[2].activeSelf == true && upgrade_Tile.Diagonal_Line_Tile[2].activeSelf == false
                    && upgrade_Tile.Vertex_Tile[2].activeSelf == false && upgrade_Tile.Speciality_Tile[2].activeSelf == true)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Pink = 2;
                    next_turn.Pink_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Pink.ToString();
                }

                //23
                else if (upgrade_Tile.Double_Player_Tile[2].activeSelf == false && upgrade_Tile.Diagonal_Line_Tile[2].activeSelf == true
                    && upgrade_Tile.Vertex_Tile[2].activeSelf == true && upgrade_Tile.Speciality_Tile[2].activeSelf == false)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Pink = 2;
                    next_turn.Pink_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Pink.ToString();
                }

                //24
                else if (upgrade_Tile.Double_Player_Tile[2].activeSelf == false && upgrade_Tile.Diagonal_Line_Tile[2].activeSelf == true
                    && upgrade_Tile.Vertex_Tile[2].activeSelf == false && upgrade_Tile.Speciality_Tile[2].activeSelf == true)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Pink = 2;
                    next_turn.Pink_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Pink.ToString();
                }

                //34
                else if (upgrade_Tile.Double_Player_Tile[2].activeSelf == false && upgrade_Tile.Diagonal_Line_Tile[2].activeSelf == false
                    && upgrade_Tile.Vertex_Tile[2].activeSelf == true && upgrade_Tile.Speciality_Tile[2].activeSelf == true)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Pink = 2;
                    next_turn.Pink_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Pink.ToString();
                }

                else if (upgrade_Tile.Double_Player_Tile[2].activeSelf == false && upgrade_Tile.Diagonal_Line_Tile[2].activeSelf == false
                    && upgrade_Tile.Vertex_Tile[2].activeSelf == false && upgrade_Tile.Speciality_Tile[2].activeSelf == false)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Pink = 0;
                    next_turn.Pink_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Pink.ToString();
                }

            }

            IEnumerator Yellow0_1_Blue()
            {
                //괄호 있는거 띄우면서 동시에 블루와 핑크가 각각 몇 개의 업그레이드 타일을 활성화 했는지 숫자 넣기
                //(0.5초 후에 나타내기)

                yield return new WaitForSeconds(2.0f);

                next_turn.Blue_Plus_brackets_Upgrate_Tile.SetActive(true);
                next_turn.Blue_Upgrate_Tile_Four.SetActive(true);

                //1
                if (upgrade_Tile_Blue.Double_Player_Tile[2].activeSelf == true && upgrade_Tile_Blue.Diagonal_Line_Tile[2].activeSelf == false
                    && upgrade_Tile_Blue.Vertex_Tile[2].activeSelf == false && upgrade_Tile_Blue.Speciality_Tile[2].activeSelf == false)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Blue = 1;
                    next_turn.Blue_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Blue.ToString();
                }


                //2
                else if (upgrade_Tile_Blue.Double_Player_Tile[2].activeSelf == false && upgrade_Tile_Blue.Diagonal_Line_Tile[2].activeSelf == true
                    && upgrade_Tile_Blue.Vertex_Tile[2].activeSelf == false && upgrade_Tile_Blue.Speciality_Tile[2].activeSelf == false)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Blue = 1;
                    next_turn.Blue_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Blue.ToString();
                }

                //3
                else if (upgrade_Tile_Blue.Double_Player_Tile[2].activeSelf == false && upgrade_Tile_Blue.Diagonal_Line_Tile[2].activeSelf == false
                    && upgrade_Tile_Blue.Vertex_Tile[2].activeSelf == true && upgrade_Tile_Blue.Speciality_Tile[2].activeSelf == false)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Blue = 1;
                    next_turn.Blue_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Blue.ToString();
                }

                //4
                else if (upgrade_Tile_Blue.Double_Player_Tile[2].activeSelf == false && upgrade_Tile_Blue.Diagonal_Line_Tile[2].activeSelf == false
                    && upgrade_Tile_Blue.Vertex_Tile[2].activeSelf == false && upgrade_Tile_Blue.Speciality_Tile[2].activeSelf == true)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Blue = 1;
                    next_turn.Blue_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Blue.ToString();
                }

                //123
                else if (upgrade_Tile_Blue.Double_Player_Tile[2].activeSelf == true && upgrade_Tile_Blue.Diagonal_Line_Tile[2].activeSelf == true
                    && upgrade_Tile_Blue.Vertex_Tile[2].activeSelf == true && upgrade_Tile_Blue.Speciality_Tile[2].activeSelf == false)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Blue = 3;
                    next_turn.Blue_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Blue.ToString();
                }

                //124
                else if (upgrade_Tile_Blue.Double_Player_Tile[2].activeSelf == true && upgrade_Tile_Blue.Diagonal_Line_Tile[2].activeSelf == true
                    && upgrade_Tile_Blue.Vertex_Tile[2].activeSelf == false && upgrade_Tile_Blue.Speciality_Tile[2].activeSelf == true)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Blue = 3;
                    next_turn.Blue_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Blue.ToString();
                }

                //134
                else if (upgrade_Tile_Blue.Double_Player_Tile[2].activeSelf == true && upgrade_Tile_Blue.Diagonal_Line_Tile[2].activeSelf == false
                    && upgrade_Tile_Blue.Vertex_Tile[2].activeSelf == true && upgrade_Tile_Blue.Speciality_Tile[2].activeSelf == true)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Blue = 3;
                    next_turn.Blue_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Blue.ToString();
                }

                //234
                else if (upgrade_Tile_Blue.Double_Player_Tile[2].activeSelf == false && upgrade_Tile_Blue.Diagonal_Line_Tile[2].activeSelf == true
                    && upgrade_Tile_Blue.Vertex_Tile[2].activeSelf == true && upgrade_Tile_Blue.Speciality_Tile[2].activeSelf == true)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Blue = 3;
                    next_turn.Blue_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Blue.ToString();
                }

                //1234
                else if (upgrade_Tile_Blue.Double_Player_Tile[2].activeSelf == true && upgrade_Tile_Blue.Diagonal_Line_Tile[2].activeSelf == true
                    && upgrade_Tile_Blue.Vertex_Tile[2].activeSelf == true && upgrade_Tile_Blue.Speciality_Tile[2].activeSelf == true)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Blue = 4;
                    next_turn.Blue_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Blue.ToString();
                }

                //12
                else if (upgrade_Tile_Blue.Double_Player_Tile[2].activeSelf == true && upgrade_Tile_Blue.Diagonal_Line_Tile[2].activeSelf == true
                    && upgrade_Tile_Blue.Vertex_Tile[2].activeSelf == false && upgrade_Tile_Blue.Speciality_Tile[2].activeSelf == false)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Blue = 2;
                    next_turn.Blue_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Blue.ToString();
                }

                //13
                else if (upgrade_Tile_Blue.Double_Player_Tile[2].activeSelf == true && upgrade_Tile_Blue.Diagonal_Line_Tile[2].activeSelf == false
                    && upgrade_Tile_Blue.Vertex_Tile[2].activeSelf == true && upgrade_Tile_Blue.Speciality_Tile[2].activeSelf == false)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Blue = 2;
                    next_turn.Blue_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Blue.ToString();
                }


                //14
                else if (upgrade_Tile_Blue.Double_Player_Tile[2].activeSelf == true && upgrade_Tile_Blue.Diagonal_Line_Tile[2].activeSelf == false
                    && upgrade_Tile_Blue.Vertex_Tile[2].activeSelf == false && upgrade_Tile_Blue.Speciality_Tile[2].activeSelf == true)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Blue = 2;
                    next_turn.Blue_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Blue.ToString();
                }

                //23
                else if (upgrade_Tile_Blue.Double_Player_Tile[2].activeSelf == false && upgrade_Tile_Blue.Diagonal_Line_Tile[2].activeSelf == true
                    && upgrade_Tile_Blue.Vertex_Tile[2].activeSelf == true && upgrade_Tile_Blue.Speciality_Tile[2].activeSelf == false)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Blue = 2;
                    next_turn.Blue_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Blue.ToString();
                }

                //24
                else if (upgrade_Tile_Blue.Double_Player_Tile[2].activeSelf == false && upgrade_Tile_Blue.Diagonal_Line_Tile[2].activeSelf == true
                    && upgrade_Tile_Blue.Vertex_Tile[2].activeSelf == false && upgrade_Tile_Blue.Speciality_Tile[2].activeSelf == true)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Blue = 2;
                    next_turn.Blue_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Blue.ToString();
                }

                //34
                else if (upgrade_Tile_Blue.Double_Player_Tile[2].activeSelf == false && upgrade_Tile_Blue.Diagonal_Line_Tile[2].activeSelf == false
                    && upgrade_Tile_Blue.Vertex_Tile[2].activeSelf == true && upgrade_Tile_Blue.Speciality_Tile[2].activeSelf == true)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Blue = 2;
                    next_turn.Blue_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Blue.ToString();
                }

                else if (upgrade_Tile_Blue.Double_Player_Tile[2].activeSelf == false && upgrade_Tile_Blue.Diagonal_Line_Tile[2].activeSelf == false
                    && upgrade_Tile_Blue.Vertex_Tile[2].activeSelf == false && upgrade_Tile_Blue.Speciality_Tile[2].activeSelf == false)
                {
                    //숫자 String으로 출력
                    Upgrade_Tile_Blue = 0;
                    next_turn.Blue_Upgrate_Tile_Four_Text.text = Upgrade_Tile_Blue.ToString();
                }


            }

            IEnumerator Yellow0_2()
            {
                //핑크, 블루 업그레이드 타일

                yield return new WaitForSeconds(3.0f);

                next_turn.Pink_Plus_brackets_Upgrate_Tile.SetActive(false);
                next_turn.Pink_Upgrate_Tile_Four.SetActive(false);

                next_turn.Blue_Plus_brackets_Upgrate_Tile.SetActive(false);
                next_turn.Blue_Upgrate_Tile_Four.SetActive(false);

                //업그레이드 타일 다 계산한 거
                next_turn.Pink_Plus_Upgrate_Tile.SetActive(true);
                next_turn.Pink_Upgrate_Tile_Total.SetActive(true);

                next_turn.Blue_Plus_Upgrate_Tile.SetActive(true);
                next_turn.Blue_Upgrate_Tile_Total.SetActive(true);

                Upgrade_Tile_Pink_Total = 2;
                next_turn.Pink_Upgrate_Tile_Total_Text.text = (Upgrade_Tile_Pink_Total * Upgrade_Tile_Pink).ToString();

                Upgrade_Tile_Blue_Total = 2;
                next_turn.Blue_Upgrate_Tile_Total_Text.text = (Upgrade_Tile_Blue_Total * Upgrade_Tile_Blue).ToString();
            }

            IEnumerator Yellow1()
            {
                //주문 완료한 횟수
                yield return new WaitForSeconds(4.0f);

                next_turn.Pink_Good_Count_Yellow.SetActive(true);
                next_turn.Blue_Good_Count_Yellow.SetActive(true);


                next_turn.Blue_Upgrate_Tile_Yellow.SetActive(false);
                next_turn.Pink_Upgrate_Tile_Yellow.SetActive(false);

            }

                IEnumerator Yellow1_Inside()
            {
                //주문 완료한 횟수
                yield return new WaitForSeconds(5.0f);

                //분홍
                next_turn.Pink_Plus_Good_Count.SetActive(true);
                next_turn.Pink_Good_Count.SetActive(true);

                next_turn.Pink_Good_Count_Text.text = good_bad.Goood_Count.ToString();

                //파랑
                next_turn.Blue_Plus_Good_Count.SetActive(true);
                next_turn.Blue_Good_Count.SetActive(true);

                next_turn.Blue_Good_Count_Text.text = good_bad.Goood_Count_Blue.ToString();

            }

            IEnumerator Yellow2()
            {
                //주문 실패한 횟수
                yield return new WaitForSeconds(6.0f);

                next_turn.Pink_Bad_Count_Yellow.SetActive(true);
                next_turn.Blue_Bad_Count_Yellow.SetActive(true);

                next_turn.Pink_Good_Count_Yellow.SetActive(false);
                next_turn.Blue_Good_Count_Yellow.SetActive(false);
            }

                IEnumerator Yellow2_Inside()
            {
                //주문 실패한 횟수
                yield return new WaitForSeconds(7.0f);

                //분홍
                next_turn.Pink_Minus_Bad_Count.SetActive(true);
                next_turn.Pink_Bad_Count.SetActive(true);

                next_turn.Pink_Bad_Count_Text.text = good_bad.Bad_Ccount.ToString();

                //파랑
                next_turn.Blue_Minus_Bad_Count.SetActive(true);
                next_turn.Blue_Bad_Count.SetActive(true);

                next_turn.Blue_Bad_Count_Text.text = good_bad.Bad_Ccount_Blue.ToString();

            }


            IEnumerator Yellow3()
            {
                //갈색 네모 + 전체 점수 노랑
                yield return new WaitForSeconds(8f);

                next_turn.Blue_Brown_Line.SetActive(true);
                next_turn.Pink_Brown_Line.SetActive(true);

                next_turn.Pink_Total_Yellow.SetActive(true);
                next_turn.Blue_Total_Yellow.SetActive(true);

                next_turn.Pink_Bad_Count_Yellow.SetActive(false);
                next_turn.Blue_Bad_Count_Yellow.SetActive(false);

            }

            IEnumerator Yellow3_Inside()
            {
                //전체 점수 얼마인지 보여주기
                yield return new WaitForSeconds(9.0f);

                next_turn.Pink_Total_Small.SetActive(true);
                next_turn.Blue_Total_Small.SetActive(true);

                next_turn.Pink_Total_Small_Text.text = ((Upgrade_Tile_Pink_Total * Upgrade_Tile_Pink) + good_bad.Goood_Count - good_bad.Bad_Ccount).ToString();
                next_turn.Blue_Total_Small_Text.text = ((Upgrade_Tile_Blue_Total * Upgrade_Tile_Blue) + good_bad.Goood_Count_Blue - good_bad.Bad_Ccount_Blue).ToString();

            }

            IEnumerator Yellow4()
            {
                //코인 얼마 노랑 보여주기
                yield return new WaitForSeconds(10.0f);

                next_turn.Blue_Gold_Count_Yellow.SetActive(true);
                next_turn.Pink_Gold_Count_Yellow.SetActive(true);

                next_turn.Pink_Total_Yellow.SetActive(false);
                next_turn.Blue_Total_Yellow.SetActive(false);


            }

            IEnumerator Yellow4_Inside_Pink()
            {
                //코인 얼마인지 보여주기
                yield return new WaitForSeconds(11.0f);

                //코인이 10개 미만일 때
                if(good_bad.Ccoin_Count < 10)
                {
                    next_turn.Pink_Plus_Gold_Count_One.SetActive(true);
                    next_turn.Pink_Plus_Gold_Count_One_brackets.SetActive(true);

                    next_turn.Pink_Plus_Gold_Count_One_Text.text = good_bad.Ccoin_Count.ToString();
                }

                //코인이 10개 이상일 때
                else if (good_bad.Ccoin_Count > 9)
                {
                    next_turn.Pink_Plus_Gold_Count_Two_brackets.SetActive(true);
                    next_turn.Pink_Plus_Gold_Count_Two.SetActive(true);

                    next_turn.Pink_Plus_Gold_Count_Two_Text.text = good_bad.Ccoin_Count.ToString();
                }

            }

            IEnumerator Yellow4_Inside_Blue()
            {
                yield return new WaitForSeconds(11.0f);

                    //블루
                    //코인이 10개 미만일 때
                if (good_bad.Ccoin_Count_Blue < 10)
                {
                    next_turn.Blue_Plus_Gold_Count_One.SetActive(true);
                    next_turn.Blue_Plus_Gold_Count_One_brackets.SetActive(true);

                    next_turn.Blue_Plus_Gold_Count_One_Text.text = good_bad.Ccoin_Count_Blue.ToString();
                }

                //코인이 10개 이상일 때
                else if (good_bad.Ccoin_Count_Blue > 9)
                {
                    next_turn.Blue_Plus_Gold_Count_Two_brackets.SetActive(true);
                    next_turn.Blue_Plus_Gold_Count_Two.SetActive(true);

                    next_turn.Blue_Plus_Gold_Count_Two_Text.text = good_bad.Ccoin_Count_Blue.ToString();
                }
            }

            IEnumerator Yellow5()
            {
                //1초 뒤에 최종점수 노랑 //이제까지 나왔던 거 다 없애야 함

                yield return new WaitForSeconds(13.0f);

                next_turn.Pink_Total_Yellow.SetActive(true);
                next_turn.Blue_Total_Yellow.SetActive(true);

                //뭘 지워야 하나
                next_turn.Blue_Plus_Upgrate_Tile.SetActive(false);
                next_turn.Blue_Upgrate_Tile_Total.SetActive(false);
                next_turn.Blue_Plus_brackets_Upgrate_Tile.SetActive(false);
                next_turn.Blue_Upgrate_Tile_Four.SetActive(false);
                next_turn.Blue_Plus_Good_Count.SetActive(false);
                next_turn.Blue_Good_Count.SetActive(false);
                next_turn.Blue_Minus_Bad_Count.SetActive(false);
                next_turn.Blue_Bad_Count.SetActive(false);
                next_turn.Blue_Plus_Gold_Count_One_brackets.SetActive(false);
                next_turn.Blue_Plus_Gold_Count_One.SetActive(false);
                next_turn.Blue_Plus_Gold_Count_Two_brackets.SetActive(false);
                next_turn.Blue_Plus_Gold_Count_Two.SetActive(false);
                next_turn.Blue_Brown_Line.SetActive(false);
                next_turn.Blue_Total_Small.SetActive(false);
                next_turn.Blue_Upgrate_Tile_Yellow.SetActive(false);
                next_turn.Blue_Good_Count_Yellow.SetActive(false);
                next_turn.Blue_Bad_Count_Yellow.SetActive(false);
                next_turn.Blue_Gold_Count_Yellow.SetActive(false);

                //19개 2번째
                next_turn.Pink_Plus_Upgrate_Tile.SetActive(false);
                next_turn.Pink_Upgrate_Tile_Total.SetActive(false);
                next_turn.Pink_Plus_brackets_Upgrate_Tile.SetActive(false);
                next_turn.Pink_Upgrate_Tile_Four.SetActive(false);
                next_turn.Pink_Plus_Good_Count.SetActive(false);
                next_turn.Pink_Good_Count.SetActive(false);
                next_turn.Pink_Minus_Bad_Count.SetActive(false);
                next_turn.Pink_Bad_Count.SetActive(false);
                next_turn.Pink_Plus_Gold_Count_One_brackets.SetActive(false);
                next_turn.Pink_Plus_Gold_Count_One.SetActive(false);
                next_turn.Pink_Plus_Gold_Count_Two_brackets.SetActive(false);
                next_turn.Pink_Plus_Gold_Count_Two.SetActive(false);
                next_turn.Pink_Brown_Line.SetActive(false);
                next_turn.Pink_Total_Small.SetActive(false);
                next_turn.Pink_Upgrate_Tile_Yellow.SetActive(false);
                next_turn.Pink_Good_Count_Yellow.SetActive(false);
                next_turn.Pink_Bad_Count_Yellow.SetActive(false);
                next_turn.Pink_Gold_Count_Yellow.SetActive(false);

            }

            IEnumerator Yellow5_Inside_Pink()
            {
                //0.5초 뒤에 점수 공개-핑크
                yield return new WaitForSeconds(14.0f);

                if((Upgrade_Tile_Pink_Total * Upgrade_Tile_Pink) + good_bad.Goood_Count - good_bad.Bad_Ccount > 9)
                {
                    //두 자릿 수
                    Pink_RectTransform.anchoredPosition = new Vector2(532.8f, 26.73f);
                    next_turn.Pink_Total_Big.SetActive(true);
                    next_turn.Pink_Total_Big_Text.text = ((Upgrade_Tile_Pink_Total * Upgrade_Tile_Pink) + good_bad.Goood_Count - good_bad.Bad_Ccount).ToString();

                    //골드
                    if (good_bad.Ccoin_Count < 10)
                    {
                        next_turn.Pink_Score_Coin_brackets_One.SetActive(true);
                        next_turn.Pink_Score_Coin_One.SetActive(true);

                        next_turn.Pink_Score_Coin_One_Text.text = good_bad.Ccoin_Count.ToString();
                    }

                    //코인이 10개 이상일 때
                    else if (good_bad.Ccoin_Count > 9)
                    {
                        next_turn.Pink_Score_Coin_brackets_Two.SetActive(true);
                        next_turn.Pink_Score_Coin_Two.SetActive(true);

                        next_turn.Pink_Score_Coin_Two_Text.text = good_bad.Ccoin_Count.ToString();
                    }

                }

                else if ((Upgrade_Tile_Pink_Total * Upgrade_Tile_Pink) + good_bad.Goood_Count - good_bad.Bad_Ccount < 10)
                {
                    //한 자릿 수
                    Pink_RectTransform.anchoredPosition = new Vector2(511.8f, 26.73f);
                    next_turn.Pink_Total_Big.SetActive(true);
                    next_turn.Pink_Total_Big_Text.text = ((Upgrade_Tile_Pink_Total * Upgrade_Tile_Pink) + good_bad.Goood_Count - good_bad.Bad_Ccount).ToString();

                    //골드
                    if (good_bad.Ccoin_Count < 10)
                    {
                        next_turn.Pink_Score_Coin_brackets_One.SetActive(true);
                        next_turn.Pink_Score_Coin_One.SetActive(true);

                        next_turn.Pink_Score_Coin_One_Text.text = good_bad.Ccoin_Count.ToString();
                    }

                    //코인이 10개 이상일 때
                    else if (good_bad.Ccoin_Count > 9)
                    {
                        next_turn.Pink_Score_Coin_brackets_Two.SetActive(true);
                        next_turn.Pink_Score_Coin_Two.SetActive(true);

                        next_turn.Pink_Score_Coin_Two_Text.text = good_bad.Ccoin_Count.ToString();
                    }

                }

                /*next_turn.Pink_Total_Big.SetActive(true);
                next_turn.Pink_Total_Big_Text.text = ((Upgrade_Tile_Pink_Total * Upgrade_Tile_Pink) + good_bad.Goood_Count - good_bad.Bad_Ccount).ToString();
                */

                //골드
               /* if (good_bad.Ccoin_Count < 10)
                {
                    next_turn.Pink_Score_Coin_brackets_One.SetActive(true);
                    next_turn.Pink_Score_Coin_One.SetActive(true);

                    next_turn.Pink_Score_Coin_One_Text.text = good_bad.Ccoin_Count.ToString();
                }

                //코인이 10개 이상일 때
                else if (good_bad.Ccoin_Count > 9)
                {
                    next_turn.Pink_Score_Coin_brackets_Two.SetActive(true);
                    next_turn.Pink_Score_Coin_Two.SetActive(true);

                    next_turn.Pink_Score_Coin_Two_Text.text = good_bad.Ccoin_Count.ToString();
                }*/

            }

            IEnumerator Yellow5_Inside_Blue()
            {
                //0.5초 뒤에 점수 공개-블루
                yield return new WaitForSeconds(14.0f);


                if((Upgrade_Tile_Blue_Total * Upgrade_Tile_Blue) + good_bad.Goood_Count_Blue - good_bad.Bad_Ccount_Blue > 9)
                {
                    //두 자릿 수
                    Blue_RectTransform.anchoredPosition = new Vector2(-131.3f, 26.72f);
                    next_turn.Blue_Total_Big.SetActive(true);

                    next_turn.Blue_Total_Big_Text.text = ((Upgrade_Tile_Blue_Total * Upgrade_Tile_Blue) + good_bad.Goood_Count_Blue - good_bad.Bad_Ccount_Blue).ToString();

                    //골드
                    if (good_bad.Ccoin_Count_Blue < 10)
                    {
                        next_turn.Blue_Score_Coin_brackets_One.SetActive(true);
                        next_turn.Blue_Score_Coin_One.SetActive(true);

                        next_turn.Blue_Score_Coin_One_Text.text = good_bad.Ccoin_Count_Blue.ToString();
                    }

                    //코인이 10개 이상일 때
                    else if (good_bad.Ccoin_Count_Blue > 9)
                    {
                        next_turn.Blue_Score_Coin_brackets_Two.SetActive(true);
                        next_turn.Blue_Score_Coin_Two.SetActive(true);

                        next_turn.Blue_Score_Coin_Two_Text.text = good_bad.Ccoin_Count_Blue.ToString();
                    }
                }

                else if ((Upgrade_Tile_Blue_Total * Upgrade_Tile_Blue) + good_bad.Goood_Count_Blue - good_bad.Bad_Ccount_Blue < 10)
                {
                    //한 자릿 수
                    Blue_RectTransform.anchoredPosition = new Vector2(-151.6f, 26.72f);
                    next_turn.Blue_Total_Big.SetActive(true);

                    next_turn.Blue_Total_Big_Text.text = ((Upgrade_Tile_Blue_Total * Upgrade_Tile_Blue) + good_bad.Goood_Count_Blue - good_bad.Bad_Ccount_Blue).ToString();

                    //골드
                    if (good_bad.Ccoin_Count_Blue < 10)
                    {
                        next_turn.Blue_Score_Coin_brackets_One.SetActive(true);
                        next_turn.Blue_Score_Coin_One.SetActive(true);

                        next_turn.Blue_Score_Coin_One_Text.text = good_bad.Ccoin_Count_Blue.ToString();
                    }

                    //코인이 10개 이상일 때
                    else if (good_bad.Ccoin_Count_Blue > 9)
                    {
                        next_turn.Blue_Score_Coin_brackets_Two.SetActive(true);
                        next_turn.Blue_Score_Coin_Two.SetActive(true);

                        next_turn.Blue_Score_Coin_Two_Text.text = good_bad.Ccoin_Count_Blue.ToString();
                    }
                }

                //골드
               /* if (good_bad.Ccoin_Count_Blue < 10)
                {
                    next_turn.Blue_Score_Coin_brackets_One.SetActive(true);
                    next_turn.Blue_Score_Coin_One.SetActive(true);

                    next_turn.Blue_Score_Coin_One_Text.text = good_bad.Ccoin_Count_Blue.ToString();
                }

                //코인이 10개 이상일 때
                else if (good_bad.Ccoin_Count_Blue > 9)
                {
                    next_turn.Blue_Score_Coin_brackets_Two.SetActive(true);
                    next_turn.Blue_Score_Coin_Two.SetActive(true);

                    next_turn.Blue_Score_Coin_Two_Text.text = good_bad.Ccoin_Count_Blue.ToString();
                }*/

            }

            IEnumerator Yellow6()
            {
                //2초 뒤에 커튼 닫기
                yield return new WaitForSeconds(16.0f);

                next_turn.Close_Curtain_Left.SetActive(true);
                next_turn.Close_Curtain_Right.SetActive(true);

            }

            IEnumerator Yellow7()
            {
                //2초 뒤에 커튼 열기 
                //커튼 제외 이제까지 나왔던 거 다 없애야 함
                //열면서 우승자 (핑크 혹은 블루)가 보이도록
                yield return new WaitForSeconds(18.0f);

                next_turn.Pink_Total_Big.SetActive(false);
                next_turn.Blue_Total_Big.SetActive(false);

                next_turn.Pink_Total_Yellow.SetActive(false);
                next_turn.Blue_Total_Yellow.SetActive(false);

                next_turn.Blue_Score_Coin_brackets_One.SetActive(false);
                next_turn.Blue_Score_Coin_One.SetActive(false);

                next_turn.Blue_Score_Coin_brackets_Two.SetActive(false);
                next_turn.Blue_Score_Coin_Two.SetActive(false);

                next_turn.Pink_Score_Coin_brackets_Two.SetActive(false);
                next_turn.Pink_Score_Coin_Two.SetActive(false);

                next_turn.Pink_Score_Coin_brackets_One.SetActive(false);
                next_turn.Pink_Score_Coin_One.SetActive(false);

                next_turn.Close_Curtain_Left.SetActive(false);
                next_turn.Close_Curtain_Right.SetActive(false);

                next_turn.Open_Curtain_Left.SetActive(false);
                next_turn.Open_Curtain_Right.SetActive(false);

                next_turn.Final_Curtain_Open_0.SetActive(true);
                next_turn.Final_Curtain_Open_1.SetActive(true);


                //파랑 관련된 거 - 거짓
                next_turn.About_Blue.SetActive(false);

                //핑크 관련된 거 - 거짓
                next_turn.About_Pink.SetActive(false);

                //핑크
                Total_Score_Pink = (Upgrade_Tile_Pink_Total * Upgrade_Tile_Pink) + good_bad.Goood_Count - good_bad.Bad_Ccount;


                //블루
                Total_Score_Blue = (Upgrade_Tile_Blue_Total * Upgrade_Tile_Blue) + good_bad.Goood_Count_Blue - good_bad.Bad_Ccount_Blue;

                //우승자 가리는 거 - 점수 비교

                if(Total_Score_Pink > Total_Score_Blue)
                {
                    //핑크 승
                    next_turn.Pink_Win.SetActive(true);
                }

                else if (Total_Score_Pink < Total_Score_Blue)
                {
                    //블루 승
                    next_turn.Blue_Win.SetActive(true);
                }

                else if (Total_Score_Pink == Total_Score_Blue)
                {
                    //코인 수로 비교

                    if(good_bad.Ccoin_Count > good_bad.Ccoin_Count_Blue)
                    {
                        //핑크가 더 골드가 많은 경우
                        next_turn.Pink_Win.SetActive(true);
                    }

                    else if (good_bad.Ccoin_Count < good_bad.Ccoin_Count_Blue)
                    {
                        //블루가 더 골드가 많은 경우
                        next_turn.Blue_Win.SetActive(true);
                    }

                    else if (good_bad.Ccoin_Count == good_bad.Ccoin_Count_Blue)
                    {
                        next_turn.Draw.SetActive(true);
                        //골드 수가 같은 경우
                    }
                }

                //글씨는 아직


            }

            IEnumerator Yellow8()
            {
                //0.5초 뒤에 **누구의 승리!** 하고 ** 폭죽 ** 보여주기
                yield return new WaitForSeconds(19.0f);

                if(next_turn.Pink_Win.activeSelf ==true)
                {
                    next_turn.Text_Pink_Team_Win.SetActive(true);
                    next_turn.Text_Game_Result.SetActive(false);


                    end.StartParticles();

                }

                else if(next_turn.Blue_Win.activeSelf ==true)
                { 
                    next_turn.Text_Blue_Team_Win.SetActive(true);
                    next_turn.Text_Game_Result.SetActive(false);

                    end.StartParticles();

                }

                else if(next_turn.Draw.activeSelf ==true)
                { 
                    next_turn.Text_Darw.SetActive(true);
                    next_turn.Text_Game_Result.SetActive(false);

                    end.StopParticles();
                }

            }

        }
    }

    

}
