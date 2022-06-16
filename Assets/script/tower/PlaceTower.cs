using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{
    private GameObject tower;  // object to be handled during the game

    public GameObject GetTower()
    {
        return tower;
    }

    public void SetTower(GameObject Tower)
    {
        tower = Tower;
    }

    private void OnMouseUp()
    {
        if (tower == null)
        {
            transform.Find("tower selection").gameObject.SetActive(true);
        }
        else
        {
            transform.Find("tower work").gameObject.SetActive(true);
        }
    }
}
