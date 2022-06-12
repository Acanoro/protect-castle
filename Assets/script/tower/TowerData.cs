using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerData : MonoBehaviour
{
    public List<TowerLevel> levels;
    private TowerLevel currentLevel;

    [System.Serializable]  // this allows us to quickly change all values ​​of the Level class, even when the game is running
    public class TowerLevel
    {
        public int cost;
        public GameObject visualization;
    }

    public TowerLevel CurrentLevel
    {
        get
        {
            return currentLevel;
        }
        set
        {
            currentLevel = value;
            int currentLevelIndex = levels.IndexOf(currentLevel);

            GameObject levelVisualization = levels[currentLevelIndex].visualization;
            for (int i = 0; i < levels.Count; i++)
            {
                if (levelVisualization != null)
                {
                    if (i == currentLevelIndex)
                    {
                        levels[i].visualization.SetActive(true);
                    }
                    else
                    {
                        levels[i].visualization.SetActive(false);
                    }
                }
            }
        }
    }

    private void OnEnable()
    {
        CurrentLevel = levels[0];
    }
}
