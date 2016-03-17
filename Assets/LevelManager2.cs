using UnityEngine;
using System.Collections;

public class LevelManager2 : MonoBehaviour {
    public void LoadScene(string name) {
        Application.LoadLevel(name);
    }
}
