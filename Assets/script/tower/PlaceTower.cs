using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlaceTower : MonoBehaviour
{
    private GameObject tower;  // object to be handled during the game

    public Text nameLabel;
    public Text strengthLabel;
    public Text rateOfFireLabel;
    public Text attackRadiusLabel;
    public Image iconTower;

    public GameObject towerBuild;
    public GameObject towerUpgrade;

    public GameObject Tower
    {
        get
        {
            return tower;
        }
        set
        {
            tower = value;
        }
    }

    public void Filling()
    {
        iconTower.GetComponent<Image>().sprite = tower.GetComponent<TowerData>().icon;
        nameLabel.GetComponent<Text>().text = tower.GetComponent<TowerData>().Name;
        strengthLabel.GetComponent<Text>().text = tower.GetComponent<TowerData>().CurrentLevel.strength;
        rateOfFireLabel.GetComponent<Text>().text = tower.GetComponent<TowerData>().CurrentLevel.rateOfFire;
        attackRadiusLabel.GetComponent<Text>().text = tower.GetComponent<TowerData>().CurrentLevel.attackRadius;
    }

/*    public void FillingTowerBuild()
    {
        towerBuild.transform.Find("TowerImg").GetComponent<Image>().sprite = tower.GetComponent<TowerData>().CurrentLevel[1].img;
        towerBuild.transform.Find("TowerNameLabel").GetComponent<Text>().text = tower.GetComponent<TowerData>().Name;
        towerBuild.transform.Find("StrangeLabel").GetComponent<Text>().text = tower.GetComponent<TowerData>().CurrentLevel.strength;
        towerBuild.transform.Find("SpeedLabel").GetComponent<Text>().text = tower.GetComponent<TowerData>().CurrentLevel.rateOfFire;
        towerBuild.transform.Find("RadiousLabel").GetComponent<Text>().text = tower.GetComponent<TowerData>().CurrentLevel.attackRadius;
        towerBuild.transform.Find("CostLabel").GetComponent<Text>().text = tower.GetComponent<TowerData>().CurrentLevel.cost.ToString();
    }

    public void FillingTowerUpgrade()
    {
        towerUpgrade.transform.Find("TowerImg").GetComponent<Image>().sprite = tower.GetComponent<TowerData>().CurrentLevel.img;
        towerUpgrade.transform.Find("TowerNameLabel").GetComponent<Text>().text = tower.GetComponent<TowerData>().Name;
        towerUpgrade.transform.Find("StrangeLabel").GetComponent<Text>().text = tower.GetComponent<TowerData>().CurrentLevel.strength;
        towerUpgrade.transform.Find("SpeedLabel").GetComponent<Text>().text = tower.GetComponent<TowerData>().CurrentLevel.rateOfFire;
        towerUpgrade.transform.Find("RadiousLabel").GetComponent<Text>().text = tower.GetComponent<TowerData>().CurrentLevel.attackRadius;
        towerUpgrade.transform.Find("CostLabel").GetComponent<Text>().text = tower.GetComponent<TowerData>().CurrentLevel.cost.ToString();
    }*/
}
