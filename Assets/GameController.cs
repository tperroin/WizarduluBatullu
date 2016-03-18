using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

    public GUIText loseText;
    public GUIText winText;

    private bool win;
    private bool lose;

    void Start()
    {
        win = false;
        lose = false;
        loseText.text = "";
        winText.text = "";
    }

    public void Win()
    {
        winText.text = "You win!";
        win = true;
    }

    public void Lose()
    {
        loseText.text = "You lose!";
        lose = true;
    }
}