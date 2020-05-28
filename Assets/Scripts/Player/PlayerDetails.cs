using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerDetails : MonoBehaviour
{
    public Text deathsNumText;
    void Start()
    {
        print("Number of deaths: " + GameManager.deaths);
        deathsNumText.text = ("Number of Deaths: ") + GameManager.deaths.ToString();
    }
}
