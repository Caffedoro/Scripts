using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public GameEnding gameEnding;
    public float timer;
    
    public TextMeshProUGUI timerText;


    
    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        UpdateText();


        if (timer <= 0)
        {
            gameEnding.CaughtPlayer();
        }
    }

    void Start()
    {
        timer = 60;


        UpdateText();
    }

    void UpdateText()
    {
        timerText.text = "Timer: " + timer;
    }


}
