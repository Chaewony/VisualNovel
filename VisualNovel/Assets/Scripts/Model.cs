using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    //ù��° ������
    [SerializeField]
    private float firstData;
    public float FirstData
    {
        get { return firstData; }
        set { firstData = value; }
    }

    //�ι�° ������
    [SerializeField]
    private float secondData;
    public float SecondData
    {
        get { return secondData; }
        set { secondData = value; }
    }
}

