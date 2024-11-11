using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Move_Count : MonoBehaviour
{
    public Text Move_Player_Count;//현재 플레이어가 몇 번 움직일 수 있는지
    public int Can_Move_Count;

    //public Text Coin_Add_Move_Count;//현재 코인이 몇 개인지
    //public int Can_Coin_Count;

    public Turn_Count turn_count;//몇 번째 턴인지

    //경우의 수를 2개 만들어야 함

    //1) 코인의 개수에 따른 이동(1개일때, 1개 초과일 때)

    //2) 코인이 없을 때 (3칸만 갈 수 있을 때)

    void Start()
    {
        Can_Move_Count = 1;

    }


    void Update()
    {
        

        Update_Can_Move_Count();//플레이어 움직일 수 있는 횟수


        
        /*if (Can_Move_Count==0)//이 코드가 적용안 되는 이유 찾기
        {
            BoxCollider2D boxCollider1 = turn_count.objects[0].GetComponent<BoxCollider2D>();//핑크1 콜라이더
            boxCollider1.enabled = false;

            BoxCollider2D boxCollider2 = turn_count.objects[1].GetComponent<BoxCollider2D>();//핑크2 콜라이더
            boxCollider2.enabled = false;

            BoxCollider2D boxCollider3 = turn_count.objects[2].GetComponent<BoxCollider2D>();//파랑1 콜라이더
            boxCollider3.enabled = false;

            BoxCollider2D boxCollider4 = turn_count.objects[3].GetComponent<BoxCollider2D>();//파랑2 콜라이더
            boxCollider4.enabled = false;
        }*/
    }

    public void Update_Can_Move_Count()
    {
        

        //플레이어가 몇 번 움직일 수 있는지 확인하는 코드
        Move_Player_Count.text ="0"+ Can_Move_Count.ToString();
        Debug.Log(Can_Move_Count + "번 남음");
    }

    public void Plus_Can_Move_Count()
    {
        //플레이어가 몇 번 움직일 수 있는지 확인하는 코드
        Can_Move_Count++;
    }

    public void Minus_Can_Move_Count()
    {
        Can_Move_Count--;
    }
}
