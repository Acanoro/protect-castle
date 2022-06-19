using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{
    private GameObject tower;  // object to be handled during the game

    public GameObject Tower
    {
        get
        {
            return tower;
        }
        set
        {
            tower = value;
        }
    }
}
