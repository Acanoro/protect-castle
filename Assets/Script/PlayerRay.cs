using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRay : MonoBehaviour
{
    private PlaceTower placeTower;
    private BuildingTower buildingTower;
    private TowerUpgrade towerUpgrade;

    public GameObject descriptionTowerBuild;
    public GameObject descriptionTowerUpgrade;

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

    public void ExitBuild()
    {
        buildingTower = null;
        showTowerSelection();
    }

    public void ExitUpgrade()
    {
        towerUpgrade = null;
        showTowerSelection();
    }

    public void Build()
    {
        hideTowerSelection();
        buildingTower.Click();
        buildingTower = null;
        placeTower = null;
    }

    public void Ubgrade()
    {
        hideTowerSelection();
        towerUpgrade.Click();
        buildingTower = null;
        placeTower = null;
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
                    if ((placeTower.Tower == null && descriptionTowerBuild.activeSelf == false) || (placeTower.Tower && descriptionTowerUpgrade.activeSelf == false))
                    {
                        hideTowerSelection();
                        placeTower = temporaryPlaceTower;
                        showTowerSelection();
                    }
                }

                BuildingTower temporarybuildingTower = hit.collider.gameObject.GetComponent<BuildingTower>();
                if (temporarybuildingTower)
                {
                    buildingTower = temporarybuildingTower;
                    if (placeTower.Tower)
                    {
                        descriptionTowerUpgrade.SetActive(true);
                    }
                    else
                    {
                        descriptionTowerBuild.SetActive(true);
                    }
                    hideTowerSelection();
                }

                TowerUpgrade temporaryTowerUpgrade = hit.collider.gameObject.GetComponent<TowerUpgrade>();
                if (temporaryTowerUpgrade)
                {
                    towerUpgrade = temporaryTowerUpgrade;
                    if (placeTower.Tower)
                    {
                        descriptionTowerUpgrade.SetActive(true);
                    }
                    else
                    {
                        descriptionTowerBuild.SetActive(true);
                    }
                    hideTowerSelection();
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
            if (Input.GetMouseButtonDown(0) && placeTower)
            {
                if ((placeTower.Tower == null && descriptionTowerBuild.activeSelf == false) || (placeTower.Tower && descriptionTowerUpgrade.activeSelf == false))
                {
                    if (placeTower)
                    {
                        hideTowerSelection();
                    }
                    placeTower = null;
                    buildingTower = null;
                }
            }
        }
    }
}