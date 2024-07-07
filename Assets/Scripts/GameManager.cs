using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager gameManagerInstance;
    public int countTracks,numberOfMoves;
    public bool victorybool, losebool;

    public TextMeshProUGUI winDisplay;
    public TextMeshProUGUI loseDisplay;
    void Start()
    {
        if (gameManagerInstance == null)
            gameManagerInstance = this;

        countTracks = GameObject.FindGameObjectsWithTag("path").Length;

        numberOfMoves = countTracks + 5;

    }

    public void Victory()
    {
        if (countTracks.Equals(0) && !losebool)
        {
            victorybool = true;
            winDisplay.enabled = true;

            //tyouWin.setEnaeDI
            Debug.Log("You Win!");
        }
    }

    public void Lose()
    {
        if (losebool | numberOfMoves.Equals(0) && !victorybool)
        {
            loseDisplay.enabled = true;
            Debug.Log("You Lose!");
        }
    }
}
