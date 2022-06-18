using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingTower : MonoBehaviour
{
    public PlaceTower placeTower;

    public BuildingTower towerOne;
    public BuildingTower towerTwo;
    public BuildingTower towerThree;


    public GameObject towerPrefab;
    public GameObject towerTransparentPrefab;

    private GameManagerBehavior gameManagere;  // to access the GameManager Behavior component of the scene's GameManager object

    private bool selectedTower = false;

    public bool SelectedTower
    {
        get
        {
            return selectedTower;
        }
        set
        {
            selectedTower = value;
        }
    }

    public bool CanPlaceTower()
    {
        int cost = towerPrefab.GetComponent<TowerData>().levels[0].cost;
        return placeTower.Tower == null && gameManagere.Gold >= cost;
    }

    public void CheckingExample()
    {
        if (placeTower.TowerExample)
        {
            Destroy(placeTower.TowerExample);
            towerOne.selectedTower = false;
            towerTwo.selectedTower = false;
            towerThree.selectedTower = false;
        }
    }

    // positions the tower on mouse click or screen touch
    public void Click()
    {
        if (CanPlaceTower())
        {
            if (selectedTower)
            {
                Destroy(placeTower.TowerExample);
                placeTower.Tower = Instantiate(towerPrefab, placeTower.transform.position, Quaternion.identity);
                gameManagere.Gold -= placeTower.Tower.GetComponent<TowerData>().CurrentLevel.cost;
                placeTower.transform.Find("tower selection").gameObject.SetActive(false);
                selectedTower = false;
            }
        }
        if (!selectedTower && placeTower.Tower == null)
        {
            CheckingExample();
            placeTower.TowerExample = Instantiate(towerTransparentPrefab, placeTower.transform.position, Quaternion.identity);
            selectedTower = true;
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameManagere = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
    }

}
