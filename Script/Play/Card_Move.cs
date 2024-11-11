using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card_Move : MonoBehaviour
{
    //ī�� ��ġ�ϴ� ��
    //����
    public Transform[] Pink_First_Line;
    public Transform[] Pink_Second_Line;
    public Transform[] Pink_Third_Line;
    public Transform[] Pink_Fourth_Line;


    //�Ķ�
    public Transform[] Blue_First_Line;
    public Transform[] Blue_Second_Line;
    public Transform[] Blue_Third_Line;
    public Transform[] Blue_Fourth_Line;


    //�޴� ī�� 80��
    public GameObject[] Menu_Card;


    public Text cardCountText; // UI Text ������Ʈ�� ����Ű�� ����
    public List<GameObject> usedCards = new List<GameObject>(); // ����� ī�带 ���� ����Ʈ
    public int usedCardCount = 0; // ����� ī�� ����

    private List<int> availableCardIndices; // ��� ������ ī�� �ε����� ���� ����Ʈ


    // ������ �� ��� ������ ī�� �ε����� �ʱ�ȭ�ϰ� ���´�
    private void InitializeAvailableCardIndices()
    {
        availableCardIndices = new List<int>();//availableCardIndices��� ���� ����Ʈ�� ����
        //��� ������ ī�� �ε������� ���� ����

        for (int i = 0; i < Menu_Card.Length; i++)//0���� �迭�� ���̱��� �ݺ�
        {
            availableCardIndices.Add(i);//for���� �ݺ��ϸ鼭 i���� ����Ʈ�� �߰�
            //�̰� �ϸ鼭 ī�� �ε����� ��Ÿ���� ����Ʈ�� �Ǵ� ����
        }
        ShuffleAvailableCardIndices();
        //ī����� ���� ���� �Լ� ȣ��
    }

    // ��� ������ ī�� �ε��� ����Ʈ�� Fisher-Yates �˰����� ����Ͽ� ����
    //Fisher-Yates �˰��� ����ϸ� ������
    //�߾ƾǰ� �����ϱ� �����
    private void ShuffleAvailableCardIndices()
    {
        int n = availableCardIndices.Count;//���� ī���� ������ n�� ����
        while (n > 1)
        {
            n--;//����Ʈ���� �������� ������ ������ ���̱� ���� ���
            int k = Random.Range(0, n + 1);//����Ʈ���� �������� ������ ����� �ε����� ����
            int value = availableCardIndices[k];//����Ʈ���� �������� ���õ� ����� ���� �ӽ÷� ����
            availableCardIndices[k] = availableCardIndices[n];//����Ʈ���� �������� ���õ� ��Ұ� 
            //�����ִ� ��� �� ���� ������ ��ҿ� �ڸ��� �ٲ�
            availableCardIndices[n] = value;//n�ε����� �ִ� ��Ҹ� value������ ��ȯ
            //�������� ���õ� ��Ұ� ����Ʈ ���������� �̵�
        }
        //while�� �ݺ��ϸ鼭 �������� ���õǴ� ������ �������鼭 ����Ʈ�� �������� ���ġ��
    }

    // ��� ������ ī�� �ε��� ����Ʈ���� �������� �ϳ��� ī�� �ε����� �����ϰ� �ش� �ε����� ����Ʈ���� �����մϴ�.
    public int GetRandomCardIndex()//�ߺ� ���� ���� ��
    {
        int randomIndex = availableCardIndices[0];//�ε����� ù ��° ��Ҹ� ������ ����
        availableCardIndices.RemoveAt(0);//����Ʈ���� ù ��° ��Ҹ� ����
        //�̷��� �ؼ� �ƿ��� ������ ī���� �ε����� ����Ʈ���� ������ ��
        return randomIndex;
    }

    // Start �Լ����� ��� ������ ī�� �ε��� ����Ʈ�� �����ϰ� �����ϴ�.
    void Start()
    {
        InitializeAvailableCardIndices();
    }

    public void Start_Pink()
    {
        int randomIndex0 = GetRandomCardIndex();
        int randomIndex1 = GetRandomCardIndex();
        int randomIndex2 = GetRandomCardIndex();

        

        //�Ķ�
        int randomIndex0_1 = GetRandomCardIndex();
        int randomIndex1_1 = GetRandomCardIndex();

        // ù ��° ���ο� ù ��° ī�带 �ڽ����� �߰�
        GameObject cardObject0 = Instantiate(Menu_Card[randomIndex0], Pink_First_Line[0]);
        cardObject0.transform.localPosition = Vector3.zero;
        cardObject0.transform.localRotation = Quaternion.identity;

        // �� ��° ���ο� �� ��° ī�带 �ڽ����� �߰�
        GameObject cardObject1 = Instantiate(Menu_Card[randomIndex1], Pink_Second_Line[0]);
        cardObject1.transform.localPosition = Vector3.zero;
        cardObject1.transform.localRotation = Quaternion.identity;

        GameObject cardObject2 = Instantiate(Menu_Card[randomIndex2], Pink_First_Line[1]);
        cardObject2.transform.localPosition = Vector3.zero;
        cardObject2.transform.localRotation = Quaternion.identity;

        


        //�Ķ�
        // ù ��° ���ο� ù ��° ī�带 �ڽ����� �߰�
        GameObject cardObject0_1 = Instantiate(Menu_Card[randomIndex0_1], Blue_First_Line[0]);
        cardObject0_1.transform.localPosition = Vector3.zero;
        cardObject0_1.transform.localRotation = Quaternion.identity;

        // �� ��° ���ο� �� ��° ī�带 �ڽ����� �߰�
        GameObject cardObject1_1 = Instantiate(Menu_Card[randomIndex1_1], Blue_Second_Line[0]);
        cardObject1_1.transform.localPosition = Vector3.zero;
        cardObject1_1.transform.localRotation = Quaternion.identity;

        // ����� ī�带 ����Ʈ�� �߰��ϰ� ����� ī�� ������ ������Ŵ
        usedCards.Add(cardObject0_1);
        usedCards.Add(cardObject1_1);
        
        usedCards.Add(cardObject0);
        usedCards.Add(cardObject1);
        usedCards.Add(cardObject2);

       


        usedCardCount = usedCards.Count;

        // ī�� ������ ������Ʈ�ϰ� UI Text�� ǥ��
        UpdateCardCountText();
    }

    public void Start_Blue()
    {
        int randomIndex0_1 = GetRandomCardIndex();
        int randomIndex1_1 = GetRandomCardIndex();
        int randomIndex2_1 = GetRandomCardIndex();

        int randomIndex0 = GetRandomCardIndex();
        int randomIndex1 = GetRandomCardIndex();

        // ù ��° ���ο� ù ��° ī�带 �ڽ����� �߰�
        GameObject cardObject0_1 = Instantiate(Menu_Card[randomIndex0_1], Blue_First_Line[0]);
        cardObject0_1.transform.localPosition = Vector3.zero;
        cardObject0_1.transform.localRotation = Quaternion.identity;

        // �� ��° ���ο� �� ��° ī�带 �ڽ����� �߰�
        GameObject cardObject1_1 = Instantiate(Menu_Card[randomIndex1_1], Blue_Second_Line[0]);
        cardObject1_1.transform.localPosition = Vector3.zero;
        cardObject1_1.transform.localRotation = Quaternion.identity;

        GameObject cardObject2_1 = Instantiate(Menu_Card[randomIndex2_1], Blue_First_Line[1]);
        cardObject2_1.transform.localPosition = Vector3.zero;
        cardObject2_1.transform.localRotation = Quaternion.identity;

        // ù ��° ���ο� ù ��° ī�带 �ڽ����� �߰�
        GameObject cardObject0 = Instantiate(Menu_Card[randomIndex0], Pink_First_Line[0]);
        cardObject0.transform.localPosition = Vector3.zero;
        cardObject0.transform.localRotation = Quaternion.identity;

        // �� ��° ���ο� �� ��° ī�带 �ڽ����� �߰�
        GameObject cardObject1 = Instantiate(Menu_Card[randomIndex1], Pink_Second_Line[0]);
        cardObject1.transform.localPosition = Vector3.zero;
        cardObject1.transform.localRotation = Quaternion.identity;

        // ����� ī�带 ����Ʈ�� �߰��ϰ� ����� ī�� ������ ������Ŵ
        usedCards.Add(cardObject0_1);
        usedCards.Add(cardObject1_1);
        usedCards.Add(cardObject2_1);
        usedCards.Add(cardObject0);
        usedCards.Add(cardObject1);
        usedCardCount = usedCards.Count;

        // ī�� ������ ������Ʈ�ϰ� UI Text�� ǥ��
        UpdateCardCountText();
    }

    public void UpdateCardCountText()
    {
        int remainingCardCount = Menu_Card.Length - usedCardCount;
        cardCountText.text = remainingCardCount.ToString();
    }

    /*public Text cardCountText; // UI Text ������Ʈ�� ����Ű�� ����
    public List<GameObject> usedCards = new List<GameObject>(); // ����� ī�带 ���� ����Ʈ
    public int usedCardCount = 0; // ����� ī�� ����

    public void Start_Pink()
    {
        int randomIndex0 = Random.Range(0, Menu_Card.Length);//0���� 79�� ���� ���̿��� ������ ������ �����ϴ� �ڵ�
        int randomIndex1 = Random.Range(0, Menu_Card.Length);
        int randomIndex2 = Random.Range(0, Menu_Card.Length);

        int randomIndex0_1 = Random.Range(0, Menu_Card.Length);
        int randomIndex1_1 = Random.Range(0, Menu_Card.Length);

        // ù ��° ���ο� ù ��° ī�带 �ڽ����� �߰�
        GameObject cardObject0 = Instantiate(Menu_Card[randomIndex0], Pink_First_Line[0]);
        //Menu_Card �迭���� randomIndex0 ��ġ�� �ִ� ������Ʈ�� ����
        //randomIndex0�� 0���� 79�� ���� ���̿��� ������
        //������ ������Ʈ�� Pink_First_Line[0]�� �ڽ����� �߰�

        cardObject0.transform.localPosition = Vector3.zero;
        cardObject0.transform.localRotation = Quaternion.identity;

        // �� ��° ���ο� �� ��° ī�带 �ڽ����� �߰�
        GameObject cardObject1 = Instantiate(Menu_Card[randomIndex1], Pink_Second_Line[0]);
        cardObject1.transform.localPosition = Vector3.zero;
        cardObject1.transform.localRotation = Quaternion.identity;


        GameObject cardObject2 = Instantiate(Menu_Card[randomIndex2], Pink_First_Line[1]);
        cardObject2.transform.localPosition = Vector3.zero;
        cardObject2.transform.localRotation = Quaternion.identity;


        // ù ��° ���ο� ù ��° ī�带 �ڽ����� �߰�
        GameObject cardObject0_1 = Instantiate(Menu_Card[randomIndex0_1], Blue_First_Line[0]);
        cardObject0_1.transform.localPosition = Vector3.zero;
        cardObject0_1.transform.localRotation = Quaternion.identity;

        // �� ��° ���ο� �� ��° ī�带 �ڽ����� �߰�
        GameObject cardObject1_1 = Instantiate(Menu_Card[randomIndex1_1], Blue_Second_Line[0]);
        cardObject1_1.transform.localPosition = Vector3.zero;
        cardObject1_1.transform.localRotation = Quaternion.identity;

        // ����� ī�带 ����Ʈ�� �߰��ϰ� ����� ī�� ������ ������Ŵ
        usedCards.Add(cardObject0_1);
        usedCards.Add(cardObject1_1);
        usedCards.Add(cardObject2);
        usedCards.Add(cardObject0);
        usedCards.Add(cardObject1);
        usedCardCount = usedCards.Count;

        // ī�� ������ ������Ʈ�ϰ� UI Text�� ǥ��
        UpdateCardCountText();
    }


    public void Start_Blue()
    {
        int randomIndex0_1 = Random.Range(0, Menu_Card.Length);
        int randomIndex1_1 = Random.Range(0, Menu_Card.Length);
        int randomIndex2_1 = Random.Range(0, Menu_Card.Length);

        int randomIndex0 = Random.Range(0, Menu_Card.Length);
        int randomIndex1 = Random.Range(0, Menu_Card.Length);

        // ù ��° ���ο� ù ��° ī�带 �ڽ����� �߰�
        GameObject cardObject0_1 = Instantiate(Menu_Card[randomIndex0_1], Blue_First_Line[0]);
        cardObject0_1.transform.localPosition = Vector3.zero;
        cardObject0_1.transform.localRotation = Quaternion.identity;

        // �� ��° ���ο� �� ��° ī�带 �ڽ����� �߰�
        GameObject cardObject1_1 = Instantiate(Menu_Card[randomIndex1_1], Blue_Second_Line[0]);
        cardObject1_1.transform.localPosition = Vector3.zero;
        cardObject1_1.transform.localRotation = Quaternion.identity;

        GameObject cardObject2_1 = Instantiate(Menu_Card[randomIndex2_1], Blue_First_Line[1]);
        cardObject2_1.transform.localPosition = Vector3.zero;
        cardObject2_1.transform.localRotation = Quaternion.identity;

        // ù ��° ���ο� ù ��° ī�带 �ڽ����� �߰�
        GameObject cardObject0 = Instantiate(Menu_Card[randomIndex0], Pink_First_Line[0]);
        cardObject0.transform.localPosition = Vector3.zero;
        cardObject0.transform.localRotation = Quaternion.identity;

        // �� ��° ���ο� �� ��° ī�带 �ڽ����� �߰�
        GameObject cardObject1 = Instantiate(Menu_Card[randomIndex1], Pink_Second_Line[0]);
        cardObject1.transform.localPosition = Vector3.zero;
        cardObject1.transform.localRotation = Quaternion.identity;

        // ����� ī�带 ����Ʈ�� �߰��ϰ� ����� ī�� ������ ������Ŵ
        usedCards.Add(cardObject0_1);
        usedCards.Add(cardObject1_1);
        usedCards.Add(cardObject2_1);
        usedCards.Add(cardObject0);
        usedCards.Add(cardObject1);
        usedCardCount = usedCards.Count;

        // ī�� ������ ������Ʈ�ϰ� UI Text�� ǥ��
        UpdateCardCountText();
    }

    private void UpdateCardCountText()
    {
        int remainingCardCount = Menu_Card.Length - usedCardCount;
        cardCountText.text = remainingCardCount.ToString();
    }*/
}
