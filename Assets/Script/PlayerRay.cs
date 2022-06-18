using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    public PlaceTower placeTower;
    public BuildingTower buildingTower;

    private void showTowerSelection()
    {
        if (placeTower.Tower == null)
        {
            placeTower.transform.Find("tower selection").gameObject.SetActive(true);
        }
        else
        {
            placeTower.transform.Find("tower work").gameObject.SetActive(true);
        }
    }

    private void hideTowerSelection()
    {
        if (placeTower.Tower == null)
        {
            placeTower.transform.Find("tower selection").gameObject.SetActive(false);
        }
        else
        {
            placeTower.transform.Find("tower work").gameObject.SetActive(false);
        }
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit))
        {
            if (Input.GetMouseButtonDown(0))
            {
                PlaceTower temporaryPlaceTower = hit.collider.gameObject.GetComponent<PlaceTower>();
                if (placeTower == null && temporaryPlaceTower)
                {
                    placeTower = temporaryPlaceTower;
                    showTowerSelection();
                }
                else if (temporaryPlaceTower)
                {
                    hideTowerSelection();

                    if (placeTower.TowerExample)
                    {
                        Destroy(placeTower.TowerExample);
                        buildingTower.SelectedTower = false;
                        buildingTower = null;
                    }

                    placeTower = temporaryPlaceTower;
                    showTowerSelection();
                }

                BuildingTower temporarybuildingTower = hit.collider.gameObject.GetComponent<BuildingTower>();
                if (temporarybuildingTower)
                {
                    buildingTower = temporarybuildingTower;
                    if (buildingTower.SelectedTower)
                    {
                        buildingTower.Click();
                        placeTower = null;
                        buildingTower = null;
                    }
                    else
                    {
                        buildingTower.Click();
                    }
                }

                TowerUpgrade towerUpgrade = hit.collider.gameObject.GetComponent<TowerUpgrade>();
                if (towerUpgrade)
                {
                    towerUpgrade.Click();
                }

                TowerRemoval towerRemoval = hit.collider.gameObject.GetComponent<TowerRemoval>();
                if (towerRemoval)
                {
                    towerRemoval.Click();
                }
            }
        }
        else
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (placeTower)
                {
                    hideTowerSelection();
                }
                if (buildingTower)
                {
                    Destroy(placeTower.TowerExample);
                    buildingTower.SelectedTower = false;
                }

                placeTower = null;
                buildingTower = null;
            }
        }
    }
}
