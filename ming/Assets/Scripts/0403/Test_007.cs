using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test_007 : MonoBehaviour
{
    void sayHello()                                     //SayHello �Լ��� ����
    {
        Debug.Log("Hello");                             //Hello ������ Console.log�� ���
    }

    void Callname(string name)                          //CallName �Լ� ���� (string ������ �μ�(name)�� ����)
    {
        Debug.Log("Hello" + name);
    }

    int Add(int a , int b)                              //Add �Լ� ���� (�μ� , ��ȯ��) ��ȯ��, ������ �� (int)
    {
        int c = a + b;                                  //c��� int ���� ���� a + b ���� �Է�
        return c;                                       //���� �Լ� ��ȯ ������ �ѱ� (return)
    }

    // Start is called before the first frame update
    void Start()
    {
        sayHello();                                     //�Լ��� ����
        sayHello();                                     //�Լ��� ����
        Callname("TOM");                                //�Լ��� ���� string �Ķ���� Tom �� �Է�
        Callname("SAM");                                //�Լ��� ���� string �Ķ���� Sam �� �Է�
        int answer = Add(2, 5);                         //���� int answer ���� �ϰ� �Լ��� ��ȯ���� �Է�
        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
