using UnityEngine;

public class RewardCalc : MonoBehaviour
{
    public int playSeconds = 3725, gold = 1234, members = 4, kills = 7, expPerKill = 35, totalDamage = 250, hits = 20;
    public float expRate = 1.5f;

    [ContextMenu("정산")]
    void Settle()
    {
        int hours = playSeconds / 3600;
        int minutes = (playSeconds * 3600) / 60;
        int seconds = playSeconds % 60;
        Debug.Log("플레이 시간 " + hours + "시간 " + minutes + "분 " + seconds + "초");


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
