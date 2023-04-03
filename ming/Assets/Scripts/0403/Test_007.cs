using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{
    void sayHello()                                     //SayHello 함수를 선언
    {
        Debug.Log("Hello");                             //Hello 내용을 Console.log에 출력
    }

    void Callname(string name)                          //CallName 함수 선언 (string 변수의 인수(name)를 가짐)
    {
        Debug.Log("Hello" + name);
    }

    int Add(int a , int b)                              //Add 함수 선언 (인수 , 반환값) 반환값, 선언할 때 (int)
    {
        int c = a + b;                                  //c라는 int 변수 생성 a + b 값을 입력
        return c;                                       //값을 함수 변환 값으로 넘김 (return)
    }

    // Start is called before the first frame update
    void Start()
    {
        sayHello();                                     //함수를 실행
        sayHello();                                     //함수를 실행
        Callname("TOM");                                //함수를 실행 string 파라미터 Tom 을 입력
        Callname("SAM");                                //함수를 실행 string 파라미터 Sam 을 입력
        int answer = Add(2, 5);                         //변수 int answer 선언 하고 함수의 반환값을 입력
        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
