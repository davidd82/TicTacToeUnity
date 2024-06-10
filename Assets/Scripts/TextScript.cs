using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextScript : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject XWinsBG;
    GameObject OWinsBG;
    void Start()
    {
        XWinsBG = GameObject.Find("XWinsBG");
        XWinsBG.SetActive(false);   
        
        OWinsBG = GameObject.Find("OWinsBG");
        OWinsBG.SetActive(false); 
    } 

    public void DisplayWinner(int player)
    {
        if (player == 0) {
            XWinsBG.SetActive(true);
        } else {
            OWinsBG.SetActive(true);
        }
    }
}
