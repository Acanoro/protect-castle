using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerRemoval : MonoBehaviour
{
    public PlaceTower Object;
    private GameManagerBehavior gameManagere;  // to access the GameManager Behavior component of the scene's GameManager object

    void OnMouseUp()
    {
        Destroy(Object.GetTower());
        gameManagere.Gold += Object.GetTower().GetComponent<TowerData>().CurrentLevel.refundAmount;
        Object.transform.Find("tower work").gameObject.SetActive(false);
    }

    // Start is called before the first frame update
    void Start()
    {
        gameManagere = GameObject.Find("GameManager").GetComponent<GameManagerBehavior>();
    }
}
