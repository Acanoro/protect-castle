using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerUpgrade : MonoBehaviour
{
    private GameManagerBehavior gameManagere;  // to access the GameManager Behavior component of the scene's GameManager object
    public PlaceTower placeTower;

    private bool selectedImprovement = false;

    // positions the tower on mouse click or screen touch
    public void Click()
    {
        if (CanUpgradeTower())
        {
            if (selectedImprovement)
            {
                placeTower.Tower.GetComponent<TowerData>().IncreaseLevel();
                gameManagere.Gold -= placeTower.Tower.GetComponent<TowerData>().CurrentLevel.cost;
                placeTower.transform.Find("tower work").gameObject.SetActive(false);
                selectedImprovement = false;
            }
        }
        if (!selectedImprovement)
        {
            Debug.Log("1");
            selectedImprovement = true;
        }
    }

    private bool CanUpgradeTower()
    {
        if (placeTower.Tower != null)
        {
            TowerData towerData = placeTower.Tower.GetComponent<TowerData>();
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
