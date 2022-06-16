using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerRemoval : MonoBehaviour
{
    public PlaceTower Object;

    void OnMouseUp()
    {
        Object.SetTower(null);
    }
}
