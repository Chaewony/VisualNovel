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
            // foreach문 도는 중에 옵저버리스트 변경 일어나서
            // (updateUI함수 실행하면서 object가 inactive되면서 옵저버 리스트에서 해제되기 때문)
            // 기존의 옵저버 리스트를 값만복사 후 foreach문을 실행함
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

        //view를 통한 사용자 입력에 의한 모델의 정보 업데이트
        public void UpdateData(GameObject nextMapUI, GameObject nextMapObject)
        {
            mapModel.NextMapUI = nextMapUI;
            mapModel.NextMapObject = nextMapObject;
            NotifyObservers();
        }
    }
}