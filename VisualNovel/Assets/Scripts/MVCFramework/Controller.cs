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

        //옵저버 등록
        public void ResisterObserver(IView observer)
        {
            observersList.Add(observer);
            NotifyObservers(); //최초 정보 업데이트 하여 view를 통해 사용자에게 보여줌
        }

        //옵저버 해지
        public void RemoveObserver(IView observer)
        {
            observersList.Remove(observer);
        }

        //옵저버들에게 정보 전달(발신)
        public void NotifyObservers()
        {
            foreach (IView observer in observersList)
            {
                observer.UpdateUI(model.FirstData, model.SecondData); //model에서 파싱된 정보를 view를 통해 인터페이스로 출력
            }
        }

        //view를 통한 사용자 입력에 의한 모델의 정보 업데이트
        public void UpdateData(float firstValue, float secondValue)
        {
            model.FirstData += firstValue;
            model.SecondData += secondValue;
            NotifyObservers();
        }
    }
}