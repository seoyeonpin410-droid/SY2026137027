using UnityEngine;

public class Lesson09 : MonoBehaviour
{
    [ContextMenu("예측1")]
    void Predict1()
    {
        int hp = 10;
        hp = hp - 3;
        Debug.Log(hp);
        hp = 20;
        Debug.Log(hp);   
        int maxhp = hp;
        hp = 5;
        Debug.Log(maxhp);
        
    }
    /*hp변수 선언 후 hp 10이 됨 > 3을 뺀 7이 콘솔에 찍힘 하지만 20선언을 함
     > 최대값(max) hp는 20이라 선언됨 대신 최대값이 5로 선언함 >효과 x
    */

    [ContextMenu("예측2")]
    void Predict2()
    {
        int hp = 7;
        int maxHp = 10;
        Debug.Log(hp / maxHp);
        Debug.Log((float)hp / maxHp);
        Debug.Log(hp / 2);
        Debug.Log(hp / 2f);
        Debug.Log(hp % 2);
    }

    [ContextMenu("나머지")]
    void Remainder()
    {
        int shotCount = 6;
        int totalSeconds = 135;

        bool isEven = shotCount % 2 == 0;
        bool strongShot = shotCount % 3 == 0;
        int min = totalSeconds / 60;
        int sec = totalSeconds % 60;
        Debug.Log(min + ":" + sec);
    }


    public int gold = 100;
    public int potion = 3;

    [ContextMenu("골드보기")]
    void ShowGold()
    {
        Debug.Log(gold);
    }

    [ContextMenu("Hello")]
    void Hello()
    {
        Debug.Log("Hello");
    }

    [ContextMenu("테스트1")]
    void Test1()
    {
        int hp = 10;
        Debug.Log(hp);
    }

    [ContextMenu("테스트2")]
    void Test2()
    {
        int hp = 7;
        Debug.Log(hp);
    }

    public int attack = 10;
    int killcount = 0;

    [ContextMenu("처치")]
    void CountKill()
    {
        int defense = 3; //지역변수 
        killcount = killcount + 1;
        Debug.Log(attack - defense);
        Debug.Log(killcount);
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(attack);
    }

    void Hit()
    {
        killcount = killcount + 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

