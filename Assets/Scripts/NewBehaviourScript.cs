using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //정수 구분
        int number = -100;

        if (number < 0)
        {
            Debug.Log("음수입니다.");
        }
        else if(number > 0)
        {
            Debug.Log("양수입니다.");
        }
        else
        {
            Debug.Log("0입니다.");
        }


        //윤년 계산
        int year = 4400;

        if(year % 4 == 0)
        {
            Debug.Log("윤년입니다.");
        }
        else
        {
            Debug.Log("윤년이 아닙니다.");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
