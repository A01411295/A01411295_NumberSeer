using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Seer : MonoBehaviour {
    private int min;
    private int max;
    private levelManager levelManager;
    private int guess;
    public int attempts;
    public Text guessLable;
	// Use this for initialization
	void Start () {
        levelManager = FindObjectOfType<levelManager>();
        StartGame();
        ShowGuess();
	}
    void StartGame()
    {
        min = 1;
        max = 1001;
        NextGuess();
    }
	public void NextGuess()
    {
        guess = Random.Range(min, max);
        attempts -= 1;
        ShowGuess();
    }
    public void ShowGuess()
    {
        if (attempts < 0)
        {
            levelManager.loadLevel("win");
        }
        else
        {
            guessLable.text = "I've entered your mind and I know the number is " + guess + ", isn't it?";
        }
        

    }
    public void Update()
    {

    }
    public void GuessHigher()
    {
        min = guess;
        NextGuess();
        
        
    }
    public void GuessLower()
    {
        max = guess;
        NextGuess();
    }
    public void CorrectGuess()
    {
        levelManager.loadLevel("lose");
    }

}
