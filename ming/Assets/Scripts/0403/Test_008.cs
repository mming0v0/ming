using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;                                   //UI�� �����ϱ� ���ؼ� ���


public class Player
{
    private int hp = 100;                               //hp �� ������ �� 100�� ���� �Է�
    private int Power = 50;                             //power�� ������ �� 50�� ���� �Է�

    public void Attack()    
    {
        Debug.Log(this.Power + " �������� ������.");   //this�� Player Ŭ������ �̾߱��Ѵ�.
    }

    public void Damage(int damage)                     //Damage �Լ��� int ���·� ���� ������ �μ��� �޴´�.
    {
        this.hp -= damage;
        Debug.Log(damage + " �������� ������.");
    }

    public int GetHp()                                 //private �� ����Ǿ��ִ� Hp ���� ���� �Լ��� ���ؼ� ����
    {
        return this.hp;
    }
}

public class Test_008 : MonoBehaviour
{
    Player player_01 = new Player();
    Player player_02 = new Player();
    public Text player01HP;
    public Text player02HP;

    // Start is called before the first frame update
    void Start()
    {
        Player player_01 = new Player();                //���� ���� �÷��̾� Ŭ������ �����Ѵ�.
        player_01.Attack();                             //������ player_01 �� Attack �Լ��� �����Ų��.
        player_01.Damage(30);                           //������ player_01 �� Damage �Լ��� �����Ų��.
    }

    // Update is called once per frame
    void Update()
    {
        player01HP.text = "Player 01 HP : " + player_01.GetHp().ToString();             //GetHp() �Լ��� ȣ���ϰ� ToStering���� ���ڿ��� ��ȯ
        player02HP.text = "Player 02 HP : " + player_02.GetHp().ToString();             //GetHp() �Լ��� ȣ���ϰ� ToStering���� ���ڿ��� ��ȯ

        if (Input.GetMouseButtonDown(0))                //���� ���콺�� ������ ��
        {
            player_01.Damage(1);                        //player_01�� ��ü�� �Լ� Damage�� ���� (�Ƕ���ͷδ� 1�� ����)
        }

        if (Input.GetMouseButtonDown(1))                //������ ���콺�� ������ ��
        {
            player_02.Damage(1);                        //player_01�� ��ü�� �Լ� Damage�� ���� (�Ƕ���ͷδ� 1�� ����)
        }

    }
}
