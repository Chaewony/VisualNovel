using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MapChange
{
    public class MapChangeController : MonoBehaviour, IController
    {
        private List<IView> observersList = new List<IView>();
        public MapModel mapModel;

        //옵저버 등록
        public void ResisterObserver(IView observer)
        {
            observersList.Add(observer);
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
                observer.UpdateUI(mapModel);
            }
        }

        //view를 통한 사용자 입력에 의한 모델의 정보 업데이트
        public void UpdateData(GameObject nextMapUI, GameObject nextMapObject)
        {
            mapModel.NextMapUI = nextMapUI;
            mapModel.NextMapObject = nextMapObject;
            NotifyObservers();
        }
    }
}