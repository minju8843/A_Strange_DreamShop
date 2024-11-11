using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card_Move : MonoBehaviour
{
    //카드 배치하는 곳
    //빨강
    public Transform[] Pink_First_Line;
    public Transform[] Pink_Second_Line;
    public Transform[] Pink_Third_Line;
    public Transform[] Pink_Fourth_Line;


    //파랑
    public Transform[] Blue_First_Line;
    public Transform[] Blue_Second_Line;
    public Transform[] Blue_Third_Line;
    public Transform[] Blue_Fourth_Line;


    //메뉴 카드 80개
    public GameObject[] Menu_Card;


    public Text cardCountText; // UI Text 컴포넌트를 가리키는 변수
    public List<GameObject> usedCards = new List<GameObject>(); // 사용한 카드를 담을 리스트
    public int usedCardCount = 0; // 사용한 카드 개수

    private List<int> availableCardIndices; // 사용 가능한 카드 인덱스를 담을 리스트


    // 시작할 때 사용 가능한 카드 인덱스를 초기화하고 섞는다
    private void InitializeAvailableCardIndices()
    {
        availableCardIndices = new List<int>();//availableCardIndices라는 정수 리스트를 만듦
        //사용 가능한 카드 인덱스들을 담을 예정

        for (int i = 0; i < Menu_Card.Length; i++)//0부터 배열의 길이까지 반복
        {
            availableCardIndices.Add(i);//for문을 반복하면서 i값을 리스트에 추가
            //이걸 하면서 카드 인덱스를 나타내는 리스트가 되는 거임
        }
        ShuffleAvailableCardIndices();
        //카드들을 섞기 위한 함수 호출
    }

    // 사용 가능한 카드 인덱스 리스트를 Fisher-Yates 알고리즘을 사용하여 섞음
    //Fisher-Yates 알고리즘 기억하면 좋을듯
    //야아악간 이해하기 힘들다
    private void ShuffleAvailableCardIndices()
    {
        int n = availableCardIndices.Count;//현재 카드의 개수를 n에 저장
        while (n > 1)
        {
            n--;//리스트에서 무작위로 선택할 범위를 줄이기 위해 사용
            int k = Random.Range(0, n + 1);//리스트에서 무작위로 선택할 요소의 인덱스를 결정
            int value = availableCardIndices[k];//리스트에서 무작위로 선택된 요소의 값을 임시로 보관
            availableCardIndices[k] = availableCardIndices[n];//리스트에서 무작위로 선택된 요소가 
            //남아있는 요소 중 가장 마지막 요소와 자리를 바꿈
            availableCardIndices[n] = value;//n인덱스에 있는 요소를 value값으로 교환
            //무작위로 선택된 요소가 리스트 마지막으로 이동
        }
        //while문 반복하면서 무작위로 선택되는 범위가 좁아지면서 리스트가 무작위로 재배치됨
    }

    // 사용 가능한 카드 인덱스 리스트에서 무작위로 하나의 카드 인덱스를 선택하고 해당 인덱스를 리스트에서 제거합니다.
    public int GetRandomCardIndex()//중복 선택 방지 콛
    {
        int randomIndex = availableCardIndices[0];//인덱스의 첫 번째 요소를 변수에 저장
        availableCardIndices.RemoveAt(0);//리스트에서 첫 번째 요소를 제거
        //이렇게 해서 아에서 선택한 카드의 인덱스가 리스트에서 빠지게 됨
        return randomIndex;
    }

    // Start 함수에서 사용 가능한 카드 인덱스 리스트를 설정하고 섞습니다.
    void Start()
    {
        InitializeAvailableCardIndices();
    }

    public void Start_Pink()
    {
        int randomIndex0 = GetRandomCardIndex();
        int randomIndex1 = GetRandomCardIndex();
        int randomIndex2 = GetRandomCardIndex();

        

        //파랑
        int randomIndex0_1 = GetRandomCardIndex();
        int randomIndex1_1 = GetRandomCardIndex();

        // 첫 번째 라인에 첫 번째 카드를 자식으로 추가
        GameObject cardObject0 = Instantiate(Menu_Card[randomIndex0], Pink_First_Line[0]);
        cardObject0.transform.localPosition = Vector3.zero;
        cardObject0.transform.localRotation = Quaternion.identity;

        // 두 번째 라인에 두 번째 카드를 자식으로 추가
        GameObject cardObject1 = Instantiate(Menu_Card[randomIndex1], Pink_Second_Line[0]);
        cardObject1.transform.localPosition = Vector3.zero;
        cardObject1.transform.localRotation = Quaternion.identity;

        GameObject cardObject2 = Instantiate(Menu_Card[randomIndex2], Pink_First_Line[1]);
        cardObject2.transform.localPosition = Vector3.zero;
        cardObject2.transform.localRotation = Quaternion.identity;

        


        //파랑
        // 첫 번째 라인에 첫 번째 카드를 자식으로 추가
        GameObject cardObject0_1 = Instantiate(Menu_Card[randomIndex0_1], Blue_First_Line[0]);
        cardObject0_1.transform.localPosition = Vector3.zero;
        cardObject0_1.transform.localRotation = Quaternion.identity;

        // 두 번째 라인에 두 번째 카드를 자식으로 추가
        GameObject cardObject1_1 = Instantiate(Menu_Card[randomIndex1_1], Blue_Second_Line[0]);
        cardObject1_1.transform.localPosition = Vector3.zero;
        cardObject1_1.transform.localRotation = Quaternion.identity;

        // 사용한 카드를 리스트에 추가하고 사용한 카드 개수를 증가시킴
        usedCards.Add(cardObject0_1);
        usedCards.Add(cardObject1_1);
        
        usedCards.Add(cardObject0);
        usedCards.Add(cardObject1);
        usedCards.Add(cardObject2);

       


        usedCardCount = usedCards.Count;

        // 카드 개수를 업데이트하고 UI Text에 표시
        UpdateCardCountText();
    }

    public void Start_Blue()
    {
        int randomIndex0_1 = GetRandomCardIndex();
        int randomIndex1_1 = GetRandomCardIndex();
        int randomIndex2_1 = GetRandomCardIndex();

        int randomIndex0 = GetRandomCardIndex();
        int randomIndex1 = GetRandomCardIndex();

        // 첫 번째 라인에 첫 번째 카드를 자식으로 추가
        GameObject cardObject0_1 = Instantiate(Menu_Card[randomIndex0_1], Blue_First_Line[0]);
        cardObject0_1.transform.localPosition = Vector3.zero;
        cardObject0_1.transform.localRotation = Quaternion.identity;

        // 두 번째 라인에 두 번째 카드를 자식으로 추가
        GameObject cardObject1_1 = Instantiate(Menu_Card[randomIndex1_1], Blue_Second_Line[0]);
        cardObject1_1.transform.localPosition = Vector3.zero;
        cardObject1_1.transform.localRotation = Quaternion.identity;

        GameObject cardObject2_1 = Instantiate(Menu_Card[randomIndex2_1], Blue_First_Line[1]);
        cardObject2_1.transform.localPosition = Vector3.zero;
        cardObject2_1.transform.localRotation = Quaternion.identity;

        // 첫 번째 라인에 첫 번째 카드를 자식으로 추가
        GameObject cardObject0 = Instantiate(Menu_Card[randomIndex0], Pink_First_Line[0]);
        cardObject0.transform.localPosition = Vector3.zero;
        cardObject0.transform.localRotation = Quaternion.identity;

        // 두 번째 라인에 두 번째 카드를 자식으로 추가
        GameObject cardObject1 = Instantiate(Menu_Card[randomIndex1], Pink_Second_Line[0]);
        cardObject1.transform.localPosition = Vector3.zero;
        cardObject1.transform.localRotation = Quaternion.identity;

        // 사용한 카드를 리스트에 추가하고 사용한 카드 개수를 증가시킴
        usedCards.Add(cardObject0_1);
        usedCards.Add(cardObject1_1);
        usedCards.Add(cardObject2_1);
        usedCards.Add(cardObject0);
        usedCards.Add(cardObject1);
        usedCardCount = usedCards.Count;

        // 카드 개수를 업데이트하고 UI Text에 표시
        UpdateCardCountText();
    }

    public void UpdateCardCountText()
    {
        int remainingCardCount = Menu_Card.Length - usedCardCount;
        cardCountText.text = remainingCardCount.ToString();
    }

    /*public Text cardCountText; // UI Text 컴포넌트를 가리키는 변수
    public List<GameObject> usedCards = new List<GameObject>(); // 사용한 카드를 담을 리스트
    public int usedCardCount = 0; // 사용한 카드 개수

    public void Start_Pink()
    {
        int randomIndex0 = Random.Range(0, Menu_Card.Length);//0부터 79의 정수 사이에서 무작위 정수를 생성하는 코드
        int randomIndex1 = Random.Range(0, Menu_Card.Length);
        int randomIndex2 = Random.Range(0, Menu_Card.Length);

        int randomIndex0_1 = Random.Range(0, Menu_Card.Length);
        int randomIndex1_1 = Random.Range(0, Menu_Card.Length);

        // 첫 번째 라인에 첫 번째 카드를 자식으로 추가
        GameObject cardObject0 = Instantiate(Menu_Card[randomIndex0], Pink_First_Line[0]);
        //Menu_Card 배열에서 randomIndex0 위치에 있는 오브젝트를 복제
        //randomIndex0는 0부터 79의 정수 사이에서 무작위
        //생성된 오브젝트를 Pink_First_Line[0]의 자식으로 추가

        cardObject0.transform.localPosition = Vector3.zero;
        cardObject0.transform.localRotation = Quaternion.identity;

        // 두 번째 라인에 두 번째 카드를 자식으로 추가
        GameObject cardObject1 = Instantiate(Menu_Card[randomIndex1], Pink_Second_Line[0]);
        cardObject1.transform.localPosition = Vector3.zero;
        cardObject1.transform.localRotation = Quaternion.identity;


        GameObject cardObject2 = Instantiate(Menu_Card[randomIndex2], Pink_First_Line[1]);
        cardObject2.transform.localPosition = Vector3.zero;
        cardObject2.transform.localRotation = Quaternion.identity;


        // 첫 번째 라인에 첫 번째 카드를 자식으로 추가
        GameObject cardObject0_1 = Instantiate(Menu_Card[randomIndex0_1], Blue_First_Line[0]);
        cardObject0_1.transform.localPosition = Vector3.zero;
        cardObject0_1.transform.localRotation = Quaternion.identity;

        // 두 번째 라인에 두 번째 카드를 자식으로 추가
        GameObject cardObject1_1 = Instantiate(Menu_Card[randomIndex1_1], Blue_Second_Line[0]);
        cardObject1_1.transform.localPosition = Vector3.zero;
        cardObject1_1.transform.localRotation = Quaternion.identity;

        // 사용한 카드를 리스트에 추가하고 사용한 카드 개수를 증가시킴
        usedCards.Add(cardObject0_1);
        usedCards.Add(cardObject1_1);
        usedCards.Add(cardObject2);
        usedCards.Add(cardObject0);
        usedCards.Add(cardObject1);
        usedCardCount = usedCards.Count;

        // 카드 개수를 업데이트하고 UI Text에 표시
        UpdateCardCountText();
    }


    public void Start_Blue()
    {
        int randomIndex0_1 = Random.Range(0, Menu_Card.Length);
        int randomIndex1_1 = Random.Range(0, Menu_Card.Length);
        int randomIndex2_1 = Random.Range(0, Menu_Card.Length);

        int randomIndex0 = Random.Range(0, Menu_Card.Length);
        int randomIndex1 = Random.Range(0, Menu_Card.Length);

        // 첫 번째 라인에 첫 번째 카드를 자식으로 추가
        GameObject cardObject0_1 = Instantiate(Menu_Card[randomIndex0_1], Blue_First_Line[0]);
        cardObject0_1.transform.localPosition = Vector3.zero;
        cardObject0_1.transform.localRotation = Quaternion.identity;

        // 두 번째 라인에 두 번째 카드를 자식으로 추가
        GameObject cardObject1_1 = Instantiate(Menu_Card[randomIndex1_1], Blue_Second_Line[0]);
        cardObject1_1.transform.localPosition = Vector3.zero;
        cardObject1_1.transform.localRotation = Quaternion.identity;

        GameObject cardObject2_1 = Instantiate(Menu_Card[randomIndex2_1], Blue_First_Line[1]);
        cardObject2_1.transform.localPosition = Vector3.zero;
        cardObject2_1.transform.localRotation = Quaternion.identity;

        // 첫 번째 라인에 첫 번째 카드를 자식으로 추가
        GameObject cardObject0 = Instantiate(Menu_Card[randomIndex0], Pink_First_Line[0]);
        cardObject0.transform.localPosition = Vector3.zero;
        cardObject0.transform.localRotation = Quaternion.identity;

        // 두 번째 라인에 두 번째 카드를 자식으로 추가
        GameObject cardObject1 = Instantiate(Menu_Card[randomIndex1], Pink_Second_Line[0]);
        cardObject1.transform.localPosition = Vector3.zero;
        cardObject1.transform.localRotation = Quaternion.identity;

        // 사용한 카드를 리스트에 추가하고 사용한 카드 개수를 증가시킴
        usedCards.Add(cardObject0_1);
        usedCards.Add(cardObject1_1);
        usedCards.Add(cardObject2_1);
        usedCards.Add(cardObject0);
        usedCards.Add(cardObject1);
        usedCardCount = usedCards.Count;

        // 카드 개수를 업데이트하고 UI Text에 표시
        UpdateCardCountText();
    }

    private void UpdateCardCountText()
    {
        int remainingCardCount = Menu_Card.Length - usedCardCount;
        cardCountText.text = remainingCardCount.ToString();
    }*/
}
