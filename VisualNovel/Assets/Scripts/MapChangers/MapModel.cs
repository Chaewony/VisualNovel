using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MapChange
{
    public class MapModel : MonoBehaviour, IModel
    {
        //첫번째 데이터
        [SerializeField]
        private GameObject nextMapUI;
        public GameObject NextMapUI
        {
            get { return nextMapUI; }
            set { nextMapUI = value; }
        }

        //두번째 데이터
        [SerializeField]
        private GameObject nextMapObject;
        public GameObject NextMapObject
        {
            get { return nextMapObject; }
            set { nextMapObject = value; }
        }
    }
}

