using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Turn_Count : MonoBehaviour
{
    public Text Button_Click;
    public int Click_Count;//���° ������ Ȯ��


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




        if (Open_Pink.activeSelf == true || Close_Pink.activeSelf == true)//��ũ�� ����
        {
            //Open_Pink.activeSelf==true || Close_Pink.activeSelf == true �̰ſ���

            //¦���ε� 0�� ���
            //�ٷ� ��Ÿ����

            //¦���ε� 0�� �ƴ� ���
            //3�� �ڿ� ����ǵ���

            //¦�� ��° Ŭ���ߴµ� ������ 0, 0, 180�̶�� ��ũ�� ��Ÿ���� �Ķ��� �����
            if (Click_Count % 2 == 0 && Click_Count != 0 && Click_Count != 2 && Click_Count != 4)//¦���� ��
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



                    //�̰� PC�϶��� ����Ǵ� �ڵ�...
                    /*BoxCollider2D boxCollider1 = objects[0].GetComponent<BoxCollider2D>();//��ũ1 �ݶ��̴�
                    boxCollider1.enabled = true;

                    BoxCollider2D boxCollider2 = objects[1].GetComponent<BoxCollider2D>();//��ũ2 �ݶ��̴�
                    boxCollider2.enabled = true;

                    BoxCollider2D boxCollider3 = objects[2].GetComponent<BoxCollider2D>();//�Ķ�1 �ݶ��̴�
                    boxCollider3.enabled = false;

                    BoxCollider2D boxCollider4 = objects[3].GetComponent<BoxCollider2D>();//�Ķ�2 �ݶ��̴�
                    boxCollider4.enabled = false;*/

                    //�Ķ� ��� ĭ�� false�ϰ� 

                    //��ȫ ��� ĭ�� true�� �����
                    /*Blue_Material_Canvas.SetActive(false);
                    Pink_Material_Canvas.SetActive(true);

                    Good_Bad_Blue.SetActive(false);
                    Good_Bad_Pink.SetActive(true);

                    Coin_Blue.SetActive(false);
                    Coin_Pink.SetActive(true);*/






                }



                if (move_count.Can_Move_Count == 0)//�÷��̾ ������ �� �ִ� ���� 0�̶��
                {
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);
                    /*BoxCollider2D boxCollider5 = objects[0].GetComponent<BoxCollider2D>();//��ũ1 �ݶ��̴�
                    boxCollider5.enabled = false;

                    BoxCollider2D boxCollider6 = objects[1].GetComponent<BoxCollider2D>();//��ũ2 �ݶ��̴�
                    boxCollider6.enabled = false;

                    BoxCollider2D boxCollider7 = objects[2].GetComponent<BoxCollider2D>();//�Ķ�1 �ݶ��̴�
                    boxCollider7.enabled = false;

                    BoxCollider2D boxCollider8 = objects[3].GetComponent<BoxCollider2D>();//�Ķ�2 �ݶ��̴�
                    boxCollider8.enabled = false;*/
                }




            }

            //07.28�߰��غ�
            else if (Click_Count != 0 && Click_Count != 2 && Click_Count == 4)//¦���� ��, 4�� ����
            {
                Debug.Log("��ũ�� ���϶� 4���");

                Blue_Material_Canvas.SetActive(false);
                Pink_Material_Canvas.SetActive(true);

                Good_Bad_Blue_1.SetActive(false);
                Good_Bad_Blue_2.SetActive(false);

                Good_Bad_Pink_1.SetActive(true);
                Good_Bad_Pink_2.SetActive(true);

                Coin_Blue_1.SetActive(false);


                Coin_Pink_1.SetActive(true);
             

                Blue_1.SetActive(false);//�Ķ� ���õ� ǥ��
                Blue_2.SetActive(false);//�Ķ� ���õ� ǥ��

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


                next_turn.Go_Player1_B.SetActive(false);//��� �� ������
                next_turn.Go_Player2_B.SetActive(true);//��ũ �� ������

                //next_turn.Rotate_board.transform.Rotate(0f, 0f, 180f);
                // ���� ��ġ�� (0, 15.6)���� ����
                //next_turn.board.anchoredPosition = new Vector2(0f, 12.9f);//15.6���µ�


                next_turn.blue.SetActive(false);//��� 
                next_turn.pink.SetActive(true);//��ũ 

                //��ũ�� �����ʿ� ������

                //blue_pink.Plate.transform.Rotate(0f, 0f, 180f);
                // blue_pink.plate.anchoredPosition = new Vector2(0f, 12.9f);//15.6�̾��µ�...


                if (move_count.Can_Move_Count == 0)//�÷��̾ ������ �� �ִ� ���� 0�̶��
                {
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);



                }




            }

            else if (Click_Count == 0 && Click_Count != 4)//¦���� ��, 0, 2�϶���
            {//�Ķ��̰� ������
                Blue_Material_Canvas.SetActive(true);
                Pink_Material_Canvas.SetActive(false);

                Good_Bad_Blue_1.SetActive(true);
                Good_Bad_Blue_2.SetActive(true);

                Good_Bad_Pink_1.SetActive(false);
                Good_Bad_Pink_2.SetActive(false);

                Coin_Blue_1.SetActive(true);
               

                Coin_Pink_1.SetActive(false);
         

                Pink_1.SetActive(false);//�Ķ� ���õ� ǥ��
                Pink_2.SetActive(false);//�Ķ� ���õ� ǥ��

                Blue_1.SetActive(false);//�Ķ� ���õ� ǥ��
                Blue_2.SetActive(true);//0�϶�

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


                if (move_count.Can_Move_Count == 0)//�÷��̾ ������ �� �ִ� ���� 0�̶��
                {
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                }




            }

            else if (Click_Count == 2 && Click_Count != 4)//¦���� ��, 0, 2�϶���
            {//�Ķ��̰� ������
                Blue_Material_Canvas.SetActive(true);
                Pink_Material_Canvas.SetActive(false);

                Good_Bad_Blue_1.SetActive(true);
                Good_Bad_Blue_2.SetActive(true);

                Good_Bad_Pink_1.SetActive(false);
                Good_Bad_Pink_2.SetActive(false);

                Coin_Blue_1.SetActive(true);
            

                Coin_Pink_1.SetActive(false);
            

                Pink_1.SetActive(false);//�Ķ� ���õ� ǥ��
                Pink_2.SetActive(false);//�Ķ� ���õ� ǥ��

                Blue_1.SetActive(true);//�Ķ� ���õ� ǥ��
                Blue_2.SetActive(false);//2�϶�

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


                if (move_count.Can_Move_Count == 0)//�÷��̾ ������ �� �ִ� ���� 0�̶��
                {
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                }




            }

            //���� ���� �ִ� ��
            else if (Click_Count % 2 != 0 && Click_Count != 1 && Click_Count != 3)//Ȧ���� ��
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




                    /*BoxCollider2D boxCollider1 = objects[0].GetComponent<BoxCollider2D>();//��ũ1 �ݶ��̴�
                    boxCollider1.enabled = false;

                    BoxCollider2D boxCollider2 = objects[1].GetComponent<BoxCollider2D>();//��ũ2 �ݶ��̴�
                    boxCollider2.enabled = false;

                    BoxCollider2D boxCollider3 = objects[2].GetComponent<BoxCollider2D>();//�Ķ�1 �ݶ��̴�
                    boxCollider3.enabled = true;

                    BoxCollider2D boxCollider4 = objects[3].GetComponent<BoxCollider2D>();//�Ķ�2 �ݶ��̴�
                    boxCollider4.enabled = true;*/

                    //�Ķ� ��� ĭ�� true�ϰ� 
                    //��ȫ ��� ĭ�� false�� �����

                    /*Blue_Material_Canvas.SetActive(true);
                    Pink_Material_Canvas.SetActive(false);

                    Good_Bad_Blue.SetActive(true);
                    Good_Bad_Pink.SetActive(false);

                    Coin_Blue.SetActive(true);
                    Coin_Pink.SetActive(false);*/


                }






                if (move_count.Can_Move_Count == 0)//�÷��̾ ������ �� �ִ� ���� 0�̶��
                {
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                    /* BoxCollider2D boxCollider5 = objects[0].GetComponent<BoxCollider2D>();//��ũ1 �ݶ��̴�
                     boxCollider5.enabled = false;

                     BoxCollider2D boxCollider6 = objects[1].GetComponent<BoxCollider2D>();//��ũ2 �ݶ��̴�
                     boxCollider6.enabled = false;

                     BoxCollider2D boxCollider7 = objects[2].GetComponent<BoxCollider2D>();//�Ķ�1 �ݶ��̴�
                     boxCollider7.enabled = false;

                     BoxCollider2D boxCollider8 = objects[3].GetComponent<BoxCollider2D>();//�Ķ�2 �ݶ��̴�
                     boxCollider8.enabled = false;*/
                }


            }

            //07.28.�߰��غ�
            else if (Click_Count == 1)//Ȧ���� ��
            {//��ȫ�� ������

                Blue_1.SetActive(false);
                Blue_2.SetActive(false);

                Pink_1.SetActive(false);
                Pink_2.SetActive(true);

                //�Ķ� ��� ĭ�� true�ϰ� 
                //��ȫ ��� ĭ�� false�� �����

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

                if (move_count.Can_Move_Count == 0)//�÷��̾ ������ �� �ִ� ���� 0�̶��
                {
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                }


            }

            else if (Click_Count == 3)//Ȧ���� ��
            {//��ȫ�� ������



                Blue_1.SetActive(false);
                Blue_2.SetActive(false);

                Pink_1.SetActive(true);
                Pink_2.SetActive(false);

                //�Ķ� ��� ĭ�� true�ϰ� 
                //��ȫ ��� ĭ�� false�� �����

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

                if (move_count.Can_Move_Count == 0)//�÷��̾ ������ �� �ִ� ���� 0�̶��
                {
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                }


            }
        }

        if (Open_Blue.activeSelf == true || Close_Blue.activeSelf == true)//��簡 ����
        {
            //Open_Blue.activeSelf == true || Close_Blue.activeSelf == true �̰ſ���

            //¦����° Ŭ���ߴµ� ������ 0, 0, 0�̶�� �Ķ��� ��Ÿ���� ��ȫ �����
            if (Click_Count % 2 == 0 && Click_Count != 0 && Click_Count != 2 && Click_Count != 4)//¦���� ��
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



                    /*BoxCollider2D boxCollider1 = objects[0].GetComponent<BoxCollider2D>();//��ũ1 �ݶ��̴�
                    boxCollider1.enabled = false;

                    BoxCollider2D boxCollider2 = objects[1].GetComponent<BoxCollider2D>();//��ũ2 �ݶ��̴�
                    boxCollider2.enabled = false;

                    BoxCollider2D boxCollider3 = objects[2].GetComponent<BoxCollider2D>();//�Ķ�1 �ݶ��̴�
                    boxCollider3.enabled = true;

                    BoxCollider2D boxCollider4 = objects[3].GetComponent<BoxCollider2D>();//�Ķ�2 �ݶ��̴�
                    boxCollider4.enabled = true;*/

                    //�Ķ� ��� ĭ�� true�ϰ� 
                    //��ȫ ��� ĭ�� false�� �����

                    /* Blue_Material_Canvas.SetActive(true);
                     Pink_Material_Canvas.SetActive(false);

                     Good_Bad_Blue.SetActive(true);
                     Good_Bad_Pink.SetActive(false);

                     Coin_Blue.SetActive(true);
                     Coin_Pink.SetActive(false);*/


                }




                if (move_count.Can_Move_Count == 0)//�÷��̾ ������ �� �ִ� ���� 0�̶��
                {
                    /*BoxCollider2D boxCollider5 = objects[0].GetComponent<BoxCollider2D>();//��ũ1 �ݶ��̴�
                    boxCollider5.enabled = false;

                    BoxCollider2D boxCollider6 = objects[1].GetComponent<BoxCollider2D>();//��ũ2 �ݶ��̴�
                    boxCollider6.enabled = false;

                    BoxCollider2D boxCollider7 = objects[2].GetComponent<BoxCollider2D>();//�Ķ�1 �ݶ��̴�
                    boxCollider7.enabled = false;

                    BoxCollider2D boxCollider8 = objects[3].GetComponent<BoxCollider2D>();//�Ķ�2 �ݶ��̴�
                    boxCollider8.enabled = false;*/

                    Pink_1.SetActive(false);//���� ���õ� ǥ��
                    Pink_2.SetActive(false);//���� ���õ� ǥ��
                    Blue_1.SetActive(false);//�Ķ� ���õ� ǥ��
                    Blue_2.SetActive(false);//�Ķ� ���õ� ǥ��
                }
            }

            //07.28.�߰��غ�
            if (Click_Count != 0 && Click_Count != 2 && Click_Count == 4 && Click_Count % 2 == 0)//¦���� ��, 4�϶���
            {
                Pink_1.SetActive(false);//���� ���õ� ǥ��
                Pink_2.SetActive(false);//���� ���õ� ǥ��

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

                next_turn.Go_Player1_B.SetActive(true);//��� �� ������
                next_turn.Go_Player2_B.SetActive(false);//��ũ �� ������

                next_turn.blue.SetActive(true);//��� 
                next_turn.pink.SetActive(false);//��ũ 

                // next_turn.Rotate_board.transform.Rotate(0f, 0f, 180f);
                // ���� ��ġ�� (0, 15.6)���� ����
                //next_turn.board.anchoredPosition = new Vector2(0f, 0f);//15.6���µ�

                if (move_count.Can_Move_Count == 0)//�÷��̾ ������ �� �ִ� ���� 0�̶��
                {

                    Pink_1.SetActive(false);//���� ���õ� ǥ��
                    Pink_2.SetActive(false);//���� ���õ� ǥ��
                    Blue_1.SetActive(false);//�Ķ� ���õ� ǥ��
                    Blue_2.SetActive(false);//�Ķ� ���õ� ǥ��


                }

            }



            //4 �ƴҶ�
            else if (Click_Count == 0 && Click_Count != 4)
            {//��ȫ�� �� ����ǵ���
                Blue_1.SetActive(false);//���� ���õ� ǥ��
                Blue_2.SetActive(false);//���� ���õ� ǥ��

                Pink_1.SetActive(false);//���� ���õ� ǥ��
                Pink_2.SetActive(true);//���� ���õ� ǥ��

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



                if (move_count.Can_Move_Count == 0)//�÷��̾ ������ �� �ִ� ���� 0�̶��
                {

                    Pink_1.SetActive(false);//���� ���õ� ǥ��
                    Pink_2.SetActive(false);//���� ���õ� ǥ��
                    Blue_1.SetActive(false);//�Ķ� ���õ� ǥ��
                    Blue_2.SetActive(false);//�Ķ� ���õ� ǥ��
                }

            }

            if (Click_Count == 2 && Click_Count != 4)
            {//��ȫ�� �� ����ǵ���
                Blue_1.SetActive(false);//���� ���õ� ǥ��
                Blue_2.SetActive(false);//���� ���õ� ǥ��

                Pink_1.SetActive(true);//���� ���õ� ǥ��
                Pink_2.SetActive(false);//���� ���õ� ǥ��

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



                if (move_count.Can_Move_Count == 0)//�÷��̾ ������ �� �ִ� ���� 0�̶��
                {

                    Pink_1.SetActive(false);//���� ���õ� ǥ��
                    Pink_2.SetActive(false);//���� ���õ� ǥ��
                    Blue_1.SetActive(false);//�Ķ� ���õ� ǥ��
                    Blue_2.SetActive(false);//�Ķ� ���õ� ǥ��
                }

            }

            //���� ���� �ִ� ��
            else if (Click_Count % 2 != 0 && Click_Count != 1 && Click_Count != 3)//Ȧ���� ��
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



                    /*BoxCollider2D boxCollider1 = objects[0].GetComponent<BoxCollider2D>();//��ũ1 �ݶ��̴�
                    boxCollider1.enabled = true;

                    BoxCollider2D boxCollider2 = objects[1].GetComponent<BoxCollider2D>();//��ũ2 �ݶ��̴�
                    boxCollider2.enabled = true;

                    BoxCollider2D boxCollider3 = objects[2].GetComponent<BoxCollider2D>();//�Ķ�1 �ݶ��̴�
                    boxCollider3.enabled = false;

                    BoxCollider2D boxCollider4 = objects[3].GetComponent<BoxCollider2D>();//�Ķ�2 �ݶ��̴�
                    boxCollider4.enabled = false;*/

                    //�Ķ� ��� ĭ�� false�ϰ� 
                    //��ȫ ��� ĭ�� true�� �����

                    /*Blue_Material_Canvas.SetActive(false);
                     Pink_Material_Canvas.SetActive(true);

                     Good_Bad_Blue.SetActive(false);
                     Good_Bad_Pink.SetActive(true);

                     Coin_Blue.SetActive(false);
                     Coin_Pink.SetActive(true);*/


                }




                if (move_count.Can_Move_Count == 0)//�÷��̾ ������ �� �ִ� ���� 0�̶��
                {
                    /*BoxCollider2D boxCollider5 = objects[0].GetComponent<BoxCollider2D>();//��ũ1 �ݶ��̴�
                    boxCollider5.enabled = false;

                    BoxCollider2D boxCollider6 = objects[1].GetComponent<BoxCollider2D>();//��ũ2 �ݶ��̴�
                    boxCollider6.enabled = false;

                    BoxCollider2D boxCollider7 = objects[2].GetComponent<BoxCollider2D>();//�Ķ�1 �ݶ��̴�
                    boxCollider7.enabled = false;

                    BoxCollider2D boxCollider8 = objects[3].GetComponent<BoxCollider2D>();//�Ķ�2 �ݶ��̴�
                    boxCollider8.enabled = false;*/

                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);
                }



            }

            //07.28.���� �߰�
            else if (Click_Count == 1 && Click_Count != 3)//Ȧ���� ��
            {
                //�Ķ��̰� ����Ǿ�� ��
                Pink_1.SetActive(false);
                Pink_2.SetActive(false);

                Pink_1.SetActive(false);
                Pink_2.SetActive(true);

                //�Ķ� ��� ĭ�� false�ϰ� 
                //��ȫ ��� ĭ�� true�� �����

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


                if (move_count.Can_Move_Count == 0)//�÷��̾ ������ �� �ִ� ���� 0�̶��
                {
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);
                }

            }

            else if (Click_Count == 3 && Click_Count != 1)//Ȧ���� ��
            {
                //�Ķ��̰� ����Ǿ�� ��
                Pink_1.SetActive(false);
                Pink_2.SetActive(false);

                Pink_1.SetActive(true);
                Pink_2.SetActive(false);

                //�Ķ� ��� ĭ�� false�ϰ� 
                //��ȫ ��� ĭ�� true�� �����

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


                if (move_count.Can_Move_Count == 0)//�÷��̾ ������ �� �ִ� ���� 0�̶��
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
    {//�� �� Ŭ���ߴ��� Ȯ���ϱ� ���� ���� �ڵ�
        Button_Click.text = " " + Click_Count.ToString();

        if (Click_Count == 1)//���� Ŭ�� ī��Ʈ�� 0, 1, 2, 3�̶�� 
        {
            move_count.Can_Move_Count = 1;
        }

        if (Click_Count == 2)//���� Ŭ�� ī��Ʈ�� 0, 1, 2, 3�̶�� 
        {
            move_count.Can_Move_Count = 1;
        }

        if (Click_Count == 3)//���� Ŭ�� ī��Ʈ�� 0, 1, 2, 3�̶�� 
        {
            move_count.Can_Move_Count = 1;
        }

        if (Click_Count > 3)//���� Ŭ�� ī��Ʈ�� 4�̻� �̶�� 
        {
            move_count.Can_Move_Count = 3;
        }
    }

    public void Down_Card()//���� �� �Ǹ� ī�� �Ʒ��� �ѱ�� �� //�� �ѱ�� ��ư�� �߰��� ����
    {
        //Ŭ�� ī��Ʈ�� 0, 1, 2, 3�϶��� �ڸ� �״�� ����

        //Ŭ�� ī��Ʈ�� 4 �̻��̸鼭 
        //Ŭ�� ī��Ʈ�� 0, 1, 2, 3�϶� 0, 2���� ��ȫ ��ᰡ true���ٸ� 
        //��ư ������ ���� ī�� �� ĭ�� �������� 4��° �ٿ� �ִ� �Ŵ� Bad ���ڷ� �ű��

        //Bad�Ǳ� ���� ���� ���ڱ��� �Ÿ��� �� �����Ű�� �ʹ�

        if (Open_Pink.activeSelf == true || Close_Pink.activeSelf == true)//��ũ�� ����
                                                                          // Open_Pink.activeSelf == true || Close_Pink.activeSelf == true �̰ſ��� 

        //������ 0
        {

            //¦�� ��° Ŭ���ߴµ� ������ 0, 0, 180�̶�� ��ũ�� ��Ÿ���� �Ķ��� �����
            if (Click_Count % 2 == 0 && Click_Count != 0 && Click_Count != 2 && Click_Count > 4)//¦���̸鼭 0, 2�� �ƴ϶��
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


                        //���⿡ �� �־�� �� ��

                        StartCoroutine(Go_Next());


                        IEnumerator Go_Next()
                        {
                            yield return new WaitForSeconds(2.8f);

                            Blue_1.SetActive(false);
                            Blue_2.SetActive(false);

                            //�Ķ� ��� ĭ�� false�ϰ� 

                            //��ȫ ��� ĭ�� true�� �����

                            Blue_Material_Canvas.SetActive(false);
                            Pink_Material_Canvas.SetActive(true);//��ȫ ��� true
                                                                 //�� ���� ��ȫ���� ��ġ�� �ű�ų� �ִϸ��̼��� ����Ǽ��� �ȵ�

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

                        //���⿡ �� �־�� �� ��

                        StartCoroutine(Go_Next());


                        IEnumerator Go_Next()
                        {
                            yield return new WaitForSeconds(0.5f);

                            Blue_1.SetActive(false);
                            Blue_2.SetActive(false);

                            //�Ķ� ��� ĭ�� false�ϰ� 

                            //��ȫ ��� ĭ�� true�� �����

                            Blue_Material_Canvas.SetActive(false);
                            Pink_Material_Canvas.SetActive(true);//��ȫ ��� true
                                                                 //�� ���� ��ȫ���� ��ġ�� �ű�ų� �ִϸ��̼��� ����Ǽ��� �ȵ�

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

                    //�Ķ� ��� ĭ�� false�ϰ� 

                    //��ȫ ��� ĭ�� true�� �����

                    Blue_Material_Canvas.SetActive(false);
                    Pink_Material_Canvas.SetActive(true);//��ȫ ��� true
                                                         //�� ���� ��ȫ���� ��ġ�� �ű�ų� �ִϸ��̼��� ����Ǽ��� �ȵ�

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


            else if (Click_Count != 0 && Click_Count == 2)// 0, 2���
            {//��ũ�� ������ �� �Ķ��� ���� ����Ǿ�� ��
                StartCoroutine(Go_Next());


                IEnumerator Go_Next()
                {
                    yield return new WaitForSeconds(0.0f);

                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);

                    Blue_1.SetActive(true);
                    Blue_2.SetActive(false);

                    //�Ķ� ��� ĭ�� false�ϰ� 

                    //��ȫ ��� ĭ�� true�� �����

                    Blue_Material_Canvas.SetActive(true);
                    Pink_Material_Canvas.SetActive(false);//��ȫ ��� true
                                                          //�� ���� ��ȫ���� ��ġ�� �ű�ų� �ִϸ��̼��� ����Ǽ��� �ȵ�

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

            else if (Click_Count == 0 && Click_Count != 2)// 0, 2���
            {//��ũ�� ������ �� �Ķ��� ���� ����Ǿ�� ��
                StartCoroutine(Go_Next());


                IEnumerator Go_Next()
                {
                    yield return new WaitForSeconds(0.0f);

                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);

                    Blue_1.SetActive(false);
                    Blue_2.SetActive(true);

                    //�Ķ� ��� ĭ�� false�ϰ� 

                    //��ȫ ��� ĭ�� true�� �����

                    Blue_Material_Canvas.SetActive(true);
                    Pink_Material_Canvas.SetActive(false);//��ȫ ��� true
                                                          //�� ���� ��ȫ���� ��ġ�� �ű�ų� �ִϸ��̼��� ����Ǽ��� �ȵ�

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
            else if (Click_Count != 0 && Click_Count != 2 && Click_Count == 4)// 4���
            {//��ũ�� ������ �� �Ķ��� ���� ����Ǿ�� ��
                StartCoroutine(Go_Next());


                IEnumerator Go_Next()
                {
                    yield return new WaitForSeconds(0.0f);

                    //Pink_1.SetActive(false);
                    //Pink_2.SetActive(false);

                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                    //�Ķ� ��� ĭ�� false�ϰ� 

                    //��ȫ ��� ĭ�� true�� �����

                    Blue_Material_Canvas.SetActive(false);
                    Pink_Material_Canvas.SetActive(true);//��ȫ ��� true
                                                         //�� ���� ��ȫ���� ��ġ�� �ű�ų� �ִϸ��̼��� ����Ǽ��� �ȵ�

                    Good_Bad_Blue_1.SetActive(false);
                    Good_Bad_Blue_2.SetActive(false);

                    Good_Bad_Pink_1.SetActive(true);
                    Good_Bad_Pink_2.SetActive(true);

                    Coin_Blue_1.SetActive(false);
                 

                    Coin_Pink_1.SetActive(true);
         

                    // blue_pink.Plate.transform.Rotate(0f, 0f, 180f);
                    // blue_pink.plate.anchoredPosition = new Vector2(0f, 12.9f);//15.6�̾��µ�...

                    //
                    next_turn.Go_Player1_B.SetActive(false);//��� �� ������
                    next_turn.Go_Player2_B.SetActive(true);//��ũ �� ������

                    next_turn.blue.SetActive(false);//��� 
                    next_turn.pink.SetActive(true);//��ũ 

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

            if (Click_Count % 2 != 0 && Click_Count != 1 && Click_Count != 3 && Click_Count > 4)//Ȧ���鼭 1, 3�� �ƴ϶��
            {


                //���� ��ũ���� �Ķ����� �Ѿ ���̹Ƿ� ���⼭ �ڵ� �����ؾ� ��
                /*for (int i = 0; i < 7; i++)
                {
                    // ������ �����ϴ� ��쿡�� ����
                    if (card_move.Pink_Fourth_Line[i].transform.childCount == 1)
                    {
                        // "PlayAnimationOnFirstChildObjects" �޼��带 ȣ���Ͽ� �ִϸ��̼� ����
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


                            //�Ķ� ��� ĭ�� true�ϰ� 
                            //��ȫ ��� ĭ�� false�� �����

                            Blue_Material_Canvas.SetActive(true);
                            Pink_Material_Canvas.SetActive(false);//��ũ ��Ȱ��

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


                            //�Ķ� ��� ĭ�� true�ϰ� 
                            //��ȫ ��� ĭ�� false�� �����

                            Blue_Material_Canvas.SetActive(true);
                            Pink_Material_Canvas.SetActive(false);//��ũ ��Ȱ��

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

            if (Click_Count == 1 && Click_Count != 3)//1, 3�̶��
            {
                //��ũ�� ������ �� Ȧ���� ��ũ��


                StartCoroutine(Go_Next1());


                IEnumerator Go_Next1()
                {
                    yield return new WaitForSeconds(0.0f);

                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                    Pink_1.SetActive(false);
                    Pink_2.SetActive(true);


                    //�Ķ� ��� ĭ�� true�ϰ� 
                    //��ȫ ��� ĭ�� false�� �����

                    Blue_Material_Canvas.SetActive(false);
                    Pink_Material_Canvas.SetActive(true);//��ũ ��Ȱ��

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

            if (Click_Count != 1 && Click_Count == 3)//1, 3�̶��
            {
                //��ũ�� ������ �� Ȧ���� ��ũ��


                StartCoroutine(Go_Next1());


                IEnumerator Go_Next1()
                {
                    yield return new WaitForSeconds(0.0f);

                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                    Pink_1.SetActive(true);
                    Pink_2.SetActive(false);


                    //�Ķ� ��� ĭ�� true�ϰ� 
                    //��ȫ ��� ĭ�� false�� �����

                    Blue_Material_Canvas.SetActive(false);
                    Pink_Material_Canvas.SetActive(true);//��ũ ��Ȱ��

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


        if (Open_Blue.activeSelf == true || Close_Blue.activeSelf == true)//��簡 ����
        {
            //Open_Blue.activeSelf == true || Close_Blue.activeSelf == true �̰ſ���

            //¦����° Ŭ���ߴµ� ������ 0, 0, 0�̶�� �Ķ��� ��Ÿ���� ��ȫ �����
            //4�� 
            if (Click_Count % 2 == 0 && Click_Count != 0 && Click_Count != 2 && Click_Count > 4) //¦���� ��
            {

                //������. ī�� ���� 1�ִ� �� ������ �ű����
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

                            //�Ķ� ��� ĭ�� true�ϰ� 
                            //��ȫ ��� ĭ�� false�� �����

                            Blue_Material_Canvas.SetActive(true);
                            Pink_Material_Canvas.SetActive(false);//��ȫ ��ᰡ false�� �� �ڵ� ����

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

                            //�Ķ� ��� ĭ�� true�ϰ� 
                            //��ȫ ��� ĭ�� false�� �����

                            Blue_Material_Canvas.SetActive(true);
                            Pink_Material_Canvas.SetActive(false);//��ȫ ��ᰡ false�� �� �ڵ� ����

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



                //���� ��ũ���� �Ķ����� �Ѿ ���̹Ƿ� ���⼭ �ڵ� �����ؾ� ��
                /* for (int i = 0; i < 7; i++)
                 {
                     // ������ �����ϴ� ��쿡�� ����
                     if (card_move.Pink_Fourth_Line[i].transform.childCount == 1)
                     {
                         // "PlayAnimationOnFirstChildObjects" �޼��带 ȣ���Ͽ� �ִϸ��̼� ����
                         PlayAnimationOnFirstChildObjects(card_move.Pink_Fourth_Line[i].transform);
                     }

                     if (card_move.Pink_Fourth_Line[i].transform.childCount == 0)
                     {
                         // "PlayAnimationOnFirstChildObjects" �޼��带 ȣ���Ͽ� �ִϸ��̼� ����
                         PlayAnimationOnFirstChildObjects_1(card_move.Pink_Fourth_Line[i].transform);
                     }
                 }*/






            }

            else if (Click_Count == 0 && Click_Count != 2)//¦���� ��
            {//��簡 �����ε� ¦���� ��ũ�� ����
                StartCoroutine(Go_Next1());


                IEnumerator Go_Next1()
                {
                    yield return new WaitForSeconds(0.0f);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                    Pink_1.SetActive(false);
                    Pink_2.SetActive(true);



                    //�Ķ� ��� ĭ�� true�ϰ� 
                    //��ȫ ��� ĭ�� false�� �����

                    Blue_Material_Canvas.SetActive(false);
                    Pink_Material_Canvas.SetActive(true);//��ȫ ��ᰡ false�� �� �ڵ� ����

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

            else if (Click_Count != 0 && Click_Count == 2)//¦���� ��
            {//��簡 �����ε� ¦���� ��ũ�� ����
                StartCoroutine(Go_Next1());


                IEnumerator Go_Next1()
                {
                    yield return new WaitForSeconds(0.0f);
                    Blue_1.SetActive(false);
                    Blue_2.SetActive(false);

                    Pink_1.SetActive(true);
                    Pink_2.SetActive(false);



                    //�Ķ� ��� ĭ�� true�ϰ� 
                    //��ȫ ��� ĭ�� false�� �����

                    Blue_Material_Canvas.SetActive(false);
                    Pink_Material_Canvas.SetActive(true);//��ȫ ��ᰡ false�� �� �ڵ� ����

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
            else if (Click_Count != 0 && Click_Count != 2 && Click_Count == 4)//4�� ��
            {//��簡 �����ε� ¦���� ��ũ�� ����
                StartCoroutine(Go_Next1());


                IEnumerator Go_Next1()
                {
                    yield return new WaitForSeconds(0.0f);
                    //Blue_1.SetActive(false);
                    //Blue_2.SetActive(false);

                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);



                    //�Ķ� ��� ĭ�� true�ϰ� 
                    //��ȫ ��� ĭ�� false�� �����

                    Blue_Material_Canvas.SetActive(true);
                    Pink_Material_Canvas.SetActive(false);//��ȫ ��ᰡ false�� �� �ڵ� ����

                    Good_Bad_Blue_1.SetActive(true);
                    Good_Bad_Blue_2.SetActive(true);

                    Good_Bad_Pink_1.SetActive(false);
                    Good_Bad_Pink_2.SetActive(false);

                    Coin_Blue_1.SetActive(true);


                    Coin_Pink_1.SetActive(false);
                   

                    // next_turn.Rotate_board.transform.Rotate(0f, 0f, 180f);
                    // ���� ��ġ�� (0, 15.6)���� ����
                    //next_turn.board.anchoredPosition = new Vector2(0f, 0f);//15.6���µ�



                    //
                    next_turn.Go_Player1_B.SetActive(true);//��� �� ������
                    next_turn.Go_Player2_B.SetActive(false);//��ũ �� ������

                    next_turn.blue.SetActive(true);//��� 
                    next_turn.pink.SetActive(false);//��ũ 

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

            else if (Click_Count % 2 != 0 && Click_Count != 1 && Click_Count != 3 && Click_Count > 4)//Ȧ���� ��
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

                            //�Ķ� ��� ĭ�� false�ϰ� 
                            //��ȫ ��� ĭ�� true�� �����

                            Blue_Material_Canvas.SetActive(false);
                            Pink_Material_Canvas.SetActive(true);
                            //�ڵ� �������� ����-��ȫ

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
                        Debug.Log("���� �ʾ�?");

                        PlayAnimationOnFirstChildObjects_1_Blue();

                        StartCoroutine(Go_Next1());


                        IEnumerator Go_Next1()
                        {
                            yield return new WaitForSeconds(0.5f);
                            Blue_1.SetActive(false);
                            Blue_2.SetActive(false);

                            //�Ķ� ��� ĭ�� false�ϰ� 
                            //��ȫ ��� ĭ�� true�� �����

                            Blue_Material_Canvas.SetActive(false);
                            Pink_Material_Canvas.SetActive(true);
                            //�ڵ� �������� ����-��ȫ

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

            else if (Click_Count == 1 && Click_Count != 3)//Ȧ���� ��
            {//������ �� ��簡 ������ ��簡 ����
                StartCoroutine(Go_Next1());


                IEnumerator Go_Next1()
                {
                    yield return new WaitForSeconds(0.0f);
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);

                    Blue_1.SetActive(false);
                    Blue_2.SetActive(true);

                    //�Ķ� ��� ĭ�� false�ϰ� 
                    //��ȫ ��� ĭ�� true�� �����

                    Blue_Material_Canvas.SetActive(true);
                    Pink_Material_Canvas.SetActive(false);
                    //�ڵ� �������� ����-��ȫ

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

            else if (Click_Count != 1 && Click_Count == 3)//Ȧ���� ��
            {//������ �� ��簡 ������ ��簡 ����

                StartCoroutine(Go_Next1());


                IEnumerator Go_Next1()
                {
                    yield return new WaitForSeconds(0.0f);
                    Pink_1.SetActive(false);
                    Pink_2.SetActive(false);

                    Blue_1.SetActive(true);
                    Blue_2.SetActive(false);

                    //�Ķ� ��� ĭ�� false�ϰ� 
                    //��ȫ ��� ĭ�� true�� �����

                    Blue_Material_Canvas.SetActive(true);
                    Pink_Material_Canvas.SetActive(false);
                    //�ڵ� �������� ����-��ȫ

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
        // parentTransform ������Ʈ�� ��� ù ��° �ڽĵ��� Animator ������Ʈ�� ã��
        Animator[] childAnimators = parentTransform.GetComponentsInChildren<Animator>();

        // ã�� Animator ������Ʈ�鿡 "Go_Red" �ִϸ��̼��� ����
        foreach (Animator animator in childAnimators)
        {
            // Animator ������Ʈ�� �����ϰ�, �ִϸ��̼��� ����� �غ� �Ǿ����� Ȯ��
            if (animator != null && animator.runtimeAnimatorController != null)
            {


                // "Go_Red" �ִϸ��̼��� ����
                animator.SetBool("Go_Red", true);

                StartCoroutine(Stop_Anim());

                StartCoroutine(Next_Card1());
                StartCoroutine(Next_Card2());




                IEnumerator Stop_Anim()
                {
                    yield return new WaitForSeconds(2.0f);
                    animator.SetBool("Go_Red", false);


                    good_bad.Bad_Ccount++; // ��� �߰�
                    good_bad.Update_Bad_Count(); // ��� �߰� ��� �ڵ�

                    good_bad.Ccoin_Count++;//���� �߰�
                    good_bad.Update_Coin_Count();//���� �߰� ��� �ڵ�




                    //��� ī��Ʈ�� 5 �̻��̸�
                    //���� ��ũ�� ���϶�
                    //�� Open�� �Ǿ��ִ� ���
                    if (Open_Pink.activeSelf == true && Close_Pink.activeSelf == false)
                    {
                        if (good_bad.Bad_Ccount == 5 || good_bad.Bad_Ccount > 5 || card_move.usedCardCount == 80)
                        {
                            //��ũ�� ������ �Ǵ� �� 
                            //��ũ�� ���۵Ǵµ� ��ũ�� 5���϶�
                            Open_Pink.SetActive(false);
                            Close_Pink.SetActive(true);

                            Debug.Log("��ũ ���� Ȱ��ȭ");
                        }

                        else
                        {
                            Open_Pink.SetActive(true);
                            Close_Pink.SetActive(false);


                        }
                    }

                    //���� ��簡 ���϶�
                    //�� Open�� �Ǿ��ִ� ���
                    else if (Open_Blue.activeSelf == true && Close_Blue.activeSelf == false)
                    {
                        if (good_bad.Bad_Ccount == 5 || good_bad.Bad_Ccount > 5 || card_move.usedCardCount == 80)
                        {
                            Open_Blue.SetActive(false);
                            Close_Blue.SetActive(true);

                            Debug.Log("��� ���� Ȱ��ȭ");

                        }

                        else
                        {
                            Open_Blue.SetActive(true);
                            Close_Blue.SetActive(false);


                        }
                    }

                    else if (Close_Pink.activeSelf == true)
                    {
                        //���� Ŭ�ο���尡 Ȱ��ȭ
                        //����� �̰� ��ũ���� ��� �Ѿ�� �ڵ忡 �ִ� �Ŵ�.
                        Debug.Log("��ũ ���� ������ �����ϵ� �� ���� ��簡 ������ ����");


                        //���⼭ ���ο� ������ ���ڸ� �߰�������

                        //��ũ�� �����ε�
                        //��ũ���� �������� �Ѿ�� ��ư�ε� 
                        //�̹� �����ٸ� 

                        ;
                    }

                    else if (Close_Blue.activeSelf == true)
                    {
                        //���� Ŭ�ο���尡 Ȱ��ȭ
                        //����� �̰� ��ũ���� ��� �Ѿ�� �ڵ忡 �ִ� �Ŵ�.

                        //��� ����
                        Debug.Log("��ũ ������ �� - �� �������ʹ� �ٷ� ���ھ� ���;� ��.");


                    }





                    sfx.SFX_Fail_Menu();

                    //���⼭ �ؿ� �ִ� for�� ���ְ� ����
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
                            //���� ��ũ�� ���ε�
                            //��ũ�� ������ ��

                            //�� �̻� �ƹ��͵� ���� �ʴ´�
                            //Debug.Log("�ƹ��͵� ���� ����");
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
                            //���� ��簡 ���ε� ��簡 ������ ��
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

                            Debug.Log("�� ��ũ�� ������ ��. �� ��ũ �� �ϰ� ���� ���ھ� ��Ÿ����");

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
                        //Debug.Log("�ڽ� ����");

                        //���� �߰�0827
                        if (Close_Pink.activeSelf == true)
                        {
                            //���� ��ũ�� ���ε�
                            //��ũ�� ������ ��

                            //�� �̻� �ƹ��͵� ���� �ʴ´�
                            //Debug.Log("�ƹ��͵� ���� ����");
                            Debug.Log("�ڽ� ����");
                        }

                        else if (Close_Blue.activeSelf == true)
                        {
                            //���� ��簡 ���ε� ��簡 ������ ��
                            //Destroy(card_move.Pink_Fourth_Line[i].transform.GetChild(0).gameObject);

                            Debug.Log("�� ��ũ�� ������ ��. �� ��ũ �� �ϰ� ���� ���ھ� ��Ÿ����");

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
                            Debug.Log("�ڽ� ����");
                            //Destroy(card_move.Pink_Fourth_Line[i].transform.GetChild(0).gameObject);
                        }
                    }*/





                    //�ֹ� ó�� ���� �� ����
                    /*for (int i = 0; i < card_move.Pink_Fourth_Line.Length; i++)
                    {
                        if (card_move.Pink_Fourth_Line[i].transform.childCount == 1)
                        {
                            if (Close_Pink.activeSelf == true)
                            {
                                //���� ��ũ�� ���ε�
                                //��ũ�� ������ ��

                                //�� �̻� �ƹ��͵� ���� �ʴ´�
                                //Debug.Log("�ƹ��͵� ���� ����");
                                Destroy(card_move.Pink_Fourth_Line[i].transform.GetChild(0).gameObject);
                            }

                            else if (Close_Blue.activeSelf == true)
                            {
                                //���� ��簡 ���ε� ��簡 ������ ��
                                Destroy(card_move.Pink_Fourth_Line[i].transform.GetChild(0).gameObject);

                                Debug.Log("�� ��ũ�� ������ ��. �� ��ũ �� �ϰ� ���� ���ھ� ��Ÿ����");

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
                            //Debug.Log("�ڽ� ����");

                            //���� �߰�0827
                            if (Close_Pink.activeSelf == true)
                            {
                                //���� ��ũ�� ���ε�
                                //��ũ�� ������ ��

                                //�� �̻� �ƹ��͵� ���� �ʴ´�
                                //Debug.Log("�ƹ��͵� ���� ����");
                                Debug.Log("�ڽ� ����");
                            }

                            else if (Close_Blue.activeSelf == true)
                            {
                                //���� ��簡 ���ε� ��簡 ������ ��
                                //Destroy(card_move.Pink_Fourth_Line[i].transform.GetChild(0).gameObject);

                                Debug.Log("�� ��ũ�� ������ ��. �� ��ũ �� �ϰ� ���� ���ھ� ��Ÿ����");

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
                                Debug.Log("�ڽ� ����");
                                //Destroy(card_move.Pink_Fourth_Line[i].transform.GetChild(0).gameObject);
                            }
                        }


                    }*/



                    //�� ��° �ٿ� �ִ� �� �� ���� �ٷ� �̵�
                    for (int i = 0; i < card_move.Pink_Third_Line.Length; i++)
                    {
                        if (card_move.Pink_Third_Line[i].transform.childCount == 1)
                        {
                            if (Close_Pink.activeSelf == true)
                            {
                                //���� ��ũ�� ���ε�
                                //��ũ�� ������ ��

                                Transform childToMove = card_move.Pink_Third_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Pink_Fourth_Line[i].transform, false);

                                //�� �̻� �ƹ��͵� ���� �ʴ´�
                                // Debug.Log("�ƹ��͵� ���� ����");
                            }

                            else if (Close_Blue.activeSelf == true)
                            {
                                //���� ��簡 ���ε� ��簡 ������ ��
                                Transform childToMove = card_move.Pink_Third_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Pink_Fourth_Line[i].transform, false);

                                Debug.Log("�� ��ũ�� ������ ��. �� ��ũ �� �ϰ� ���� ���ھ� ��Ÿ����");
                            }

                            else
                            {
                                Transform childToMove = card_move.Pink_Third_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Pink_Fourth_Line[i].transform, false);
                            }

                            // Pink_Third_Line[i]�� �ڽ��� 1�� �ִ� ���
                            // �ش� �ڽ��� Pink_Fourth_Line[i]�� ù ��° �ڽ����� �ű�
                            /*Transform childToMove = card_move.Pink_Third_Line[i].transform.GetChild(0);

                            childToMove.SetParent(card_move.Pink_Fourth_Line[i].transform, false);*/



                        }

                        else if (card_move.Pink_Third_Line[i].transform.childCount == 0)
                        {
                            Debug.Log("�ڽ� ����");
                        }
                    }

                }

                IEnumerator Next_Card1()
                {
                    yield return new WaitForSeconds(2.005f);
                    //�� ��° �ٿ� �ִ� �� �� ��° �ٷ� �̵�
                    for (int i = 0; i < card_move.Pink_Second_Line.Length; i++)
                    {
                        if (card_move.Pink_Second_Line[i].transform.childCount == 1)
                        {
                            if (Close_Pink.activeSelf == true)
                            {
                                //���� ��ũ�� ���ε�
                                //��ũ�� ������ ��

                                Transform childToMove = card_move.Pink_Second_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Pink_Third_Line[i].transform, false);

                                //�� �̻� �ƹ��͵� ���� �ʴ´�
                                //Debug.Log("�ƹ��͵� ���� ����");
                            }

                            else if (Close_Blue.activeSelf == true)
                            {
                                //���� ��簡 ���ε� ��簡 ������ ��
                                Transform childToMove = card_move.Pink_Second_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Pink_Third_Line[i].transform, false);

                                Debug.Log("�� ��ũ�� ������ ��. �� ��ũ �� �ϰ� ���� ���ھ� ��Ÿ����");


                            }

                            else
                            {
                                Transform childToMove = card_move.Pink_Second_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Pink_Third_Line[i].transform, false);
                            }

                            // Pink_Second_Line[i]�� �ڽ��� 1�� �ִ� ���
                            // �ش� �ڽ��� Pink_Third_Line[i]�� ù ��° �ڽ����� �ű�
                            /*Transform childToMove = card_move.Pink_Second_Line[i].transform.GetChild(0);
                            childToMove.SetParent(card_move.Pink_Third_Line[i].transform, false);*/
                        }

                        else if (card_move.Pink_Second_Line[i].transform.childCount == 0)
                        {
                            Debug.Log("�ڽ� ����");
                        }
                    }
                }

                IEnumerator Next_Card2()
                {
                    yield return new WaitForSeconds(2.01f);
                    //ù ��° �ٿ� �ִ� �� �� ���� �ٷ� �̵�
                    for (int i = 0; i < card_move.Pink_First_Line.Length; i++)
                    {
                        if (card_move.Pink_First_Line[i].transform.childCount == 1)
                        {

                            if (Close_Pink.activeSelf == true)
                            {
                                //���� ��ũ�� ���ε�
                                //��ũ�� ������ ��

                                Transform childToMove2 = card_move.Pink_First_Line[i].transform.GetChild(0);
                                childToMove2.SetParent(card_move.Pink_Second_Line[i].transform, false);

                                //�� �̻� �ƹ��͵� ���� �ʴ´�
                                //Debug.Log("�ƹ��͵� ���� ����");
                            }

                            else if (Close_Blue.activeSelf == true)
                            {
                                //���� ��簡 ���ε� ��簡 ������ ��
                                Transform childToMove2 = card_move.Pink_First_Line[i].transform.GetChild(0);
                                childToMove2.SetParent(card_move.Pink_Second_Line[i].transform, false);

                                Debug.Log("�� ��ũ�� ������ ��. �� ��ũ �� �ϰ� ���� ���ھ� ��Ÿ����");
                            }

                            else
                            {
                                Transform childToMove2 = card_move.Pink_First_Line[i].transform.GetChild(0);
                                childToMove2.SetParent(card_move.Pink_Second_Line[i].transform, false);
                            }
                            // Pink_Third_Line[i]�� �ڽ��� 1�� �ִ� ���
                            // �ش� �ڽ��� Pink_Fourth_Line[i]�� ù ��° �ڽ����� �ű�
                            /* Transform childToMove2 = card_move.Pink_First_Line[i].transform.GetChild(0);
                             childToMove2.SetParent(card_move.Pink_Second_Line[i].transform, false);*/
                        }

                        else if (card_move.Pink_First_Line[i].transform.childCount == 0)//�ڽ��� ���� ����� ������ ¥����
                        {
                            Debug.Log("�ڽ� ����");
                        }
                    }
                }
            }




        }
    }

    public void PlayAnimationOnFirstChildObjects_1()//�� ��° �ٿ� �ڽ��� ���� ���
    {
        // parentTransform ������Ʈ�� ��� ù ��° �ڽĵ��� Animator ������Ʈ�� ã��

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
                //Debug.Log("�ڽ� ����");

                //���� �߰�0827
                if (Close_Pink.activeSelf == true)
                {
                    //���� ��ũ�� ���ε�
                    //��ũ�� ������ ��

                    //�� �̻� �ƹ��͵� ���� �ʴ´�
                    //Debug.Log("�ƹ��͵� ���� ����");
                    Debug.Log("�ڽ� ����");
                }

                else if (Close_Blue.activeSelf == true)
                {
                    //���� ��簡 ���ε� ��簡 ������ ��
                    //Destroy(card_move.Pink_Fourth_Line[i].transform.GetChild(0).gameObject);

                    Debug.Log("�� ��ũ�� ������ ��. �� ��ũ �� �ϰ� ���� ���ھ� ��Ÿ����");

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
                    Debug.Log("�ڽ� ����");
                    //Destroy(card_move.Pink_Fourth_Line[i].transform.GetChild(0).gameObject);
                }
            }

            //�� ��° �ٿ� �ִ� �� �� ���� �ٷ� �̵�
            for (int i = 0; i < card_move.Pink_Third_Line.Length; i++)
            {
                if (card_move.Pink_Third_Line[i].transform.childCount == 1)
                {
                    if (Close_Pink.activeSelf == true)
                    {
                        //���� ��ũ�� ���ε�
                        //��ũ�� ������ ��

                        //�� �̻� �ƹ��͵� ���� �ʴ´�
                        //Debug.Log("�ƹ��͵� ���� ����");

                        Transform childToMove = card_move.Pink_Third_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Pink_Fourth_Line[i].transform, false);
                    }

                    else if (Close_Blue.activeSelf == true)
                    {
                        //���� ��簡 ���ε� ��簡 ������ ��
                        Transform childToMove = card_move.Pink_Third_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Pink_Fourth_Line[i].transform, false);

                        Debug.Log("�� ��ũ�� ������ ��. �� ��ũ �� �ϰ� ���� ���ھ� ��Ÿ����");
                    }

                    else
                    {
                        Transform childToMove = card_move.Pink_Third_Line[i].transform.GetChild(0);

                        childToMove.SetParent(card_move.Pink_Fourth_Line[i].transform, false);
                    }

                    // Pink_Third_Line[i]�� �ڽ��� 1�� �ִ� ���
                    // �ش� �ڽ��� Pink_Fourth_Line[i]�� ù ��° �ڽ����� �ű�
                    /*Transform childToMove = card_move.Pink_Third_Line[i].transform.GetChild(0);

                    childToMove.SetParent(card_move.Pink_Fourth_Line[i].transform, false);*/



                }

                else if (card_move.Pink_Third_Line[i].transform.childCount == 0)
                {
                    Debug.Log("�ڽ� ����");
                }
            }

        }

        IEnumerator Next_Card1()
        {
            yield return new WaitForSeconds(0.005f);
            //�� ��° �ٿ� �ִ� �� �� ��° �ٷ� �̵�
            for (int i = 0; i < card_move.Pink_Second_Line.Length; i++)
            {
                if (card_move.Pink_Second_Line[i].transform.childCount == 1)
                {
                    if (Close_Pink.activeSelf == true)
                    {
                        //���� ��ũ�� ���ε�
                        //��ũ�� ������ ��

                        Transform childToMove = card_move.Pink_Second_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Pink_Third_Line[i].transform, false);

                        //�� �̻� �ƹ��͵� ���� �ʴ´�
                        //Debug.Log("�ƹ��͵� ���� ����");
                    }

                    else if (Close_Blue.activeSelf == true)
                    {
                        //���� ��簡 ���ε� ��簡 ������ ��
                        Transform childToMove = card_move.Pink_Second_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Pink_Third_Line[i].transform, false);

                        Debug.Log("�� ��ũ�� ������ ��. �� ��ũ �� �ϰ� ���� ���ھ� ��Ÿ����");
                    }

                    else
                    {
                        Transform childToMove = card_move.Pink_Second_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Pink_Third_Line[i].transform, false);
                    }

                    // Pink_Second_Line[i]�� �ڽ��� 1�� �ִ� ���
                    // �ش� �ڽ��� Pink_Third_Line[i]�� ù ��° �ڽ����� �ű�
                    /*Transform childToMove = card_move.Pink_Second_Line[i].transform.GetChild(0);
                    childToMove.SetParent(card_move.Pink_Third_Line[i].transform, false);*/
                }

                else if (card_move.Pink_Second_Line[i].transform.childCount == 0)
                {
                    Debug.Log("�ڽ� ����");
                }
            }
        }

        IEnumerator Next_Card2()
        {
            yield return new WaitForSeconds(0.01f);
            //ù ��° �ٿ� �ִ� �� �� ���� �ٷ� �̵�
            for (int i = 0; i < card_move.Pink_First_Line.Length; i++)
            {
                if (card_move.Pink_First_Line[i].transform.childCount == 1)
                {
                    if (Close_Pink.activeSelf == true)
                    {
                        //���� ��ũ�� ���ε�
                        //��ũ�� ������ ��

                        Transform childToMove2 = card_move.Pink_First_Line[i].transform.GetChild(0);
                        childToMove2.SetParent(card_move.Pink_Second_Line[i].transform, false);

                        //�� �̻� �ƹ��͵� ���� �ʴ´�
                        //Debug.Log("�ƹ��͵� ���� ����");
                    }

                    else if (Close_Blue.activeSelf == true)
                    {
                        //���� ��簡 ���ε� ��簡 ������ ��
                        Transform childToMove2 = card_move.Pink_First_Line[i].transform.GetChild(0);
                        childToMove2.SetParent(card_move.Pink_Second_Line[i].transform, false);

                        Debug.Log("�� ��ũ�� ������ ��. �� ��ũ �� �ϰ� ���� ���ھ� ��Ÿ����");
                    }

                    else
                    {
                        Transform childToMove2 = card_move.Pink_First_Line[i].transform.GetChild(0);
                        childToMove2.SetParent(card_move.Pink_Second_Line[i].transform, false);
                    }

                    // Pink_Third_Line[i]�� �ڽ��� 1�� �ִ� ���
                    // �ش� �ڽ��� Pink_Fourth_Line[i]�� ù ��° �ڽ����� �ű�
                    /*Transform childToMove2 = card_move.Pink_First_Line[i].transform.GetChild(0);
                    childToMove2.SetParent(card_move.Pink_Second_Line[i].transform, false);*/

                }

                else if (card_move.Pink_First_Line[i].transform.childCount == 0)//�ڽ��� ���� ����� ������ ¥����
                {
                    Debug.Log("�ڽ� ����");
                }
            }
        }



    }


    public void PlayAnimationOnFirstChildObjects_Blue(Transform parentTransform)
    {
        // parentTransform ������Ʈ�� ��� ù ��° �ڽĵ��� Animator ������Ʈ�� ã��
        Animator[] childAnimators = parentTransform.GetComponentsInChildren<Animator>();

        // ã�� Animator ������Ʈ�鿡 "Go_Red" �ִϸ��̼��� ����
        foreach (Animator animator in childAnimators)
        {
            // Animator ������Ʈ�� �����ϰ�, �ִϸ��̼��� ����� �غ� �Ǿ����� Ȯ��
            if (animator != null && animator.runtimeAnimatorController != null)
            {

                //���� ���� �ִ� ��
                // "Go_Red" �ִϸ��̼��� ����
                animator.SetBool("Go_Red", true);



                StartCoroutine(Stop_Anim_Blue());

                StartCoroutine(Next_Card1_Blue());
                StartCoroutine(Next_Card2_Blue());


                IEnumerator Stop_Anim_Blue()
                {
                    yield return new WaitForSeconds(2.0f);
                    animator.SetBool("Go_Red", false);


                    good_bad.Bad_Ccount_Blue++; // ��� �߰�
                    good_bad.Update_Bad_Count_Blue(); // ��� �߰� ��� �ڵ�

                    good_bad.Ccoin_Count_Blue++;//���� �߰�
                    good_bad.Update_Coin_Count_Blue();//���� �߰� ��� �ڵ�



                    //��� ī��Ʈ�� 5 �̻��̸�
                    //���� ��ũ�� ���϶�
                    //�� Open�� �Ǿ��ִ� ���
                    if (Open_Pink.activeSelf == true && Close_Pink.activeSelf == false)
                    {
                        if (good_bad.Bad_Ccount_Blue == 5 || good_bad.Bad_Ccount_Blue > 5 || card_move.usedCardCount == 80)
                        {
                            Open_Pink.SetActive(false);
                            Close_Pink.SetActive(true);

                            Debug.Log("��ũ ���� Ȱ��ȭ");
                        }

                        else
                        {
                            Open_Pink.SetActive(true);
                            Close_Pink.SetActive(false);

                        }
                    }

                    //���� ��簡 ���϶�
                    //�� Open�� �Ǿ��ִ� ���
                    else if (Open_Blue.activeSelf == true && Close_Blue.activeSelf == false)
                    {
                        if (good_bad.Bad_Ccount_Blue == 5 || good_bad.Bad_Ccount_Blue > 5 || card_move.usedCardCount == 80)
                        {
                            Open_Blue.SetActive(false);
                            Close_Blue.SetActive(true);

                            Debug.Log("��� ���� Ȱ��ȭ");

                        }

                        else
                        {
                            Open_Blue.SetActive(true);
                            Close_Blue.SetActive(false);

                        }
                    }

                    else if (Close_Blue.activeSelf == true)
                    {
                        //��簡 ���� ��
                        //��� ������ Ȱ��ȭ �Ǿ����� �x

                        //�������� �ѱ��
                        Debug.Log("���� ��� ����, ���� ��ũ�� ������ ��");
                    }

                    else if (Close_Pink.activeSelf == true)
                    {
                        //��ũ�� ���� ��
                        //��ũ ������ Ȱ��ȭ �Ǿ����� ��

                        // ���� ��� ����Ǿ�� ��
                        Debug.Log("�� ��簡 ������ ��. �� ��� �� �ϰ� ���� ���ھ� ��Ÿ����");
                    }


                    sfx.SFX_Fail_Menu();

                    //���� ����0827
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

                            Debug.Log("�� ��簡 ������ ��. �� ��� �� �ϰ� ���� ���ھ� ��Ÿ����");

                            //������� ���� �߰�
                            Debug.Log("���� ���ھ� ��Ÿ����");

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
                        }//������� ���� �߰��� ��

                        else if (Close_Blue.activeSelf == true)
                        {
                            //���� ��簡 ���ε� ��簡 ������ ��
                            //�� �̻� �ƹ��͵� ���� �ʴ´�
                            //Debug.Log("�ƹ��͵� ���� ����");
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
                             //���� ��ũ�� ���ε�
                             //��ũ�� ������ ��
                             Debug.Log("�ڽ� ����");
                             Debug.Log("�� ��簡 ������ ��. �� ��� �� �ϰ� ���� ���ھ� ��Ÿ����");

                             //������� ���� �߰�
                             Debug.Log("���� ���ھ� ��Ÿ����");

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
                         }//������� ���� �߰��� ��

                         else if (Close_Blue.activeSelf == true)
                         {
                             //���� ��簡 ���ε� ��簡 ������ ��
                             //�� �̻� �ƹ��͵� ���� �ʴ´�
                             //Debug.Log("�ƹ��͵� ���� ����");
                             //Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                             Debug.Log("�ڽ� ����");
                         }

                         else
                         {
                             //Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                             Debug.Log("�ڽ� ����");
                         }

                         //Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                     }*/

                    /*else
                    {
                        Debug.Log("�ڽ� ����");
                    }*/


                    // }



                    //�ֹ� ó�� ���� �� ����
                    /* for (int i = 0; i < card_move.Blue_Fourth_Line.Length; i++)
                     {
                         if (card_move.Blue_Fourth_Line[i].transform.childCount == 1)
                         {
                             if(Close_Pink.activeSelf == true)
                             {
                                 //���� ��ũ�� ���ε�
                                 //��ũ�� ������ ��
                                 Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                                 Debug.Log("�� ��簡 ������ ��. �� ��� �� �ϰ� ���� ���ھ� ��Ÿ����");

                                 //������� ���� �߰�
                                 Debug.Log("���� ���ھ� ��Ÿ����");

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
                             }//������� ���� �߰��� ��

                             else if (Close_Blue.activeSelf == true)
                             {
                                 //���� ��簡 ���ε� ��簡 ������ ��
                                 //�� �̻� �ƹ��͵� ���� �ʴ´�
                                 //Debug.Log("�ƹ��͵� ���� ����");
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
                                 //���� ��ũ�� ���ε�
                                 //��ũ�� ������ ��
                                 Debug.Log("�ڽ� ����");
                                 Debug.Log("�� ��簡 ������ ��. �� ��� �� �ϰ� ���� ���ھ� ��Ÿ����");

                                 //������� ���� �߰�
                                 Debug.Log("���� ���ھ� ��Ÿ����");

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
                             }//������� ���� �߰��� ��

                             else if (Close_Blue.activeSelf == true)
                             {
                                 //���� ��簡 ���ε� ��簡 ������ ��
                                 //�� �̻� �ƹ��͵� ���� �ʴ´�
                                 //Debug.Log("�ƹ��͵� ���� ����");
                                 //Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                                 Debug.Log("�ڽ� ����");
                             }

                             else
                             {
                                 //Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                                 Debug.Log("�ڽ� ����");
                             }

                             //Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                         }

                         //else
                         //{
                           //  Debug.Log("�ڽ� ����");
                         //}


                     }*/



                    //�� ��° �ٿ� �ִ� �� �� ���� �ٷ� �̵�
                    for (int i = 0; i < card_move.Blue_Third_Line.Length; i++)
                    {
                        if (card_move.Blue_Third_Line[i].transform.childCount == 1)
                        {
                            //���� ����
                            if (Close_Pink.activeSelf == true)
                            {
                                //���� ��ũ�� ���ε�
                                //��ũ�� ������ ��
                                Transform childToMove = card_move.Blue_Third_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Blue_Fourth_Line[i].transform, false);
                                Debug.Log("�� ��簡 ������ ��. �� ��� �� �ϰ� ���� ���ھ� ��Ÿ����");
                            }

                            else if (Close_Blue.activeSelf == true)
                            {
                                //���� ��簡 ���ε� ��簡 ������ ��
                                //�� �̻� �ƹ��͵� ���� �ʴ´�
                                //Debug.Log("�ƹ��͵� ���� ����");
                                Transform childToMove = card_move.Blue_Third_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Blue_Fourth_Line[i].transform, false);
                            }

                            else
                            {
                                Transform childToMove = card_move.Blue_Third_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Blue_Fourth_Line[i].transform, false);
                            }


                            // Pink_Third_Line[i]�� �ڽ��� 1�� �ִ� ���
                            // �ش� �ڽ��� Pink_Fourth_Line[i]�� ù ��° �ڽ����� �ű�
                            /*Transform childToMove = card_move.Blue_Third_Line[i].transform.GetChild(0);

                            childToMove.SetParent(card_move.Blue_Fourth_Line[i].transform, false);*/



                        }

                        else if (card_move.Blue_Third_Line[i].transform.childCount == 0)
                        {
                            Debug.Log("�ڽ� ����");
                        }
                    }

                }

                IEnumerator Next_Card1_Blue()
                {
                    yield return new WaitForSeconds(2.005f);
                    //�� ��° �ٿ� �ִ� �� �� ��° �ٷ� �̵�
                    for (int i = 0; i < card_move.Blue_Second_Line.Length; i++)
                    {
                        if (card_move.Blue_Second_Line[i].transform.childCount == 1)
                        {
                            //���� ����
                            if (Close_Pink.activeSelf == true)
                            {
                                //���� ��ũ�� ���ε�
                                //��ũ�� ������ ��
                                Transform childToMove = card_move.Blue_Second_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Blue_Third_Line[i].transform, false);
                                Debug.Log("�� ��簡 ������ ��. �� ��� �� �ϰ� ���� ���ھ� ��Ÿ����");
                            }

                            else if (Close_Blue.activeSelf == true)
                            {
                                //���� ��簡 ���ε� ��簡 ������ ��
                                //�� �̻� �ƹ��͵� ���� �ʴ´�
                                //Debug.Log("�ƹ��͵� ���� ����");
                                Transform childToMove = card_move.Blue_Second_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Blue_Third_Line[i].transform, false);
                            }

                            else
                            {
                                Transform childToMove = card_move.Blue_Second_Line[i].transform.GetChild(0);
                                childToMove.SetParent(card_move.Blue_Third_Line[i].transform, false);
                            }


                            // Pink_Second_Line[i]�� �ڽ��� 1�� �ִ� ���
                            // �ش� �ڽ��� Pink_Third_Line[i]�� ù ��° �ڽ����� �ű�
                            /*Transform childToMove = card_move.Blue_Second_Line[i].transform.GetChild(0);
                            childToMove.SetParent(card_move.Blue_Third_Line[i].transform, false);*/
                        }

                        else if (card_move.Blue_Second_Line[i].transform.childCount == 0)
                        {
                            Debug.Log("�ڽ� ����");
                        }
                    }
                }

                IEnumerator Next_Card2_Blue()
                {
                    yield return new WaitForSeconds(2.01f);
                    //ù ��° �ٿ� �ִ� �� �� ���� �ٷ� �̵�
                    for (int i = 0; i < card_move.Blue_First_Line.Length; i++)
                    {
                        if (card_move.Blue_First_Line[i].transform.childCount == 1)
                        {
                            //���� ����
                            if (Close_Pink.activeSelf == true)
                            {
                                //���� ��ũ�� ���ε�
                                //��ũ�� ������ ��
                                Transform childToMove2 = card_move.Blue_First_Line[i].transform.GetChild(0);
                                childToMove2.SetParent(card_move.Blue_Second_Line[i].transform, false);
                                Debug.Log("�� ��簡 ������ ��. �� ��� �� �ϰ� ���� ���ھ� ��Ÿ����");
                            }

                            else if (Close_Blue.activeSelf == true)
                            {
                                //���� ��簡 ���ε� ��簡 ������ ��
                                //�� �̻� �ƹ��͵� ���� �ʴ´�
                                //Debug.Log("�ƹ��͵� ���� ����");
                                Transform childToMove2 = card_move.Blue_First_Line[i].transform.GetChild(0);
                                childToMove2.SetParent(card_move.Blue_Second_Line[i].transform, false);
                            }

                            else
                            {
                                Transform childToMove2 = card_move.Blue_First_Line[i].transform.GetChild(0);
                                childToMove2.SetParent(card_move.Blue_Second_Line[i].transform, false);
                            }

                            // Pink_Third_Line[i]�� �ڽ��� 1�� �ִ� ���
                            // �ش� �ڽ��� Pink_Fourth_Line[i]�� ù ��° �ڽ����� �ű�
                            /*Transform childToMove2 = card_move.Blue_First_Line[i].transform.GetChild(0);
                            childToMove2.SetParent(card_move.Blue_Second_Line[i].transform, false);*/

                        }

                        else if (card_move.Blue_First_Line[i].transform.childCount == 0)//�ڽ��� ���� ����� ������ ¥����
                        {
                            Debug.Log("�ڽ� ����");
                        }
                    }
                }
            }




        }
    }


    public void PlayAnimationOnFirstChildObjects_1_Blue()//�� ��° �ٿ� �ڽ��� ���� ���
    {
        // parentTransform ������Ʈ�� ��� ù ��° �ڽĵ��� Animator ������Ʈ�� ã��

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
                    //���� ��ũ�� ���ε�
                    //��ũ�� ������ ��
                    Debug.Log("�ڽ� ����");
                    Debug.Log("�� ��簡 ������ ��. �� ��� �� �ϰ� ���� ���ھ� ��Ÿ����");

                    //������� ���� �߰�
                    Debug.Log("���� ���ھ� ��Ÿ����");

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
                }//������� ���� �߰��� ��

                else if (Close_Blue.activeSelf == true)
                {
                    //���� ��簡 ���ε� ��簡 ������ ��
                    //�� �̻� �ƹ��͵� ���� �ʴ´�
                    //Debug.Log("�ƹ��͵� ���� ����");
                    //Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                    Debug.Log("�ڽ� ����");
                }

                else
                {
                    //Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
                    Debug.Log("�ڽ� ����");
                }

                //Destroy(card_move.Blue_Fourth_Line[i].transform.GetChild(0).gameObject);
            }

            //�� ��° �ٿ� �ִ� �� �� ���� �ٷ� �̵�
            for (int i = 0; i < card_move.Blue_Third_Line.Length; i++)
            {
                if (card_move.Blue_Third_Line[i].transform.childCount == 1)
                {
                    //���� ����
                    if (Close_Pink.activeSelf == true)
                    {
                        //���� ��ũ�� ���ε�
                        //��ũ�� ������ ��
                        Transform childToMove = card_move.Blue_Third_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Blue_Fourth_Line[i].transform, false);
                        Debug.Log("�� ��簡 ������ ��. �� ��� �� �ϰ� ���� ���ھ� ��Ÿ����");
                    }

                    else if (Close_Blue.activeSelf == true)
                    {
                        Transform childToMove = card_move.Blue_Third_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Blue_Fourth_Line[i].transform, false);
                        //���� ��簡 ���ε� ��簡 ������ ��
                        //�� �̻� �ƹ��͵� ���� �ʴ´�
                        //Debug.Log("�ƹ��͵� ���� ����");
                    }

                    else
                    {
                        Transform childToMove = card_move.Blue_Third_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Blue_Fourth_Line[i].transform, false);
                    }

                    // Pink_Third_Line[i]�� �ڽ��� 1�� �ִ� ���
                    // �ش� �ڽ��� Pink_Fourth_Line[i]�� ù ��° �ڽ����� �ű�
                    /*Transform childToMove = card_move.Blue_Third_Line[i].transform.GetChild(0);

                    childToMove.SetParent(card_move.Blue_Fourth_Line[i].transform, false);*/



                }

                else if (card_move.Blue_Third_Line[i].transform.childCount == 0)
                {
                    Debug.Log("�ڽ� ����");
                }
            }

        }

        IEnumerator Next_Card1_Blue()
        {
            yield return new WaitForSeconds(0.005f);
            //�� ��° �ٿ� �ִ� �� �� ��° �ٷ� �̵�
            for (int i = 0; i < card_move.Blue_Second_Line.Length; i++)
            {
                if (card_move.Blue_Second_Line[i].transform.childCount == 1)
                {
                    //���� ����
                    if (Close_Pink.activeSelf == true)
                    {
                        //���� ��ũ�� ���ε�
                        //��ũ�� ������ ��
                        Transform childToMove = card_move.Blue_Second_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Blue_Third_Line[i].transform, false);
                        Debug.Log("�� ��簡 ������ ��. �� ��� �� �ϰ� ���� ���ھ� ��Ÿ����");
                    }

                    else if (Close_Blue.activeSelf == true)
                    {
                        //���� ��簡 ���ε� ��簡 ������ ��
                        //�� �̻� �ƹ��͵� ���� �ʴ´�
                        //Debug.Log("�ƹ��͵� ���� ����");
                        Transform childToMove = card_move.Blue_Second_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Blue_Third_Line[i].transform, false);
                    }

                    else
                    {
                        Transform childToMove = card_move.Blue_Second_Line[i].transform.GetChild(0);
                        childToMove.SetParent(card_move.Blue_Third_Line[i].transform, false);
                    }

                    // Pink_Second_Line[i]�� �ڽ��� 1�� �ִ� ���
                    // �ش� �ڽ��� Pink_Third_Line[i]�� ù ��° �ڽ����� �ű�
                    /*Transform childToMove = card_move.Blue_Second_Line[i].transform.GetChild(0);
                    childToMove.SetParent(card_move.Blue_Third_Line[i].transform, false);*/
                }

                else if (card_move.Blue_Second_Line[i].transform.childCount == 0)
                {
                    Debug.Log("�ڽ� ����");
                }
            }
        }

        IEnumerator Next_Card2_Blue()
        {
            yield return new WaitForSeconds(0.01f);
            //ù ��° �ٿ� �ִ� �� �� ���� �ٷ� �̵�
            for (int i = 0; i < card_move.Blue_First_Line.Length; i++)
            {
                if (card_move.Blue_First_Line[i].transform.childCount == 1)
                {
                    //���� ����
                    if (Close_Pink.activeSelf == true)
                    {
                        //���� ��ũ�� ���ε�
                        //��ũ�� ������ ��
                        Transform childToMove2 = card_move.Blue_First_Line[i].transform.GetChild(0);
                        childToMove2.SetParent(card_move.Blue_Second_Line[i].transform, false);
                        Debug.Log("�� ��簡 ������ ��. �� ��� �� �ϰ� ���� ���ھ� ��Ÿ����");
                    }

                    else if (Close_Blue.activeSelf == true)
                    {
                        //���� ��簡 ���ε� ��簡 ������ ��
                        //�� �̻� �ƹ��͵� ���� �ʴ´�
                        //Debug.Log("�ƹ��͵� ���� ����");
                        Transform childToMove2 = card_move.Blue_First_Line[i].transform.GetChild(0);
                        childToMove2.SetParent(card_move.Blue_Second_Line[i].transform, false);
                    }

                    else
                    {
                        Transform childToMove2 = card_move.Blue_First_Line[i].transform.GetChild(0);
                        childToMove2.SetParent(card_move.Blue_Second_Line[i].transform, false);
                    }

                    // Pink_Third_Line[i]�� �ڽ��� 1�� �ִ� ���
                    // �ش� �ڽ��� Pink_Fourth_Line[i]�� ù ��° �ڽ����� �ű�
                    /*Transform childToMove2 = card_move.Blue_First_Line[i].transform.GetChild(0);
                    childToMove2.SetParent(card_move.Blue_Second_Line[i].transform, false);*/

                }

                else if (card_move.Blue_First_Line[i].transform.childCount == 0)//�ڽ��� ���� ����� ������ ¥����
                {
                    Debug.Log("�ڽ� ����");
                }
            }
        }



    }


}
