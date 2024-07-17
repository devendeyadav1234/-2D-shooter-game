using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayManager : MonoBehaviour
{
    public static GamePlayManager instance;
    [SerializeField] GameObject targetPrefab; // It is private and we can also see in the inspector
    int score = 0;
    [SerializeField] Text scoreText;
    [SerializeField] GameObject winPanel;
    bool hasWon = false;

    private void Awake()
    {
        if (instance == null) 
        {
            instance = this;
        }
    }

    private void Start()
    {
        winPanel.SetActive(false);
        // InvokeRepeating("SpawnTarget", 1f, 1f);
    }

    public void startSpawningTargets() 
    {
        scoreText.text = "0";
        InvokeRepeating("SpawnTarget", 1f, 1f);
    }

    private void Update()
    {
        if(hasWon)
        {
            CancelInvoke("SpawnTarget");  
        }
    }
    void SpawnTarget() 
    {
        float xPos = Random.Range(-7.1f,7.1f);
        float yPos = Random.Range(-3.1f,3.1f);
        Vector3 randomTargetPos = new Vector3(xPos, yPos, 0);
        Instantiate(targetPrefab,randomTargetPos,Quaternion.identity); // Don't want rotation
    }

    public void IncrementScore() 
    {
        score++;
        scoreText.text = score.ToString();
        if (score >= 10)
        { 
            winPanel.SetActive(true);
            hasWon = true;
        }
    }

}
