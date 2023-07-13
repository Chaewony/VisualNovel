namespace MVCPattern
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
        void UpdateUI(float firstData, float secondData); //v가 할 일, m의 상태 변경을 c를 통해 확인 후 화면에 update
        //여기 업데이트 UI부분에 어떤 자료형이든 다 들어갈 수 있게 하기 위해 템플릿함수로 구현하고 싶은데
        //인터페이스로 구현하는게 별로인가?
    }
}
