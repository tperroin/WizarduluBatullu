using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{

    public GUIText looseText;
    public GUIText winText;

    private bool win;
    private bool loose;

    void Start()
    {
        win = false;
        loose = false;
        looseText.text = "";
        winText.text = "";
    }

    public void Win()
    {
        winText.text = "You win!";
        win = true;
    }

    public void Loose()
    {
        looseText.text = "You loose!";
        loose = true;
    }
}