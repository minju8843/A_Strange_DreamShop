using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Move_Count : MonoBehaviour
{
    public Text Move_Player_Count;//���� �÷��̾ �� �� ������ �� �ִ���
    public int Can_Move_Count;

    //public Text Coin_Add_Move_Count;//���� ������ �� ������
    //public int Can_Coin_Count;

    public Turn_Count turn_count;//�� ��° ������

    //����� ���� 2�� ������ ��

    //1) ������ ������ ���� �̵�(1���϶�, 1�� �ʰ��� ��)

    //2) ������ ���� �� (3ĭ�� �� �� ���� ��)

    void Start()
    {
        Can_Move_Count = 1;

    }


    void Update()
    {
        

        Update_Can_Move_Count();//�÷��̾� ������ �� �ִ� Ƚ��


        
        /*if (Can_Move_Count==0)//�� �ڵ尡 ����� �Ǵ� ���� ã��
        {
            BoxCollider2D boxCollider1 = turn_count.objects[0].GetComponent<BoxCollider2D>();//��ũ1 �ݶ��̴�
            boxCollider1.enabled = false;

            BoxCollider2D boxCollider2 = turn_count.objects[1].GetComponent<BoxCollider2D>();//��ũ2 �ݶ��̴�
            boxCollider2.enabled = false;

            BoxCollider2D boxCollider3 = turn_count.objects[2].GetComponent<BoxCollider2D>();//�Ķ�1 �ݶ��̴�
            boxCollider3.enabled = false;

            BoxCollider2D boxCollider4 = turn_count.objects[3].GetComponent<BoxCollider2D>();//�Ķ�2 �ݶ��̴�
            boxCollider4.enabled = false;
        }*/
    }

    public void Update_Can_Move_Count()
    {
        

        //�÷��̾ �� �� ������ �� �ִ��� Ȯ���ϴ� �ڵ�
        Move_Player_Count.text ="0"+ Can_Move_Count.ToString();
        Debug.Log(Can_Move_Count + "�� ����");
    }

    public void Plus_Can_Move_Count()
    {
        //�÷��̾ �� �� ������ �� �ִ��� Ȯ���ϴ� �ڵ�
        Can_Move_Count++;
    }

    public void Minus_Can_Move_Count()
    {
        Can_Move_Count--;
    }
}
