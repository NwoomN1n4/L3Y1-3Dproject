using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public float timer;
    public TMP_Text timerText; 
    public float timeLimit;
    // Start is called before the first frame update
    void Start()
    {
        timer = timeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        timerText.text = timer.ToString("F2");

        if (timer <= 0)
        {
            Debug.Log("Out of Time.");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        else
        {
          timer -= Time.deltaTime;
        }
    }
}
