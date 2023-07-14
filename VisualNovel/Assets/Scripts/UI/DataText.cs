using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using MVCPattern;

namespace MVCPattern
{
    public class DataText : MonoBehaviour, IView
    {
        [SerializeField] private TextMeshProUGUI text;
        [SerializeField] private Controller controller;

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
        public void UpdateUI(float firstData, float secondData) 
        {
            //text. 텍스트 업데이트
            text.SetText(firstData.ToString() + " " + secondData.ToString());
        }
    }
}
