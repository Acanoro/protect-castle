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
}
