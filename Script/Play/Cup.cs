using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


public class Cup : MonoBehaviour
{

    public Blue_Pink blue_pink;


    public GameObject[] Cup_Material;//8개

    public RectTransform[] Material_Positions_Ice; // 가능한 위치들의 배열
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
    //public Transform Parent_Transform; // 새로운 부모로 설정할 Transform 컴포넌트
    //public Transform Parent_Transform_Pink2; // 새로운 부모로 설정할 Transform 컴포넌트
    //public Transform Parent_Transform_Pink3; // 새로운 부모로 설정할 Transform 컴포넌트

    public Rigidbody2D[] Material_rigid;

    public Rigidbody2D[] Material_rigid_Pink2;

    public Rigidbody2D[] Material_rigid_Pink3;

    public Rigidbody2D[] Material_rigid_Blue1;

    public Rigidbody2D[] Material_rigid_Blue2;

    public Rigidbody2D[] Material_rigid_Blue3;

    //만약 선택되어 있는 상태에서 컵 1번을 누르면 현재 선택된 오브젝트가 컵 내부로 들어가고
    //지금 true되어 있는 걸 false시킨다.

    public GameObject[] Pink_Inside;
    public GameObject[] Blue_Inside;

    //새로 추가
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
        //핑크 컵 내부 확인
        Pink_Inside[0].SetActive(false);
        Pink_Inside[1].SetActive(false);
        Pink_Inside[2].SetActive(false);

        //블루 컵 내부 확인
        Blue_Inside[0].SetActive(false);
        Blue_Inside[1].SetActive(false);
        Blue_Inside[2].SetActive(false);

        //Go_Back.SetActive(false);


        //콜라이더 다 false
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

        //2번째 핑크 잔
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

        //3번째 핑크 잔
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

        //첫 번째 블루 잔
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


        //두 번째 블루 잔
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

        //세 번째 블루 잔
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

        //Rigidbody2D의 gravityScale을 0으로 설정
        //중력에 영향을 받지 않도록 함

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

        //핑크 잔2
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

        //핑크 잔3
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


        //블루1
        //Rigidbody2D의 gravityScale을 0으로 설정
        //중력에 영향을 받지 않도록 함

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

        //블루 잔2
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

        //블루 잔3
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
                //빨갛게 선택되었고 흰색이 있으며 자식이 1개 초과 있다면(2개 이상)

                blue_pink.Pink_Cups1[0].SetActive(false);//흰
                blue_pink.Pink_Cups1[1].SetActive(false);//흰
                blue_pink.Pink_Cups1[2].SetActive(false);//흰

                blue_pink.Pink_Cups2[0].SetActive(true);//빨
                blue_pink.Pink_Cups2[1].SetActive(true);//빨
                blue_pink.Pink_Cups2[2].SetActive(true);//빨

                blue_pink.Blue_Cups1[0].SetActive(false);//흰
                blue_pink.Blue_Cups1[1].SetActive(false);//흰
                blue_pink.Blue_Cups1[2].SetActive(false);//흰

                blue_pink.Blue_Cups2[0].SetActive(false);//파
                blue_pink.Blue_Cups2[1].SetActive(false);//파
                blue_pink.Blue_Cups2[2].SetActive(false);//파
            }

            if (move_material.selection_Pink_24[i].activeSelf == false && move_material.Pink_24[i].activeSelf && move_material.Pink_24[i].transform.childCount < 1)
            {
                //빨갛게 선택되지 않았고 흰색이 있으며 자식이 1개 미만이다 (0개, 1개)

                blue_pink.Pink_Cups1[0].SetActive(true);//흰
                blue_pink.Pink_Cups1[1].SetActive(true);//흰
                blue_pink.Pink_Cups1[2].SetActive(true);//흰

                blue_pink.Pink_Cups2[0].SetActive(false);//빨
                blue_pink.Pink_Cups2[1].SetActive(false);//빨
                blue_pink.Pink_Cups2[2].SetActive(false);//빨

                blue_pink.Blue_Cups1[0].SetActive(false);//흰
                blue_pink.Blue_Cups1[1].SetActive(false);//흰
                blue_pink.Blue_Cups1[2].SetActive(false);//흰

                blue_pink.Blue_Cups2[0].SetActive(false);//파
                blue_pink.Blue_Cups2[1].SetActive(false);//파
                blue_pink.Blue_Cups2[2].SetActive(false);//파
            }
        }

        for (int i = 0; i < move_material.selection_Blue_24.Length; i++)
        {
            if (move_material.selection_Blue_24[i].activeSelf && move_material.Blue_24[i].activeSelf && move_material.Blue_24[i].transform.childCount > 1)
            {
                //파랗게 선택되었고 흰색이 있으며 자식이 1개 초과 있다면(2개 이상)

                blue_pink.Pink_Cups1[0].SetActive(false);//흰
                blue_pink.Pink_Cups1[1].SetActive(false);//흰
                blue_pink.Pink_Cups1[2].SetActive(false);//흰

                blue_pink.Pink_Cups2[0].SetActive(false);//빨
                blue_pink.Pink_Cups2[1].SetActive(false);//빨
                blue_pink.Pink_Cups2[2].SetActive(false);//빨

                blue_pink.Blue_Cups1[0].SetActive(false);//흰
                blue_pink.Blue_Cups1[1].SetActive(false);//흰
                blue_pink.Blue_Cups1[2].SetActive(false);//흰

                blue_pink.Blue_Cups2[0].SetActive(true);//파
                blue_pink.Blue_Cups2[1].SetActive(true);//파
                blue_pink.Blue_Cups2[2].SetActive(true);//파
            }

            if (move_material.selection_Blue_24[i].activeSelf == false && move_material.Blue_24[i].activeSelf && move_material.Blue_24[i].transform.childCount < 1)
            {
                //파랗게 선택되지 않았고 흰색이 있으며 자식이 1개 미만이다 (0개, 1개)

                blue_pink.Pink_Cups1[0].SetActive(false);//흰
                blue_pink.Pink_Cups1[1].SetActive(false);//흰
                blue_pink.Pink_Cups1[2].SetActive(false);//흰

                blue_pink.Pink_Cups2[0].SetActive(false);//빨
                blue_pink.Pink_Cups2[1].SetActive(false);//빨
                blue_pink.Pink_Cups2[2].SetActive(false);//빨

                blue_pink.Blue_Cups1[0].SetActive(true);//흰
                blue_pink.Blue_Cups1[1].SetActive(true);//흰
                blue_pink.Blue_Cups1[2].SetActive(true);//흰

                blue_pink.Blue_Cups2[0].SetActive(false);//파
                blue_pink.Blue_Cups2[1].SetActive(false);//파
                blue_pink.Blue_Cups2[2].SetActive(false);//파
            }
        }

    }

    public void Next_Cup_Pink_One()
    {
        //핑크 컵 내부 확인
        Pink_Inside[0].SetActive(true);
        Pink_Inside[1].SetActive(false);
        Pink_Inside[2].SetActive(false);

        //블루 컵 내부 확인
        Blue_Inside[0].SetActive(false);
        Blue_Inside[1].SetActive(false);
        Blue_Inside[2].SetActive(false);

        sfx.SFX_Button();

    }

    public void Next_Cup_Pink_Two()
    {
        //핑크 컵 내부 확인
        Pink_Inside[0].SetActive(false);
        Pink_Inside[1].SetActive(true);
        Pink_Inside[2].SetActive(false);

        //블루 컵 내부 확인
        Blue_Inside[0].SetActive(false);
        Blue_Inside[1].SetActive(false);
        Blue_Inside[2].SetActive(false);

        sfx.SFX_Button();
    }

    public void Next_Cup_Pink_Three()
    {
        //핑크 컵 내부 확인
        Pink_Inside[0].SetActive(false);
        Pink_Inside[1].SetActive(false);
        Pink_Inside[2].SetActive(true);

        //블루 컵 내부 확인
        Blue_Inside[0].SetActive(false);
        Blue_Inside[1].SetActive(false);
        Blue_Inside[2].SetActive(false);

        sfx.SFX_Button();
    }

    public void Next_Cup_Blue_One()
    {
        //핑크 컵 내부 확인
        Pink_Inside[0].SetActive(false);
        Pink_Inside[1].SetActive(false);
        Pink_Inside[2].SetActive(false);

        //블루 컵 내부 확인
        Blue_Inside[0].SetActive(true);
        Blue_Inside[1].SetActive(false);
        Blue_Inside[2].SetActive(false);

        sfx.SFX_Button();
    }

    public void Next_Cup_Blue_Two()
    {
        //핑크 컵 내부 확인
        Pink_Inside[0].SetActive(false);
        Pink_Inside[1].SetActive(false);
        Pink_Inside[2].SetActive(false);

        //블루 컵 내부 확인
        Blue_Inside[0].SetActive(false);
        Blue_Inside[1].SetActive(true);
        Blue_Inside[2].SetActive(false);

        sfx.SFX_Button();
    }

    public void Next_Cup_Blue_Three()
    {
        //핑크 컵 내부 확인
        Pink_Inside[0].SetActive(false);
        Pink_Inside[1].SetActive(false);
        Pink_Inside[2].SetActive(false);

        //블루 컵 내부 확인
        Blue_Inside[0].SetActive(false);
        Blue_Inside[1].SetActive(false);
        Blue_Inside[2].SetActive(true);

        sfx.SFX_Button();
    }


    public void Go_Pink_Inside_1()//핑크 첫번째 컵 내용물 확인
    {
        Pink_Inside[0].SetActive(true);
        Pink_Inside[1].SetActive(false);
        Pink_Inside[2].SetActive(false);

    }

    public void Go_Pink_Inside_2()//핑크 두번째 컵 내용물 확인
    {
        Pink_Inside[0].SetActive(false);
        Pink_Inside[1].SetActive(true);
        Pink_Inside[2].SetActive(false);

    }

    public void Go_Pink_Inside_3()//핑크 세번째 컵 내용물 확인
    {
        Pink_Inside[0].SetActive(false);
        Pink_Inside[1].SetActive(false);
        Pink_Inside[2].SetActive(true);
    }

    public void Go_Blue_Inside_1()//블루 첫번째 컵 내용물 확인
    {
        Blue_Inside[0].SetActive(true);
        Blue_Inside[1].SetActive(false);
        Blue_Inside[2].SetActive(false);

    }

    public void Go_Blue_Inside_2()//블루 두번째 컵 내용물 확인
    {
        Blue_Inside[0].SetActive(false);
        Blue_Inside[1].SetActive(true);
        Blue_Inside[2].SetActive(false);


    }

    public void Go_Blue_Inside_3()//블루 세번째 컵 내용물 확인
    {
        Blue_Inside[0].SetActive(false);
        Blue_Inside[1].SetActive(false);
        Blue_Inside[2].SetActive(true);

    }

    public void Go_Back_Game()//뒤로 가기 버튼
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
    //Menu에서 쓸거
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

    //이건 원래 있던 거
    public void G_Pink_Cup_Test()
    {


        for (int i = 0; i < move_material.Pink_24.Length; i++)
        {
            if (move_material.selection_Pink_24[i].activeSelf && move_material.Pink_24[i].activeSelf && move_material.Pink_24[i].transform.childCount > 1)
            {
                move_material.selection_Pink_24[i].SetActive(false);

                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "얼음(선택시)(Clone)")
                {
                    count_0++;

                    if (count_0 == 1)
                    {
                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[0].childCount == 0 && Material_Positions_Ice[1].childCount == 1)
                        {//자식이 없고, 자식이 있으면
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[0], false);
                            //부모를 Material_Positions_Ice[0]에 해당하는 위치로 설정. false는 상대적인 로컬 위치로 설정

                            instantiatedObject.transform.localPosition = Vector3.zero;
                            //instantiatedObject의 로컬 위치 지정. 로컬 좌표 기준으로 0, 0, 0위치를 설정

                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            //로컬 회전을 설정. 회전 없음으로 설정

                            instantiatedObject.transform.localScale = Vector3.one;
                            //로컬 스케일은 1, 1, 1로 설정

                            Material_rigid[0].gravityScale = 1.0f;
                            Positions_Ice[0].enabled = true;

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[0].childCount == 1 && Material_Positions_Ice[1].childCount == 0)
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "카라멜(선택시)(Clone)")
                {
                    count_1++;

                    if (count_1 == 1)
                    {
                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[0].childCount == 0 && Material_Positions_Caramel[1].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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


                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "증기(선택시)(Clone)")
                {
                    count_2++;

                    if (count_2 == 1)
                    {
                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[0].childCount == 0 && Material_Positions_Steam[1].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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



                //커피
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "커피콩(선택시)(Clone)")
                {
                    count_3++;

                    if (count_3 == 1)
                    {
                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[0].childCount == 0 && Material_Positions_Coffee[1].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                //우유
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "우유(선택시)(Clone)")
                {
                    count_4++;

                    if (count_4 == 1)
                    {
                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[0].childCount == 0 && Material_Positions_Milk[1].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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


                //물
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "물(선택시)(Clone)")
                {
                    count_5++;

                    if (count_5 == 1)
                    {
                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[0].childCount == 0 && Material_Positions_Water[1].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                //찻잎
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "찻잎(선택시)(Clone)")
                {
                    count_6++;

                    if (count_6 == 1)
                    {
                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[0].childCount == 0 && Material_Positions_Tea[1].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                //초콜릿
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "초콜릿(선택시)(Clone)")
                {
                    count_7++;

                    if (count_7 == 1)
                    {
                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[0].childCount == 0 && Material_Positions_Chocolate[1].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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


    //핑크 2번째 컵
    public void Go_Pink_Cup2_Test()
    {


        for (int i = 0; i < move_material.Pink_24.Length; i++)
        {
            if (move_material.selection_Pink_24[i].activeSelf && move_material.Pink_24[i].activeSelf && move_material.Pink_24[i].transform.childCount > 1)
            {
                move_material.selection_Pink_24[i].SetActive(false);

                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "얼음(선택시)(Clone)")
                {
                    count_0++;

                    if (count_0 == 1)
                    {
                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[2].childCount == 0 && Material_Positions_Ice[3].childCount == 1)
                        {//자식이 없고, 자식이 있으면
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[2], false);
                            //부모를 Material_Positions_Ice[0]에 해당하는 위치로 설정. false는 상대적인 로컬 위치로 설정

                            instantiatedObject.transform.localPosition = Vector3.zero;
                            //instantiatedObject의 로컬 위치 지정. 로컬 좌표 기준으로 0, 0, 0위치를 설정

                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            //로컬 회전을 설정. 회전 없음으로 설정

                            instantiatedObject.transform.localScale = Vector3.one;
                            //로컬 스케일은 1, 1, 1로 설정

                            Material_rigid_Pink2[0].gravityScale = 1.0f;
                            Positions_Ice[2].enabled = true;

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[2].childCount == 1 && Material_Positions_Ice[3].childCount == 0)
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "카라멜(선택시)(Clone)")
                {
                    count_1++;

                    if (count_1 == 1)
                    {
                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[2].childCount == 0 && Material_Positions_Caramel[3].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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


                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "증기(선택시)(Clone)")
                {
                    count_2++;

                    if (count_2 == 1)
                    {
                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[2].childCount == 0 && Material_Positions_Steam[3].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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



                //커피
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "커피콩(선택시)(Clone)")
                {
                    count_3++;

                    if (count_3 == 1)
                    {
                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[2].childCount == 0 && Material_Positions_Coffee[3].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                //우유
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "우유(선택시)(Clone)")
                {
                    count_4++;

                    if (count_4 == 1)
                    {
                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[2].childCount == 0 && Material_Positions_Milk[3].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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


                //물
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "물(선택시)(Clone)")
                {
                    count_5++;

                    if (count_5 == 1)
                    {
                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[2].childCount == 0 && Material_Positions_Water[3].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                //찻잎
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "찻잎(선택시)(Clone)")
                {
                    count_6++;

                    if (count_6 == 1)
                    {
                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[2].childCount == 0 && Material_Positions_Tea[3].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                //초콜릿
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "초콜릿(선택시)(Clone)")
                {
                    count_7++;

                    if (count_7 == 1)
                    {
                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[2].childCount == 0 && Material_Positions_Chocolate[3].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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


    //3번째 핑크 컵
    public void Go_Pink_Cup3_Test()
    {


        for (int i = 0; i < move_material.Pink_24.Length; i++)
        {
            if (move_material.selection_Pink_24[i].activeSelf && move_material.Pink_24[i].activeSelf && move_material.Pink_24[i].transform.childCount > 1)
            {
                move_material.selection_Pink_24[i].SetActive(false);

                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "얼음(선택시)(Clone)")
                {
                    count_0++;

                    if (count_0 == 1)
                    {
                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[4].childCount == 0 && Material_Positions_Ice[5].childCount == 1)
                        {//자식이 없고, 자식이 있으면
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[4], false);
                            //부모를 Material_Positions_Ice[0]에 해당하는 위치로 설정. false는 상대적인 로컬 위치로 설정

                            instantiatedObject.transform.localPosition = Vector3.zero;
                            //instantiatedObject의 로컬 위치 지정. 로컬 좌표 기준으로 0, 0, 0위치를 설정

                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            //로컬 회전을 설정. 회전 없음으로 설정

                            instantiatedObject.transform.localScale = Vector3.one;
                            //로컬 스케일은 1, 1, 1로 설정

                            Material_rigid_Pink3[0].gravityScale = 1.0f;
                            Positions_Ice[4].enabled = true;

                            Destroy(move_material.Pink_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[4].childCount == 1 && Material_Positions_Ice[5].childCount == 0)
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "카라멜(선택시)(Clone)")
                {
                    count_1++;

                    if (count_1 == 1)
                    {
                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[4].childCount == 0 && Material_Positions_Caramel[5].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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


                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "증기(선택시)(Clone)")
                {
                    count_2++;

                    if (count_2 == 1)
                    {
                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[4].childCount == 0 && Material_Positions_Steam[5].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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



                //커피
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "커피콩(선택시)(Clone)")
                {
                    count_3++;

                    if (count_3 == 1)
                    {
                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[4].childCount == 0 && Material_Positions_Coffee[5].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                //우유
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "우유(선택시)(Clone)")
                {
                    count_4++;

                    if (count_4 == 1)
                    {
                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[4].childCount == 0 && Material_Positions_Milk[5].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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


                //물
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "물(선택시)(Clone)")
                {
                    count_5++;

                    if (count_5 == 1)
                    {
                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[4].childCount == 0 && Material_Positions_Water[5].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                //찻잎
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "찻잎(선택시)(Clone)")
                {
                    count_6++;

                    if (count_6 == 1)
                    {
                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[4].childCount == 0 && Material_Positions_Tea[5].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                //초콜릿
                if (move_material.Pink_24[i].transform.GetChild(1).gameObject.name == "초콜릿(선택시)(Clone)")
                {
                    count_7++;

                    if (count_7 == 1)
                    {
                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[4].childCount == 0 && Material_Positions_Chocolate[5].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

    //파랑 컵1
    public void Go_Blue_Cup1_Test()
    {


        for (int i = 0; i < move_material.Blue_24.Length; i++)
        {
            if (move_material.selection_Blue_24[i].activeSelf && move_material.Blue_24[i].activeSelf && move_material.Blue_24[i].transform.childCount > 1)
            {
                move_material.selection_Blue_24[i].SetActive(false);

                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "얼음(선택시)(Clone)")
                {
                    count_0++;

                    if (count_0 == 1)
                    {
                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[6].childCount == 0 && Material_Positions_Ice[7].childCount == 1)
                        {//자식이 없고, 자식이 있으면
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[6], false);
                            //부모를 Material_Positions_Ice[0]에 해당하는 위치로 설정. false는 상대적인 로컬 위치로 설정

                            instantiatedObject.transform.localPosition = Vector3.zero;
                            //instantiatedObject의 로컬 위치 지정. 로컬 좌표 기준으로 0, 0, 0위치를 설정

                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            //로컬 회전을 설정. 회전 없음으로 설정

                            instantiatedObject.transform.localScale = Vector3.one;
                            //로컬 스케일은 1, 1, 1로 설정

                            Material_rigid_Blue1[0].gravityScale = 1.0f;
                            Positions_Ice[6].enabled = true;

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[6].childCount == 1 && Material_Positions_Ice[7].childCount == 0)
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "카라멜(선택시)(Clone)")
                {
                    count_1++;

                    if (count_1 == 1)
                    {
                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[6].childCount == 0 && Material_Positions_Caramel[7].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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


                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "증기(선택시)(Clone)")
                {
                    count_2++;

                    if (count_2 == 1)
                    {
                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[6].childCount == 0 && Material_Positions_Steam[7].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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



                //커피
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "커피콩(선택시)(Clone)")
                {
                    count_3++;

                    if (count_3 == 1)
                    {
                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[6].childCount == 0 && Material_Positions_Coffee[7].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                //우유
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "우유(선택시)(Clone)")
                {
                    count_4++;

                    if (count_4 == 1)
                    {
                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[6].childCount == 0 && Material_Positions_Milk[7].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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


                //물
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "물(선택시)(Clone)")
                {
                    count_5++;

                    if (count_5 == 1)
                    {
                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[6].childCount == 0 && Material_Positions_Water[7].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                //찻잎
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "찻잎(선택시)(Clone)")
                {
                    count_6++;

                    if (count_6 == 1)
                    {
                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[6].childCount == 0 && Material_Positions_Tea[7].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                //초콜릿
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "초콜릿(선택시)(Clone)")
                {
                    count_7++;

                    if (count_7 == 1)
                    {
                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[6].childCount == 0 && Material_Positions_Chocolate[7].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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



    //파란 컵 2번
    public void Go_Blue_Cup2_Test()
    {


        for (int i = 0; i < move_material.Blue_24.Length; i++)
        {
            if (move_material.selection_Blue_24[i].activeSelf && move_material.Blue_24[i].activeSelf && move_material.Blue_24[i].transform.childCount > 1)
            {
                move_material.selection_Blue_24[i].SetActive(false);

                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "얼음(선택시)(Clone)")
                {
                    count_0++;

                    if (count_0 == 1)
                    {
                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[8].childCount == 0 && Material_Positions_Ice[9].childCount == 1)
                        {//자식이 없고, 자식이 있으면
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[8], false);
                            //부모를 Material_Positions_Ice[0]에 해당하는 위치로 설정. false는 상대적인 로컬 위치로 설정

                            instantiatedObject.transform.localPosition = Vector3.zero;
                            //instantiatedObject의 로컬 위치 지정. 로컬 좌표 기준으로 0, 0, 0위치를 설정

                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            //로컬 회전을 설정. 회전 없음으로 설정

                            instantiatedObject.transform.localScale = Vector3.one;
                            //로컬 스케일은 1, 1, 1로 설정

                            Material_rigid_Blue2[0].gravityScale = 1.0f;
                            Positions_Ice[8].enabled = true;

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[8].childCount == 1 && Material_Positions_Ice[9].childCount == 0)
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "카라멜(선택시)(Clone)")
                {
                    count_1++;

                    if (count_1 == 1)
                    {
                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[8].childCount == 0 && Material_Positions_Caramel[9].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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


                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "증기(선택시)(Clone)")
                {
                    count_2++;

                    if (count_2 == 1)
                    {
                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[8].childCount == 0 && Material_Positions_Steam[9].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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



                //커피
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "커피콩(선택시)(Clone)")
                {
                    count_3++;

                    if (count_3 == 1)
                    {
                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[8].childCount == 0 && Material_Positions_Coffee[9].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                //우유
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "우유(선택시)(Clone)")
                {
                    count_4++;

                    if (count_4 == 1)
                    {
                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[8].childCount == 0 && Material_Positions_Milk[9].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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


                //물
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "물(선택시)(Clone)")
                {
                    count_5++;

                    if (count_5 == 1)
                    {
                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[8].childCount == 0 && Material_Positions_Water[9].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                //찻잎
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "찻잎(선택시)(Clone)")
                {
                    count_6++;

                    if (count_6 == 1)
                    {
                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[8].childCount == 0 && Material_Positions_Tea[9].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                //초콜릿
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "초콜릿(선택시)(Clone)")
                {
                    count_7++;

                    if (count_7 == 1)
                    {
                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[8].childCount == 0 && Material_Positions_Chocolate[9].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

    //파랑컵 3번
    public void Go_Blue_Cup3_Test()
    {


        for (int i = 0; i < move_material.Blue_24.Length; i++)
        {
            if (move_material.selection_Blue_24[i].activeSelf && move_material.Blue_24[i].activeSelf && move_material.Blue_24[i].transform.childCount > 1)
            {
                move_material.selection_Blue_24[i].SetActive(false);

                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "얼음(선택시)(Clone)")
                {
                    count_0++;

                    if (count_0 == 1)
                    {
                        GameObject instantiatedObject = Instantiate(Cup_Material[0], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Ice[10].childCount == 0 && Material_Positions_Ice[11].childCount == 1)
                        {//자식이 없고, 자식이 있으면
                            instantiatedObject.transform.SetParent(Material_Positions_Ice[10], false);
                            //부모를 Material_Positions_Ice[0]에 해당하는 위치로 설정. false는 상대적인 로컬 위치로 설정

                            instantiatedObject.transform.localPosition = Vector3.zero;
                            //instantiatedObject의 로컬 위치 지정. 로컬 좌표 기준으로 0, 0, 0위치를 설정

                            instantiatedObject.transform.localRotation = Quaternion.identity;
                            //로컬 회전을 설정. 회전 없음으로 설정

                            instantiatedObject.transform.localScale = Vector3.one;
                            //로컬 스케일은 1, 1, 1로 설정

                            Material_rigid_Blue3[0].gravityScale = 1.0f;
                            Positions_Ice[10].enabled = true;

                            Destroy(move_material.Blue_24[i].transform.GetChild(1).gameObject);

                            count_0 = 0;
                        }

                        if (Material_Positions_Ice[10].childCount == 1 && Material_Positions_Ice[11].childCount == 0)
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "카라멜(선택시)(Clone)")
                {
                    count_1++;

                    if (count_1 == 1)
                    {
                        GameObject instantiatedObject0 = Instantiate(Cup_Material[1], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Caramel[10].childCount == 0 && Material_Positions_Caramel[11].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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


                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "증기(선택시)(Clone)")
                {
                    count_2++;

                    if (count_2 == 1)
                    {
                        GameObject instantiatedObject3 = Instantiate(Cup_Material[2], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Steam[10].childCount == 0 && Material_Positions_Steam[11].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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



                //커피
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "커피콩(선택시)(Clone)")
                {
                    count_3++;

                    if (count_3 == 1)
                    {
                        GameObject instantiatedObject5 = Instantiate(Cup_Material[3], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Coffee[10].childCount == 0 && Material_Positions_Coffee[11].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                //우유
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "우유(선택시)(Clone)")
                {
                    count_4++;

                    if (count_4 == 1)
                    {
                        GameObject instantiatedObject7 = Instantiate(Cup_Material[4], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Milk[10].childCount == 0 && Material_Positions_Milk[11].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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


                //물
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "물(선택시)(Clone)")
                {
                    count_5++;

                    if (count_5 == 1)
                    {
                        GameObject instantiatedObject9 = Instantiate(Cup_Material[5], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Water[10].childCount == 0 && Material_Positions_Water[11].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                //찻잎
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "찻잎(선택시)(Clone)")
                {
                    count_6++;

                    if (count_6 == 1)
                    {
                        GameObject instantiatedObject11 = Instantiate(Cup_Material[6], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Tea[10].childCount == 0 && Material_Positions_Tea[11].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

                //초콜릿
                if (move_material.Blue_24[i].transform.GetChild(1).gameObject.name == "초콜릿(선택시)(Clone)")
                {
                    count_7++;

                    if (count_7 == 1)
                    {
                        GameObject instantiatedObject13 = Instantiate(Cup_Material[7], Vector3.zero, Quaternion.identity);

                        if (Material_Positions_Chocolate[10].childCount == 0 && Material_Positions_Chocolate[11].childCount == 1)
                        {//자식이 없고, 자식이 있으면
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
                        {//자식이 있고 2번째 것이 자식이 없으면

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
                        {//자식이 없으면

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

       
    




