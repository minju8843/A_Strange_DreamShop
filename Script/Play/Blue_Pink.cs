using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Blue_Pink : MonoBehaviour
{
    public CameraZoom zoom;

    public GameObject Choose_Color;
    public GameObject Choose_Start_Color;

    public GameObject Plate;//�� ���ÿ� ���� ���� ȸ����Ű�� ���� �ʿ�
    public RectTransform plate;//�� ���ÿ� ���� ���� ȸ����Ű�� ���� �ʿ�

    public GameObject Start_Pink;//���� ��ū�� ��ũ��
    public GameObject Start_Blue;//���� ��ū�� ��翡 �־�� �ϴ���

    public Card_Move card_move;


    public GameObject[] Pink_Cups1;
    public GameObject[] Pink_Cups2;

    public GameObject[] Blue_Cups1;
    public GameObject[] Blue_Cups2;

    public Next_Turn next_turn;

    public SFX_2023 sfx;


    public GameObject blue;
    public GameObject pink;

    public Turn_Count turn_count;

    public GameObject Go_Black;
    public GameObject Go_Empty;

    public void Start()
    {
     
    }

    public void Pick_Pink()//���� �� �� ����-��ũ
    {
        Choose_Color.SetActive(false);//�� ���� ����ȭ�� �����
        Choose_Start_Color.SetActive(true);//� �� ���� ������ ���� ����ȭ�� ��Ÿ����

        sfx.SFX_Button();

    }

    public void Pink_Start()//� ������ ���� ������ ����-��ũ
    {
        //Plate.transform.Rotate(0f, 0f, 180f);

        //PC������ ����Ǵ� �ڵ��Դϴ�
        //Ȯ��, ��� �ڵ�
        /*zoom.isZoomedIn = false;//���� ���°� �ƴ�
        zoom.zoomCount = 0; //¦����°
        zoom.ZoomOut();//�� �ƿ�
        */
        zoom.ResetToOriginalSize();


        Start_Pink.SetActive(true);//���� ��ū
        Start_Blue.SetActive(false);//���� ��ū

        Pink_Cups1[0].SetActive(false);//��ũ ��
        Pink_Cups1[1].SetActive(false);
        Pink_Cups1[2].SetActive(false);

        Pink_Cups2[0].SetActive(false);//��ũ ��ȫ
        Pink_Cups2[1].SetActive(false);
        Pink_Cups2[2].SetActive(false);

        Blue_Cups1[0].SetActive(true);//��� ��
        Blue_Cups1[1].SetActive(true);
        Blue_Cups1[2].SetActive(true);

        Blue_Cups2[0].SetActive(false);//��� ���
        Blue_Cups2[1].SetActive(false);
        Blue_Cups2[2].SetActive(false);


        //Object_Place.Start_Pink();
        card_move.Start_Pink();

        StartCoroutine(Right_Pink());
        StartCoroutine(WaitSecond_1());
        StartCoroutine(WaitSecond_2());

        IEnumerator Right_Pink()
        {
            yield return new WaitForSeconds(0.0f);//0.5����

            Go_Black.SetActive(true);//����->����//���� �߰�

            //Choose_Start_Color.SetActive(false);

            next_turn.Go_Player2_B.SetActive(false);
            next_turn.Go_Player1_B.SetActive(true);

            sfx.SFX_Button();

            //0813
            blue.SetActive(true);
            pink.SetActive(false);


            //0814
            turn_count.Pink_1.SetActive(false);
            turn_count.Pink_2.SetActive(false);

            turn_count.Blue_1.SetActive(false);
            turn_count.Blue_2.SetActive(true);

        }

        IEnumerator WaitSecond_1()
        {
            yield return new WaitForSeconds(1.0f);
            Go_Empty.SetActive(true);//����->����
            Go_Black.SetActive(false);

            Choose_Start_Color.SetActive(false);//�����߰�
        }

        IEnumerator WaitSecond_2()
        {
            yield return new WaitForSeconds(2.5f);
            Go_Empty.SetActive(false);//����->����
            Go_Black.SetActive(false);
        }

    }

    public void Pick_Blue()//���� �� �� ����-���
    {

        Choose_Color.SetActive(false);//�� ���� ����ȭ�� �����
        Choose_Start_Color.SetActive(true);

        sfx.SFX_Button();

    }

    public void Blue_Start()//� ������ ���� ������ ����-���
    {
        //PC������ ����Ǵ� �ڵ��Դϴ�
        //Ȯ��, ��� �ڵ�
        /*zoom.isZoomedIn = false;//���� ���°� �ƴ�
        zoom.zoomCount = 0; //¦����°
        zoom.ZoomOut();//�� �ƿ�
        */
        zoom.ResetToOriginalSize();

        //0813
        Plate.transform.Rotate(0f, 0f, 180f);
        plate.anchoredPosition = new Vector2(0f, 12.9f);//15.6�̾��µ�...

        Start_Pink.SetActive(false);
        Start_Blue.SetActive(true);

        //��簡 ������ ���� �غ� �ÿ��� ��ũ�� ���� ���;� ��
        Pink_Cups1[0].SetActive(true);//��ũ ��
        Pink_Cups1[1].SetActive(true);//��ũ ��
        Pink_Cups1[2].SetActive(true);//��ũ ��

        Pink_Cups2[0].SetActive(false);//��ũ ��ũ
        Pink_Cups2[1].SetActive(false);//��ũ ��ũ
        Pink_Cups2[2].SetActive(false);//��ũ ��ũ

        Blue_Cups1[0].SetActive(false);//��� ��
        Blue_Cups1[1].SetActive(false);//��� ��
        Blue_Cups1[2].SetActive(false);//��� ��

        Blue_Cups2[0].SetActive(false);//��� ���
        Blue_Cups2[1].SetActive(false);//��� ���
        Blue_Cups2[2].SetActive(false);//��� ���

        //Object_Place.Start_Blue();
        card_move.Start_Blue();

        StartCoroutine(Right_Blue());
        StartCoroutine(WaitSecond_1());
        StartCoroutine(WaitSecond_2());

        IEnumerator Right_Blue()
        {
            yield return new WaitForSeconds(0.0f);//0.5����

            Go_Black.SetActive(true);//����->����

            //Choose_Start_Color.SetActive(false);

            next_turn.Go_Player1_B.SetActive(false);
            next_turn.Go_Player2_B.SetActive(true);

            sfx.SFX_Button();

            //0813
            blue.SetActive(false);
            pink.SetActive(true);

            //0814
            turn_count.Pink_1.SetActive(false);
            turn_count.Pink_2.SetActive(true);

            turn_count.Blue_1.SetActive(false);
            turn_count.Blue_2.SetActive(false);

        }

        IEnumerator WaitSecond_1()
        {
            yield return new WaitForSeconds(1.0f);
            Choose_Start_Color.SetActive(false);//�����߰�

            Go_Empty.SetActive(true);//����->����
            Go_Black.SetActive(false);
        }

        IEnumerator WaitSecond_2()
        {
            yield return new WaitForSeconds(2.5f);
            Go_Empty.SetActive(false);//����->����
            Go_Black.SetActive(false);
        }

    }
}
