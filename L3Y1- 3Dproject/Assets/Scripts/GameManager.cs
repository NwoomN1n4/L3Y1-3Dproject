using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [Header("Timer")]
    public float timer;
    public TMP_Text timerText; 
    public float timeLimit;


    [Header("Collectables")]

    public int requiredCollectables;
    public int currentCollectables;
    public TMP_Text collectablesText;

    // Start is called before the first frame update
    void Start()
    {
        timer = timeLimit;
    }

    // Update is called once per frame
    void Update()
    {
        GameTimer();
        // Collectables();
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }
    void Collectables()
    {
        collectablesText.text = currentCollectables + " / " + requiredCollectables;
        if (currentCollectables == requiredCollectables)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    void GameTimer()
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
