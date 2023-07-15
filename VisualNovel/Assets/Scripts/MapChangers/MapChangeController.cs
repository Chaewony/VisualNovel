using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MapChange
{
    public class MapChangeController : MonoBehaviour, IController
    {
        private List<IView> observersList = new List<IView>();
        public MapModel mapModel;

        //������ ���
        public void ResisterObserver(IView observer)
        {
            observersList.Add(observer);
        }

        //������ ����
        public void RemoveObserver(IView observer)
        {
            observersList.Remove(observer);
        }

        //�������鿡�� ���� ����(�߽�)
        public void NotifyObservers()
        {
            // foreach�� ���� �߿� ����������Ʈ ���� �Ͼ��
            // (updateUI�Լ� �����ϸ鼭 object�� inactive�Ǹ鼭 ������ ����Ʈ���� �����Ǳ� ����)
            // ������ ������ ����Ʈ�� �������� �� foreach���� ������
            List<IView> currentObserverList = new List<IView>();
            foreach (IView observer in observersList)
            {
                currentObserverList.Add(observer);
            }
            
            foreach (IView observer in currentObserverList) 
            {
                observer.UpdateUI(mapModel);
            }
        }

        //view�� ���� ����� �Է¿� ���� ���� ���� ������Ʈ
        public void UpdateData(GameObject nextMapUI, GameObject nextMapObject)
        {
            mapModel.NextMapUI = nextMapUI;
            mapModel.NextMapObject = nextMapObject;
            NotifyObservers();
        }
    }
}