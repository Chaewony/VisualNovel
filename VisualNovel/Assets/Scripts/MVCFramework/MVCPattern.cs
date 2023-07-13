namespace MVCPattern
{
    public interface IController
    {
        //������ ���
        void ResisterObserver(IView observer); //m�� ������v���� ����Ʈ�� ����

        //������ ����
        void RemoveObserver(IView observer);

        //�������鿡�� ���� ����
        void NotifyObservers(); //c�� �� ��, m�� ���°� ���� �Ǹ� v���� �˸�
    }

    public interface IView
    {
        //������ ���� �� UI ������Ʈ ����ߵ� 
        void UpdateUI(float firstData, float secondData); //v�� �� ��, m�� ���� ������ c�� ���� Ȯ�� �� ȭ�鿡 update
        //���� ������Ʈ UI�κп� � �ڷ����̵� �� �� �� �ְ� �ϱ� ���� ���ø��Լ��� �����ϰ� ������
        //�������̽��� �����ϴ°� �����ΰ�?
    }
}
