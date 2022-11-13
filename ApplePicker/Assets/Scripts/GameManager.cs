using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private TextMeshProUGUI myText;
   
    private float countTime = 3f;

    void Start()
    {
        Time.timeScale = 1.0f;
        StartCoroutine("Counting");
    }

    // Update is called once per frame
    void Update()
    {
        countTime -= Time.deltaTime;
        myText.text = Mathf.Clamp(Mathf.CeilToInt(countTime), 0, int.MaxValue).ToString();
        myText.fontSize += 1.2f;
        Debug.Log(myText.fontSize);
        if (countTime <= 0)
        {
            Destroy(myText);
        }
    }

    IEnumerator Counting()
    {
        yield return new WaitForSeconds(1f);
        myText.fontSize = 20;
        yield return new WaitForSeconds(1f);
        myText.fontSize = 20;
        yield return new WaitForSeconds(1f);
        myText.fontSize = 20;
        yield break;
    }
}
