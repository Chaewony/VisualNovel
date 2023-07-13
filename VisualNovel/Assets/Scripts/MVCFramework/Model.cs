using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model : MonoBehaviour
{
    //첫번째 데이터
    [SerializeField]
    private float firstData;
    public float FirstData
    {
        get { return firstData; }
        set { firstData = value; }
    }

    //두번째 데이터
    [SerializeField]
    private float secondData;
    public float SecondData
    {
        get { return secondData; }
        set { secondData = value; }
    }
}

