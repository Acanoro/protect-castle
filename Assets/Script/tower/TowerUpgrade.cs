using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerUpgrade : MonoBehaviour
{
    private GameManagerBehavior gameManagere;  // to access the GameManager Behavior component of the scene's GameManager object
    public PlaceTower Object;

    // positions the tower on mouse click or screen touch
    void OnMouseUp()
    {
        if (CanUpgradeTower())
        {
            Object.Tower.GetComponent<TowerData>().IncreaseLevel();
            gameManagere.Gold -= Object.Tower.GetComponent<TowerData>().CurrentLevel.cost;
            Object.transform.Find("tower work").gameObject.SetActive(false);
        }
    }

    private bool CanUpgradeTower()
    {
        if (Object.Tower != null)
        {
            TowerData towerData = Object.Tower.GetComponent<TowerData>();
            TowerLevel nextLevel = towerData.GetNextLevel();
            if (nextLevel != null)
            {
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
