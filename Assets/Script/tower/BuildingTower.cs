using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingTower : MonoBehaviour
{
    public PlaceTower Object;
    public GameObject towerPrefab;
/*    public GameObject towerTransparentPrefab;*/

    private GameManagerBehavior gameManagere;  // to access the GameManager Behavior component of the scene's GameManager object

/*    private bool selectedTower = false;*/

    public bool CanPlaceTower()
    {
        int cost = towerPrefab.GetComponent<TowerData>().levels[0].cost;
        return Object.Tower == null && gameManagere.Gold >= cost;
    }

    // positions the tower on mouse click or screen touch
    void OnMouseUp()
    {

        if (CanPlaceTower())
        {
            Object.Tower = Instantiate(towerPrefab, Object.transform.position, Quaternion.identity);
            gameManagere.Gold -= Object.Tower.GetComponent<TowerData>().CurrentLevel.cost;
            Object.transform.Find("tower selection").gameObject.SetActive(false);
            /*            if (selectedTower)
                        {
                            Destroy(Object.TowerExample);
                            Object.Tower = Instantiate(towerPrefab, Object.transform.position, Quaternion.identity);
                            gameManagere.Gold -= Object.Tower.GetComponent<TowerData>().CurrentLevel.cost;
                            Object.transform.Find("tower selection").gameObject.SetActive(false);
                            selectedTower = false;
                        }
                        else
                        {
                            Object.TowerExample = Instantiate(towerTransparentPrefab, Object.transform.position, Quaternion.identity);
                            selectedTower = true;
                        }*/
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        gameManagere = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
    }

/*    void Update()
    {
        Debug.Log(Input.mousePresent);
*//*        if (Input.GetMouseButtonUp(1))
        {
            Destroy(Object.TowerExample);
            selectedTower = false;
        }*//*
    }*/
}
