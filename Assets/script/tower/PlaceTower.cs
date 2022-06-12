using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{
    public GameObject towerPrefab;  // building a tower
    public GameObject tower;  // object to be handled during the game

    // put only one tower
    private bool CanPlaceTower()
    {
        return tower == null;
    }

    // positions the tower on mouse click or screen touch
    private void OnMouseUp()
    {
        if (CanPlaceTower())
        {
            tower = (GameObject) Instantiate(towerPrefab, transform.position, Quaternion.identity);
        }
    }
}
