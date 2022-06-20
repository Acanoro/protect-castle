using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManagerBehavior : MonoBehaviour
{
    public Text goldLabel;  // reference to the Text component used to display the amount of gold the player has

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

    // Start is called before the first frame update
    void Start()
    {
        Gold = 500;
    }
}
