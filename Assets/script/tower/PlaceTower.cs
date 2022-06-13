using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{
    public GameObject towerPrefab;  // building a tower
    private GameObject tower;  // object to be handled during the game
    private GameManagerBehavior gameManagere;  // to access the GameManager Behavior component of the scene's GameManager object

    // put only one tower
    private bool CanPlaceTower()
    {
        int cost = towerPrefab.GetComponent<TowerData>().levels[0].cost;
        return tower == null && gameManagere.Gold >= cost;
    }

    // positions the tower on mouse click or screen touch
    private void OnMouseUp()
    {
        if (CanPlaceTower())
        {
            tower = Instantiate(towerPrefab, transform.position, Quaternion.identity);

            gameManagere.Gold -= tower.GetComponent<TowerData>().CurrentLevel.cost;
        }
        else if (CanUpgradeTower())
        {
            tower.GetComponent<TowerData>().IncreaseLevel();

            gameManagere.Gold -= tower.GetComponent<TowerData>().CurrentLevel.cost;
        }
    }

    private bool CanUpgradeTower()
    {
        if (tower != null)
        {
            TowerData towerData = tower.GetComponent<TowerData>();
            TowerLevel nextLevel = towerData.GetNextLevel();
            if (nextLevel != null)
            {
                Debug.Log("1");
                return gameManagere.Gold >= nextLevel.cost;
            }
        }
        return false;
    }

    // Start is called before the first frame update
    void Start()
    {
        gameManagere = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
    }
}
