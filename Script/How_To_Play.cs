using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class How_To_Play : MonoBehaviour
{
    public GameObject Open_How_To_Play;

    public GameObject Prepare_Game1;
    public GameObject Prepare_Game2;
    public GameObject Prepare_Game3;
    public GameObject Prepare_Game4;
    public GameObject Prepare_Game5;
    public GameObject Prepare_Game6;

    public GameObject Upgrade_Tile1;
    public GameObject Upgrade_Tile2;
    public GameObject Upgrade_Tile3;
    public GameObject Upgrade_Tile4;
    public GameObject Upgrade_Tile5;
    public GameObject Upgrade_Tile6;

    public GameObject Move_Player1;
    public GameObject Move_Player2;
    public GameObject Move_Player3;
    public GameObject Move_Player4;
    public GameObject Move_Player5;
    public GameObject Move_Player6;

    public GameObject Put_Material1;
    public GameObject Put_Material2;
    public GameObject Put_Material3;

    public GameObject Order_Processing1;//주문 처리
    public GameObject Order_Processing2;
    public GameObject Order_Processing3;
    public GameObject Order_Processing4;
    public GameObject Order_Processing5;
    public GameObject Order_Processing6;
    public GameObject Order_Processing7;
    public GameObject Order_Processing8;
    public GameObject Order_Processing9;

    public GameObject Conditions_Of_Victory1;//승리 조건
    public GameObject Conditions_Of_Victory2;//승리 조건
    public GameObject Conditions_Of_Victory3;//승리 조건

    public SFX_2023 sfx;

    public void Go_How_To_Play_Menu()//메뉴 칸으로 들어가기 전 6개 보여주기
    {
        sfx.SFX_Button();//버튼 소리

        Open_How_To_Play.SetActive(true);

        //나머지 오브젝트 다 비활성 상태로
        Prepare_Game1.SetActive(false);
        Prepare_Game2.SetActive(false);
        Prepare_Game3.SetActive(false);
        Prepare_Game4.SetActive(false);
        Prepare_Game5.SetActive(false);
        Prepare_Game6.SetActive(false);

        Upgrade_Tile1.SetActive(false);
        Upgrade_Tile2.SetActive(false);
        Upgrade_Tile3.SetActive(false);
        Upgrade_Tile4.SetActive(false);
        Upgrade_Tile5.SetActive(false);
        Upgrade_Tile6.SetActive(false);

        Move_Player1.SetActive(false);
        Move_Player2.SetActive(false);
        Move_Player3.SetActive(false);
        Move_Player4.SetActive(false);
        Move_Player5.SetActive(false);
        Move_Player6.SetActive(false);

        Put_Material1.SetActive(false);
        Put_Material2.SetActive(false);
        Put_Material3.SetActive(false);

        Order_Processing1.SetActive(false);
        Order_Processing2.SetActive(false);
        Order_Processing3.SetActive(false);
        Order_Processing4.SetActive(false);
        Order_Processing5.SetActive(false);
        Order_Processing6.SetActive(false);
        Order_Processing7.SetActive(false);
        Order_Processing8.SetActive(false);
        Order_Processing9.SetActive(false);

        Conditions_Of_Victory1.SetActive(false);
        Conditions_Of_Victory2.SetActive(false);
        Conditions_Of_Victory3.SetActive(false);

    }

    public void Out_How_To_Play_Menu()//메뉴 칸으로 들어가기 전 6개 사라지기
    {
        Open_How_To_Play.SetActive(false);
        //이건 게임방법 칸만 나왔을 때
        //게임방법 칸에서 벗어나고 싶으면 이 게임방법 칸만 없어지도록
    }

    public void Go_Prepare_Game_1()
    {
        Open_How_To_Play.SetActive(false);

        Prepare_Game1.SetActive(true);
        Prepare_Game2.SetActive(false);
        Prepare_Game3.SetActive(false);
        Prepare_Game4.SetActive(false);
        Prepare_Game5.SetActive(false);
        Prepare_Game6.SetActive(false);

        Upgrade_Tile1.SetActive(false);
        Upgrade_Tile2.SetActive(false);
        Upgrade_Tile3.SetActive(false);
        Upgrade_Tile4.SetActive(false);
        Upgrade_Tile5.SetActive(false);
        Upgrade_Tile6.SetActive(false);

        Move_Player1.SetActive(false);
        Move_Player2.SetActive(false);
        Move_Player3.SetActive(false);
        Move_Player4.SetActive(false);
        Move_Player5.SetActive(false);
        Move_Player6.SetActive(false);

        Put_Material1.SetActive(false);
        Put_Material2.SetActive(false);
        Put_Material3.SetActive(false);

        Order_Processing1.SetActive(false);
        Order_Processing2.SetActive(false);
        Order_Processing3.SetActive(false);
        Order_Processing4.SetActive(false);
        Order_Processing5.SetActive(false);
        Order_Processing6.SetActive(false);
        Order_Processing7.SetActive(false);
        Order_Processing8.SetActive(false);
        Order_Processing9.SetActive(false);

        Conditions_Of_Victory1.SetActive(false);
        Conditions_Of_Victory2.SetActive(false);
        Conditions_Of_Victory3.SetActive(false);
    }

    public void Go_Prepare_Game_2()
    {
        //2번째로 고고
        Prepare_Game1.SetActive(false);
        Prepare_Game2.SetActive(true);
        Prepare_Game3.SetActive(false);
        Prepare_Game4.SetActive(false);
        Prepare_Game5.SetActive(false);
        Prepare_Game6.SetActive(false);
    }

    public void Go_Prepare_Game_3()
    {
        //2번째로 고고
        Prepare_Game1.SetActive(false);
        Prepare_Game2.SetActive(false);
        Prepare_Game3.SetActive(true);
        Prepare_Game4.SetActive(false);
        Prepare_Game5.SetActive(false);
        Prepare_Game6.SetActive(false);
    }

    public void Go_Prepare_Game_4()
    {
        //2번째로 고고
        Prepare_Game1.SetActive(false);
        Prepare_Game2.SetActive(false);
        Prepare_Game3.SetActive(false);
        Prepare_Game4.SetActive(true);
        Prepare_Game5.SetActive(false);
        Prepare_Game6.SetActive(false);
    }

    public void Go_Prepare_Game_5()
    {
        //2번째로 고고
        Prepare_Game1.SetActive(false);
        Prepare_Game2.SetActive(false);
        Prepare_Game3.SetActive(false);
        Prepare_Game4.SetActive(false);
        Prepare_Game5.SetActive(true);
        Prepare_Game6.SetActive(false);
    }

    public void Go_Prepare_Game_6()
    {
        //2번째로 고고
        Prepare_Game1.SetActive(false);
        Prepare_Game2.SetActive(false);
        Prepare_Game3.SetActive(false);
        Prepare_Game4.SetActive(false);
        Prepare_Game5.SetActive(false);
        Prepare_Game6.SetActive(true);
    }

    public void Go_Upgrade_Tile_Menu_1()
    {
        Open_How_To_Play.SetActive(false);

        Prepare_Game1.SetActive(false);
        Prepare_Game2.SetActive(false);
        Prepare_Game3.SetActive(false);
        Prepare_Game4.SetActive(false);
        Prepare_Game5.SetActive(false);
        Prepare_Game6.SetActive(false);

        Upgrade_Tile1.SetActive(true);
        Upgrade_Tile2.SetActive(false);
        Upgrade_Tile3.SetActive(false);
        Upgrade_Tile4.SetActive(false);
        Upgrade_Tile5.SetActive(false);
        Upgrade_Tile6.SetActive(false);

        Move_Player1.SetActive(false);
        Move_Player2.SetActive(false);
        Move_Player3.SetActive(false);
        Move_Player4.SetActive(false);
        Move_Player5.SetActive(false);
        Move_Player6.SetActive(false);

        Put_Material1.SetActive(false);
        Put_Material2.SetActive(false);
        Put_Material3.SetActive(false);

        Order_Processing1.SetActive(false);
        Order_Processing2.SetActive(false);
        Order_Processing3.SetActive(false);
        Order_Processing4.SetActive(false);
        Order_Processing5.SetActive(false);
        Order_Processing6.SetActive(false);
        Order_Processing7.SetActive(false);
        Order_Processing8.SetActive(false);
        Order_Processing9.SetActive(false);

        Conditions_Of_Victory1.SetActive(false);
        Conditions_Of_Victory2.SetActive(false);
        Conditions_Of_Victory3.SetActive(false);
    }

    public void Go_Upgrade_Tile_Menu_2()
    {
        Upgrade_Tile1.SetActive(false);
        Upgrade_Tile2.SetActive(true);
        Upgrade_Tile3.SetActive(false);
        Upgrade_Tile4.SetActive(false);
        Upgrade_Tile5.SetActive(false);
        Upgrade_Tile6.SetActive(false);

    }

    public void Go_Upgrade_Tile_Menu_3()
    {
        Upgrade_Tile1.SetActive(false);
        Upgrade_Tile2.SetActive(false);
        Upgrade_Tile3.SetActive(true);
        Upgrade_Tile4.SetActive(false);
        Upgrade_Tile5.SetActive(false);
        Upgrade_Tile6.SetActive(false);

    }

    public void Go_Upgrade_Tile_Menu_4()
    {
        Upgrade_Tile1.SetActive(false);
        Upgrade_Tile2.SetActive(false);
        Upgrade_Tile3.SetActive(false);
        Upgrade_Tile4.SetActive(true);
        Upgrade_Tile5.SetActive(false);
        Upgrade_Tile6.SetActive(false);

    }

    public void Go_Upgrade_Tile_Menu_5()
    {
        Upgrade_Tile1.SetActive(false);
        Upgrade_Tile2.SetActive(false);
        Upgrade_Tile3.SetActive(false);
        Upgrade_Tile4.SetActive(false);
        Upgrade_Tile5.SetActive(true);
        Upgrade_Tile6.SetActive(false);

    }

    public void Go_Upgrade_Tile_Menu_6()
    {
        Upgrade_Tile1.SetActive(false);
        Upgrade_Tile2.SetActive(false);
        Upgrade_Tile3.SetActive(false);
        Upgrade_Tile4.SetActive(false);
        Upgrade_Tile5.SetActive(false);
        Upgrade_Tile6.SetActive(true);

    }

    public void Go_Move_Player_Menu_1()
    {
        Open_How_To_Play.SetActive(false);

        Prepare_Game1.SetActive(false);
        Prepare_Game2.SetActive(false);
        Prepare_Game3.SetActive(false);
        Prepare_Game4.SetActive(false);
        Prepare_Game5.SetActive(false);
        Prepare_Game6.SetActive(false);

        Upgrade_Tile1.SetActive(false);
        Upgrade_Tile2.SetActive(false);
        Upgrade_Tile3.SetActive(false);
        Upgrade_Tile4.SetActive(false);
        Upgrade_Tile5.SetActive(false);
        Upgrade_Tile6.SetActive(false);

        Move_Player1.SetActive(true);
        Move_Player2.SetActive(false);
        Move_Player3.SetActive(false);
        Move_Player4.SetActive(false);
        Move_Player5.SetActive(false);
        Move_Player6.SetActive(false);

        Put_Material1.SetActive(false);
        Put_Material2.SetActive(false);
        Put_Material3.SetActive(false);

        Order_Processing1.SetActive(false);
        Order_Processing2.SetActive(false);
        Order_Processing3.SetActive(false);
        Order_Processing4.SetActive(false);
        Order_Processing5.SetActive(false);
        Order_Processing6.SetActive(false);
        Order_Processing7.SetActive(false);
        Order_Processing8.SetActive(false);
        Order_Processing9.SetActive(false);

        Conditions_Of_Victory1.SetActive(false);
        Conditions_Of_Victory2.SetActive(false);
        Conditions_Of_Victory3.SetActive(false);
    }

    public void Go_Move_Player_Menu_2()
    {
        Move_Player1.SetActive(false);
        Move_Player2.SetActive(true);
        Move_Player3.SetActive(false);
        Move_Player4.SetActive(false);
        Move_Player5.SetActive(false);
        Move_Player6.SetActive(false);
    }

    public void Go_Move_Player_Menu_3()
    {
        Move_Player1.SetActive(false);
        Move_Player2.SetActive(false);
        Move_Player3.SetActive(true);
        Move_Player4.SetActive(false);
        Move_Player5.SetActive(false);
        Move_Player6.SetActive(false);
    }

    public void Go_Move_Player_Menu_4()
    {
        Move_Player1.SetActive(false);
        Move_Player2.SetActive(false);
        Move_Player3.SetActive(false);
        Move_Player4.SetActive(true);
        Move_Player5.SetActive(false);
        Move_Player6.SetActive(false);
    }

    public void Go_Move_Player_Menu_5()
    {
        Move_Player1.SetActive(false);
        Move_Player2.SetActive(false);
        Move_Player3.SetActive(false);
        Move_Player4.SetActive(false);
        Move_Player5.SetActive(true);
        Move_Player6.SetActive(false);
    }

    public void Go_Move_Player_Menu_6()
    {
        Move_Player1.SetActive(false);
        Move_Player2.SetActive(false);
        Move_Player3.SetActive(false);
        Move_Player4.SetActive(false);
        Move_Player5.SetActive(false);
        Move_Player6.SetActive(true);
    }

    public void Go_Put_Material_Menu_1()
    {
        Open_How_To_Play.SetActive(false);

        Prepare_Game1.SetActive(false);
        Prepare_Game2.SetActive(false);
        Prepare_Game3.SetActive(false);
        Prepare_Game4.SetActive(false);
        Prepare_Game5.SetActive(false);
        Prepare_Game6.SetActive(false);

        Upgrade_Tile1.SetActive(false);
        Upgrade_Tile2.SetActive(false);
        Upgrade_Tile3.SetActive(false);
        Upgrade_Tile4.SetActive(false);
        Upgrade_Tile5.SetActive(false);
        Upgrade_Tile6.SetActive(false);

        Move_Player1.SetActive(false);
        Move_Player2.SetActive(false);
        Move_Player3.SetActive(false);
        Move_Player4.SetActive(false);
        Move_Player5.SetActive(false);
        Move_Player6.SetActive(false);

        Put_Material1.SetActive(true);
        Put_Material2.SetActive(false);
        Put_Material3.SetActive(false);

        Order_Processing1.SetActive(false);
        Order_Processing2.SetActive(false);
        Order_Processing3.SetActive(false);
        Order_Processing4.SetActive(false);
        Order_Processing5.SetActive(false);
        Order_Processing6.SetActive(false);
        Order_Processing7.SetActive(false);
        Order_Processing8.SetActive(false);
        Order_Processing9.SetActive(false);

        Conditions_Of_Victory1.SetActive(false);
        Conditions_Of_Victory2.SetActive(false);
        Conditions_Of_Victory3.SetActive(false);
    }

    public void Go_Put_Material_Menu_2()
    {
        Put_Material1.SetActive(false);
        Put_Material2.SetActive(true);
        Put_Material3.SetActive(false);

    }

    public void Go_Put_Material_Menu_3()
    {
        Put_Material1.SetActive(false);
        Put_Material2.SetActive(false);
        Put_Material3.SetActive(true);

    }

    public void Go_Order_Processing_Menu_1()
    {
        Open_How_To_Play.SetActive(false);

        Prepare_Game1.SetActive(false);
        Prepare_Game2.SetActive(false);
        Prepare_Game3.SetActive(false);
        Prepare_Game4.SetActive(false);
        Prepare_Game5.SetActive(false);
        Prepare_Game6.SetActive(false);

        Upgrade_Tile1.SetActive(false);
        Upgrade_Tile2.SetActive(false);
        Upgrade_Tile3.SetActive(false);
        Upgrade_Tile4.SetActive(false);
        Upgrade_Tile5.SetActive(false);
        Upgrade_Tile6.SetActive(false);

        Move_Player1.SetActive(false);
        Move_Player2.SetActive(false);
        Move_Player3.SetActive(false);
        Move_Player4.SetActive(false);
        Move_Player5.SetActive(false);
        Move_Player6.SetActive(false);

        Put_Material1.SetActive(false);
        Put_Material2.SetActive(false);
        Put_Material3.SetActive(false);

        Order_Processing1.SetActive(true);
        Order_Processing2.SetActive(false);
        Order_Processing3.SetActive(false);
        Order_Processing4.SetActive(false);
        Order_Processing5.SetActive(false);
        Order_Processing6.SetActive(false);
        Order_Processing7.SetActive(false);
        Order_Processing8.SetActive(false);
        Order_Processing9.SetActive(false);

        Conditions_Of_Victory1.SetActive(false);
        Conditions_Of_Victory2.SetActive(false);
        Conditions_Of_Victory3.SetActive(false);
    }

    public void Go_Order_Processing_Menu_2()
    {
        Order_Processing1.SetActive(false);
        Order_Processing2.SetActive(true);
        Order_Processing3.SetActive(false);
        Order_Processing4.SetActive(false);
        Order_Processing5.SetActive(false);
        Order_Processing6.SetActive(false);
        Order_Processing7.SetActive(false);
        Order_Processing8.SetActive(false);
        Order_Processing9.SetActive(false);
    }

    public void Go_Order_Processing_Menu_3()
    {
        Order_Processing1.SetActive(false);
        Order_Processing2.SetActive(false);
        Order_Processing3.SetActive(true);
        Order_Processing4.SetActive(false);
        Order_Processing5.SetActive(false);
        Order_Processing6.SetActive(false);
        Order_Processing7.SetActive(false);
        Order_Processing8.SetActive(false);
        Order_Processing9.SetActive(false);
    }

    public void Go_Order_Processing_Menu_4()
    {
        Order_Processing1.SetActive(false);
        Order_Processing2.SetActive(false);
        Order_Processing3.SetActive(false);
        Order_Processing4.SetActive(true);
        Order_Processing5.SetActive(false);
        Order_Processing6.SetActive(false);
        Order_Processing7.SetActive(false);
        Order_Processing8.SetActive(false);
        Order_Processing9.SetActive(false);
    }

    public void Go_Order_Processing_Menu_5()
    {
        Order_Processing1.SetActive(false);
        Order_Processing2.SetActive(false);
        Order_Processing3.SetActive(false);
        Order_Processing4.SetActive(false);
        Order_Processing5.SetActive(true);
        Order_Processing6.SetActive(false);
        Order_Processing7.SetActive(false);
        Order_Processing8.SetActive(false);
        Order_Processing9.SetActive(false);
    }

    public void Go_Order_Processing_Menu_6()
    {
        Order_Processing1.SetActive(false);
        Order_Processing2.SetActive(false);
        Order_Processing3.SetActive(false);
        Order_Processing4.SetActive(false);
        Order_Processing5.SetActive(false);
        Order_Processing6.SetActive(true);
        Order_Processing7.SetActive(false);
        Order_Processing8.SetActive(false);
        Order_Processing9.SetActive(false);
    }

    public void Go_Order_Processing_Menu_7()
    {
        Order_Processing1.SetActive(false);
        Order_Processing2.SetActive(false);
        Order_Processing3.SetActive(false);
        Order_Processing4.SetActive(false);
        Order_Processing5.SetActive(false);
        Order_Processing6.SetActive(false);
        Order_Processing7.SetActive(true);
        Order_Processing8.SetActive(false);
        Order_Processing9.SetActive(false);
    }

    public void Go_Order_Processing_Menu_8()
    {
        Order_Processing1.SetActive(false);
        Order_Processing2.SetActive(false);
        Order_Processing3.SetActive(false);
        Order_Processing4.SetActive(false);
        Order_Processing5.SetActive(false);
        Order_Processing6.SetActive(false);
        Order_Processing7.SetActive(false);
        Order_Processing8.SetActive(true);
        Order_Processing9.SetActive(false);
    }

    public void Go_Order_Processing_Menu_9()
    {
        Order_Processing1.SetActive(false);
        Order_Processing2.SetActive(false);
        Order_Processing3.SetActive(false);
        Order_Processing4.SetActive(false);
        Order_Processing5.SetActive(false);
        Order_Processing6.SetActive(false);
        Order_Processing7.SetActive(false);
        Order_Processing8.SetActive(false);
        Order_Processing9.SetActive(true);
    }

    public void Go_Conditions_Of_Victory_Menu_1()
    {
        Open_How_To_Play.SetActive(false);

        Prepare_Game1.SetActive(false);
        Prepare_Game2.SetActive(false);
        Prepare_Game3.SetActive(false);
        Prepare_Game4.SetActive(false);
        Prepare_Game5.SetActive(false);
        Prepare_Game6.SetActive(false);

        Upgrade_Tile1.SetActive(false);
        Upgrade_Tile2.SetActive(false);
        Upgrade_Tile3.SetActive(false);
        Upgrade_Tile4.SetActive(false);
        Upgrade_Tile5.SetActive(false);
        Upgrade_Tile6.SetActive(false);

        Move_Player1.SetActive(false);
        Move_Player2.SetActive(false);
        Move_Player3.SetActive(false);
        Move_Player4.SetActive(false);
        Move_Player5.SetActive(false);
        Move_Player6.SetActive(false);

        Put_Material1.SetActive(false);
        Put_Material2.SetActive(false);
        Put_Material3.SetActive(false);

        Order_Processing1.SetActive(false);
        Order_Processing2.SetActive(false);
        Order_Processing3.SetActive(false);
        Order_Processing4.SetActive(false);
        Order_Processing5.SetActive(false);
        Order_Processing6.SetActive(false);
        Order_Processing7.SetActive(false);
        Order_Processing8.SetActive(false);
        Order_Processing9.SetActive(false);

        Conditions_Of_Victory1.SetActive(true);
        Conditions_Of_Victory2.SetActive(false);
        Conditions_Of_Victory3.SetActive(false);
    }

    public void Go_Conditions_Of_Victory_Menu_2()
    {
        Conditions_Of_Victory1.SetActive(false);
        Conditions_Of_Victory2.SetActive(true);
        Conditions_Of_Victory3.SetActive(false);
    }

    public void Go_Conditions_Of_Victory_Menu_3()
    {
        Conditions_Of_Victory1.SetActive(false);
        Conditions_Of_Victory2.SetActive(false);
        Conditions_Of_Victory3.SetActive(true);
    }
}
