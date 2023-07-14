using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MapChange
{
    public class BtnMapChange : MonoBehaviour, IView
    {
        [SerializeField]
        private Button button;

        [SerializeField]
        private GameObject nextMapUI; //��ư�� �������� ���� ������Ʈ��(���� �� ������Ʈ��)�� ��� �ֻ��� ������Ʈ
        [SerializeField]
        private GameObject nextMapObject; //��ư�� �������� ���� ������Ʈ��(���� �� ������Ʈ��)�� ��� �ֻ��� ������Ʈ
        [SerializeField]
        private MapChangeController controller;

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

        private void Awake()
        {
            //��ư Ŭ������ ���� ó��
            button.onClick.AddListener(() => controller.UpdateData(nextMapUI, nextMapObject));
        }

        //������ ���޹����� Display�� Update ��
        public void UpdateUI(IModel model) //v�� �� ��, m�� ���� ������ c�� ���� Ȯ�� �� ȭ�鿡 update
        {
        }
    }
}
