using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{
    private GameObject tower;  // object to be handled during the game
    private GameObject towerExample;

    public GameObject TowerExample
    {
        get
        {
            return towerExample;
        }
        set
        {
            towerExample = value;
        }
    }

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

/*    private void OnMouseUp()
    {
        if (tower == null)
        {
            transform.Find("tower selection").gameObject.SetActive(true);
        }
        else
        {
            transform.Find("tower work").gameObject.SetActive(true);
        }
    }*/
}
