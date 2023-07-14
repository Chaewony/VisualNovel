using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MapChange
{
    public class MapModel : MonoBehaviour, IModel
    {
        //ù��° ������
        [SerializeField]
        private GameObject nextMapUI;
        public GameObject NextMapUI
        {
            get { return nextMapUI; }
            set { nextMapUI = value; }
        }

        //�ι�° ������
        [SerializeField]
        private GameObject nextMapObject;
        public GameObject NextMapObject
        {
            get { return nextMapObject; }
            set { nextMapObject = value; }
        }
    }
}

