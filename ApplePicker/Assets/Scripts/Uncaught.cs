using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Uncaught : MonoBehaviour
{
    GameManager gameManager;
    public static int uncaughtApples;

    [SerializeField]
    private TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Uncaught: " + uncaughtApples;
        if (uncaughtApples >= 3)
        {
            gameManager.Restart();
        }
    }
}
