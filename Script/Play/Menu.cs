using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Menu : MonoBehaviour
{

    public CameraZoom zoom;

    public Total_Audio total;

    public GameObject Next_Pink_Player;//턴 끝내기
    public GameObject Next_Blue_Player;//턴 끝내기

    public GameObject Blue;
    public GameObject Pink;

    public Next_Turn next_turn;

    public Move_Player move_player;

    public GameObject Start_Player;
    public GameObject Color_Select;

    public Upgrade_Tile upgrade_tile;
    public Upgrade_Tile_Blue upgrade_tile_blue;

    public Player_Move_Count move_count;

    public Card_Move card_move;

    public Turn_Count turn_count;

    public GameObject Ddabong_Pink_1;
    public GameObject Ddabong_Pink_2;

    public GameObject Ddabong_Blue_1;
    public GameObject Ddabong_Blue_2;

    public GameObject Coin_Pink1;

    public GameObject Coin_Blue1;

    public GameObject Pink_Cup_White1;
    public GameObject Pink_Cup_White2;
    public GameObject Pink_Cup_White3;

    public GameObject Pink_Cup_Pink1;
    public GameObject Pink_Cup_Pink2;
    public GameObject Pink_Cup_Pink3;

    public GameObject Blue_Cup_White1;
    public GameObject Blue_Cup_White2;
    public GameObject Blue_Cup_White3;

    public GameObject Blue_Cup_Blue1;
    public GameObject Blue_Cup_Blue2;
    public GameObject Blue_Cup_Blue3;


    public GameObject Pink_Cup_Inside_1;
    public GameObject Pink_Cup_Inside_2;
    public GameObject Pink_Cup_Inside_3;

    public GameObject Blue_Cup_Inside_1;
    public GameObject Blue_Cup_Inside_2;
    public GameObject Blue_Cup_Inside_3;

    public GameObject Blue_Material;
    public GameObject Pink_Material;

    public Move_Material move_material;

    public GameObject Setting;

    public SFX_2023 sfx;
    public BGM_2023 bgm;

    public SFX_2023 sfx1;
    public BGM_2023 bgm1;

    public Good_Bad G_B;

    public Cup cup;

    public Cup_Menu cup_menu;

    public GameObject blue_Open;
    public GameObject blue_Close;

    public GameObject pink_Open;
    public GameObject pink_Close;

    public END end;

    public Main main;

    public Blue_Pink blue_pink;

    public GameObject Cradit;
    public RectTransform Cradit_board;
    public GameObject Out_Cradit;


    public void Go_Cradit()
    {
        Cradit.SetActive(true);
        Out_Cradit.SetActive(true);

        Cradit_board.offsetMin = new Vector2(0, -2102.47f); ;//왼쪽, 바텀
        Cradit_board.offsetMax = new Vector2(0, 0.0001220703f); ;//오른쪽, 위
    }

    public void Get_Out_Credit()
    {
        Cradit.SetActive(false);
        Out_Cradit.SetActive(false);

        Cradit_board.offsetMin = new Vector2(0, -2102.47f); ;//왼쪽, 바텀
        Cradit_board.offsetMax = new Vector2(0, 0.0001220703f); ;//오른쪽, 위
    }


    public void Continue_Game()
    {
        total.menuSet.SetActive(false);
    }



    //점수 나오고 나서 나오는 게임 재시작  버튼
    //게임 다시 시작하기
    //소리 크기는 그대로


    public void Game_Restart()
    {
        StartCoroutine(WaitSecond_0());
        StartCoroutine(WaitSecond_1());

        StartCoroutine(WaitSecond_2());

        IEnumerator WaitSecond_0()
        {
            yield return new WaitForSeconds(0.0f);
            main.Go_Black.SetActive(true);//없음->검정
            sfx.SFX_Button();//버튼 소리


            end.StopParticles();
        }

        IEnumerator WaitSecond_1()
        {
            yield return new WaitForSeconds(1.0f);

            //PC에서는 실행되는 코드입니다
            //확대, 축소 코드
            /*zoom.isZoomedIn = false;//줌인 상태가 아님
            zoom.zoomCount = 0; //짝수번째
            zoom.ZoomOut();//줌 아웃
            */
            zoom.ResetToOriginalSize();

            //재료칸에 있는 재료 없애기
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

            //블루
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

            move_player.isSelected = false;

            move_player.selectionIndicators[0].SetActive(false);
            move_player.selectionIndicators[1].SetActive(false);
            move_player.selectionIndicators[2].SetActive(false);
            move_player.selectionIndicators[3].SetActive(false);

            //여기부터 버튼 눌리는 거
            //얼음1 의 버튼이 눌리지 않게 하는 것
            Button button_0 = move_player.SixTeen_Plate_Button[0].GetComponent<Button>();
            button_0.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_0_1 = move_player.inside_SixTeen_Plate_Button[0].GetComponent<Button>();
            button_0_1.interactable = true;

            //카라멜1 의 버튼이 눌리지 않게 하는 것
            Button button_1 = move_player.SixTeen_Plate_Button[1].GetComponent<Button>();
            button_1.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_1_1 = move_player.inside_SixTeen_Plate_Button[1].GetComponent<Button>();
            button_1_1.interactable = true;

            //증기1 의 버튼이 눌리지 않게 하는 것
            Button button_2 = move_player.SixTeen_Plate_Button[2].GetComponent<Button>();
            button_2.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_2_1 = move_player.inside_SixTeen_Plate_Button[2].GetComponent<Button>();
            button_2_1.interactable = true;

            //커피1 의 버튼이 눌리지 않게 하는 것
            Button button_3 = move_player.SixTeen_Plate_Button[3].GetComponent<Button>();
            button_3.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_3_1 = move_player.inside_SixTeen_Plate_Button[3].GetComponent<Button>();
            button_3_1.interactable = true;

            //커피2의 버튼이 눌리지 않게 하는 것
            Button button_4 = move_player.SixTeen_Plate_Button[4].GetComponent<Button>();
            button_4.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_4_1 = move_player.inside_SixTeen_Plate_Button[4].GetComponent<Button>();
            button_4_1.interactable = true;

            //우유1 의 버튼이 눌리지 않게 하는 것
            Button button_5 = move_player.SixTeen_Plate_Button[5].GetComponent<Button>();
            button_5.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_5_1 = move_player.inside_SixTeen_Plate_Button[5].GetComponent<Button>();
            button_5_1.interactable = true;

            //얼음2 의 버튼이 눌리지 않게 하는 것
            Button button_6 = move_player.SixTeen_Plate_Button[6].GetComponent<Button>();
            button_6.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_6_1 = move_player.inside_SixTeen_Plate_Button[6].GetComponent<Button>();
            button_6_1.interactable = true;

            //물1 의 버튼이 눌리지 않게 하는 것
            Button button_7 = move_player.SixTeen_Plate_Button[7].GetComponent<Button>();
            button_7.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_7_1 = move_player.inside_SixTeen_Plate_Button[7].GetComponent<Button>();
            button_7_1.interactable = true;

            //녹차1의 버튼이 눌리지 않게 하는 것
            Button button_8 = move_player.SixTeen_Plate_Button[8].GetComponent<Button>();
            button_8.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_8_1 = move_player.inside_SixTeen_Plate_Button[8].GetComponent<Button>();
            button_8_1.interactable = true;

            //증기2의 버튼이 눌리지 않게 하는 것
            Button button_9 = move_player.SixTeen_Plate_Button[9].GetComponent<Button>();
            button_9.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_9_1 = move_player.inside_SixTeen_Plate_Button[9].GetComponent<Button>();
            button_9_1.interactable = true;

            //우유2의 버튼이 눌리지 않게 하는 것
            Button button_10 = move_player.SixTeen_Plate_Button[10].GetComponent<Button>();
            button_10.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_10_1 = move_player.inside_SixTeen_Plate_Button[10].GetComponent<Button>();
            button_10_1.interactable = true;

            //커피3의 버튼이 눌리지 않게 하는 것
            Button button_11 = move_player.SixTeen_Plate_Button[11].GetComponent<Button>();
            button_11.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_11_1 = move_player.inside_SixTeen_Plate_Button[11].GetComponent<Button>();
            button_11_1.interactable = true;

            //우유3의 버튼이 눌리지 않게 하는 것
            Button button_12 = move_player.SixTeen_Plate_Button[12].GetComponent<Button>();
            button_12.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_12_1 = move_player.inside_SixTeen_Plate_Button[12].GetComponent<Button>();
            button_12_1.interactable = true;

            //얼음3의 버튼이 눌리지 않게 하는 것
            Button button_13 = move_player.SixTeen_Plate_Button[13].GetComponent<Button>();
            button_13.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_13_1 = move_player.inside_SixTeen_Plate_Button[13].GetComponent<Button>();
            button_13_1.interactable = true;

            //초코1의 버튼이 눌리지 않게 하는 것
            Button button_14 = move_player.SixTeen_Plate_Button[14].GetComponent<Button>();
            button_14.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_14_1 = move_player.inside_SixTeen_Plate_Button[14].GetComponent<Button>();
            button_14_1.interactable = true;


            //증기3의 버튼이 눌리지 않게 하는 것
            Button button_15 = move_player.SixTeen_Plate_Button[15].GetComponent<Button>();
            button_15.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_15_1 = move_player.inside_SixTeen_Plate_Button[15].GetComponent<Button>();
            button_15_1.interactable = true;

            //얼음
            ColorBlock colors_0 = move_player.SixTeen_Plate_Button[0].colors;
            colors_0.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[0].colors = colors_0;

            //카라멜
            ColorBlock colors_1 = move_player.SixTeen_Plate_Button[1].colors;
            colors_1.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[1].colors = colors_1;

            //증기1
            ColorBlock colors_2 = move_player.SixTeen_Plate_Button[2].colors;
            colors_2.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[2].colors = colors_2;

            //커피1
            ColorBlock colors_3 = move_player.SixTeen_Plate_Button[3].colors;
            colors_3.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[3].colors = colors_3;

            //커피2
            ColorBlock colors_4 = move_player.SixTeen_Plate_Button[4].colors;
            colors_4.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[4].colors = colors_4;

            //우유1
            ColorBlock colors_5 = move_player.SixTeen_Plate_Button[5].colors;
            colors_5.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[5].colors = colors_5;

            //얼음2
            ColorBlock colors_6 = move_player.SixTeen_Plate_Button[6].colors;
            colors_6.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[6].colors = colors_6;

            //물1
            ColorBlock colors_7 = move_player.SixTeen_Plate_Button[7].colors;
            colors_7.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[7].colors = colors_7;

            //녹차1
            ColorBlock colors_8 = move_player.SixTeen_Plate_Button[8].colors;
            colors_8.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[8].colors = colors_8;

            //증기2
            ColorBlock colors_9 = move_player.SixTeen_Plate_Button[9].colors;
            colors_9.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[9].colors = colors_9;

            //우유2
            ColorBlock colors_10 = move_player.SixTeen_Plate_Button[10].colors;
            colors_10.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[10].colors = colors_10;

            //커피3
            ColorBlock colors_11 = move_player.SixTeen_Plate_Button[11].colors;
            colors_11.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[11].colors = colors_11;

            //우유3
            ColorBlock colors_12 = move_player.SixTeen_Plate_Button[12].colors;
            colors_12.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[12].colors = colors_12;

            //얼음3
            ColorBlock colors_13 = move_player.SixTeen_Plate_Button[13].colors;
            colors_13.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[13].colors = colors_13;

            //초코1
            ColorBlock colors_14 = move_player.SixTeen_Plate_Button[14].colors;
            colors_14.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[14].colors = colors_14;

            //증기3
            ColorBlock colors_15 = move_player.SixTeen_Plate_Button[15].colors;
            colors_15.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[15].colors = colors_15;





            main.Go_Black.SetActive(false);
            main.Go_Empty.SetActive(true);

            Start_Player.SetActive(true);
            Color_Select.SetActive(true);

            blue_pink.Go_Black.SetActive(false);
            blue_pink.Go_Empty.SetActive(false);
            //main.Go_Black.SetActive(false);
            //main.Go_Empty.SetActive(false);
            main.main.SetActive(false);


            next_turn.Final_Curtain_Open_0.SetActive(false);
            next_turn.Final_Curtain_Open_1.SetActive(false);

            next_turn.Stay_Curtain_Left.SetActive(false);
            next_turn.Stay_Curtain_Right.SetActive(false);

            next_turn.Open_Curtain_Left.SetActive(false);
            next_turn.Open_Curtain_Right.SetActive(false);

            next_turn.Close_Curtain_Left.SetActive(false);
            next_turn.Close_Curtain_Right.SetActive(false);

            next_turn.Text_Game_Result.SetActive(false);
            next_turn.Text_Pink_Team_Win.SetActive(false);
            next_turn.Text_Blue_Team_Win.SetActive(false);
            next_turn.Text_Darw.SetActive(false);

            next_turn.Score.SetActive(false);

            next_turn.About_Blue.SetActive(false);
            next_turn.About_Pink.SetActive(false);

            next_turn.Wall.SetActive(false);

            //여기부터 19개
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
            next_turn.Blue_Total_Big.SetActive(false);
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
            next_turn.Pink_Total_Big.SetActive(false);
            next_turn.Pink_Upgrate_Tile_Yellow.SetActive(false);
            next_turn.Pink_Good_Count_Yellow.SetActive(false);
            next_turn.Pink_Bad_Count_Yellow.SetActive(false);
            next_turn.Pink_Gold_Count_Yellow.SetActive(false);

            next_turn.Blue_Total_Yellow.SetActive(false);
            next_turn.Pink_Total_Yellow.SetActive(false);

            //핑크가 이겼을 때
            next_turn.Pink_Win.SetActive(false);

            //블루가 이겼을 때
            next_turn.Blue_Win.SetActive(false);

            //무승부
            next_turn.Draw.SetActive(false);

            blue_Open.SetActive(false);
            blue_Close.SetActive(false);

            pink_Open.SetActive(false);
            pink_Close.SetActive(false);

            total.menuSet.SetActive(false);

            // 최종 점수 옆에 있는 코인
            next_turn.Pink_Score_Coin_brackets_Two.SetActive(false);
            next_turn.Pink_Score_Coin_Two.SetActive(false);

            next_turn.Pink_Score_Coin_brackets_One.SetActive(false);
            next_turn.Pink_Score_Coin_One.SetActive(false);

            next_turn.Blue_Score_Coin_brackets_Two.SetActive(false);
            next_turn.Blue_Score_Coin_Two.SetActive(false);

            next_turn.Blue_Score_Coin_brackets_One.SetActive(false);
            next_turn.Blue_Score_Coin_One.SetActive(false);

            //주문완료
            cup_menu.Coffee[0].SetActive(false);
            cup_menu.Coffee[1].SetActive(false);
            cup_menu.Coffee[2].SetActive(false);
            cup_menu.Coffee[3].SetActive(false);
            cup_menu.Coffee[4].SetActive(false);
            cup_menu.Coffee[5].SetActive(false);
            cup_menu.Coffee[6].SetActive(false);
            cup_menu.Coffee[7].SetActive(false);
            cup_menu.Coffee[8].SetActive(false);
            cup_menu.Coffee[9].SetActive(false);
            cup_menu.Coffee[10].SetActive(false);
            cup_menu.Coffee[11].SetActive(false);
            cup_menu.Coffee[12].SetActive(false);
            cup_menu.Coffee[13].SetActive(false);
            cup_menu.Coffee[14].SetActive(false);
            cup_menu.Coffee[15].SetActive(false);
            cup_menu.Coffee[16].SetActive(false);
            cup_menu.Coffee[17].SetActive(false);
            cup_menu.Coffee[18].SetActive(false);
            cup_menu.Coffee[19].SetActive(false);
            cup_menu.Coffee[20].SetActive(false);
            cup_menu.Coffee[21].SetActive(false);
            cup_menu.Coffee[22].SetActive(false);
            cup_menu.Coffee[23].SetActive(false);
            cup_menu.Coffee[24].SetActive(false);
            cup_menu.Coffee[25].SetActive(false);
            cup_menu.Coffee[26].SetActive(false);
            cup_menu.Coffee[27].SetActive(false);
            cup_menu.Coffee[28].SetActive(false);
            cup_menu.Coffee[29].SetActive(false);
            cup_menu.Coffee[30].SetActive(false);
            cup_menu.Coffee[31].SetActive(false);
            cup_menu.Coffee[32].SetActive(false);

            //분홍에 대한 스크립트
            upgrade_tile.Double_Player_Tile_Upgrade.SetActive(false);
            upgrade_tile.Double_Player_Tile_Upgrade_Inside.SetActive(false);
            upgrade_tile.Double_Player_Tile_Upgrade_Will_No.SetActive(true);
            upgrade_tile.Double_Player_Tile_Upgrade_Will_No_Inside.SetActive(false);

            upgrade_tile.Diagonal_Line_Tile_Upgrade.SetActive(false);
            upgrade_tile.Diagonal_Line_Tile_Upgrade_Inside.SetActive(false);

            upgrade_tile.Diagonal_Line_Tile_Upgrade_Will_No.SetActive(true);
            upgrade_tile.Diagonal_Line_Tile_Upgrade_Will_No_Inside.SetActive(false);

            upgrade_tile.Vertex_Tile_Upgrade.SetActive(false);//꼭짓점에 있을 때 2배 타일 업데이트
            upgrade_tile.Vertex_Tile_Upgrade_Inside.SetActive(false);

            upgrade_tile.Vertex_Tile_Upgrade_Will_No.SetActive(true);
            upgrade_tile.Vertex_Tile_Upgrade_Will_No_Inside.SetActive(false);

            //여기는 스페셜티 2배
            upgrade_tile.Speciality_Tile_Upgrade.SetActive(false);//스페셜티에 있을 때 2배 타일 업데이트
            upgrade_tile.Speciality_Tile_Upgrade_Inside.SetActive(false);

            upgrade_tile.Speciality_Tile_Upgrade_Will_No.SetActive(true);
            upgrade_tile.Speciality_Tile_Upgrade_Will_No_Inside.SetActive(false);

            upgrade_tile.Will_Use_Coin.SetActive(false);
            upgrade_tile.Will_Use_Coin_Inside.SetActive(false);

            upgrade_tile.Will_Use_Coin_No_Coin.SetActive(true);
            upgrade_tile.Will_Use_Coin_No_Coin_Inside.SetActive(false);
            upgrade_tile.No_Coin.SetActive(false);
            upgrade_tile.Use_Coin.SetActive(false);

            upgrade_tile.Already_Player_Coin_Zero.SetActive(true);
            upgrade_tile.Already_Player_Coin_Zero_Inside.SetActive(false);
            upgrade_tile.Already_Player_Coin_Not_Zero.SetActive(false);
            upgrade_tile.Already_Player_Coin_Not_Zero_Inside.SetActive(false);
            upgrade_tile.No_Good.SetActive(false);
            upgrade_tile.Next_Turn_No_Double_Player.SetActive(false);

            //파랑에 대한 스크립트
            upgrade_tile_blue.Double_Player_Tile_Upgrade.SetActive(false);
            upgrade_tile_blue.Double_Player_Tile_Upgrade_Inside.SetActive(false);

            //게임말 2배 충족 안됨
            upgrade_tile_blue.Double_Player_Tile_Upgrade_Will_No.SetActive(true);
            upgrade_tile_blue.Double_Player_Tile_Upgrade_Will_No_Inside.SetActive(false);

            upgrade_tile_blue.Diagonal_Line_Tile_Upgrade.SetActive(false);
            upgrade_tile_blue.Diagonal_Line_Tile_Upgrade_Inside.SetActive(false);

            //대각선 충족 안됨
            upgrade_tile_blue.Diagonal_Line_Tile_Upgrade_Will_No.SetActive(true);
            upgrade_tile_blue.Diagonal_Line_Tile_Upgrade_Will_No_Inside.SetActive(false);

            upgrade_tile_blue.Vertex_Tile_Upgrade.SetActive(false);//꼭짓점에 있을 때 2배 타일 업데이트
            upgrade_tile_blue.Vertex_Tile_Upgrade_Inside.SetActive(false);

            //꼭짓점 2배 충족 안됨
            upgrade_tile_blue.Vertex_Tile_Upgrade_Will_No.SetActive(true);
            upgrade_tile_blue.Vertex_Tile_Upgrade_Will_No_Inside.SetActive(false);

            //여기는 스페셜티 2배
            upgrade_tile_blue.Speciality_Tile_Upgrade.SetActive(false);//스페셜티에 있을 때 2배 타일 업데이트
            upgrade_tile_blue.Speciality_Tile_Upgrade_Inside.SetActive(false);

            //충족 안됨
            upgrade_tile_blue.Speciality_Tile_Upgrade_Will_No.SetActive(true);
            upgrade_tile_blue.Speciality_Tile_Upgrade_Will_No_Inside.SetActive(false);

            upgrade_tile_blue.Will_Use_Coin.SetActive(false);
            upgrade_tile_blue.Will_Use_Coin_Inside.SetActive(false);

            upgrade_tile_blue.Will_Use_Coin_No_Coin.SetActive(true);
            upgrade_tile_blue.Will_Use_Coin_No_Coin_Inside.SetActive(false);

            upgrade_tile_blue.No_Coin.SetActive(false);
            upgrade_tile_blue.Use_Coin.SetActive(false);

            upgrade_tile_blue.Already_Player_Coin_Zero.SetActive(true);

            upgrade_tile_blue.Already_Player_Coin_Zero_Inside.SetActive(false);
            upgrade_tile_blue.Already_Player_Coin_Not_Zero.SetActive(false);
            upgrade_tile_blue.Already_Player_Coin_Not_Zero_Inside.SetActive(false);
            upgrade_tile_blue.No_Good.SetActive(false);
            upgrade_tile_blue.Next_Turn_No_Double_Player.SetActive(false);

            //커피 잔 안에 있는 내용물 전부 삭제 & rigid와 콜라이더 초기화
            //rigid는 그대로 두고(중력1)
            //콜라이더도 활성화 된 상태로 두기

            //핑크 1 버림 코드 갖다 씀
            cup.Trash_Cup_Pink_One1();

            //핑크2 버림 코드 갖다 씀
            cup.Trash_Cup_Pink_Two1();

            //핑크3 버림 코드 갖다 씀
            cup.Trash_Cup_Pink_Three1();

            //블루 1 버림 코드 갖다 씀
            cup.Trash_Cup_Blue_One1();

            //블루2 버림 코드 갖다 씀
            cup.Trash_Cup_Blue_Two1();

            //블루3 버림 코드 갖다 씀
            cup.Trash_Cup_Blue_Three1();




            move_material.selection_Blue_24[0].SetActive(false);
            move_material.selection_Blue_24[1].SetActive(false);
            move_material.selection_Blue_24[2].SetActive(false);
            move_material.selection_Blue_24[3].SetActive(false);
            move_material.selection_Blue_24[4].SetActive(false);
            move_material.selection_Blue_24[5].SetActive(false);
            move_material.selection_Blue_24[6].SetActive(false);
            move_material.selection_Blue_24[7].SetActive(false);
            move_material.selection_Blue_24[8].SetActive(false);
            move_material.selection_Blue_24[9].SetActive(false);
            move_material.selection_Blue_24[10].SetActive(false);
            move_material.selection_Blue_24[11].SetActive(false);
            move_material.selection_Blue_24[12].SetActive(false);
            move_material.selection_Blue_24[13].SetActive(false);
            move_material.selection_Blue_24[14].SetActive(false);
            move_material.selection_Blue_24[15].SetActive(false);

            move_material.selection_Pink_24[0].SetActive(false);
            move_material.selection_Pink_24[1].SetActive(false);
            move_material.selection_Pink_24[2].SetActive(false);
            move_material.selection_Pink_24[3].SetActive(false);
            move_material.selection_Pink_24[4].SetActive(false);
            move_material.selection_Pink_24[5].SetActive(false);
            move_material.selection_Pink_24[6].SetActive(false);
            move_material.selection_Pink_24[7].SetActive(false);
            move_material.selection_Pink_24[8].SetActive(false);
            move_material.selection_Pink_24[9].SetActive(false);
            move_material.selection_Pink_24[10].SetActive(false);
            move_material.selection_Pink_24[11].SetActive(false);
            move_material.selection_Pink_24[12].SetActive(false);
            move_material.selection_Pink_24[13].SetActive(false);
            move_material.selection_Pink_24[14].SetActive(false);
            move_material.selection_Pink_24[15].SetActive(false);

            Setting.SetActive(false);

            Blue_Material.SetActive(false);
            Pink_Material.SetActive(false);

            

            Pink_Cup_White1.SetActive(false);
            Pink_Cup_White2.SetActive(false);
            Pink_Cup_White3.SetActive(false);

            Pink_Cup_Pink1.SetActive(false);
            Pink_Cup_Pink2.SetActive(false);
            Pink_Cup_Pink3.SetActive(false);

            Blue_Cup_White1.SetActive(false);
            Blue_Cup_White2.SetActive(false);
            Blue_Cup_White3.SetActive(false);

            Blue_Cup_Blue1.SetActive(false);
            Blue_Cup_Blue2.SetActive(false);
            Blue_Cup_Blue3.SetActive(false);


            //08_15화

            Ddabong_Pink_1.SetActive(false);
            Ddabong_Pink_2.SetActive(false);
            Ddabong_Blue_1.SetActive(false);
            Ddabong_Blue_2.SetActive(false);

            Coin_Pink1.SetActive(false);

            Coin_Blue1.SetActive(false);

            //따봉, 안따봉 개수 0개로 초기화
            G_B.Goood_Count = 0;
            G_B.Bad_Ccount = 0;

            G_B.Goood_Count_Blue = 0;
            G_B.Bad_Ccount_Blue = 0;


            //골드 개수 0개로 초기화
            G_B.Ccoin_Count = 0;
            G_B.Ccoin_Count_Blue = 0;

            G_B.Update_Good_Count();
            G_B.Update_Bad_Count();
            G_B.Update_Coin_Count();

            G_B.Update_Good_Count_Blue();
            G_B.Update_Bad_Count_Blue();
            G_B.Update_Coin_Count_Blue();



            Pink_Cup_Inside_1.SetActive(false);
            Pink_Cup_Inside_2.SetActive(false);
            Pink_Cup_Inside_3.SetActive(false);

            Blue_Cup_Inside_1.SetActive(false);
            Blue_Cup_Inside_2.SetActive(false);
            Blue_Cup_Inside_3.SetActive(false);


            //턴 넘기는 버튼 둘다 활성화
            Next_Pink_Player.SetActive(true);
            Next_Blue_Player.SetActive(true);

            Pink.SetActive(true);
            Blue.SetActive(true);

            //판 위치와 회전 원래대로
            next_turn.board.anchoredPosition = new Vector2(0.0f, 0.0f);
            next_turn.board.rotation = Quaternion.Euler(0f, 0f, 0f);

            //next_turn.Plate_Back.anchoredPosition = new Vector2(1.0f, 3.8147e-05f);

            //분홍, 파랑말 원래대로
            // <뒤집을 때> 의 자식으로 돌아가기

            if (next_turn.board.localPosition == Vector3.zero)
            {
                //핑크 말1
                move_player.Four_Player[0].transform.SetParent(next_turn.Rotate_board.transform);
                move_player.Four_Player[0].transform.localPosition = new Vector3(-433.1f, -258.9f, 0.0f);
                move_player.Four_Player[0].transform.localRotation = Quaternion.Euler(0f, 0f, 180f);

                //핑크 말2
                move_player.Four_Player[1].transform.SetParent(next_turn.Rotate_board.transform);//next_turn.Rotate_board의 자식으로...
                move_player.Four_Player[1].transform.localRotation = Quaternion.Euler(0f, 0f, 180f);
                move_player.Four_Player[1].transform.localPosition = new Vector3(-394.75f, -258.9f, 0.0f);

                //블루 말1
                move_player.Four_Player[2].transform.SetParent(next_turn.Rotate_board.transform);//next_turn.Rotate_board의 자식으로...
                move_player.Four_Player[2].transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
                move_player.Four_Player[2].transform.localPosition = new Vector3(432.0f, 271.9f, 0.0f);


                //블루 말2
                move_player.Four_Player[3].transform.SetParent(next_turn.Rotate_board.transform);//next_turn.Rotate_board의 자식으로...
                move_player.Four_Player[3].transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
                move_player.Four_Player[3].transform.localPosition = new Vector3(393.76f, 271.9f, 0.0f);

                //말이 선택되었다는 false로
                move_player.selectionIndicators[0].SetActive(false);
                move_player.selectionIndicators[1].SetActive(false);
                move_player.selectionIndicators[2].SetActive(false);
                move_player.selectionIndicators[3].SetActive(false);


                //핑크
                upgrade_tile.Double_Player_Tile[0].SetActive(true);
                upgrade_tile.Double_Player_Tile[1].SetActive(false);
                upgrade_tile.Double_Player_Tile[2].SetActive(false);

                upgrade_tile.Diagonal_Line_Tile[0].SetActive(true);
                upgrade_tile.Diagonal_Line_Tile[1].SetActive(false);
                upgrade_tile.Diagonal_Line_Tile[2].SetActive(false);

                upgrade_tile.Vertex_Tile[0].SetActive(true);
                upgrade_tile.Vertex_Tile[1].SetActive(false);
                upgrade_tile.Vertex_Tile[2].SetActive(false);

                upgrade_tile.Speciality_Tile[0].SetActive(true);
                upgrade_tile.Speciality_Tile[1].SetActive(false);
                upgrade_tile.Speciality_Tile[2].SetActive(false);

                //블루
                upgrade_tile_blue.Double_Player_Tile[0].SetActive(true);
                upgrade_tile_blue.Double_Player_Tile[1].SetActive(false);
                upgrade_tile_blue.Double_Player_Tile[2].SetActive(false);

                upgrade_tile_blue.Diagonal_Line_Tile[0].SetActive(true);
                upgrade_tile_blue.Diagonal_Line_Tile[1].SetActive(false);
                upgrade_tile_blue.Diagonal_Line_Tile[2].SetActive(false);

                upgrade_tile_blue.Vertex_Tile[0].SetActive(true);
                upgrade_tile_blue.Vertex_Tile[1].SetActive(false);
                upgrade_tile_blue.Vertex_Tile[2].SetActive(false);

                upgrade_tile_blue.Speciality_Tile[0].SetActive(true);
                upgrade_tile_blue.Speciality_Tile[1].SetActive(false);
                upgrade_tile_blue.Speciality_Tile[2].SetActive(false);

                //카드 배치하는 곳의 자식을 다 없애기
                //핑크
                //카드 무브

                //핑크1
                if (card_move.Pink_First_Line[0].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Pink_First_Line[1].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Pink_First_Line[2].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Pink_First_Line[3].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Pink_First_Line[4].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Pink_First_Line[5].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Pink_First_Line[6].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                //자식 있음
                if (card_move.Pink_First_Line[0].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_First_Line[0].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_First_Line[1].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_First_Line[1].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_First_Line[2].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_First_Line[2].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_First_Line[3].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_First_Line[3].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_First_Line[4].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_First_Line[4].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_First_Line[5].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_First_Line[5].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_First_Line[6].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_First_Line[6].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                //핑크2
                if (card_move.Pink_Second_Line[0].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                if (card_move.Pink_Second_Line[1].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                if (card_move.Pink_Second_Line[2].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음"); ;
                }

                if (card_move.Pink_Second_Line[3].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                if (card_move.Pink_Second_Line[4].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                if (card_move.Pink_Second_Line[5].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                if (card_move.Pink_Second_Line[6].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                //자식 있음
                if (card_move.Pink_Second_Line[0].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Second_Line[0].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Second_Line[1].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Second_Line[1].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Second_Line[2].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Second_Line[2].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Second_Line[3].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Second_Line[3].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Second_Line[4].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Second_Line[4].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Second_Line[5].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Second_Line[5].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Second_Line[6].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Second_Line[6].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                //핑크3
                if (card_move.Pink_Third_Line[0].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Pink_Third_Line[1].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Pink_Third_Line[2].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Pink_Third_Line[3].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Pink_Third_Line[4].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Pink_Third_Line[5].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Pink_Third_Line[6].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                //자식 있음
                if (card_move.Pink_Third_Line[0].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Third_Line[0].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Third_Line[1].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Third_Line[1].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Third_Line[2].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Third_Line[2].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Third_Line[3].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Third_Line[3].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Third_Line[4].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Third_Line[4].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Third_Line[5].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Third_Line[5].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Third_Line[6].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Third_Line[6].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                //핑크4
                if (card_move.Pink_Fourth_Line[0].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Pink_Fourth_Line[1].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Pink_Fourth_Line[2].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Pink_Fourth_Line[3].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Pink_Fourth_Line[4].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Pink_Fourth_Line[5].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Pink_Fourth_Line[6].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                //자식 있음
                if (card_move.Pink_Fourth_Line[0].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Fourth_Line[0].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Fourth_Line[1].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Fourth_Line[1].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Fourth_Line[2].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Fourth_Line[2].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Fourth_Line[3].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Fourth_Line[3].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Fourth_Line[4].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Fourth_Line[4].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Fourth_Line[5].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Fourth_Line[5].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Fourth_Line[6].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Fourth_Line[6].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                //여기부터는 블루
                if (card_move.Blue_First_Line[0].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Blue_First_Line[1].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Blue_First_Line[2].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Blue_First_Line[3].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Blue_First_Line[4].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Blue_First_Line[5].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Blue_First_Line[6].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                //자식 있음
                if (card_move.Blue_First_Line[0].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_First_Line[0].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_First_Line[1].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_First_Line[1].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_First_Line[2].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_First_Line[2].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_First_Line[3].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_First_Line[3].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_First_Line[4].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_First_Line[4].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_First_Line[5].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_First_Line[5].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_First_Line[6].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_First_Line[6].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                //핑크2
                if (card_move.Blue_Second_Line[0].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                if (card_move.Blue_Second_Line[1].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                if (card_move.Blue_Second_Line[2].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음"); ;
                }

                if (card_move.Blue_Second_Line[3].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                if (card_move.Blue_Second_Line[4].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                if (card_move.Blue_Second_Line[5].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                if (card_move.Blue_Second_Line[6].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                //자식 있음
                if (card_move.Blue_Second_Line[0].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Second_Line[0].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Second_Line[1].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Second_Line[1].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Second_Line[2].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Second_Line[2].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Second_Line[3].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Second_Line[3].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Second_Line[4].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Second_Line[4].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Second_Line[5].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Second_Line[5].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Second_Line[6].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Second_Line[6].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                //핑크3
                if (card_move.Blue_Third_Line[0].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Blue_Third_Line[1].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Blue_Third_Line[2].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Blue_Third_Line[3].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Blue_Third_Line[4].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Blue_Third_Line[5].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Blue_Third_Line[6].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                //자식 있음
                if (card_move.Blue_Third_Line[0].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Third_Line[0].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Third_Line[1].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Third_Line[1].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Third_Line[2].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Third_Line[2].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Third_Line[3].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Third_Line[3].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Third_Line[4].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Third_Line[4].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Third_Line[5].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Third_Line[5].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Third_Line[6].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Third_Line[6].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                //핑크4
                if (card_move.Blue_Fourth_Line[0].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Blue_Fourth_Line[1].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Blue_Fourth_Line[2].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Blue_Fourth_Line[3].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Blue_Fourth_Line[4].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Blue_Fourth_Line[5].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Blue_Fourth_Line[6].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                //자식 있음
                if (card_move.Blue_Fourth_Line[0].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Fourth_Line[0].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Fourth_Line[1].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Fourth_Line[1].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Fourth_Line[2].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Fourth_Line[2].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Fourth_Line[3].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Fourth_Line[3].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Fourth_Line[4].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Fourth_Line[4].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Fourth_Line[5].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Fourth_Line[5].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Fourth_Line[6].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Fourth_Line[6].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                //카드 개수를 80새로 원상복귀
                //card_move.Menu_Card.Length = 80;
                //card_move.usedCardCount = 0;
                card_move.usedCards.Clear();
                card_move.UpdateCardCountText();

                move_count.Can_Move_Count = 1;

                turn_count.Click_Count = 0;
                turn_count.UpdateClickCountText();



            }
        }

        IEnumerator WaitSecond_2()
        {
            yield return new WaitForSeconds(3.0f);
            main.Go_Black.SetActive(false);
            main.Go_Empty.SetActive(false);
        }




    }



    public void Game_Reset()//게임 전체를 리셋
    {
        StartCoroutine(WaitSecond_0());
        StartCoroutine(WaitSecond_1());

        StartCoroutine(WaitSecond_2());

        IEnumerator WaitSecond_0()
        {
            yield return new WaitForSeconds(0.0f);
            main.Go_Black.SetActive(true);//없음->검정
            sfx.SFX_Button();//버튼 소리
            end.StopParticles();
        }

        IEnumerator WaitSecond_1()
        {
            yield return new WaitForSeconds(1.0f);

            //PC에서는 실행되는 코드입니다
            //확대, 축소 코드
            /*zoom.isZoomedIn = false;//줌인 상태가 아님
            zoom.zoomCount = 0; //짝수번째
            zoom.ZoomOut();//줌 아웃
            */
            zoom.ResetToOriginalSize();

            move_player.isSelected = false;

            //재료칸에 있는 재료 없애기
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

            //블루
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



            move_player.selectionIndicators[0].SetActive(false);
            move_player.selectionIndicators[1].SetActive(false);
            move_player.selectionIndicators[2].SetActive(false);
            move_player.selectionIndicators[3].SetActive(false);

            //여기부터 버튼 눌리는 거
            //얼음1 의 버튼이 눌리지 않게 하는 것
            Button button_0 = move_player.SixTeen_Plate_Button[0].GetComponent<Button>();
            button_0.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_0_1 = move_player.inside_SixTeen_Plate_Button[0].GetComponent<Button>();
            button_0_1.interactable = true;

            //카라멜1 의 버튼이 눌리지 않게 하는 것
            Button button_1 = move_player.SixTeen_Plate_Button[1].GetComponent<Button>();
            button_1.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_1_1 = move_player.inside_SixTeen_Plate_Button[1].GetComponent<Button>();
            button_1_1.interactable = true;

            //증기1 의 버튼이 눌리지 않게 하는 것
            Button button_2 = move_player.SixTeen_Plate_Button[2].GetComponent<Button>();
            button_2.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_2_1 = move_player.inside_SixTeen_Plate_Button[2].GetComponent<Button>();
            button_2_1.interactable = true;

            //커피1 의 버튼이 눌리지 않게 하는 것
            Button button_3 = move_player.SixTeen_Plate_Button[3].GetComponent<Button>();
            button_3.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_3_1 = move_player.inside_SixTeen_Plate_Button[3].GetComponent<Button>();
            button_3_1.interactable = true;

            //커피2의 버튼이 눌리지 않게 하는 것
            Button button_4 = move_player.SixTeen_Plate_Button[4].GetComponent<Button>();
            button_4.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_4_1 = move_player.inside_SixTeen_Plate_Button[4].GetComponent<Button>();
            button_4_1.interactable = true;

            //우유1 의 버튼이 눌리지 않게 하는 것
            Button button_5 = move_player.SixTeen_Plate_Button[5].GetComponent<Button>();
            button_5.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_5_1 = move_player.inside_SixTeen_Plate_Button[5].GetComponent<Button>();
            button_5_1.interactable = true;

            //얼음2 의 버튼이 눌리지 않게 하는 것
            Button button_6 = move_player.SixTeen_Plate_Button[6].GetComponent<Button>();
            button_6.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_6_1 = move_player.inside_SixTeen_Plate_Button[6].GetComponent<Button>();
            button_6_1.interactable = true;

            //물1 의 버튼이 눌리지 않게 하는 것
            Button button_7 = move_player.SixTeen_Plate_Button[7].GetComponent<Button>();
            button_7.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_7_1 = move_player.inside_SixTeen_Plate_Button[7].GetComponent<Button>();
            button_7_1.interactable = true;

            //녹차1의 버튼이 눌리지 않게 하는 것
            Button button_8 = move_player.SixTeen_Plate_Button[8].GetComponent<Button>();
            button_8.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_8_1 = move_player.inside_SixTeen_Plate_Button[8].GetComponent<Button>();
            button_8_1.interactable = true;

            //증기2의 버튼이 눌리지 않게 하는 것
            Button button_9 = move_player.SixTeen_Plate_Button[9].GetComponent<Button>();
            button_9.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_9_1 = move_player.inside_SixTeen_Plate_Button[9].GetComponent<Button>();
            button_9_1.interactable = true;

            //우유2의 버튼이 눌리지 않게 하는 것
            Button button_10 = move_player.SixTeen_Plate_Button[10].GetComponent<Button>();
            button_10.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_10_1 = move_player.inside_SixTeen_Plate_Button[10].GetComponent<Button>();
            button_10_1.interactable = true;

            //커피3의 버튼이 눌리지 않게 하는 것
            Button button_11 = move_player.SixTeen_Plate_Button[11].GetComponent<Button>();
            button_11.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_11_1 = move_player.inside_SixTeen_Plate_Button[11].GetComponent<Button>();
            button_11_1.interactable = true;

            //우유3의 버튼이 눌리지 않게 하는 것
            Button button_12 = move_player.SixTeen_Plate_Button[12].GetComponent<Button>();
            button_12.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_12_1 = move_player.inside_SixTeen_Plate_Button[12].GetComponent<Button>();
            button_12_1.interactable = true;

            //얼음3의 버튼이 눌리지 않게 하는 것
            Button button_13 = move_player.SixTeen_Plate_Button[13].GetComponent<Button>();
            button_13.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_13_1 = move_player.inside_SixTeen_Plate_Button[13].GetComponent<Button>();
            button_13_1.interactable = true;

            //초코1의 버튼이 눌리지 않게 하는 것
            Button button_14 = move_player.SixTeen_Plate_Button[14].GetComponent<Button>();
            button_14.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_14_1 = move_player.inside_SixTeen_Plate_Button[14].GetComponent<Button>();
            button_14_1.interactable = true;


            //증기3의 버튼이 눌리지 않게 하는 것
            Button button_15 = move_player.SixTeen_Plate_Button[15].GetComponent<Button>();
            button_15.interactable = true;//버튼이 눌리지 않게 하는 코드

            Button button_15_1 = move_player.inside_SixTeen_Plate_Button[15].GetComponent<Button>();
            button_15_1.interactable = true;

            //얼음
            ColorBlock colors_0 = move_player.SixTeen_Plate_Button[0].colors;
            colors_0.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[0].colors = colors_0;

            //카라멜
            ColorBlock colors_1 = move_player.SixTeen_Plate_Button[1].colors;
            colors_1.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[1].colors = colors_1;

            //증기1
            ColorBlock colors_2 = move_player.SixTeen_Plate_Button[2].colors;
            colors_2.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[2].colors = colors_2;

            //커피1
            ColorBlock colors_3 = move_player.SixTeen_Plate_Button[3].colors;
            colors_3.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[3].colors = colors_3;

            //커피2
            ColorBlock colors_4 = move_player.SixTeen_Plate_Button[4].colors;
            colors_4.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[4].colors = colors_4;

            //우유1
            ColorBlock colors_5 = move_player.SixTeen_Plate_Button[5].colors;
            colors_5.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[5].colors = colors_5;

            //얼음2
            ColorBlock colors_6 = move_player.SixTeen_Plate_Button[6].colors;
            colors_6.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[6].colors = colors_6;

            //물1
            ColorBlock colors_7 = move_player.SixTeen_Plate_Button[7].colors;
            colors_7.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[7].colors = colors_7;

            //녹차1
            ColorBlock colors_8 = move_player.SixTeen_Plate_Button[8].colors;
            colors_8.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[8].colors = colors_8;

            //증기2
            ColorBlock colors_9 = move_player.SixTeen_Plate_Button[9].colors;
            colors_9.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[9].colors = colors_9;

            //우유2
            ColorBlock colors_10 = move_player.SixTeen_Plate_Button[10].colors;
            colors_10.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[10].colors = colors_10;

            //커피3
            ColorBlock colors_11 = move_player.SixTeen_Plate_Button[11].colors;
            colors_11.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[11].colors = colors_11;

            //우유3
            ColorBlock colors_12 = move_player.SixTeen_Plate_Button[12].colors;
            colors_12.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[12].colors = colors_12;

            //얼음3
            ColorBlock colors_13 = move_player.SixTeen_Plate_Button[13].colors;
            colors_13.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[13].colors = colors_13;

            //초코1
            ColorBlock colors_14 = move_player.SixTeen_Plate_Button[14].colors;
            colors_14.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[14].colors = colors_14;

            //증기3
            ColorBlock colors_15 = move_player.SixTeen_Plate_Button[15].colors;
            colors_15.normalColor = new Color32(255, 255, 255, 255);
            move_player.SixTeen_Plate_Button[15].colors = colors_15;

            main.Go_Black.SetActive(false);
            main.Go_Empty.SetActive(true);

            Start_Player.SetActive(true);
            Color_Select.SetActive(true);

            blue_pink.Go_Black.SetActive(false);
            blue_pink.Go_Empty.SetActive(false);

            //main.Go_Black.SetActive(false);
            //main.Go_Empty.SetActive(false);
            main.main.SetActive(false);



            next_turn.Final_Curtain_Open_0.SetActive(false);
            next_turn.Final_Curtain_Open_1.SetActive(false);

            next_turn.Stay_Curtain_Left.SetActive(false);
            next_turn.Stay_Curtain_Right.SetActive(false);

            next_turn.Open_Curtain_Left.SetActive(false);
            next_turn.Open_Curtain_Right.SetActive(false);

            next_turn.Close_Curtain_Left.SetActive(false);
            next_turn.Close_Curtain_Right.SetActive(false);

            next_turn.Text_Game_Result.SetActive(false);
            next_turn.Text_Pink_Team_Win.SetActive(false);
            next_turn.Text_Blue_Team_Win.SetActive(false);
            next_turn.Text_Darw.SetActive(false);

            next_turn.Score.SetActive(false);

            next_turn.About_Blue.SetActive(false);
            next_turn.About_Pink.SetActive(false);

            next_turn.Wall.SetActive(false);

            //여기부터 19개
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
            next_turn.Blue_Total_Big.SetActive(false);
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
            next_turn.Pink_Total_Big.SetActive(false);
            next_turn.Pink_Upgrate_Tile_Yellow.SetActive(false);
            next_turn.Pink_Good_Count_Yellow.SetActive(false);
            next_turn.Pink_Bad_Count_Yellow.SetActive(false);
            next_turn.Pink_Gold_Count_Yellow.SetActive(false);

            next_turn.Blue_Total_Yellow.SetActive(false);
            next_turn.Pink_Total_Yellow.SetActive(false);

            //핑크가 이겼을 때
            next_turn.Pink_Win.SetActive(false);

            //블루가 이겼을 때
            next_turn.Blue_Win.SetActive(false);

            //무승부
            next_turn.Draw.SetActive(false);

            blue_Open.SetActive(false);
            blue_Close.SetActive(false);

            pink_Open.SetActive(false);
            pink_Close.SetActive(false);

            total.menuSet.SetActive(false);

            // 최종 점수 옆에 있는 코인
            next_turn.Pink_Score_Coin_brackets_Two.SetActive(false);
            next_turn.Pink_Score_Coin_Two.SetActive(false);

            next_turn.Pink_Score_Coin_brackets_One.SetActive(false);
            next_turn.Pink_Score_Coin_One.SetActive(false);

            next_turn.Blue_Score_Coin_brackets_Two.SetActive(false);
            next_turn.Blue_Score_Coin_Two.SetActive(false);

            next_turn.Blue_Score_Coin_brackets_One.SetActive(false);
            next_turn.Blue_Score_Coin_One.SetActive(false);

            //주문완료
            cup_menu.Coffee[0].SetActive(false);
            cup_menu.Coffee[1].SetActive(false);
            cup_menu.Coffee[2].SetActive(false);
            cup_menu.Coffee[3].SetActive(false);
            cup_menu.Coffee[4].SetActive(false);
            cup_menu.Coffee[5].SetActive(false);
            cup_menu.Coffee[6].SetActive(false);
            cup_menu.Coffee[7].SetActive(false);
            cup_menu.Coffee[8].SetActive(false);
            cup_menu.Coffee[9].SetActive(false);
            cup_menu.Coffee[10].SetActive(false);
            cup_menu.Coffee[11].SetActive(false);
            cup_menu.Coffee[12].SetActive(false);
            cup_menu.Coffee[13].SetActive(false);
            cup_menu.Coffee[14].SetActive(false);
            cup_menu.Coffee[15].SetActive(false);
            cup_menu.Coffee[16].SetActive(false);
            cup_menu.Coffee[17].SetActive(false);
            cup_menu.Coffee[18].SetActive(false);
            cup_menu.Coffee[19].SetActive(false);
            cup_menu.Coffee[20].SetActive(false);
            cup_menu.Coffee[21].SetActive(false);
            cup_menu.Coffee[22].SetActive(false);
            cup_menu.Coffee[23].SetActive(false);
            cup_menu.Coffee[24].SetActive(false);
            cup_menu.Coffee[25].SetActive(false);
            cup_menu.Coffee[26].SetActive(false);
            cup_menu.Coffee[27].SetActive(false);
            cup_menu.Coffee[28].SetActive(false);
            cup_menu.Coffee[29].SetActive(false);
            cup_menu.Coffee[30].SetActive(false);
            cup_menu.Coffee[31].SetActive(false);
            cup_menu.Coffee[32].SetActive(false);

            //분홍에 대한 스크립트
            /*upgrade_tile.Double_Player_Tile_Upgrade.SetActive(false);
            upgrade_tile.Double_Player_Tile_Upgrade_Inside.SetActive(false);
            upgrade_tile.Double_Player_Tile_Upgrade_Will_No.SetActive(false);
            upgrade_tile.Double_Player_Tile_Upgrade_Will_No_Inside.SetActive(false);

            upgrade_tile.Diagonal_Line_Tile_Upgrade.SetActive(false);
            upgrade_tile.Diagonal_Line_Tile_Upgrade_Inside.SetActive(false);

            upgrade_tile.Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            upgrade_tile.Diagonal_Line_Tile_Upgrade_Will_No_Inside.SetActive(false);

            upgrade_tile.Vertex_Tile_Upgrade.SetActive(false);//꼭짓점에 있을 때 2배 타일 업데이트
            upgrade_tile.Vertex_Tile_Upgrade_Inside.SetActive(false);

            upgrade_tile.Vertex_Tile_Upgrade_Will_No.SetActive(false);
            upgrade_tile.Vertex_Tile_Upgrade_Will_No_Inside.SetActive(false);

            //여기는 스페셜티 2배
            upgrade_tile.Speciality_Tile_Upgrade.SetActive(false);//스페셜티에 있을 때 2배 타일 업데이트
            upgrade_tile.Speciality_Tile_Upgrade_Inside.SetActive(false);

            upgrade_tile.Speciality_Tile_Upgrade_Will_No.SetActive(false);
            upgrade_tile.Speciality_Tile_Upgrade_Will_No_Inside.SetActive(false);

            upgrade_tile.Will_Use_Coin.SetActive(false);
            upgrade_tile.Will_Use_Coin_Inside.SetActive(false);
            upgrade_tile.Will_Use_Coin_No_Coin.SetActive(false);
            upgrade_tile.Will_Use_Coin_No_Coin_Inside.SetActive(false);
            upgrade_tile.No_Coin.SetActive(false);
            upgrade_tile.Use_Coin.SetActive(false);
            upgrade_tile.Already_Player_Coin_Zero.SetActive(false);
            upgrade_tile.Already_Player_Coin_Zero_Inside.SetActive(false);
            upgrade_tile.Already_Player_Coin_Not_Zero.SetActive(false);
            upgrade_tile.Already_Player_Coin_Not_Zero_Inside.SetActive(false);
            upgrade_tile.No_Good.SetActive(false);
            upgrade_tile.Next_Turn_No_Double_Player.SetActive(false);

            //파랑에 대한 스크립트
            upgrade_tile_blue.Double_Player_Tile_Upgrade.SetActive(false);
            upgrade_tile_blue.Double_Player_Tile_Upgrade_Inside.SetActive(false);
            upgrade_tile_blue.Double_Player_Tile_Upgrade_Will_No.SetActive(false);
            upgrade_tile_blue.Double_Player_Tile_Upgrade_Will_No_Inside.SetActive(false);

            upgrade_tile_blue.Diagonal_Line_Tile_Upgrade.SetActive(false);
            upgrade_tile_blue.Diagonal_Line_Tile_Upgrade_Inside.SetActive(false);

            upgrade_tile_blue.Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            upgrade_tile_blue.Diagonal_Line_Tile_Upgrade_Will_No_Inside.SetActive(false);

            upgrade_tile_blue.Vertex_Tile_Upgrade.SetActive(false);//꼭짓점에 있을 때 2배 타일 업데이트
            upgrade_tile_blue.Vertex_Tile_Upgrade_Inside.SetActive(false);

            upgrade_tile_blue.Vertex_Tile_Upgrade_Will_No.SetActive(false);
            upgrade_tile_blue.Vertex_Tile_Upgrade_Will_No_Inside.SetActive(false);

            //여기는 스페셜티 2배
            upgrade_tile_blue.Speciality_Tile_Upgrade.SetActive(false);//스페셜티에 있을 때 2배 타일 업데이트
            upgrade_tile_blue.Speciality_Tile_Upgrade_Inside.SetActive(false);

            upgrade_tile_blue.Speciality_Tile_Upgrade_Will_No.SetActive(false);
            upgrade_tile_blue.Speciality_Tile_Upgrade_Will_No_Inside.SetActive(false);

            upgrade_tile_blue.Will_Use_Coin.SetActive(false);
            upgrade_tile_blue.Will_Use_Coin_Inside.SetActive(false);
            upgrade_tile_blue.Will_Use_Coin_No_Coin.SetActive(false);
            upgrade_tile_blue.Will_Use_Coin_No_Coin_Inside.SetActive(false);
            upgrade_tile_blue.No_Coin.SetActive(false);
            upgrade_tile_blue.Use_Coin.SetActive(false);
            upgrade_tile_blue.Already_Player_Coin_Zero.SetActive(false);
            upgrade_tile_blue.Already_Player_Coin_Zero_Inside.SetActive(false);
            upgrade_tile_blue.Already_Player_Coin_Not_Zero.SetActive(false);
            upgrade_tile_blue.Already_Player_Coin_Not_Zero_Inside.SetActive(false);
            upgrade_tile_blue.No_Good.SetActive(false);
            upgrade_tile_blue.Next_Turn_No_Double_Player.SetActive(false);*/

            //분홍에 대한 스크립트
            upgrade_tile.Double_Player_Tile_Upgrade.SetActive(false);
            upgrade_tile.Double_Player_Tile_Upgrade_Inside.SetActive(false);
            upgrade_tile.Double_Player_Tile_Upgrade_Will_No.SetActive(true);
            upgrade_tile.Double_Player_Tile_Upgrade_Will_No_Inside.SetActive(false);

            upgrade_tile.Diagonal_Line_Tile_Upgrade.SetActive(false);
            upgrade_tile.Diagonal_Line_Tile_Upgrade_Inside.SetActive(false);

            upgrade_tile.Diagonal_Line_Tile_Upgrade_Will_No.SetActive(true);
            upgrade_tile.Diagonal_Line_Tile_Upgrade_Will_No_Inside.SetActive(false);

            upgrade_tile.Vertex_Tile_Upgrade.SetActive(false);//꼭짓점에 있을 때 2배 타일 업데이트
            upgrade_tile.Vertex_Tile_Upgrade_Inside.SetActive(false);

            upgrade_tile.Vertex_Tile_Upgrade_Will_No.SetActive(true);
            upgrade_tile.Vertex_Tile_Upgrade_Will_No_Inside.SetActive(false);

            //여기는 스페셜티 2배
            upgrade_tile.Speciality_Tile_Upgrade.SetActive(false);//스페셜티에 있을 때 2배 타일 업데이트
            upgrade_tile.Speciality_Tile_Upgrade_Inside.SetActive(false);

            upgrade_tile.Speciality_Tile_Upgrade_Will_No.SetActive(true);
            upgrade_tile.Speciality_Tile_Upgrade_Will_No_Inside.SetActive(false);

            upgrade_tile.Will_Use_Coin.SetActive(false);
            upgrade_tile.Will_Use_Coin_Inside.SetActive(false);

            upgrade_tile.Will_Use_Coin_No_Coin.SetActive(true);
            upgrade_tile.Will_Use_Coin_No_Coin_Inside.SetActive(false);
            upgrade_tile.No_Coin.SetActive(false);
            upgrade_tile.Use_Coin.SetActive(false);

            upgrade_tile.Already_Player_Coin_Zero.SetActive(true);
            upgrade_tile.Already_Player_Coin_Zero_Inside.SetActive(false);
            upgrade_tile.Already_Player_Coin_Not_Zero.SetActive(false);
            upgrade_tile.Already_Player_Coin_Not_Zero_Inside.SetActive(false);
            upgrade_tile.No_Good.SetActive(false);
            upgrade_tile.Next_Turn_No_Double_Player.SetActive(false);

            //파랑에 대한 스크립트
            upgrade_tile_blue.Double_Player_Tile_Upgrade.SetActive(false);
            upgrade_tile_blue.Double_Player_Tile_Upgrade_Inside.SetActive(false);

            //게임말 2배 충족 안됨
            upgrade_tile_blue.Double_Player_Tile_Upgrade_Will_No.SetActive(true);
            upgrade_tile_blue.Double_Player_Tile_Upgrade_Will_No_Inside.SetActive(false);

            upgrade_tile_blue.Diagonal_Line_Tile_Upgrade.SetActive(false);
            upgrade_tile_blue.Diagonal_Line_Tile_Upgrade_Inside.SetActive(false);

            //대각선 충족 안됨
            upgrade_tile_blue.Diagonal_Line_Tile_Upgrade_Will_No.SetActive(true);
            upgrade_tile_blue.Diagonal_Line_Tile_Upgrade_Will_No_Inside.SetActive(false);

            upgrade_tile_blue.Vertex_Tile_Upgrade.SetActive(false);//꼭짓점에 있을 때 2배 타일 업데이트
            upgrade_tile_blue.Vertex_Tile_Upgrade_Inside.SetActive(false);

            //꼭짓점 2배 충족 안됨
            upgrade_tile_blue.Vertex_Tile_Upgrade_Will_No.SetActive(true);
            upgrade_tile_blue.Vertex_Tile_Upgrade_Will_No_Inside.SetActive(false);

            //여기는 스페셜티 2배
            upgrade_tile_blue.Speciality_Tile_Upgrade.SetActive(false);//스페셜티에 있을 때 2배 타일 업데이트
            upgrade_tile_blue.Speciality_Tile_Upgrade_Inside.SetActive(false);

            //충족 안됨
            upgrade_tile_blue.Speciality_Tile_Upgrade_Will_No.SetActive(true);
            upgrade_tile_blue.Speciality_Tile_Upgrade_Will_No_Inside.SetActive(false);

            upgrade_tile_blue.Will_Use_Coin.SetActive(false);
            upgrade_tile_blue.Will_Use_Coin_Inside.SetActive(false);

            upgrade_tile_blue.Will_Use_Coin_No_Coin.SetActive(true);
            upgrade_tile_blue.Will_Use_Coin_No_Coin_Inside.SetActive(false);

            upgrade_tile_blue.No_Coin.SetActive(false);
            upgrade_tile_blue.Use_Coin.SetActive(false);

            upgrade_tile_blue.Already_Player_Coin_Zero.SetActive(true);

            upgrade_tile_blue.Already_Player_Coin_Zero_Inside.SetActive(false);
            upgrade_tile_blue.Already_Player_Coin_Not_Zero.SetActive(false);
            upgrade_tile_blue.Already_Player_Coin_Not_Zero_Inside.SetActive(false);
            upgrade_tile_blue.No_Good.SetActive(false);
            upgrade_tile_blue.Next_Turn_No_Double_Player.SetActive(false);

            //커피 잔 안에 있는 내용물 전부 삭제 & rigid와 콜라이더 초기화
            //rigid는 그대로 두고(중력1)
            //콜라이더도 활성화 된 상태로 두기

            //핑크 1 버림 코드 갖다 씀
            cup.Trash_Cup_Pink_One1();

            //핑크2 버림 코드 갖다 씀
            cup.Trash_Cup_Pink_Two1();

            //핑크3 버림 코드 갖다 씀
            cup.Trash_Cup_Pink_Three1();

            //블루 1 버림 코드 갖다 씀
            cup.Trash_Cup_Blue_One1();

            //블루2 버림 코드 갖다 씀
            cup.Trash_Cup_Blue_Two1();

            //블루3 버림 코드 갖다 씀
            cup.Trash_Cup_Blue_Three1();

            //음악
            sfx.back_SFX_Vol = 0.5001f;
            sfx.back_SFX_Volume.value = sfx.back_SFX_Vol;
            sfx.back_SFX_Vol = sfx.back_SFX_Volume.value;

            sfx.sfx1.volume = sfx.back_SFX_Volume.value;
            sfx.sfx2.volume = sfx.back_SFX_Volume.value;
            sfx.sfx3.volume = sfx.back_SFX_Volume.value;
            sfx.sfx4.volume = sfx.back_SFX_Volume.value;
            sfx.sfx5.volume = sfx.back_SFX_Volume.value;
            sfx.sfx6.volume = sfx.back_SFX_Volume.value;

            sfx.backVolume_1.value = sfx.sfx1.volume;
            sfx.backVolume_1.value = sfx.sfx2.volume;
            sfx.backVolume_1.value = sfx.sfx3.volume;
            sfx.backVolume_1.value = sfx.sfx4.volume;
            sfx.backVolume_1.value = sfx.sfx5.volume;
            sfx.backVolume_1.value = sfx.sfx6.volume;

            PlayerPrefs.SetFloat("back_SFX_Vol", sfx.back_SFX_Vol);

            Debug.Log(sfx.back_SFX_Vol + "로 SFX 초기화 할거지롱");

            bgm.backVol = 0.5001f;
            bgm.backVolume.value = bgm.backVol;
            bgm.backVol = bgm.backVolume.value;

            bgm.audio1.volume = bgm.backVolume.value;
            bgm.audio2.volume = bgm.backVolume.value;
            bgm.audio3.volume = bgm.backVolume.value;

            bgm.backVolume_1.value = bgm.audio1.volume;
            bgm.backVolume_1.value = bgm.audio2.volume;
            bgm.backVolume_1.value = bgm.audio3.volume;



            PlayerPrefs.SetFloat("backvol", bgm.backVol);

            Debug.Log(bgm.backVol + "로 BGM 초기화 할거지롱");

            //에베베
            sfx1.back_SFX_Vol = 0.5001f;
            sfx1.back_SFX_Volume.value = sfx1.back_SFX_Vol;
            sfx1.back_SFX_Vol = sfx1.back_SFX_Volume.value;

            sfx1.sfx1.volume = sfx1.back_SFX_Volume.value;
            sfx1.sfx2.volume = sfx1.back_SFX_Volume.value;
            sfx1.sfx3.volume = sfx1.back_SFX_Volume.value;
            sfx1.sfx4.volume = sfx1.back_SFX_Volume.value;
            sfx1.sfx5.volume = sfx1.back_SFX_Volume.value;
            sfx1.sfx6.volume = sfx1.back_SFX_Volume.value;

            sfx1.backVolume_1.value = sfx1.sfx1.volume;
            sfx1.backVolume_1.value = sfx1.sfx2.volume;
            sfx1.backVolume_1.value = sfx1.sfx3.volume;
            sfx1.backVolume_1.value = sfx1.sfx4.volume;
            sfx1.backVolume_1.value = sfx1.sfx5.volume;
            sfx1.backVolume_1.value = sfx1.sfx6.volume;

            PlayerPrefs.SetFloat("back_SFX_Vol", sfx1.back_SFX_Vol);

            Debug.Log(sfx1.back_SFX_Vol + "로 SFX 초기화 할거지롱");

            bgm1.backVol = 0.5001f;
            bgm1.backVolume.value = bgm1.backVol;
            bgm1.backVol = bgm1.backVolume.value;

            bgm1.audio1.volume = bgm1.backVolume.value;
            bgm1.audio2.volume = bgm1.backVolume.value;
            bgm1.audio3.volume = bgm1.backVolume.value;

            bgm1.backVolume_1.value = bgm1.audio1.volume;
            bgm1.backVolume_1.value = bgm1.audio2.volume;
            bgm1.backVolume_1.value = bgm1.audio3.volume;



            PlayerPrefs.SetFloat("backvol", bgm1.backVol);

            Debug.Log(bgm1.backVol + "로 BGM 초기화 할거지롱");


            move_material.selection_Blue_24[0].SetActive(false);
            move_material.selection_Blue_24[1].SetActive(false);
            move_material.selection_Blue_24[2].SetActive(false);
            move_material.selection_Blue_24[3].SetActive(false);
            move_material.selection_Blue_24[4].SetActive(false);
            move_material.selection_Blue_24[5].SetActive(false);
            move_material.selection_Blue_24[6].SetActive(false);
            move_material.selection_Blue_24[7].SetActive(false);
            move_material.selection_Blue_24[8].SetActive(false);
            move_material.selection_Blue_24[9].SetActive(false);
            move_material.selection_Blue_24[10].SetActive(false);
            move_material.selection_Blue_24[11].SetActive(false);
            move_material.selection_Blue_24[12].SetActive(false);
            move_material.selection_Blue_24[13].SetActive(false);
            move_material.selection_Blue_24[14].SetActive(false);
            move_material.selection_Blue_24[15].SetActive(false);

            move_material.selection_Pink_24[0].SetActive(false);
            move_material.selection_Pink_24[1].SetActive(false);
            move_material.selection_Pink_24[2].SetActive(false);
            move_material.selection_Pink_24[3].SetActive(false);
            move_material.selection_Pink_24[4].SetActive(false);
            move_material.selection_Pink_24[5].SetActive(false);
            move_material.selection_Pink_24[6].SetActive(false);
            move_material.selection_Pink_24[7].SetActive(false);
            move_material.selection_Pink_24[8].SetActive(false);
            move_material.selection_Pink_24[9].SetActive(false);
            move_material.selection_Pink_24[10].SetActive(false);
            move_material.selection_Pink_24[11].SetActive(false);
            move_material.selection_Pink_24[12].SetActive(false);
            move_material.selection_Pink_24[13].SetActive(false);
            move_material.selection_Pink_24[14].SetActive(false);
            move_material.selection_Pink_24[15].SetActive(false);

            Setting.SetActive(false);

            Blue_Material.SetActive(false);
            Pink_Material.SetActive(false);

            Pink_Cup_White1.SetActive(false);
            Pink_Cup_White2.SetActive(false);
            Pink_Cup_White3.SetActive(false);

            Pink_Cup_Pink1.SetActive(false);
            Pink_Cup_Pink2.SetActive(false);
            Pink_Cup_Pink3.SetActive(false);

            Blue_Cup_White1.SetActive(false);
            Blue_Cup_White2.SetActive(false);
            Blue_Cup_White3.SetActive(false);

            Blue_Cup_Blue1.SetActive(false);
            Blue_Cup_Blue2.SetActive(false);
            Blue_Cup_Blue3.SetActive(false);

            //08_15화

            Ddabong_Pink_1.SetActive(false);
            Ddabong_Pink_2.SetActive(false);
            Ddabong_Blue_1.SetActive(false);
            Ddabong_Blue_2.SetActive(false);

            Coin_Pink1.SetActive(false);

            Coin_Blue1.SetActive(false);

            //따봉, 안따봉 개수 0개로 초기화
            G_B.Goood_Count = 0;
            G_B.Bad_Ccount = 0;

            G_B.Goood_Count_Blue = 0;
            G_B.Bad_Ccount_Blue = 0;


            //골드 개수 0개로 초기화
            G_B.Ccoin_Count = 0;
            G_B.Ccoin_Count_Blue = 0;

            G_B.Update_Good_Count();
            G_B.Update_Bad_Count();
            G_B.Update_Coin_Count();

            G_B.Update_Good_Count_Blue();
            G_B.Update_Bad_Count_Blue();
            G_B.Update_Coin_Count_Blue();



            Pink_Cup_Inside_1.SetActive(false);
            Pink_Cup_Inside_2.SetActive(false);
            Pink_Cup_Inside_3.SetActive(false);

            Blue_Cup_Inside_1.SetActive(false);
            Blue_Cup_Inside_2.SetActive(false);
            Blue_Cup_Inside_3.SetActive(false);


            //턴 넘기는 버튼 둘다 활성화
            Next_Pink_Player.SetActive(true);
            Next_Blue_Player.SetActive(true);

            Pink.SetActive(true);
            Blue.SetActive(true);

            //판 위치와 회전 원래대로
            next_turn.board.anchoredPosition = new Vector2(0.0f, 0.0f);
            next_turn.board.rotation = Quaternion.Euler(0f, 0f, 0f);

            //next_turn.Plate_Back.anchoredPosition = new Vector2(1.0f, 3.8147e-05f);

            //분홍, 파랑말 원래대로
            // <뒤집을 때> 의 자식으로 돌아가기

            if (next_turn.board.localPosition == Vector3.zero)
            {
                //핑크 말1
                move_player.Four_Player[0].transform.SetParent(next_turn.Rotate_board.transform);
                move_player.Four_Player[0].transform.localPosition = new Vector3(-433.1f, -258.9f, 0.0f);
                move_player.Four_Player[0].transform.localRotation = Quaternion.Euler(0f, 0f, 180f);

                //핑크 말2
                move_player.Four_Player[1].transform.SetParent(next_turn.Rotate_board.transform);//next_turn.Rotate_board의 자식으로...
                move_player.Four_Player[1].transform.localRotation = Quaternion.Euler(0f, 0f, 180f);
                move_player.Four_Player[1].transform.localPosition = new Vector3(-394.75f, -258.9f, 0.0f);

                //블루 말1
                move_player.Four_Player[2].transform.SetParent(next_turn.Rotate_board.transform);//next_turn.Rotate_board의 자식으로...
                move_player.Four_Player[2].transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
                move_player.Four_Player[2].transform.localPosition = new Vector3(432.0f, 271.9f, 0.0f);


                //블루 말2
                move_player.Four_Player[3].transform.SetParent(next_turn.Rotate_board.transform);//next_turn.Rotate_board의 자식으로...
                move_player.Four_Player[3].transform.localRotation = Quaternion.Euler(0f, 0f, 0f);
                move_player.Four_Player[3].transform.localPosition = new Vector3(393.76f, 271.9f, 0.0f);

                //말이 선택되었다는 false로
                move_player.selectionIndicators[0].SetActive(false);
                move_player.selectionIndicators[1].SetActive(false);
                move_player.selectionIndicators[2].SetActive(false);
                move_player.selectionIndicators[3].SetActive(false);



                //핑크
                upgrade_tile.Double_Player_Tile[0].SetActive(true);
                upgrade_tile.Double_Player_Tile[1].SetActive(false);
                upgrade_tile.Double_Player_Tile[2].SetActive(false);

                upgrade_tile.Diagonal_Line_Tile[0].SetActive(true);
                upgrade_tile.Diagonal_Line_Tile[1].SetActive(false);
                upgrade_tile.Diagonal_Line_Tile[2].SetActive(false);

                upgrade_tile.Vertex_Tile[0].SetActive(true);
                upgrade_tile.Vertex_Tile[1].SetActive(false);
                upgrade_tile.Vertex_Tile[2].SetActive(false);

                upgrade_tile.Speciality_Tile[0].SetActive(true);
                upgrade_tile.Speciality_Tile[1].SetActive(false);
                upgrade_tile.Speciality_Tile[2].SetActive(false);

                //블루
                upgrade_tile_blue.Double_Player_Tile[0].SetActive(true);
                upgrade_tile_blue.Double_Player_Tile[1].SetActive(false);
                upgrade_tile_blue.Double_Player_Tile[2].SetActive(false);

                upgrade_tile_blue.Diagonal_Line_Tile[0].SetActive(true);
                upgrade_tile_blue.Diagonal_Line_Tile[1].SetActive(false);
                upgrade_tile_blue.Diagonal_Line_Tile[2].SetActive(false);

                upgrade_tile_blue.Vertex_Tile[0].SetActive(true);
                upgrade_tile_blue.Vertex_Tile[1].SetActive(false);
                upgrade_tile_blue.Vertex_Tile[2].SetActive(false);

                upgrade_tile_blue.Speciality_Tile[0].SetActive(true);
                upgrade_tile_blue.Speciality_Tile[1].SetActive(false);
                upgrade_tile_blue.Speciality_Tile[2].SetActive(false);

                //카드 배치하는 곳의 자식을 다 없애기
                //핑크
                //카드 무브

                //핑크1
                if (card_move.Pink_First_Line[0].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Pink_First_Line[1].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Pink_First_Line[2].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Pink_First_Line[3].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Pink_First_Line[4].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Pink_First_Line[5].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Pink_First_Line[6].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                //자식 있음
                if (card_move.Pink_First_Line[0].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_First_Line[0].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_First_Line[1].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_First_Line[1].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_First_Line[2].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_First_Line[2].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_First_Line[3].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_First_Line[3].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_First_Line[4].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_First_Line[4].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_First_Line[5].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_First_Line[5].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_First_Line[6].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_First_Line[6].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                //핑크2
                if (card_move.Pink_Second_Line[0].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                if (card_move.Pink_Second_Line[1].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                if (card_move.Pink_Second_Line[2].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음"); ;
                }

                if (card_move.Pink_Second_Line[3].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                if (card_move.Pink_Second_Line[4].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                if (card_move.Pink_Second_Line[5].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                if (card_move.Pink_Second_Line[6].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                //자식 있음
                if (card_move.Pink_Second_Line[0].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Second_Line[0].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Second_Line[1].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Second_Line[1].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Second_Line[2].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Second_Line[2].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Second_Line[3].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Second_Line[3].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Second_Line[4].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Second_Line[4].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Second_Line[5].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Second_Line[5].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Second_Line[6].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Second_Line[6].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                //핑크3
                if (card_move.Pink_Third_Line[0].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Pink_Third_Line[1].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Pink_Third_Line[2].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Pink_Third_Line[3].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Pink_Third_Line[4].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Pink_Third_Line[5].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Pink_Third_Line[6].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                //자식 있음
                if (card_move.Pink_Third_Line[0].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Third_Line[0].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Third_Line[1].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Third_Line[1].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Third_Line[2].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Third_Line[2].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Third_Line[3].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Third_Line[3].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Third_Line[4].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Third_Line[4].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Third_Line[5].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Third_Line[5].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Third_Line[6].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Third_Line[6].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                //핑크4
                if (card_move.Pink_Fourth_Line[0].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Pink_Fourth_Line[1].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Pink_Fourth_Line[2].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Pink_Fourth_Line[3].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Pink_Fourth_Line[4].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Pink_Fourth_Line[5].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Pink_Fourth_Line[6].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                //자식 있음
                if (card_move.Pink_Fourth_Line[0].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Fourth_Line[0].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Fourth_Line[1].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Fourth_Line[1].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Fourth_Line[2].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Fourth_Line[2].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Fourth_Line[3].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Fourth_Line[3].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Fourth_Line[4].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Fourth_Line[4].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Fourth_Line[5].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Fourth_Line[5].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Pink_Fourth_Line[6].transform.childCount == 1)
                {
                    Destroy(card_move.Pink_Fourth_Line[6].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                //여기부터는 블루
                if (card_move.Blue_First_Line[0].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Blue_First_Line[1].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Blue_First_Line[2].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Blue_First_Line[3].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Blue_First_Line[4].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Blue_First_Line[5].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                if (card_move.Blue_First_Line[6].transform.childCount == 0)
                {
                    Debug.Log("첫번째 줄 자식 없음");
                }

                //자식 있음
                if (card_move.Blue_First_Line[0].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_First_Line[0].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_First_Line[1].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_First_Line[1].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_First_Line[2].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_First_Line[2].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_First_Line[3].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_First_Line[3].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_First_Line[4].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_First_Line[4].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_First_Line[5].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_First_Line[5].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_First_Line[6].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_First_Line[6].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                //핑크2
                if (card_move.Blue_Second_Line[0].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                if (card_move.Blue_Second_Line[1].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                if (card_move.Blue_Second_Line[2].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음"); ;
                }

                if (card_move.Blue_Second_Line[3].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                if (card_move.Blue_Second_Line[4].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                if (card_move.Blue_Second_Line[5].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                if (card_move.Blue_Second_Line[6].transform.childCount == 0)
                {
                    Debug.Log("두번째 줄 자식 없음");
                }

                //자식 있음
                if (card_move.Blue_Second_Line[0].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Second_Line[0].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Second_Line[1].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Second_Line[1].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Second_Line[2].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Second_Line[2].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Second_Line[3].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Second_Line[3].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Second_Line[4].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Second_Line[4].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Second_Line[5].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Second_Line[5].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Second_Line[6].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Second_Line[6].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                //핑크3
                if (card_move.Blue_Third_Line[0].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Blue_Third_Line[1].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Blue_Third_Line[2].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Blue_Third_Line[3].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Blue_Third_Line[4].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Blue_Third_Line[5].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                if (card_move.Blue_Third_Line[6].transform.childCount == 0)
                {
                    Debug.Log("세번째 줄 자식 없음");
                }

                //자식 있음
                if (card_move.Blue_Third_Line[0].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Third_Line[0].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Third_Line[1].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Third_Line[1].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Third_Line[2].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Third_Line[2].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Third_Line[3].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Third_Line[3].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Third_Line[4].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Third_Line[4].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Third_Line[5].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Third_Line[5].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Third_Line[6].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Third_Line[6].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                //핑크4
                if (card_move.Blue_Fourth_Line[0].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Blue_Fourth_Line[1].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Blue_Fourth_Line[2].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Blue_Fourth_Line[3].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Blue_Fourth_Line[4].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Blue_Fourth_Line[5].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                if (card_move.Blue_Fourth_Line[6].transform.childCount == 0)
                {
                    Debug.Log("네번째 줄 자식 없음");
                }

                //자식 있음
                if (card_move.Blue_Fourth_Line[0].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Fourth_Line[0].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Fourth_Line[1].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Fourth_Line[1].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Fourth_Line[2].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Fourth_Line[2].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Fourth_Line[3].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Fourth_Line[3].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Fourth_Line[4].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Fourth_Line[4].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Fourth_Line[5].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Fourth_Line[5].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                if (card_move.Blue_Fourth_Line[6].transform.childCount == 1)
                {
                    Destroy(card_move.Blue_Fourth_Line[6].transform.GetChild(0).gameObject);

                    card_move.usedCardCount = card_move.usedCardCount - 1;
                }

                //카드 개수를 80새로 원상복귀
                //card_move.Menu_Card.Length = 80;
                //card_move.usedCardCount = 0;
                card_move.usedCards.Clear();
                card_move.UpdateCardCountText();

                move_count.Can_Move_Count = 1;

                turn_count.Click_Count = 0;
                turn_count.UpdateClickCountText();


            }

        }


        IEnumerator WaitSecond_2()
        {
            yield return new WaitForSeconds(3.0f);
            main.Go_Black.SetActive(false);
            main.Go_Empty.SetActive(false);
        }






    }

    public void End_Game()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit(); // 어플리케이션 종료
#endif
    }
}
