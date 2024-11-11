using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Good_Bad : MonoBehaviour
{
    public Text Good_Count;
    public int Goood_Count;

    public Text Bad_Count;
    public int Bad_Ccount;

    public Text Coin_Count;
    public int Ccoin_Count;

    public Text Good_Count_Blue;
    public int Goood_Count_Blue;

    public Text Bad_Count_Blue;
    public int Bad_Ccount_Blue;

    public Text Coin_Count_Blue;
    public int Ccoin_Count_Blue;

    private void Start()
    {
        Goood_Count = 0;
        Bad_Ccount = 0;
        Ccoin_Count = 0;

        Goood_Count_Blue = 0;
        Bad_Ccount_Blue = 0;
        Ccoin_Count_Blue = 0;
    }

    void Update()
    {
        Update_Good_Count();
        Update_Bad_Count();
        Update_Coin_Count();

        Update_Good_Count_Blue();
        Update_Bad_Count_Blue();
        Update_Coin_Count_Blue();
    }

    public void Update_Good_Count()
    {
        //�÷��̾ �� �� ������ �ִ��� Ȯ���ϴ� �ڵ�
        if(Goood_Count<10)
        {
            Good_Count.text = "0" + Goood_Count.ToString();
        }
       
        else if (Goood_Count > 9)
        {
            Good_Count.text = " " + Goood_Count.ToString();
        }

        Debug.Log("�ֹ� ó�� �Ѱ� �� ��? : " + Goood_Count.ToString());
    }

    public void Update_Bad_Count()
    {
        //�÷��̾ �� �� ������ �ƴ� ���� �ִ��� Ȯ���ϴ� �ڵ�
        if (Bad_Ccount < 10)
        {
            Bad_Count.text = "0" + Bad_Ccount.ToString();
        }

        else if (Bad_Ccount > 9)
        {
            Bad_Count.text = " " + Bad_Ccount.ToString();
        }
        Debug.Log("�ֹ� ó�� ���Ѱ� �� ��? : " + Bad_Ccount.ToString());
    }

    public void Update_Coin_Count()
    {
        //�÷��̾ �� �� ������ �ƴ� ���� �ִ��� Ȯ���ϴ� �ڵ�
        if (Ccoin_Count < 10)
        {
            Coin_Count.text = "0" + Ccoin_Count.ToString();
        }

        else if (Ccoin_Count > 9)
        {
            Coin_Count.text = " " + Ccoin_Count.ToString();
        }
        Debug.Log("����� �޴� ó�� + �ֹ�ó�� ���� �� �� ��? : " + Ccoin_Count.ToString());
    }

    public void Update_Good_Count_Blue()
    {
        //�÷��̾ �� �� ������ �ִ��� Ȯ���ϴ� �ڵ�
        if (Goood_Count_Blue < 10)
        {
            Good_Count_Blue.text = "0" + Goood_Count_Blue.ToString();
        }

        else if (Goood_Count_Blue > 9)
        {
            Good_Count_Blue.text = " " + Goood_Count_Blue.ToString();
        }

        Debug.Log("��� �ֹ� ó�� �Ѱ� �� ��? : " + Goood_Count_Blue.ToString());
    }

    public void Update_Bad_Count_Blue()
    {
        //�÷��̾ �� �� ������ �ƴ� ���� �ִ��� Ȯ���ϴ� �ڵ�
        if (Bad_Ccount_Blue < 10)
        {
            Bad_Count_Blue.text = "0" + Bad_Ccount_Blue.ToString();
        }

        else if (Bad_Ccount_Blue > 9)
        {
            Bad_Count_Blue.text = " " + Bad_Ccount_Blue.ToString();
        }
        Debug.Log("��� �ֹ� ó�� ���Ѱ� �� ��? : " + Bad_Ccount_Blue.ToString());
    }

    public void Update_Coin_Count_Blue()
    {
        //�÷��̾ �� �� ������ �ƴ� ���� �ִ��� Ȯ���ϴ� �ڵ�
        if (Ccoin_Count_Blue < 10)
        {
            Coin_Count_Blue.text = "0" + Ccoin_Count_Blue.ToString();
        }

        else if (Ccoin_Count_Blue > 9)
        {
            Coin_Count_Blue.text = " " + Ccoin_Count_Blue.ToString();
        }
        Debug.Log("��� ����� �޴� ó�� + �ֹ�ó�� ���� �� �� ��? : " + Ccoin_Count_Blue.ToString());
    }
}
