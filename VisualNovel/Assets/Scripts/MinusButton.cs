using System.Collections;
using System.Collections.Generic;
using MVCPattern;
using UnityEngine;
using UnityEngine.UI;
using static System.Net.Mime.MediaTypeNames;

namespace MVCPattern
{
    public class MinusButton : MonoBehaviour, IView
    {
        [SerializeField] private Button btn;
        [SerializeField] private Controller controller;

        //버튼 클릭됐을 때의 처리
        private void Awake()
        {
            //btn.onClick.AddListener(() => { Debug.Log("버튼 클릭"); }); //람다식으로 디버그
            btn.onClick.AddListener(() => controller.UpdateData(-1, -1)); //람다식 버전
        }

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
        public void UpdateUI(float firstData, float secondData) //v가 할 일, m의 상태 변경을 c를 통해 확인 후 화면에 update
        {
            //버튼에 대한 업데이트
        }
    }
}

