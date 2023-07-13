using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using MVCPattern;

namespace MVCPattern
{
    public class View : MonoBehaviour, IView
    {
        [SerializeField] private Button btn;
        [SerializeField] private Controller controller;
        [SerializeField] private TextMeshProUGUI text;

        //��ư Ŭ������ ���� ó��
        private void Awake()
        {
            //btn.onClick.AddListener(() => { Debug.Log("��ư Ŭ��"); }); //���ٽ����� �����
            btn.onClick.AddListener(() => controller.UpdateData()); //���ٽ� ����
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
            //text. �ؽ�Ʈ ������Ʈ
            text.SetText(firstData.ToString() + " " + secondData.ToString());
        }
    }
}


