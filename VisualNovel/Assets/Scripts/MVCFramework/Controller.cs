using System.Collections;
using System.Collections.Generic;
using MVCPattern;
using UnityEngine;

namespace MVCPattern
{
    public class Controller : MonoBehaviour, IController
    {
        [SerializeField] Model model;
        private List<IView> observersList = new List<IView>();

        //������ ���
        public void ResisterObserver(IView observer)
        {
            observersList.Add(observer);
            NotifyObservers(); //���� ���� ������Ʈ �Ͽ� view�� ���� ����ڿ��� ������
        }

        //������ ����
        public void RemoveObserver(IView observer)
        {
            observersList.Remove(observer);
        }

        //�������鿡�� ���� ����(�߽�)
        public void NotifyObservers()
        {
            foreach (IView observer in observersList)
            {
                observer.UpdateUI(model.FirstData, model.SecondData); //model���� �Ľ̵� ������ view�� ���� �������̽��� ���
            }
        }

        //view�� ���� ����� �Է¿� ���� ���� ���� ������Ʈ
        public void UpdateData(float firstValue, float secondValue)
        {
            model.FirstData += firstValue;
            model.SecondData += secondValue;
            NotifyObservers();
        }
    }
}