using UnityEngine;
using TMPro;

public class TimerUI : MonoBehaviour
{
    public TextMeshProUGUI timeText;

    float tiempo = 0f;
    bool gameOver = false;

    void Update()
    {
        if (!gameOver)
        {
            tiempo += Time.deltaTime;

            timeText.text = tiempo.ToString("0.00");
        }
    }

    public void StopTimer()
    {
        gameOver = true;
    }
}