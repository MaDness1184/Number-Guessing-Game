using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NumberWizard : MonoBehaviour
{
    public int max = 1000;
    public int min = 1;
    public TextMeshProUGUI guessText;
    public int guess = 500;

    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    public void OnPressHigher()
    {
        min = guess + 1;
        NextGuess();
    }

    public void OnPressLower()
    {
        max = guess - 1;
        NextGuess();
    }

    public void StartGame()
    {
        NextGuess();
        max = max + 1;
    }

    public void NextGuess()
    {
        guess = Random.Range(min, max + 1);
        guessText.text = guess.ToString();
    }

}
