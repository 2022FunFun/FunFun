using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class SkillSlot : MonoBehaviour
{
    public GameObject pikeGameObject;
    public GameObject dualGameObject;
    public GameObject yedoGameObject;
    public GameObject waldoGameObject;
    public GameObject punchGameObject;

    public GameObject SlotCanvas;

    public List<GameObject> slotList;

    public Vector3[] slotPosition;

    public bool isSkilling; //���� ��ų �������ΰ�

    void Awake()
    {

    }

    void Start()
    {
        MakeSlotList();
        ShuffleList(slotList);
        FirstMovingSlot();
    }

    void Update()
    {
        if (isSkilling) return;


        //�׽�Ʈ�ڵ�
        if(Input.GetKeyDown(KeyCode.A))
        {
            GetSlot(0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            GetSlot(1);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            GetSlot(2);
        }
        if (Input.GetKeyDown(KeyCode.F))
        {
            GetSlot(3);
        }

    }

    public void GetSlot(int num) //ü������ �ƴ����� ����
    {
        StartCoroutine(SetCount());

        if (num != 0)
        {
            if (slotList[num].name == slotList[num - 1].name)
            {
                Debug.Log("ü��");
                
                MovingSlot(2, num + 1);
                //ü���ڵ�
                return;
            }
        }

        if (num != 7)
        {
            if (slotList[num].name == slotList[num + 1].name)
            {
                Debug.Log("ü��");

                MovingSlot(2, num + 2);
                //ü���ڵ�
                return;
            }
        }

        Debug.Log("�Ϲ�");

        MovingSlot(1, num + 1);
        //�Ϲݽ�ų�ڵ�
    }

    public IEnumerator SetCount()
    {
        isSkilling = true;
        yield return new WaitForSeconds(0.5f);
        isSkilling = false;
    }

    public void MakeSlotList()//���Ը���Ʈ ä����
    {
        slotList[0] = Instantiate(pikeGameObject, SlotCanvas.transform);
        slotList[1] = Instantiate(pikeGameObject, SlotCanvas.transform);
        slotList[2] = Instantiate(dualGameObject, SlotCanvas.transform);
        slotList[3] = Instantiate(dualGameObject, SlotCanvas.transform);
        slotList[4] = Instantiate(yedoGameObject, SlotCanvas.transform);
        slotList[5] = Instantiate(yedoGameObject, SlotCanvas.transform);
        slotList[6] = Instantiate(waldoGameObject, SlotCanvas.transform);
        slotList[7] = Instantiate(waldoGameObject, SlotCanvas.transform);
        slotList[8] = Instantiate(punchGameObject, SlotCanvas.transform);
        slotList[9] = Instantiate(punchGameObject, SlotCanvas.transform);

        for(int i = 0; i < 10; i++)
        {
            slotList[i].transform.parent = SlotCanvas.transform;
            slotList[i].transform.localPosition = slotPosition[7];
        }

        //for(int i = 0; i < 7; i++)
        //{
        //    slotList[i].transform.localPosition = slotPosition[i];
        //}
    }

    public void ShuffleList<T>(List<T> list)
    {
        int random1;
        int random2;

        T tmp;

        for (int index = 0; index < list.Count; ++index)
        {
            random1 = UnityEngine.Random.Range(0, list.Count);
            random2 = UnityEngine.Random.Range(0, list.Count);

            tmp = list[random1];
            list[random1] = list[random2];
            list[random2] = tmp;
        }
    } //���Ը���Ʈ ������


    public void FirstMovingSlot() //ó�� ���� �ִϸ��̼�
    {
        Sequence firstSeq = DOTween.Sequence();

        firstSeq.Append(slotList[0].transform.DOLocalMoveX(slotPosition[0].x, 0.3f))
            .Append(slotList[1].transform.DOLocalMoveX(slotPosition[1].x, 0.28f))
            .Append(slotList[2].transform.DOLocalMoveX(slotPosition[2].x, 0.26f))
            .Append(slotList[3].transform.DOLocalMoveX(slotPosition[3].x, 0.24f))
            .Append(slotList[4].transform.DOLocalMoveX(slotPosition[4].x, 0.22f))
            .Append(slotList[5].transform.DOLocalMoveX(slotPosition[5].x, 0.2f))
            .Append(slotList[6].transform.DOLocalMoveX(slotPosition[6].x, 0.18f));
    }

    //���� �� �Լ��� ȣ������ 0.2�� �� �ѹ� �� ȣ��� ������ ���ܿ�
    public void MovingSlot(int Minus, int current) //�Ϲ��̸� 1 ü���̸� 2, �� ó������ �����̴� �迭�� �� //���̳ʽ��� 1 or 2  Ŀ��Ʈ�� 1 ~ 7 (���̳ʽ��� 2�϶��� 2 ~ 7)
    {
        DOTween.CompleteAll();
        if(Minus == 1)
        {
            GameObject temp;
            temp = slotList[current - 1];

            //���� �ִϸ��̼�
            slotList[current - 1].GetComponent<Image>().DOFade(0, 0.2f).OnComplete(()=> { slotList[slotList.Count - 1].transform.DOLocalMove(slotPosition[7], 0);
                slotList[slotList.Count - 1].GetComponent<Image>().DOFade(1, 0);
            });

            for (int i = current; i < current + (8 - current); i++)
            {
                slotList[i].transform.DOLocalMoveX(slotPosition[i - 1].x, 0.2f);
            }

            //���� ����Ʈ ����
            for (int i = current; i < 10; i++)
            {
                slotList[i - 1] = slotList[i];
            }
            slotList[9] = temp;
        }

        else if (Minus == 2)
        {
            GameObject temp1, temp2;
            temp1 = slotList[current - 2]; //1
            temp2 = slotList[current - 1]; //2

            slotList[current - 1].GetComponent<Image>().DOFade(0, 0.2f).OnComplete(() =>
            {
                slotList[slotList.Count - 1].transform.DOLocalMove(slotPosition[7], 0);
                slotList[slotList.Count - 1].GetComponent<Image>().DOFade(1, 0);
            });

            slotList[current - 2].GetComponent<Image>().DOFade(0, 0.2f).OnComplete(() => {
                slotList[slotList.Count - 3].transform.DOLocalMove(slotPosition[7], 0);
                slotList[slotList.Count - 3].GetComponent<Image>().DOFade(1, 0);
            });

            for (int i = current; i < current + (8 - current) + 1; i++)
            {
                slotList[i].transform.DOLocalMoveX(slotPosition[i - 2].x, 0.2f);
            }

            for (int i = current; i < 10; i++)
            {
                slotList[i - 2] = slotList[i];
            }

            slotList[8] = slotList[7];
            slotList[7] = temp1;
            slotList[9] = temp2;
        }
        else
        {
            Debug.LogError("���� ���̳ʽ�");
        }
        
    }

} 
