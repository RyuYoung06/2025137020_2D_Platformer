using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //���� ����
        int number = -100;

        if (number < 0)
        {
            Debug.Log("�����Դϴ�.");
        }
        else if(number > 0)
        {
            Debug.Log("����Դϴ�.");
        }
        else
        {
            Debug.Log("0�Դϴ�.");
        }


        //���� ���
        int year = 4400;

        if(year % 4 == 0)
        {
            Debug.Log("�����Դϴ�.");
        }
        else
        {
            Debug.Log("������ �ƴմϴ�.");
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
