using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingTower : MonoBehaviour
{
    public GameObject towerPrefab;
    private GameManagerBehavior gameManagere;  // to access the GameManager Behavior component of the scene's GameManager object
    public PlaceTower Object;

    public bool CanPlaceTower()
    {
        int cost = towerPrefab.GetComponent<TowerData>().levels[0].cost;
        return Object.GetTower() == null && gameManagere.Gold >= cost;
    }

    // positions the tower on mouse click or screen touch
    void OnMouseUp()
    {
        if (CanPlaceTower())
        {
            Object.SetTower(Instantiate(towerPrefab, Object.transform.position, Quaternion.identity));

            gameManagere.Gold -= Object.GetTower().GetComponent<TowerData>().CurrentLevel.cost;

            Object.transform.Find("tower selection").gameObject.SetActive(false);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameManagere = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
    }
}
