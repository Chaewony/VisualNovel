using System.Collections;
using System.Collections.Generic;
using MVCPattern;
using UnityEngine;
using UnityEngine.UI;

public class PlusButton : MonoBehaviour, IView
{
    [SerializeField] private Button btn;
    [SerializeField] private Controller controller;

    //��ư Ŭ������ ���� ó��
    private void Awake()
    {
        //btn.onClick.AddListener(() => { Debug.Log("��ư Ŭ��"); }); //���ٽ����� �����
        btn.onClick.AddListener(() => controller.UpdateData(1, 1)); //���ٽ� ����
    }

    private void OnEnable()
    {
        //�ڽ��� �������� ���
        controller.ResisterObserver(this);
    }

    private void OnDisable()
    {
        //��ü ���� �� ������ ����
        controller.RemoveObserver(this);
    }

    //������ ���޹����� Display�� Update ��
    public void UpdateUI(float firstData, float secondData) //v�� �� ��, m�� ���� ������ c�� ���� Ȯ�� �� ȭ�鿡 update
    {
        //��ư�� ���� ������Ʈ
    }
}
