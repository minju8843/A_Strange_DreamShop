using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Cup : MonoBehaviour
{

    public Blue_Pink blue_pink;


    public GameObject[] Cup_Material;//8��

    public RectTransform[] Material_Positions_Ice; // ������ ��ġ���� �迭
    public CircleCollider2D[] Positions_Ice;


    public RectTransform[] Material_Positions_Caramel;
    public CircleCollider2D[] Positions_Caramel;

    public RectTransform[] Material_Positions_Steam;
    public CapsuleCollider2D[] Positions_Steam;

    public RectTransform[] Material_Positions_Coffee;
    public CapsuleCollider2D[] Positions_Coffee;

    public RectTransform[] Material_Positions_Milk;
    public CapsuleCollider2D[] Positions_Milk;

    public RectTransform[] Material_Positions_Water;
    public CapsuleCollider2D[] Positions_Water;

    public RectTransform[] Material_Positions_Tea;
    public CapsuleCollider2D[] Positions_Tea;

    public RectTransform[] Material_Positions_Chocolate;
    public CapsuleCollider2D[] Positions_Chocolate;

    public Move_Material move_material;
    //public Transform Parent_Transform; // ���ο� �θ�� ������ Transform ������Ʈ
    //public Transform Parent_Transform_Pink2; // ���ο� �θ�� ������ Transform ������Ʈ
    //public Transform Parent_Transform_Pink3; // ���ο� �θ�� ������ Transform ������Ʈ

    public Rigidbody2D[] Material_rigid;

    public Rigidbody2D[] Material_rigid_Pink2;

    public Rigidbody2D[] Material_rigid_Pink3;

    public Rigidbody2D[] Material_rigid_Blue1;

    public Rigidbody2D[] Material_rigid_Blue2;

    public Rigidbody2D[] Material_rigid_Blue3;

    //���� ���õǾ� �ִ� ���¿��� �� 1���� ������ ���� ���õ� ������Ʈ�� �� ���η� ����
    //���� true�Ǿ� �ִ� �� false��Ų��.

    public GameObject[] Pink_Inside;
    public GameObject[] Blue_Inside;

    //���� �߰�
    public Cup_Menu cup_menu;

    public SFX_2023 sfx;



    public int count_0 = 0;
    public int count_1 = 0;
    public int count_2 = 0;
    public int count_3 = 0;
    public int count_4 = 0;
    public int count_5 = 0;
    public int count_6 = 0;
    public int count_7 = 0;

    //public GameObject Go_Back;

    public void Start()
    {
        //��ũ �� ���� Ȯ��
        Pink_Inside[0].SetActive(false);
        Pink_Inside[1].SetActive(false);
        Pink_Inside[2].SetActive(false);

        //��� �� ���� Ȯ��
        Blue_Inside[0].SetActive(false);
        Blue_Inside[1].SetActive(false);
        Blue_Inside[2].SetActive(false);

        //Go_Back.SetActive(false);


        //�ݶ��̴� �� false
        Positions_Ice[0].enabled = false;
        Positions_Ice[1].enabled = false;

        Positions_Caramel[0].enabled = false;
        Positions_Caramel[1].enabled = false;

        Positions_Steam[0].enabled = false;
        Positions_Steam[1].enabled = false;

        Positions_Coffee[0].enabled = false;
        Positions_Coffee[1].enabled = false;

        Positions_Milk[0].enabled = false;
        Positions_Milk[1].enabled = false;

        Positions_Water[0].enabled = false;
        Positions_Water[1].enabled = false;

        Positions_Tea[0].enabled = false;
        Positions_Tea[1].enabled = false;

        Positions_Chocolate[0].enabled = false;
        Positions_Chocolate[1].enabled = false;

        //2��° ��ũ ��
        Positions_Ice[2].enabled = false;
        Positions_Ice[3].enabled = false;

        Positions_Caramel[2].enabled = false;
        Positions_Caramel[3].enabled = false;

        Positions_Steam[2].enabled = false;
        Positions_Steam[3].enabled = false;

        Positions_Coffee[2].enabled = false;
        Positions_Coffee[3].enabled = false;

        Positions_Milk[2].enabled = false;
        Positions_Milk[3].enabled = false;

        Positions_Water[2].enabled = false;
        Positions_Water[3].enabled = false;

        Positions_Tea[2].enabled = false;
        Positions_Tea[3].enabled = false;

        Positions_Chocolate[2].enabled = false;
        Positions_Chocolate[3].enabled = false;

        //3��° ��ũ ��
        Positions_Ice[4].enabled = false;
        Positions_Ice[5].enabled = false;

        Positions_Caramel[4].enabled = false;
        Positions_Caramel[5].enabled = false;

        Positions_Steam[4].enabled = false;
        Positions_Steam[5].enabled = false;

        Positions_Coffee[4].enabled = false;
        Positions_Coffee[5].enabled = false;

        Positions_Milk[4].enabled = false;
        Positions_Milk[5].enabled = false;

        Positions_Water[4].enabled = false;
        Positions_Water[5].enabled = false;

        Positions_Tea[4].enabled = false;
        Positions_Tea[5].enabled = false;

        Positions_Chocolate[4].enabled = false;
        Positions_Chocolate[5].enabled = false;

        //ù ��° ��� ��
        Positions_Ice[6].enabled = false;
        Positions_Ice[7].enabled = false;

        Positions_Caramel[6].enabled = false;
        Positions_Caramel[7].enabled = false;

        Positions_Steam[6].enabled = false;
        Positions_Steam[7].enabled = false;

        Positions_Coffee[6].enabled = false;
        Positions_Coffee[7].enabled = false;

        Positions_Milk[6].enabled = false;
        Positions_Milk[7].enabled = false;

        Positions_Water[6].enabled = false;
        Positions_Water[7].enabled = false;

        Positions_Tea[6].enabled = false;
        Positions_Tea[7].enabled = false;

        Positions_Chocolate[6].enabled = false;
        Positions_Chocolate[7].enabled = false;


        //�� ��° ��� ��
        Positions_Ice[8].enabled = false;
        Positions_Ice[9].enabled = false;

        Positions_Caramel[8].enabled = false;
        Positions_Caramel[9].enabled = false;

        Positions_Steam[8].enabled = false;
        Positions_Steam[9].enabled = false;

        Positions_Coffee[8].enabled = false;
        Positions_Coffee[9].enabled = false;

        Positions_Milk[8].enabled = false;
        Positions_Milk[9].enabled = false;

        Positions_Water[8].enabled = false;
        Positions_Water[9].enabled = false;

        Positions_Tea[8].enabled = false;
        Positions_Tea[9].enabled = false;

        Positions_Chocolate[8].enabled = false;
        Positions_Chocolate[9].enabled = false;

        //�� ��° ��� ��
        Positions_Ice[10].enabled = false;
        Positions_Ice[11].enabled = false;

        Positions_Caramel[10].enabled = false;
        Positions_Caramel[11].enabled = false;

        Positions_Steam[10].enabled = false;
        Positions_Steam[11].enabled = false;

        Positions_Coffee[10].enabled = false;
        Positions_Coffee[11].enabled = false;

        Positions_Milk[10].enabled = false;
        Positions_Milk[11].enabled = false;

        Positions_Water[10].enabled = false;
        Positions_Water[11].enabled = false;

        Positions_Tea[10].enabled = false;
        Positions_Tea[11].enabled = false;

        Positions_Chocolate[10].enabled = false;
        Positions_Chocolate[11].enabled = false;

        //Rigidbody2D�� gravityScale�� 0���� ����
        //�߷¿� ������ ���� �ʵ��� ��

        Material_rigid[0].gravityScale = 0.0f;
        Material_rigid[1].gravityScale = 0.0f;
        Material_rigid[2].gravityScale = 0.0f;
        Material_rigid[3].gravityScale = 0.0f;
        Material_rigid[4].gravityScale = 0.0f;
        Material_rigid[5].gravityScale = 0.0f;
        Material_rigid[6].gravityScale = 0.0f;
        Material_rigid[7].gravityScale = 0.0f;

        Material_rigid[8].gravityScale = 0.0f;
        Material_rigid[9].gravityScale = 0.0f;
        Material_rigid[10].gravityScale = 0.0f;
        Material_rigid[11].gravityScale = 0.0f;
        Material_rigid[12].gravityScale = 0.0f;
        Material_rigid[13].gravityScale = 0.0f;
        Material_rigid[14].gravityScale = 0.0f;
        Material_rigid[15].gravityScale = 0.0f;

        //��ũ ��2
        Material_rigid_Pink2[0].gravityScale = 0.0f;
        Material_rigid_Pink2[1].gravityScale = 0.0f;
        Material_rigid_Pink2[2].gravityScale = 0.0f;
        Material_rigid_Pink2[3].gravityScale = 0.0f;
        Material_rigid_Pink2[4].gravityScale = 0.0f;
        Material_rigid_Pink2[5].gravityScale = 0.0f;
        Material_rigid_Pink2[6].gravityScale = 0.0f;
        Material_rigid_Pink2[7].gravityScale = 0.0f;

        Material_rigid_Pink2[8].gravityScale = 0.0f;
        Material_rigid_Pink2[9].gravityScale = 0.0f;
        Material_rigid_Pink2[10].gravityScale = 0.0f;
        Material_rigid_Pink2[11].gravityScale = 0.0f;
        Material_rigid_Pink2[12].gravityScale = 0.0f;
        Material_rigid_Pink2[13].gravityScale = 0.0f;
        Material_rigid_Pink2[14].gravityScale = 0.0f;
        Material_rigid_Pink2[15].gravityScale = 0.0f;

        //��ũ ��3
        Material_rigid_Pink3[0].gravityScale = 0.0f;
        Material_rigid_Pink3[1].gravityScale = 0.0f;
        Material_rigid_Pink3[2].gravityScale = 0.0f;
        Material_rigid_Pink3[3].gravityScale = 0.0f;
        Material_rigid_Pink3[4].gravityScale = 0.0f;
        Material_rigid_Pink3[5].gravityScale = 0.0f;
        Material_rigid_Pink3[6].gravityScale = 0.0f;
        Material_rigid_Pink3[7].gravityScale = 0.0f;

        Material_rigid_Pink3[8].gravityScale = 0.0f;
        Material_rigid_Pink3[9].gravityScale = 0.0f;
        Material_rigid_Pink3[10].gravityScale = 0.0f;
        Material_rigid_Pink3[11].gravityScale = 0.0f;
        Material_rigid_Pink3[12].gravityScale = 0.0f;
        Material_rigid_Pink3[13].gravityScale = 0.0f;
        Material_rigid_Pink3[14].gravityScale = 0.0f;
        Material_rigid_Pink3[15].gravityScale = 0.0f;


        //���1
        //Rigidbody2D�� gravityScale�� 0���� ����
        //�߷¿� ������ ���� �ʵ��� ��

        Material_rigid_Blue1[0].gravityScale = 0.0f;
        Material_rigid_Blue1[1].gravityScale = 0.0f;
        Material_rigid_Blue1[2].gravityScale = 0.0f;
        Material_rigid_Blue1[3].gravityScale = 0.0f;
        Material_rigid_Blue1[4].gravityScale = 0.0f;
        Material_rigid_Blue1[5].gravityScale = 0.0f;
        Material_rigid_Blue1[6].gravityScale = 0.0f;
        Material_rigid_Blue1[7].gravityScale = 0.0f;

        Material_rigid_Blue1[8].gravityScale = 0.0f;
        Material_rigid_Blue1[9].gravityScale = 0.0f;
        Material_rigid_Blue1[10].gravityScale = 0.0f;
        Material_rigid_Blue1[11].gravityScale = 0.0f;
        Material_rigid_Blue1[12].gravityScale = 0.0f;
        Material_rigid_Blue1[13].gravityScale = 0.0f;
        Material_rigid_Blue1[14].gravityScale = 0.0f;
        Material_rigid_Blue1[15].gravityScale = 0.0f;

        //��� ��2
        Material_rigid_Blue2[0].gravityScale = 0.0f;
        Material_rigid_Blue2[1].gravityScale = 0.0f;
        Material_rigid_Blue2[2].gravityScale = 0.0f;
        Material_rigid_Blue2[3].gravityScale = 0.0f;
        Material_rigid_Blue2[4].gravityScale = 0.0f;
        Material_rigid_Blue2[5].gravityScale = 0.0f;
        Material_rigid_Blue2[6].gravityScale = 0.0f;
        Material_rigid_Blue2[7].gravityScale = 0.0f;

        Material_rigid_Blue2[8].gravityScale = 0.0f;
        Material_rigid_Blue2[9].gravityScale = 0.0f;
        Material_rigid_Blue2[10].gravityScale = 0.0f;
        Material_rigid_Blue2[11].gravityScale = 0.0f;
        Material_rigid_Blue2[12].gravityScale = 0.0f;
        Material_rigid_Blue2[13].gravityScale = 0.0f;
        Material_rigid_Blue2[14].gravityScale = 0.0f;
        Material_rigid_Blue2[15].gravityScale = 0.0f;

        //��� ��3
        Material_rigid_Blue3[0].gravityScale = 0.0f;
        Material_rigid_Blue3[1].gravityScale = 0.0f;
        Material_rigid_Blue3[2].gravityScale = 0.0f;
        Material_rigid_Blue3[3].gravityScale = 0.0f;
        Material_rigid_Blue3[4].gravityScale = 0.0f;
        Material_rigid_Blue3[5].gravityScale = 0.0f;
        Material_rigid_Blue3[6].gravityScale = 0.0f;
        Material_rigid_Blue3[7].gravityScale = 0.0f;

        Material_rigid_Blue3[8].gravityScale = 0.0f;
        Material_rigid_Blue3[9].gravityScale = 0.0f;
        Material_rigid_Blue3[10].gravityScale = 0.0f;
        Material_rigid_Blue3[11].gravityScale = 0.0f;
        Material_rigid_Blue3[12].gravityScale = 0.0f;
        Material_rigid_Blue3[13].gravityScale = 0.0f;
        Material_rigid_Blue3[14].gravityScale = 0.0f;
        Material_rigid_Blue3[15].gravityScale = 0.0f;



    }

    public void Update()
    {
        for (int i = 0; i < move_material.selection_Pink_24.Length; i++)
        {
            if (move_material.selection_Pink_24[i].activeSelf && move_material.Pink_24[i].activeSelf && move_material.Pink_24[i].transform.childCount > 1)
            {
                //������ ���õǾ��� ����� ������ �ڽ��� 1�� �ʰ� �ִٸ�(2�� �̻�)

                blue_pink.Pink_Cups1[0].SetActive(false);//��
                blue_pink.Pink_Cups1[1].SetActive(false);//��
                blue_pink.Pink_Cups1[2].SetActive(false);//��

                blue_pink.Pink_Cups2[0].SetActive(true);//��
                blue_pink.Pink_Cups2[1].SetActive(true);//��
                blue_pink.Pink_Cups2[2].SetActive(true);//��

                blue_pink.Blue_Cups1[0].SetActive(false);//��
                blue_pink.Blue_Cups1[1].SetActive(false);//��
                blue_pink.Blue_Cups1[2].SetActive(false);//��

                blue_pink.Blue_Cups2[0].SetActive(false);//��
                blue_pink.Blue_Cups2[1].SetActive(false);//��
                blue_pink.Blue_Cups2[2].SetActive(false);//��
            }

            if (move_material.selection_Pink_24[i].activeSelf == false && move_material.Pink_24[i].activeSelf && move_material.Pink_24[i].transform.childCount < 1)
            {
                //������ ���õ��� �ʾҰ� ����� ������ �ڽ��� 1�� �̸��̴� (0��, 1��)

                blue_pink.Pink_Cups1[0].SetActive(true);//��
                blue_pink.Pink_Cups1[1].SetActive(true);//��
                blue_pink.Pink_Cups1[2].SetActive(true);//��

                blue_pink.Pink_Cups2[0].SetActive(false);//��
                blue_pink.Pink_Cups2[1].SetActive(false);//��
                blue_pink.Pink_Cups2[2].SetActive(false);//��

                blue_pink.Blue_Cups1[0].SetActive(false);//��
                blue_pink.Blue_Cups1[1].SetActive(false);//��
                blue_pink.Blue_Cups1[2].SetActive(false);//��

                blue_pink.Blue_Cups2[0].SetActive(false);//��
                blue_pink.Blue_Cups2[1].SetActive(false);//��
                blue_pink.Blue_Cups2[2].SetActive(false);//��
            }
        }

        for (int i = 0; i < move_material.selection_Blue_24.Length; i++)
        {
            if (move_material.selection_Blue_24[i].activeSelf && move_material.Blue_24[i].activeSelf && move_material.Blue_24[i].transform.childCount > 1)
            {
                //�Ķ��� ���õǾ��� ����� ������ �ڽ��� 1�� �ʰ� �ִٸ�(2�� �̻�)

                blue_pink.Pink_Cups1[0].SetActive(false);//��
                blue_pink.Pink_Cups1[1].SetActive(false);//��
                blue_pink.Pink_Cups1[2].SetActive(false);//��

                blue_pink.Pink_Cups2[0].SetActive(false);//��
                blue_pink.Pink_Cups2[1].SetActive(false);//��
                blue_pink.Pink_Cups2[2].SetActive(false);//��

                blue_pink.Blue_Cups1[0].SetActive(false);//��
                blue_pink.Blue_Cups1[1].SetActive(false);//��
                blue_pink.Blue_Cups1[2].SetActive(false);//��

                blue_pink.Blue_Cups2[0].SetActive(true);//��
                blue_pink.Blue_Cups2[1].SetActive(true);//��
                blue_pink.Blue_Cups2[2].SetActive(true);//��
            }

            if (move_material.selection_Blue_24[i].activeSelf == false && move_material.Blue_24[i].activeSelf && move_material.Blue_24[i].transform.childCount < 1)
            {
                //�Ķ��� ���õ��� �ʾҰ� ����� ������ �ڽ��� 1�� �̸��̴� (0��, 1��)

                blue_pink.Pink_Cups1[0].SetActive(false);//��
                blue_pink.Pink_Cups1[1].SetActive(false);//��
                blue_pink.Pink_Cups1[2].SetActive(false);//��

                blue_pink.Pink_Cups2[0].SetActive(false);//��
                blue_pink.Pink_Cups2[1].SetActive(false);//��
                blue_pink.Pink_Cups2[2].SetActive(false);//��

                blue_pink.Blue_Cups1[0].SetActive(true);//��
                blue_pink.Blue_Cups1[1].SetActive(true);//��
                blue_pink.Blue_Cups1[2].SetActive(true);//��

                blue_pink.Blue_Cups2[0].SetActive(false);//��
                blue_pink.Blue_Cups2[1].SetActive(false);//��
                blue_pink.Blue_Cups2[2].SetActive(false);//��
            }
        }

    }

    public void Next_Cup_Pink_One()
    {
        //��ũ �� ���� Ȯ��
        Pink_Inside[0].SetActive(true);
        Pink_Inside[1].SetActive(false);
        Pink_Inside[2].SetActive(false);

        //��� �� ���� Ȯ��
        Blue_Inside[0].SetActive(false);
        Blue_Inside[1].SetActive(false);
        Blue_Inside[2].SetActive(false);

        sfx.SFX_Button();

    }

    public void Next_Cup_Pink_Two()
    {
        //��ũ �� ���� Ȯ��
        Pink_Inside[0].SetActive(false);
        Pink_Inside[1].SetActive(true);
        Pink_Inside[2].SetActive(false);

        //��� �� ���� Ȯ��
        Blue_Inside[0].SetActive(false);
        Blue_Inside[1].SetActive(false);
        Blue_Inside[2].SetActive(false);

        sfx.SFX_Button();
    }

    public void Next_Cup_Pink_Three()
    {
        //��ũ �� ���� Ȯ��
        Pink_Inside[0].SetActive(false);
        Pink_Inside[1].SetActive(false);
        Pink_Inside[2].SetActive(true);

        //��� �� ���� Ȯ��
        Blue_Inside[0].SetActive(false);
        Blue_Inside[1].SetActive(false);
        Blue_Inside[2].SetActive(false);

        sfx.SFX_Button();
    }

    public void Next_Cup_Blue_One()
    {
        //��ũ �� ���� Ȯ��
        Pink_Inside[0].SetActive(false);
        Pink_Inside[1].SetActive(false);
        Pink_Inside[2].SetActive(false);

        //��� �� ���� Ȯ��
        Blue_Inside[0].SetActive(true);
        Blue_Inside[1].SetActive(false);
        Blue_Inside[2].SetActive(false);

        sfx.SFX_Button();
    }

    public void Next_Cup_Blue_Two()
    {
        //��ũ �� ���� Ȯ��
        Pink_Inside[0].SetActive(false);
        Pink_Inside[1].SetActive(false);
        Pink_Inside[2].SetActive(false);

        //��� �� ���� Ȯ��
        Blue_Inside[0].SetActive(false);
        Blue_Inside[1].SetActive(true);
        Blue_Inside[2].SetActive(false);

        sfx.SFX_Button();
    }

    public void Next_Cup_Blue_Three()
    {
        //��ũ �� ���� Ȯ��
        Pink_Inside[0].SetActive(false);
        Pink_Inside[1].SetActive(false);
        Pink_Inside[2].SetActive(false);

        //��� �� ���� Ȯ��
        Blue_Inside[0].SetActive(false);
        Blue_Inside[1].SetActive(false);
        Blue_Inside[2].SetActive(true);

        sfx.SFX_Button();
    }


    public void Go_Pink_Inside_1()//��ũ ù��° �� ���빰 Ȯ��
    {
        Pink_Inside[0].SetActive(true);
        Pink_Inside[1].SetActive(false);
        Pink_Inside[2].SetActive(false);

    }

    public void Go_Pink_Inside_2()//��ũ �ι�° �� ���빰 Ȯ��
    {
        Pink_Inside[0].SetActive(false);
        Pink_Inside[1].SetActive(true);
        Pink_Inside[2].SetActive(false);

    }

    public void Go_Pink_Inside_3()//��ũ ����° �� ���빰 Ȯ��
    {
        Pink_Inside[0].SetActive(false);
        Pink_Inside[1].SetActive(false);
        Pink_Inside[2].SetActive(true);
    }

    public void Go_Blue_Inside_1()//��� ù��° �� ���빰 Ȯ��
    {
        Blue_Inside[0].SetActive(true);
        Blue_Inside[1].SetActive(false);
        Blue_Inside[2].SetActive(false);

    }

    public void Go_Blue_Inside_2()//��� �ι�° �� ���빰 Ȯ��
    {
        Blue_Inside[0].SetActive(false);
        Blue_Inside[1].SetActive(true);
        Blue_Inside[2].SetActive(false);


    }

    public void Go_Blue_Inside_3()//��� ����° �� ���빰 Ȯ��
    {
        Blue_Inside[0].SetActive(false);
        Blue_Inside[1].SetActive(false);
        Blue_Inside[2].SetActive(true);

    }

    public void Go_Back_Game()//�ڷ� ���� ��ư
    {
        Blue_Inside[0].SetActive(false);
        Blue_Inside[1].SetActive(false);
        Blue_Inside[2].SetActive(false);

        Pink_Inside[0].SetActive(false);
        Pink_Inside[1].SetActive(false);
        Pink_Inside[2].SetActive(false);

        /*for(int i=0; i< 33; i++)
        {
            cup_menu.Coffee[i].SetActive(false);
        }*/
 

    }

    public void Go_Back_Cup()
    {
        for (int i = 0; i < 33; i++)
        {
            cup_menu.Coffee[i].SetActive(false);
        }
    }

    public void Trash_Cup_Pink_One()
    {
        if(Material_Positions_Ice[0].childCount == 1 || Material_Positions_Ice[1].childCount == 1||
            Material_Positions_Caramel[0].childCount == 1 || Material_Positions_Caramel[1].childCount == 1
            || Material_Positions_Steam[0].childCount == 1 || Material_Positions_Steam[1].childCount == 1||
            Material_Positions_Coffee[0].childCount == 1 || Material_Positions_Coffee[1].childCount == 1||
            Material_Positions_Milk[0].childCount == 1 || Material_Positions_Milk[1].childCount == 1||
            Material_Positions_Water[0].childCount == 1 || Material_Positions_Water[1].childCount == 1
            || Material_Positions_Tea[0].childCount == 1 || Material_Positions_Tea[1].childCount == 1
            || Material_Positions_Chocolate[0].childCount == 1 || Material_Positions_Chocolate[1].childCount == 1)
        {

            if (Material_Positions_Ice[0].childCount == 1)
            {
                Destroy(Material_Positions_Ice[0].transform.GetChild(0).gameObject);

                Material_rigid[0].gravityScale = 0.0f;
                Positions_Ice[0].enabled = false;

                Material_Positions_Ice[0].anchoredPosition = new Vector2(-48f, -42.7f);


            }

            if (Material_Positions_Ice[1].childCount == 1)
            {
                Destroy(Material_Positions_Ice[1].transform.GetChild(0).gameObject);


                Material_rigid[1].gravityScale = 0.0f;
                Positions_Ice[1].enabled = false;

                Material_Positions_Ice[1].anchoredPosition = new Vector2(-91.4f, -58.6f);


            }

            if (Material_Positions_Caramel[0].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[0].transform.GetChild(0).gameObject);

                Material_rigid[2].gravityScale = 0.0f;
                Positions_Caramel[0].enabled = false;

                Material_Positions_Caramel[0].anchoredPosition = new Vector2(-43.6f, -56f);


            }

            if ( Material_Positions_Caramel[1].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[1].transform.GetChild(0).gameObject);

                Material_rigid[3].gravityScale = 0.0f;
                Positions_Caramel[1].enabled = false;

                Material_Positions_Caramel[1].anchoredPosition = new Vector2(4.6f, -53.1f);

            }

            if (Material_Positions_Steam[0].childCount == 1)
            {
                Destroy(Material_Positions_Steam[0].transform.GetChild(0).gameObject);

                Material_rigid[4].gravityScale = 0.0f;
                Positions_Steam[0].enabled = false;

                Material_Positions_Steam[0].anchoredPosition = new Vector2(-107.9f, -15.5f);


            }

            if (Material_Positions_Steam[1].childCount == 1)
            {
                Destroy(Material_Positions_Steam[1].transform.GetChild(0).gameObject);

                Material_rigid[5].gravityScale = 0.0f;
                Positions_Steam[1].enabled = false;

               
                Material_Positions_Steam[1].anchoredPosition = new Vector2(8.5f, -41.9f);


            }


            if (Material_Positions_Coffee[0].childCount == 1 )
            {
                Destroy(Material_Positions_Coffee[0].transform.GetChild(0).gameObject);

                Material_rigid[6].gravityScale = 0.0f;
                Positions_Coffee[0].enabled = false;

                Material_Positions_Coffee[0].anchoredPosition = new Vector2(-90.3f, -46.2f);
            }

            if (Material_Positions_Coffee[1].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[1].transform.GetChild(0).gameObject);

                Material_rigid[7].gravityScale = 0.0f;
                Positions_Coffee[1].enabled = false;

                Material_Positions_Coffee[1].anchoredPosition = new Vector2(17.9f, -47.6f);

            }


            if (Material_Positions_Milk[0].childCount == 1)
            {
                Destroy(Material_Positions_Milk[0].transform.GetChild(0).gameObject);

                Material_rigid[8].gravityScale = 0.0f;
                Positions_Milk[0].enabled = false;

                Material_Positions_Milk[0].anchoredPosition = new Vector2(-9.3f, -35.6f);

            }

            if ( Material_Positions_Milk[1].childCount == 1)
            {

                Destroy(Material_Positions_Milk[1].transform.GetChild(0).gameObject);

                Material_rigid[9].gravityScale = 0.0f;
                Positions_Milk[1].enabled = false;

             
                Material_Positions_Milk[1].anchoredPosition = new Vector2(33f, -45.5f);

            }

            if (Material_Positions_Water[0].childCount == 1)
            {
                Destroy(Material_Positions_Water[0].transform.GetChild(0).gameObject);

                Material_rigid[10].gravityScale = 0.0f;
                Positions_Water[0].enabled = false;

                Material_Positions_Water[0].anchoredPosition = new Vector2(21.7f, -37.3f);

            }

            if ( Material_Positions_Water[1].childCount == 1)
            {
                Destroy(Material_Positions_Water[1].transform.GetChild(0).gameObject);


                Material_rigid[11].gravityScale = 0.0f;
                Positions_Water[1].enabled = false;

                Material_Positions_Water[1].anchoredPosition = new Vector2(-29.8f, -25.3f);

            }

            if (Material_Positions_Tea[0].childCount == 1)
            {
                Destroy(Material_Positions_Tea[0].transform.GetChild(0).gameObject);

                Material_rigid[12].gravityScale = 0.0f;
                Positions_Tea[0].enabled = false;

              
                Material_Positions_Tea[0].anchoredPosition = new Vector2(-61.9f, -46.9f);

            }

            if (Material_Positions_Tea[1].childCount == 1)
            {
                Destroy(Material_Positions_Tea[1].transform.GetChild(0).gameObject);

                Material_rigid[13].gravityScale = 0.0f;
                Positions_Tea[1].enabled = false;

               
                Material_Positions_Tea[1].anchoredPosition = new Vector2(-56.5f, -33.9f);

            }

            if (Material_Positions_Chocolate[0].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[0].transform.GetChild(0).gameObject);

                Material_rigid[14].gravityScale = 0.0f;
                Positions_Chocolate[0].enabled = false;

                Material_Positions_Chocolate[0].anchoredPosition = new Vector2(-10.7f, -36.3f);
            }

            if (Material_Positions_Chocolate[1].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[1].transform.GetChild(0).gameObject);

                Material_rigid[15].gravityScale = 0.0f;
                Positions_Chocolate[1].enabled = false;

                Material_Positions_Chocolate[1].anchoredPosition = new Vector2(-14.1f, -32.7f);
            }

            sfx.SFX_Trash_Button();

        }




    }

    public void Trash_Cup_Pink_Two()
    {
        if (Material_Positions_Ice[2].childCount == 1 || Material_Positions_Ice[3].childCount == 1 ||
            Material_Positions_Caramel[2].childCount == 1 || Material_Positions_Caramel[3].childCount == 1
            || Material_Positions_Steam[2].childCount == 1 || Material_Positions_Steam[3].childCount == 1 ||
            Material_Positions_Coffee[2].childCount == 1 || Material_Positions_Coffee[3].childCount == 1 ||
            Material_Positions_Milk[2].childCount == 1 || Material_Positions_Milk[3].childCount == 1 ||
            Material_Positions_Water[2].childCount == 1 || Material_Positions_Water[3].childCount == 1
            || Material_Positions_Tea[2].childCount == 1 || Material_Positions_Tea[3].childCount == 1
            || Material_Positions_Chocolate[2].childCount == 1 || Material_Positions_Chocolate[3].childCount == 1)
        {

            if (Material_Positions_Ice[2].childCount == 1)
            {
                Destroy(Material_Positions_Ice[2].transform.GetChild(0).gameObject);

                

                Material_rigid_Pink2[0].gravityScale = 0.0f;

                Positions_Ice[2].enabled = false;

                Material_Positions_Ice[2].anchoredPosition = new Vector2(-48f, -42.7f);
                


            }

            if (Material_Positions_Ice[3].childCount == 1)
            {
                Destroy(Material_Positions_Ice[3].transform.GetChild(0).gameObject);


                Material_rigid_Pink2[1].gravityScale = 0.0f;
                Positions_Ice[3].enabled = false;

                Material_Positions_Ice[3].anchoredPosition = new Vector2(-91.4f, -58.6f);
                

            }

            if (Material_Positions_Caramel[2].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[2].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[2].gravityScale = 0.0f;
                Positions_Caramel[2].enabled = false;

                Material_Positions_Caramel[2].anchoredPosition = new Vector2(-43.6f, -56f);
              
            }

            if (Material_Positions_Caramel[3].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[3].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[3].gravityScale = 0.0f;
                Positions_Caramel[3].enabled = false;

                Material_Positions_Caramel[3].anchoredPosition = new Vector2(4.6f, -53.1f);
                
            }

            if (Material_Positions_Steam[2].childCount == 1)
            {
                Destroy(Material_Positions_Steam[2].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[4].gravityScale = 0.0f;
                Positions_Steam[2].enabled = false;

                Material_Positions_Steam[2].anchoredPosition = new Vector2(-107.9f, -15.5f);
         
            }

            if (Material_Positions_Steam[3].childCount == 1)
            {
                Destroy(Material_Positions_Steam[3].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[5].gravityScale = 0.0f;
                Positions_Steam[3].enabled = false;

                Material_Positions_Steam[3].anchoredPosition = new Vector2(8.5f, -41.9f);
               
            }


            if (Material_Positions_Coffee[2].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[2].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[6].gravityScale = 0.0f;
                Positions_Coffee[2].enabled = false;

                Material_Positions_Coffee[2].anchoredPosition = new Vector2(-90.3f, -46.2f);
               

            }

            if (Material_Positions_Coffee[3].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[3].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[7].gravityScale = 0.0f;
                Positions_Coffee[3].enabled = false;

                Material_Positions_Coffee[3].anchoredPosition = new Vector2(17.9f, -47.6f);
                
            }


            if (Material_Positions_Milk[2].childCount == 1)
            {
                Destroy(Material_Positions_Milk[2].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[8].gravityScale = 0.0f;
                Positions_Milk[2].enabled = false;

                Material_Positions_Milk[2].anchoredPosition = new Vector2(-9.3f, -35.6f);
                
            }

            if (Material_Positions_Milk[3].childCount == 1)
            {

                Destroy(Material_Positions_Milk[3].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[9].gravityScale = 0.0f;
                Positions_Milk[3].enabled = false;

                Material_Positions_Milk[3].anchoredPosition = new Vector2(33f, -45.5f);
                
            }

            if (Material_Positions_Water[2].childCount == 1)
            {
                Destroy(Material_Positions_Water[2].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[10].gravityScale = 0.0f;
                Positions_Water[2].enabled = false;

                Material_Positions_Water[2].anchoredPosition = new Vector2(21.7f, -37.3f);
                
            }

            if (Material_Positions_Water[3].childCount == 1)
            {
                Destroy(Material_Positions_Water[3].transform.GetChild(0).gameObject);


                Material_rigid_Pink2[11].gravityScale = 0.0f;
                Positions_Water[3].enabled = false;

                Material_Positions_Water[3].anchoredPosition = new Vector2(-29.8f, -25.3f);
             
            }

            if (Material_Positions_Tea[2].childCount == 1)
            {
                Destroy(Material_Positions_Tea[2].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[12].gravityScale = 0.0f;
                Positions_Tea[2].enabled = false;

                Material_Positions_Tea[2].anchoredPosition = new Vector2(-61.9f, -46.9f);
                


            }

            if (Material_Positions_Tea[3].childCount == 1)
            {
                Destroy(Material_Positions_Tea[3].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[13].gravityScale = 0.0f;
                Positions_Tea[3].enabled = false;

                Material_Positions_Tea[3].anchoredPosition = new Vector2(-56.5f, -33.9f);
                


            }

            if (Material_Positions_Chocolate[2].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[2].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[14].gravityScale = 0.0f;
                Positions_Chocolate[2].enabled = false;

                Material_Positions_Chocolate[2].anchoredPosition = new Vector2(-10.7f, -36.3f);
               
            }

            if (Material_Positions_Chocolate[3].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[3].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[15].gravityScale = 0.0f;
                Positions_Chocolate[3].enabled = false;

                Material_Positions_Chocolate[3].anchoredPosition = new Vector2(-14.1f, -32.7f);
            }

            sfx.SFX_Trash_Button();

        }
    }

    public void Trash_Cup_Pink_Three()
    {
        if (Material_Positions_Ice[4].childCount == 1 || Material_Positions_Ice[5].childCount == 1 ||
            Material_Positions_Caramel[4].childCount == 1 || Material_Positions_Caramel[5].childCount == 1
            || Material_Positions_Steam[4].childCount == 1 || Material_Positions_Steam[5].childCount == 1 ||
            Material_Positions_Coffee[4].childCount == 1 || Material_Positions_Coffee[5].childCount == 1 ||
            Material_Positions_Milk[4].childCount == 1 || Material_Positions_Milk[5].childCount == 1 ||
            Material_Positions_Water[4].childCount == 1 || Material_Positions_Water[5].childCount == 1
            || Material_Positions_Tea[4].childCount == 1 || Material_Positions_Tea[5].childCount == 1
            || Material_Positions_Chocolate[4].childCount == 1 || Material_Positions_Chocolate[5].childCount == 1)
        {

            if (Material_Positions_Ice[4].childCount == 1)
            {
                Destroy(Material_Positions_Ice[4].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[0].gravityScale = 0.0f;
                Positions_Ice[4].enabled = false;

                Material_Positions_Ice[4].anchoredPosition = new Vector2(-48f, -42.7f);


            }

            if (Material_Positions_Ice[5].childCount == 1)
            {
                Destroy(Material_Positions_Ice[5].transform.GetChild(0).gameObject);


                Material_rigid_Pink3[1].gravityScale = 0.0f;
                Positions_Ice[5].enabled = false;

                Material_Positions_Ice[5].anchoredPosition = new Vector2(-91.4f, -58.6f);


            }

            if (Material_Positions_Caramel[4].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[4].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[2].gravityScale = 0.0f;
                Positions_Caramel[4].enabled = false;

                Material_Positions_Caramel[4].anchoredPosition = new Vector2(-43.6f, -56f);

            }

            if (Material_Positions_Caramel[5].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[5].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[3].gravityScale = 0.0f;
                Positions_Caramel[5].enabled = false;

             
                Material_Positions_Caramel[5].anchoredPosition = new Vector2(4.6f, -53.1f);

            }

            if (Material_Positions_Steam[4].childCount == 1)
            {
                Destroy(Material_Positions_Steam[4].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[4].gravityScale = 0.0f;
                Positions_Steam[4].enabled = false;

                Material_Positions_Steam[4].anchoredPosition = new Vector2(-107.9f, -15.5f);
   
            }

            if (Material_Positions_Steam[5].childCount == 1)
            {
                Destroy(Material_Positions_Steam[5].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[5].gravityScale = 0.0f;
                Positions_Steam[5].enabled = false;

            
                Material_Positions_Steam[5].anchoredPosition = new Vector2(8.5f, -41.9f);

            }


            if (Material_Positions_Coffee[4].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[4].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[6].gravityScale = 0.0f;
                Positions_Coffee[4].enabled = false;

              
                Material_Positions_Coffee[4].anchoredPosition = new Vector2(-90.3f, -46.2f);


            }

            if (Material_Positions_Coffee[5].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[5].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[7].gravityScale = 0.0f;
                Positions_Coffee[5].enabled = false;

                Material_Positions_Coffee[5].anchoredPosition = new Vector2(17.9f, -47.6f);

            }


            if (Material_Positions_Milk[4].childCount == 1)
            {
                Destroy(Material_Positions_Milk[4].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[8].gravityScale = 0.0f;
                Positions_Milk[4].enabled = false;

                Material_Positions_Milk[4].anchoredPosition = new Vector2(-9.3f, -35.6f);
  
            }

            if (Material_Positions_Milk[5].childCount == 1)
            {

                Destroy(Material_Positions_Milk[5].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[9].gravityScale = 0.0f;
                Positions_Milk[5].enabled = false;

             
                Material_Positions_Milk[5].anchoredPosition = new Vector2(33f, -45.5f);

            }

            if (Material_Positions_Water[4].childCount == 1)
            {
                Destroy(Material_Positions_Water[4].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[10].gravityScale = 0.0f;
                Positions_Water[4].enabled = false;

              
                Material_Positions_Water[4].anchoredPosition = new Vector2(21.7f, -37.3f);
    
            }

            if (Material_Positions_Water[5].childCount == 1)
            {
                Destroy(Material_Positions_Water[5].transform.GetChild(0).gameObject);


                Material_rigid_Pink3[11].gravityScale = 0.0f;
                Positions_Water[5].enabled = false;

              
                Material_Positions_Water[5].anchoredPosition = new Vector2(-29.8f, -25.3f);

            }

            if (Material_Positions_Tea[4].childCount == 1)
            {
                Destroy(Material_Positions_Tea[4].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[12].gravityScale = 0.0f;
                Positions_Tea[4].enabled = false;

              
                Material_Positions_Tea[4].anchoredPosition = new Vector2(-61.9f, -46.9f);



            }

            if (Material_Positions_Tea[5].childCount == 1)
            {
                Destroy(Material_Positions_Tea[5].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[13].gravityScale = 0.0f;
                Positions_Tea[5].enabled = false;

                Material_Positions_Tea[5].anchoredPosition = new Vector2(-56.5f, -33.9f);



            }

            if (Material_Positions_Chocolate[4].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[4].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[14].gravityScale = 0.0f;
                Positions_Chocolate[4].enabled = false;

              
                Material_Positions_Chocolate[4].anchoredPosition = new Vector2(-10.7f, -36.3f);
 
            }

            if (Material_Positions_Chocolate[5].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[5].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[15].gravityScale = 0.0f;
                Positions_Chocolate[5].enabled = false;

                Material_Positions_Chocolate[5].anchoredPosition = new Vector2(-14.1f, -32.7f);
            }

            sfx.SFX_Trash_Button();

        }
    }

    public void Trash_Cup_Blue_One()
    {
        if (Material_Positions_Ice[6].childCount == 1 || Material_Positions_Ice[7].childCount == 1 ||
            Material_Positions_Caramel[6].childCount == 1 || Material_Positions_Caramel[7].childCount == 1
            || Material_Positions_Steam[6].childCount == 1 || Material_Positions_Steam[7].childCount == 1 ||
            Material_Positions_Coffee[6].childCount == 1 || Material_Positions_Coffee[7].childCount == 1 ||
            Material_Positions_Milk[6].childCount == 1 || Material_Positions_Milk[7].childCount == 1 ||
            Material_Positions_Water[6].childCount == 1 || Material_Positions_Water[7].childCount == 1
            || Material_Positions_Tea[6].childCount == 1 || Material_Positions_Tea[7].childCount == 1
            || Material_Positions_Chocolate[6].childCount == 1 || Material_Positions_Chocolate[7].childCount == 1)
        {

            if (Material_Positions_Ice[6].childCount == 1)
            {
                Destroy(Material_Positions_Ice[6].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[0].gravityScale = 0.0f;
                Positions_Ice[6].enabled = false;

                Material_Positions_Ice[6].anchoredPosition = new Vector2(-48f, -42.7f);


            }

            if (Material_Positions_Ice[7].childCount == 1)
            {
                Destroy(Material_Positions_Ice[7].transform.GetChild(0).gameObject);


                Material_rigid_Blue1[1].gravityScale = 0.0f;
                Positions_Ice[7].enabled = false;

                Material_Positions_Ice[7].anchoredPosition = new Vector2(-91.4f, -58.6f);


            }

            if (Material_Positions_Caramel[6].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[6].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[2].gravityScale = 0.0f;
                Positions_Caramel[6].enabled = false;

              
                Material_Positions_Caramel[6].anchoredPosition = new Vector2(-43.6f, -56f);
       
            }

            if (Material_Positions_Caramel[7].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[7].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[3].gravityScale = 0.0f;
                Positions_Caramel[7].enabled = false;

                Material_Positions_Caramel[7].anchoredPosition = new Vector2(4.6f, -53.1f);

            }

            if (Material_Positions_Steam[6].childCount == 1)
            {
                Destroy(Material_Positions_Steam[6].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[4].gravityScale = 0.0f;
                Positions_Steam[6].enabled = false;

              
                Material_Positions_Steam[6].anchoredPosition = new Vector2(-107.9f, -15.5f);
          
            }

            if (Material_Positions_Steam[7].childCount == 1)
            {
                Destroy(Material_Positions_Steam[7].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[5].gravityScale = 0.0f;
                Positions_Steam[7].enabled = false;

            
                Material_Positions_Steam[7].anchoredPosition = new Vector2(8.5f, -41.9f);
      
            }


            if (Material_Positions_Coffee[6].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[6].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[6].gravityScale = 0.0f;
                Positions_Coffee[6].enabled = false;

               
                Material_Positions_Coffee[6].anchoredPosition = new Vector2(-90.3f, -46.2f);


            }

            if (Material_Positions_Coffee[7].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[7].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[7].gravityScale = 0.0f;
                Positions_Coffee[7].enabled = false;

              
                Material_Positions_Coffee[7].anchoredPosition = new Vector2(17.9f, -47.6f);
            
            }


            if (Material_Positions_Milk[6].childCount == 1)
            {
                Destroy(Material_Positions_Milk[6].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[8].gravityScale = 0.0f;
                Positions_Milk[6].enabled = false;

              
                Material_Positions_Milk[6].anchoredPosition = new Vector2(-9.3f, -35.6f);
 
            }

            if (Material_Positions_Milk[7].childCount == 1)
            {

                Destroy(Material_Positions_Milk[7].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[9].gravityScale = 0.0f;
                Positions_Milk[7].enabled = false;

             
                Material_Positions_Milk[7].anchoredPosition = new Vector2(33f, -45.5f);

            }

            if (Material_Positions_Water[6].childCount == 1)
            {
                Destroy(Material_Positions_Water[6].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[10].gravityScale = 0.0f;
                Positions_Water[6].enabled = false;

              
                Material_Positions_Water[6].anchoredPosition = new Vector2(21.7f, -37.3f);
 
            }

            if (Material_Positions_Water[7].childCount == 1)
            {
                Destroy(Material_Positions_Water[7].transform.GetChild(0).gameObject);


                Material_rigid_Blue1[11].gravityScale = 0.0f;
                Positions_Water[7].enabled = false;

          
                Material_Positions_Water[7].anchoredPosition = new Vector2(-29.8f, -25.3f);
  
            }

            if (Material_Positions_Tea[6].childCount == 1)
            {
                Destroy(Material_Positions_Tea[6].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[12].gravityScale = 0.0f;
                Positions_Tea[6].enabled = false;

                Material_Positions_Tea[6].anchoredPosition = new Vector2(-61.9f, -46.9f);



            }

            if (Material_Positions_Tea[7].childCount == 1)
            {
                Destroy(Material_Positions_Tea[7].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[13].gravityScale = 0.0f;
                Positions_Tea[7].enabled = false;

           
                Material_Positions_Tea[7].anchoredPosition = new Vector2(-56.5f, -33.9f);



            }

            if (Material_Positions_Chocolate[6].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[6].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[14].gravityScale = 0.0f;
                Positions_Chocolate[6].enabled = false;

            
                Material_Positions_Chocolate[6].anchoredPosition = new Vector2(-10.7f, -36.3f);
         
            }

            if (Material_Positions_Chocolate[7].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[7].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[15].gravityScale = 0.0f;
                Positions_Chocolate[7].enabled = false;

        
                Material_Positions_Chocolate[7].anchoredPosition = new Vector2(-14.1f, -32.7f);
            }

            sfx.SFX_Trash_Button();

        }
    }

    public void Trash_Cup_Blue_Two()
    {
        if (Material_Positions_Ice[8].childCount == 1 || Material_Positions_Ice[9].childCount == 1 ||
            Material_Positions_Caramel[8].childCount == 1 || Material_Positions_Caramel[9].childCount == 1
            || Material_Positions_Steam[8].childCount == 1 || Material_Positions_Steam[9].childCount == 1 ||
            Material_Positions_Coffee[8].childCount == 1 || Material_Positions_Coffee[9].childCount == 1 ||
            Material_Positions_Milk[8].childCount == 1 || Material_Positions_Milk[9].childCount == 1 ||
            Material_Positions_Water[8].childCount == 1 || Material_Positions_Water[9].childCount == 1
            || Material_Positions_Tea[8].childCount == 1 || Material_Positions_Tea[9].childCount == 1
            || Material_Positions_Chocolate[8].childCount == 1 || Material_Positions_Chocolate[9].childCount == 1)
        {

            if (Material_Positions_Ice[8].childCount == 1)
            {
                Destroy(Material_Positions_Ice[8].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[0].gravityScale = 0.0f;
                Positions_Ice[8].enabled = false;

                Material_Positions_Ice[8].anchoredPosition = new Vector2(-48f, -42.7f);
        

            }

            if (Material_Positions_Ice[9].childCount == 1)
            {
                Destroy(Material_Positions_Ice[9].transform.GetChild(0).gameObject);


                Material_rigid_Blue2[1].gravityScale = 0.0f;
                Positions_Ice[9].enabled = false;

                Material_Positions_Ice[9].anchoredPosition = new Vector2(-91.4f, -58.6f);


            }

            if (Material_Positions_Caramel[8].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[8].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[2].gravityScale = 0.0f;
                Positions_Caramel[8].enabled = false;

               
                Material_Positions_Caramel[8].anchoredPosition = new Vector2(-43.6f, -56f);
    
            }

            if (Material_Positions_Caramel[9].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[9].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[3].gravityScale = 0.0f;
                Positions_Caramel[9].enabled = false;

                Material_Positions_Caramel[9].anchoredPosition = new Vector2(4.6f, -53.1f);
  
            }

            if (Material_Positions_Steam[8].childCount == 1)
            {
                Destroy(Material_Positions_Steam[8].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[4].gravityScale = 0.0f;
                Positions_Steam[8].enabled = false;

              
                Material_Positions_Steam[8].anchoredPosition = new Vector2(-107.9f, -15.5f);
        
            }

            if (Material_Positions_Steam[9].childCount == 1)
            {
                Destroy(Material_Positions_Steam[9].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[5].gravityScale = 0.0f;
                Positions_Steam[9].enabled = false;

               
                Material_Positions_Steam[9].anchoredPosition = new Vector2(8.5f, -41.9f);
         
            }


            if (Material_Positions_Coffee[8].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[8].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[6].gravityScale = 0.0f;
                Positions_Coffee[8].enabled = false;

              
                Material_Positions_Coffee[8].anchoredPosition = new Vector2(-90.3f, -46.2f);
           

            }

            if (Material_Positions_Coffee[9].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[9].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[7].gravityScale = 0.0f;
                Positions_Coffee[9].enabled = false;

                Material_Positions_Coffee[9].anchoredPosition = new Vector2(17.9f, -47.6f);
           
            }


            if (Material_Positions_Milk[8].childCount == 1)
            {
                Destroy(Material_Positions_Milk[8].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[8].gravityScale = 0.0f;
                Positions_Milk[8].enabled = false;

             
                Material_Positions_Milk[8].anchoredPosition = new Vector2(-9.3f, -35.6f);
          
            }

            if (Material_Positions_Milk[9].childCount == 1)
            {

                Destroy(Material_Positions_Milk[9].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[9].gravityScale = 0.0f;
                Positions_Milk[9].enabled = false;

               
                Material_Positions_Milk[9].anchoredPosition = new Vector2(33f, -45.5f);

            }

            if (Material_Positions_Water[8].childCount == 1)
            {
                Destroy(Material_Positions_Water[8].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[10].gravityScale = 0.0f;
                Positions_Water[8].enabled = false;

              
                Material_Positions_Water[8].anchoredPosition = new Vector2(21.7f, -37.3f);

            }

            if (Material_Positions_Water[9].childCount == 1)
            {
                Destroy(Material_Positions_Water[9].transform.GetChild(0).gameObject);


                Material_rigid_Blue2[11].gravityScale = 0.0f;
                Positions_Water[9].enabled = false;

                Material_Positions_Water[9].anchoredPosition = new Vector2(-29.8f, -25.3f);

            }

            if (Material_Positions_Tea[8].childCount == 1)
            {
                Destroy(Material_Positions_Tea[8].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[12].gravityScale = 0.0f;
                Positions_Tea[8].enabled = false;

                Material_Positions_Tea[8].anchoredPosition = new Vector2(-61.9f, -46.9f);



            }

            if (Material_Positions_Tea[9].childCount == 1)
            {
                Destroy(Material_Positions_Tea[9].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[13].gravityScale = 0.0f;
                Positions_Tea[9].enabled = false;

              
                Material_Positions_Tea[9].anchoredPosition = new Vector2(-56.5f, -33.9f);


            }

            if (Material_Positions_Chocolate[8].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[8].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[14].gravityScale = 0.0f;
                Positions_Chocolate[8].enabled = false;

                Material_Positions_Chocolate[8].anchoredPosition = new Vector2(-10.7f, -36.3f);

            }

            if (Material_Positions_Chocolate[9].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[9].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[15].gravityScale = 0.0f;
                Positions_Chocolate[9].enabled = false;

              
                Material_Positions_Chocolate[9].anchoredPosition = new Vector2(-14.1f, -32.7f);
            }

            sfx.SFX_Trash_Button();
        }
    }

    public void Trash_Cup_Blue_Three()
    {
        if (Material_Positions_Ice[10].childCount == 1 || Material_Positions_Ice[11].childCount == 1 ||
            Material_Positions_Caramel[10].childCount == 1 || Material_Positions_Caramel[11].childCount == 1
            || Material_Positions_Steam[10].childCount == 1 || Material_Positions_Steam[11].childCount == 1 ||
            Material_Positions_Coffee[10].childCount == 1 || Material_Positions_Coffee[11].childCount == 1 ||
            Material_Positions_Milk[10].childCount == 1 || Material_Positions_Milk[11].childCount == 1 ||
            Material_Positions_Water[10].childCount == 1 || Material_Positions_Water[11].childCount == 1
            || Material_Positions_Tea[10].childCount == 1 || Material_Positions_Tea[11].childCount == 1
            || Material_Positions_Chocolate[10].childCount == 1 || Material_Positions_Chocolate[11].childCount == 1)
        {

            if (Material_Positions_Ice[10].childCount == 1)
            {
                Destroy(Material_Positions_Ice[10].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[0].gravityScale = 0.0f;
                Positions_Ice[10].enabled = false;

                Material_Positions_Ice[10].anchoredPosition = new Vector2(-48f, -42.7f);
     

            }

            if (Material_Positions_Ice[11].childCount == 1)
            {
                Destroy(Material_Positions_Ice[11].transform.GetChild(0).gameObject);


                Material_rigid_Blue3[1].gravityScale = 0.0f;
                Positions_Ice[11].enabled = false;

              
                Material_Positions_Ice[11].anchoredPosition = new Vector2(-91.4f, -58.6f);


            }

            if (Material_Positions_Caramel[10].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[10].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[2].gravityScale = 0.0f;
                Positions_Caramel[10].enabled = false;

                
                Material_Positions_Caramel[10].anchoredPosition = new Vector2(-43.6f, -56f);

            }

            if (Material_Positions_Caramel[11].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[11].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[3].gravityScale = 0.0f;
                Positions_Caramel[11].enabled = false;

            
                Material_Positions_Caramel[11].anchoredPosition = new Vector2(4.6f, -53.1f);
  
            }

            if (Material_Positions_Steam[10].childCount == 1)
            {
                Destroy(Material_Positions_Steam[10].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[4].gravityScale = 0.0f;
                Positions_Steam[10].enabled = false;

               
                Material_Positions_Steam[10].anchoredPosition = new Vector2(-107.9f, -15.5f);

            }

            if (Material_Positions_Steam[11].childCount == 1)
            {
                Destroy(Material_Positions_Steam[11].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[5].gravityScale = 0.0f;
                Positions_Steam[11].enabled = false;

              
                Material_Positions_Steam[11].anchoredPosition = new Vector2(8.5f, -41.9f);
            
            }


            if (Material_Positions_Coffee[10].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[10].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[6].gravityScale = 0.0f;
                Positions_Coffee[10].enabled = false;

              
                Material_Positions_Coffee[10].anchoredPosition = new Vector2(-90.3f, -46.2f);
       

            }

            if (Material_Positions_Coffee[11].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[11].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[7].gravityScale = 0.0f;
                Positions_Coffee[11].enabled = false;

               
                Material_Positions_Coffee[11].anchoredPosition = new Vector2(17.9f, -47.6f);

            }


            if (Material_Positions_Milk[10].childCount == 1)
            {
                Destroy(Material_Positions_Milk[10].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[8].gravityScale = 0.0f;
                Positions_Milk[10].enabled = false;

              
                Material_Positions_Milk[10].anchoredPosition = new Vector2(-9.3f, -35.6f);
          
            }

            if (Material_Positions_Milk[11].childCount == 1)
            {

                Destroy(Material_Positions_Milk[11].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[9].gravityScale = 0.0f;
                Positions_Milk[11].enabled = false;

            
                Material_Positions_Milk[11].anchoredPosition = new Vector2(33f, -45.5f);

            }

            if (Material_Positions_Water[10].childCount == 1)
            {
                Destroy(Material_Positions_Water[10].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[10].gravityScale = 0.0f;
                Positions_Water[10].enabled = false;

               
                Material_Positions_Water[10].anchoredPosition = new Vector2(21.7f, -37.3f);
     
            }

            if (Material_Positions_Water[11].childCount == 1)
            {
                Destroy(Material_Positions_Water[11].transform.GetChild(0).gameObject);


                Material_rigid_Blue3[11].gravityScale = 0.0f;
                Positions_Water[11].enabled = false;

               
       
                Material_Positions_Water[11].anchoredPosition = new Vector2(-29.8f, -25.3f);

            }

            if (Material_Positions_Tea[10].childCount == 1)
            {
                Destroy(Material_Positions_Tea[10].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[12].gravityScale = 0.0f;
                Positions_Tea[10].enabled = false;

                Material_Positions_Tea[10].anchoredPosition = new Vector2(-61.9f, -46.9f);



            }

            if (Material_Positions_Tea[11].childCount == 1)
            {
                Destroy(Material_Positions_Tea[11].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[13].gravityScale = 0.0f;
                Positions_Tea[11].enabled = false;

               
                Material_Positions_Tea[11].anchoredPosition = new Vector2(-56.5f, -33.9f);



            }

            if (Material_Positions_Chocolate[10].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[10].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[14].gravityScale = 0.0f;
                Positions_Chocolate[10].enabled = false;

                Material_Positions_Chocolate[10].anchoredPosition = new Vector2(-10.7f, -36.3f);
    
            }

            if (Material_Positions_Chocolate[11].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[11].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[15].gravityScale = 0.0f;
                Positions_Chocolate[11].enabled = false;

               
                Material_Positions_Chocolate[11].anchoredPosition = new Vector2(-14.1f, -32.7f);
            }

            sfx.SFX_Trash_Button();

        }
    }

    //0815
    //Menu���� ����
    public void Trash_Cup_Pink_One1()
    {
        if (Material_Positions_Ice[0].childCount == 1 || Material_Positions_Ice[1].childCount == 1 ||
            Material_Positions_Caramel[0].childCount == 1 || Material_Positions_Caramel[1].childCount == 1
            || Material_Positions_Steam[0].childCount == 1 || Material_Positions_Steam[1].childCount == 1 ||
            Material_Positions_Coffee[0].childCount == 1 || Material_Positions_Coffee[1].childCount == 1 ||
            Material_Positions_Milk[0].childCount == 1 || Material_Positions_Milk[1].childCount == 1 ||
            Material_Positions_Water[0].childCount == 1 || Material_Positions_Water[1].childCount == 1
            || Material_Positions_Tea[0].childCount == 1 || Material_Positions_Tea[1].childCount == 1
            || Material_Positions_Chocolate[0].childCount == 1 || Material_Positions_Chocolate[1].childCount == 1)
        {

            if (Material_Positions_Ice[0].childCount == 1)
            {
                Destroy(Material_Positions_Ice[0].transform.GetChild(0).gameObject);

                Material_rigid[0].gravityScale = 0.0f;
                Positions_Ice[0].enabled = false;

                Material_Positions_Ice[0].anchoredPosition = new Vector2(-48f, -42.7f);


            }

            if (Material_Positions_Ice[1].childCount == 1)
            {
                Destroy(Material_Positions_Ice[1].transform.GetChild(0).gameObject);


                Material_rigid[1].gravityScale = 0.0f;
                Positions_Ice[1].enabled = false;

                Material_Positions_Ice[1].anchoredPosition = new Vector2(-91.4f, -58.6f);


            }

            if (Material_Positions_Caramel[0].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[0].transform.GetChild(0).gameObject);

                Material_rigid[2].gravityScale = 0.0f;
                Positions_Caramel[0].enabled = false;

                Material_Positions_Caramel[0].anchoredPosition = new Vector2(-43.6f, -56f);


            }

            if (Material_Positions_Caramel[1].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[1].transform.GetChild(0).gameObject);

                Material_rigid[3].gravityScale = 0.0f;
                Positions_Caramel[1].enabled = false;

                Material_Positions_Caramel[1].anchoredPosition = new Vector2(4.6f, -53.1f);

            }

            if (Material_Positions_Steam[0].childCount == 1)
            {
                Destroy(Material_Positions_Steam[0].transform.GetChild(0).gameObject);

                Material_rigid[4].gravityScale = 0.0f;
                Positions_Steam[0].enabled = false;

                Material_Positions_Steam[0].anchoredPosition = new Vector2(-107.9f, -15.5f);


            }

            if (Material_Positions_Steam[1].childCount == 1)
            {
                Destroy(Material_Positions_Steam[1].transform.GetChild(0).gameObject);

                Material_rigid[5].gravityScale = 0.0f;
                Positions_Steam[1].enabled = false;


                Material_Positions_Steam[1].anchoredPosition = new Vector2(8.5f, -41.9f);


            }


            if (Material_Positions_Coffee[0].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[0].transform.GetChild(0).gameObject);

                Material_rigid[6].gravityScale = 0.0f;
                Positions_Coffee[0].enabled = false;

                Material_Positions_Coffee[0].anchoredPosition = new Vector2(-90.3f, -46.2f);
            }

            if (Material_Positions_Coffee[1].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[1].transform.GetChild(0).gameObject);

                Material_rigid[7].gravityScale = 0.0f;
                Positions_Coffee[1].enabled = false;

                Material_Positions_Coffee[1].anchoredPosition = new Vector2(17.9f, -47.6f);

            }


            if (Material_Positions_Milk[0].childCount == 1)
            {
                Destroy(Material_Positions_Milk[0].transform.GetChild(0).gameObject);

                Material_rigid[8].gravityScale = 0.0f;
                Positions_Milk[0].enabled = false;

                Material_Positions_Milk[0].anchoredPosition = new Vector2(-9.3f, -35.6f);

            }

            if (Material_Positions_Milk[1].childCount == 1)
            {

                Destroy(Material_Positions_Milk[1].transform.GetChild(0).gameObject);

                Material_rigid[9].gravityScale = 0.0f;
                Positions_Milk[1].enabled = false;


                Material_Positions_Milk[1].anchoredPosition = new Vector2(33f, -45.5f);

            }

            if (Material_Positions_Water[0].childCount == 1)
            {
                Destroy(Material_Positions_Water[0].transform.GetChild(0).gameObject);

                Material_rigid[10].gravityScale = 0.0f;
                Positions_Water[0].enabled = false;

                Material_Positions_Water[0].anchoredPosition = new Vector2(21.7f, -37.3f);

            }

            if (Material_Positions_Water[1].childCount == 1)
            {
                Destroy(Material_Positions_Water[1].transform.GetChild(0).gameObject);


                Material_rigid[11].gravityScale = 0.0f;
                Positions_Water[1].enabled = false;

                Material_Positions_Water[1].anchoredPosition = new Vector2(-29.8f, -25.3f);

            }

            if (Material_Positions_Tea[0].childCount == 1)
            {
                Destroy(Material_Positions_Tea[0].transform.GetChild(0).gameObject);

                Material_rigid[12].gravityScale = 0.0f;
                Positions_Tea[0].enabled = false;


                Material_Positions_Tea[0].anchoredPosition = new Vector2(-61.9f, -46.9f);

            }

            if (Material_Positions_Tea[1].childCount == 1)
            {
                Destroy(Material_Positions_Tea[1].transform.GetChild(0).gameObject);

                Material_rigid[13].gravityScale = 0.0f;
                Positions_Tea[1].enabled = false;


                Material_Positions_Tea[1].anchoredPosition = new Vector2(-56.5f, -33.9f);

            }

            if (Material_Positions_Chocolate[0].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[0].transform.GetChild(0).gameObject);

                Material_rigid[14].gravityScale = 0.0f;
                Positions_Chocolate[0].enabled = false;

                Material_Positions_Chocolate[0].anchoredPosition = new Vector2(-10.7f, -36.3f);
            }

            if (Material_Positions_Chocolate[1].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[1].transform.GetChild(0).gameObject);

                Material_rigid[15].gravityScale = 0.0f;
                Positions_Chocolate[1].enabled = false;

                Material_Positions_Chocolate[1].anchoredPosition = new Vector2(-14.1f, -32.7f);
            }


        }




    }

    public void Trash_Cup_Pink_Two1()
    {
        if (Material_Positions_Ice[2].childCount == 1 || Material_Positions_Ice[3].childCount == 1 ||
            Material_Positions_Caramel[2].childCount == 1 || Material_Positions_Caramel[3].childCount == 1
            || Material_Positions_Steam[2].childCount == 1 || Material_Positions_Steam[3].childCount == 1 ||
            Material_Positions_Coffee[2].childCount == 1 || Material_Positions_Coffee[3].childCount == 1 ||
            Material_Positions_Milk[2].childCount == 1 || Material_Positions_Milk[3].childCount == 1 ||
            Material_Positions_Water[2].childCount == 1 || Material_Positions_Water[3].childCount == 1
            || Material_Positions_Tea[2].childCount == 1 || Material_Positions_Tea[3].childCount == 1
            || Material_Positions_Chocolate[2].childCount == 1 || Material_Positions_Chocolate[3].childCount == 1)
        {

            if (Material_Positions_Ice[2].childCount == 1)
            {
                Destroy(Material_Positions_Ice[2].transform.GetChild(0).gameObject);



                Material_rigid_Pink2[0].gravityScale = 0.0f;

                Positions_Ice[2].enabled = false;

                Material_Positions_Ice[2].anchoredPosition = new Vector2(-48f, -42.7f);



            }

            if (Material_Positions_Ice[3].childCount == 1)
            {
                Destroy(Material_Positions_Ice[3].transform.GetChild(0).gameObject);


                Material_rigid_Pink2[1].gravityScale = 0.0f;
                Positions_Ice[3].enabled = false;

                Material_Positions_Ice[3].anchoredPosition = new Vector2(-91.4f, -58.6f);


            }

            if (Material_Positions_Caramel[2].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[2].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[2].gravityScale = 0.0f;
                Positions_Caramel[2].enabled = false;

                Material_Positions_Caramel[2].anchoredPosition = new Vector2(-43.6f, -56f);

            }

            if (Material_Positions_Caramel[3].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[3].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[3].gravityScale = 0.0f;
                Positions_Caramel[3].enabled = false;

                Material_Positions_Caramel[3].anchoredPosition = new Vector2(4.6f, -53.1f);

            }

            if (Material_Positions_Steam[2].childCount == 1)
            {
                Destroy(Material_Positions_Steam[2].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[4].gravityScale = 0.0f;
                Positions_Steam[2].enabled = false;

                Material_Positions_Steam[2].anchoredPosition = new Vector2(-107.9f, -15.5f);

            }

            if (Material_Positions_Steam[3].childCount == 1)
            {
                Destroy(Material_Positions_Steam[3].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[5].gravityScale = 0.0f;
                Positions_Steam[3].enabled = false;

                Material_Positions_Steam[3].anchoredPosition = new Vector2(8.5f, -41.9f);

            }


            if (Material_Positions_Coffee[2].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[2].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[6].gravityScale = 0.0f;
                Positions_Coffee[2].enabled = false;

                Material_Positions_Coffee[2].anchoredPosition = new Vector2(-90.3f, -46.2f);


            }

            if (Material_Positions_Coffee[3].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[3].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[7].gravityScale = 0.0f;
                Positions_Coffee[3].enabled = false;

                Material_Positions_Coffee[3].anchoredPosition = new Vector2(17.9f, -47.6f);

            }


            if (Material_Positions_Milk[2].childCount == 1)
            {
                Destroy(Material_Positions_Milk[2].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[8].gravityScale = 0.0f;
                Positions_Milk[2].enabled = false;

                Material_Positions_Milk[2].anchoredPosition = new Vector2(-9.3f, -35.6f);

            }

            if (Material_Positions_Milk[3].childCount == 1)
            {

                Destroy(Material_Positions_Milk[3].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[9].gravityScale = 0.0f;
                Positions_Milk[3].enabled = false;

                Material_Positions_Milk[3].anchoredPosition = new Vector2(33f, -45.5f);

            }

            if (Material_Positions_Water[2].childCount == 1)
            {
                Destroy(Material_Positions_Water[2].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[10].gravityScale = 0.0f;
                Positions_Water[2].enabled = false;

                Material_Positions_Water[2].anchoredPosition = new Vector2(21.7f, -37.3f);

            }

            if (Material_Positions_Water[3].childCount == 1)
            {
                Destroy(Material_Positions_Water[3].transform.GetChild(0).gameObject);


                Material_rigid_Pink2[11].gravityScale = 0.0f;
                Positions_Water[3].enabled = false;

                Material_Positions_Water[3].anchoredPosition = new Vector2(-29.8f, -25.3f);

            }

            if (Material_Positions_Tea[2].childCount == 1)
            {
                Destroy(Material_Positions_Tea[2].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[12].gravityScale = 0.0f;
                Positions_Tea[2].enabled = false;

                Material_Positions_Tea[2].anchoredPosition = new Vector2(-61.9f, -46.9f);



            }

            if (Material_Positions_Tea[3].childCount == 1)
            {
                Destroy(Material_Positions_Tea[3].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[13].gravityScale = 0.0f;
                Positions_Tea[3].enabled = false;

                Material_Positions_Tea[3].anchoredPosition = new Vector2(-56.5f, -33.9f);



            }

            if (Material_Positions_Chocolate[2].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[2].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[14].gravityScale = 0.0f;
                Positions_Chocolate[2].enabled = false;

                Material_Positions_Chocolate[2].anchoredPosition = new Vector2(-10.7f, -36.3f);

            }

            if (Material_Positions_Chocolate[3].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[3].transform.GetChild(0).gameObject);

                Material_rigid_Pink2[15].gravityScale = 0.0f;
                Positions_Chocolate[3].enabled = false;

                Material_Positions_Chocolate[3].anchoredPosition = new Vector2(-14.1f, -32.7f);
            }


        }
    }

    public void Trash_Cup_Pink_Three1()
    {
        if (Material_Positions_Ice[4].childCount == 1 || Material_Positions_Ice[5].childCount == 1 ||
            Material_Positions_Caramel[4].childCount == 1 || Material_Positions_Caramel[5].childCount == 1
            || Material_Positions_Steam[4].childCount == 1 || Material_Positions_Steam[5].childCount == 1 ||
            Material_Positions_Coffee[4].childCount == 1 || Material_Positions_Coffee[5].childCount == 1 ||
            Material_Positions_Milk[4].childCount == 1 || Material_Positions_Milk[5].childCount == 1 ||
            Material_Positions_Water[4].childCount == 1 || Material_Positions_Water[5].childCount == 1
            || Material_Positions_Tea[4].childCount == 1 || Material_Positions_Tea[5].childCount == 1
            || Material_Positions_Chocolate[4].childCount == 1 || Material_Positions_Chocolate[5].childCount == 1)
        {

            if (Material_Positions_Ice[4].childCount == 1)
            {
                Destroy(Material_Positions_Ice[4].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[0].gravityScale = 0.0f;
                Positions_Ice[4].enabled = false;

                Material_Positions_Ice[4].anchoredPosition = new Vector2(-48f, -42.7f);


            }

            if (Material_Positions_Ice[5].childCount == 1)
            {
                Destroy(Material_Positions_Ice[5].transform.GetChild(0).gameObject);


                Material_rigid_Pink3[1].gravityScale = 0.0f;
                Positions_Ice[5].enabled = false;

                Material_Positions_Ice[5].anchoredPosition = new Vector2(-91.4f, -58.6f);


            }

            if (Material_Positions_Caramel[4].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[4].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[2].gravityScale = 0.0f;
                Positions_Caramel[4].enabled = false;

                Material_Positions_Caramel[4].anchoredPosition = new Vector2(-43.6f, -56f);

            }

            if (Material_Positions_Caramel[5].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[5].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[3].gravityScale = 0.0f;
                Positions_Caramel[5].enabled = false;


                Material_Positions_Caramel[5].anchoredPosition = new Vector2(4.6f, -53.1f);

            }

            if (Material_Positions_Steam[4].childCount == 1)
            {
                Destroy(Material_Positions_Steam[4].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[4].gravityScale = 0.0f;
                Positions_Steam[4].enabled = false;

                Material_Positions_Steam[4].anchoredPosition = new Vector2(-107.9f, -15.5f);

            }

            if (Material_Positions_Steam[5].childCount == 1)
            {
                Destroy(Material_Positions_Steam[5].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[5].gravityScale = 0.0f;
                Positions_Steam[5].enabled = false;


                Material_Positions_Steam[5].anchoredPosition = new Vector2(8.5f, -41.9f);

            }


            if (Material_Positions_Coffee[4].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[4].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[6].gravityScale = 0.0f;
                Positions_Coffee[4].enabled = false;


                Material_Positions_Coffee[4].anchoredPosition = new Vector2(-90.3f, -46.2f);


            }

            if (Material_Positions_Coffee[5].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[5].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[7].gravityScale = 0.0f;
                Positions_Coffee[5].enabled = false;

                Material_Positions_Coffee[5].anchoredPosition = new Vector2(17.9f, -47.6f);

            }


            if (Material_Positions_Milk[4].childCount == 1)
            {
                Destroy(Material_Positions_Milk[4].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[8].gravityScale = 0.0f;
                Positions_Milk[4].enabled = false;

                Material_Positions_Milk[4].anchoredPosition = new Vector2(-9.3f, -35.6f);

            }

            if (Material_Positions_Milk[5].childCount == 1)
            {

                Destroy(Material_Positions_Milk[5].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[9].gravityScale = 0.0f;
                Positions_Milk[5].enabled = false;


                Material_Positions_Milk[5].anchoredPosition = new Vector2(33f, -45.5f);

            }

            if (Material_Positions_Water[4].childCount == 1)
            {
                Destroy(Material_Positions_Water[4].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[10].gravityScale = 0.0f;
                Positions_Water[4].enabled = false;


                Material_Positions_Water[4].anchoredPosition = new Vector2(21.7f, -37.3f);

            }

            if (Material_Positions_Water[5].childCount == 1)
            {
                Destroy(Material_Positions_Water[5].transform.GetChild(0).gameObject);


                Material_rigid_Pink3[11].gravityScale = 0.0f;
                Positions_Water[5].enabled = false;


                Material_Positions_Water[5].anchoredPosition = new Vector2(-29.8f, -25.3f);

            }

            if (Material_Positions_Tea[4].childCount == 1)
            {
                Destroy(Material_Positions_Tea[4].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[12].gravityScale = 0.0f;
                Positions_Tea[4].enabled = false;


                Material_Positions_Tea[4].anchoredPosition = new Vector2(-61.9f, -46.9f);



            }

            if (Material_Positions_Tea[5].childCount == 1)
            {
                Destroy(Material_Positions_Tea[5].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[13].gravityScale = 0.0f;
                Positions_Tea[5].enabled = false;

                Material_Positions_Tea[5].anchoredPosition = new Vector2(-56.5f, -33.9f);



            }

            if (Material_Positions_Chocolate[4].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[4].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[14].gravityScale = 0.0f;
                Positions_Chocolate[4].enabled = false;


                Material_Positions_Chocolate[4].anchoredPosition = new Vector2(-10.7f, -36.3f);

            }

            if (Material_Positions_Chocolate[5].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[5].transform.GetChild(0).gameObject);

                Material_rigid_Pink3[15].gravityScale = 0.0f;
                Positions_Chocolate[5].enabled = false;

                Material_Positions_Chocolate[5].anchoredPosition = new Vector2(-14.1f, -32.7f);
            }


        }
    }

    public void Trash_Cup_Blue_One1()
    {
        if (Material_Positions_Ice[6].childCount == 1 || Material_Positions_Ice[7].childCount == 1 ||
            Material_Positions_Caramel[6].childCount == 1 || Material_Positions_Caramel[7].childCount == 1
            || Material_Positions_Steam[6].childCount == 1 || Material_Positions_Steam[7].childCount == 1 ||
            Material_Positions_Coffee[6].childCount == 1 || Material_Positions_Coffee[7].childCount == 1 ||
            Material_Positions_Milk[6].childCount == 1 || Material_Positions_Milk[7].childCount == 1 ||
            Material_Positions_Water[6].childCount == 1 || Material_Positions_Water[7].childCount == 1
            || Material_Positions_Tea[6].childCount == 1 || Material_Positions_Tea[7].childCount == 1
            || Material_Positions_Chocolate[6].childCount == 1 || Material_Positions_Chocolate[7].childCount == 1)
        {

            if (Material_Positions_Ice[6].childCount == 1)
            {
                Destroy(Material_Positions_Ice[6].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[0].gravityScale = 0.0f;
                Positions_Ice[6].enabled = false;

                Material_Positions_Ice[6].anchoredPosition = new Vector2(-48f, -42.7f);


            }

            if (Material_Positions_Ice[7].childCount == 1)
            {
                Destroy(Material_Positions_Ice[7].transform.GetChild(0).gameObject);


                Material_rigid_Blue1[1].gravityScale = 0.0f;
                Positions_Ice[7].enabled = false;

                Material_Positions_Ice[7].anchoredPosition = new Vector2(-91.4f, -58.6f);


            }

            if (Material_Positions_Caramel[6].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[6].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[2].gravityScale = 0.0f;
                Positions_Caramel[6].enabled = false;


                Material_Positions_Caramel[6].anchoredPosition = new Vector2(-43.6f, -56f);

            }

            if (Material_Positions_Caramel[7].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[7].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[3].gravityScale = 0.0f;
                Positions_Caramel[7].enabled = false;

                Material_Positions_Caramel[7].anchoredPosition = new Vector2(4.6f, -53.1f);

            }

            if (Material_Positions_Steam[6].childCount == 1)
            {
                Destroy(Material_Positions_Steam[6].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[4].gravityScale = 0.0f;
                Positions_Steam[6].enabled = false;


                Material_Positions_Steam[6].anchoredPosition = new Vector2(-107.9f, -15.5f);

            }

            if (Material_Positions_Steam[7].childCount == 1)
            {
                Destroy(Material_Positions_Steam[7].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[5].gravityScale = 0.0f;
                Positions_Steam[7].enabled = false;


                Material_Positions_Steam[7].anchoredPosition = new Vector2(8.5f, -41.9f);

            }


            if (Material_Positions_Coffee[6].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[6].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[6].gravityScale = 0.0f;
                Positions_Coffee[6].enabled = false;


                Material_Positions_Coffee[6].anchoredPosition = new Vector2(-90.3f, -46.2f);


            }

            if (Material_Positions_Coffee[7].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[7].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[7].gravityScale = 0.0f;
                Positions_Coffee[7].enabled = false;


                Material_Positions_Coffee[7].anchoredPosition = new Vector2(17.9f, -47.6f);

            }


            if (Material_Positions_Milk[6].childCount == 1)
            {
                Destroy(Material_Positions_Milk[6].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[8].gravityScale = 0.0f;
                Positions_Milk[6].enabled = false;


                Material_Positions_Milk[6].anchoredPosition = new Vector2(-9.3f, -35.6f);

            }

            if (Material_Positions_Milk[7].childCount == 1)
            {

                Destroy(Material_Positions_Milk[7].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[9].gravityScale = 0.0f;
                Positions_Milk[7].enabled = false;


                Material_Positions_Milk[7].anchoredPosition = new Vector2(33f, -45.5f);

            }

            if (Material_Positions_Water[6].childCount == 1)
            {
                Destroy(Material_Positions_Water[6].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[10].gravityScale = 0.0f;
                Positions_Water[6].enabled = false;


                Material_Positions_Water[6].anchoredPosition = new Vector2(21.7f, -37.3f);

            }

            if (Material_Positions_Water[7].childCount == 1)
            {
                Destroy(Material_Positions_Water[7].transform.GetChild(0).gameObject);


                Material_rigid_Blue1[11].gravityScale = 0.0f;
                Positions_Water[7].enabled = false;


                Material_Positions_Water[7].anchoredPosition = new Vector2(-29.8f, -25.3f);

            }

            if (Material_Positions_Tea[6].childCount == 1)
            {
                Destroy(Material_Positions_Tea[6].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[12].gravityScale = 0.0f;
                Positions_Tea[6].enabled = false;

                Material_Positions_Tea[6].anchoredPosition = new Vector2(-61.9f, -46.9f);



            }

            if (Material_Positions_Tea[7].childCount == 1)
            {
                Destroy(Material_Positions_Tea[7].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[13].gravityScale = 0.0f;
                Positions_Tea[7].enabled = false;


                Material_Positions_Tea[7].anchoredPosition = new Vector2(-56.5f, -33.9f);



            }

            if (Material_Positions_Chocolate[6].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[6].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[14].gravityScale = 0.0f;
                Positions_Chocolate[6].enabled = false;


                Material_Positions_Chocolate[6].anchoredPosition = new Vector2(-10.7f, -36.3f);

            }

            if (Material_Positions_Chocolate[7].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[7].transform.GetChild(0).gameObject);

                Material_rigid_Blue1[15].gravityScale = 0.0f;
                Positions_Chocolate[7].enabled = false;


                Material_Positions_Chocolate[7].anchoredPosition = new Vector2(-14.1f, -32.7f);
            }


        }
    }

    public void Trash_Cup_Blue_Two1()
    {
        if (Material_Positions_Ice[8].childCount == 1 || Material_Positions_Ice[9].childCount == 1 ||
            Material_Positions_Caramel[8].childCount == 1 || Material_Positions_Caramel[9].childCount == 1
            || Material_Positions_Steam[8].childCount == 1 || Material_Positions_Steam[9].childCount == 1 ||
            Material_Positions_Coffee[8].childCount == 1 || Material_Positions_Coffee[9].childCount == 1 ||
            Material_Positions_Milk[8].childCount == 1 || Material_Positions_Milk[9].childCount == 1 ||
            Material_Positions_Water[8].childCount == 1 || Material_Positions_Water[9].childCount == 1
            || Material_Positions_Tea[8].childCount == 1 || Material_Positions_Tea[9].childCount == 1
            || Material_Positions_Chocolate[8].childCount == 1 || Material_Positions_Chocolate[9].childCount == 1)
        {

            if (Material_Positions_Ice[8].childCount == 1)
            {
                Destroy(Material_Positions_Ice[8].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[0].gravityScale = 0.0f;
                Positions_Ice[8].enabled = false;

                Material_Positions_Ice[8].anchoredPosition = new Vector2(-48f, -42.7f);


            }

            if (Material_Positions_Ice[9].childCount == 1)
            {
                Destroy(Material_Positions_Ice[9].transform.GetChild(0).gameObject);


                Material_rigid_Blue2[1].gravityScale = 0.0f;
                Positions_Ice[9].enabled = false;

                Material_Positions_Ice[9].anchoredPosition = new Vector2(-91.4f, -58.6f);


            }

            if (Material_Positions_Caramel[8].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[8].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[2].gravityScale = 0.0f;
                Positions_Caramel[8].enabled = false;


                Material_Positions_Caramel[8].anchoredPosition = new Vector2(-43.6f, -56f);

            }

            if (Material_Positions_Caramel[9].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[9].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[3].gravityScale = 0.0f;
                Positions_Caramel[9].enabled = false;

                Material_Positions_Caramel[9].anchoredPosition = new Vector2(4.6f, -53.1f);

            }

            if (Material_Positions_Steam[8].childCount == 1)
            {
                Destroy(Material_Positions_Steam[8].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[4].gravityScale = 0.0f;
                Positions_Steam[8].enabled = false;


                Material_Positions_Steam[8].anchoredPosition = new Vector2(-107.9f, -15.5f);

            }

            if (Material_Positions_Steam[9].childCount == 1)
            {
                Destroy(Material_Positions_Steam[9].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[5].gravityScale = 0.0f;
                Positions_Steam[9].enabled = false;


                Material_Positions_Steam[9].anchoredPosition = new Vector2(8.5f, -41.9f);

            }


            if (Material_Positions_Coffee[8].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[8].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[6].gravityScale = 0.0f;
                Positions_Coffee[8].enabled = false;


                Material_Positions_Coffee[8].anchoredPosition = new Vector2(-90.3f, -46.2f);


            }

            if (Material_Positions_Coffee[9].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[9].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[7].gravityScale = 0.0f;
                Positions_Coffee[9].enabled = false;

                Material_Positions_Coffee[9].anchoredPosition = new Vector2(17.9f, -47.6f);

            }


            if (Material_Positions_Milk[8].childCount == 1)
            {
                Destroy(Material_Positions_Milk[8].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[8].gravityScale = 0.0f;
                Positions_Milk[8].enabled = false;


                Material_Positions_Milk[8].anchoredPosition = new Vector2(-9.3f, -35.6f);

            }

            if (Material_Positions_Milk[9].childCount == 1)
            {

                Destroy(Material_Positions_Milk[9].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[9].gravityScale = 0.0f;
                Positions_Milk[9].enabled = false;


                Material_Positions_Milk[9].anchoredPosition = new Vector2(33f, -45.5f);

            }

            if (Material_Positions_Water[8].childCount == 1)
            {
                Destroy(Material_Positions_Water[8].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[10].gravityScale = 0.0f;
                Positions_Water[8].enabled = false;


                Material_Positions_Water[8].anchoredPosition = new Vector2(21.7f, -37.3f);

            }

            if (Material_Positions_Water[9].childCount == 1)
            {
                Destroy(Material_Positions_Water[9].transform.GetChild(0).gameObject);


                Material_rigid_Blue2[11].gravityScale = 0.0f;
                Positions_Water[9].enabled = false;

                Material_Positions_Water[9].anchoredPosition = new Vector2(-29.8f, -25.3f);

            }

            if (Material_Positions_Tea[8].childCount == 1)
            {
                Destroy(Material_Positions_Tea[8].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[12].gravityScale = 0.0f;
                Positions_Tea[8].enabled = false;

                Material_Positions_Tea[8].anchoredPosition = new Vector2(-61.9f, -46.9f);



            }

            if (Material_Positions_Tea[9].childCount == 1)
            {
                Destroy(Material_Positions_Tea[9].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[13].gravityScale = 0.0f;
                Positions_Tea[9].enabled = false;


                Material_Positions_Tea[9].anchoredPosition = new Vector2(-56.5f, -33.9f);


            }

            if (Material_Positions_Chocolate[8].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[8].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[14].gravityScale = 0.0f;
                Positions_Chocolate[8].enabled = false;

                Material_Positions_Chocolate[8].anchoredPosition = new Vector2(-10.7f, -36.3f);

            }

            if (Material_Positions_Chocolate[9].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[9].transform.GetChild(0).gameObject);

                Material_rigid_Blue2[15].gravityScale = 0.0f;
                Positions_Chocolate[9].enabled = false;


                Material_Positions_Chocolate[9].anchoredPosition = new Vector2(-14.1f, -32.7f);
            }

        }
    }

    public void Trash_Cup_Blue_Three1()
    {
        if (Material_Positions_Ice[10].childCount == 1 || Material_Positions_Ice[11].childCount == 1 ||
            Material_Positions_Caramel[10].childCount == 1 || Material_Positions_Caramel[11].childCount == 1
            || Material_Positions_Steam[10].childCount == 1 || Material_Positions_Steam[11].childCount == 1 ||
            Material_Positions_Coffee[10].childCount == 1 || Material_Positions_Coffee[11].childCount == 1 ||
            Material_Positions_Milk[10].childCount == 1 || Material_Positions_Milk[11].childCount == 1 ||
            Material_Positions_Water[10].childCount == 1 || Material_Positions_Water[11].childCount == 1
            || Material_Positions_Tea[10].childCount == 1 || Material_Positions_Tea[11].childCount == 1
            || Material_Positions_Chocolate[10].childCount == 1 || Material_Positions_Chocolate[11].childCount == 1)
        {

            if (Material_Positions_Ice[10].childCount == 1)
            {
                Destroy(Material_Positions_Ice[10].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[0].gravityScale = 0.0f;
                Positions_Ice[10].enabled = false;

                Material_Positions_Ice[10].anchoredPosition = new Vector2(-48f, -42.7f);


            }

            if (Material_Positions_Ice[11].childCount == 1)
            {
                Destroy(Material_Positions_Ice[11].transform.GetChild(0).gameObject);


                Material_rigid_Blue3[1].gravityScale = 0.0f;
                Positions_Ice[11].enabled = false;


                Material_Positions_Ice[11].anchoredPosition = new Vector2(-91.4f, -58.6f);


            }

            if (Material_Positions_Caramel[10].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[10].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[2].gravityScale = 0.0f;
                Positions_Caramel[10].enabled = false;


                Material_Positions_Caramel[10].anchoredPosition = new Vector2(-43.6f, -56f);

            }

            if (Material_Positions_Caramel[11].childCount == 1)
            {
                Destroy(Material_Positions_Caramel[11].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[3].gravityScale = 0.0f;
                Positions_Caramel[11].enabled = false;


                Material_Positions_Caramel[11].anchoredPosition = new Vector2(4.6f, -53.1f);

            }

            if (Material_Positions_Steam[10].childCount == 1)
            {
                Destroy(Material_Positions_Steam[10].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[4].gravityScale = 0.0f;
                Positions_Steam[10].enabled = false;


                Material_Positions_Steam[10].anchoredPosition = new Vector2(-107.9f, -15.5f);

            }

            if (Material_Positions_Steam[11].childCount == 1)
            {
                Destroy(Material_Positions_Steam[11].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[5].gravityScale = 0.0f;
                Positions_Steam[11].enabled = false;


                Material_Positions_Steam[11].anchoredPosition = new Vector2(8.5f, -41.9f);

            }


            if (Material_Positions_Coffee[10].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[10].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[6].gravityScale = 0.0f;
                Positions_Coffee[10].enabled = false;


                Material_Positions_Coffee[10].anchoredPosition = new Vector2(-90.3f, -46.2f);


            }

            if (Material_Positions_Coffee[11].childCount == 1)
            {
                Destroy(Material_Positions_Coffee[11].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[7].gravityScale = 0.0f;
                Positions_Coffee[11].enabled = false;


                Material_Positions_Coffee[11].anchoredPosition = new Vector2(17.9f, -47.6f);

            }


            if (Material_Positions_Milk[10].childCount == 1)
            {
                Destroy(Material_Positions_Milk[10].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[8].gravityScale = 0.0f;
                Positions_Milk[10].enabled = false;


                Material_Positions_Milk[10].anchoredPosition = new Vector2(-9.3f, -35.6f);

            }

            if (Material_Positions_Milk[11].childCount == 1)
            {

                Destroy(Material_Positions_Milk[11].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[9].gravityScale = 0.0f;
                Positions_Milk[11].enabled = false;


                Material_Positions_Milk[11].anchoredPosition = new Vector2(33f, -45.5f);

            }

            if (Material_Positions_Water[10].childCount == 1)
            {
                Destroy(Material_Positions_Water[10].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[10].gravityScale = 0.0f;
                Positions_Water[10].enabled = false;


                Material_Positions_Water[10].anchoredPosition = new Vector2(21.7f, -37.3f);

            }

            if (Material_Positions_Water[11].childCount == 1)
            {
                Destroy(Material_Positions_Water[11].transform.GetChild(0).gameObject);


                Material_rigid_Blue3[11].gravityScale = 0.0f;
                Positions_Water[11].enabled = false;



                Material_Positions_Water[11].anchoredPosition = new Vector2(-29.8f, -25.3f);

            }

            if (Material_Positions_Tea[10].childCount == 1)
            {
                Destroy(Material_Positions_Tea[10].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[12].gravityScale = 0.0f;
                Positions_Tea[10].enabled = false;

                Material_Positions_Tea[10].anchoredPosition = new Vector2(-61.9f, -46.9f);



            }

            if (Material_Positions_Tea[11].childCount == 1)
            {
                Destroy(Material_Positions_Tea[11].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[13].gravityScale = 0.0f;
                Positions_Tea[11].enabled = false;


                Material_Positions_Tea[11].anchoredPosition = new Vector2(-56.5f, -33.9f);



            }

            if (Material_Positions_Chocolate[10].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[10].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[14].gravityScale = 0.0f;
                Positions_Chocolate[10].enabled = false;

                Material_Positions_Chocolate[10].anchoredPosition = new Vector2(-10.7f, -36.3f);

            }

            if (Material_Positions_Chocolate[11].childCount == 1)
            {
                Destroy(Material_Positions_Chocolate[11].transform.GetChild(0).gameObject);

                Material_rigid_Blue3[15].gravityScale = 0.0f;
                Positions_Chocolate[11].enabled = false;


                Material_Positions_Chocolate[11].anchoredPosition = new Vector2(-14.1f, -32.7f);
            }



        }
    }

    //�̰� ���� �ִ� ��
    public void G_Pink_Cup_Test()
    {


        for (int i = 0; i < move_material.Pink_24.Length; i++)
        {
            if (move_material.selection_Pink_24[i].activeSelf && move_material.Pink_24[i].activeSelf && move_material.Pink_24[i].transform.childCount > 1)
            {
                move_material.selection_Pink_24[i].SetActive(false);

                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_0++;

                    if (count_0 == 1)
                    {
                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[0].childCount == 0 && Material_Positions_Ice[1].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[0], false);
                            //�θ� Material_Positions_Ice[0]�� �ش��ϴ� ��ġ�� ����. false�� ������� ���� ��ġ�� ����

                            instantiatedObject.transform.localPosition = Vector3.zero;
                            //instantiatedObject�� ���� ��ġ ����. ���� ��ǥ �������� 0, 0, 0��ġ�� ����

                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            //���� ȸ���� ����. ȸ�� �������� ����

                            instantiatedObject.transform.localScale = Vector3.one;
                            //���� �������� 1, 1, 1�� ����

                            Material_rigid[0].gravityScale = 1.0f;
                            Positions_Ice[0].enabled = true;

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[0].childCount == 1 && Material_Positions_Ice[1].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_0 = 0;

                            instantiatedObject.transform.SetParent(Material_Positions_Ice[1], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            Material_rigid[1].gravityScale = 1.0f;
                            Positions_Ice[1].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[0].childCount == 0 && Material_Positions_Ice[1].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject.transform.SetParent(Material_Positions_Ice[0], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            Material_rigid[0].gravityScale = 1.0f;
                            Positions_Ice[0].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;

                        }



                        if (Material_Positions_Ice[0].childCount == 1 && Material_Positions_Ice[1].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_0 = 0;
                        }
                    }

                    if (count_0 == 2)
                    {

                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject1 = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[0].childCount == 0 && Material_Positions_Ice[1].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[0], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            instantiatedObject1.transform.SetParent(Material_Positions_Ice[1], false);
                            instantiatedObject1.transform.localPosition = Vector3.zero;
                            instantiatedObject1.transform.localRotation = Quaternion.identity;
                            instantiatedObject1.transform.localScale = Vector3.one;

                            Material_rigid[0].gravityScale = 1.0f;
                            Positions_Ice[0].enabled = true;

                            Material_rigid[1].gravityScale = 1.0f;
                            Positions_Ice[1].enabled = true;

                            Destroy(instantiatedObject);
                            Destroy(instantiatedObject1);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[0].childCount == 0 && Material_Positions_Ice[1].childCount == 1)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[0], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid[0].gravityScale = 1.0f;
                            Positions_Ice[0].enabled = true;

                            Destroy(instantiatedObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[0].childCount == 1 && Material_Positions_Ice[1].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[1], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid[1].gravityScale = 1.0f;
                            Positions_Ice[1].enabled = true;

                            Destroy(instantiatedObject);

                            count_0 = 0;

                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[0].childCount == 1 && Material_Positions_Ice[1].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_0 = 0;
                        }


                    }
                    else if (count_0 > 2)
                    {
                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject1 = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[0].childCount == 0 && Material_Positions_Ice[1].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[0], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            instantiatedObject1.transform.SetParent(Material_Positions_Ice[1], false);
                            instantiatedObject1.transform.localPosition = Vector3.zero;
                            instantiatedObject1.transform.localRotation = Quaternion.identity;
                            instantiatedObject1.transform.localScale = Vector3.one;

                            Material_rigid[0].gravityScale = 1.0f;
                            Positions_Ice[0].enabled = true;

                            Material_rigid[1].gravityScale = 1.0f;
                            Positions_Ice[1].enabled = true;

                            Destroy(instantiatedObject);
                            Destroy(instantiatedObject1);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[0].childCount == 0 && Material_Positions_Ice[1].childCount == 1)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[0], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid[0].gravityScale = 1.0f;
                            Positions_Ice[0].enabled = true;

                            Destroy(instantiatedObject);



                            count_0 = 0;
                        }


                        if (Material_Positions_Ice[0].childCount == 1 && Material_Positions_Ice[1].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[1], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid[1].gravityScale = 1.0f;
                            Positions_Ice[1].enabled = true;

                            Destroy(instantiatedObject);



                            count_0 = 0;

                            //return;
                            //move_material.selection_Pink_24[i].SetActive(false);
                            //count_0 = 0;
                        }

                        if (Material_Positions_Ice[0].childCount == 1 && Material_Positions_Ice[1].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_0 = 0;
                        }


                    }
                }

                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "ī���(���ý�)(Clone)")
                {
                    count_1++;

                    if (count_1 == 1)
                    {
                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[0].childCount == 0 && Material_Positions_Caramel[1].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[0], false);

                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;

                            instantiatedObject0.transform.localScale = Vector3.one;

                            Material_rigid[2].gravityScale = 1.0f;
                            Positions_Caramel[0].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[0].childCount == 1 && Material_Positions_Caramel[1].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_1 = 0;

                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[1], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            Material_rigid[3].gravityScale = 1.0f;
                            Positions_Caramel[1].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[0].childCount == 0 && Material_Positions_Caramel[1].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[0], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            Material_rigid[2].gravityScale = 1.0f;
                            Positions_Caramel[0].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_1 = 0;

                        }



                        if (Material_Positions_Caramel[0].childCount == 1 && Material_Positions_Caramel[1].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_1 = 0;
                        }
                    }

                    if (count_1 == 2)
                    {

                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject2 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[0].childCount == 0 && Material_Positions_Caramel[1].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[0], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            instantiatedObject2.transform.SetParent(Material_Positions_Caramel[1], false);
                            instantiatedObject2.transform.localPosition = Vector3.zero;
                            instantiatedObject2.transform.localRotation = Quaternion.identity;
                            instantiatedObject2.transform.localScale = Vector3.one;

                            Material_rigid[2].gravityScale = 1.0f;
                            Positions_Caramel[0].enabled = true;

                            Material_rigid[3].gravityScale = 1.0f;
                            Positions_Caramel[1].enabled = true;

                            Destroy(instantiatedObject0);
                            Destroy(instantiatedObject2);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[0].childCount == 0 && Material_Positions_Caramel[1].childCount == 1)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[0], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid[2].gravityScale = 1.0f;
                            Positions_Caramel[0].enabled = true;

                            Destroy(instantiatedObject0);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[0].childCount == 1 && Material_Positions_Caramel[1].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[1], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid[3].gravityScale = 1.0f;
                            Positions_Caramel[1].enabled = true;

                            Destroy(instantiatedObject0);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[0].childCount == 1 && Material_Positions_Caramel[1].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_1 = 0;
                        }


                    }
                    else if (count_1 > 2)
                    {
                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject2 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[0].childCount == 0 && Material_Positions_Caramel[1].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[0], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            instantiatedObject2.transform.SetParent(Material_Positions_Caramel[1], false);
                            instantiatedObject2.transform.localPosition = Vector3.zero;
                            instantiatedObject2.transform.localRotation = Quaternion.identity;
                            instantiatedObject2.transform.localScale = Vector3.one;

                            Material_rigid[2].gravityScale = 1.0f;
                            Positions_Caramel[0].enabled = true;

                            Material_rigid[3].gravityScale = 1.0f;
                            Positions_Caramel[1].enabled = true;

                            Destroy(instantiatedObject0);
                            Destroy(instantiatedObject2);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[0].childCount == 0 && Material_Positions_Caramel[1].childCount == 1)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[0], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid[2].gravityScale = 1.0f;
                            Positions_Caramel[0].enabled = true;

                            Destroy(instantiatedObject0);



                            count_1 = 0;
                        }


                        if (Material_Positions_Caramel[0].childCount == 1 && Material_Positions_Caramel[1].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[1], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid[3].gravityScale = 1.0f;
                            Positions_Caramel[1].enabled = true;

                            Destroy(instantiatedObject0);



                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[0].childCount == 1 && Material_Positions_Caramel[1].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_1 = 0;
                        }


                    }
                }


                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_2++;

                    if (count_2 == 1)
                    {
                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[0].childCount == 0 && Material_Positions_Steam[1].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[0], false);

                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            Material_rigid[4].gravityScale = 1.0f;
                            Positions_Steam[0].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[0].childCount == 1 && Material_Positions_Steam[1].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_2 = 0;

                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[1], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            // instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            Material_rigid[5].gravityScale = 1.0f;
                            Positions_Steam[1].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[0].childCount == 0 && Material_Positions_Steam[1].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[0], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            Material_rigid[4].gravityScale = 1.0f;
                            Positions_Steam[0].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_2 = 0;

                        }



                        if (Material_Positions_Steam[0].childCount == 1 && Material_Positions_Steam[1].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_2 = 0;
                        }
                    }

                    if (count_2 == 2)
                    {

                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject4 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[0].childCount == 0 && Material_Positions_Steam[1].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[0], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            // instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            instantiatedObject4.transform.SetParent(Material_Positions_Steam[1], false);
                            instantiatedObject4.transform.localPosition = Vector3.zero;
                            //instantiatedObject4.transform.localRotation = Quaternion.identity;
                            instantiatedObject4.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject4.transform.localScale = Vector3.one;

                            Material_rigid[4].gravityScale = 1.0f;
                            Positions_Steam[0].enabled = true;

                            Material_rigid[5].gravityScale = 1.0f;
                            Positions_Steam[1].enabled = true;

                            Destroy(instantiatedObject3);
                            Destroy(instantiatedObject4);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[0].childCount == 0 && Material_Positions_Steam[1].childCount == 1)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[0], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid[4].gravityScale = 1.0f;
                            Positions_Steam[0].enabled = true;

                            Destroy(instantiatedObject3);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[0].childCount == 1 && Material_Positions_Steam[1].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[1], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid[5].gravityScale = 1.0f;
                            Positions_Steam[1].enabled = true;

                            Destroy(instantiatedObject3);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[0].childCount == 1 && Material_Positions_Steam[1].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_2 = 0;
                        }


                    }
                    else if (count_2 > 2)
                    {
                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject4 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[0].childCount == 0 && Material_Positions_Steam[1].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[0], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                           //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            instantiatedObject4.transform.SetParent(Material_Positions_Steam[1], false);
                            instantiatedObject4.transform.localPosition = Vector3.zero;
                            //instantiatedObject4.transform.localRotation = Quaternion.identity;
                            instantiatedObject4.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject4.transform.localScale = Vector3.one;

                            Material_rigid[4].gravityScale = 1.0f;
                            Positions_Steam[0].enabled = true;

                            Material_rigid[5].gravityScale = 1.0f;
                            Positions_Steam[1].enabled = true;

                            Destroy(instantiatedObject3);
                            Destroy(instantiatedObject4);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[0].childCount == 0 && Material_Positions_Steam[1].childCount == 1)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[0], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid[4].gravityScale = 1.0f;
                            Positions_Steam[0].enabled = true;

                            Destroy(instantiatedObject3);



                            count_2 = 0;
                        }


                        if (Material_Positions_Steam[0].childCount == 1 && Material_Positions_Steam[1].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[1], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid[5].gravityScale = 1.0f;
                            Positions_Steam[1].enabled = true;

                            Destroy(instantiatedObject3);



                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[0].childCount == 1 && Material_Positions_Steam[1].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_2 = 0;
                        }


                    }
                }



                //Ŀ��
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "Ŀ����(���ý�)(Clone)")
                {
                    count_3++;

                    if (count_3 == 1)
                    {
                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[0].childCount == 0 && Material_Positions_Coffee[1].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject5.transform.SetParent(Material_Positions_Steam[0], false);

                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;

                            instantiatedObject5.transform.localScale = Vector3.one;

                            Material_rigid[6].gravityScale = 1.0f;
                            Positions_Coffee[0].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[0].childCount == 1 && Material_Positions_Coffee[1].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_3 = 0;

                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[1], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            Material_rigid[7].gravityScale = 1.0f;
                            Positions_Coffee[1].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[0].childCount == 0 && Material_Positions_Coffee[1].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[0], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            Material_rigid[6].gravityScale = 1.0f;
                            Positions_Coffee[0].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_3 = 0;

                        }



                        if (Material_Positions_Coffee[0].childCount == 1 && Material_Positions_Coffee[1].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_3 = 0;
                        }
                    }

                    if (count_3 == 2)
                    {

                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject6 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[0].childCount == 0 && Material_Positions_Coffee[1].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[0], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            instantiatedObject6.transform.SetParent(Material_Positions_Coffee[1], false);
                            instantiatedObject6.transform.localPosition = Vector3.zero;
                            instantiatedObject6.transform.localRotation = Quaternion.identity;
                            instantiatedObject6.transform.localScale = Vector3.one;

                            Material_rigid[6].gravityScale = 1.0f;
                            Positions_Coffee[0].enabled = true;

                            Material_rigid[7].gravityScale = 1.0f;
                            Positions_Coffee[1].enabled = true;

                            Destroy(instantiatedObject5);
                            Destroy(instantiatedObject6);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[0].childCount == 0 && Material_Positions_Coffee[1].childCount == 1)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[0], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid[6].gravityScale = 1.0f;
                            Positions_Coffee[0].enabled = true;

                            Destroy(instantiatedObject5);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[0].childCount == 1 && Material_Positions_Coffee[1].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[1], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid[7].gravityScale = 1.0f;
                            Positions_Coffee[1].enabled = true;

                            Destroy(instantiatedObject5);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[0].childCount == 1 && Material_Positions_Coffee[1].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_3 = 0;
                        }


                    }
                    else if (count_3 > 2)
                    {
                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject6 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[0].childCount == 0 && Material_Positions_Coffee[1].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[0], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            instantiatedObject6.transform.SetParent(Material_Positions_Coffee[1], false);
                            instantiatedObject6.transform.localPosition = Vector3.zero;
                            instantiatedObject6.transform.localRotation = Quaternion.identity;
                            instantiatedObject6.transform.localScale = Vector3.one;

                            Material_rigid[6].gravityScale = 1.0f;
                            Positions_Coffee[0].enabled = true;

                            Material_rigid[7].gravityScale = 1.0f;
                            Positions_Coffee[1].enabled = true;

                            Destroy(instantiatedObject5);
                            Destroy(instantiatedObject6);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[0].childCount == 0 && Material_Positions_Coffee[1].childCount == 1)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[0], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid[6].gravityScale = 1.0f;
                            Positions_Coffee[0].enabled = true;

                            Destroy(instantiatedObject5);



                            count_3 = 0;
                        }


                        if (Material_Positions_Coffee[0].childCount == 1 && Material_Positions_Coffee[1].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[1], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid[7].gravityScale = 1.0f;
                            Positions_Coffee[1].enabled = true;

                            Destroy(instantiatedObject5);



                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[0].childCount == 1 && Material_Positions_Coffee[1].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_3 = 0;
                        }


                    }
                }

                //����
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_4++;

                    if (count_4 == 1)
                    {
                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[0].childCount == 0 && Material_Positions_Milk[1].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[0], false);

                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            Material_rigid[8].gravityScale = 1.0f;
                            Positions_Milk[0].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[0].childCount == 1 && Material_Positions_Milk[1].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_4 = 0;

                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[1], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            Material_rigid[9].gravityScale = 1.0f;
                            Positions_Milk[1].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[0].childCount == 0 && Material_Positions_Milk[1].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[0], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            Material_rigid[8].gravityScale = 1.0f;
                            Positions_Milk[0].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_4 = 0;

                        }



                        if (Material_Positions_Milk[0].childCount == 1 && Material_Positions_Milk[1].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_4 = 0;
                        }
                    }

                    if (count_4 == 2)
                    {

                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject8 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[0].childCount == 0 && Material_Positions_Milk[1].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[0], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            instantiatedObject8.transform.SetParent(Material_Positions_Milk[1], false);
                            instantiatedObject8.transform.localPosition = Vector3.zero;
                            //instantiatedObject8.transform.localRotation = Quaternion.identity;
                            instantiatedObject8.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject8.transform.localScale = Vector3.one;

                            Material_rigid[8].gravityScale = 1.0f;
                            Positions_Milk[0].enabled = true;

                            Material_rigid[9].gravityScale = 1.0f;
                            Positions_Milk[1].enabled = true;

                            Destroy(instantiatedObject7);
                            Destroy(instantiatedObject8);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[0].childCount == 0 && Material_Positions_Milk[1].childCount == 1)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[0], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid[8].gravityScale = 1.0f;
                            Positions_Milk[0].enabled = true;

                            Destroy(instantiatedObject7);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[0].childCount == 1 && Material_Positions_Milk[1].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[1], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid[9].gravityScale = 1.0f;
                            Positions_Milk[1].enabled = true;

                            Destroy(instantiatedObject7);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[0].childCount == 1 && Material_Positions_Milk[1].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_4 = 0;
                        }


                    }
                    else if (count_4 > 2)
                    {
                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject8 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[0].childCount == 0 && Material_Positions_Milk[1].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[0], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            // instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            instantiatedObject8.transform.SetParent(Material_Positions_Milk[1], false);
                            instantiatedObject8.transform.localPosition = Vector3.zero;
                            //instantiatedObject8.transform.localRotation = Quaternion.identity;
                            instantiatedObject8.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject8.transform.localScale = Vector3.one;

                            Material_rigid[8].gravityScale = 1.0f;
                            Positions_Milk[0].enabled = true;

                            Material_rigid[9].gravityScale = 1.0f;
                            Positions_Milk[1].enabled = true;

                            Destroy(instantiatedObject7);
                            Destroy(instantiatedObject8);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[0].childCount == 0 && Material_Positions_Milk[1].childCount == 1)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[0], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid[8].gravityScale = 1.0f;
                            Positions_Milk[0].enabled = true;

                            Destroy(instantiatedObject7);



                            count_4 = 0;
                        }


                        if (Material_Positions_Milk[0].childCount == 1 && Material_Positions_Milk[1].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[1], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid[9].gravityScale = 1.0f;
                            Positions_Milk[1].enabled = true;

                            Destroy(instantiatedObject7);



                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[0].childCount == 1 && Material_Positions_Milk[1].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_4 = 0;
                        }


                    }
                }


                //��
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "��(���ý�)(Clone)")
                {
                    count_5++;

                    if (count_5 == 1)
                    {
                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[0].childCount == 0 && Material_Positions_Water[1].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[0], false);

                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            Material_rigid[10].gravityScale = 1.0f;
                            Positions_Water[0].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[0].childCount == 1 && Material_Positions_Water[1].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_5 = 0;

                            instantiatedObject9.transform.SetParent(Material_Positions_Water[1], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            Material_rigid[11].gravityScale = 1.0f;
                            Positions_Water[1].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[0].childCount == 0 && Material_Positions_Water[1].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject9.transform.SetParent(Material_Positions_Water[0], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            Material_rigid[10].gravityScale = 1.0f;
                            Positions_Water[0].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_5 = 0;

                        }



                        if (Material_Positions_Water[0].childCount == 1 && Material_Positions_Water[1].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_5 = 0;
                        }
                    }

                    if (count_5 == 2)
                    {

                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject10 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[0].childCount == 0 && Material_Positions_Water[1].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[0], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            // instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            instantiatedObject10.transform.SetParent(Material_Positions_Water[1], false);
                            instantiatedObject10.transform.localPosition = Vector3.zero;
                            //instantiatedObject10.transform.localRotation = Quaternion.identity;
                            instantiatedObject10.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject10.transform.localScale = Vector3.one;

                            Material_rigid[10].gravityScale = 1.0f;
                            Positions_Water[0].enabled = true;

                            Material_rigid[11].gravityScale = 1.0f;
                            Positions_Water[1].enabled = true;

                            Destroy(instantiatedObject9);
                            Destroy(instantiatedObject10);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[0].childCount == 0 && Material_Positions_Water[1].childCount == 1)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[0], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid[10].gravityScale = 1.0f;
                            Positions_Water[0].enabled = true;

                            Destroy(instantiatedObject9);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[0].childCount == 1 && Material_Positions_Water[1].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[1], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid[11].gravityScale = 1.0f;
                            Positions_Water[1].enabled = true;

                            Destroy(instantiatedObject9);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_5 = 0;
                        }

                        if (Material_Positions_Water[0].childCount == 1 && Material_Positions_Water[1].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_5 = 0;
                        }


                    }
                    else if (count_5 > 2)
                    {
                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject10 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[0].childCount == 0 && Material_Positions_Water[1].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[0], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            instantiatedObject10.transform.SetParent(Material_Positions_Water[1], false);
                            instantiatedObject10.transform.localPosition = Vector3.zero;
                            //instantiatedObject10.transform.localRotation = Quaternion.identity;
                            instantiatedObject10.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject10.transform.localScale = Vector3.one;

                            Material_rigid[10].gravityScale = 1.0f;
                            Positions_Water[0].enabled = true;

                            Material_rigid[11].gravityScale = 1.0f;
                            Positions_Water[1].enabled = true;

                            Destroy(instantiatedObject9);
                            Destroy(instantiatedObject10);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[0].childCount == 0 && Material_Positions_Water[1].childCount == 1)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[0], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            // instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid[10].gravityScale = 1.0f;
                            Positions_Water[0].enabled = true;

                            Destroy(instantiatedObject9);



                            count_5 = 0;
                        }


                        if (Material_Positions_Water[0].childCount == 1 && Material_Positions_Water[1].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[1], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid[11].gravityScale = 1.0f;
                            Positions_Water[1].enabled = true;

                            Destroy(instantiatedObject9);



                            count_5 = 0;
                        }

                        if (Material_Positions_Water[0].childCount == 1 && Material_Positions_Water[1].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_5 = 0;
                        }


                    }
                }

                //����
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_6++;

                    if (count_6 == 1)
                    {
                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[0].childCount == 0 && Material_Positions_Tea[1].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[0], false);

                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;

                            instantiatedObject11.transform.localScale = Vector3.one;

                            Material_rigid[12].gravityScale = 1.0f;
                            Positions_Tea[0].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[0].childCount == 1 && Material_Positions_Tea[1].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_6 = 0;

                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[1], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            Material_rigid[13].gravityScale = 1.0f;
                            Positions_Tea[1].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[0].childCount == 0 && Material_Positions_Tea[1].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[0], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            Material_rigid[12].gravityScale = 1.0f;
                            Positions_Tea[0].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_6 = 0;

                        }



                        if (Material_Positions_Tea[0].childCount == 1 && Material_Positions_Tea[1].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_6 = 0;
                        }
                    }

                    if (count_6 == 2)
                    {

                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject12 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[0].childCount == 0 && Material_Positions_Tea[1].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[0], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            instantiatedObject12.transform.SetParent(Material_Positions_Tea[1], false);
                            instantiatedObject12.transform.localPosition = Vector3.zero;
                            instantiatedObject12.transform.localRotation = Quaternion.identity;
                            instantiatedObject12.transform.localScale = Vector3.one;

                            Material_rigid[12].gravityScale = 1.0f;
                            Positions_Tea[0].enabled = true;

                            Material_rigid[13].gravityScale = 1.0f;
                            Positions_Tea[1].enabled = true;

                            Destroy(instantiatedObject11);
                            Destroy(instantiatedObject12);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[0].childCount == 0 && Material_Positions_Tea[1].childCount == 1)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[0], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid[12].gravityScale = 1.0f;
                            Positions_Tea[0].enabled = true;

                            Destroy(instantiatedObject11);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[0].childCount == 1 && Material_Positions_Tea[1].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[1], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid[13].gravityScale = 1.0f;
                            Positions_Tea[1].enabled = true;

                            Destroy(instantiatedObject11);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[0].childCount == 1 && Material_Positions_Tea[1].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_6 = 0;
                        }


                    }
                    else if (count_6 > 2)
                    {
                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject12 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[0].childCount == 0 && Material_Positions_Tea[1].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[0], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            instantiatedObject12.transform.SetParent(Material_Positions_Tea[1], false);
                            instantiatedObject12.transform.localPosition = Vector3.zero;
                            instantiatedObject12.transform.localRotation = Quaternion.identity;
                            instantiatedObject12.transform.localScale = Vector3.one;

                            Material_rigid[12].gravityScale = 1.0f;
                            Positions_Tea[0].enabled = true;

                            Material_rigid[13].gravityScale = 1.0f;
                            Positions_Tea[1].enabled = true;

                            Destroy(instantiatedObject11);
                            Destroy(instantiatedObject12);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[0].childCount == 0 && Material_Positions_Tea[1].childCount == 1)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[0], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid[12].gravityScale = 1.0f;
                            Positions_Tea[0].enabled = true;

                            Destroy(instantiatedObject11);



                            count_6 = 0;
                        }


                        if (Material_Positions_Tea[0].childCount == 1 && Material_Positions_Tea[1].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[1], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid[13].gravityScale = 1.0f;
                            Positions_Tea[1].enabled = true;

                            Destroy(instantiatedObject11);



                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[0].childCount == 1 && Material_Positions_Tea[1].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_6 = 0;
                        }


                    }
                }

                //���ݸ�
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "���ݸ�(���ý�)(Clone)")
                {
                    count_7++;

                    if (count_7 == 1)
                    {
                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[0].childCount == 0 && Material_Positions_Chocolate[1].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[0], false);

                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            Material_rigid[14].gravityScale = 1.0f;
                            Positions_Chocolate[0].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[0].childCount == 1 && Material_Positions_Chocolate[1].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_7 = 0;

                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[1], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            // instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            Material_rigid[15].gravityScale = 1.0f;
                            Positions_Chocolate[1].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[0].childCount == 0 && Material_Positions_Chocolate[1].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[0], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            Material_rigid[14].gravityScale = 1.0f;
                            Positions_Chocolate[0].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_7 = 0;

                        }



                        if (Material_Positions_Chocolate[0].childCount == 1 && Material_Positions_Chocolate[1].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_7 = 0;
                        }
                    }

                    if (count_7 == 2)
                    {

                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject14 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[0].childCount == 0 && Material_Positions_Chocolate[1].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[0], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            // instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            instantiatedObject14.transform.SetParent(Material_Positions_Chocolate[1], false);
                            instantiatedObject14.transform.localPosition = Vector3.zero;
                            //instantiatedObject14.transform.localRotation = Quaternion.identity;
                            instantiatedObject14.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject14.transform.localScale = Vector3.one;

                            Material_rigid[14].gravityScale = 1.0f;
                            Positions_Chocolate[0].enabled = true;

                            Material_rigid[15].gravityScale = 1.0f;
                            Positions_Chocolate[1].enabled = true;

                            Destroy(instantiatedObject13);
                            Destroy(instantiatedObject14);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[0].childCount == 0 && Material_Positions_Chocolate[1].childCount == 1)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[0], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid[14].gravityScale = 1.0f;
                            Positions_Chocolate[0].enabled = true;

                            Destroy(instantiatedObject13);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[0].childCount == 1 && Material_Positions_Chocolate[1].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[1], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid[15].gravityScale = 1.0f;
                            Positions_Chocolate[1].enabled = true;

                            Destroy(instantiatedObject13);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[0].childCount == 1 && Material_Positions_Chocolate[1].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_7 = 0;
                        }


                    }
                    else if (count_7 > 2)
                    {
                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject14 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[0].childCount == 0 && Material_Positions_Chocolate[1].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[0], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            instantiatedObject14.transform.SetParent(Material_Positions_Chocolate[1], false);
                            instantiatedObject14.transform.localPosition = Vector3.zero;
                            //instantiatedObject14.transform.localRotation = Quaternion.identity;
                            instantiatedObject14.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject14.transform.localScale = Vector3.one;

                            Material_rigid[14].gravityScale = 1.0f;
                            Positions_Chocolate[0].enabled = true;

                            Material_rigid[15].gravityScale = 1.0f;
                            Positions_Chocolate[1].enabled = true;

                            Destroy(instantiatedObject13);
                            Destroy(instantiatedObject14);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[0].childCount == 0 && Material_Positions_Chocolate[1].childCount == 1)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[0], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            // instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid[14].gravityScale = 1.0f;
                            Positions_Chocolate[0].enabled = true;

                            Destroy(instantiatedObject13);



                            count_7 = 0;
                        }


                        if (Material_Positions_Chocolate[0].childCount == 1 && Material_Positions_Chocolate[1].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[1], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            // instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid[15].gravityScale = 1.0f;
                            Positions_Chocolate[1].enabled = true;

                            Destroy(instantiatedObject13);



                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[0].childCount == 1 && Material_Positions_Chocolate[1].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_7 = 0;
                        }


                    }
                }
            }

        }



    }


    //��ũ 2��° ��
    public void Go_Pink_Cup2_Test()
    {


        for (int i = 0; i < move_material.Pink_24.Length; i++)
        {
            if (move_material.selection_Pink_24[i].activeSelf && move_material.Pink_24[i].activeSelf && move_material.Pink_24[i].transform.childCount > 1)
            {
                move_material.selection_Pink_24[i].SetActive(false);

                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_0++;

                    if (count_0 == 1)
                    {
                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[2].childCount == 0 && Material_Positions_Ice[3].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[2], false);
                            //�θ� Material_Positions_Ice[0]�� �ش��ϴ� ��ġ�� ����. false�� ������� ���� ��ġ�� ����

                            instantiatedObject.transform.localPosition = Vector3.zero;
                            //instantiatedObject�� ���� ��ġ ����. ���� ��ǥ �������� 0, 0, 0��ġ�� ����

                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            //���� ȸ���� ����. ȸ�� �������� ����

                            instantiatedObject.transform.localScale = Vector3.one;
                            //���� �������� 1, 1, 1�� ����

                            Material_rigid_Pink2[0].gravityScale = 1.0f;
                            Positions_Ice[2].enabled = true;

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[2].childCount == 1 && Material_Positions_Ice[3].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_0 = 0;

                            instantiatedObject.transform.SetParent(Material_Positions_Ice[3], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[1].gravityScale = 1.0f;
                            Positions_Ice[3].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[2].childCount == 0 && Material_Positions_Ice[3].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject.transform.SetParent(Material_Positions_Ice[2], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[0].gravityScale = 1.0f;
                            Positions_Ice[2].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;

                        }



                        if (Material_Positions_Ice[2].childCount == 1 && Material_Positions_Ice[3].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_0 = 0;
                        }
                    }

                    if (count_0 == 2)
                    {

                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject1 = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[2].childCount == 0 && Material_Positions_Ice[3].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[2], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            instantiatedObject1.transform.SetParent(Material_Positions_Ice[3], false);
                            instantiatedObject1.transform.localPosition = Vector3.zero;
                            instantiatedObject1.transform.localRotation = Quaternion.identity;
                            instantiatedObject1.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[0].gravityScale = 1.0f;
                            Positions_Ice[2].enabled = true;

                            Material_rigid_Pink2[1].gravityScale = 1.0f;
                            Positions_Ice[3].enabled = true;

                            Destroy(instantiatedObject);
                            Destroy(instantiatedObject1);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[2].childCount == 0 && Material_Positions_Ice[3].childCount == 1)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[2], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[0].gravityScale = 1.0f;
                            Positions_Ice[2].enabled = true;

                            Destroy(instantiatedObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[2].childCount == 1 && Material_Positions_Ice[3].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[3], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[1].gravityScale = 1.0f;
                            Positions_Ice[3].enabled = true;

                            Destroy(instantiatedObject);

                            count_0 = 0;

                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[2].childCount == 1 && Material_Positions_Ice[3].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_0 = 0;
                        }


                    }
                    else if (count_0 > 2)
                    {
                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject1 = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[2].childCount == 0 && Material_Positions_Ice[3].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[2], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            instantiatedObject1.transform.SetParent(Material_Positions_Ice[3], false);
                            instantiatedObject1.transform.localPosition = Vector3.zero;
                            instantiatedObject1.transform.localRotation = Quaternion.identity;
                            instantiatedObject1.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[0].gravityScale = 1.0f;
                            Positions_Ice[2].enabled = true;

                            Material_rigid_Pink2[1].gravityScale = 1.0f;
                            Positions_Ice[3].enabled = true;

                            Destroy(instantiatedObject);
                            Destroy(instantiatedObject1);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[2].childCount == 0 && Material_Positions_Ice[3].childCount == 1)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[2], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[0].gravityScale = 1.0f;
                            Positions_Ice[2].enabled = true;

                            Destroy(instantiatedObject);



                            count_0 = 0;
                        }


                        if (Material_Positions_Ice[2].childCount == 1 && Material_Positions_Ice[3].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[3], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[1].gravityScale = 1.0f;
                            Positions_Ice[3].enabled = true;

                            Destroy(instantiatedObject);



                            count_0 = 0;

                            //return;
                            //move_material.selection_Pink_24[i].SetActive(false);
                            //count_0 = 0;
                        }

                        if (Material_Positions_Ice[2].childCount == 1 && Material_Positions_Ice[3].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_0 = 0;
                        }


                    }
                }

                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "ī���(���ý�)(Clone)")
                {
                    count_1++;

                    if (count_1 == 1)
                    {
                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[2].childCount == 0 && Material_Positions_Caramel[3].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[2], false);

                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;

                            instantiatedObject0.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[2].gravityScale = 1.0f;
                            Positions_Caramel[2].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[2].childCount == 1 && Material_Positions_Caramel[3].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_1 = 0;

                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[3], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[3].gravityScale = 1.0f;
                            Positions_Caramel[3].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[2].childCount == 0 && Material_Positions_Caramel[3].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[2], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[2].gravityScale = 1.0f;
                            Positions_Caramel[2].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_1 = 0;

                        }



                        if (Material_Positions_Caramel[2].childCount == 1 && Material_Positions_Caramel[3].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_1 = 0;
                        }
                    }

                    if (count_1 == 2)
                    {

                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject2 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[2].childCount == 0 && Material_Positions_Caramel[3].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[2], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            instantiatedObject2.transform.SetParent(Material_Positions_Caramel[3], false);
                            instantiatedObject2.transform.localPosition = Vector3.zero;
                            instantiatedObject2.transform.localRotation = Quaternion.identity;
                            instantiatedObject2.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[2].gravityScale = 1.0f;
                            Positions_Caramel[2].enabled = true;

                            Material_rigid_Pink2[3].gravityScale = 1.0f;
                            Positions_Caramel[3].enabled = true;

                            Destroy(instantiatedObject0);
                            Destroy(instantiatedObject2);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[2].childCount == 0 && Material_Positions_Caramel[3].childCount == 1)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[2], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[2].gravityScale = 1.0f;
                            Positions_Caramel[2].enabled = true;

                            Destroy(instantiatedObject0);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[2].childCount == 1 && Material_Positions_Caramel[3].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[3], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[3].gravityScale = 1.0f;
                            Positions_Caramel[3].enabled = true;

                            Destroy(instantiatedObject0);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[2].childCount == 1 && Material_Positions_Caramel[3].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_1 = 0;
                        }


                    }
                    else if (count_1 > 2)
                    {
                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject2 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[2].childCount == 0 && Material_Positions_Caramel[3].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[2], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            instantiatedObject2.transform.SetParent(Material_Positions_Caramel[3], false);
                            instantiatedObject2.transform.localPosition = Vector3.zero;
                            instantiatedObject2.transform.localRotation = Quaternion.identity;
                            instantiatedObject2.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[2].gravityScale = 1.0f;
                            Positions_Caramel[2].enabled = true;

                            Material_rigid_Pink2[3].gravityScale = 1.0f;
                            Positions_Caramel[3].enabled = true;

                            Destroy(instantiatedObject0);
                            Destroy(instantiatedObject2);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[2].childCount == 0 && Material_Positions_Caramel[3].childCount == 1)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[2], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[2].gravityScale = 1.0f;
                            Positions_Caramel[2].enabled = true;

                            Destroy(instantiatedObject0);



                            count_1 = 0;
                        }


                        if (Material_Positions_Caramel[2].childCount == 1 && Material_Positions_Caramel[3].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[3], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[3].gravityScale = 1.0f;
                            Positions_Caramel[3].enabled = true;

                            Destroy(instantiatedObject0);



                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[2].childCount == 1 && Material_Positions_Caramel[3].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_1 = 0;
                        }


                    }
                }


                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_2++;

                    if (count_2 == 1)
                    {
                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[2].childCount == 0 && Material_Positions_Steam[3].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[2], false);

                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[4].gravityScale = 1.0f;
                            Positions_Steam[2].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[2].childCount == 1 && Material_Positions_Steam[3].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_2 = 0;

                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[3], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[5].gravityScale = 1.0f;
                            Positions_Steam[3].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[2].childCount == 0 && Material_Positions_Steam[3].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[2], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);
                            // instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[4].gravityScale = 1.0f;
                            Positions_Steam[2].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_2 = 0;

                        }



                        if (Material_Positions_Steam[2].childCount == 1 && Material_Positions_Steam[3].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_2 = 0;
                        }
                    }

                    if (count_2 == 2)
                    {

                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject4 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[2].childCount == 0 && Material_Positions_Steam[3].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[2], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            instantiatedObject4.transform.SetParent(Material_Positions_Steam[3], false);
                            instantiatedObject4.transform.localPosition = Vector3.zero;
                            //instantiatedObject4.transform.localRotation = Quaternion.identity;
                            instantiatedObject4.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject4.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[4].gravityScale = 1.0f;
                            Positions_Steam[2].enabled = true;

                            Material_rigid_Pink2[5].gravityScale = 1.0f;
                            Positions_Steam[3].enabled = true;

                            Destroy(instantiatedObject3);
                            Destroy(instantiatedObject4);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[2].childCount == 0 && Material_Positions_Steam[3].childCount == 1)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[2], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[4].gravityScale = 1.0f;
                            Positions_Steam[2].enabled = true;

                            Destroy(instantiatedObject3);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[2].childCount == 1 && Material_Positions_Steam[3].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[3], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[5].gravityScale = 1.0f;
                            Positions_Steam[3].enabled = true;

                            Destroy(instantiatedObject3);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[2].childCount == 1 && Material_Positions_Steam[3].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_2 = 0;
                        }


                    }
                    else if (count_2 > 2)
                    {
                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject4 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[2].childCount == 0 && Material_Positions_Steam[3].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[2], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            instantiatedObject4.transform.SetParent(Material_Positions_Steam[3], false);
                            instantiatedObject4.transform.localPosition = Vector3.zero;
                            //instantiatedObject4.transform.localRotation = Quaternion.identity;
                            instantiatedObject4.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject4.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[4].gravityScale = 1.0f;
                            Positions_Steam[2].enabled = true;

                            Material_rigid_Pink2[5].gravityScale = 1.0f;
                            Positions_Steam[3].enabled = true;

                            Destroy(instantiatedObject3);
                            Destroy(instantiatedObject4);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[2].childCount == 0 && Material_Positions_Steam[3].childCount == 1)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[2], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[4].gravityScale = 1.0f;
                            Positions_Steam[2].enabled = true;

                            Destroy(instantiatedObject3);



                            count_2 = 0;
                        }


                        if (Material_Positions_Steam[2].childCount == 1 && Material_Positions_Steam[3].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[3], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[5].gravityScale = 1.0f;
                            Positions_Steam[3].enabled = true;

                            Destroy(instantiatedObject3);



                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[2].childCount == 1 && Material_Positions_Steam[3].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_2 = 0;
                        }


                    }
                }



                //Ŀ��
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "Ŀ����(���ý�)(Clone)")
                {
                    count_3++;

                    if (count_3 == 1)
                    {
                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[2].childCount == 0 && Material_Positions_Coffee[3].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject5.transform.SetParent(Material_Positions_Steam[2], false);

                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;

                            instantiatedObject5.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[6].gravityScale = 1.0f;
                            Positions_Coffee[2].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[2].childCount == 1 && Material_Positions_Coffee[3].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_3 = 0;

                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[3], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[7].gravityScale = 1.0f;
                            Positions_Coffee[3].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[2].childCount == 0 && Material_Positions_Coffee[3].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[2], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[6].gravityScale = 1.0f;
                            Positions_Coffee[2].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_3 = 0;

                        }



                        if (Material_Positions_Coffee[2].childCount == 1 && Material_Positions_Coffee[3].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_3 = 0;
                        }
                    }

                    if (count_3 == 2)
                    {

                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject6 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[2].childCount == 0 && Material_Positions_Coffee[3].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[2], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            instantiatedObject6.transform.SetParent(Material_Positions_Coffee[3], false);
                            instantiatedObject6.transform.localPosition = Vector3.zero;
                            instantiatedObject6.transform.localRotation = Quaternion.identity;
                            instantiatedObject6.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[6].gravityScale = 1.0f;
                            Positions_Coffee[2].enabled = true;

                            Material_rigid_Pink2[7].gravityScale = 1.0f;
                            Positions_Coffee[3].enabled = true;

                            Destroy(instantiatedObject5);
                            Destroy(instantiatedObject6);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[2].childCount == 0 && Material_Positions_Coffee[3].childCount == 1)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[2], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[6].gravityScale = 1.0f;
                            Positions_Coffee[2].enabled = true;

                            Destroy(instantiatedObject5);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[2].childCount == 1 && Material_Positions_Coffee[3].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[3], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[7].gravityScale = 1.0f;
                            Positions_Coffee[3].enabled = true;

                            Destroy(instantiatedObject5);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[2].childCount == 1 && Material_Positions_Coffee[3].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_3 = 0;
                        }


                    }
                    else if (count_3 > 2)
                    {
                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject6 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[2].childCount == 0 && Material_Positions_Coffee[3].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[2], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            instantiatedObject6.transform.SetParent(Material_Positions_Coffee[3], false);
                            instantiatedObject6.transform.localPosition = Vector3.zero;
                            instantiatedObject6.transform.localRotation = Quaternion.identity;
                            instantiatedObject6.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[6].gravityScale = 1.0f;
                            Positions_Coffee[2].enabled = true;

                            Material_rigid_Pink2[7].gravityScale = 1.0f;
                            Positions_Coffee[3].enabled = true;

                            Destroy(instantiatedObject5);
                            Destroy(instantiatedObject6);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[2].childCount == 0 && Material_Positions_Coffee[3].childCount == 1)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[2], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[6].gravityScale = 1.0f;
                            Positions_Coffee[2].enabled = true;

                            Destroy(instantiatedObject5);



                            count_3 = 0;
                        }


                        if (Material_Positions_Coffee[2].childCount == 1 && Material_Positions_Coffee[3].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[3], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[7].gravityScale = 1.0f;
                            Positions_Coffee[3].enabled = true;

                            Destroy(instantiatedObject5);



                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[2].childCount == 1 && Material_Positions_Coffee[3].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_3 = 0;
                        }


                    }
                }

                //����
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_4++;

                    if (count_4 == 1)
                    {
                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[2].childCount == 0 && Material_Positions_Milk[3].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[2], false);

                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[8].gravityScale = 1.0f;
                            Positions_Milk[2].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[2].childCount == 1 && Material_Positions_Milk[3].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_4 = 0;

                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[3], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[9].gravityScale = 1.0f;
                            Positions_Milk[3].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[2].childCount == 0 && Material_Positions_Milk[3].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[2], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[8].gravityScale = 1.0f;
                            Positions_Milk[2].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_4 = 0;

                        }



                        if (Material_Positions_Milk[2].childCount == 1 && Material_Positions_Milk[3].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_4 = 0;
                        }
                    }

                    if (count_4 == 2)
                    {

                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject8 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[2].childCount == 0 && Material_Positions_Milk[3].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[2], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            instantiatedObject8.transform.SetParent(Material_Positions_Milk[3], false);
                            instantiatedObject8.transform.localPosition = Vector3.zero;
                            // instantiatedObject8.transform.localRotation = Quaternion.identity;
                            instantiatedObject8.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject8.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[8].gravityScale = 1.0f;
                            Positions_Milk[2].enabled = true;

                            Material_rigid_Pink2[9].gravityScale = 1.0f;
                            Positions_Milk[3].enabled = true;

                            Destroy(instantiatedObject7);
                            Destroy(instantiatedObject8);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[2].childCount == 0 && Material_Positions_Milk[3].childCount == 1)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[2], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[8].gravityScale = 1.0f;
                            Positions_Milk[2].enabled = true;

                            Destroy(instantiatedObject7);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[2].childCount == 1 && Material_Positions_Milk[3].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[3], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[9].gravityScale = 1.0f;
                            Positions_Milk[3].enabled = true;

                            Destroy(instantiatedObject7);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[2].childCount == 1 && Material_Positions_Milk[3].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_4 = 0;
                        }


                    }
                    else if (count_4 > 2)
                    {
                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject8 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[2].childCount == 0 && Material_Positions_Milk[3].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[2], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            instantiatedObject8.transform.SetParent(Material_Positions_Milk[3], false);
                            instantiatedObject8.transform.localPosition = Vector3.zero;
                            // instantiatedObject8.transform.localRotation = Quaternion.identity;
                            instantiatedObject8.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject8.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[8].gravityScale = 1.0f;
                            Positions_Milk[2].enabled = true;

                            Material_rigid_Pink2[9].gravityScale = 1.0f;
                            Positions_Milk[3].enabled = true;

                            Destroy(instantiatedObject7);
                            Destroy(instantiatedObject8);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[2].childCount == 0 && Material_Positions_Milk[3].childCount == 1)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[2], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[8].gravityScale = 1.0f;
                            Positions_Milk[2].enabled = true;

                            Destroy(instantiatedObject7);



                            count_4 = 0;
                        }


                        if (Material_Positions_Milk[2].childCount == 1 && Material_Positions_Milk[3].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[3], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[9].gravityScale = 1.0f;
                            Positions_Milk[3].enabled = true;

                            Destroy(instantiatedObject7);



                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[2].childCount == 1 && Material_Positions_Milk[3].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_4 = 0;
                        }


                    }
                }


                //��
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "��(���ý�)(Clone)")
                {
                    count_5++;

                    if (count_5 == 1)
                    {
                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[2].childCount == 0 && Material_Positions_Water[3].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[2], false);

                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[10].gravityScale = 1.0f;
                            Positions_Water[2].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[2].childCount == 1 && Material_Positions_Water[3].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_5 = 0;

                            instantiatedObject9.transform.SetParent(Material_Positions_Water[3], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[11].gravityScale = 1.0f;
                            Positions_Water[3].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[2].childCount == 0 && Material_Positions_Water[3].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject9.transform.SetParent(Material_Positions_Water[2], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[10].gravityScale = 1.0f;
                            Positions_Water[2].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_5 = 0;

                        }



                        if (Material_Positions_Water[2].childCount == 1 && Material_Positions_Water[3].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_5 = 0;
                        }
                    }

                    if (count_5 == 2)
                    {

                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject10 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[2].childCount == 0 && Material_Positions_Water[3].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[2], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            instantiatedObject10.transform.SetParent(Material_Positions_Water[3], false);
                            instantiatedObject10.transform.localPosition = Vector3.zero;
                            //instantiatedObject10.transform.localRotation = Quaternion.identity;
                            instantiatedObject10.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject10.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[10].gravityScale = 1.0f;
                            Positions_Water[2].enabled = true;

                            Material_rigid_Pink2[11].gravityScale = 1.0f;
                            Positions_Water[3].enabled = true;

                            Destroy(instantiatedObject9);
                            Destroy(instantiatedObject10);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[2].childCount == 0 && Material_Positions_Water[3].childCount == 1)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[2], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            // instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[10].gravityScale = 1.0f;
                            Positions_Water[2].enabled = true;

                            Destroy(instantiatedObject9);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[2].childCount == 1 && Material_Positions_Water[3].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[3], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[11].gravityScale = 1.0f;
                            Positions_Water[3].enabled = true;

                            Destroy(instantiatedObject9);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_5 = 0;
                        }

                        if (Material_Positions_Water[2].childCount == 1 && Material_Positions_Water[3].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_5 = 0;
                        }


                    }
                    else if (count_5 > 2)
                    {
                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject10 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[2].childCount == 0 && Material_Positions_Water[3].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[2], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            // instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            instantiatedObject10.transform.SetParent(Material_Positions_Water[3], false);
                            instantiatedObject10.transform.localPosition = Vector3.zero;
                            //instantiatedObject10.transform.localRotation = Quaternion.identity;
                            instantiatedObject10.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject10.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[10].gravityScale = 1.0f;
                            Positions_Water[2].enabled = true;

                            Material_rigid_Pink2[11].gravityScale = 1.0f;
                            Positions_Water[3].enabled = true;

                            Destroy(instantiatedObject9);
                            Destroy(instantiatedObject10);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[2].childCount == 0 && Material_Positions_Water[3].childCount == 1)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[2], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            // instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[10].gravityScale = 1.0f;
                            Positions_Water[2].enabled = true;

                            Destroy(instantiatedObject9);



                            count_5 = 0;
                        }


                        if (Material_Positions_Water[2].childCount == 1 && Material_Positions_Water[3].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[3], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[11].gravityScale = 1.0f;
                            Positions_Water[3].enabled = true;

                            Destroy(instantiatedObject9);



                            count_5 = 0;
                        }

                        if (Material_Positions_Water[2].childCount == 1 && Material_Positions_Water[3].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_5 = 0;
                        }


                    }
                }

                //����
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_6++;

                    if (count_6 == 1)
                    {
                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[2].childCount == 0 && Material_Positions_Tea[3].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[2], false);

                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;

                            instantiatedObject11.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[12].gravityScale = 1.0f;
                            Positions_Tea[2].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[2].childCount == 1 && Material_Positions_Tea[3].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_6 = 0;

                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[3], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[13].gravityScale = 1.0f;
                            Positions_Tea[3].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[2].childCount == 0 && Material_Positions_Tea[3].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[2], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[12].gravityScale = 1.0f;
                            Positions_Tea[2].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_6 = 0;

                        }



                        if (Material_Positions_Tea[2].childCount == 1 && Material_Positions_Tea[3].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_6 = 0;
                        }
                    }

                    if (count_6 == 2)
                    {

                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject12 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[2].childCount == 0 && Material_Positions_Tea[3].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[2], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            instantiatedObject12.transform.SetParent(Material_Positions_Tea[3], false);
                            instantiatedObject12.transform.localPosition = Vector3.zero;
                            instantiatedObject12.transform.localRotation = Quaternion.identity;
                            instantiatedObject12.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[12].gravityScale = 1.0f;
                            Positions_Tea[2].enabled = true;

                            Material_rigid_Pink2[13].gravityScale = 1.0f;
                            Positions_Tea[3].enabled = true;

                            Destroy(instantiatedObject11);
                            Destroy(instantiatedObject12);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[2].childCount == 0 && Material_Positions_Tea[3].childCount == 1)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[2], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[12].gravityScale = 1.0f;
                            Positions_Tea[2].enabled = true;

                            Destroy(instantiatedObject11);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[2].childCount == 1 && Material_Positions_Tea[3].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[3], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[13].gravityScale = 1.0f;
                            Positions_Tea[3].enabled = true;

                            Destroy(instantiatedObject11);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[2].childCount == 1 && Material_Positions_Tea[3].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_6 = 0;
                        }


                    }
                    else if (count_6 > 2)
                    {
                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject12 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[2].childCount == 0 && Material_Positions_Tea[3].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[2], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            instantiatedObject12.transform.SetParent(Material_Positions_Tea[3], false);
                            instantiatedObject12.transform.localPosition = Vector3.zero;
                            instantiatedObject12.transform.localRotation = Quaternion.identity;
                            instantiatedObject12.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[12].gravityScale = 1.0f;
                            Positions_Tea[2].enabled = true;

                            Material_rigid_Pink2[13].gravityScale = 1.0f;
                            Positions_Tea[3].enabled = true;

                            Destroy(instantiatedObject11);
                            Destroy(instantiatedObject12);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[2].childCount == 0 && Material_Positions_Tea[3].childCount == 1)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[2], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[12].gravityScale = 1.0f;
                            Positions_Tea[2].enabled = true;

                            Destroy(instantiatedObject11);



                            count_6 = 0;
                        }


                        if (Material_Positions_Tea[2].childCount == 1 && Material_Positions_Tea[3].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[3], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[13].gravityScale = 1.0f;
                            Positions_Tea[3].enabled = true;

                            Destroy(instantiatedObject11);



                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[2].childCount == 1 && Material_Positions_Tea[3].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_6 = 0;
                        }


                    }
                }

                //���ݸ�
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "���ݸ�(���ý�)(Clone)")
                {
                    count_7++;

                    if (count_7 == 1)
                    {
                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[2].childCount == 0 && Material_Positions_Chocolate[3].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[2], false);

                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[14].gravityScale = 1.0f;
                            Positions_Chocolate[2].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[2].childCount == 1 && Material_Positions_Chocolate[3].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_7 = 0;

                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[3], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[15].gravityScale = 1.0f;
                            Positions_Chocolate[3].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[2].childCount == 0 && Material_Positions_Chocolate[3].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[2], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            // instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[14].gravityScale = 1.0f;
                            Positions_Chocolate[2].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_7 = 0;

                        }



                        if (Material_Positions_Chocolate[2].childCount == 1 && Material_Positions_Chocolate[3].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_7 = 0;
                        }
                    }

                    if (count_7 == 2)
                    {

                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject14 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[2].childCount == 0 && Material_Positions_Chocolate[3].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[2], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            instantiatedObject14.transform.SetParent(Material_Positions_Chocolate[3], false);
                            instantiatedObject14.transform.localPosition = Vector3.zero;
                            // instantiatedObject14.transform.localRotation = Quaternion.identity;
                            instantiatedObject14.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject14.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[14].gravityScale = 1.0f;
                            Positions_Chocolate[2].enabled = true;

                            Material_rigid_Pink2[15].gravityScale = 1.0f;
                            Positions_Chocolate[3].enabled = true;

                            Destroy(instantiatedObject13);
                            Destroy(instantiatedObject14);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[2].childCount == 0 && Material_Positions_Chocolate[3].childCount == 1)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[2], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[14].gravityScale = 1.0f;
                            Positions_Chocolate[2].enabled = true;

                            Destroy(instantiatedObject13);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[2].childCount == 1 && Material_Positions_Chocolate[3].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[3], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[15].gravityScale = 1.0f;
                            Positions_Chocolate[3].enabled = true;

                            Destroy(instantiatedObject13);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[2].childCount == 1 && Material_Positions_Chocolate[3].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_7 = 0;
                        }


                    }
                    else if (count_7 > 2)
                    {
                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject14 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[2].childCount == 0 && Material_Positions_Chocolate[3].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[2], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;

                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);
                            instantiatedObject13.transform.localScale = Vector3.one;

                            instantiatedObject14.transform.SetParent(Material_Positions_Chocolate[3], false);
                            instantiatedObject14.transform.localPosition = Vector3.zero;
                            // instantiatedObject14.transform.localRotation = Quaternion.identity;
                            instantiatedObject14.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject14.transform.localScale = Vector3.one;

                            Material_rigid_Pink2[14].gravityScale = 1.0f;
                            Positions_Chocolate[2].enabled = true;

                            Material_rigid_Pink2[15].gravityScale = 1.0f;
                            Positions_Chocolate[3].enabled = true;

                            Destroy(instantiatedObject13);
                            Destroy(instantiatedObject14);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[2].childCount == 0 && Material_Positions_Chocolate[3].childCount == 1)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[2], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            // instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[14].gravityScale = 1.0f;
                            Positions_Chocolate[2].enabled = true;

                            Destroy(instantiatedObject13);



                            count_7 = 0;
                        }


                        if (Material_Positions_Chocolate[2].childCount == 1 && Material_Positions_Chocolate[3].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[3], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid_Pink2[15].gravityScale = 1.0f;
                            Positions_Chocolate[3].enabled = true;

                            Destroy(instantiatedObject13);



                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[2].childCount == 1 && Material_Positions_Chocolate[3].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_7 = 0;
                        }


                    }
                }
            }

        }



    }


    //3��° ��ũ ��
    public void Go_Pink_Cup3_Test()
    {


        for (int i = 0; i < move_material.Pink_24.Length; i++)
        {
            if (move_material.selection_Pink_24[i].activeSelf && move_material.Pink_24[i].activeSelf && move_material.Pink_24[i].transform.childCount > 1)
            {
                move_material.selection_Pink_24[i].SetActive(false);

                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_0++;

                    if (count_0 == 1)
                    {
                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[4].childCount == 0 && Material_Positions_Ice[5].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[4], false);
                            //�θ� Material_Positions_Ice[0]�� �ش��ϴ� ��ġ�� ����. false�� ������� ���� ��ġ�� ����

                            instantiatedObject.transform.localPosition = Vector3.zero;
                            //instantiatedObject�� ���� ��ġ ����. ���� ��ǥ �������� 0, 0, 0��ġ�� ����

                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            //���� ȸ���� ����. ȸ�� �������� ����

                            instantiatedObject.transform.localScale = Vector3.one;
                            //���� �������� 1, 1, 1�� ����

                            Material_rigid_Pink3[0].gravityScale = 1.0f;
                            Positions_Ice[4].enabled = true;

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[4].childCount == 1 && Material_Positions_Ice[5].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_0 = 0;

                            instantiatedObject.transform.SetParent(Material_Positions_Ice[5], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[1].gravityScale = 1.0f;
                            Positions_Ice[5].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[4].childCount == 0 && Material_Positions_Ice[5].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject.transform.SetParent(Material_Positions_Ice[4], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[0].gravityScale = 1.0f;
                            Positions_Ice[4].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;

                        }



                        if (Material_Positions_Ice[4].childCount == 1 && Material_Positions_Ice[5].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_0 = 0;
                        }
                    }

                    if (count_0 == 2)
                    {

                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject1 = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[4].childCount == 0 && Material_Positions_Ice[5].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[4], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            instantiatedObject1.transform.SetParent(Material_Positions_Ice[5], false);
                            instantiatedObject1.transform.localPosition = Vector3.zero;
                            instantiatedObject1.transform.localRotation = Quaternion.identity;
                            instantiatedObject1.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[0].gravityScale = 1.0f;
                            Positions_Ice[4].enabled = true;

                            Material_rigid_Pink3[1].gravityScale = 1.0f;
                            Positions_Ice[5].enabled = true;

                            Destroy(instantiatedObject);
                            Destroy(instantiatedObject1);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[4].childCount == 0 && Material_Positions_Ice[5].childCount == 1)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[4], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[0].gravityScale = 1.0f;
                            Positions_Ice[4].enabled = true;

                            Destroy(instantiatedObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[4].childCount == 1 && Material_Positions_Ice[5].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[5], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[1].gravityScale = 1.0f;
                            Positions_Ice[5].enabled = true;

                            Destroy(instantiatedObject);

                            count_0 = 0;

                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[4].childCount == 1 && Material_Positions_Ice[5].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_0 = 0;
                        }


                    }
                    else if (count_0 > 2)
                    {
                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject1 = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[4].childCount == 0 && Material_Positions_Ice[5].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[4], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            instantiatedObject1.transform.SetParent(Material_Positions_Ice[5], false);
                            instantiatedObject1.transform.localPosition = Vector3.zero;
                            instantiatedObject1.transform.localRotation = Quaternion.identity;
                            instantiatedObject1.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[0].gravityScale = 1.0f;
                            Positions_Ice[4].enabled = true;

                            Material_rigid_Pink3[1].gravityScale = 1.0f;
                            Positions_Ice[5].enabled = true;

                            Destroy(instantiatedObject);
                            Destroy(instantiatedObject1);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[4].childCount == 0 && Material_Positions_Ice[5].childCount == 1)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[4], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[0].gravityScale = 1.0f;
                            Positions_Ice[4].enabled = true;

                            Destroy(instantiatedObject);



                            count_0 = 0;
                        }


                        if (Material_Positions_Ice[4].childCount == 1 && Material_Positions_Ice[5].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[5], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[1].gravityScale = 1.0f;
                            Positions_Ice[5].enabled = true;

                            Destroy(instantiatedObject);



                            count_0 = 0;

                            //return;
                            //move_material.selection_Pink_24[i].SetActive(false);
                            //count_0 = 0;
                        }

                        if (Material_Positions_Ice[4].childCount == 1 && Material_Positions_Ice[5].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_0 = 0;
                        }


                    }
                }

                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "ī���(���ý�)(Clone)")
                {
                    count_1++;

                    if (count_1 == 1)
                    {
                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[4].childCount == 0 && Material_Positions_Caramel[5].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[4], false);

                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;

                            instantiatedObject0.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[2].gravityScale = 1.0f;
                            Positions_Caramel[4].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[4].childCount == 1 && Material_Positions_Caramel[5].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_1 = 0;

                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[5], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[3].gravityScale = 1.0f;
                            Positions_Caramel[5].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[4].childCount == 0 && Material_Positions_Caramel[5].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[4], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[2].gravityScale = 1.0f;
                            Positions_Caramel[4].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_1 = 0;

                        }



                        if (Material_Positions_Caramel[4].childCount == 1 && Material_Positions_Caramel[5].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_1 = 0;
                        }
                    }

                    if (count_1 == 2)
                    {

                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject2 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[4].childCount == 0 && Material_Positions_Caramel[5].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[4], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            instantiatedObject2.transform.SetParent(Material_Positions_Caramel[5], false);
                            instantiatedObject2.transform.localPosition = Vector3.zero;
                            instantiatedObject2.transform.localRotation = Quaternion.identity;
                            instantiatedObject2.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[2].gravityScale = 1.0f;
                            Positions_Caramel[4].enabled = true;

                            Material_rigid_Pink3[3].gravityScale = 1.0f;
                            Positions_Caramel[5].enabled = true;

                            Destroy(instantiatedObject0);
                            Destroy(instantiatedObject2);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[4].childCount == 0 && Material_Positions_Caramel[5].childCount == 1)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[4], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[2].gravityScale = 1.0f;
                            Positions_Caramel[4].enabled = true;

                            Destroy(instantiatedObject0);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[4].childCount == 1 && Material_Positions_Caramel[5].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[5], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[3].gravityScale = 1.0f;
                            Positions_Caramel[5].enabled = true;

                            Destroy(instantiatedObject0);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[4].childCount == 1 && Material_Positions_Caramel[5].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_1 = 0;
                        }


                    }
                    else if (count_1 > 2)
                    {
                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject2 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[4].childCount == 0 && Material_Positions_Caramel[5].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[4], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            instantiatedObject2.transform.SetParent(Material_Positions_Caramel[5], false);
                            instantiatedObject2.transform.localPosition = Vector3.zero;
                            instantiatedObject2.transform.localRotation = Quaternion.identity;
                            instantiatedObject2.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[2].gravityScale = 1.0f;
                            Positions_Caramel[4].enabled = true;

                            Material_rigid_Pink3[3].gravityScale = 1.0f;
                            Positions_Caramel[5].enabled = true;

                            Destroy(instantiatedObject0);
                            Destroy(instantiatedObject2);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[4].childCount == 0 && Material_Positions_Caramel[5].childCount == 1)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[4], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[2].gravityScale = 1.0f;
                            Positions_Caramel[4].enabled = true;

                            Destroy(instantiatedObject0);



                            count_1 = 0;
                        }


                        if (Material_Positions_Caramel[4].childCount == 1 && Material_Positions_Caramel[5].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[5], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[3].gravityScale = 1.0f;
                            Positions_Caramel[5].enabled = true;

                            Destroy(instantiatedObject0);



                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[4].childCount == 1 && Material_Positions_Caramel[5].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_1 = 0;
                        }


                    }
                }


                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_2++;

                    if (count_2 == 1)
                    {
                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[4].childCount == 0 && Material_Positions_Steam[5].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[4], false);

                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[4].gravityScale = 1.0f;
                            Positions_Steam[4].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[4].childCount == 1 && Material_Positions_Steam[5].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_2 = 0;

                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[5], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[5].gravityScale = 1.0f;
                            Positions_Steam[5].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[4].childCount == 0 && Material_Positions_Steam[5].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[4], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[4].gravityScale = 1.0f;
                            Positions_Steam[4].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_2 = 0;

                        }



                        if (Material_Positions_Steam[4].childCount == 1 && Material_Positions_Steam[5].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_2 = 0;
                        }
                    }

                    if (count_2 == 2)
                    {

                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject4 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[4].childCount == 0 && Material_Positions_Steam[5].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[4], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            instantiatedObject4.transform.SetParent(Material_Positions_Steam[5], false);
                            instantiatedObject4.transform.localPosition = Vector3.zero;
                            //instantiatedObject4.transform.localRotation = Quaternion.identity;
                            instantiatedObject4.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject4.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[4].gravityScale = 1.0f;
                            Positions_Steam[4].enabled = true;

                            Material_rigid_Pink3[5].gravityScale = 1.0f;
                            Positions_Steam[5].enabled = true;

                            Destroy(instantiatedObject3);
                            Destroy(instantiatedObject4);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[4].childCount == 0 && Material_Positions_Steam[5].childCount == 1)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[4], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            // instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[4].gravityScale = 1.0f;
                            Positions_Steam[4].enabled = true;

                            Destroy(instantiatedObject3);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[4].childCount == 1 && Material_Positions_Steam[5].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[5], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[5].gravityScale = 1.0f;
                            Positions_Steam[5].enabled = true;

                            Destroy(instantiatedObject3);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[4].childCount == 1 && Material_Positions_Steam[5].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_2 = 0;
                        }


                    }
                    else if (count_2 > 2)
                    {
                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject4 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[4].childCount == 0 && Material_Positions_Steam[5].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[4], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;

                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);
                            instantiatedObject3.transform.localScale = Vector3.one;

                            instantiatedObject4.transform.SetParent(Material_Positions_Steam[5], false);
                            instantiatedObject4.transform.localPosition = Vector3.zero;

                            instantiatedObject4.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);
                            //instantiatedObject4.transform.localRotation = Quaternion.identity;
                            instantiatedObject4.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[4].gravityScale = 1.0f;
                            Positions_Steam[4].enabled = true;

                            Material_rigid_Pink3[5].gravityScale = 1.0f;
                            Positions_Steam[5].enabled = true;

                            Destroy(instantiatedObject3);
                            Destroy(instantiatedObject4);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[4].childCount == 0 && Material_Positions_Steam[5].childCount == 1)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[4], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[4].gravityScale = 1.0f;
                            Positions_Steam[4].enabled = true;

                            Destroy(instantiatedObject3);



                            count_2 = 0;
                        }


                        if (Material_Positions_Steam[4].childCount == 1 && Material_Positions_Steam[5].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[5], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[5].gravityScale = 1.0f;
                            Positions_Steam[5].enabled = true;

                            Destroy(instantiatedObject3);



                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[4].childCount == 1 && Material_Positions_Steam[5].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_2 = 0;
                        }


                    }
                }



                //Ŀ��
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "Ŀ����(���ý�)(Clone)")
                {
                    count_3++;

                    if (count_3 == 1)
                    {
                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[4].childCount == 0 && Material_Positions_Coffee[5].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject5.transform.SetParent(Material_Positions_Steam[4], false);

                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;

                            instantiatedObject5.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[6].gravityScale = 1.0f;
                            Positions_Coffee[4].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[4].childCount == 1 && Material_Positions_Coffee[5].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_3 = 0;

                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[5], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[7].gravityScale = 1.0f;
                            Positions_Coffee[5].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[4].childCount == 0 && Material_Positions_Coffee[5].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[4], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[6].gravityScale = 1.0f;
                            Positions_Coffee[4].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_3 = 0;

                        }



                        if (Material_Positions_Coffee[4].childCount == 1 && Material_Positions_Coffee[5].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_3 = 0;
                        }
                    }

                    if (count_3 == 2)
                    {

                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject6 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[4].childCount == 0 && Material_Positions_Coffee[5].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[4], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            instantiatedObject6.transform.SetParent(Material_Positions_Coffee[5], false);
                            instantiatedObject6.transform.localPosition = Vector3.zero;
                            instantiatedObject6.transform.localRotation = Quaternion.identity;
                            instantiatedObject6.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[6].gravityScale = 1.0f;
                            Positions_Coffee[4].enabled = true;

                            Material_rigid_Pink3[7].gravityScale = 1.0f;
                            Positions_Coffee[5].enabled = true;

                            Destroy(instantiatedObject5);
                            Destroy(instantiatedObject6);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[4].childCount == 0 && Material_Positions_Coffee[5].childCount == 1)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[4], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[6].gravityScale = 1.0f;
                            Positions_Coffee[4].enabled = true;

                            Destroy(instantiatedObject5);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[4].childCount == 1 && Material_Positions_Coffee[5].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[5], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[7].gravityScale = 1.0f;
                            Positions_Coffee[5].enabled = true;

                            Destroy(instantiatedObject5);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[4].childCount == 1 && Material_Positions_Coffee[5].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_3 = 0;
                        }


                    }
                    else if (count_3 > 2)
                    {
                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject6 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[4].childCount == 0 && Material_Positions_Coffee[5].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[4], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            instantiatedObject6.transform.SetParent(Material_Positions_Coffee[5], false);
                            instantiatedObject6.transform.localPosition = Vector3.zero;
                            instantiatedObject6.transform.localRotation = Quaternion.identity;
                            instantiatedObject6.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[6].gravityScale = 1.0f;
                            Positions_Coffee[4].enabled = true;

                            Material_rigid_Pink3[7].gravityScale = 1.0f;
                            Positions_Coffee[5].enabled = true;

                            Destroy(instantiatedObject5);
                            Destroy(instantiatedObject6);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[4].childCount == 0 && Material_Positions_Coffee[5].childCount == 1)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[4], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[6].gravityScale = 1.0f;
                            Positions_Coffee[4].enabled = true;

                            Destroy(instantiatedObject5);



                            count_3 = 0;
                        }


                        if (Material_Positions_Coffee[4].childCount == 1 && Material_Positions_Coffee[5].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[5], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[7].gravityScale = 1.0f;
                            Positions_Coffee[5].enabled = true;

                            Destroy(instantiatedObject5);



                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[4].childCount == 1 && Material_Positions_Coffee[5].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_3 = 0;
                        }


                    }
                }

                //����
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_4++;

                    if (count_4 == 1)
                    {
                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[4].childCount == 0 && Material_Positions_Milk[5].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[4], false);

                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[8].gravityScale = 1.0f;
                            Positions_Milk[4].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[4].childCount == 1 && Material_Positions_Milk[5].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_4 = 0;

                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[5], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[9].gravityScale = 1.0f;
                            Positions_Milk[5].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[4].childCount == 0 && Material_Positions_Milk[5].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[4], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[8].gravityScale = 1.0f;
                            Positions_Milk[4].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_4 = 0;

                        }



                        if (Material_Positions_Milk[4].childCount == 1 && Material_Positions_Milk[5].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_4 = 0;
                        }
                    }

                    if (count_4 == 2)
                    {

                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject8 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[4].childCount == 0 && Material_Positions_Milk[5].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[4], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            instantiatedObject8.transform.SetParent(Material_Positions_Milk[5], false);
                            instantiatedObject8.transform.localPosition = Vector3.zero;
                            //instantiatedObject8.transform.localRotation = Quaternion.identity;
                            instantiatedObject8.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject8.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[8].gravityScale = 1.0f;
                            Positions_Milk[4].enabled = true;

                            Material_rigid_Pink3[9].gravityScale = 1.0f;
                            Positions_Milk[5].enabled = true;

                            Destroy(instantiatedObject7);
                            Destroy(instantiatedObject8);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[4].childCount == 0 && Material_Positions_Milk[5].childCount == 1)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[4], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[8].gravityScale = 1.0f;
                            Positions_Milk[4].enabled = true;

                            Destroy(instantiatedObject7);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[4].childCount == 1 && Material_Positions_Milk[5].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[5], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            // instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[9].gravityScale = 1.0f;
                            Positions_Milk[5].enabled = true;

                            Destroy(instantiatedObject7);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[4].childCount == 1 && Material_Positions_Milk[5].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_4 = 0;
                        }


                    }
                    else if (count_4 > 2)
                    {
                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject8 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[4].childCount == 0 && Material_Positions_Milk[5].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[4], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            instantiatedObject8.transform.SetParent(Material_Positions_Milk[5], false);
                            instantiatedObject8.transform.localPosition = Vector3.zero;
                            //instantiatedObject8.transform.localRotation = Quaternion.identity;
                            instantiatedObject8.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject8.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[8].gravityScale = 1.0f;
                            Positions_Milk[4].enabled = true;

                            Material_rigid_Pink3[9].gravityScale = 1.0f;
                            Positions_Milk[5].enabled = true;

                            Destroy(instantiatedObject7);
                            Destroy(instantiatedObject8);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[4].childCount == 0 && Material_Positions_Milk[5].childCount == 1)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[4], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            // instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[8].gravityScale = 1.0f;
                            Positions_Milk[4].enabled = true;

                            Destroy(instantiatedObject7);



                            count_4 = 0;
                        }


                        if (Material_Positions_Milk[4].childCount == 1 && Material_Positions_Milk[5].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[5], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[9].gravityScale = 1.0f;
                            Positions_Milk[5].enabled = true;

                            Destroy(instantiatedObject7);



                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[4].childCount == 1 && Material_Positions_Milk[5].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_4 = 0;
                        }


                    }
                }


                //��
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "��(���ý�)(Clone)")
                {
                    count_5++;

                    if (count_5 == 1)
                    {
                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[4].childCount == 0 && Material_Positions_Water[5].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[4], false);

                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[10].gravityScale = 1.0f;
                            Positions_Water[4].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[4].childCount == 1 && Material_Positions_Water[5].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_5 = 0;

                            instantiatedObject9.transform.SetParent(Material_Positions_Water[5], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            // instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[11].gravityScale = 1.0f;
                            Positions_Water[5].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[4].childCount == 0 && Material_Positions_Water[5].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject9.transform.SetParent(Material_Positions_Water[4], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[10].gravityScale = 1.0f;
                            Positions_Water[4].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_5 = 0;

                        }



                        if (Material_Positions_Water[4].childCount == 1 && Material_Positions_Water[5].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_5 = 0;
                        }
                    }

                    if (count_5 == 2)
                    {

                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject10 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[4].childCount == 0 && Material_Positions_Water[5].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[4], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            instantiatedObject10.transform.SetParent(Material_Positions_Water[5], false);
                            instantiatedObject10.transform.localPosition = Vector3.zero;
                            //instantiatedObject10.transform.localRotation = Quaternion.identity;
                            instantiatedObject10.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject10.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[10].gravityScale = 1.0f;
                            Positions_Water[4].enabled = true;

                            Material_rigid_Pink3[11].gravityScale = 1.0f;
                            Positions_Water[5].enabled = true;

                            Destroy(instantiatedObject9);
                            Destroy(instantiatedObject10);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[4].childCount == 0 && Material_Positions_Water[5].childCount == 1)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[4], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[10].gravityScale = 1.0f;
                            Positions_Water[4].enabled = true;

                            Destroy(instantiatedObject9);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[4].childCount == 1 && Material_Positions_Water[5].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[5], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[11].gravityScale = 1.0f;
                            Positions_Water[5].enabled = true;

                            Destroy(instantiatedObject9);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_5 = 0;
                        }

                        if (Material_Positions_Water[4].childCount == 1 && Material_Positions_Water[5].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_5 = 0;
                        }


                    }
                    else if (count_5 > 2)
                    {
                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject10 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[4].childCount == 0 && Material_Positions_Water[5].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[4], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            instantiatedObject10.transform.SetParent(Material_Positions_Water[5], false);
                            instantiatedObject10.transform.localPosition = Vector3.zero;
                            //instantiatedObject10.transform.localRotation = Quaternion.identity;
                            instantiatedObject10.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject10.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[10].gravityScale = 1.0f;
                            Positions_Water[4].enabled = true;

                            Material_rigid_Pink3[11].gravityScale = 1.0f;
                            Positions_Water[5].enabled = true;

                            Destroy(instantiatedObject9);
                            Destroy(instantiatedObject10);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[4].childCount == 0 && Material_Positions_Water[5].childCount == 1)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[4], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[10].gravityScale = 1.0f;
                            Positions_Water[4].enabled = true;

                            Destroy(instantiatedObject9);



                            count_5 = 0;
                        }


                        if (Material_Positions_Water[4].childCount == 1 && Material_Positions_Water[5].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[5], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[11].gravityScale = 1.0f;
                            Positions_Water[5].enabled = true;

                            Destroy(instantiatedObject9);



                            count_5 = 0;
                        }

                        if (Material_Positions_Water[4].childCount == 1 && Material_Positions_Water[5].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_5 = 0;
                        }


                    }
                }

                //����
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_6++;

                    if (count_6 == 1)
                    {
                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[4].childCount == 0 && Material_Positions_Tea[5].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[4], false);

                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;

                            instantiatedObject11.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[12].gravityScale = 1.0f;
                            Positions_Tea[4].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[4].childCount == 1 && Material_Positions_Tea[5].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_6 = 0;

                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[5], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[13].gravityScale = 1.0f;
                            Positions_Tea[5].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[4].childCount == 0 && Material_Positions_Tea[5].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[4], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[12].gravityScale = 1.0f;
                            Positions_Tea[4].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_6 = 0;

                        }



                        if (Material_Positions_Tea[4].childCount == 1 && Material_Positions_Tea[5].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_6 = 0;
                        }
                    }

                    if (count_6 == 2)
                    {

                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject12 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[4].childCount == 0 && Material_Positions_Tea[5].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[4], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            instantiatedObject12.transform.SetParent(Material_Positions_Tea[5], false);
                            instantiatedObject12.transform.localPosition = Vector3.zero;
                            instantiatedObject12.transform.localRotation = Quaternion.identity;
                            instantiatedObject12.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[12].gravityScale = 1.0f;
                            Positions_Tea[4].enabled = true;

                            Material_rigid_Pink3[13].gravityScale = 1.0f;
                            Positions_Tea[5].enabled = true;

                            Destroy(instantiatedObject11);
                            Destroy(instantiatedObject12);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[4].childCount == 0 && Material_Positions_Tea[5].childCount == 1)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[4], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[12].gravityScale = 1.0f;
                            Positions_Tea[4].enabled = true;

                            Destroy(instantiatedObject11);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[4].childCount == 1 && Material_Positions_Tea[5].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[5], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[13].gravityScale = 1.0f;
                            Positions_Tea[5].enabled = true;

                            Destroy(instantiatedObject11);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[4].childCount == 1 && Material_Positions_Tea[5].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_6 = 0;
                        }


                    }
                    else if (count_6 > 2)
                    {
                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject12 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[4].childCount == 0 && Material_Positions_Tea[5].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[4], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            instantiatedObject12.transform.SetParent(Material_Positions_Tea[5], false);
                            instantiatedObject12.transform.localPosition = Vector3.zero;
                            instantiatedObject12.transform.localRotation = Quaternion.identity;
                            instantiatedObject12.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[12].gravityScale = 1.0f;
                            Positions_Tea[4].enabled = true;

                            Material_rigid_Pink3[13].gravityScale = 1.0f;
                            Positions_Tea[5].enabled = true;

                            Destroy(instantiatedObject11);
                            Destroy(instantiatedObject12);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[4].childCount == 0 && Material_Positions_Tea[5].childCount == 1)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[4], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[12].gravityScale = 1.0f;
                            Positions_Tea[4].enabled = true;

                            Destroy(instantiatedObject11);



                            count_6 = 0;
                        }


                        if (Material_Positions_Tea[4].childCount == 1 && Material_Positions_Tea[5].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[5], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[13].gravityScale = 1.0f;
                            Positions_Tea[5].enabled = true;

                            Destroy(instantiatedObject11);



                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[4].childCount == 1 && Material_Positions_Tea[5].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_6 = 0;
                        }


                    }
                }

                //���ݸ�
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "���ݸ�(���ý�)(Clone)")
                {
                    count_7++;

                    if (count_7 == 1)
                    {
                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[4].childCount == 0 && Material_Positions_Chocolate[5].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[4], false);

                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[14].gravityScale = 1.0f;
                            Positions_Chocolate[4].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[4].childCount == 1 && Material_Positions_Chocolate[5].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_7 = 0;

                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[5], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[15].gravityScale = 1.0f;
                            Positions_Chocolate[5].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[4].childCount == 0 && Material_Positions_Chocolate[5].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[4], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[14].gravityScale = 1.0f;
                            Positions_Chocolate[4].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_7 = 0;

                        }



                        if (Material_Positions_Chocolate[4].childCount == 1 && Material_Positions_Chocolate[5].childCount == 1)
                        {
                            //return;
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_7 = 0;
                        }
                    }

                    if (count_7 == 2)
                    {

                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject14 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[4].childCount == 0 && Material_Positions_Chocolate[5].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[4], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            instantiatedObject14.transform.SetParent(Material_Positions_Chocolate[5], false);
                            instantiatedObject14.transform.localPosition = Vector3.zero;
                            //instantiatedObject14.transform.localRotation = Quaternion.identity;
                            instantiatedObject14.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject14.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[14].gravityScale = 1.0f;
                            Positions_Chocolate[4].enabled = true;

                            Material_rigid_Pink3[15].gravityScale = 1.0f;
                            Positions_Chocolate[5].enabled = true;

                            Destroy(instantiatedObject13);
                            Destroy(instantiatedObject14);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[4].childCount == 0 && Material_Positions_Chocolate[5].childCount == 1)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[4], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[14].gravityScale = 1.0f;
                            Positions_Chocolate[4].enabled = true;

                            Destroy(instantiatedObject13);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[4].childCount == 1 && Material_Positions_Chocolate[5].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[5], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[15].gravityScale = 1.0f;
                            Positions_Chocolate[5].enabled = true;

                            Destroy(instantiatedObject13);
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[4].childCount == 1 && Material_Positions_Chocolate[5].childCount == 1)
                        {
                            move_material.selection_Pink_24[i].SetActive(false);
                            count_7 = 0;
                        }


                    }
                    else if (count_7 > 2)
                    {
                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject14 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[4].childCount == 0 && Material_Positions_Chocolate[5].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[4], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            instantiatedObject14.transform.SetParent(Material_Positions_Chocolate[5], false);
                            instantiatedObject14.transform.localPosition = Vector3.zero;
                            //instantiatedObject14.transform.localRotation = Quaternion.identity;
                            instantiatedObject14.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject14.transform.localScale = Vector3.one;

                            Material_rigid_Pink3[14].gravityScale = 1.0f;
                            Positions_Chocolate[4].enabled = true;

                            Material_rigid_Pink3[15].gravityScale = 1.0f;
                            Positions_Chocolate[5].enabled = true;

                            Destroy(instantiatedObject13);
                            Destroy(instantiatedObject14);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[4].childCount == 0 && Material_Positions_Chocolate[5].childCount == 1)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[4], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;

                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);
                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[14].gravityScale = 1.0f;
                            Positions_Chocolate[4].enabled = true;

                            Destroy(instantiatedObject13);



                            count_7 = 0;
                        }


                        if (Material_Positions_Chocolate[4].childCount == 1 && Material_Positions_Chocolate[5].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[5], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid_Pink3[15].gravityScale = 1.0f;
                            Positions_Chocolate[5].enabled = true;

                            Destroy(instantiatedObject13);



                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[4].childCount == 1 && Material_Positions_Chocolate[5].childCount == 1)
                        {

                            move_material.selection_Pink_24[i].SetActive(false);
                            count_7 = 0;
                        }


                    }
                }
            }

        }


    }

    //�Ķ� ��1
    public void Go_Blue_Cup1_Test()
    {


        for (int i = 0; i < move_material.Blue_24.Length; i++)
        {
            if (move_material.selection_Blue_24[i].activeSelf && move_material.Blue_24[i].activeSelf && move_material.Blue_24[i].transform.childCount > 1)
            {
                move_material.selection_Blue_24[i].SetActive(false);

                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_0++;

                    if (count_0 == 1)
                    {
                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[6].childCount == 0 && Material_Positions_Ice[7].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[6], false);
                            //�θ� Material_Positions_Ice[0]�� �ش��ϴ� ��ġ�� ����. false�� ������� ���� ��ġ�� ����

                            instantiatedObject.transform.localPosition = Vector3.zero;
                            //instantiatedObject�� ���� ��ġ ����. ���� ��ǥ �������� 0, 0, 0��ġ�� ����

                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            //���� ȸ���� ����. ȸ�� �������� ����

                            instantiatedObject.transform.localScale = Vector3.one;
                            //���� �������� 1, 1, 1�� ����

                            Material_rigid_Blue1[0].gravityScale = 1.0f;
                            Positions_Ice[6].enabled = true;

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[6].childCount == 1 && Material_Positions_Ice[7].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_0 = 0;

                            instantiatedObject.transform.SetParent(Material_Positions_Ice[7], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[1].gravityScale = 1.0f;
                            Positions_Ice[7].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[6].childCount == 0 && Material_Positions_Ice[7].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject.transform.SetParent(Material_Positions_Ice[6], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[0].gravityScale = 1.0f;
                            Positions_Ice[6].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;

                        }



                        if (Material_Positions_Ice[6].childCount == 1 && Material_Positions_Ice[7].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_0 = 0;
                        }
                    }

                    if (count_0 == 2)
                    {

                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject1 = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[6].childCount == 0 && Material_Positions_Ice[7].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[6], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            instantiatedObject1.transform.SetParent(Material_Positions_Ice[7], false);
                            instantiatedObject1.transform.localPosition = Vector3.zero;
                            instantiatedObject1.transform.localRotation = Quaternion.identity;
                            instantiatedObject1.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[0].gravityScale = 1.0f;
                            Positions_Ice[6].enabled = true;

                            Material_rigid_Blue1[1].gravityScale = 1.0f;
                            Positions_Ice[7].enabled = true;

                            Destroy(instantiatedObject);
                            Destroy(instantiatedObject1);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[6].childCount == 0 && Material_Positions_Ice[7].childCount == 1)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[6], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[0].gravityScale = 1.0f;
                            Positions_Ice[6].enabled = true;

                            Destroy(instantiatedObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[6].childCount == 1 && Material_Positions_Ice[7].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[7], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[1].gravityScale = 1.0f;
                            Positions_Ice[7].enabled = true;

                            Destroy(instantiatedObject);

                            count_0 = 0;

                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[6].childCount == 1 && Material_Positions_Ice[7].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_0 = 0;
                        }


                    }
                    else if (count_0 > 2)
                    {
                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject1 = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[6].childCount == 0 && Material_Positions_Ice[7].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[6], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            instantiatedObject1.transform.SetParent(Material_Positions_Ice[7], false);
                            instantiatedObject1.transform.localPosition = Vector3.zero;
                            instantiatedObject1.transform.localRotation = Quaternion.identity;
                            instantiatedObject1.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[0].gravityScale = 1.0f;
                            Positions_Ice[6].enabled = true;

                            Material_rigid_Blue1[1].gravityScale = 1.0f;
                            Positions_Ice[7].enabled = true;

                            Destroy(instantiatedObject);
                            Destroy(instantiatedObject1);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[6].childCount == 0 && Material_Positions_Ice[7].childCount == 1)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[6], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[0].gravityScale = 1.0f;
                            Positions_Ice[6].enabled = true;

                            Destroy(instantiatedObject);



                            count_0 = 0;
                        }


                        if (Material_Positions_Ice[6].childCount == 1 && Material_Positions_Ice[7].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[7], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[1].gravityScale = 1.0f;
                            Positions_Ice[7].enabled = true;

                            Destroy(instantiatedObject);



                            count_0 = 0;

                            //return;
                            //move_material.selection_Pink_24[i].SetActive(false);
                            //count_0 = 0;
                        }

                        if (Material_Positions_Ice[6].childCount == 1 && Material_Positions_Ice[7].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_0 = 0;
                        }


                    }
                }

                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "ī���(���ý�)(Clone)")
                {
                    count_1++;

                    if (count_1 == 1)
                    {
                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[6].childCount == 0 && Material_Positions_Caramel[7].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[6], false);

                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;

                            instantiatedObject0.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[2].gravityScale = 1.0f;
                            Positions_Caramel[6].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[6].childCount == 1 && Material_Positions_Caramel[7].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_1 = 0;

                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[7], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[3].gravityScale = 1.0f;
                            Positions_Caramel[7].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[6].childCount == 0 && Material_Positions_Caramel[7].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[6], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[2].gravityScale = 1.0f;
                            Positions_Caramel[6].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_1 = 0;

                        }



                        if (Material_Positions_Caramel[6].childCount == 1 && Material_Positions_Caramel[7].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_1 = 0;
                        }
                    }

                    if (count_1 == 2)
                    {

                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject2 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[6].childCount == 0 && Material_Positions_Caramel[7].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[6], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            instantiatedObject2.transform.SetParent(Material_Positions_Caramel[7], false);
                            instantiatedObject2.transform.localPosition = Vector3.zero;
                            instantiatedObject2.transform.localRotation = Quaternion.identity;
                            instantiatedObject2.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[2].gravityScale = 1.0f;
                            Positions_Caramel[6].enabled = true;

                            Material_rigid_Blue1[3].gravityScale = 1.0f;
                            Positions_Caramel[7].enabled = true;

                            Destroy(instantiatedObject0);
                            Destroy(instantiatedObject2);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[6].childCount == 0 && Material_Positions_Caramel[7].childCount == 1)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[6], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[2].gravityScale = 1.0f;
                            Positions_Caramel[6].enabled = true;

                            Destroy(instantiatedObject0);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[6].childCount == 1 && Material_Positions_Caramel[7].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[7], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[3].gravityScale = 1.0f;
                            Positions_Caramel[7].enabled = true;

                            Destroy(instantiatedObject0);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[6].childCount == 1 && Material_Positions_Caramel[7].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_1 = 0;
                        }


                    }
                    else if (count_1 > 2)
                    {
                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject2 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[6].childCount == 0 && Material_Positions_Caramel[7].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[6], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            instantiatedObject2.transform.SetParent(Material_Positions_Caramel[7], false);
                            instantiatedObject2.transform.localPosition = Vector3.zero;
                            instantiatedObject2.transform.localRotation = Quaternion.identity;
                            instantiatedObject2.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[2].gravityScale = 1.0f;
                            Positions_Caramel[6].enabled = true;

                            Material_rigid_Blue1[3].gravityScale = 1.0f;
                            Positions_Caramel[7].enabled = true;

                            Destroy(instantiatedObject0);
                            Destroy(instantiatedObject2);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[6].childCount == 0 && Material_Positions_Caramel[7].childCount == 1)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[6], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[2].gravityScale = 1.0f;
                            Positions_Caramel[6].enabled = true;

                            Destroy(instantiatedObject0);



                            count_1 = 0;
                        }


                        if (Material_Positions_Caramel[6].childCount == 1 && Material_Positions_Caramel[7].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[7], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[3].gravityScale = 1.0f;
                            Positions_Caramel[7].enabled = true;

                            Destroy(instantiatedObject0);



                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[6].childCount == 1 && Material_Positions_Caramel[7].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_1 = 0;
                        }


                    }
                }


                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_2++;

                    if (count_2 == 1)
                    {
                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[6].childCount == 0 && Material_Positions_Steam[7].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[6], false);

                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[4].gravityScale = 1.0f;
                            Positions_Steam[6].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[6].childCount == 1 && Material_Positions_Steam[7].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_2 = 0;

                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[7], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[5].gravityScale = 1.0f;
                            Positions_Steam[7].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[6].childCount == 0 && Material_Positions_Steam[7].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[6], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[4].gravityScale = 1.0f;
                            Positions_Steam[6].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_2 = 0;

                        }



                        if (Material_Positions_Steam[6].childCount == 1 && Material_Positions_Steam[7].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_2 = 0;
                        }
                    }

                    if (count_2 == 2)
                    {

                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject4 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[6].childCount == 0 && Material_Positions_Steam[7].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[6], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            instantiatedObject4.transform.SetParent(Material_Positions_Steam[7], false);
                            instantiatedObject4.transform.localPosition = Vector3.zero;
                            //instantiatedObject4.transform.localRotation = Quaternion.identity;
                            instantiatedObject4.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject4.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[4].gravityScale = 1.0f;
                            Positions_Steam[6].enabled = true;

                            Material_rigid_Blue1[5].gravityScale = 1.0f;
                            Positions_Steam[7].enabled = true;

                            Destroy(instantiatedObject3);
                            Destroy(instantiatedObject4);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[6].childCount == 0 && Material_Positions_Steam[7].childCount == 1)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[6], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[4].gravityScale = 1.0f;
                            Positions_Steam[6].enabled = true;

                            Destroy(instantiatedObject3);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[6].childCount == 1 && Material_Positions_Steam[7].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[7], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[5].gravityScale = 1.0f;
                            Positions_Steam[7].enabled = true;

                            Destroy(instantiatedObject3);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[6].childCount == 1 && Material_Positions_Steam[7].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_2 = 0;
                        }


                    }
                    else if (count_2 > 2)
                    {
                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject4 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[6].childCount == 0 && Material_Positions_Steam[7].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[6], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            instantiatedObject4.transform.SetParent(Material_Positions_Steam[7], false);
                            instantiatedObject4.transform.localPosition = Vector3.zero;
                            //instantiatedObject4.transform.localRotation = Quaternion.identity;
                            instantiatedObject4.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject4.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[4].gravityScale = 1.0f;
                            Positions_Steam[6].enabled = true;

                            Material_rigid_Blue1[5].gravityScale = 1.0f;
                            Positions_Steam[7].enabled = true;

                            Destroy(instantiatedObject3);
                            Destroy(instantiatedObject4);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[6].childCount == 0 && Material_Positions_Steam[7].childCount == 1)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[6], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[4].gravityScale = 1.0f;
                            Positions_Steam[6].enabled = true;

                            Destroy(instantiatedObject3);



                            count_2 = 0;
                        }


                        if (Material_Positions_Steam[6].childCount == 1 && Material_Positions_Steam[7].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[7], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            // instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[5].gravityScale = 1.0f;
                            Positions_Steam[7].enabled = true;

                            Destroy(instantiatedObject3);



                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[6].childCount == 1 && Material_Positions_Steam[7].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_2 = 0;
                        }


                    }
                }



                //Ŀ��
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "Ŀ����(���ý�)(Clone)")
                {
                    count_3++;

                    if (count_3 == 1)
                    {
                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[6].childCount == 0 && Material_Positions_Coffee[7].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject5.transform.SetParent(Material_Positions_Steam[6], false);

                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;

                            instantiatedObject5.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[6].gravityScale = 1.0f;
                            Positions_Coffee[6].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[6].childCount == 1 && Material_Positions_Coffee[7].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_3 = 0;

                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[7], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[7].gravityScale = 1.0f;
                            Positions_Coffee[7].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[6].childCount == 0 && Material_Positions_Coffee[7].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[6], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[6].gravityScale = 1.0f;
                            Positions_Coffee[6].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_3 = 0;

                        }



                        if (Material_Positions_Coffee[6].childCount == 1 && Material_Positions_Coffee[7].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_3 = 0;
                        }
                    }

                    if (count_3 == 2)
                    {

                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject6 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[6].childCount == 0 && Material_Positions_Coffee[7].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[6], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            instantiatedObject6.transform.SetParent(Material_Positions_Coffee[7], false);
                            instantiatedObject6.transform.localPosition = Vector3.zero;
                            instantiatedObject6.transform.localRotation = Quaternion.identity;
                            instantiatedObject6.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[6].gravityScale = 1.0f;
                            Positions_Coffee[6].enabled = true;

                            Material_rigid_Blue1[7].gravityScale = 1.0f;
                            Positions_Coffee[7].enabled = true;

                            Destroy(instantiatedObject5);
                            Destroy(instantiatedObject6);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[6].childCount == 0 && Material_Positions_Coffee[7].childCount == 1)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[6], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[6].gravityScale = 1.0f;
                            Positions_Coffee[6].enabled = true;

                            Destroy(instantiatedObject5);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[6].childCount == 1 && Material_Positions_Coffee[7].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[7], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[7].gravityScale = 1.0f;
                            Positions_Coffee[7].enabled = true;

                            Destroy(instantiatedObject5);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[6].childCount == 1 && Material_Positions_Coffee[7].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_3 = 0;
                        }


                    }
                    else if (count_3 > 2)
                    {
                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject6 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[6].childCount == 0 && Material_Positions_Coffee[7].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[6], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            instantiatedObject6.transform.SetParent(Material_Positions_Coffee[7], false);
                            instantiatedObject6.transform.localPosition = Vector3.zero;
                            instantiatedObject6.transform.localRotation = Quaternion.identity;
                            instantiatedObject6.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[6].gravityScale = 1.0f;
                            Positions_Coffee[6].enabled = true;

                            Material_rigid_Blue1[7].gravityScale = 1.0f;
                            Positions_Coffee[7].enabled = true;

                            Destroy(instantiatedObject5);
                            Destroy(instantiatedObject6);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[6].childCount == 0 && Material_Positions_Coffee[7].childCount == 1)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[6], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[6].gravityScale = 1.0f;
                            Positions_Coffee[6].enabled = true;

                            Destroy(instantiatedObject5);



                            count_3 = 0;
                        }


                        if (Material_Positions_Coffee[6].childCount == 1 && Material_Positions_Coffee[7].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[7], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[7].gravityScale = 1.0f;
                            Positions_Coffee[7].enabled = true;

                            Destroy(instantiatedObject5);



                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[6].childCount == 1 && Material_Positions_Coffee[7].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_3 = 0;
                        }


                    }
                }

                //����
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_4++;

                    if (count_4 == 1)
                    {
                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[6].childCount == 0 && Material_Positions_Milk[7].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[6], false);

                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[8].gravityScale = 1.0f;
                            Positions_Milk[6].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[6].childCount == 1 && Material_Positions_Milk[7].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_4 = 0;

                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[7], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[9].gravityScale = 1.0f;
                            Positions_Milk[7].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[6].childCount == 0 && Material_Positions_Milk[7].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[6], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[8].gravityScale = 1.0f;
                            Positions_Milk[6].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_4 = 0;

                        }



                        if (Material_Positions_Milk[6].childCount == 1 && Material_Positions_Milk[7].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_4 = 0;
                        }
                    }

                    if (count_4 == 2)
                    {

                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject8 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[6].childCount == 0 && Material_Positions_Milk[7].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[6], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            instantiatedObject8.transform.SetParent(Material_Positions_Milk[7], false);
                            instantiatedObject8.transform.localPosition = Vector3.zero;
                            //instantiatedObject8.transform.localRotation = Quaternion.identity;
                            instantiatedObject8.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject8.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[8].gravityScale = 1.0f;
                            Positions_Milk[6].enabled = true;

                            Material_rigid_Blue1[9].gravityScale = 1.0f;
                            Positions_Milk[7].enabled = true;

                            Destroy(instantiatedObject7);
                            Destroy(instantiatedObject8);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[6].childCount == 0 && Material_Positions_Milk[7].childCount == 1)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[6], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            // instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[8].gravityScale = 1.0f;
                            Positions_Milk[6].enabled = true;

                            Destroy(instantiatedObject7);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[6].childCount == 1 && Material_Positions_Milk[7].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[7], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[9].gravityScale = 1.0f;
                            Positions_Milk[7].enabled = true;

                            Destroy(instantiatedObject7);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[6].childCount == 1 && Material_Positions_Milk[7].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_4 = 0;
                        }


                    }
                    else if (count_4 > 2)
                    {
                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject8 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[6].childCount == 0 && Material_Positions_Milk[7].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[6], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            instantiatedObject8.transform.SetParent(Material_Positions_Milk[7], false);
                            instantiatedObject8.transform.localPosition = Vector3.zero;
                            //instantiatedObject8.transform.localRotation = Quaternion.identity;
                            instantiatedObject8.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject8.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[8].gravityScale = 1.0f;
                            Positions_Milk[6].enabled = true;

                            Material_rigid_Blue1[9].gravityScale = 1.0f;
                            Positions_Milk[7].enabled = true;

                            Destroy(instantiatedObject7);
                            Destroy(instantiatedObject8);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[6].childCount == 0 && Material_Positions_Milk[7].childCount == 1)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[6], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[8].gravityScale = 1.0f;
                            Positions_Milk[6].enabled = true;

                            Destroy(instantiatedObject7);



                            count_4 = 0;
                        }


                        if (Material_Positions_Milk[6].childCount == 1 && Material_Positions_Milk[7].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[7], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[9].gravityScale = 1.0f;
                            Positions_Milk[7].enabled = true;

                            Destroy(instantiatedObject7);



                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[6].childCount == 1 && Material_Positions_Milk[7].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_4 = 0;
                        }


                    }
                }


                //��
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "��(���ý�)(Clone)")
                {
                    count_5++;

                    if (count_5 == 1)
                    {
                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[6].childCount == 0 && Material_Positions_Water[7].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[6], false);

                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[10].gravityScale = 1.0f;
                            Positions_Water[6].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[6].childCount == 1 && Material_Positions_Water[7].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_5 = 0;

                            instantiatedObject9.transform.SetParent(Material_Positions_Water[7], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[11].gravityScale = 1.0f;
                            Positions_Water[7].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[6].childCount == 0 && Material_Positions_Water[7].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject9.transform.SetParent(Material_Positions_Water[6], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[10].gravityScale = 1.0f;
                            Positions_Water[6].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_5 = 0;

                        }



                        if (Material_Positions_Water[6].childCount == 1 && Material_Positions_Water[7].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_5 = 0;
                        }
                    }

                    if (count_5 == 2)
                    {

                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject10 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[6].childCount == 0 && Material_Positions_Water[7].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[6], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            instantiatedObject10.transform.SetParent(Material_Positions_Water[7], false);
                            instantiatedObject10.transform.localPosition = Vector3.zero;
                            //instantiatedObject10.transform.localRotation = Quaternion.identity;
                            instantiatedObject10.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject10.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[10].gravityScale = 1.0f;
                            Positions_Water[6].enabled = true;

                            Material_rigid_Blue1[11].gravityScale = 1.0f;
                            Positions_Water[7].enabled = true;

                            Destroy(instantiatedObject9);
                            Destroy(instantiatedObject10);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[6].childCount == 0 && Material_Positions_Water[7].childCount == 1)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[6], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[10].gravityScale = 1.0f;
                            Positions_Water[6].enabled = true;

                            Destroy(instantiatedObject9);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[6].childCount == 1 && Material_Positions_Water[7].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[7], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[11].gravityScale = 1.0f;
                            Positions_Water[7].enabled = true;

                            Destroy(instantiatedObject9);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_5 = 0;
                        }

                        if (Material_Positions_Water[6].childCount == 1 && Material_Positions_Water[7].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_5 = 0;
                        }


                    }
                    else if (count_5 > 2)
                    {
                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject10 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[6].childCount == 0 && Material_Positions_Water[7].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[6], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            instantiatedObject10.transform.SetParent(Material_Positions_Water[7], false);
                            instantiatedObject10.transform.localPosition = Vector3.zero;
                            //instantiatedObject10.transform.localRotation = Quaternion.identity;
                            instantiatedObject10.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject10.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[10].gravityScale = 1.0f;
                            Positions_Water[6].enabled = true;

                            Material_rigid_Blue1[11].gravityScale = 1.0f;
                            Positions_Water[7].enabled = true;

                            Destroy(instantiatedObject9);
                            Destroy(instantiatedObject10);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[6].childCount == 0 && Material_Positions_Water[7].childCount == 1)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[6], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[10].gravityScale = 1.0f;
                            Positions_Water[6].enabled = true;

                            Destroy(instantiatedObject9);



                            count_5 = 0;
                        }


                        if (Material_Positions_Water[6].childCount == 1 && Material_Positions_Water[7].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[7], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[11].gravityScale = 1.0f;
                            Positions_Water[7].enabled = true;

                            Destroy(instantiatedObject9);



                            count_5 = 0;
                        }

                        if (Material_Positions_Water[6].childCount == 1 && Material_Positions_Water[7].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_5 = 0;
                        }


                    }
                }

                //����
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_6++;

                    if (count_6 == 1)
                    {
                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[6].childCount == 0 && Material_Positions_Tea[7].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[6], false);

                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;

                            instantiatedObject11.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[12].gravityScale = 1.0f;
                            Positions_Tea[6].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[6].childCount == 1 && Material_Positions_Tea[7].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_6 = 0;

                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[7], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[13].gravityScale = 1.0f;
                            Positions_Tea[7].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[6].childCount == 0 && Material_Positions_Tea[7].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[6], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[12].gravityScale = 1.0f;
                            Positions_Tea[6].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_6 = 0;

                        }



                        if (Material_Positions_Tea[6].childCount == 1 && Material_Positions_Tea[7].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_6 = 0;
                        }
                    }

                    if (count_6 == 2)
                    {

                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject12 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[6].childCount == 0 && Material_Positions_Tea[7].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[6], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            instantiatedObject12.transform.SetParent(Material_Positions_Tea[7], false);
                            instantiatedObject12.transform.localPosition = Vector3.zero;
                            instantiatedObject12.transform.localRotation = Quaternion.identity;
                            instantiatedObject12.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[12].gravityScale = 1.0f;
                            Positions_Tea[6].enabled = true;

                            Material_rigid_Blue1[13].gravityScale = 1.0f;
                            Positions_Tea[7].enabled = true;

                            Destroy(instantiatedObject11);
                            Destroy(instantiatedObject12);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[6].childCount == 0 && Material_Positions_Tea[7].childCount == 1)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[6], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[12].gravityScale = 1.0f;
                            Positions_Tea[6].enabled = true;

                            Destroy(instantiatedObject11);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[6].childCount == 1 && Material_Positions_Tea[7].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[7], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[13].gravityScale = 1.0f;
                            Positions_Tea[7].enabled = true;

                            Destroy(instantiatedObject11);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[6].childCount == 1 && Material_Positions_Tea[7].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_6 = 0;
                        }


                    }
                    else if (count_6 > 2)
                    {
                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject12 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[6].childCount == 0 && Material_Positions_Tea[7].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[6], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            instantiatedObject12.transform.SetParent(Material_Positions_Tea[7], false);
                            instantiatedObject12.transform.localPosition = Vector3.zero;
                            instantiatedObject12.transform.localRotation = Quaternion.identity;
                            instantiatedObject12.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[12].gravityScale = 1.0f;
                            Positions_Tea[6].enabled = true;

                            Material_rigid_Blue1[13].gravityScale = 1.0f;
                            Positions_Tea[7].enabled = true;

                            Destroy(instantiatedObject11);
                            Destroy(instantiatedObject12);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[6].childCount == 0 && Material_Positions_Tea[7].childCount == 1)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[6], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[12].gravityScale = 1.0f;
                            Positions_Tea[6].enabled = true;

                            Destroy(instantiatedObject11);



                            count_6 = 0;
                        }


                        if (Material_Positions_Tea[6].childCount == 1 && Material_Positions_Tea[7].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[7], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[13].gravityScale = 1.0f;
                            Positions_Tea[7].enabled = true;

                            Destroy(instantiatedObject11);



                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[6].childCount == 1 && Material_Positions_Tea[7].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_6 = 0;
                        }


                    }
                }

                //���ݸ�
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "���ݸ�(���ý�)(Clone)")
                {
                    count_7++;

                    if (count_7 == 1)
                    {
                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[6].childCount == 0 && Material_Positions_Chocolate[7].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[6], false);

                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);
                            instantiatedObject13.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[14].gravityScale = 1.0f;
                            Positions_Chocolate[6].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[6].childCount == 1 && Material_Positions_Chocolate[7].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_7 = 0;

                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[7], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[15].gravityScale = 1.0f;
                            Positions_Chocolate[7].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[6].childCount == 0 && Material_Positions_Chocolate[7].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[6], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[14].gravityScale = 1.0f;
                            Positions_Chocolate[6].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_7 = 0;

                        }



                        if (Material_Positions_Chocolate[6].childCount == 1 && Material_Positions_Chocolate[7].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_7 = 0;
                        }
                    }

                    if (count_7 == 2)
                    {

                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject14 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[6].childCount == 0 && Material_Positions_Chocolate[7].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[6], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            instantiatedObject14.transform.SetParent(Material_Positions_Chocolate[7], false);
                            instantiatedObject14.transform.localPosition = Vector3.zero;
                            //instantiatedObject14.transform.localRotation = Quaternion.identity;
                            instantiatedObject14.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject14.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[14].gravityScale = 1.0f;
                            Positions_Chocolate[6].enabled = true;

                            Material_rigid_Blue1[15].gravityScale = 1.0f;
                            Positions_Chocolate[7].enabled = true;

                            Destroy(instantiatedObject13);
                            Destroy(instantiatedObject14);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[6].childCount == 0 && Material_Positions_Chocolate[7].childCount == 1)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[6], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[14].gravityScale = 1.0f;
                            Positions_Chocolate[6].enabled = true;

                            Destroy(instantiatedObject13);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[6].childCount == 1 && Material_Positions_Chocolate[7].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[7], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            // instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[15].gravityScale = 1.0f;
                            Positions_Chocolate[7].enabled = true;

                            Destroy(instantiatedObject13);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[6].childCount == 1 && Material_Positions_Chocolate[7].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_7 = 0;
                        }


                    }
                    else if (count_7 > 2)
                    {
                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject14 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[6].childCount == 0 && Material_Positions_Chocolate[7].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[6], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            instantiatedObject14.transform.SetParent(Material_Positions_Chocolate[7], false);
                            instantiatedObject14.transform.localPosition = Vector3.zero;
                            // instantiatedObject14.transform.localRotation = Quaternion.identity;
                            instantiatedObject14.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject14.transform.localScale = Vector3.one;

                            Material_rigid_Blue1[14].gravityScale = 1.0f;
                            Positions_Chocolate[6].enabled = true;

                            Material_rigid_Blue1[15].gravityScale = 1.0f;
                            Positions_Chocolate[7].enabled = true;

                            Destroy(instantiatedObject13);
                            Destroy(instantiatedObject14);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[6].childCount == 0 && Material_Positions_Chocolate[7].childCount == 1)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[6], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[14].gravityScale = 1.0f;
                            Positions_Chocolate[6].enabled = true;

                            Destroy(instantiatedObject13);



                            count_7 = 0;
                        }


                        if (Material_Positions_Chocolate[6].childCount == 1 && Material_Positions_Chocolate[7].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[7], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid_Blue1[15].gravityScale = 1.0f;
                            Positions_Chocolate[7].enabled = true;

                            Destroy(instantiatedObject13);



                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[6].childCount == 1 && Material_Positions_Chocolate[7].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_7 = 0;
                        }


                    }
                }
            }

        }
    }



    //�Ķ� �� 2��
    public void Go_Blue_Cup2_Test()
    {


        for (int i = 0; i < move_material.Blue_24.Length; i++)
        {
            if (move_material.selection_Blue_24[i].activeSelf && move_material.Blue_24[i].activeSelf && move_material.Blue_24[i].transform.childCount > 1)
            {
                move_material.selection_Blue_24[i].SetActive(false);

                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_0++;

                    if (count_0 == 1)
                    {
                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[8].childCount == 0 && Material_Positions_Ice[9].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[8], false);
                            //�θ� Material_Positions_Ice[0]�� �ش��ϴ� ��ġ�� ����. false�� ������� ���� ��ġ�� ����

                            instantiatedObject.transform.localPosition = Vector3.zero;
                            //instantiatedObject�� ���� ��ġ ����. ���� ��ǥ �������� 0, 0, 0��ġ�� ����

                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            //���� ȸ���� ����. ȸ�� �������� ����

                            instantiatedObject.transform.localScale = Vector3.one;
                            //���� �������� 1, 1, 1�� ����

                            Material_rigid_Blue2[0].gravityScale = 1.0f;
                            Positions_Ice[8].enabled = true;

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[8].childCount == 1 && Material_Positions_Ice[9].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_0 = 0;

                            instantiatedObject.transform.SetParent(Material_Positions_Ice[9], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[1].gravityScale = 1.0f;
                            Positions_Ice[9].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[8].childCount == 0 && Material_Positions_Ice[9].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject.transform.SetParent(Material_Positions_Ice[8], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[0].gravityScale = 1.0f;
                            Positions_Ice[8].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;

                        }



                        if (Material_Positions_Ice[8].childCount == 1 && Material_Positions_Ice[9].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_0 = 0;
                        }
                    }

                    if (count_0 == 2)
                    {

                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject1 = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[8].childCount == 0 && Material_Positions_Ice[9].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[8], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            instantiatedObject1.transform.SetParent(Material_Positions_Ice[9], false);
                            instantiatedObject1.transform.localPosition = Vector3.zero;
                            instantiatedObject1.transform.localRotation = Quaternion.identity;
                            instantiatedObject1.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[0].gravityScale = 1.0f;
                            Positions_Ice[8].enabled = true;

                            Material_rigid_Blue2[1].gravityScale = 1.0f;
                            Positions_Ice[9].enabled = true;

                            Destroy(instantiatedObject);
                            Destroy(instantiatedObject1);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[8].childCount == 0 && Material_Positions_Ice[9].childCount == 1)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[8], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[0].gravityScale = 1.0f;
                            Positions_Ice[8].enabled = true;

                            Destroy(instantiatedObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[8].childCount == 1 && Material_Positions_Ice[9].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[9], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[1].gravityScale = 1.0f;
                            Positions_Ice[9].enabled = true;

                            Destroy(instantiatedObject);

                            count_0 = 0;

                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[8].childCount == 1 && Material_Positions_Ice[9].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_0 = 0;
                        }


                    }
                    else if (count_0 > 2)
                    {
                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject1 = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[8].childCount == 0 && Material_Positions_Ice[9].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[8], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            instantiatedObject1.transform.SetParent(Material_Positions_Ice[9], false);
                            instantiatedObject1.transform.localPosition = Vector3.zero;
                            instantiatedObject1.transform.localRotation = Quaternion.identity;
                            instantiatedObject1.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[0].gravityScale = 1.0f;
                            Positions_Ice[8].enabled = true;

                            Material_rigid_Blue2[1].gravityScale = 1.0f;
                            Positions_Ice[9].enabled = true;

                            Destroy(instantiatedObject);
                            Destroy(instantiatedObject1);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[8].childCount == 0 && Material_Positions_Ice[9].childCount == 1)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[8], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[0].gravityScale = 1.0f;
                            Positions_Ice[8].enabled = true;

                            Destroy(instantiatedObject);



                            count_0 = 0;
                        }


                        if (Material_Positions_Ice[8].childCount == 1 && Material_Positions_Ice[9].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[9], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[1].gravityScale = 1.0f;
                            Positions_Ice[9].enabled = true;

                            Destroy(instantiatedObject);



                            count_0 = 0;

                            //return;
                            //move_material.selection_Pink_24[i].SetActive(false);
                            //count_0 = 0;
                        }

                        if (Material_Positions_Ice[8].childCount == 1 && Material_Positions_Ice[9].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_0 = 0;
                        }


                    }
                }

                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "ī���(���ý�)(Clone)")
                {
                    count_1++;

                    if (count_1 == 1)
                    {
                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[8].childCount == 0 && Material_Positions_Caramel[9].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[8], false);

                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;

                            instantiatedObject0.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[2].gravityScale = 1.0f;
                            Positions_Caramel[8].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[8].childCount == 1 && Material_Positions_Caramel[9].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_1 = 0;

                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[9], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[3].gravityScale = 1.0f;
                            Positions_Caramel[9].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[8].childCount == 0 && Material_Positions_Caramel[9].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[8], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[2].gravityScale = 1.0f;
                            Positions_Caramel[8].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_1 = 0;

                        }



                        if (Material_Positions_Caramel[8].childCount == 1 && Material_Positions_Caramel[9].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_1 = 0;
                        }
                    }

                    if (count_1 == 2)
                    {

                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject2 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[8].childCount == 0 && Material_Positions_Caramel[9].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[8], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            instantiatedObject2.transform.SetParent(Material_Positions_Caramel[9], false);
                            instantiatedObject2.transform.localPosition = Vector3.zero;
                            instantiatedObject2.transform.localRotation = Quaternion.identity;
                            instantiatedObject2.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[2].gravityScale = 1.0f;
                            Positions_Caramel[8].enabled = true;

                            Material_rigid_Blue2[3].gravityScale = 1.0f;
                            Positions_Caramel[9].enabled = true;

                            Destroy(instantiatedObject0);
                            Destroy(instantiatedObject2);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[8].childCount == 0 && Material_Positions_Caramel[9].childCount == 1)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[8], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[2].gravityScale = 1.0f;
                            Positions_Caramel[8].enabled = true;

                            Destroy(instantiatedObject0);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[8].childCount == 1 && Material_Positions_Caramel[9].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[9], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[3].gravityScale = 1.0f;
                            Positions_Caramel[9].enabled = true;

                            Destroy(instantiatedObject0);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[8].childCount == 1 && Material_Positions_Caramel[9].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_1 = 0;
                        }


                    }
                    else if (count_1 > 2)
                    {
                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject2 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[8].childCount == 0 && Material_Positions_Caramel[9].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[8], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            instantiatedObject2.transform.SetParent(Material_Positions_Caramel[9], false);
                            instantiatedObject2.transform.localPosition = Vector3.zero;
                            instantiatedObject2.transform.localRotation = Quaternion.identity;
                            instantiatedObject2.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[2].gravityScale = 1.0f;
                            Positions_Caramel[8].enabled = true;

                            Material_rigid_Blue2[3].gravityScale = 1.0f;
                            Positions_Caramel[9].enabled = true;

                            Destroy(instantiatedObject0);
                            Destroy(instantiatedObject2);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[8].childCount == 0 && Material_Positions_Caramel[9].childCount == 1)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[8], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[2].gravityScale = 1.0f;
                            Positions_Caramel[8].enabled = true;

                            Destroy(instantiatedObject0);



                            count_1 = 0;
                        }


                        if (Material_Positions_Caramel[8].childCount == 1 && Material_Positions_Caramel[9].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[9], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[3].gravityScale = 1.0f;
                            Positions_Caramel[9].enabled = true;

                            Destroy(instantiatedObject0);



                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[8].childCount == 1 && Material_Positions_Caramel[9].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_1 = 0;
                        }


                    }
                }


                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_2++;

                    if (count_2 == 1)
                    {
                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[8].childCount == 0 && Material_Positions_Steam[9].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[8], false);

                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[4].gravityScale = 1.0f;
                            Positions_Steam[8].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[8].childCount == 1 && Material_Positions_Steam[9].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_2 = 0;

                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[9], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[5].gravityScale = 1.0f;
                            Positions_Steam[9].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[8].childCount == 0 && Material_Positions_Steam[9].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[8], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[4].gravityScale = 1.0f;
                            Positions_Steam[8].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_2 = 0;

                        }



                        if (Material_Positions_Steam[8].childCount == 1 && Material_Positions_Steam[9].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_2 = 0;
                        }
                    }

                    if (count_2 == 2)
                    {

                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject4 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[8].childCount == 0 && Material_Positions_Steam[9].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[8], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            instantiatedObject4.transform.SetParent(Material_Positions_Steam[9], false);
                            instantiatedObject4.transform.localPosition = Vector3.zero;
                            //instantiatedObject4.transform.localRotation = Quaternion.identity;
                            instantiatedObject4.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject4.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[4].gravityScale = 1.0f;
                            Positions_Steam[8].enabled = true;

                            Material_rigid_Blue2[5].gravityScale = 1.0f;
                            Positions_Steam[9].enabled = true;

                            Destroy(instantiatedObject3);
                            Destroy(instantiatedObject4);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[8].childCount == 0 && Material_Positions_Steam[9].childCount == 1)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[8], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[4].gravityScale = 1.0f;
                            Positions_Steam[8].enabled = true;

                            Destroy(instantiatedObject3);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[8].childCount == 1 && Material_Positions_Steam[9].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[9], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[5].gravityScale = 1.0f;
                            Positions_Steam[9].enabled = true;

                            Destroy(instantiatedObject3);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[8].childCount == 1 && Material_Positions_Steam[9].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_2 = 0;
                        }


                    }
                    else if (count_2 > 2)
                    {
                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject4 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[8].childCount == 0 && Material_Positions_Steam[9].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[8], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            instantiatedObject4.transform.SetParent(Material_Positions_Steam[9], false);
                            instantiatedObject4.transform.localPosition = Vector3.zero;
                            // instantiatedObject4.transform.localRotation = Quaternion.identity;
                            instantiatedObject4.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject4.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[4].gravityScale = 1.0f;
                            Positions_Steam[8].enabled = true;

                            Material_rigid_Blue2[5].gravityScale = 1.0f;
                            Positions_Steam[9].enabled = true;

                            Destroy(instantiatedObject3);
                            Destroy(instantiatedObject4);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[8].childCount == 0 && Material_Positions_Steam[9].childCount == 1)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[8], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[4].gravityScale = 1.0f;
                            Positions_Steam[8].enabled = true;

                            Destroy(instantiatedObject3);



                            count_2 = 0;
                        }


                        if (Material_Positions_Steam[8].childCount == 1 && Material_Positions_Steam[9].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[9], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[5].gravityScale = 1.0f;
                            Positions_Steam[9].enabled = true;

                            Destroy(instantiatedObject3);



                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[8].childCount == 1 && Material_Positions_Steam[9].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_2 = 0;
                        }


                    }
                }



                //Ŀ��
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "Ŀ����(���ý�)(Clone)")
                {
                    count_3++;

                    if (count_3 == 1)
                    {
                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[8].childCount == 0 && Material_Positions_Coffee[9].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject5.transform.SetParent(Material_Positions_Steam[8], false);

                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;

                            instantiatedObject5.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[6].gravityScale = 1.0f;
                            Positions_Coffee[8].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[8].childCount == 1 && Material_Positions_Coffee[9].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_3 = 0;

                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[9], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[7].gravityScale = 1.0f;
                            Positions_Coffee[9].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[8].childCount == 0 && Material_Positions_Coffee[9].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[8], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[6].gravityScale = 1.0f;
                            Positions_Coffee[8].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_3 = 0;

                        }



                        if (Material_Positions_Coffee[8].childCount == 1 && Material_Positions_Coffee[9].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_3 = 0;
                        }
                    }

                    if (count_3 == 2)
                    {

                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject6 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[8].childCount == 0 && Material_Positions_Coffee[9].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[8], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            instantiatedObject6.transform.SetParent(Material_Positions_Coffee[9], false);
                            instantiatedObject6.transform.localPosition = Vector3.zero;
                            instantiatedObject6.transform.localRotation = Quaternion.identity;
                            instantiatedObject6.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[6].gravityScale = 1.0f;
                            Positions_Coffee[8].enabled = true;

                            Material_rigid_Blue2[7].gravityScale = 1.0f;
                            Positions_Coffee[9].enabled = true;

                            Destroy(instantiatedObject5);
                            Destroy(instantiatedObject6);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[8].childCount == 0 && Material_Positions_Coffee[9].childCount == 1)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[8], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[6].gravityScale = 1.0f;
                            Positions_Coffee[8].enabled = true;

                            Destroy(instantiatedObject5);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[8].childCount == 1 && Material_Positions_Coffee[9].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[9], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[7].gravityScale = 1.0f;
                            Positions_Coffee[9].enabled = true;

                            Destroy(instantiatedObject5);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[8].childCount == 1 && Material_Positions_Coffee[9].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_3 = 0;
                        }


                    }
                    else if (count_3 > 2)
                    {
                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject6 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[8].childCount == 0 && Material_Positions_Coffee[9].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[8], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            instantiatedObject6.transform.SetParent(Material_Positions_Coffee[9], false);
                            instantiatedObject6.transform.localPosition = Vector3.zero;
                            instantiatedObject6.transform.localRotation = Quaternion.identity;
                            instantiatedObject6.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[6].gravityScale = 1.0f;
                            Positions_Coffee[8].enabled = true;

                            Material_rigid_Blue2[7].gravityScale = 1.0f;
                            Positions_Coffee[9].enabled = true;

                            Destroy(instantiatedObject5);
                            Destroy(instantiatedObject6);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[8].childCount == 0 && Material_Positions_Coffee[9].childCount == 1)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[8], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[6].gravityScale = 1.0f;
                            Positions_Coffee[8].enabled = true;

                            Destroy(instantiatedObject5);



                            count_3 = 0;
                        }


                        if (Material_Positions_Coffee[8].childCount == 1 && Material_Positions_Coffee[9].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[9], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[7].gravityScale = 1.0f;
                            Positions_Coffee[9].enabled = true;

                            Destroy(instantiatedObject5);



                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[8].childCount == 1 && Material_Positions_Coffee[9].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_3 = 0;
                        }


                    }
                }

                //����
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_4++;

                    if (count_4 == 1)
                    {
                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[8].childCount == 0 && Material_Positions_Milk[9].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[8], false);

                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[8].gravityScale = 1.0f;
                            Positions_Milk[8].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[8].childCount == 1 && Material_Positions_Milk[9].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_4 = 0;

                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[9], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[9].gravityScale = 1.0f;
                            Positions_Milk[9].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[8].childCount == 0 && Material_Positions_Milk[9].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[8], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[8].gravityScale = 1.0f;
                            Positions_Milk[8].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_4 = 0;

                        }



                        if (Material_Positions_Milk[8].childCount == 1 && Material_Positions_Milk[9].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_4 = 0;
                        }
                    }

                    if (count_4 == 2)
                    {

                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject8 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[8].childCount == 0 && Material_Positions_Milk[9].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[8], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            // instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            instantiatedObject8.transform.SetParent(Material_Positions_Milk[9], false);
                            instantiatedObject8.transform.localPosition = Vector3.zero;
                            //instantiatedObject8.transform.localRotation = Quaternion.identity;
                            instantiatedObject8.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject8.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[8].gravityScale = 1.0f;
                            Positions_Milk[8].enabled = true;

                            Material_rigid_Blue2[9].gravityScale = 1.0f;
                            Positions_Milk[9].enabled = true;

                            Destroy(instantiatedObject7);
                            Destroy(instantiatedObject8);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[8].childCount == 0 && Material_Positions_Milk[9].childCount == 1)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[8], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[8].gravityScale = 1.0f;
                            Positions_Milk[8].enabled = true;

                            Destroy(instantiatedObject7);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[8].childCount == 1 && Material_Positions_Milk[9].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[9], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[9].gravityScale = 1.0f;
                            Positions_Milk[9].enabled = true;

                            Destroy(instantiatedObject7);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[8].childCount == 1 && Material_Positions_Milk[9].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_4 = 0;
                        }


                    }
                    else if (count_4 > 2)
                    {
                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject8 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[8].childCount == 0 && Material_Positions_Milk[9].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[8], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            instantiatedObject8.transform.SetParent(Material_Positions_Milk[9], false);
                            instantiatedObject8.transform.localPosition = Vector3.zero;
                            //instantiatedObject8.transform.localRotation = Quaternion.identity;
                            instantiatedObject8.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject8.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[8].gravityScale = 1.0f;
                            Positions_Milk[8].enabled = true;

                            Material_rigid_Blue2[9].gravityScale = 1.0f;
                            Positions_Milk[9].enabled = true;

                            Destroy(instantiatedObject7);
                            Destroy(instantiatedObject8);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[8].childCount == 0 && Material_Positions_Milk[9].childCount == 1)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[8], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[8].gravityScale = 1.0f;
                            Positions_Milk[8].enabled = true;

                            Destroy(instantiatedObject7);



                            count_4 = 0;
                        }


                        if (Material_Positions_Milk[8].childCount == 1 && Material_Positions_Milk[9].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[9], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[9].gravityScale = 1.0f;
                            Positions_Milk[9].enabled = true;

                            Destroy(instantiatedObject7);



                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[8].childCount == 1 && Material_Positions_Milk[9].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_4 = 0;
                        }


                    }
                }


                //��
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "��(���ý�)(Clone)")
                {
                    count_5++;

                    if (count_5 == 1)
                    {
                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[8].childCount == 0 && Material_Positions_Water[9].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[8], false);

                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[10].gravityScale = 1.0f;
                            Positions_Water[8].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[8].childCount == 1 && Material_Positions_Water[9].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_5 = 0;

                            instantiatedObject9.transform.SetParent(Material_Positions_Water[9], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            // instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[11].gravityScale = 1.0f;
                            Positions_Water[9].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[8].childCount == 0 && Material_Positions_Water[9].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject9.transform.SetParent(Material_Positions_Water[8], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[10].gravityScale = 1.0f;
                            Positions_Water[8].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_5 = 0;

                        }



                        if (Material_Positions_Water[8].childCount == 1 && Material_Positions_Water[9].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_5 = 0;
                        }
                    }

                    if (count_5 == 2)
                    {

                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject10 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[8].childCount == 0 && Material_Positions_Water[9].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[8], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            instantiatedObject10.transform.SetParent(Material_Positions_Water[9], false);
                            instantiatedObject10.transform.localPosition = Vector3.zero;
                            //instantiatedObject10.transform.localRotation = Quaternion.identity;
                            instantiatedObject10.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject10.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[10].gravityScale = 1.0f;
                            Positions_Water[8].enabled = true;

                            Material_rigid_Blue2[11].gravityScale = 1.0f;
                            Positions_Water[9].enabled = true;

                            Destroy(instantiatedObject9);
                            Destroy(instantiatedObject10);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[8].childCount == 0 && Material_Positions_Water[9].childCount == 1)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[8], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[10].gravityScale = 1.0f;
                            Positions_Water[8].enabled = true;

                            Destroy(instantiatedObject9);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[8].childCount == 1 && Material_Positions_Water[9].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[9], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[11].gravityScale = 1.0f;
                            Positions_Water[9].enabled = true;

                            Destroy(instantiatedObject9);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_5 = 0;
                        }

                        if (Material_Positions_Water[8].childCount == 1 && Material_Positions_Water[9].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_5 = 0;
                        }


                    }
                    else if (count_5 > 2)
                    {
                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject10 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[8].childCount == 0 && Material_Positions_Water[9].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[8], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            // instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            instantiatedObject10.transform.SetParent(Material_Positions_Water[9], false);
                            instantiatedObject10.transform.localPosition = Vector3.zero;
                            //instantiatedObject10.transform.localRotation = Quaternion.identity;
                            instantiatedObject10.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject10.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[10].gravityScale = 1.0f;
                            Positions_Water[8].enabled = true;

                            Material_rigid_Blue2[11].gravityScale = 1.0f;
                            Positions_Water[9].enabled = true;

                            Destroy(instantiatedObject9);
                            Destroy(instantiatedObject10);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[8].childCount == 0 && Material_Positions_Water[9].childCount == 1)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[8], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[10].gravityScale = 1.0f;
                            Positions_Water[8].enabled = true;

                            Destroy(instantiatedObject9);



                            count_5 = 0;
                        }


                        if (Material_Positions_Water[8].childCount == 1 && Material_Positions_Water[9].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[9], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[11].gravityScale = 1.0f;
                            Positions_Water[9].enabled = true;

                            Destroy(instantiatedObject9);



                            count_5 = 0;
                        }

                        if (Material_Positions_Water[8].childCount == 1 && Material_Positions_Water[9].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_5 = 0;
                        }


                    }
                }

                //����
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_6++;

                    if (count_6 == 1)
                    {
                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[8].childCount == 0 && Material_Positions_Tea[9].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[8], false);

                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;

                            instantiatedObject11.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[12].gravityScale = 1.0f;
                            Positions_Tea[8].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[8].childCount == 1 && Material_Positions_Tea[9].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_6 = 0;

                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[9], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[13].gravityScale = 1.0f;
                            Positions_Tea[9].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[8].childCount == 0 && Material_Positions_Tea[9].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[8], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[12].gravityScale = 1.0f;
                            Positions_Tea[8].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_6 = 0;

                        }



                        if (Material_Positions_Tea[8].childCount == 1 && Material_Positions_Tea[9].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_6 = 0;
                        }
                    }

                    if (count_6 == 2)
                    {

                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject12 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[8].childCount == 0 && Material_Positions_Tea[9].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[8], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            instantiatedObject12.transform.SetParent(Material_Positions_Tea[9], false);
                            instantiatedObject12.transform.localPosition = Vector3.zero;
                            instantiatedObject12.transform.localRotation = Quaternion.identity;
                            instantiatedObject12.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[12].gravityScale = 1.0f;
                            Positions_Tea[8].enabled = true;

                            Material_rigid_Blue2[13].gravityScale = 1.0f;
                            Positions_Tea[9].enabled = true;

                            Destroy(instantiatedObject11);
                            Destroy(instantiatedObject12);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[8].childCount == 0 && Material_Positions_Tea[9].childCount == 1)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[8], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[12].gravityScale = 1.0f;
                            Positions_Tea[8].enabled = true;

                            Destroy(instantiatedObject11);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[8].childCount == 1 && Material_Positions_Tea[9].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[9], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[13].gravityScale = 1.0f;
                            Positions_Tea[9].enabled = true;

                            Destroy(instantiatedObject11);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[8].childCount == 1 && Material_Positions_Tea[9].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_6 = 0;
                        }


                    }
                    else if (count_6 > 2)
                    {
                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject12 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[8].childCount == 0 && Material_Positions_Tea[9].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[8], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            instantiatedObject12.transform.SetParent(Material_Positions_Tea[9], false);
                            instantiatedObject12.transform.localPosition = Vector3.zero;
                            instantiatedObject12.transform.localRotation = Quaternion.identity;
                            instantiatedObject12.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[12].gravityScale = 1.0f;
                            Positions_Tea[8].enabled = true;

                            Material_rigid_Blue2[13].gravityScale = 1.0f;
                            Positions_Tea[9].enabled = true;

                            Destroy(instantiatedObject11);
                            Destroy(instantiatedObject12);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[8].childCount == 0 && Material_Positions_Tea[9].childCount == 1)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[8], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[12].gravityScale = 1.0f;
                            Positions_Tea[8].enabled = true;

                            Destroy(instantiatedObject11);



                            count_6 = 0;
                        }


                        if (Material_Positions_Tea[8].childCount == 1 && Material_Positions_Tea[9].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[9], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[13].gravityScale = 1.0f;
                            Positions_Tea[9].enabled = true;

                            Destroy(instantiatedObject11);



                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[8].childCount == 1 && Material_Positions_Tea[9].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_6 = 0;
                        }


                    }
                }

                //���ݸ�
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "���ݸ�(���ý�)(Clone)")
                {
                    count_7++;

                    if (count_7 == 1)
                    {
                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[8].childCount == 0 && Material_Positions_Chocolate[9].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[8], false);

                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[14].gravityScale = 1.0f;
                            Positions_Chocolate[8].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[8].childCount == 1 && Material_Positions_Chocolate[9].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_7 = 0;

                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[9], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[15].gravityScale = 1.0f;
                            Positions_Chocolate[9].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[8].childCount == 0 && Material_Positions_Chocolate[9].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[8], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[14].gravityScale = 1.0f;
                            Positions_Chocolate[8].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_7 = 0;

                        }



                        if (Material_Positions_Chocolate[8].childCount == 1 && Material_Positions_Chocolate[9].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_7 = 0;
                        }

                    }



                    if (count_7 == 2)
                    {

                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject14 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[8].childCount == 0 && Material_Positions_Chocolate[9].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[8], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            instantiatedObject14.transform.SetParent(Material_Positions_Chocolate[9], false);
                            instantiatedObject14.transform.localPosition = Vector3.zero;
                            //instantiatedObject14.transform.localRotation = Quaternion.identity;
                            instantiatedObject14.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject14.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[14].gravityScale = 1.0f;
                            Positions_Chocolate[8].enabled = true;

                            Material_rigid_Blue2[15].gravityScale = 1.0f;
                            Positions_Chocolate[9].enabled = true;

                            Destroy(instantiatedObject13);
                            Destroy(instantiatedObject14);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[8].childCount == 0 && Material_Positions_Chocolate[9].childCount == 1)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[8], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[14].gravityScale = 1.0f;
                            Positions_Chocolate[8].enabled = true;

                            Destroy(instantiatedObject13);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[8].childCount == 1 && Material_Positions_Chocolate[9].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[9], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            // instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[15].gravityScale = 1.0f;
                            Positions_Chocolate[9].enabled = true;

                            Destroy(instantiatedObject13);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[8].childCount == 1 && Material_Positions_Chocolate[9].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_7 = 0;
                        }


                    }
                    else if (count_7 > 2)
                    {
                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject14 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[8].childCount == 0 && Material_Positions_Chocolate[9].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[8], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            instantiatedObject14.transform.SetParent(Material_Positions_Chocolate[9], false);
                            instantiatedObject14.transform.localPosition = Vector3.zero;
                            // instantiatedObject14.transform.localRotation = Quaternion.identity;
                            instantiatedObject14.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject14.transform.localScale = Vector3.one;

                            Material_rigid_Blue2[14].gravityScale = 1.0f;
                            Positions_Chocolate[8].enabled = true;

                            Material_rigid_Blue2[15].gravityScale = 1.0f;
                            Positions_Chocolate[9].enabled = true;

                            Destroy(instantiatedObject13);
                            Destroy(instantiatedObject14);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[8].childCount == 0 && Material_Positions_Chocolate[9].childCount == 1)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[8], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[14].gravityScale = 1.0f;
                            Positions_Chocolate[8].enabled = true;

                            Destroy(instantiatedObject13);



                            count_7 = 0;
                        }


                        if (Material_Positions_Chocolate[8].childCount == 1 && Material_Positions_Chocolate[9].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[9], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid_Blue2[15].gravityScale = 1.0f;
                            Positions_Chocolate[9].enabled = true;

                            Destroy(instantiatedObject13);



                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[8].childCount == 1 && Material_Positions_Chocolate[9].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_7 = 0;
                        }


                    }
                }
            }
        }
    }

    //�Ķ��� 3��
    public void Go_Blue_Cup3_Test()
    {


        for (int i = 0; i < move_material.Blue_24.Length; i++)
        {
            if (move_material.selection_Blue_24[i].activeSelf && move_material.Blue_24[i].activeSelf && move_material.Blue_24[i].transform.childCount > 1)
            {
                move_material.selection_Blue_24[i].SetActive(false);

                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_0++;

                    if (count_0 == 1)
                    {
                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[10].childCount == 0 && Material_Positions_Ice[11].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[10], false);
                            //�θ� Material_Positions_Ice[0]�� �ش��ϴ� ��ġ�� ����. false�� ������� ���� ��ġ�� ����

                            instantiatedObject.transform.localPosition = Vector3.zero;
                            //instantiatedObject�� ���� ��ġ ����. ���� ��ǥ �������� 0, 0, 0��ġ�� ����

                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            //���� ȸ���� ����. ȸ�� �������� ����

                            instantiatedObject.transform.localScale = Vector3.one;
                            //���� �������� 1, 1, 1�� ����

                            Material_rigid_Blue3[0].gravityScale = 1.0f;
                            Positions_Ice[10].enabled = true;

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[10].childCount == 1 && Material_Positions_Ice[11].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_0 = 0;

                            instantiatedObject.transform.SetParent(Material_Positions_Ice[11], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[1].gravityScale = 1.0f;
                            Positions_Ice[11].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[10].childCount == 0 && Material_Positions_Ice[11].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject.transform.SetParent(Material_Positions_Ice[10], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[0].gravityScale = 1.0f;
                            Positions_Ice[10].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;

                        }



                        if (Material_Positions_Ice[10].childCount == 1 && Material_Positions_Ice[11].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_0 = 0;
                        }
                    }

                    if (count_0 == 2)
                    {

                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject1 = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[10].childCount == 0 && Material_Positions_Ice[11].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[10], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            instantiatedObject1.transform.SetParent(Material_Positions_Ice[11], false);
                            instantiatedObject1.transform.localPosition = Vector3.zero;
                            instantiatedObject1.transform.localRotation = Quaternion.identity;
                            instantiatedObject1.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[0].gravityScale = 1.0f;
                            Positions_Ice[10].enabled = true;

                            Material_rigid_Blue3[1].gravityScale = 1.0f;
                            Positions_Ice[11].enabled = true;

                            Destroy(instantiatedObject);
                            Destroy(instantiatedObject1);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[10].childCount == 0 && Material_Positions_Ice[11].childCount == 1)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[10], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[0].gravityScale = 1.0f;
                            Positions_Ice[10].enabled = true;

                            Destroy(instantiatedObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[810].childCount == 1 && Material_Positions_Ice[11].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[11], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[1].gravityScale = 1.0f;
                            Positions_Ice[11].enabled = true;

                            Destroy(instantiatedObject);

                            count_0 = 0;

                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[10].childCount == 1 && Material_Positions_Ice[11].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_0 = 0;
                        }


                    }
                    else if (count_0 > 2)
                    {
                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject1 = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[10].childCount == 0 && Material_Positions_Ice[11].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[10], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;

                            instantiatedObject1.transform.SetParent(Material_Positions_Ice[11], false);
                            instantiatedObject1.transform.localPosition = Vector3.zero;
                            instantiatedObject1.transform.localRotation = Quaternion.identity;
                            instantiatedObject1.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[0].gravityScale = 1.0f;
                            Positions_Ice[10].enabled = true;

                            Material_rigid_Blue3[1].gravityScale = 1.0f;
                            Positions_Ice[11].enabled = true;

                            Destroy(instantiatedObject);
                            Destroy(instantiatedObject1);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[10].childCount == 0 && Material_Positions_Ice[11].childCount == 1)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[10], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[0].gravityScale = 1.0f;
                            Positions_Ice[10].enabled = true;

                            Destroy(instantiatedObject);



                            count_0 = 0;
                        }


                        if (Material_Positions_Ice[10].childCount == 1 && Material_Positions_Ice[11].childCount == 0)
                        {
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[11], false);
                            instantiatedObject.transform.localPosition = Vector3.zero;
                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            instantiatedObject.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[1].gravityScale = 1.0f;
                            Positions_Ice[11].enabled = true;

                            Destroy(instantiatedObject);



                            count_0 = 0;

                            //return;
                            //move_material.selection_Pink_24[i].SetActive(false);
                            //count_0 = 0;
                        }

                        if (Material_Positions_Ice[10].childCount == 1 && Material_Positions_Ice[11].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_0 = 0;
                        }


                    }
                }

                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "ī���(���ý�)(Clone)")
                {
                    count_1++;

                    if (count_1 == 1)
                    {
                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[10].childCount == 0 && Material_Positions_Caramel[11].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[10], false);

                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;

                            instantiatedObject0.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[2].gravityScale = 1.0f;
                            Positions_Caramel[10].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[10].childCount == 1 && Material_Positions_Caramel[11].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_1 = 0;

                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[11], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[3].gravityScale = 1.0f;
                            Positions_Caramel[11].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[10].childCount == 0 && Material_Positions_Caramel[11].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[10], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[2].gravityScale = 1.0f;
                            Positions_Caramel[10].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_1 = 0;

                        }



                        if (Material_Positions_Caramel[10].childCount == 1 && Material_Positions_Caramel[11].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_1 = 0;
                        }
                    }

                    if (count_1 == 2)
                    {

                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject2 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[10].childCount == 0 && Material_Positions_Caramel[11].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[10], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            instantiatedObject2.transform.SetParent(Material_Positions_Caramel[11], false);
                            instantiatedObject2.transform.localPosition = Vector3.zero;
                            instantiatedObject2.transform.localRotation = Quaternion.identity;
                            instantiatedObject2.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[2].gravityScale = 1.0f;
                            Positions_Caramel[10].enabled = true;

                            Material_rigid_Blue3[3].gravityScale = 1.0f;
                            Positions_Caramel[11].enabled = true;

                            Destroy(instantiatedObject0);
                            Destroy(instantiatedObject2);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[10].childCount == 0 && Material_Positions_Caramel[11].childCount == 1)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[10], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[2].gravityScale = 1.0f;
                            Positions_Caramel[10].enabled = true;

                            Destroy(instantiatedObject0);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[10].childCount == 1 && Material_Positions_Caramel[11].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[11], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[3].gravityScale = 1.0f;
                            Positions_Caramel[11].enabled = true;

                            Destroy(instantiatedObject0);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[10].childCount == 1 && Material_Positions_Caramel[11].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_1 = 0;
                        }


                    }
                    else if (count_1 > 2)
                    {
                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject2 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[10].childCount == 0 && Material_Positions_Caramel[11].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[10], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;

                            instantiatedObject2.transform.SetParent(Material_Positions_Caramel[11], false);
                            instantiatedObject2.transform.localPosition = Vector3.zero;
                            instantiatedObject2.transform.localRotation = Quaternion.identity;
                            instantiatedObject2.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[2].gravityScale = 1.0f;
                            Positions_Caramel[10].enabled = true;

                            Material_rigid_Blue3[3].gravityScale = 1.0f;
                            Positions_Caramel[11].enabled = true;

                            Destroy(instantiatedObject0);
                            Destroy(instantiatedObject2);

                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[10].childCount == 0 && Material_Positions_Caramel[11].childCount == 1)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[10], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[2].gravityScale = 1.0f;
                            Positions_Caramel[10].enabled = true;

                            Destroy(instantiatedObject0);



                            count_1 = 0;
                        }


                        if (Material_Positions_Caramel[10].childCount == 1 && Material_Positions_Caramel[11].childCount == 0)
                        {
                            instantiatedObject0.transform.SetParent(Material_Positions_Caramel[11], false);
                            instantiatedObject0.transform.localPosition = Vector3.zero;
                            instantiatedObject0.transform.localRotation = Quaternion.identity;
                            instantiatedObject0.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[3].gravityScale = 1.0f;
                            Positions_Caramel[11].enabled = true;

                            Destroy(instantiatedObject0);



                            count_1 = 0;
                        }

                        if (Material_Positions_Caramel[10].childCount == 1 && Material_Positions_Caramel[11].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_1 = 0;
                        }


                    }
                }


                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_2++;

                    if (count_2 == 1)
                    {
                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[10].childCount == 0 && Material_Positions_Steam[11].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[10], false);

                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[4].gravityScale = 1.0f;
                            Positions_Steam[10].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[10].childCount == 1 && Material_Positions_Steam[11].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_2 = 0;

                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[11], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[5].gravityScale = 1.0f;
                            Positions_Steam[11].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[10].childCount == 0 && Material_Positions_Steam[11].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[10], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[4].gravityScale = 1.0f;
                            Positions_Steam[10].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_2 = 0;

                        }



                        if (Material_Positions_Steam[10].childCount == 1 && Material_Positions_Steam[11].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_2 = 0;
                        }
                    }

                    if (count_2 == 2)
                    {

                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject4 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[10].childCount == 0 && Material_Positions_Steam[11].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[10], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            instantiatedObject4.transform.SetParent(Material_Positions_Steam[11], false);
                            instantiatedObject4.transform.localPosition = Vector3.zero;
                            //instantiatedObject4.transform.localRotation = Quaternion.identity;
                            instantiatedObject4.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject4.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[4].gravityScale = 1.0f;
                            Positions_Steam[10].enabled = true;

                            Material_rigid_Blue3[5].gravityScale = 1.0f;
                            Positions_Steam[11].enabled = true;

                            Destroy(instantiatedObject3);
                            Destroy(instantiatedObject4);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[10].childCount == 0 && Material_Positions_Steam[11].childCount == 1)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[10], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[4].gravityScale = 1.0f;
                            Positions_Steam[10].enabled = true;

                            Destroy(instantiatedObject3);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[10].childCount == 1 && Material_Positions_Steam[11].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[11], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[5].gravityScale = 1.0f;
                            Positions_Steam[11].enabled = true;

                            Destroy(instantiatedObject3);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[10].childCount == 1 && Material_Positions_Steam[11].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_2 = 0;
                        }


                    }
                    else if (count_2 > 2)
                    {
                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject4 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[10].childCount == 0 && Material_Positions_Steam[11].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[10], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject3.transform.localScale = Vector3.one;

                            instantiatedObject4.transform.SetParent(Material_Positions_Steam[11], false);
                            instantiatedObject4.transform.localPosition = Vector3.zero;
                            //instantiatedObject4.transform.localRotation = Quaternion.identity;
                            instantiatedObject4.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);

                            instantiatedObject4.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[4].gravityScale = 1.0f;
                            Positions_Steam[10].enabled = true;

                            Material_rigid_Blue3[5].gravityScale = 1.0f;
                            Positions_Steam[11].enabled = true;

                            Destroy(instantiatedObject3);
                            Destroy(instantiatedObject4);

                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[10].childCount == 0 && Material_Positions_Steam[11].childCount == 1)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[10], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            // instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);
                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[4].gravityScale = 1.0f;
                            Positions_Steam[10].enabled = true;

                            Destroy(instantiatedObject3);



                            count_2 = 0;
                        }


                        if (Material_Positions_Steam[10].childCount == 1 && Material_Positions_Steam[11].childCount == 0)
                        {
                            instantiatedObject3.transform.SetParent(Material_Positions_Steam[11], false);
                            instantiatedObject3.transform.localPosition = Vector3.zero;
                            //instantiatedObject3.transform.localRotation = Quaternion.identity;
                            instantiatedObject3.transform.localRotation = Quaternion.Euler(0f, 0f, -30f);
                            instantiatedObject3.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[5].gravityScale = 1.0f;
                            Positions_Steam[11].enabled = true;

                            Destroy(instantiatedObject3);



                            count_2 = 0;
                        }

                        if (Material_Positions_Steam[10].childCount == 1 && Material_Positions_Steam[11].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_2 = 0;
                        }


                    }
                }



                //Ŀ��
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "Ŀ����(���ý�)(Clone)")
                {
                    count_3++;

                    if (count_3 == 1)
                    {
                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[10].childCount == 0 && Material_Positions_Coffee[11].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject5.transform.SetParent(Material_Positions_Steam[10], false);

                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;

                            instantiatedObject5.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[6].gravityScale = 1.0f;
                            Positions_Coffee[10].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[10].childCount == 1 && Material_Positions_Coffee[11].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_3 = 0;

                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[11], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[7].gravityScale = 1.0f;
                            Positions_Coffee[11].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[10].childCount == 0 && Material_Positions_Coffee[11].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[10], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[6].gravityScale = 1.0f;
                            Positions_Coffee[10].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_3 = 0;

                        }



                        if (Material_Positions_Coffee[10].childCount == 1 && Material_Positions_Coffee[11].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_3 = 0;
                        }
                    }

                    if (count_3 == 2)
                    {

                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject6 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[10].childCount == 0 && Material_Positions_Coffee[11].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[10], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            instantiatedObject6.transform.SetParent(Material_Positions_Coffee[11], false);
                            instantiatedObject6.transform.localPosition = Vector3.zero;
                            instantiatedObject6.transform.localRotation = Quaternion.identity;
                            instantiatedObject6.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[6].gravityScale = 1.0f;
                            Positions_Coffee[10].enabled = true;

                            Material_rigid_Blue3[7].gravityScale = 1.0f;
                            Positions_Coffee[11].enabled = true;

                            Destroy(instantiatedObject5);
                            Destroy(instantiatedObject6);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[10].childCount == 0 && Material_Positions_Coffee[11].childCount == 1)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[10], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[6].gravityScale = 1.0f;
                            Positions_Coffee[10].enabled = true;

                            Destroy(instantiatedObject5);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[10].childCount == 1 && Material_Positions_Coffee[11].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[11], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[7].gravityScale = 1.0f;
                            Positions_Coffee[11].enabled = true;

                            Destroy(instantiatedObject5);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[10].childCount == 1 && Material_Positions_Coffee[11].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_3 = 0;
                        }


                    }
                    else if (count_3 > 2)
                    {
                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject6 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[10].childCount == 0 && Material_Positions_Coffee[11].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[10], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;

                            instantiatedObject6.transform.SetParent(Material_Positions_Coffee[11], false);
                            instantiatedObject6.transform.localPosition = Vector3.zero;
                            instantiatedObject6.transform.localRotation = Quaternion.identity;
                            instantiatedObject6.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[6].gravityScale = 1.0f;
                            Positions_Coffee[10].enabled = true;

                            Material_rigid_Blue3[7].gravityScale = 1.0f;
                            Positions_Coffee[11].enabled = true;

                            Destroy(instantiatedObject5);
                            Destroy(instantiatedObject6);

                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[10].childCount == 0 && Material_Positions_Coffee[11].childCount == 1)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[10], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[6].gravityScale = 1.0f;
                            Positions_Coffee[10].enabled = true;

                            Destroy(instantiatedObject5);



                            count_3 = 0;
                        }


                        if (Material_Positions_Coffee[10].childCount == 1 && Material_Positions_Coffee[11].childCount == 0)
                        {
                            instantiatedObject5.transform.SetParent(Material_Positions_Coffee[11], false);
                            instantiatedObject5.transform.localPosition = Vector3.zero;
                            instantiatedObject5.transform.localRotation = Quaternion.identity;
                            instantiatedObject5.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[7].gravityScale = 1.0f;
                            Positions_Coffee[11].enabled = true;

                            Destroy(instantiatedObject5);



                            count_3 = 0;
                        }

                        if (Material_Positions_Coffee[10].childCount == 1 && Material_Positions_Coffee[11].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_3 = 0;
                        }


                    }
                }

                //����
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_4++;

                    if (count_4 == 1)
                    {
                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[10].childCount == 0 && Material_Positions_Milk[11].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[10], false);

                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[8].gravityScale = 1.0f;
                            Positions_Milk[10].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[10].childCount == 1 && Material_Positions_Milk[11].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_4 = 0;

                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[11], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[9].gravityScale = 1.0f;
                            Positions_Milk[11].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[10].childCount == 0 && Material_Positions_Milk[11].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[10], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[8].gravityScale = 1.0f;
                            Positions_Milk[10].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_4 = 0;

                        }



                        if (Material_Positions_Milk[10].childCount == 1 && Material_Positions_Milk[11].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_4 = 0;
                        }
                    }

                    if (count_4 == 2)
                    {

                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject8 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[10].childCount == 0 && Material_Positions_Milk[11].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[10], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            instantiatedObject8.transform.SetParent(Material_Positions_Milk[11], false);
                            instantiatedObject8.transform.localPosition = Vector3.zero;
                            //instantiatedObject8.transform.localRotation = Quaternion.identity;
                            instantiatedObject8.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject8.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[8].gravityScale = 1.0f;
                            Positions_Milk[10].enabled = true;

                            Material_rigid_Blue3[9].gravityScale = 1.0f;
                            Positions_Milk[11].enabled = true;

                            Destroy(instantiatedObject7);
                            Destroy(instantiatedObject8);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[10].childCount == 0 && Material_Positions_Milk[11].childCount == 1)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[10], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[8].gravityScale = 1.0f;
                            Positions_Milk[10].enabled = true;

                            Destroy(instantiatedObject7);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[10].childCount == 1 && Material_Positions_Milk[11].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[11], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[9].gravityScale = 1.0f;
                            Positions_Milk[11].enabled = true;

                            Destroy(instantiatedObject7);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[10].childCount == 1 && Material_Positions_Milk[11].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_4 = 0;
                        }


                    }
                    else if (count_4 > 2)
                    {
                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject8 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[10].childCount == 0 && Material_Positions_Milk[11].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[10], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;

                            instantiatedObject8.transform.SetParent(Material_Positions_Milk[11], false);
                            instantiatedObject8.transform.localPosition = Vector3.zero;
                            // instantiatedObject8.transform.localRotation = Quaternion.identity;
                            instantiatedObject8.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject8.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[8].gravityScale = 1.0f;
                            Positions_Milk[10].enabled = true;

                            Material_rigid_Blue3[9].gravityScale = 1.0f;
                            Positions_Milk[11].enabled = true;

                            Destroy(instantiatedObject7);
                            Destroy(instantiatedObject8);

                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[10].childCount == 0 && Material_Positions_Milk[11].childCount == 1)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[10], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[8].gravityScale = 1.0f;
                            Positions_Milk[10].enabled = true;

                            Destroy(instantiatedObject7);



                            count_4 = 0;
                        }


                        if (Material_Positions_Milk[10].childCount == 1 && Material_Positions_Milk[11].childCount == 0)
                        {
                            instantiatedObject7.transform.SetParent(Material_Positions_Milk[11], false);
                            instantiatedObject7.transform.localPosition = Vector3.zero;
                            //instantiatedObject7.transform.localRotation = Quaternion.identity;
                            instantiatedObject7.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject7.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[9].gravityScale = 1.0f;
                            Positions_Milk[11].enabled = true;

                            Destroy(instantiatedObject7);



                            count_4 = 0;
                        }

                        if (Material_Positions_Milk[10].childCount == 1 && Material_Positions_Milk[11].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_4 = 0;
                        }


                    }
                }


                //��
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "��(���ý�)(Clone)")
                {
                    count_5++;

                    if (count_5 == 1)
                    {
                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[10].childCount == 0 && Material_Positions_Water[11].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[10], false);

                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[10].gravityScale = 1.0f;
                            Positions_Water[10].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[10].childCount == 1 && Material_Positions_Water[11].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_5 = 0;

                            instantiatedObject9.transform.SetParent(Material_Positions_Water[11], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[11].gravityScale = 1.0f;
                            Positions_Water[11].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[10].childCount == 0 && Material_Positions_Water[11].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject9.transform.SetParent(Material_Positions_Water[10], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[10].gravityScale = 1.0f;
                            Positions_Water[10].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_5 = 0;

                        }



                        if (Material_Positions_Water[10].childCount == 1 && Material_Positions_Water[11].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_5 = 0;
                        }
                    }

                    if (count_5 == 2)
                    {

                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject10 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[10].childCount == 0 && Material_Positions_Water[11].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[10], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            instantiatedObject10.transform.SetParent(Material_Positions_Water[11], false);
                            instantiatedObject10.transform.localPosition = Vector3.zero;
                            //instantiatedObject10.transform.localRotation = Quaternion.identity;

                            instantiatedObject10.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);
                            instantiatedObject10.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[10].gravityScale = 1.0f;
                            Positions_Water[10].enabled = true;

                            Material_rigid_Blue3[11].gravityScale = 1.0f;
                            Positions_Water[11].enabled = true;

                            Destroy(instantiatedObject9);
                            Destroy(instantiatedObject10);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[10].childCount == 0 && Material_Positions_Water[11].childCount == 1)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[10], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            // instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[10].gravityScale = 1.0f;
                            Positions_Water[10].enabled = true;

                            Destroy(instantiatedObject9);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[10].childCount == 1 && Material_Positions_Water[11].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[11], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[11].gravityScale = 1.0f;
                            Positions_Water[11].enabled = true;

                            Destroy(instantiatedObject9);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_5 = 0;
                        }

                        if (Material_Positions_Water[10].childCount == 1 && Material_Positions_Water[11].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_5 = 0;
                        }


                    }
                    else if (count_5 > 2)
                    {
                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject10 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[10].childCount == 0 && Material_Positions_Water[11].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[10], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;

                            instantiatedObject10.transform.SetParent(Material_Positions_Water[11], false);
                            instantiatedObject10.transform.localPosition = Vector3.zero;
                            //instantiatedObject10.transform.localRotation = Quaternion.identity;
                            instantiatedObject10.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject10.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[10].gravityScale = 1.0f;
                            Positions_Water[10].enabled = true;

                            Material_rigid_Blue3[11].gravityScale = 1.0f;
                            Positions_Water[11].enabled = true;

                            Destroy(instantiatedObject9);
                            Destroy(instantiatedObject10);

                            count_5 = 0;
                        }

                        if (Material_Positions_Water[10].childCount == 0 && Material_Positions_Water[11].childCount == 1)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[10], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[10].gravityScale = 1.0f;
                            Positions_Water[10].enabled = true;

                            Destroy(instantiatedObject9);



                            count_5 = 0;
                        }


                        if (Material_Positions_Water[10].childCount == 1 && Material_Positions_Water[11].childCount == 0)
                        {
                            instantiatedObject9.transform.SetParent(Material_Positions_Water[11], false);
                            instantiatedObject9.transform.localPosition = Vector3.zero;
                            //instantiatedObject9.transform.localRotation = Quaternion.identity;
                            instantiatedObject9.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject9.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[11].gravityScale = 1.0f;
                            Positions_Water[11].enabled = true;

                            Destroy(instantiatedObject9);



                            count_5 = 0;
                        }

                        if (Material_Positions_Water[10].childCount == 1 && Material_Positions_Water[11].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_5 = 0;
                        }


                    }
                }

                //����
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "����(���ý�)(Clone)")
                {
                    count_6++;

                    if (count_6 == 1)
                    {
                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[10].childCount == 0 && Material_Positions_Tea[11].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[10], false);

                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;

                            instantiatedObject11.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[12].gravityScale = 1.0f;
                            Positions_Tea[10].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[10].childCount == 1 && Material_Positions_Tea[11].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_6 = 0;

                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[11], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[13].gravityScale = 1.0f;
                            Positions_Tea[11].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[10].childCount == 0 && Material_Positions_Tea[11].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[10], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[12].gravityScale = 1.0f;
                            Positions_Tea[10].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_6 = 0;

                        }



                        if (Material_Positions_Tea[10].childCount == 1 && Material_Positions_Tea[11].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_6 = 0;
                        }
                    }

                    if (count_6 == 2)
                    {

                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject12 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[10].childCount == 0 && Material_Positions_Tea[11].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[10], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            instantiatedObject12.transform.SetParent(Material_Positions_Tea[11], false);
                            instantiatedObject12.transform.localPosition = Vector3.zero;
                            instantiatedObject12.transform.localRotation = Quaternion.identity;
                            instantiatedObject12.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[12].gravityScale = 1.0f;
                            Positions_Tea[10].enabled = true;

                            Material_rigid_Blue3[13].gravityScale = 1.0f;
                            Positions_Tea[11].enabled = true;

                            Destroy(instantiatedObject11);
                            Destroy(instantiatedObject12);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[10].childCount == 0 && Material_Positions_Tea[11].childCount == 1)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[10], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[12].gravityScale = 1.0f;
                            Positions_Tea[10].enabled = true;

                            Destroy(instantiatedObject11);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[10].childCount == 1 && Material_Positions_Tea[11].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[11], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[13].gravityScale = 1.0f;
                            Positions_Tea[11].enabled = true;

                            Destroy(instantiatedObject11);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[10].childCount == 1 && Material_Positions_Tea[11].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_6 = 0;
                        }


                    }
                    else if (count_6 > 2)
                    {
                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject12 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[10].childCount == 0 && Material_Positions_Tea[11].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[10], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;

                            instantiatedObject12.transform.SetParent(Material_Positions_Tea[11], false);
                            instantiatedObject12.transform.localPosition = Vector3.zero;
                            instantiatedObject12.transform.localRotation = Quaternion.identity;
                            instantiatedObject12.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[12].gravityScale = 1.0f;
                            Positions_Tea[10].enabled = true;

                            Material_rigid_Blue3[13].gravityScale = 1.0f;
                            Positions_Tea[11].enabled = true;

                            Destroy(instantiatedObject11);
                            Destroy(instantiatedObject12);

                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[10].childCount == 0 && Material_Positions_Tea[11].childCount == 1)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[10], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[12].gravityScale = 1.0f;
                            Positions_Tea[10].enabled = true;

                            Destroy(instantiatedObject11);



                            count_6 = 0;
                        }


                        if (Material_Positions_Tea[10].childCount == 1 && Material_Positions_Tea[11].childCount == 0)
                        {
                            instantiatedObject11.transform.SetParent(Material_Positions_Tea[11], false);
                            instantiatedObject11.transform.localPosition = Vector3.zero;
                            instantiatedObject11.transform.localRotation = Quaternion.identity;
                            instantiatedObject11.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[13].gravityScale = 1.0f;
                            Positions_Tea[11].enabled = true;

                            Destroy(instantiatedObject11);



                            count_6 = 0;
                        }

                        if (Material_Positions_Tea[10].childCount == 1 && Material_Positions_Tea[11].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_6 = 0;
                        }


                    }
                }

                //���ݸ�
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "���ݸ�(���ý�)(Clone)")
                {
                    count_7++;

                    if (count_7 == 1)
                    {
                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[10].childCount == 0 && Material_Positions_Chocolate[11].childCount == 1)
                        {//�ڽ��� ����, �ڽ��� ������
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[10], false);

                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[14].gravityScale = 1.0f;
                            Positions_Chocolate[10].enabled = true;

                            //Destroy(instantiatedObject);

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[10].childCount == 1 && Material_Positions_Chocolate[11].childCount == 0)
                        {//�ڽ��� �ְ� 2��° ���� �ڽ��� ������

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_7 = 0;

                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[11], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[15].gravityScale = 1.0f;
                            Positions_Chocolate[11].enabled = true;


                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[10].childCount == 0 && Material_Positions_Chocolate[11].childCount == 0)
                        {//�ڽ��� ������

                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[10], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[14].gravityScale = 1.0f;
                            Positions_Chocolate[10].enabled = true;

                            //Destroy(instantiatedObject);
                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_7 = 0;

                        }



                        if (Material_Positions_Chocolate[10].childCount == 1 && Material_Positions_Chocolate[11].childCount == 1)
                        {
                            //return;
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_7 = 0;
                        }

                    }



                    if (count_7 == 2)
                    {

                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject14 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[10].childCount == 0 && Material_Positions_Chocolate[11].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[10], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            instantiatedObject14.transform.SetParent(Material_Positions_Chocolate[11], false);
                            instantiatedObject14.transform.localPosition = Vector3.zero;
                            // instantiatedObject14.transform.localRotation = Quaternion.identity;
                            instantiatedObject14.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject14.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[14].gravityScale = 1.0f;
                            Positions_Chocolate[10].enabled = true;

                            Material_rigid_Blue3[15].gravityScale = 1.0f;
                            Positions_Chocolate[11].enabled = true;

                            Destroy(instantiatedObject13);
                            Destroy(instantiatedObject14);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[10].childCount == 0 && Material_Positions_Chocolate[11].childCount == 1)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[10], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[14].gravityScale = 1.0f;
                            Positions_Chocolate[10].enabled = true;

                            Destroy(instantiatedObject13);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[10].childCount == 1 && Material_Positions_Chocolate[11].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[11], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[15].gravityScale = 1.0f;
                            Positions_Chocolate[11].enabled = true;

                            Destroy(instantiatedObject13);
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[10].childCount == 1 && Material_Positions_Chocolate[11].childCount == 1)
                        {
                            move_material.selection_Blue_24[i].SetActive(false);
                            count_7 = 0;
                        }


                    }
                    else if (count_7 > 2)
                    {
                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);
                        GameObject instantiatedObject14 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[10].childCount == 0 && Material_Positions_Chocolate[11].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[10], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;

                            instantiatedObject14.transform.SetParent(Material_Positions_Chocolate[11], false);
                            instantiatedObject14.transform.localPosition = Vector3.zero;
                            //instantiatedObject14.transform.localRotation = Quaternion.identity;
                            instantiatedObject14.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject14.transform.localScale = Vector3.one;

                            Material_rigid_Blue3[14].gravityScale = 1.0f;
                            Positions_Chocolate[10].enabled = true;

                            Material_rigid_Blue3[15].gravityScale = 1.0f;
                            Positions_Chocolate[11].enabled = true;

                            Destroy(instantiatedObject13);
                            Destroy(instantiatedObject14);

                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[10].childCount == 0 && Material_Positions_Chocolate[11].childCount == 1)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[10], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            // instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[14].gravityScale = 1.0f;
                            Positions_Chocolate[10].enabled = true;

                            Destroy(instantiatedObject13);



                            count_7 = 0;
                        }


                        if (Material_Positions_Chocolate[10].childCount == 1 && Material_Positions_Chocolate[11].childCount == 0)
                        {
                            instantiatedObject13.transform.SetParent(Material_Positions_Chocolate[11], false);
                            instantiatedObject13.transform.localPosition = Vector3.zero;
                            //instantiatedObject13.transform.localRotation = Quaternion.identity;
                            instantiatedObject13.transform.localRotation = Quaternion.Euler(0f, 0f, -20f);

                            instantiatedObject13.transform.localScale = Vector3.one;


                            Material_rigid_Blue3[15].gravityScale = 1.0f;
                            Positions_Chocolate[11].enabled = true;

                            Destroy(instantiatedObject13);



                            count_7 = 0;
                        }

                        if (Material_Positions_Chocolate[10].childCount == 1 && Material_Positions_Chocolate[11].childCount == 1)
                        {

                            move_material.selection_Blue_24[i].SetActive(false);
                            count_7 = 0;
                        }


                    }
                }
            }
        }
    }
}

       
    




