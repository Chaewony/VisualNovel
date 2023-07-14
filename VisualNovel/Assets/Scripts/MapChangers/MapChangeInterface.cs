using UnityEngine;

namespace MapChange
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
        void UpdateUI(IModel model); 
    }

    public interface IModel
    {
        
    }
}
