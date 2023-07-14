using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MapChange
{
    public class BackGroundChange : MonoBehaviour, IView
    {
        [SerializeField] private MapChangeController controller;

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

        //정보를 전달받으면 Display에 Update 함
        public void UpdateUI(IModel model) //v가 할 일, m의 상태 변경을 c를 통해 확인 후 화면에 update
        {
            MapModel mapModel = (MapModel)model; //명시적 형변환
            mapModel.NextMapObject.gameObject.SetActive(true);
            this.gameObject.SetActive(false);
        }
    }

}