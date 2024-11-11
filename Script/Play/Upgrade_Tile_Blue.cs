using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrade_Tile_Blue : MonoBehaviour
{
    // 플레이어 무브 스크립트에서 할 거
    // 만약 이동할 수 있는 횟수가 1번 남았을 때
    // 다른 말이 있는 곳으로 이동하려고 하면
    // ->이동횟수가 1회 남았습니다. 코인을 사용하시겠습니까? 출력
    // 그리고 코인을 몇 개 사용할 건지 

    public GameObject[] Double_Player_Tile;//플레이어 2개 있을 때 2배
    public GameObject[] Diagonal_Line_Tile;//대각선 이동 가능
    public GameObject[] Vertex_Tile;//꼭짓점에 있을 때 2배
    public GameObject[] Speciality_Tile;//스페셜티에 있을 때 2배

    //여기는 플레이어 2개
    public GameObject Double_Player_Tile_Upgrade;//플레이어2개 타일 업데이트 하겠습니까?
    public GameObject Double_Player_Tile_Upgrade_Inside;

    public GameObject Double_Player_Tile_Upgrade_Will_No;//플레이어2개 타일 업데이트 // 조건 해당 안되는거
    public GameObject Double_Player_Tile_Upgrade_Will_No_Inside;

    //여기는 대각선
    public GameObject Diagonal_Line_Tile_Upgrade;//대각선 이동 타일 업데이트 하겠씁니까?
    public GameObject Diagonal_Line_Tile_Upgrade_Inside;

    public GameObject Diagonal_Line_Tile_Upgrade_Will_No;
    public GameObject Diagonal_Line_Tile_Upgrade_Will_No_Inside;

    //여기는 꼭짓점 2배
    public GameObject Vertex_Tile_Upgrade;//꼭짓점에 있을 때 2배 타일 업데이트
    public GameObject Vertex_Tile_Upgrade_Inside;

    public GameObject Vertex_Tile_Upgrade_Will_No;
    public GameObject Vertex_Tile_Upgrade_Will_No_Inside;

    //여기는 스페셜티 2배
    public GameObject Speciality_Tile_Upgrade;//스페셜티에 있을 때 2배 타일 업데이트
    public GameObject Speciality_Tile_Upgrade_Inside;

    public GameObject Speciality_Tile_Upgrade_Will_No;
    public GameObject Speciality_Tile_Upgrade_Will_No_Inside;

    //코인
    //public GameObject[] Coin_Button;//코인 버튼
    public Button[] Coin_Four_Button;

    public GameObject Will_Use_Coin;//코인 사용할거? //코인이 하나라도 있는 경우
    public GameObject Will_Use_Coin_Inside;
    public GameObject Will_Use_Coin_No_Coin;//코인 사용할거? //코인이 하나도 없는 경우
    public GameObject Will_Use_Coin_No_Coin_Inside;

    public GameObject No_Coin;//코인 없으면서!
    public GameObject Use_Coin;//코인 몇 개 사용할 건데?

    public GameObject Already_Player_Coin_Zero;//다른 말이 있는 재료 칸에 말을 놓으려 하는데 코인이 0개네?
    public GameObject Already_Player_Coin_Zero_Inside;

    public GameObject Already_Player_Coin_Not_Zero;//다른 말이 있는 재료 칸에 말을 놓으려 하는데 코인이 있네?
    public GameObject Already_Player_Coin_Not_Zero_Inside;

    public Text Coin_Count;//코인 숫자
    public int Ccoin_Count;//코인 숫자

    public Turn_Count B_Count;

    public GameObject No_Good;//주문 처리한 거 3개 이상 안되면서!

    public Good_Bad good_bad;

    public Player_Move_Count Can_Move_Count;

    public GameObject Next_Turn_No_Double_Player;

    public SFX_2023 sfx;

    //이 스크립트는 업그레이드 타일 활성화를 위해 만들어진 스크립트 입니다.
    //또한 코인을 개인적으로 먼저 사용하고 싶을 때 사용하는 코드입니다.

    //경우의 수(업그레이드 타일 활성화)
    //1. 만약 <게임말 2개>업그레이드 타일을 클릭 했을 때
    // -> <게임말 2개> 타일을 업그레이드 하겠습니까?

    public void Start()
    {
        Double_Player_Tile[0].SetActive(true);//조건 안됨
        Double_Player_Tile[1].SetActive(false);//조건 충족됨
        Double_Player_Tile[2].SetActive(false);//활성화됨

        //여기부터는 대각선
        Diagonal_Line_Tile[0].SetActive(true);
        Diagonal_Line_Tile[1].SetActive(false);
        Diagonal_Line_Tile[2].SetActive(false);//활성화됨

        //여기부터는 꼭짓점 2배
        Vertex_Tile[0].SetActive(true);
        Vertex_Tile[1].SetActive(false);
        Vertex_Tile[2].SetActive(false);//활성화됨

        //여기부터 스페셜티 2배
        Speciality_Tile[0].SetActive(true);
        Speciality_Tile[1].SetActive(false);
        Speciality_Tile[2].SetActive(false);

        //코인
        //만약 핑크가 먼저라고 할 때
        //Coin_Button[0].SetActive(true);//코인이 0개
        //Coin_Button[1].SetActive(false);//코인이 1개 이상

        Will_Use_Coin_No_Coin.SetActive(true);
        Will_Use_Coin.SetActive(false);

        Already_Player_Coin_Zero.SetActive(true);//코인 없음 //재료 칸에 말 있음
        Already_Player_Coin_Not_Zero.SetActive(false);//코인 있음 //재료 칸에 말 있음


    }

    public void Update()
    {
        //코인 버튼 눌리게 & 안 눌리게 하는 거
        if (Can_Move_Count.Can_Move_Count > 0)//만약 움직일 수 있는 횟수가 1 이상이라면
        {
            //버튼 터치조차 안 되도록 하기
            Button button_0 = Coin_Four_Button[0].GetComponent<Button>();
            button_0.interactable = false;//버튼이 눌리지 않게 하는 코드

            Button button_1 = Coin_Four_Button[1].GetComponent<Button>();
            button_1.interactable = false;//버튼이 눌리지 않게 하는 코드

        }

        if (Can_Move_Count.Can_Move_Count == 0 && B_Count.Click_Count < 4)//만약 움직일 수 있는 횟수가 0이라면
        {
            //버튼 터치 되도록 하기
            Button button_0 = Coin_Four_Button[0].GetComponent<Button>();
            button_0.interactable = false;//버튼이 안 눌리게

            Button button_1 = Coin_Four_Button[1].GetComponent<Button>();
            button_1.interactable = false;//버튼이 안 눌리게

        }

        if (Can_Move_Count.Can_Move_Count == 0 && B_Count.Click_Count > 3)//만약 움직일 수 있는 횟수가 0이라면
        {
            //버튼 터치 되도록 하기
            Button button_0 = Coin_Four_Button[0].GetComponent<Button>();
            button_0.interactable = true;//버튼이 눌리게

            Button button_1 = Coin_Four_Button[1].GetComponent<Button>();
            button_1.interactable = true;//버튼이 눌리게

        }



        if (good_bad.Goood_Count_Blue > 2 && good_bad.Ccoin_Count_Blue > 0)//코인이 1개 이상
        {
            Double_Player_Tile[0].SetActive(false);
            Double_Player_Tile[1].SetActive(true);
            Double_Player_Tile_Upgrade.SetActive(true);
            Double_Player_Tile_Upgrade_Will_No.SetActive(false);

            //여기부터는 대각선
            Diagonal_Line_Tile[0].SetActive(false);
            Diagonal_Line_Tile[1].SetActive(true);
            Diagonal_Line_Tile_Upgrade.SetActive(true);
            Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

            //여기부터는 꼭짓점
            Vertex_Tile[0].SetActive(false);
            Vertex_Tile[1].SetActive(true);
            Vertex_Tile_Upgrade.SetActive(true);
            Vertex_Tile_Upgrade_Will_No.SetActive(false);

            //여기부터는 스페셜티
            Speciality_Tile[0].SetActive(false);
            Speciality_Tile[1].SetActive(true);
            Speciality_Tile_Upgrade.SetActive(true);
            Speciality_Tile_Upgrade_Will_No.SetActive(false);

            //여기부터는 코인
            //Coin_Button[0].SetActive(false);//코인이 0개
            //Coin_Button[1].SetActive(true);//코인이 1개 이상

            Will_Use_Coin_No_Coin.SetActive(false);
            Will_Use_Coin.SetActive(true);

            Already_Player_Coin_Zero.SetActive(false);//코인 없음 //재료 칸에 말 있음
            Already_Player_Coin_Not_Zero.SetActive(true);//코인 있음 //재료 칸에 말 있음
        }

        if (good_bad.Goood_Count_Blue > 2 && good_bad.Ccoin_Count_Blue == 0)//코인이 0개
        {
            Double_Player_Tile[0].SetActive(false);
            Double_Player_Tile[1].SetActive(true);
            Double_Player_Tile_Upgrade.SetActive(true);
            Double_Player_Tile_Upgrade_Will_No.SetActive(false);

            //여기부터는 대각선
            Diagonal_Line_Tile[0].SetActive(false);
            Diagonal_Line_Tile[1].SetActive(true);
            Diagonal_Line_Tile_Upgrade.SetActive(true);
            Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

            //여기부터는 꼭짓점
            Vertex_Tile[0].SetActive(false);
            Vertex_Tile[1].SetActive(true);
            Vertex_Tile_Upgrade.SetActive(true);
            Vertex_Tile_Upgrade_Will_No.SetActive(false);

            //여기부터는 스페셜티
            Speciality_Tile[0].SetActive(false);
            Speciality_Tile[1].SetActive(true);
            Speciality_Tile_Upgrade.SetActive(true);
            Speciality_Tile_Upgrade_Will_No.SetActive(false);

            //여기부터는 코인
            // Coin_Button[0].SetActive(true);//코인이 0개
            //Coin_Button[1].SetActive(false);//코인이 1개 이상

            Will_Use_Coin_No_Coin.SetActive(true);
            Will_Use_Coin.SetActive(false);

            Already_Player_Coin_Zero.SetActive(true);//코인 없음 //재료 칸에 말 있음
            Already_Player_Coin_Not_Zero.SetActive(false);//코인 있음 //재료 칸에 말 있음
        }



        if (good_bad.Goood_Count_Blue < 3 && good_bad.Ccoin_Count_Blue > 0)//코인이 1개 이상
        {
            Double_Player_Tile[0].SetActive(true);
            Double_Player_Tile[1].SetActive(false);
            Double_Player_Tile_Upgrade.SetActive(false);
            Double_Player_Tile_Upgrade_Will_No.SetActive(true);

            //여기부터는 대각선
            Diagonal_Line_Tile[0].SetActive(true);
            Diagonal_Line_Tile[1].SetActive(false);
            Diagonal_Line_Tile_Upgrade.SetActive(false);
            Diagonal_Line_Tile_Upgrade_Will_No.SetActive(true);

            //여기부터는 꼭짓점
            Vertex_Tile[0].SetActive(true);
            Vertex_Tile[1].SetActive(false);
            Vertex_Tile_Upgrade.SetActive(false);
            Vertex_Tile_Upgrade_Will_No.SetActive(true);

            //여기부터는 스페셜티
            Speciality_Tile[0].SetActive(true);
            Speciality_Tile[1].SetActive(false);
            Speciality_Tile_Upgrade.SetActive(false);
            Speciality_Tile_Upgrade_Will_No.SetActive(true);

            //여기부터는 코인
            //Coin_Button[0].SetActive(false);//코인이 0개
            //Coin_Button[1].SetActive(true);//코인이 1개 이상

            Will_Use_Coin_No_Coin.SetActive(false);
            Will_Use_Coin.SetActive(true);

            Already_Player_Coin_Zero.SetActive(false);//코인 없음 //재료 칸에 말 있음
            Already_Player_Coin_Not_Zero.SetActive(true);//코인 있음 //재료 칸에 말 있음
        }

        if (good_bad.Goood_Count_Blue < 3 && good_bad.Ccoin_Count_Blue == 0)//코인이 0개
        {
            Double_Player_Tile[0].SetActive(true);
            Double_Player_Tile[1].SetActive(false);
            Double_Player_Tile_Upgrade.SetActive(false);
            Double_Player_Tile_Upgrade_Will_No.SetActive(true);

            //여기부터는 대각선
            Diagonal_Line_Tile[0].SetActive(true);
            Diagonal_Line_Tile[1].SetActive(false);
            Diagonal_Line_Tile_Upgrade.SetActive(false);
            Diagonal_Line_Tile_Upgrade_Will_No.SetActive(true);

            //여기부터는 꼭짓점
            Vertex_Tile[0].SetActive(true);
            Vertex_Tile[1].SetActive(false);
            Vertex_Tile_Upgrade.SetActive(false);
            Vertex_Tile_Upgrade_Will_No.SetActive(true);

            //여기부터는 스페셜티
            Speciality_Tile[0].SetActive(true);
            Speciality_Tile[1].SetActive(false);
            Speciality_Tile_Upgrade.SetActive(false);
            Speciality_Tile_Upgrade_Will_No.SetActive(true);

            //여기부터는 코인
            //Coin_Button[0].SetActive(true);//코인이 0개
            //Coin_Button[1].SetActive(false);//코인이 1개 이상

            Will_Use_Coin_No_Coin.SetActive(true);
            Will_Use_Coin.SetActive(false);

            Already_Player_Coin_Zero.SetActive(true);//코인 없음 //재료 칸에 말 있음
            Already_Player_Coin_Not_Zero.SetActive(false);//코인 있음 //재료 칸에 말 있음
        }

        if ((good_bad.Goood_Count_Blue > 2 || good_bad.Goood_Count_Blue < 3) && Double_Player_Tile[2].activeSelf == true && good_bad.Ccoin_Count_Blue > 0)//코인이 1개 이상
        {
            Double_Player_Tile[2].SetActive(true);
            Double_Player_Tile_Upgrade.SetActive(false);
            Double_Player_Tile_Upgrade_Will_No.SetActive(false);

            //여기부터는 코인
            //Coin_Button[0].SetActive(false);//코인이 0개
            //Coin_Button[1].SetActive(true);//코인이 1개 이상

            Will_Use_Coin_No_Coin.SetActive(false);
            Will_Use_Coin.SetActive(true);

            Already_Player_Coin_Zero.SetActive(false);//코인 없음 //재료 칸에 말 있음
            Already_Player_Coin_Not_Zero.SetActive(true);//코인 있음 //재료 칸에 말 있음

            //경우의 수 만들어야 함
            // 1. 대각선도 참이면
            if (Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == false)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 2. 꼭짓점도 참이면
            if (Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 3. 스페셜티도 참이면
            if (Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 4. 대각선과 꼭짓점도 참이면
            if (Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 5. 대각선과 스페셜티도 참이면
            if (Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 6. 꼭짓점과 스페셜티도 참이면
            if (Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == true)
            {
                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 7. 대각선, 꼭짓점, 스페셜티가 모두 참이면
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

        if ((good_bad.Goood_Count_Blue > 2 || good_bad.Goood_Count_Blue < 3) && Double_Player_Tile[2].activeSelf == true && good_bad.Ccoin_Count_Blue == 0)//코인이 0개
        {
            Double_Player_Tile[2].SetActive(true);
            Double_Player_Tile_Upgrade.SetActive(false);
            Double_Player_Tile_Upgrade_Will_No.SetActive(false);

            //여기부터는 코인
            //Coin_Button[0].SetActive(true);//코인이 0개
            //Coin_Button[1].SetActive(false);//코인이 1개 이상

            Will_Use_Coin_No_Coin.SetActive(true);
            Will_Use_Coin.SetActive(false);

            Already_Player_Coin_Zero.SetActive(true);//코인 없음 //재료 칸에 말 있음
            Already_Player_Coin_Not_Zero.SetActive(false);//코인 있음 //재료 칸에 말 있음

            //경우의 수 만들어야 함
            // 1. 대각선도 참이면
            if (Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == false)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 2. 꼭짓점도 참이면
            if (Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 3. 스페셜티도 참이면
            if (Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 4. 대각선과 꼭짓점도 참이면
            if (Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 5. 대각선과 스페셜티도 참이면
            if (Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 6. 꼭짓점과 스페셜티도 참이면
            if (Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == true)
            {
                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 7. 대각선, 꼭짓점, 스페셜티가 모두 참이면
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

        if ((good_bad.Goood_Count_Blue > 2 || good_bad.Goood_Count_Blue < 3) && Diagonal_Line_Tile[2].activeSelf == true && good_bad.Ccoin_Count_Blue > 0)//코인이 1개 이상
        {
            //여기부터는 대각선
            Diagonal_Line_Tile[2].SetActive(true);
            Diagonal_Line_Tile_Upgrade.SetActive(false);
            Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

            //여기부터는 코인
            //Coin_Button[0].SetActive(false);//코인이 0개
            //Coin_Button[1].SetActive(true);//코인이 1개 이상

            Will_Use_Coin_No_Coin.SetActive(false);
            Will_Use_Coin.SetActive(true);

            Already_Player_Coin_Zero.SetActive(false);//코인 없음 //재료 칸에 말 있음
            Already_Player_Coin_Not_Zero.SetActive(true);//코인 있음 //재료 칸에 말 있음

            //경우의 수 만들어야 함
            // 1. 플레이어 2배도 참이면
            if (Double_Player_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 2. 꼭짓점도 참이면
            if (Double_Player_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 3. 스페셜티도 참이면
            if (Double_Player_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 4. 플레이어 2배과 꼭짓점도 참이면
            if (Double_Player_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 5. 플레이어 2배과 스페셜티도 참이면
            if (Double_Player_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 6. 꼭짓점과 스페셜티도 참이면
            if (Double_Player_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == true)
            {
                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 7. 플레이어 2배, 꼭짓점, 스페셜티가 모두 참이면
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

        if ((good_bad.Goood_Count_Blue > 2 || good_bad.Goood_Count_Blue < 3) && Diagonal_Line_Tile[2].activeSelf == true && good_bad.Ccoin_Count_Blue == 0)//코인이 0개
        {
            //여기부터는 대각선
            Diagonal_Line_Tile[2].SetActive(true);
            Diagonal_Line_Tile_Upgrade.SetActive(false);
            Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

            //여기부터는 코인
            // Coin_Button[0].SetActive(true);//코인이 0개
            //Coin_Button[1].SetActive(false);//코인이 1개 이상

            Will_Use_Coin_No_Coin.SetActive(true);
            Will_Use_Coin.SetActive(false);

            Already_Player_Coin_Zero.SetActive(true);//코인 없음 //재료 칸에 말 있음
            Already_Player_Coin_Not_Zero.SetActive(false);//코인 있음 //재료 칸에 말 있음

            //경우의 수 만들어야 함
            // 1. 플레이어 2배도 참이면
            if (Double_Player_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 2. 꼭짓점도 참이면
            if (Double_Player_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 3. 스페셜티도 참이면
            if (Double_Player_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 4. 플레이어 2배과 꼭짓점도 참이면
            if (Double_Player_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 5. 플레이어 2배과 스페셜티도 참이면
            if (Double_Player_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 6. 꼭짓점과 스페셜티도 참이면
            if (Double_Player_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == true)
            {
                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 7. 플레이어 2배, 꼭짓점, 스페셜티가 모두 참이면
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

        if ((good_bad.Goood_Count_Blue > 2 || good_bad.Goood_Count_Blue < 3) && Vertex_Tile[2].activeSelf == true && good_bad.Ccoin_Count_Blue > 0)//코인이 1개 이상
        {
            //여기부터는 꼭짓점
            Vertex_Tile[2].SetActive(true);
            Vertex_Tile_Upgrade.SetActive(false);
            Vertex_Tile_Upgrade_Will_No.SetActive(false);

            //여기부터는 코인
            //Coin_Button[0].SetActive(false);//코인이 0개
            //Coin_Button[1].SetActive(true);//코인이 1개 이상

            Will_Use_Coin_No_Coin.SetActive(false);
            Will_Use_Coin.SetActive(true);

            Already_Player_Coin_Zero.SetActive(false);//코인 없음 //재료 칸에 말 있음
            Already_Player_Coin_Not_Zero.SetActive(true);//코인 있음 //재료 칸에 말 있음

            //경우의 수 만들어야 함
            // 1. 플레이어 2배도 참이면
            if (Double_Player_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 2. 대각선도 참이면
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 3. 스페셜티도 참이면
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 4. 플레이어 2배과 대각선도 참이면
            if (Double_Player_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 5. 플레이어 2배과 스페셜티도 참이면
            if (Diagonal_Line_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 6. 대각선과 스페셜티도 참이면
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == true)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 7. 플레이어 2배, 대각선, 스페셜티가 모두 참이면
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

        if ((good_bad.Goood_Count_Blue > 2 || good_bad.Goood_Count_Blue < 3) && Vertex_Tile[2].activeSelf == true && good_bad.Ccoin_Count_Blue == 0)//코인이 0개
        {
            //여기부터는 꼭짓점
            Vertex_Tile[2].SetActive(true);
            Vertex_Tile_Upgrade.SetActive(false);
            Vertex_Tile_Upgrade_Will_No.SetActive(false);

            //여기부터는 코인
            // Coin_Button[0].SetActive(true);//코인이 0개
            // Coin_Button[1].SetActive(false);//코인이 1개 이상

            Will_Use_Coin_No_Coin.SetActive(true);
            Will_Use_Coin.SetActive(false);

            Already_Player_Coin_Zero.SetActive(true);//코인 없음 //재료 칸에 말 있음
            Already_Player_Coin_Not_Zero.SetActive(false);//코인 있음 //재료 칸에 말 있음

            //경우의 수 만들어야 함
            // 1. 플레이어 2배도 참이면
            if (Double_Player_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 2. 대각선도 참이면
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 3. 스페셜티도 참이면
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 4. 플레이어 2배과 대각선도 참이면
            if (Double_Player_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 5. 플레이어 2배과 스페셜티도 참이면
            if (Diagonal_Line_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == false && Speciality_Tile[2].activeSelf == true)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 6. 대각선과 스페셜티도 참이면
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == true && Speciality_Tile[2].activeSelf == true)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Speciality_Tile[2].SetActive(true);
                Speciality_Tile_Upgrade.SetActive(false);
                Speciality_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 7. 플레이어 2배, 대각선, 스페셜티가 모두 참이면
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

        if ((good_bad.Goood_Count_Blue > 2 || good_bad.Goood_Count_Blue < 3) && Speciality_Tile[2].activeSelf == true && good_bad.Ccoin_Count_Blue > 0)//코인이 1개 이상
        {
            //여기부터는 스페셜티
            Speciality_Tile[2].SetActive(true);
            Speciality_Tile_Upgrade.SetActive(false);
            Speciality_Tile_Upgrade_Will_No.SetActive(false);

            //여기부터는 코인
            //Coin_Button[0].SetActive(false);//코인이 0개
            //Coin_Button[1].SetActive(true);//코인이 1개 이상

            Will_Use_Coin_No_Coin.SetActive(false);
            Will_Use_Coin.SetActive(true);

            Already_Player_Coin_Zero.SetActive(false);//코인 없음 //재료 칸에 말 있음
            Already_Player_Coin_Not_Zero.SetActive(true);//코인 있음 //재료 칸에 말 있음

            //경우의 수 만들어야 함
            // 1. 플레이어 2배도 참이면
            if (Double_Player_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 2. 대각선도 참이면
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 3. 꼭짓점 참이면
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true)
            {
                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 4. 플레이어 2배과 대각선도 참이면
            if (Double_Player_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 5. 플레이어 2배과 꼭짓점도 참이면
            if (Diagonal_Line_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 6. 대각선과 꼭짓점도 참이면
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == true)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 7. 플레이어 2배, 대각선, 꼭짓점가 모두 참이면
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

        if ((good_bad.Goood_Count_Blue > 2 || good_bad.Goood_Count_Blue < 3) && Speciality_Tile[2].activeSelf == true && good_bad.Ccoin_Count_Blue == 0)//코인이 0개
        {
            //여기부터는 스페셜티
            Speciality_Tile[2].SetActive(true);
            Speciality_Tile_Upgrade.SetActive(false);
            Speciality_Tile_Upgrade_Will_No.SetActive(false);

            //여기부터는 코인
            // Coin_Button[0].SetActive(true);//코인이 0개
            // Coin_Button[1].SetActive(false);//코인이 1개 이상

            Will_Use_Coin_No_Coin.SetActive(true);
            Will_Use_Coin.SetActive(false);

            Already_Player_Coin_Zero.SetActive(true);//코인 없음 //재료 칸에 말 있음
            Already_Player_Coin_Not_Zero.SetActive(false);//코인 있음 //재료 칸에 말 있음

            //경우의 수 만들어야 함
            // 1. 플레이어 2배도 참이면
            if (Double_Player_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 2. 대각선도 참이면
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 3. 꼭짓점 참이면
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true)
            {
                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 4. 플레이어 2배과 대각선도 참이면
            if (Double_Player_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == false)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 5. 플레이어 2배과 꼭짓점도 참이면
            if (Diagonal_Line_Tile[2].activeSelf == true && Diagonal_Line_Tile[2].activeSelf == false && Vertex_Tile[2].activeSelf == true)
            {
                Double_Player_Tile[2].SetActive(true);
                Double_Player_Tile_Upgrade.SetActive(false);
                Double_Player_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 6. 대각선과 꼭짓점도 참이면
            if (Double_Player_Tile[2].activeSelf == false && Diagonal_Line_Tile[2].activeSelf == true && Vertex_Tile[2].activeSelf == true)
            {
                Diagonal_Line_Tile[2].SetActive(true);
                Diagonal_Line_Tile_Upgrade.SetActive(false);
                Diagonal_Line_Tile_Upgrade_Will_No.SetActive(false);

                Vertex_Tile[2].SetActive(true);
                Vertex_Tile_Upgrade.SetActive(false);
                Vertex_Tile_Upgrade_Will_No.SetActive(false);
            }

            // 7. 플레이어 2배, 대각선, 꼭짓점가 모두 참이면
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


    public void Upgrade_Double_Player_Tile_Inside()//게임말 2개 //조건 해당 됨
    {//게임말 2배 타일을 활성화하시겠습니까? 

        Double_Player_Tile_Upgrade_Inside.SetActive(true);//조건 해당될 떄
        Double_Player_Tile_Upgrade_Will_No_Inside.SetActive(false);//조건 해당 안될 때
    }

    public void Upgrade_Double_Player_Tile_No_Inside()//게임말 2개//조건 해당 안됨
    {//게임말 2배 타일을 활성화하시겠습니까? 

        Double_Player_Tile_Upgrade_Inside.SetActive(false);//조건 해당될 떄
        Double_Player_Tile_Upgrade_Will_No_Inside.SetActive(true);//조건 해당 안될 때
    }

    public void Upgrade_Double_Player_Tile_Yes()//조건 해당되는 경우
    {//게임말 2배 타일을 활성화하시겠습니까? 
     //->네
        Double_Player_Tile_Upgrade_Inside.SetActive(false);//조건 해당될 떄
        Double_Player_Tile_Upgrade_Will_No_Inside.SetActive(false);//조건 해당 안될 때

        //만약 Good이 3개 이상이라면
        //업그레이트 할 수 있고
        Double_Player_Tile[1].SetActive(false);
        Double_Player_Tile[2].SetActive(true);

        for (int i = 0; i < 3; i++)
        {
            good_bad.Goood_Count_Blue--;//굿 추가
            good_bad.Update_Good_Count_Blue();//굿 추가 출력 코드
        }
        sfx.SFX_Button();
    }

    public void Upgrade_Double_Player_Tile_Yes_No()//조건 해당되지 않는 경우에 Yes를 누르면
    {//게임말 2배 타일을 활성화하시겠습니까? 
     //->네
        Double_Player_Tile_Upgrade_Inside.SetActive(false);//조건 해당될 떄
        Double_Player_Tile_Upgrade_Will_No_Inside.SetActive(false);//조건 해당 안될 때

        //Good이 3개 미만이라면 
        //업그레이드 할 수 없다

        No_Good.SetActive(true);
        sfx.SFX_Button();
    }

    public void You_Not_Double_Player_Tile_Ok()//업그레이드 할 수 없다의 확인 버튼
    {
        No_Good.SetActive(false);
    }

    public void Upgrade_Double_Player_Tile_No()
    {//게임말 2배 타일을 활성화하시겠습니까? 
     //->아니오
     //원래 화면으로 돌아감
        Double_Player_Tile_Upgrade_Inside.SetActive(false);//조건 해당될 떄
        Double_Player_Tile_Upgrade_Will_No_Inside.SetActive(false);//조건 해당 안될 때

    }

    //여기부터 대각선
    public void Diagonal_Line_Tile_Inside()//게임말 2개 //조건 해당 됨
    {//게임말 2배 타일을 활성화하시겠습니까? 

        Diagonal_Line_Tile_Upgrade_Inside.SetActive(true);//조건 해당될 떄
        Diagonal_Line_Tile_Upgrade_Will_No_Inside.SetActive(false);//조건 해당 안될 때
    }

    public void Diagonal_Line_Tile_No_Inside()//게임말 2개//조건 해당 안됨
    {//게임말 2배 타일을 활성화하시겠습니까? 

        Diagonal_Line_Tile_Upgrade_Inside.SetActive(false);//조건 해당될 떄
        Diagonal_Line_Tile_Upgrade_Will_No_Inside.SetActive(true);//조건 해당 안될 때
    }

    public void Diagonal_Line_Tile_Yes()//조건 해당되는 경우
    {//게임말 2배 타일을 활성화하시겠습니까? 
     //->네
        Diagonal_Line_Tile_Upgrade_Inside.SetActive(false);//조건 해당될 떄
        Diagonal_Line_Tile_Upgrade_Will_No_Inside.SetActive(false);//조건 해당 안될 때

        //만약 Good이 3개 이상이라면
        //업그레이트 할 수 있고
        Diagonal_Line_Tile[1].SetActive(false);
        Diagonal_Line_Tile[2].SetActive(true);

        for (int i = 0; i < 3; i++)
        {
            good_bad.Goood_Count_Blue--;//굿 추가
            good_bad.Update_Good_Count_Blue();//굿 추가 출력 코드
        }

        sfx.SFX_Button();
    }

    public void Diagonal_Line_Tile_Yes_No()//조건 해당되지 않는 경우에 Yes를 누르면
    {//게임말 2배 타일을 활성화하시겠습니까? 
     //->네
        Diagonal_Line_Tile_Upgrade_Inside.SetActive(false);//조건 해당될 떄
        Diagonal_Line_Tile_Upgrade_Will_No_Inside.SetActive(false);//조건 해당 안될 때

        //Good이 3개 미만이라면 
        //업그레이드 할 수 없다

        No_Good.SetActive(true);
        sfx.SFX_Button();
    }

    public void Diagonal_Line_Tile_Ok()//업그레이드 할 수 없다의 확인 버튼
    {
        No_Good.SetActive(false);
    }

    public void Diagonal_Line_Tile_No()
    {//게임말 2배 타일을 활성화하시겠습니까? 
     //->아니오
     //원래 화면으로 돌아감
        Diagonal_Line_Tile_Upgrade_Inside.SetActive(false);//조건 해당될 떄
        Diagonal_Line_Tile_Upgrade_Will_No_Inside.SetActive(false);//조건 해당 안될 때

    }

    //여기부터 꼭짓점
    public void Vertex_Tile_Inside()//게임말 2개 //조건 해당 됨
    {//게임말 2배 타일을 활성화하시겠습니까? 

        Vertex_Tile_Upgrade_Inside.SetActive(true);//조건 해당될 떄
        Vertex_Tile_Upgrade_Will_No_Inside.SetActive(false);//조건 해당 안될 때
    }

    public void Vertex_Tile_No_Inside()//게임말 2개//조건 해당 안됨
    {//게임말 2배 타일을 활성화하시겠습니까? 

        Vertex_Tile_Upgrade_Inside.SetActive(false);//조건 해당될 떄
        Vertex_Tile_Upgrade_Will_No_Inside.SetActive(true);//조건 해당 안될 때
    }

    public void Vertex_Tile_Yes()//조건 해당되는 경우
    {//게임말 2배 타일을 활성화하시겠습니까? 
     //->네
        Vertex_Tile_Upgrade_Inside.SetActive(false);//조건 해당될 떄
        Vertex_Tile_Upgrade_Will_No_Inside.SetActive(false);//조건 해당 안될 때

        //만약 Good이 3개 이상이라면
        //업그레이트 할 수 있고
        Vertex_Tile[1].SetActive(false);
        Vertex_Tile[2].SetActive(true);

        for (int i = 0; i < 3; i++)
        {
            good_bad.Goood_Count_Blue--;//굿 추가
            good_bad.Update_Good_Count_Blue();//굿 추가 출력 코드
        }

        sfx.SFX_Button();
    }

    public void Vertex_Tile_Yes_No()//조건 해당되지 않는 경우에 Yes를 누르면
    {//게임말 2배 타일을 활성화하시겠습니까? 
     //->네
        Vertex_Tile_Upgrade_Inside.SetActive(false);//조건 해당될 떄
        Vertex_Tile_Upgrade_Will_No_Inside.SetActive(false);//조건 해당 안될 때

        //Good이 3개 미만이라면 
        //업그레이드 할 수 없다

        No_Good.SetActive(true);
        sfx.SFX_Button();
    }

    public void Vertex_Tile_Ok()//업그레이드 할 수 없다의 확인 버튼
    {
        No_Good.SetActive(false);
    }

    public void Vertex_Tile_No()
    {//게임말 2배 타일을 활성화하시겠습니까? 
     //->아니오
     //원래 화면으로 돌아감
        Vertex_Tile_Upgrade_Inside.SetActive(false);//조건 해당될 떄
        Vertex_Tile_Upgrade_Will_No_Inside.SetActive(false);//조건 해당 안될 때

    }

    //여기부터 스페셜티
    public void Speciality_Tile_Inside()//게임말 2개 //조건 해당 됨
    {//게임말 2배 타일을 활성화하시겠습니까? 

        Speciality_Tile_Upgrade_Inside.SetActive(true);//조건 해당될 떄
        Speciality_Tile_Upgrade_Will_No_Inside.SetActive(false);//조건 해당 안될 때
    }

    public void Speciality_Tile_No_Inside()//게임말 2개//조건 해당 안됨
    {//게임말 2배 타일을 활성화하시겠습니까? 

        Speciality_Tile_Upgrade_Inside.SetActive(false);//조건 해당될 떄
        Speciality_Tile_Upgrade_Will_No_Inside.SetActive(true);//조건 해당 안될 때
    }

    public void Speciality_Tile_Yes()//조건 해당되는 경우
    {//게임말 2배 타일을 활성화하시겠습니까? 
     //->네
        Speciality_Tile_Upgrade_Inside.SetActive(false);//조건 해당될 떄
        Speciality_Tile_Upgrade_Will_No_Inside.SetActive(false);//조건 해당 안될 때

        //만약 Good이 3개 이상이라면
        //업그레이트 할 수 있고
        Speciality_Tile[1].SetActive(false);
        Speciality_Tile[2].SetActive(true);

        for (int i = 0; i < 3; i++)
        {
            good_bad.Goood_Count_Blue--;//굿 추가
            good_bad.Update_Good_Count_Blue();//굿 추가 출력 코드
        }

        sfx.SFX_Button();
    }

    public void Speciality_Tile_Yes_No()//조건 해당되지 않는 경우에 Yes를 누르면
    {//게임말 2배 타일을 활성화하시겠습니까? 
     //->네
        Speciality_Tile_Upgrade_Inside.SetActive(false);//조건 해당될 떄
        Speciality_Tile_Upgrade_Will_No_Inside.SetActive(false);//조건 해당 안될 때

        //Good이 3개 미만이라면 
        //업그레이드 할 수 없다

        No_Good.SetActive(true);
        sfx.SFX_Button();
    }

    public void Speciality_Tile_Ok()//업그레이드 할 수 없다의 확인 버튼
    {
        No_Good.SetActive(false);
    }

    public void Speciality_Tile_No()
    {//게임말 2배 타일을 활성화하시겠습니까? 
     //->아니오
     //원래 화면으로 돌아감
        Speciality_Tile_Upgrade_Inside.SetActive(false);//조건 해당될 떄
        Speciality_Tile_Upgrade_Will_No_Inside.SetActive(false);//조건 해당 안될 때

    }


    //경우의 수
    //코인 버튼 클릭 시
    // 1. 코인을 사용하겠습니까?
    public void Can_Use_Coin()
    {//왼쪽 아래 코인 버튼 눌렀을 때

        // 1) 예
        // -> 코인을 몇 개 사용할 건지 볼 수 있음.
        if (good_bad.Ccoin_Count_Blue > 0)//코인이 1개 이상 있는 경우
        {
            Will_Use_Coin_Inside.SetActive(true);//코인 사용할거? //코인이 하나라도 있는 경우

            No_Coin.SetActive(false);
            Use_Coin.SetActive(false);

            Already_Player_Coin_Zero_Inside.SetActive(false);
            Already_Player_Coin_Not_Zero_Inside.SetActive(false);

            Will_Use_Coin_No_Coin_Inside.SetActive(false);
        }


        if (good_bad.Ccoin_Count_Blue == 0 && B_Count.Click_Count > 3)
        {
            Will_Use_Coin_No_Coin_Inside.SetActive(true);//코인 사용할거? //코인이 하나도 없는 경우

            No_Coin.SetActive(false);
            Use_Coin.SetActive(false);

            Already_Player_Coin_Zero_Inside.SetActive(false);
            Already_Player_Coin_Not_Zero_Inside.SetActive(false);

            Will_Use_Coin_Inside.SetActive(false);
        }



    }

    /* public void Can_t_Use_Coin()//코인이 하나도 없는 경우
     {//왼쪽 아래 코인 버튼 눌렀을 때

         // 2. 코인을 사용하겠습니까?
         // 1) 코인이 하나도 없으면
         Will_Use_Coin_No_Coin_Inside.SetActive(true);//코인 사용할거? //코인이 하나도 없는 경우

         No_Coin.SetActive(false);
         Use_Coin.SetActive(false);

         Already_Player_Coin_Zero_Inside.SetActive(false);
         Already_Player_Coin_Not_Zero_Inside.SetActive(false);

         Will_Use_Coin_Inside.SetActive(false);
     }*/

    public void Use_Coin_No()//코인 사용하지 않을 경우//원래 게임 화면으로 돌아가기
    {
        // 2) 아니오
        // -> 원래 게임 화면으로 돌아감
        //그냥 나오는 거 다 false시키고 있음...

        No_Coin.SetActive(false);
        Use_Coin.SetActive(false);

        Already_Player_Coin_Zero_Inside.SetActive(false);
        Already_Player_Coin_Not_Zero_Inside.SetActive(false);

        Will_Use_Coin_No_Coin_Inside.SetActive(false);
        Will_Use_Coin_Inside.SetActive(false);
    }

    public void Zero_Coin()
    {//코인 사용하겠다는 버튼을 눌렀을 경우 코인이 없을 때
        // -> 코인이 없습니다! 출력
        No_Coin.SetActive(true);

        Use_Coin.SetActive(false);

        Already_Player_Coin_Zero_Inside.SetActive(false);
        Already_Player_Coin_Not_Zero_Inside.SetActive(false);

        Will_Use_Coin_No_Coin_Inside.SetActive(false);
        Will_Use_Coin_Inside.SetActive(false);

        sfx.SFX_Button();
    }

    public void How_Much_Spend_Coin()//코인 얼마나 사용할 건지
    {//코인 사용하겠다는 버튼을 눌렀을 경우
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

    public void Plus_Coin()//사용할 코인 개수 늘리기
    {
        Ccoin_Count++;//클릭 할 수록 코인 개수가 늘어나고
        Coin_Count.text = " 0" + Ccoin_Count.ToString();

        if ((Ccoin_Count > 2 || Ccoin_Count == 2) && (good_bad.Ccoin_Count_Blue > 2 || good_bad.Ccoin_Count_Blue == 2))//실제 동전 개수가 3개 이상일 때
        {
            Ccoin_Count = 2;
            Coin_Count.text = " 0" + Ccoin_Count.ToString();
            //원래 아래 주석대로 하고 싶었으나 움직일 수 있는 카운트가 3 이상이 되면 다른 말도 선택되는 문제가 발생
            //어떤 코드를 수정해야 할 지 몰라서 이렇게 하는 걸로 ㅜㅠ

            //만약 코인 개수가 현재 나의 코인 개수보다 커지면 더 이상 숫자가 증가하지 않게 하기
        }

        if (good_bad.Ccoin_Count_Blue == 1 && (Ccoin_Count > 2 || Ccoin_Count == 2 || Ccoin_Count == 1))
        {//실제 동전 개수가 1개일 때
            Ccoin_Count = 1;
            Coin_Count.text = " 0" + Ccoin_Count.ToString();
        }


    }

    public void Minus_Coin()//코인 개수 줄이기
    {
        Ccoin_Count--;//코인 감소
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
        //클릭 할 수록 코인 개수가 줄어들고
        //만약 코인 개수가 0보다 작아지면 더 이상 숫자가 줄어들지 않게 하기
    }

    public void Use_This_Coin_Ok()//코인 이정도 쓰겠다고 확인버튼 누르는 코드
    {
        //확인 버튼을 누르면
        //코인의 개수만큼 플레이어가 움직일 수 있는 카운트 증가시키기

        //코인 개수는 감소시키기
        good_bad.Ccoin_Count_Blue = good_bad.Ccoin_Count_Blue - Ccoin_Count;//코인 개수 다시 정정
        //사용한 만큼 감소시키기
        good_bad.Update_Coin_Count_Blue();//코인 추가 출력 코드

        //플레이어가 움직일 수 있는 카운트 늘리기
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

    public void Already_Player_There_Coin_1()//움직일 수 있는 횟수가 1번 남았을 때
    {//플레이어가 이미 다른 말이 있는 재료 칸에 말을 놓으려고 할 때 실행하는 코드

        //이 코드는 Player_Move에서 실행시켜야 함.
        //코인이 1개 이상 남았다면
        Already_Player_Coin_Zero_Inside.SetActive(false);
        Already_Player_Coin_Not_Zero_Inside.SetActive(true);
    }

    public void Use_One_Coin_Yes()
    {//코인 1개만 사용

        Ccoin_Count = 1;

        good_bad.Ccoin_Count_Blue = good_bad.Ccoin_Count_Blue - Ccoin_Count;//코인 개수 다시 정정
        //사용한 만큼 감소시키기
        good_bad.Update_Coin_Count_Blue();//코인 추가 출력 코드

        Can_Move_Count.Can_Move_Count = Can_Move_Count.Can_Move_Count + Ccoin_Count;
        Can_Move_Count.Update_Can_Move_Count();

        No_Coin.SetActive(false);
        Use_Coin.SetActive(false);

        Already_Player_Coin_Zero_Inside.SetActive(false);
        Already_Player_Coin_Not_Zero_Inside.SetActive(false);

        Will_Use_Coin_No_Coin_Inside.SetActive(false);
        Will_Use_Coin_Inside.SetActive(false);
    }

    public void Already_Player_There_Coin_0()//움직일 수 있는 횟수가 1번 남았을 때
    {//플레이어가 이미 다른 말이 있는 재료 칸에 말을 놓으려고 할 때 실행하는 코드

        //만약 코인이 0개 남았다면
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
