using UnityEngine;

namespace MapChange
{
    public interface IController
    {
        //옵저버 등록
        void ResisterObserver(IView observer); //m을 구독할v들을 리스트에 저장

        //옵저버 제거
        void RemoveObserver(IView observer);

        //옵저버들에게 내용 전달
        void NotifyObservers(); //c가 할 일, m의 상태가 변경 되면 v에게 알림
    }

    public interface IView
    {
        //데이터 변경 시 UI 업데이트 해줘야됨 
        void UpdateUI(IModel model); 
    }

    public interface IModel
    {
        
    }
}
