using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MapChange
{
    public class BackGroundChange : MonoBehaviour, IView
    {
        [SerializeField] private MapChangeController controller;

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
        public void UpdateUI(IModel model) //v�� �� ��, m�� ���� ������ c�� ���� Ȯ�� �� ȭ�鿡 update
        {
            MapModel mapModel = (MapModel)model; //����� ����ȯ
            mapModel.NextMapObject.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }

}