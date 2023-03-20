using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_001 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int age;    //정수형 int 선언 이름은 age               
        age = 30;   //age 에 30을 이력 (=)은 입력
        Debug.Log(age);

        float height1 = 160.5f;
        float height2;
        height2 = height1;
        Debug.Log(height2);

        string name;
        name = "sera";
        Debug.Log(name);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
