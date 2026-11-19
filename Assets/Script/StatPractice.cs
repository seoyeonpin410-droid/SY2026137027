using UnityEngine;

public class StatPractice : MonoBehaviour
{
    public string playerName = "플레이어 이름";
    public int level = 20;
    public float attack = 12.5f;
    public bool isBoss = false;

    [ContextMenu("스탯")]
    public void ShowStat()
    {
        Debug.Log("플레이어 이름" + playerName);
        Debug.Log("레벨" + level);
        Debug.Log("공격" + attack);
        Debug.Log("보스" + isBoss);
    }


    [ContextMenu("오버플로")]
    void Overflow()
    {
        int gold = int.MaxValue;
        Debug.Log(gold);
        gold = gold + 1;
        Debug.Log(gold);
        byte red = 255;
        red++;
        Debug.Log(red);
    }

    [ContextMenu("정밀도")]
    void Precision()
    {
        double d = 0.1 + 0.2;
        Debug.Log(d == 0.3);

        float half = 1 / 2;
        Debug.Log(half);
    }

    [ContextMenu("자료형")]
    void Types()
    {
        int level = 30;
        byte red = 255;
        char grade = 'S';
        float speed = 5.5f;
        bool isHigh = level >= 10;
        Debug.Log(level + "" + red + "" + grade);
        Debug.Log(speed + "" + isHigh);
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
