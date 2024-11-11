using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade_Tile_Blue : MonoBehaviour
{
    // �÷��̾� ���� ��ũ��Ʈ���� �� ��
    // ���� �̵��� �� �ִ� Ƚ���� 1�� ������ ��
    // �ٸ� ���� �ִ� ������ �̵��Ϸ��� �ϸ�
    // ->�̵�Ƚ���� 1ȸ ���ҽ��ϴ�. ������ ����Ͻðڽ��ϱ�? ���
    // �׸��� ������ �� �� ����� ���� 

    public GameObject[] Double_Player_Tile;//�÷��̾� 2�� ���� �� 2��
    public GameObject[] Diagonal_Line_Tile;//�밢�� �̵� ����
    public GameObject[] Vertex_Tile;//�������� ���� �� 2��
    public GameObject[] Speciality_Tile;//�����Ƽ�� ���� �� 2��

    //����� �÷��̾� 2��
    public GameObject Double_Player_Tile_Upgrade;//�÷��̾�2�� Ÿ�� ������Ʈ �ϰڽ��ϱ�?
    public GameObject Double_Player_Tile_Upgrade_Inside;

    public GameObject Double_Player_Tile_Upgrade_Will_No;//�÷��̾�2�� Ÿ�� ������Ʈ // ���� �ش� �ȵǴ°�
    public GameObject Double_Player_Tile_Upgrade_Will_No_Inside;

    //����� �밢��
    public GameObject Diagonal_Line_Tile_Upgrade;//�밢�� �̵� Ÿ�� ������Ʈ �ϰھ��ϱ�?
    public GameObject Diagonal_Line_Tile_Upgrade_Inside;

    public GameObject Diagonal_Line_Tile_Upgrade_Will_No;
    public GameObject Diagonal_Line_Tile_Upgrade_Will_No_Inside;

    //����� ������ 2��
    public GameObject Vertex_Tile_Upgrade;//�������� ���� �� 2�� Ÿ�� ������Ʈ
    public GameObject Vertex_Tile_Upgrade_Inside;

    public GameObject Vertex_Tile_Upgrade_Will_No;
    public GameObject Vertex_Tile_Upgrade_Will_No_Inside;

    //����� �����Ƽ 2��
    public GameObject Speciality_Tile_Upgrade;//�����Ƽ�� ���� �� 2�� Ÿ�� ������Ʈ
    public GameObject Speciality_Tile_Upgrade_Inside;

    public GameObject Speciality_Tile_Upgrade_Will_No;
    public GameObject Speciality_Tile_Upgrade_Will_No_Inside;

    //����
    //public GameObject[] Coin_Button;//���� ��ư
    public Button[] Coin_Four_Button;

    public GameObject Will_Use_Coin;//���� ����Ұ�? //������ �ϳ��� �ִ� ���
    public GameObject Will_Use_Coin_Inside;
    public GameObject Will_Use_Coin_No_Coin;//���� ����Ұ�? //������ �ϳ��� ���� ���
    public GameObject Will_Use_Coin_No_Coin_Inside;

    public GameObject No_Coin;//���� �����鼭!
    public GameObject Use_Coin;//���� �� �� ����� �ǵ�?

    public GameObject Already_Player_Coin_Zero;//�ٸ� ���� �ִ� ��� ĭ�� ���� ������ �ϴµ� ������ 0����?
    public GameObject Already_Player_Coin_Zero_Inside;

    public GameObject Already_Player_Coin_Not_Zero;//�ٸ� ���� �ִ� ��� ĭ�� ���� ������ �ϴµ� ������ �ֳ�?
    public GameObject Already_Player_Coin_Not_Zero_Inside;

    public Text Coin_Count;//���� ����
    public int Ccoin_Count;//���� ����

    public Turn_Count B_Count;

    public GameObject No_Good;//�ֹ� ó���� �� 3�� �̻� �ȵǸ鼭!

    public Good_Bad good_bad;

    public Player_Move_Count Can_Move_Count;

    public GameObject Next_Turn_No_Double_Player;

    public SFX_2023 sfx;

    //�� ��ũ��Ʈ�� ���׷��̵� Ÿ�� Ȱ��ȭ�� ���� ������� ��ũ��Ʈ �Դϴ�.
    //���� ������ ���������� ���� ����ϰ� ���� �� ����ϴ� �ڵ��Դϴ�.

    //����� ��(���׷��̵� Ÿ�� Ȱ��ȭ)
    //1. ���� <���Ӹ� 2��>���׷��̵� Ÿ���� Ŭ�� ���� ��
    // -> <���Ӹ� 2��> Ÿ���� ���׷��̵� �ϰڽ��ϱ�?

    public void Start()
    {
        Double_Player_Tile[0].SetActive(true);//���� �ȵ�
        Double_Player_Tile[1].SetActive(false);//���� ������
        Double_Player_Tile[2].SetActive(false);//Ȱ��ȭ��

        //������ʹ� �밢��
        Diagonal_Line_Tile[0].SetActive(true);
        Diagonal_Line_Tile[1].SetActive(false);
        Diagonal_Line_Tile[2].SetActive(false);//Ȱ��ȭ��

        //������ʹ� ������ 2��
        Vertex_Tile[0].SetActive(true);
        Vertex_Tile[1].SetActive(false);
        Vertex_Tile[2].SetActive(false);//Ȱ��ȭ��

        //������� �����Ƽ 2��
        Speciality_Tile[0].SetActive(true);
        Speciality_Tile[1].SetActive(false);
        Speciality_Tile[2].SetActive(false);

        //����
        //���� ��ũ�� ������� �� ��
        //Coin_Button[0].SetActive(true);//������ 0��
        //Coin_Button[1].SetActive(false);//������ 1�� �̻�

        Will_Use_Coin_No_Coin.SetActive(true);
        Will_Use_Coin.SetActive(false);

        Already_Player_Coin_Zero.SetActive(true);//���� ���� //��� ĭ�� �� ����
        Already_Player_Coin_Not_Zero.SetActive(false);//���� ���� //��� ĭ�� �� ����


    }

    public void Update()
    {
        //���� ��ư ������ & �� ������ �ϴ� ��
        if (Can_Move_Count.Can_Move_Count > 0)//���� ������ �� �ִ� Ƚ���� 1 �̻��̶��
        {
            //��ư ��ġ���� �� �ǵ��� �ϱ�
            Button button_0 = Coin_Four_Button[0].GetComponent<Button>();
            button_0.interactable = false;//��ư�� ������ �ʰ� �ϴ� �ڵ�

            Button button_1 = Coin_Four_Button[1].GetComponent<Button>();
            button_1.interactable = false;//��ư�� ������ �ʰ� �ϴ� �ڵ�

        }

        if (Can_Move_Count.Can_Move_Count == 0 && B_Count.Click_Count < 4)//���� ������ �� �ִ� Ƚ���� 0�̶��
        {
            //��ư ��ġ �ǵ��� �ϱ�
            Button button_0 = Coin_Four_Button[0].GetComponent<Button>();
            button_0.interactable = false;//��ư�� �� ������

            Button button_1 = Coin_Four_Button[1].GetComponent<Button>();
            button_1.interactable = false;//��ư�� �� ������

        }

        if (Can_Move_Count.Can_Move_Count == 0 && B_Count.Click_Count > 3)//���� ������ �� �ִ� Ƚ���� 0�̶��
        {
            //��ư ��ġ �ǵ��� �ϱ�
            Button button_0 = Coin_Four_Button[0].GetComponent<Button>();
            button_0.interactable = true;//��ư�� ������

            Button button_1 = Coin_Four_Button[1].GetComponent<Button>();
            button_1.interactable = true;//��ư�� ������

        }



        if (good_bad.Goood_Count_Blue > 2 && good_bad.Ccoin_Count_Blue > 0)//������ 1�� �̻�
        {
            Double_Player_Tile[0].SetActive(false);
            Double_Player_Tile[1].SetActive(true);
            Double_Player_Tile_Upgrade.SetActive(true);
            Double_Player_Tile_Upgrade_Will_No.SetActive(false);

            //������ʹ� �밢��
            Diagonal_Line_Tile[0].SetActive(false);
            Diagonal_Line_Tile[1].SetActive(true);
            Diagonal_Line_Tile_Upgrade.SetActive(true);
            Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

            //������ʹ� ������
            Vertex_Tile[0].SetActive(false);
            Vertex_Tile[1].SetActive(true);
            Vertex_Tile_Upgrade.SetActive(true);
            Vertex_Tile_Upgrade_Will_No.SetActive(false);

            //������ʹ� �����Ƽ
            Speciality_Tile[0].SetActive(false);
            Speciality_Tile[1].SetActive(true);
            Speciality_Tile_Upgrade.SetActive(true);
            Speciality_Tile_Upgrade_Will_No.SetActive(false);

            //������ʹ� ����
            //Coin_Button[0].SetActive(false);//������ 0��
            //Coin_Button[1].SetActive(true);//������ 1�� �̻�

            Will_Use_Coin_No_Coin.SetActive(false);
            Will_Use_Coin.SetActive(true);

            Already_Player_Coin_Zero.SetActive(false);//���� ���� //��� ĭ�� �� ����
            Already_Player_Coin_Not_Zero.SetActive(true);//���� ���� //��� ĭ�� �� ����
        }

        if (good_bad.Goood_Count_Blue > 2 && good_bad.Ccoin_Count_Blue == 0)//������ 0��
        {
            Double_Player_Tile[0].SetActive(false);
            Double_Player_Tile[1].SetActive(true);
            Double_Player_Tile_Upgrade.SetActive(true);
            Double_Player_Tile_Upgrade_Will_No.SetActive(false);

            //������ʹ� �밢��
            Diagonal_Line_Tile[0].SetActive(false);
            Diagonal_Line_Tile[1].SetActive(true);
            Diagonal_Line_Tile_Upgrade.SetActive(true);
            Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

            //������ʹ� ������
            Vertex_Tile[0].SetActive(false);
            Vertex_Tile[1].SetActive(true);
            Vertex_Tile_Upgrade.SetActive(true);
            Vertex_Tile_Upgrade_Will_No.SetActive(false);

            //������ʹ� �����Ƽ
            Speciality_Tile[0].SetActive(false);
            Speciality_Tile[1].SetActive(true);
            Speciality_Tile_Upgrade.SetActive(true);
            Speciality_Tile_Upgrade_Will_No.SetActive(false);

            //������ʹ� ����
            // Coin_Button[0].SetActive(true);//������ 0��
            //Coin_Button[1].SetActive(false);//������ 1�� �̻�

            Will_Use_Coin_No_Coin.SetActive(true);
            Will_Use_Coin.SetActive(false);

            Already_Player_Coin_Zero.SetActive(true);//���� ���� //��� ĭ�� �� ����
            Already_Player_Coin_Not_Zero.SetActive(false);//���� ���� //��� ĭ�� �� ����
        }



        if (good_bad.Goood_Count_Blue < 3 && good_bad.Ccoin_Count_Blue > 0)//������ 1�� �̻�
        {
            Double_Player_Tile[0].SetActive(true);
            Double_Player_Tile[1].SetActive(false);
            Double_Player_Tile_Upgrade.SetActive(false);
            Double_Player_Tile_Upgrade_Will_No.SetActive(true);

            //������ʹ� �밢��
            Diagonal_Line_Tile[0].SetActive(true);
            Diagonal_Line_Tile[1].SetActive(false);
            Diagonal_Line_Tile_Upgrade.SetActive(false);
            Diagonal_Line_Tile_Upgrade_Will_No.SetActive(true);

            //������ʹ� ������
            Vertex_Tile[0].SetActive(true);
            Vertex_Tile[1].SetActive(false);
            Vertex_Tile_Upgrade.SetActive(false);
            Vertex_Tile_Upgrade_Will_No.SetActive(true);

            //������ʹ� �����Ƽ
            Speciality_Tile[0].SetActive(true);
            Speciality_Tile[1].SetActive(false);
            Speciality_Tile_Upgrade.SetActive(false);
            Speciality_Tile_Upgrade_Will_No.SetActive(true);

            //������ʹ� ����
            //Coin_Button[0].SetActive(false);//������ 0��
            //Coin_Button[1].SetActive(true);//������ 1�� �̻�

            Will_Use_Coin_No_Coin.SetActive(false);
            Will_Use_Coin.SetActive(true);

            Already_Player_Coin_Zero.SetActive(false);//���� ���� //��� ĭ�� �� ����
            Already_Player_Coin_Not_Zero.SetActive(true);//���� ���� //��� ĭ�� �� ����
        }

        if (good_bad.Goood_Count_Blue < 3 && good_bad.Ccoin_Count_Blue == 0)//������ 0��
        {
            Double_Player_Tile[0].SetActive(true);
            Double_Player_Tile[1].SetActive(false);
            Double_Player_Tile_Upgrade.SetActive(false);
            Double_Player_Tile_Upgrade_Will_No.SetActive(true);

            //������ʹ� �밢��
            Diagonal_Line_Tile[0].SetActive(true);
            Diagonal_Line_Tile[1].SetActive(false);
            Diagonal_Line_Tile_Upgrade.SetActive(false);
            Diagonal_Line_Tile_Upgrade_Will_No.SetActive(true);

            //������ʹ� ������
            Vertex_Tile[0].SetActive(true);
            Vertex_Tile[1].SetActive(false);
            Vertex_Tile_Upgrade.SetActive(false);
            Vertex_Tile_Upgrade_Will_No.SetActive(true);

            //������ʹ� �����Ƽ
            Speciality_Tile[0].SetActive(true);
            Speciality_Tile[1].SetActive(false);
            Speciality_Tile_Upgrade.SetActive(false);
            Speciality_Tile_Upgrade_Will_No.SetActive(true);

            //������ʹ� ����
            //Coin_Button[0].SetActive(true);//������ 0��
            //Coin_Button[1].SetActive(false);//������ 1�� �̻�

            Will_Use_Coin_No_Coin.SetActive(true);
            Will_Use_Coin.SetActive(false);

            Already_Player_Coin_Zero.SetActive(true);//���� ���� //��� ĭ�� �� ����
            Already_Player_Coin_Not_Zero.SetActive(false);//���� ���� //��� ĭ�� �� ����
        }

        if ((good_bad.Goood_Count_Blue > 2 || good_bad.Goood_Count_Blue < 3) && Double_Player_Tile[2].activeSelf == true && good_bad.Ccoin_Count_Blue > 0)//������ 1�� �̻�
        {
            Double_Player_Tile[2].SetActive(true);
            Double_Player_Tile_Upgrade.SetActive(false);
            Double_Player_Tile_Upgrade_Will_No.SetActive(false);

            //������ʹ� ����
            //Coin_Button[0].SetActive(false);//������ 0��
            //Coin_Button[1].SetActive(true);//������ 1�� �̻�

            Will_Use_Coin_No_Coin.SetActive(false);
            Will_Use_Coin.SetActive(true);

            Already_Player_Coin_Zero.SetActive(false);//���� ���� //��� ĭ�� �� ����
            Already_Player_Coin_Not_Zero.SetActive(true);//���� ���� //��� ĭ�� �� ����

            //����� �� ������ ��
            // 1. �밢���� ���̸�
            if (Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == false)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 2. �������� ���̸�
            if (Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 3. �����Ƽ�� ���̸�
            if (Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 4. �밢���� �������� ���̸�
            if (Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 5. �밢���� �����Ƽ�� ���̸�
            if (Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 6. �������� �����Ƽ�� ���̸�
            if (Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == true)
            {
                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 7. �밢��, ������, �����Ƽ�� ��� ���̸�
            if (Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == true)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

        }

        if ((good_bad.Goood_Count_Blue > 2 || good_bad.Goood_Count_Blue < 3) && Double_Player_Tile[2].activeSelf == true && good_bad.Ccoin_Count_Blue == 0)//������ 0��
        {
            Double_Player_Tile[2].SetActive(true);
            Double_Player_Tile_Upgrade.SetActive(false);
            Double_Player_Tile_Upgrade_Will_No.SetActive(false);

            //������ʹ� ����
            //Coin_Button[0].SetActive(true);//������ 0��
            //Coin_Button[1].SetActive(false);//������ 1�� �̻�

            Will_Use_Coin_No_Coin.SetActive(true);
            Will_Use_Coin.SetActive(false);

            Already_Player_Coin_Zero.SetActive(true);//���� ���� //��� ĭ�� �� ����
            Already_Player_Coin_Not_Zero.SetActive(false);//���� ���� //��� ĭ�� �� ����

            //����� �� ������ ��
            // 1. �밢���� ���̸�
            if (Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == false)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 2. �������� ���̸�
            if (Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 3. �����Ƽ�� ���̸�
            if (Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 4. �밢���� �������� ���̸�
            if (Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 5. �밢���� �����Ƽ�� ���̸�
            if (Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 6. �������� �����Ƽ�� ���̸�
            if (Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == true)
            {
                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 7. �밢��, ������, �����Ƽ�� ��� ���̸�
            if (Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == true)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

        }

        if ((good_bad.Goood_Count_Blue > 2 || good_bad.Goood_Count_Blue < 3) && Diagonal_Line_Tile[2].activeSelf == true && good_bad.Ccoin_Count_Blue > 0)//������ 1�� �̻�
        {
            //������ʹ� �밢��
            Diagonal_Line_Tile[2].SetActive(true);
            Diagonal_Line_Tile_Upgrade.SetActive(false);
            Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

            //������ʹ� ����
            //Coin_Button[0].SetActive(false);//������ 0��
            //Coin_Button[1].SetActive(true);//������ 1�� �̻�

            Will_Use_Coin_No_Coin.SetActive(false);
            Will_Use_Coin.SetActive(true);

            Already_Player_Coin_Zero.SetActive(false);//���� ���� //��� ĭ�� �� ����
            Already_Player_Coin_Not_Zero.SetActive(true);//���� ���� //��� ĭ�� �� ����

            //����� �� ������ ��
            // 1. �÷��̾� 2�赵 ���̸�
            if (Double_Player_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 2. �������� ���̸�
            if (Double_Player_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 3. �����Ƽ�� ���̸�
            if (Double_Player_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 4. �÷��̾� 2��� �������� ���̸�
            if (Double_Player_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 5. �÷��̾� 2��� �����Ƽ�� ���̸�
            if (Double_Player_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 6. �������� �����Ƽ�� ���̸�
            if (Double_Player_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == true)
            {
                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 7. �÷��̾� 2��, ������, �����Ƽ�� ��� ���̸�
            if (Double_Player_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == true)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }
        }

        if ((good_bad.Goood_Count_Blue > 2 || good_bad.Goood_Count_Blue < 3) && Diagonal_Line_Tile[2].activeSelf == true && good_bad.Ccoin_Count_Blue == 0)//������ 0��
        {
            //������ʹ� �밢��
            Diagonal_Line_Tile[2].SetActive(true);
            Diagonal_Line_Tile_Upgrade.SetActive(false);
            Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

            //������ʹ� ����
            // Coin_Button[0].SetActive(true);//������ 0��
            //Coin_Button[1].SetActive(false);//������ 1�� �̻�

            Will_Use_Coin_No_Coin.SetActive(true);
            Will_Use_Coin.SetActive(false);

            Already_Player_Coin_Zero.SetActive(true);//���� ���� //��� ĭ�� �� ����
            Already_Player_Coin_Not_Zero.SetActive(false);//���� ���� //��� ĭ�� �� ����

            //����� �� ������ ��
            // 1. �÷��̾� 2�赵 ���̸�
            if (Double_Player_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 2. �������� ���̸�
            if (Double_Player_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 3. �����Ƽ�� ���̸�
            if (Double_Player_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 4. �÷��̾� 2��� �������� ���̸�
            if (Double_Player_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 5. �÷��̾� 2��� �����Ƽ�� ���̸�
            if (Double_Player_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 6. �������� �����Ƽ�� ���̸�
            if (Double_Player_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == true)
            {
                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 7. �÷��̾� 2��, ������, �����Ƽ�� ��� ���̸�
            if (Double_Player_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == true)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }
        }

        if ((good_bad.Goood_Count_Blue > 2 || good_bad.Goood_Count_Blue < 3) && Vertex_Tile[2].activeSelf == true && good_bad.Ccoin_Count_Blue > 0)//������ 1�� �̻�
        {
            //������ʹ� ������
            Vertex_Tile[2].SetActive(true);
            Vertex_Tile_Upgrade.SetActive(false);
            Vertex_Tile_Upgrade_Will_No.SetActive(false);

            //������ʹ� ����
            //Coin_Button[0].SetActive(false);//������ 0��
            //Coin_Button[1].SetActive(true);//������ 1�� �̻�

            Will_Use_Coin_No_Coin.SetActive(false);
            Will_Use_Coin.SetActive(true);

            Already_Player_Coin_Zero.SetActive(false);//���� ���� //��� ĭ�� �� ����
            Already_Player_Coin_Not_Zero.SetActive(true);//���� ���� //��� ĭ�� �� ����

            //����� �� ������ ��
            // 1. �÷��̾� 2�赵 ���̸�
            if (Double_Player_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 2. �밢���� ���̸�
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 3. �����Ƽ�� ���̸�
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 4. �÷��̾� 2��� �밢���� ���̸�
            if (Double_Player_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 5. �÷��̾� 2��� �����Ƽ�� ���̸�
            if (Diagonal_Line_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 6. �밢���� �����Ƽ�� ���̸�
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == true)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 7. �÷��̾� 2��, �밢��, �����Ƽ�� ��� ���̸�
            if (Double_Player_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == true)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }
        }

        if ((good_bad.Goood_Count_Blue > 2 || good_bad.Goood_Count_Blue < 3) && Vertex_Tile[2].activeSelf == true && good_bad.Ccoin_Count_Blue == 0)//������ 0��
        {
            //������ʹ� ������
            Vertex_Tile[2].SetActive(true);
            Vertex_Tile_Upgrade.SetActive(false);
            Vertex_Tile_Upgrade_Will_No.SetActive(false);

            //������ʹ� ����
            // Coin_Button[0].SetActive(true);//������ 0��
            // Coin_Button[1].SetActive(false);//������ 1�� �̻�

            Will_Use_Coin_No_Coin.SetActive(true);
            Will_Use_Coin.SetActive(false);

            Already_Player_Coin_Zero.SetActive(true);//���� ���� //��� ĭ�� �� ����
            Already_Player_Coin_Not_Zero.SetActive(false);//���� ���� //��� ĭ�� �� ����

            //����� �� ������ ��
            // 1. �÷��̾� 2�赵 ���̸�
            if (Double_Player_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 2. �밢���� ���̸�
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 3. �����Ƽ�� ���̸�
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 4. �÷��̾� 2��� �밢���� ���̸�
            if (Double_Player_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 5. �÷��̾� 2��� �����Ƽ�� ���̸�
            if (Diagonal_Line_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 6. �밢���� �����Ƽ�� ���̸�
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == true)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 7. �÷��̾� 2��, �밢��, �����Ƽ�� ��� ���̸�
            if (Double_Player_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == true)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }
        }

        if ((good_bad.Goood_Count_Blue > 2 || good_bad.Goood_Count_Blue < 3) && Speciality_Tile[2].activeSelf == true && good_bad.Ccoin_Count_Blue > 0)//������ 1�� �̻�
        {
            //������ʹ� �����Ƽ
            Speciality_Tile[2].SetActive(true);
            Speciality_Tile_Upgrade.SetActive(false);
            Speciality_Tile_Upgrade_Will_No.SetActive(false);

            //������ʹ� ����
            //Coin_Button[0].SetActive(false);//������ 0��
            //Coin_Button[1].SetActive(true);//������ 1�� �̻�

            Will_Use_Coin_No_Coin.SetActive(false);
            Will_Use_Coin.SetActive(true);

            Already_Player_Coin_Zero.SetActive(false);//���� ���� //��� ĭ�� �� ����
            Already_Player_Coin_Not_Zero.SetActive(true);//���� ���� //��� ĭ�� �� ����

            //����� �� ������ ��
            // 1. �÷��̾� 2�赵 ���̸�
            if (Double_Player_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 2. �밢���� ���̸�
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 3. ������ ���̸�
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true)
            {
                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 4. �÷��̾� 2��� �밢���� ���̸�
            if (Double_Player_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 5. �÷��̾� 2��� �������� ���̸�
            if (Diagonal_Line_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 6. �밢���� �������� ���̸�
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == true)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 7. �÷��̾� 2��, �밢��, �������� ��� ���̸�
            if (Double_Player_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == true)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }
        }

        if ((good_bad.Goood_Count_Blue > 2 || good_bad.Goood_Count_Blue < 3) && Speciality_Tile[2].activeSelf == true && good_bad.Ccoin_Count_Blue == 0)//������ 0��
        {
            //������ʹ� �����Ƽ
            Speciality_Tile[2].SetActive(true);
            Speciality_Tile_Upgrade.SetActive(false);
            Speciality_Tile_Upgrade_Will_No.SetActive(false);

            //������ʹ� ����
            // Coin_Button[0].SetActive(true);//������ 0��
            // Coin_Button[1].SetActive(false);//������ 1�� �̻�

            Will_Use_Coin_No_Coin.SetActive(true);
            Will_Use_Coin.SetActive(false);

            Already_Player_Coin_Zero.SetActive(true);//���� ���� //��� ĭ�� �� ����
            Already_Player_Coin_Not_Zero.SetActive(false);//���� ���� //��� ĭ�� �� ����

            //����� �� ������ ��
            // 1. �÷��̾� 2�赵 ���̸�
            if (Double_Player_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 2. �밢���� ���̸�
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 3. ������ ���̸�
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true)
            {
                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 4. �÷��̾� 2��� �밢���� ���̸�
            if (Double_Player_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 5. �÷��̾� 2��� �������� ���̸�
            if (Diagonal_Line_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 6. �밢���� �������� ���̸�
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == true)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 7. �÷��̾� 2��, �밢��, �������� ��� ���̸�
            if (Double_Player_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == true)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }
        }
    }


    public void Upgrade_Double_Player_Tile_Inside()//���Ӹ� 2�� //���� �ش� ��
    {//���Ӹ� 2�� Ÿ���� Ȱ��ȭ�Ͻðڽ��ϱ�? 

        Double_Player_Tile_Upgrade_Inside.SetActive(true);//���� �ش�� ��
        Double_Player_Tile_Upgrade_Will_No_Inside.SetActive(false);//���� �ش� �ȵ� ��
    }

    public void Upgrade_Double_Player_Tile_No_Inside()//���Ӹ� 2��//���� �ش� �ȵ�
    {//���Ӹ� 2�� Ÿ���� Ȱ��ȭ�Ͻðڽ��ϱ�? 

        Double_Player_Tile_Upgrade_Inside.SetActive(false);//���� �ش�� ��
        Double_Player_Tile_Upgrade_Will_No_Inside.SetActive(true);//���� �ش� �ȵ� ��
    }

    public void Upgrade_Double_Player_Tile_Yes()//���� �ش�Ǵ� ���
    {//���Ӹ� 2�� Ÿ���� Ȱ��ȭ�Ͻðڽ��ϱ�? 
     //->��
        Double_Player_Tile_Upgrade_Inside.SetActive(false);//���� �ش�� ��
        Double_Player_Tile_Upgrade_Will_No_Inside.SetActive(false);//���� �ش� �ȵ� ��

        //���� Good�� 3�� �̻��̶��
        //���׷���Ʈ �� �� �ְ�
        Double_Player_Tile[1].SetActive(false);
        Double_Player_Tile[2].SetActive(true);

        for (int i = 0; i < 3; i++)
        {
            good_bad.Goood_Count_Blue--;//�� �߰�
            good_bad.Update_Good_Count_Blue();//�� �߰� ��� �ڵ�
        }
        sfx.SFX_Button();
    }

    public void Upgrade_Double_Player_Tile_Yes_No()//���� �ش���� �ʴ� ��쿡 Yes�� ������
    {//���Ӹ� 2�� Ÿ���� Ȱ��ȭ�Ͻðڽ��ϱ�? 
     //->��
        Double_Player_Tile_Upgrade_Inside.SetActive(false);//���� �ش�� ��
        Double_Player_Tile_Upgrade_Will_No_Inside.SetActive(false);//���� �ش� �ȵ� ��

        //Good�� 3�� �̸��̶�� 
        //���׷��̵� �� �� ����

        No_Good.SetActive(true);
        sfx.SFX_Button();
    }

    public void You_Not_Double_Player_Tile_Ok()//���׷��̵� �� �� ������ Ȯ�� ��ư
    {
        No_Good.SetActive(false);
    }

    public void Upgrade_Double_Player_Tile_No()
    {//���Ӹ� 2�� Ÿ���� Ȱ��ȭ�Ͻðڽ��ϱ�? 
     //->�ƴϿ�
     //���� ȭ������ ���ư�
        Double_Player_Tile_Upgrade_Inside.SetActive(false);//���� �ش�� ��
        Double_Player_Tile_Upgrade_Will_No_Inside.SetActive(false);//���� �ش� �ȵ� ��

    }

    //������� �밢��
    public void Diagonal_Line_Tile_Inside()//���Ӹ� 2�� //���� �ش� ��
    {//���Ӹ� 2�� Ÿ���� Ȱ��ȭ�Ͻðڽ��ϱ�? 

        Diagonal_Line_Tile_Upgrade_Inside.SetActive(true);//���� �ش�� ��
        Diagonal_Line_Tile_Upgrade_Will_No_Inside.SetActive(false);//���� �ش� �ȵ� ��
    }

    public void Diagonal_Line_Tile_No_Inside()//���Ӹ� 2��//���� �ش� �ȵ�
    {//���Ӹ� 2�� Ÿ���� Ȱ��ȭ�Ͻðڽ��ϱ�? 

        Diagonal_Line_Tile_Upgrade_Inside.SetActive(false);//���� �ش�� ��
        Diagonal_Line_Tile_Upgrade_Will_No_Inside.SetActive(true);//���� �ش� �ȵ� ��
    }

    public void Diagonal_Line_Tile_Yes()//���� �ش�Ǵ� ���
    {//���Ӹ� 2�� Ÿ���� Ȱ��ȭ�Ͻðڽ��ϱ�? 
     //->��
        Diagonal_Line_Tile_Upgrade_Inside.SetActive(false);//���� �ش�� ��
        Diagonal_Line_Tile_Upgrade_Will_No_Inside.SetActive(false);//���� �ش� �ȵ� ��

        //���� Good�� 3�� �̻��̶��
        //���׷���Ʈ �� �� �ְ�
        Diagonal_Line_Tile[1].SetActive(false);
        Diagonal_Line_Tile[2].SetActive(true);

        for (int i = 0; i < 3; i++)
        {
            good_bad.Goood_Count_Blue--;//�� �߰�
            good_bad.Update_Good_Count_Blue();//�� �߰� ��� �ڵ�
        }

        sfx.SFX_Button();
    }

    public void Diagonal_Line_Tile_Yes_No()//���� �ش���� �ʴ� ��쿡 Yes�� ������
    {//���Ӹ� 2�� Ÿ���� Ȱ��ȭ�Ͻðڽ��ϱ�? 
     //->��
        Diagonal_Line_Tile_Upgrade_Inside.SetActive(false);//���� �ش�� ��
        Diagonal_Line_Tile_Upgrade_Will_No_Inside.SetActive(false);//���� �ش� �ȵ� ��

        //Good�� 3�� �̸��̶�� 
        //���׷��̵� �� �� ����

        No_Good.SetActive(true);
        sfx.SFX_Button();
    }

    public void Diagonal_Line_Tile_Ok()//���׷��̵� �� �� ������ Ȯ�� ��ư
    {
        No_Good.SetActive(false);
    }

    public void Diagonal_Line_Tile_No()
    {//���Ӹ� 2�� Ÿ���� Ȱ��ȭ�Ͻðڽ��ϱ�? 
     //->�ƴϿ�
     //���� ȭ������ ���ư�
        Diagonal_Line_Tile_Upgrade_Inside.SetActive(false);//���� �ش�� ��
        Diagonal_Line_Tile_Upgrade_Will_No_Inside.SetActive(false);//���� �ش� �ȵ� ��

    }

    //������� ������
    public void Vertex_Tile_Inside()//���Ӹ� 2�� //���� �ش� ��
    {//���Ӹ� 2�� Ÿ���� Ȱ��ȭ�Ͻðڽ��ϱ�? 

        Vertex_Tile_Upgrade_Inside.SetActive(true);//���� �ش�� ��
        Vertex_Tile_Upgrade_Will_No_Inside.SetActive(false);//���� �ش� �ȵ� ��
    }

    public void Vertex_Tile_No_Inside()//���Ӹ� 2��//���� �ش� �ȵ�
    {//���Ӹ� 2�� Ÿ���� Ȱ��ȭ�Ͻðڽ��ϱ�? 

        Vertex_Tile_Upgrade_Inside.SetActive(false);//���� �ش�� ��
        Vertex_Tile_Upgrade_Will_No_Inside.SetActive(true);//���� �ش� �ȵ� ��
    }

    public void Vertex_Tile_Yes()//���� �ش�Ǵ� ���
    {//���Ӹ� 2�� Ÿ���� Ȱ��ȭ�Ͻðڽ��ϱ�? 
     //->��
        Vertex_Tile_Upgrade_Inside.SetActive(false);//���� �ش�� ��
        Vertex_Tile_Upgrade_Will_No_Inside.SetActive(false);//���� �ش� �ȵ� ��

        //���� Good�� 3�� �̻��̶��
        //���׷���Ʈ �� �� �ְ�
        Vertex_Tile[1].SetActive(false);
        Vertex_Tile[2].SetActive(true);

        for (int i = 0; i < 3; i++)
        {
            good_bad.Goood_Count_Blue--;//�� �߰�
            good_bad.Update_Good_Count_Blue();//�� �߰� ��� �ڵ�
        }

        sfx.SFX_Button();
    }

    public void Vertex_Tile_Yes_No()//���� �ش���� �ʴ� ��쿡 Yes�� ������
    {//���Ӹ� 2�� Ÿ���� Ȱ��ȭ�Ͻðڽ��ϱ�? 
     //->��
        Vertex_Tile_Upgrade_Inside.SetActive(false);//���� �ش�� ��
        Vertex_Tile_Upgrade_Will_No_Inside.SetActive(false);//���� �ش� �ȵ� ��

        //Good�� 3�� �̸��̶�� 
        //���׷��̵� �� �� ����

        No_Good.SetActive(true);
        sfx.SFX_Button();
    }

    public void Vertex_Tile_Ok()//���׷��̵� �� �� ������ Ȯ�� ��ư
    {
        No_Good.SetActive(false);
    }

    public void Vertex_Tile_No()
    {//���Ӹ� 2�� Ÿ���� Ȱ��ȭ�Ͻðڽ��ϱ�? 
     //->�ƴϿ�
     //���� ȭ������ ���ư�
        Vertex_Tile_Upgrade_Inside.SetActive(false);//���� �ش�� ��
        Vertex_Tile_Upgrade_Will_No_Inside.SetActive(false);//���� �ش� �ȵ� ��

    }

    //������� �����Ƽ
    public void Speciality_Tile_Inside()//���Ӹ� 2�� //���� �ش� ��
    {//���Ӹ� 2�� Ÿ���� Ȱ��ȭ�Ͻðڽ��ϱ�? 

        Speciality_Tile_Upgrade_Inside.SetActive(true);//���� �ش�� ��
        Speciality_Tile_Upgrade_Will_No_Inside.SetActive(false);//���� �ش� �ȵ� ��
    }

    public void Speciality_Tile_No_Inside()//���Ӹ� 2��//���� �ش� �ȵ�
    {//���Ӹ� 2�� Ÿ���� Ȱ��ȭ�Ͻðڽ��ϱ�? 

        Speciality_Tile_Upgrade_Inside.SetActive(false);//���� �ش�� ��
        Speciality_Tile_Upgrade_Will_No_Inside.SetActive(true);//���� �ش� �ȵ� ��
    }

    public void Speciality_Tile_Yes()//���� �ش�Ǵ� ���
    {//���Ӹ� 2�� Ÿ���� Ȱ��ȭ�Ͻðڽ��ϱ�? 
     //->��
        Speciality_Tile_Upgrade_Inside.SetActive(false);//���� �ش�� ��
        Speciality_Tile_Upgrade_Will_No_Inside.SetActive(false);//���� �ش� �ȵ� ��

        //���� Good�� 3�� �̻��̶��
        //���׷���Ʈ �� �� �ְ�
        Speciality_Tile[1].SetActive(false);
        Speciality_Tile[2].SetActive(true);

        for (int i = 0; i < 3; i++)
        {
            good_bad.Goood_Count_Blue--;//�� �߰�
            good_bad.Update_Good_Count_Blue();//�� �߰� ��� �ڵ�
        }

        sfx.SFX_Button();
    }

    public void Speciality_Tile_Yes_No()//���� �ش���� �ʴ� ��쿡 Yes�� ������
    {//���Ӹ� 2�� Ÿ���� Ȱ��ȭ�Ͻðڽ��ϱ�? 
     //->��
        Speciality_Tile_Upgrade_Inside.SetActive(false);//���� �ش�� ��
        Speciality_Tile_Upgrade_Will_No_Inside.SetActive(false);//���� �ش� �ȵ� ��

        //Good�� 3�� �̸��̶�� 
        //���׷��̵� �� �� ����

        No_Good.SetActive(true);
        sfx.SFX_Button();
    }

    public void Speciality_Tile_Ok()//���׷��̵� �� �� ������ Ȯ�� ��ư
    {
        No_Good.SetActive(false);
    }

    public void Speciality_Tile_No()
    {//���Ӹ� 2�� Ÿ���� Ȱ��ȭ�Ͻðڽ��ϱ�? 
     //->�ƴϿ�
     //���� ȭ������ ���ư�
        Speciality_Tile_Upgrade_Inside.SetActive(false);//���� �ش�� ��
        Speciality_Tile_Upgrade_Will_No_Inside.SetActive(false);//���� �ش� �ȵ� ��

    }


    //����� ��
    //���� ��ư Ŭ�� ��
    // 1. ������ ����ϰڽ��ϱ�?
    public void Can_Use_Coin()
    {//���� �Ʒ� ���� ��ư ������ ��

        // 1) ��
        // -> ������ �� �� ����� ���� �� �� ����.
        if (good_bad.Ccoin_Count_Blue > 0)//������ 1�� �̻� �ִ� ���
        {
            Will_Use_Coin_Inside.SetActive(true);//���� ����Ұ�? //������ �ϳ��� �ִ� ���

            No_Coin.SetActive(false);
            Use_Coin.SetActive(false);

            Already_Player_Coin_Zero_Inside.SetActive(false);
            Already_Player_Coin_Not_Zero_Inside.SetActive(false);

            Will_Use_Coin_No_Coin_Inside.SetActive(false);
        }


        if (good_bad.Ccoin_Count_Blue == 0 && B_Count.Click_Count > 3)
        {
            Will_Use_Coin_No_Coin_Inside.SetActive(true);//���� ����Ұ�? //������ �ϳ��� ���� ���

            No_Coin.SetActive(false);
            Use_Coin.SetActive(false);

            Already_Player_Coin_Zero_Inside.SetActive(false);
            Already_Player_Coin_Not_Zero_Inside.SetActive(false);

            Will_Use_Coin_Inside.SetActive(false);
        }



    }

    /* public void Can_t_Use_Coin()//������ �ϳ��� ���� ���
     {//���� �Ʒ� ���� ��ư ������ ��

         // 2. ������ ����ϰڽ��ϱ�?
         // 1) ������ �ϳ��� ������
         Will_Use_Coin_No_Coin_Inside.SetActive(true);//���� ����Ұ�? //������ �ϳ��� ���� ���

         No_Coin.SetActive(false);
         Use_Coin.SetActive(false);

         Already_Player_Coin_Zero_Inside.SetActive(false);
         Already_Player_Coin_Not_Zero_Inside.SetActive(false);

         Will_Use_Coin_Inside.SetActive(false);
     }*/

    public void Use_Coin_No()//���� ������� ���� ���//���� ���� ȭ������ ���ư���
    {
        // 2) �ƴϿ�
        // -> ���� ���� ȭ������ ���ư�
        //�׳� ������ �� �� false��Ű�� ����...

        No_Coin.SetActive(false);
        Use_Coin.SetActive(false);

        Already_Player_Coin_Zero_Inside.SetActive(false);
        Already_Player_Coin_Not_Zero_Inside.SetActive(false);

        Will_Use_Coin_No_Coin_Inside.SetActive(false);
        Will_Use_Coin_Inside.SetActive(false);
    }

    public void Zero_Coin()
    {//���� ����ϰڴٴ� ��ư�� ������ ��� ������ ���� ��
        // -> ������ �����ϴ�! ���
        No_Coin.SetActive(true);

        Use_Coin.SetActive(false);

        Already_Player_Coin_Zero_Inside.SetActive(false);
        Already_Player_Coin_Not_Zero_Inside.SetActive(false);

        Will_Use_Coin_No_Coin_Inside.SetActive(false);
        Will_Use_Coin_Inside.SetActive(false);

        sfx.SFX_Button();
    }

    public void How_Much_Spend_Coin()//���� �󸶳� ����� ����
    {//���� ����ϰڴٴ� ��ư�� ������ ���
        Use_Coin.SetActive(true);

        No_Coin.SetActive(false);

        Already_Player_Coin_Zero_Inside.SetActive(false);
        Already_Player_Coin_Not_Zero_Inside.SetActive(false);

        Will_Use_Coin_No_Coin_Inside.SetActive(false);
        Will_Use_Coin_Inside.SetActive(false);

        Ccoin_Count = 0;
        Coin_Count.text = " 0" + Ccoin_Count.ToString();

        sfx.SFX_Button();
    }

    public void Plus_Coin()//����� ���� ���� �ø���
    {
        Ccoin_Count++;//Ŭ�� �� ���� ���� ������ �þ��
        Coin_Count.text = " 0" + Ccoin_Count.ToString();

        if ((Ccoin_Count > 2 || Ccoin_Count == 2) && (good_bad.Ccoin_Count_Blue > 2 || good_bad.Ccoin_Count_Blue == 2))//���� ���� ������ 3�� �̻��� ��
        {
            Ccoin_Count = 2;
            Coin_Count.text = " 0" + Ccoin_Count.ToString();
            //���� �Ʒ� �ּ���� �ϰ� �;����� ������ �� �ִ� ī��Ʈ�� 3 �̻��� �Ǹ� �ٸ� ���� ���õǴ� ������ �߻�
            //� �ڵ带 �����ؾ� �� �� ���� �̷��� �ϴ� �ɷ� �̤�

            //���� ���� ������ ���� ���� ���� �������� Ŀ���� �� �̻� ���ڰ� �������� �ʰ� �ϱ�
        }

        if (good_bad.Ccoin_Count_Blue == 1 && (Ccoin_Count > 2 || Ccoin_Count == 2 || Ccoin_Count == 1))
        {//���� ���� ������ 1���� ��
            Ccoin_Count = 1;
            Coin_Count.text = " 0" + Ccoin_Count.ToString();
        }


    }

    public void Minus_Coin()//���� ���� ���̱�
    {
        Ccoin_Count--;//���� ����
        Coin_Count.text = " 0" + Ccoin_Count.ToString();

        if (Ccoin_Count == 0 || Ccoin_Count < 0)
        {
            Ccoin_Count = 0;
            Coin_Count.text = " 0" + Ccoin_Count.ToString();
        }

        if (Ccoin_Count > 2 || Ccoin_Count == 2)
        {
            Ccoin_Count = 2;
            Coin_Count.text = " 0" + Ccoin_Count.ToString();
        }
        //Ŭ�� �� ���� ���� ������ �پ���
        //���� ���� ������ 0���� �۾����� �� �̻� ���ڰ� �پ���� �ʰ� �ϱ�
    }

    public void Use_This_Coin_Ok()//���� ������ ���ڴٰ� Ȯ�ι�ư ������ �ڵ�
    {
        //Ȯ�� ��ư�� ������
        //������ ������ŭ �÷��̾ ������ �� �ִ� ī��Ʈ ������Ű��

        //���� ������ ���ҽ�Ű��
        good_bad.Ccoin_Count_Blue = good_bad.Ccoin_Count_Blue - Ccoin_Count;//���� ���� �ٽ� ����
        //����� ��ŭ ���ҽ�Ű��
        good_bad.Update_Coin_Count_Blue();//���� �߰� ��� �ڵ�

        //�÷��̾ ������ �� �ִ� ī��Ʈ �ø���
        Can_Move_Count.Can_Move_Count = Can_Move_Count.Can_Move_Count + Ccoin_Count;
        Can_Move_Count.Update_Can_Move_Count();


        Use_Coin.SetActive(false);
        No_Coin.SetActive(false);

        Already_Player_Coin_Zero_Inside.SetActive(false);
        Already_Player_Coin_Not_Zero_Inside.SetActive(false);

        Will_Use_Coin_No_Coin_Inside.SetActive(false);
        Will_Use_Coin_Inside.SetActive(false);

        sfx.SFX_Button();


    }

    public void Already_Player_There_Coin_1()//������ �� �ִ� Ƚ���� 1�� ������ ��
    {//�÷��̾ �̹� �ٸ� ���� �ִ� ��� ĭ�� ���� �������� �� �� �����ϴ� �ڵ�

        //�� �ڵ�� Player_Move���� ������Ѿ� ��.
        //������ 1�� �̻� ���Ҵٸ�
        Already_Player_Coin_Zero_Inside.SetActive(false);
        Already_Player_Coin_Not_Zero_Inside.SetActive(true);
    }

    public void Use_One_Coin_Yes()
    {//���� 1���� ���

        Ccoin_Count = 1;

        good_bad.Ccoin_Count_Blue = good_bad.Ccoin_Count_Blue - Ccoin_Count;//���� ���� �ٽ� ����
        //����� ��ŭ ���ҽ�Ű��
        good_bad.Update_Coin_Count_Blue();//���� �߰� ��� �ڵ�

        Can_Move_Count.Can_Move_Count = Can_Move_Count.Can_Move_Count + Ccoin_Count;
        Can_Move_Count.Update_Can_Move_Count();

        No_Coin.SetActive(false);
        Use_Coin.SetActive(false);

        Already_Player_Coin_Zero_Inside.SetActive(false);
        Already_Player_Coin_Not_Zero_Inside.SetActive(false);

        Will_Use_Coin_No_Coin_Inside.SetActive(false);
        Will_Use_Coin_Inside.SetActive(false);
    }

    public void Already_Player_There_Coin_0()//������ �� �ִ� Ƚ���� 1�� ������ ��
    {//�÷��̾ �̹� �ٸ� ���� �ִ� ��� ĭ�� ���� �������� �� �� �����ϴ� �ڵ�

        //���� ������ 0�� ���Ҵٸ�
        Already_Player_Coin_Zero_Inside.SetActive(true);
        Already_Player_Coin_Not_Zero_Inside.SetActive(false);
    }

    public void No_Double_Player()
    {
        Next_Turn_No_Double_Player.SetActive(true);
    }

    public void No_Double_Player_Off()
    {
        Next_Turn_No_Double_Player.SetActive(false);
    }
}
