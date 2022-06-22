using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManagerBehavior : MonoBehaviour
{
    public Text goldLabel;  // reference to the Text component used to display the amount of gold the player has
    public Text waveLabel; // stores a reference to the wave number output label
    public bool gameOver = false;

    private int gold;
    public int Gold
    {
        get
        {
            return gold;
        }
        set
        {
            gold = value;
            goldLabel.GetComponent<Text>().text = gold.ToString();
        }
    }

    private int wave;
    public int Wave
    {
        get
        {
            return wave;
        }
        set
        {
            wave = value;
            waveLabel.text = (wave + 1).ToString();
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        Gold = 500;
        wave = 0;
    }
}
