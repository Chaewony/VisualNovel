using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using MVCPattern;

namespace MVCPattern
{
    public class DataText : MonoBehaviour, IView
    {
        [SerializeField] private TextMeshProUGUI text;
        [SerializeField] private Controller controller;

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
        public void UpdateUI(float firstData, float secondData) 
        {
            //text. �ؽ�Ʈ ������Ʈ
            text.SetText(firstData.ToString() + " " + secondData.ToString());
        }
    }
}
