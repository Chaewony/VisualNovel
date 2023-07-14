using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MapChange
{
    public class BtnMapChange : MonoBehaviour, IView
    {
        [SerializeField]
        private Button button;

        [SerializeField]
        private GameObject nextMapUI; //버튼이 눌렸을때 켜줄 오브젝트들(다음 맵 오브젝트들)을 담는 최상위 오브젝트
        [SerializeField]
        private GameObject nextMapObject; //버튼이 눌렸을때 켜줄 오브젝트들(다음 맵 오브젝트들)을 담는 최상위 오브젝트
        [SerializeField]
        private MapChangeController controller;

        private void OnEnable()
        {
            //자신을 옵저버로 등록
            controller.ResisterObserver(this);
        }

        private void OnDisable()
        {
            //객체 삭제 시 옵저버 해지
            controller.RemoveObserver(this);
        }

        private void Awake()
        {
            //버튼 클릭됐을 때의 처리
            button.onClick.AddListener(() => controller.UpdateData(nextMapUI, nextMapObject));
        }

        //정보를 전달받으면 Display에 Update 함
        public void UpdateUI(IModel model) //v가 할 일, m의 상태 변경을 c를 통해 확인 후 화면에 update
        {
        }
    }
}
