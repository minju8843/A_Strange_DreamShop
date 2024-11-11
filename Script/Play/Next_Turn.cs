using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Next_Turn : MonoBehaviour
{
    public CameraZoom zoom;

    //���� ����

    //��ũ ���� ��
    //��ũ�� ���� ������ �Ǿ��� ���
    //�Ķ��̱��� �ϰ� �Ѿ�� �ϳ�
    //�Ķ��̿��� �ֹ� ó�� �� �� ���� �������ų� ó������ �ʴ� ���� �߻�
    //������ �ϳ� ���� ����

    //��ũ ���� ��
    //��簡 ���� ������ �Ǿ��� ���
    //���� �� �ѱ� �� �ٷ� ���� ��� ���� ���;� ������
    //2�� ���� �� ���������� ���� ���� ����



    public GameObject Rotate_board;
    public RectTransform board;

    public GameObject Go_Player1_B;//��� ��ư
    public GameObject Go_Player2_B;//��ũ ��ư

    public RectTransform Plate_Back;//�� ���� ��ġ��

    public Card_Move card_move;

    public Turn_Count Click_Button;//��ư�� �� �� �������� Ȯ���ϱ� ���� ��
    
    //08.07���� �߰�
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

    //������ʹ� ���� ����
    //������� ��ũ ���� ��� ���õ� ��

    //���׷��̵� Ÿ�� ����
    //���׷��̵� Ÿ�� + (�� ����� �� �տ� �ִ� +)
    public GameObject Pink_Plus_Upgrate_Tile;//�÷����� �ִ� ��

    //���׷��̵� Ÿ�� �� ����� ��
    public GameObject Pink_Upgrate_Tile_Total;
    public Text Pink_Upgrate_Tile_Total_Text;

    //���׷��̵� Ÿ�� +( 2 x )
    public GameObject Pink_Plus_brackets_Upgrate_Tile;//��ȣ ���׷��̵� Ÿ��

    //���׷��̵� Ÿ�� 4
    public GameObject Pink_Upgrate_Tile_Four;
    public Text Pink_Upgrate_Tile_Four_Text;

    //�ֹ� �Ϸ��� Ƚ�� +
    public GameObject Pink_Plus_Good_Count;//�÷����� �ִ� ��

    //�ֹ� �Ϸ��� Ƚ�� ����
    public GameObject Pink_Good_Count;
    public Text Pink_Good_Count_Text;

    //�ֹ� ������ Ƚ�� -
    public GameObject Pink_Minus_Bad_Count;//���̳ʽ��� �ִ� ��

    //�ֹ� ������ Ƚ�� ����
    public GameObject Pink_Bad_Count;
    public Text Pink_Bad_Count_Text;

    //���� ���� () - �� �ڸ���
    public GameObject Pink_Plus_Gold_Count_One_brackets;//�÷����� �ִ� ��

    //���� ���� ���� - �� �ڸ���
    public GameObject Pink_Plus_Gold_Count_One;
    public Text Pink_Plus_Gold_Count_One_Text;

    //���� ���� () - �� �ڸ���
    public GameObject Pink_Plus_Gold_Count_Two_brackets;

    //���� ���� ���� - �� �ڸ� ��
    public GameObject Pink_Plus_Gold_Count_Two;//��ȣ ����
    public Text Pink_Plus_Gold_Count_Two_Text;

    //���� �׸�
    public GameObject Pink_Brown_Line;

    //��ü ���� �۰�
    public GameObject Pink_Total_Small;
    public Text Pink_Total_Small_Text;

    //��ü ���� ũ��
    public GameObject Pink_Total_Big;
    public Text Pink_Total_Big_Text;


    // ** ������ʹ� ��� �� **

    //���׷��̵� Ÿ��
    public GameObject Pink_Upgrate_Tile_Yellow;

    //�ֹ� ó�� ī��
    public GameObject Pink_Good_Count_Yellow;

    //�ֹ� ���� ī��
    public GameObject Pink_Bad_Count_Yellow;

    //���� ����
    public GameObject Pink_Gold_Count_Yellow;

    //�� ����
    public GameObject Pink_Total_Yellow;

    // *** ������� �Ķ� �� ***
    public GameObject Blue_Plus_Upgrate_Tile;//�÷����� �ִ� ��

    //���׷��̵� Ÿ�� �� ����� ��
    public GameObject Blue_Upgrate_Tile_Total;
    public Text Blue_Upgrate_Tile_Total_Text;

    //���׷��̵� Ÿ�� +( 2 x )
    public GameObject Blue_Plus_brackets_Upgrate_Tile;//��ȣ ���׷��̵� Ÿ��

    //���׷��̵� Ÿ�� 4
    public GameObject Blue_Upgrate_Tile_Four;
    public Text Blue_Upgrate_Tile_Four_Text;

    //�ֹ� �Ϸ��� Ƚ�� +
    public GameObject Blue_Plus_Good_Count;//�÷����� �ִ� ��

    //�ֹ� �Ϸ��� Ƚ�� ����
    public GameObject Blue_Good_Count;
    public Text Blue_Good_Count_Text;

    //�ֹ� ������ Ƚ�� -
    public GameObject Blue_Minus_Bad_Count;//���̳ʽ��� �ִ� ��

    //�ֹ� ������ Ƚ�� ����
    public GameObject Blue_Bad_Count;
    public Text Blue_Bad_Count_Text;

    //���� ���� () - �� �ڸ���
    public GameObject Blue_Plus_Gold_Count_One_brackets;//�÷����� �ִ� ��

    //���� ���� ���� - �� �ڸ���
    public GameObject Blue_Plus_Gold_Count_One;//�÷����� �ִ� ��
    public Text Blue_Plus_Gold_Count_One_Text;

    //���� ���� () - �� �ڸ���
    public GameObject Blue_Plus_Gold_Count_Two_brackets;

    //���� ���� ���� - �� �ڸ� ��
    public GameObject Blue_Plus_Gold_Count_Two;//��ȣ ����
    public Text Blue_Plus_Gold_Count_Two_Text;

    //���� �׸�
    public GameObject Blue_Brown_Line;

    //��ü ���� �۰�
    public GameObject Blue_Total_Small;
    public Text Blue_Total_Small_Text;

    //��ü ���� ũ��
    public GameObject Blue_Total_Big;
    public Text Blue_Total_Big_Text;

    //���׷��̵�
    public GameObject Blue_Upgrate_Tile_Yellow;

    //�ֹ� ó�� ī��
    public GameObject Blue_Good_Count_Yellow;

    //�ֹ� ���� ī��
    public GameObject Blue_Bad_Count_Yellow;

    //���� ����
    public GameObject Blue_Gold_Count_Yellow;

    //�� ����
    public GameObject Blue_Total_Yellow;

    //�Ķ� ���� �̰��� ��
    public GameObject Blue_Win;

    //��ȫ ���� �̰��� ��
    public GameObject Pink_Win;

    //���º��϶�
    public GameObject Draw;


    public GameObject Pink_Score_Coin_brackets_Two;//���� ���� ���� �ִ� ��� - �� �ڸ���
    public GameObject Pink_Score_Coin_Two;
    public Text Pink_Score_Coin_Two_Text;

    public GameObject Pink_Score_Coin_brackets_One;//���� ���� ���� �ִ� ��� - �� �ڸ���
    public GameObject Pink_Score_Coin_One;
    public Text Pink_Score_Coin_One_Text;

    public GameObject Blue_Score_Coin_brackets_Two;//���� ���� ���� �ִ� ��� - �� �ڸ� ��
    public GameObject Blue_Score_Coin_Two;
    public Text Blue_Score_Coin_Two_Text;

    public GameObject Blue_Score_Coin_brackets_One;//���� ���� ���� �ִ� ��� - �� �ڸ� ��
    public GameObject Blue_Score_Coin_One;
    public Text Blue_Score_Coin_One_Text;


    public Score score;

    //���̳� ����
    public GameObject Final_Curtain_Open_0;
    public GameObject Final_Curtain_Open_1;


    void Start()
    {

        Go_Player1_B.SetActive(false); ;//���
        Go_Player2_B.SetActive(false);
        //<��ũ�� ���� �����Ѵٰ� ���� ��>
        //���� ���� ȸ���ϴ� ���� ��ġ�� 0f, 15.6f�̶��
        //��ư�� ������ �� 0, 0���� ���ư��� �ϰ� (�Ķ����� ������)

        //�� ���� ��ư�� ������ ��(��ȫ���� ������)
        //0, 15.6�� ��ġ�� �Ǿ�� ��.

        //�� ���� ��ư�� ������ ��(�Ķ��� ������)
        //�ٽ� 0����

        


    }


    public void Go_Player1()//��ũȮ��
    {

        Debug.Log("�������� ����");

        //PC������ ����Ǵ� �ڵ��Դϴ�
        //Ȯ��, ��� �ڵ�
        /*zoom.isZoomedIn = false;//���� ���°� �ƴ�
        zoom.zoomCount = 0; //¦����°
        zoom.ZoomOut();//�� �ƿ�
        */
        //12.9���� z���� 180�� ���ư� ��Ȳ�̾��� ���� ��ư ������ 12.9�� �ƹ� ȸ���� ���� �� �����µ�
        //0, 0, 0��ġ�� �ƹ� ȸ���� ���°ſ��� ��

        zoom.ResetToOriginalSize();

        Vector2 currentPosition = board.anchoredPosition;//���� ������Ʈ ��ġ�� �����ͼ� currentPosition�� ����

        // ���� ���� ��ġ�� (0, 0)���
        if (currentPosition.x == 0 && currentPosition.y == 0)
        {
           

            if(Click_Button.Click_Count<4)
            {
                Click_Button.Click_Count++;//1�� �߰�
                Click_Button.UpdateClickCountText();
                StartCoroutine(Go_Player_1_1());

                IEnumerator Go_Player_1_1()
                {
                    yield return new WaitForSeconds(0.0f);//0.5����

                    Rotate_board.transform.Rotate(0f, 0f, 180f);
                    // ���� ��ġ�� (0, 15.6)���� ����
                    board.anchoredPosition = new Vector2(0f, 12.9f);//15.6���µ�

  
                    Go_Player1_B.SetActive(true);//���
                    Go_Player2_B.SetActive(false);
                    //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                    //0813
                    blue.SetActive(true);
                    pink.SetActive(false);

                    //Player1_Cup.SetActive(true);
                    //Player2_Cup.SetActive(false);
                    //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)

                    //08.11.��
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
                || card_move.Pink_Fourth_Line[6].transform.childCount == 1))//Ŭ�� ī��Ʈ�� 4 �̻��� �� //4��° �� �ڽ��� �ִ°� �ϳ� �̻��� ��
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//���� ĭ�� ���� 2�� ���� ��
                {
                    //��ũ
                    upgrade_tile.No_Double_Player();
                }

                else
                {
                    Click_Button.Click_Count++;//1�� �߰�
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
                        yield return new WaitForSeconds(2.8f);//0.5����

                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        // ���� ��ġ�� (0, 15.6)���� ����
                        board.anchoredPosition = new Vector2(0f, 12.9f);//15.6���µ�

                        

                        Go_Player1_B.SetActive(true);//���
                        Go_Player2_B.SetActive(false);
                        //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                        //08.07.���� �߰�
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

                        //08.11.��
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
                        //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
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
                && card_move.Pink_Fourth_Line[6].transform.childCount == 0)//Ŭ�� ī��Ʈ�� 4 �̻��� �� //4��° �� �ڽ��� �ִ°� �ϳ��� ���� ���
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//���� ĭ�� ���� 2�� ���� ��
                {
                    //��ũ
                    upgrade_tile.No_Double_Player();
                }

                else
                {


                    Click_Button.Click_Count++;//1�� �߰�
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
                        yield return new WaitForSeconds(0.5f);//0.5����

                        Debug.Log("2�� ����Ǿ��� ����");

                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        // ���� ��ġ�� (0, 15.6)���� ����
                         board.anchoredPosition = new Vector2(0f, 12.9f);//12.9���µ�

                        

                        Go_Player1_B.SetActive(true); //���
                        Go_Player2_B.SetActive(false);
                        //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                        //08.07.���� �߰�
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

                        //08.11.��
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
                        //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
                    }
                }
                
            }

        }

        //�����ϰ� �ִ°�
        else if(currentPosition.x == 0 && currentPosition.y == 12.9)
        {
            

            if (Click_Button.Click_Count < 3)//4����
            {
                Click_Button.Click_Count++;//1�� �߰�
                Click_Button.UpdateClickCountText();

                StartCoroutine(Go_Player_1_2());

                IEnumerator Go_Player_1_2()
                {
                    yield return new WaitForSeconds(0.0f);//0.5����




                    Rotate_board.transform.Rotate(0f, 0f, 180f);
                    // ���� ��ġ�� (0, 15.6)���� ����
                    board.anchoredPosition = new Vector2(0f, 0f);//0.0���µ�

                    Go_Player1_B.SetActive(true); ;//���
                    Go_Player2_B.SetActive(false);

                    //0813
                    blue.SetActive(true);
                    pink.SetActive(false);

                   

                    //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                    //08.11.��
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
                    //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
                }
            }

            //�����߰� 0814
            //3�϶�
            else if (Click_Button.Click_Count == 3)
            {
                Click_Button.Click_Count++;//1�� �߰�
                Click_Button.UpdateClickCountText();

                //Debug.Log("��ũ �󸸵�" + Click_Button.Click_Count);
                //������� ����

                StartCoroutine(Go_Player_1_2());

                IEnumerator Go_Player_1_2()
                {
                    yield return new WaitForSeconds(0.0f);//0.5����


                    //Rotate_board.transform.Rotate(0f, 0f, 180f);
                    // ���� ��ġ�� (0, 15.6)���� ����
                    board.anchoredPosition = new Vector2(0f, 12.9f);//0.0���µ�

                    Go_Player1_B.SetActive(false); //���
                    Go_Player2_B.SetActive(true);

                    //0813
                    blue.SetActive(false);
                    pink.SetActive(true);



                    //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                    //08.11.��
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
                    //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
                }
            }

            //���� �Ʒ����ʹ� ���� �ִ� ��

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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//���� ĭ�� ���� 2�� ���� ��
                {
                    //��ũ
                    upgrade_tile.No_Double_Player();
                }

                else
                {


                    Click_Button.Click_Count++;//1�� �߰�
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
                        yield return new WaitForSeconds(2.8f);//0.5����

                        Debug.Log("3�� ����Ǿ��� ����");

                  


                        //Rotate_board.transform.Rotate(0f, 0f, 180f);
                        // ���� ��ġ�� (0, 15.6)���� ����
                        board.anchoredPosition = new Vector2(0f, 12.9f);//0.0���µ�

                        Go_Player1_B.SetActive(false); ;//���
                        Go_Player2_B.SetActive(true);
                        //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                        //08.07.���� �߰�
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

                        //08.11.��
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
                        //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//���� ĭ�� ���� 2�� ���� ��
                {
                    //��ũ
                    upgrade_tile.No_Double_Player();
                }

                else
                {

                    Click_Button.Click_Count++;//1�� �߰�
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
                        yield return new WaitForSeconds(0.5f);//0.5����

                        Debug.Log("4�� ����Ǿ��� ����");

                       // Rotate_board.transform.Rotate(0f, 0f, 180f);
                        // ���� ��ġ�� (0, 15.6)���� ����
                        board.anchoredPosition = new Vector2(0f, 12.9f);//0.0���µ�
                        //0.0�̾���


                        Go_Player1_B.SetActive(false); ;//���
                        Go_Player2_B.SetActive(true);

                        //0813
                        blue.SetActive(false);
                        pink.SetActive(true);
                        //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                        //08.07.���� �߰�
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

                        //08.11.��
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
                        //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
                    }
                }
                
            }

        }


        else//�̰� ���� �� ������ �����غ��� �̻��ϸ� ����� 
        {
            if (Click_Button.Click_Count < 3)//4����
            {
                Click_Button.Click_Count++;//1�� �߰�
                Click_Button.UpdateClickCountText();

                StartCoroutine(Go_Player_1());

                IEnumerator Go_Player_1()
                {
                    yield return new WaitForSeconds(0.0f);//0.5����

                    Rotate_board.transform.Rotate(0f, 0f, 180f);
                    board.anchoredPosition = new Vector2(0f, 0.0f);//0.0���µ�
                    //1�� �� z�� 0���� ������

                    Go_Player1_B.SetActive(true); ;//���
                    Go_Player2_B.SetActive(false);

                    //0813
                    blue.SetActive(true);
                    pink.SetActive(false);
                    //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                    //08.11.��
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
                    //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
                }
            }

            //���� ���� ���� �� 0814
            else if (Click_Button.Click_Count ==3)//3
            {
                Debug.Log("��ũ Ŭ�� ī��Ʈ 4���Ͷ� ��");

                Click_Button.Click_Count++;//1�� �߰�
                Click_Button.UpdateClickCountText();

                StartCoroutine(Go_Player_1());

                IEnumerator Go_Player_1()
                {
                    yield return new WaitForSeconds(0.0f);//0.5����

                    //Rotate_board.transform.Rotate(0f, 0f, 180f);
                    board.anchoredPosition = new Vector2(0f, 12.9f);//0.0���µ�
                    //1�� �� z�� 0���� ������

                    Go_Player1_B.SetActive(false); //���
                    Go_Player2_B.SetActive(true);

                    //0813
                    blue.SetActive(false);
                    pink.SetActive(true);
                    //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                    //08.11.��
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
                    //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
                }
            }

            //���� ���� �ִ� ��
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//���� ĭ�� ���� 2�� ���� ��
                {
                    //��ũ
                    upgrade_tile.No_Double_Player();
                }

                else
                {

                    Click_Button.Click_Count++;//1�� �߰�
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
                        yield return new WaitForSeconds(2.8f);//0.5����

                        Debug.Log("5�� ����Ǿ��� ����");

                      

                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        board.anchoredPosition = new Vector2(0f, 0.0f);//0.0���µ�
                                                                     //1�� �� z�� 0���� ������

                        Go_Player1_B.SetActive(true); ;//���
                        Go_Player2_B.SetActive(false);

                        //0813
                        blue.SetActive(true);
                        pink.SetActive(false);
                        //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                        //08.07.���� �߰�
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

                        //08.11.��
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
                        //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//���� ĭ�� ���� 2�� ���� ��
                {
                    //��ũ
                    upgrade_tile.No_Double_Player();
                }

                else
                {


                    Click_Button.Click_Count++;//1�� �߰�
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
                        yield return new WaitForSeconds(0.5f);//0.5����

                        Debug.Log("6�� ����Ǿ��� ����");

                       


                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        board.anchoredPosition = new Vector2(0f, 0.0f);//0.0���µ�
                                                                     //1�� �� z�� 0���� ������

                        Go_Player1_B.SetActive(true); ;//���
                        Go_Player2_B.SetActive(false);

                        //0813
                        blue.SetActive(true);
                        pink.SetActive(false);
                        //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                        //08.07.���� �߰�
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

                        //08.11.��
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
                        //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
                    }
                }
                
            }
 
        }



        Plate_Back.anchoredPosition = new Vector2(1.0f, 3.8147e-05f);
    }

    //
    public void Go_Player2()//��翡�� ��ũ��
    {

        Debug.Log("�������� ����");

        //PC������ ����Ǵ� �ڵ��Դϴ�
        //Ȯ��, ��� �ڵ�
        /*zoom.isZoomedIn = false;//���� ���°� �ƴ�
        zoom.zoomCount = 0; //¦����°
        zoom.ZoomOut();//�� �ƿ�
        */
        zoom.ResetToOriginalSize();

        //12.9���� z���� 180�� ���ư� ��Ȳ�̾��� ���� ��ư ������ 12.9�� �ƹ� ȸ���� ���� �� �����µ�
        //0, 0, 0��ġ�� �ƹ� ȸ���� ���°ſ��� ��

        Vector2 currentPosition = board.anchoredPosition;//���� ������Ʈ ��ġ�� �����ͼ� currentPosition�� ����

        // ���� ���� ��ġ�� (0, 0)���
        if (currentPosition.x == 0 && currentPosition.y == 0)
        {


            if (Click_Button.Click_Count < 3)
            {
                Click_Button.Click_Count++;//1�� �߰�
                Click_Button.UpdateClickCountText();
                StartCoroutine(Go_Player_1_1());

                IEnumerator Go_Player_1_1()
                {
                    yield return new WaitForSeconds(0.0f);//0.5����

                    Rotate_board.transform.Rotate(0f, 0f, 180f);
                    // ���� ��ġ�� (0, 15.6)���� ����
                    board.anchoredPosition = new Vector2(0f, 12.9f);//15.6���µ�


                    Go_Player1_B.SetActive(false);//���
                    Go_Player2_B.SetActive(true);
                    //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                    //0813
                    blue.SetActive(false);
                    pink.SetActive(true);

                    //Player1_Cup.SetActive(true);
                    //Player2_Cup.SetActive(false);
                    //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)

                    //08.11.��
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
            
            //���� ���� 0822
            else if (Click_Button.Click_Count == 3)
            {
                Click_Button.Click_Count++;//1�� �߰�
                Click_Button.UpdateClickCountText();
                StartCoroutine(Go_Player_1_1());

                Debug.Log("�̰� ����Ǿ�� �ϴµ�");

                IEnumerator Go_Player_1_1()
                {
                    yield return new WaitForSeconds(0.0f);//0.5����

                    //Rotate_board.transform.Rotate(0f, 0f, 180f);
                    // ���� ��ġ�� (0, 15.6)���� ����
                    board.anchoredPosition = new Vector2(0f, 0.0f);//15.6���µ�


                    Go_Player1_B.SetActive(true);//���
                    Go_Player2_B.SetActive(false);
                    //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                    //0813
                    blue.SetActive(true);
                    pink.SetActive(false);

                    //Player1_Cup.SetActive(true);
                    //Player2_Cup.SetActive(false);
                    //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)

                    //08.11.��
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
                || card_move.Blue_Fourth_Line[6].transform.childCount == 1))//Ŭ�� ī��Ʈ�� 4 �̻��� �� //4��° �� �ڽ��� �ִ°� �ϳ� �̻��� ��
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//���� ĭ�� ���� 2�� ���� ��
                {
                    //��ũ
                    upgrade_tile.No_Double_Player();
                }

                else
                {
                    Click_Button.Click_Count++;//1�� �߰�
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
                        yield return new WaitForSeconds(2.8f);//0.5����

                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        // ���� ��ġ�� (0, 15.6)���� ����
                        board.anchoredPosition = new Vector2(0f, 12.9f);//15.6���µ�



                        Go_Player1_B.SetActive(false);//���
                        Go_Player2_B.SetActive(true);
                        //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                        //08.07.���� �߰�
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

                        //08.11.��
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
                        //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
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
                && card_move.Blue_Fourth_Line[6].transform.childCount == 0)//Ŭ�� ī��Ʈ�� 4 �̻��� �� //4��° �� �ڽ��� �ִ°� �ϳ��� ���� ���
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//���� ĭ�� ���� 2�� ���� ��
                {
                    //��ũ
                    upgrade_tile.No_Double_Player();
                }

                else
                {


                    Click_Button.Click_Count++;//1�� �߰�
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
                        yield return new WaitForSeconds(0.5f);//0.5����

                        Debug.Log("2�� ����Ǿ��� ����");

                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        // ���� ��ġ�� (0, 15.6)���� ����
                        board.anchoredPosition = new Vector2(0f, 12.9f);//12.9���µ�



                        Go_Player1_B.SetActive(false); //���
                        Go_Player2_B.SetActive(true);
                        //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                        //08.07.���� �߰�
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

                        //08.11.��
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
                        //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
                    }
                }

            }

        }

        //�����ϰ� �ִ°�
        else if (currentPosition.x == 0 && currentPosition.y == 12.9)
        {


            if (Click_Button.Click_Count < 4)//4����
            {
                Click_Button.Click_Count++;//1�� �߰�
                Click_Button.UpdateClickCountText();

                StartCoroutine(Go_Player_1_2());

                IEnumerator Go_Player_1_2()
                {
                    yield return new WaitForSeconds(0.0f);//0.5����




                    Rotate_board.transform.Rotate(0f, 0f, 180f);
                    // ���� ��ġ�� (0, 15.6)���� ����
                    board.anchoredPosition = new Vector2(0f, 0f);//0.0���µ�

                    Go_Player1_B.SetActive(false); ;//���
                    Go_Player2_B.SetActive(true);

                    //0813
                    blue.SetActive(false);
                    pink.SetActive(true);



                    //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                    //08.11.��
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
                    //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
                }
            }

            //�����߰� 0814
            //3�϶�
            else if (Click_Button.Click_Count == 3)
            {
                Click_Button.Click_Count++;//1�� �߰�
                Click_Button.UpdateClickCountText();

                //Debug.Log("��ũ �󸸵�" + Click_Button.Click_Count);
                //������� ����

                StartCoroutine(Go_Player_1_2());

                IEnumerator Go_Player_1_2()
                {
                    yield return new WaitForSeconds(0.0f);//0.5����


                    //Rotate_board.transform.Rotate(0f, 0f, 180f);
                    // ���� ��ġ�� (0, 15.6)���� ����
                    board.anchoredPosition = new Vector2(0f, 0.0f);//0.0���µ�

                    Go_Player1_B.SetActive(true); //���
                    Go_Player2_B.SetActive(false);

                    //0813
                    blue.SetActive(true);
                    pink.SetActive(false);



                    //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                    //08.11.��
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
                    //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
                }
            }

            //���� �Ʒ����ʹ� ���� �ִ� ��

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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//���� ĭ�� ���� 2�� ���� ��
                {
                    //��ũ
                    upgrade_tile.No_Double_Player();
                }

                else
                {


                    Click_Button.Click_Count++;//1�� �߰�
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
                        yield return new WaitForSeconds(2.8f);//0.5����

                        Debug.Log("3�� ����Ǿ��� ����");




                        //Rotate_board.transform.Rotate(0f, 0f, 180f);
                        // ���� ��ġ�� (0, 15.6)���� ����
                        board.anchoredPosition = new Vector2(0f, 12.9f);//0.0���µ�

                        Go_Player1_B.SetActive(false); ;//���
                        Go_Player2_B.SetActive(true);
                        //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                        //08.07.���� �߰�
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

                        //08.11.��
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
                        //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//���� ĭ�� ���� 2�� ���� ��
                {
                    //��ũ
                    upgrade_tile.No_Double_Player();
                }

                else
                {

                    Click_Button.Click_Count++;//1�� �߰�
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
                        yield return new WaitForSeconds(0.5f);//0.5����

                        Debug.Log("4�� ����Ǿ��� ����");

                        // Rotate_board.transform.Rotate(0f, 0f, 180f);
                        // ���� ��ġ�� (0, 15.6)���� ����
                        board.anchoredPosition = new Vector2(0f, 12.9f);//0.0���µ�
                        //0.0�̾���


                        Go_Player1_B.SetActive(false); ;//���
                        Go_Player2_B.SetActive(true);

                        //0813
                        blue.SetActive(false);
                        pink.SetActive(true);
                        //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                        //08.07.���� �߰�
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

                        //08.11.��
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
                        //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
                    }
                }

            }

        }


        else//�̰� ���� �� ������ �����غ��� �̻��ϸ� ����� 
        {
            if (Click_Button.Click_Count < 3)//4����
            {
                Click_Button.Click_Count++;//1�� �߰�
                Click_Button.UpdateClickCountText();

                StartCoroutine(Go_Player_1());

                IEnumerator Go_Player_1()
                {
                    yield return new WaitForSeconds(0.0f);//0.5����

                    Rotate_board.transform.Rotate(0f, 0f, 180f);
                    board.anchoredPosition = new Vector2(0f, 12.9f);//0.0���µ�
                    //1�� �� z�� 0���� ������

                    Go_Player1_B.SetActive(false); ;//���
                    Go_Player2_B.SetActive(true);

                    //0813
                    blue.SetActive(false);
                    pink.SetActive(true);
                    //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                    //08.11.��
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
                    //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
                }
            }

            //���� ���� ���� �� 0814
            else if (Click_Button.Click_Count == 3)//3
            {
                Debug.Log("��� Ŭ�� ī��Ʈ 4���Ͷ� ��");

                Click_Button.Click_Count++;//1�� �߰�
                Click_Button.UpdateClickCountText();

                StartCoroutine(Go_Player_1());

                IEnumerator Go_Player_1()
                {
                    yield return new WaitForSeconds(0.0f);//0.5����

                    Rotate_board.transform.Rotate(0f, 0f, 180f);
                    board.anchoredPosition = new Vector2(0f, 0.0f);//0.0���µ�
                    //1�� �� z�� 0���� ������

                    Go_Player1_B.SetActive(true); //���
                    Go_Player2_B.SetActive(false);

                    //0813
                    blue.SetActive(true);
                    pink.SetActive(false);
                    //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                    //08.11.��
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
                    //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
                }
            }

            //���� ���� �ִ� ��
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//���� ĭ�� ���� 2�� ���� ��
                {
                    //��ũ
                    upgrade_tile.No_Double_Player();
                }

                else
                {

                    Click_Button.Click_Count++;//1�� �߰�
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
                        yield return new WaitForSeconds(2.8f);//0.5����

                        Debug.Log("5�� ����Ǿ��� ����");



                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        board.anchoredPosition = new Vector2(0f, 12.9f);//0.0���µ�
                                                                       //1�� �� z�� 0���� ������

                        Go_Player1_B.SetActive(false); ;//���
                        Go_Player2_B.SetActive(true);

                        //0813
                        blue.SetActive(false);
                        pink.SetActive(true);
                        //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                        //08.07.���� �߰�
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

                        //08.11.��
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
                        //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//���� ĭ�� ���� 2�� ���� ��
                {
                    //��ũ
                    upgrade_tile.No_Double_Player();
                }

                else
                {


                    Click_Button.Click_Count++;//1�� �߰�
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
                        yield return new WaitForSeconds(0.5f);//0.5����

                        Debug.Log("6�� ����Ǿ��� ����");




                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        board.anchoredPosition = new Vector2(0f, 12.9f);//0.0���µ�
                                                                       //1�� �� z�� 0���� ������

                        Go_Player1_B.SetActive(false); ;//���
                        Go_Player2_B.SetActive(true);

                        //0813
                        blue.SetActive(false);
                        pink.SetActive(true);
                        //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                        //08.07.���� �߰�
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

                        //08.11.��
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
                        //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
                    }
                }

            }

        }



        Plate_Back.anchoredPosition = new Vector2(1.0f, 3.8147e-05f);
    }

    /*public void Go_Player2()//��� Ȯ��
    {

        Vector2 currentPosition = board.anchoredPosition;//���� ������Ʈ ��ġ�� �����ͼ� currentPosition�� ����

        // ���� ���� ��ġ�� (0, 15.6)���
        if (currentPosition.x == 0 && currentPosition.y == 12.9f)
        {
            if (Click_Button.Click_Count < 4)
            {
                Click_Button.Click_Count++;//1�� �߰�
                Click_Button.UpdateClickCountText();

                StartCoroutine(Go_Player_2_1());

                IEnumerator Go_Player_2_1()
                {
                    yield return new WaitForSeconds(0.0f);//0.5����

                    

                    Rotate_board.transform.Rotate(0f, 0f, 180f);
                    // ���� ��ġ�� (0, 0)���� ����
                    board.anchoredPosition = new Vector2(0f, 0);//-0.1f���µ�

                    Go_Player2_B.SetActive(true);
                    Go_Player1_B.SetActive(false); ;//���
                                                    //1�� �� ���� �� ��ư�� 2�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                    //0813
                    blue.SetActive(false);
                    pink.SetActive(true);
                    //Player2_Cup.SetActive(true);
                    //Player1_Cup.SetActive(false);
                    //1�� �� �� 2�÷��̾� �ɷ� �ٲٱ�(����� �� �ҷ�����)

                    //08.11.��
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
                || card_move.Blue_Fourth_Line[6].transform.childCount == 1))//Ŭ�� ī��Ʈ�� 4 �̻��� �� //4��° �� �ڽ��� �ִ°� �ϳ� �̻��� ��
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//���� ĭ�� ���� 2�� ���� ��
                {
                    //���
                    upgrade_tile_blue.No_Double_Player();
                }

                else
                {



                    Click_Button.Click_Count++;//1�� �߰�
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
                        yield return new WaitForSeconds(2.8f);//0.5����

                        Debug.Log("7�� ����Ǿ��� ����");

                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        // ���� ��ġ�� (0, 0)���� ����
                        board.anchoredPosition = new Vector2(0f, 0);//-0.1f���µ�

                        Go_Player2_B.SetActive(true);
                        Go_Player1_B.SetActive(false); ;//���
                                                        //1�� �� ���� �� ��ư�� 2�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                        //08.07.���� �߰�
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

                        //08.11.��
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
                        //1�� �� �� 2�÷��̾� �ɷ� �ٲٱ�(����� �� �ҷ�����)
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
                && card_move.Blue_Fourth_Line[6].transform.childCount == 0))//Ŭ�� ī��Ʈ�� 4 �̻��� �� //4��° �� �ڽ��� �ִ°� �ϳ� �̻��� ��
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//���� ĭ�� ���� 2�� ���� ��
                {
                    //���
                    upgrade_tile_blue.No_Double_Player();
                }

                else
                {



                    Click_Button.Click_Count++;//1�� �߰�
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
                        yield return new WaitForSeconds(0.5f);//0.5����

                        Debug.Log("8�� ����Ǿ��� ����");

                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        // ���� ��ġ�� (0, 0)���� ����
                        board.anchoredPosition = new Vector2(0f, 0);//-0.1f���µ�

                        Go_Player2_B.SetActive(true);
                        Go_Player1_B.SetActive(false); ;//���
                                                        //1�� �� ���� �� ��ư�� 2�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                        //Player2_Cup.SetActive(true);
                        //Player1_Cup.SetActive(false);
                        //1�� �� �� 2�÷��̾� �ɷ� �ٲٱ�(����� �� �ҷ�����)

                        //08.07.���� �߰�
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

                        //08.11.��
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
            if (Click_Button.Click_Count < 3)//4����
            {
                Click_Button.Click_Count++;//1�� �߰�
                Click_Button.UpdateClickCountText();

                StartCoroutine(Go_Player_2());
                //StartCoroutine(RotateAndMove2());


                IEnumerator Go_Player_2()
                {
                    yield return new WaitForSeconds(0.0f);//0.5����

                  


                    // ������Ʈ�� z������ 180�� ȸ��
                    Rotate_board.transform.Rotate(0f, 0f, 180f);
                    board.anchoredPosition = new Vector2(0f, 12.9f);//12.9���µ�

                    Go_Player2_B.SetActive(true);
                    Go_Player1_B.SetActive(false); ;//���

                    //0813
                    blue.SetActive(false);
                    pink.SetActive(true);

                    //08.11.��
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
                    //1�� �� ���� �� ��ư�� 2�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                    //Player2_Cup.SetActive(true);
                    //Player1_Cup.SetActive(false);
                    //1�� �� �� 2�÷��̾� �ɷ� �ٲٱ�(����� �� �ҷ�����)

                }
            }

            //����� ���� �߰��� ��0814
            else if (Click_Button.Click_Count == 3)
            {
                Debug.Log("�̰� ����Ǹ� �ȵ�");

                //Click_Button.Click_Count++;//1�� �߰�
                //Click_Button.UpdateClickCountText();

                Debug.Log("��� �󸸵� ��" + Click_Button.Click_Count);

                Click_Button.Click_Count++;//1�� �߰�
                Click_Button.UpdateClickCountText();

                Debug.Log("��� �󸸵� ��" + Click_Button.Click_Count);

                StartCoroutine(Go_Player_2());
                //StartCoroutine(RotateAndMove2());


                IEnumerator Go_Player_2()
                {
                    yield return new WaitForSeconds(0.0f);//0.5����

                    // ������Ʈ�� z������ 180�� ȸ��
                    //Rotate_board.transform.Rotate(0f, 0f, 180f);
                    board.anchoredPosition = new Vector2(0f, 0.0f);//12.9���µ�

                    Go_Player2_B.SetActive(false);
                    Go_Player1_B.SetActive(true); //���

                    //0813
                    blue.SetActive(true);
                    pink.SetActive(false);

                    //08.11.��
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
                    //1�� �� ���� �� ��ư�� 2�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                    //Player2_Cup.SetActive(true);
                    //Player1_Cup.SetActive(false);
                    //1�� �� �� 2�÷��̾� �ɷ� �ٲٱ�(����� �� �ҷ�����)

                }
            }



            //����� ���� �־��� ��
            if (Click_Button.Click_Count > 3 &&
                (card_move.Blue_Fourth_Line[0].transform.childCount == 1
                || card_move.Blue_Fourth_Line[1].transform.childCount == 1
                || card_move.Blue_Fourth_Line[2].transform.childCount == 1
                || card_move.Blue_Fourth_Line[3].transform.childCount == 1
                || card_move.Blue_Fourth_Line[4].transform.childCount == 1
                || card_move.Blue_Fourth_Line[5].transform.childCount == 1
                || card_move.Blue_Fourth_Line[6].transform.childCount == 1))//Ŭ�� ī��Ʈ�� 4 �̻��� �� //4��° �� �ڽ��� �ִ°� �ϳ� �̻��� ��
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//���� ĭ�� ���� 2�� ���� ��
                {
                    //���
                    upgrade_tile_blue.No_Double_Player();
                }

                else
                {

                    Click_Button.Click_Count++;//1�� �߰�
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
                        yield return new WaitForSeconds(2.8f);//0.5����

                        Debug.Log("9�� ����Ǿ��� ����");

                        // ������Ʈ�� z������ 180�� ȸ��
                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        board.anchoredPosition = new Vector2(0f, 12.9f);//12.9���µ�

                        Go_Player2_B.SetActive(true);
                        Go_Player1_B.SetActive(false); //���
                                                        //1�� �� ���� �� ��ư�� 2�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                        //Player2_Cup.SetActive(true);
                        //Player1_Cup.SetActive(false);
                        //1�� �� �� 2�÷��̾� �ɷ� �ٲٱ�(����� �� �ҷ�����)

                        //08.07.���� �߰�
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

                        //08.11.��
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
                && card_move.Blue_Fourth_Line[6].transform.childCount == 0))//Ŭ�� ī��Ʈ�� 4 �̻��� �� //4��° �� �ڽ��� �ִ°� �ϳ� �̻��� ��
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//���� ĭ�� ���� 2�� ���� ��
                {
                    //���
                    upgrade_tile_blue.No_Double_Player();
                }

                else
                {



                    Click_Button.Click_Count++;//1�� �߰�
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
                        yield return new WaitForSeconds(0.5f);//0.5����


                        // Debug.Log("10�� ����Ǿ��� ����");
                        // ������Ʈ�� z������ 180�� ȸ��
                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        board.anchoredPosition = new Vector2(0f, 12.9f);//12.9���µ�

                        Go_Player2_B.SetActive(true);
                        Go_Player1_B.SetActive(false); ;//���
                                                        //1�� �� ���� �� ��ư�� 2�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                        //Player2_Cup.SetActive(true);
                        //Player1_Cup.SetActive(false);
                        //1�� �� �� 2�÷��̾� �ɷ� �ٲٱ�(����� �� �ҷ�����)

                        //08.07.���� �߰�
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

                        //08.11.��
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

        //���� �߰��غ� 0814
        else//�̰� ���� �� ������ �����غ��� �̻��ϸ� ����� 
        {
            if (Click_Button.Click_Count < 3)//4����
            {
                Debug.Log("�̰� ������ �ǳ�?");

                Click_Button.Click_Count++;//1�� �߰�
                Click_Button.UpdateClickCountText();

                StartCoroutine(Go_Player_1());

                IEnumerator Go_Player_1()
                {
                    yield return new WaitForSeconds(0.0f);//0.5����



                    Rotate_board.transform.Rotate(0f, 0f, 180f);
                    board.anchoredPosition = new Vector2(0f, 0.0f);//0.0���µ�
                    //1�� �� z�� 0���� ������

                    Go_Player1_B.SetActive(false); //���
                    Go_Player2_B.SetActive(true);

                    //0813
                    blue.SetActive(false);
                    pink.SetActive(true);
                    //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                    //08.11.��
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
                    //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
                }
            }

            //���� ���� ���� ����0814
            else if (Click_Button.Click_Count == 3)//3
            {
                Debug.Log("��� Ŭ�� ī��Ʈ 4���Ͷ� ��");

                Click_Button.Click_Count++;//1�� �߰�
                Click_Button.UpdateClickCountText();

                StartCoroutine(Go_Player_1());

                IEnumerator Go_Player_1()
                {
                    yield return new WaitForSeconds(0.0f);//0.5����

                   
                    //Rotate_board.transform.Rotate(0f, 0f, 180f);
                    board.anchoredPosition = new Vector2(0f, 0.0f);//0.0���µ�
                    //1�� �� z�� 0���� ������

                    Go_Player1_B.SetActive(true); //���
                    Go_Player2_B.SetActive(false);

                    //0813
                    blue.SetActive(true);
                    pink.SetActive(false);
                    //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                    //08.11.��
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
                    //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
                }
            }


            //���� ���� �־���
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//���� ĭ�� ���� 2�� ���� ��
                {
                    //��ũ
                    upgrade_tile.No_Double_Player();
                }

                else
                {

                    Click_Button.Click_Count++;//1�� �߰�
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
                        yield return new WaitForSeconds(2.8f);//0.5����

                        Debug.Log("5�� ����Ǿ��� ����");



                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        board.anchoredPosition = new Vector2(0f, 12.9f);//0.0���µ�
                                                                       //1�� �� z�� 0���� ������

                        Go_Player1_B.SetActive(false); //���
                        Go_Player2_B.SetActive(true);

                        //0813
                        blue.SetActive(false);
                        pink.SetActive(true);
                        //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                        //08.07.���� �߰�
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

                        //08.11.��
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
                        //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
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
                    || (move_player.Player_Positions[0].childCount != 0 && move_player.Player_Positions[1].childCount != 0))//���� ĭ�� ���� 2�� ���� ��
                {
                    //��ũ
                    upgrade_tile.No_Double_Player();
                }

                else
                {
                    Click_Button.Click_Count++;//1�� �߰�
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
                        yield return new WaitForSeconds(0.5f);//0.5����

                        Debug.Log("6�� ����Ǿ��� ����");




                        Rotate_board.transform.Rotate(0f, 0f, 180f);
                        board.anchoredPosition = new Vector2(0f, 12.9f);//0.0���µ�
                                                                       //1�� �� z�� 0���� ������

                        Go_Player1_B.SetActive(false); ;//���
                        Go_Player2_B.SetActive(transform);

                        //0813
                        blue.SetActive(false);
                        pink.SetActive(true);
                        //1�� �� ���� �� ��ư�� 1�÷��̾� �� ��Ÿ���� �ɷ� �ٲٱ�

                        //08.07.���� �߰�
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

                        //08.11.��
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
                        //1�� �� �� 1�÷��̾�ɷ� �ٲٱ�(����� �� �ҷ�����)
                    }
                }

            }
        }


        //��� ���� �־���
        Plate_Back.anchoredPosition = new Vector2(1.0f, 3.8147e-05f);

        
    }*/


}
