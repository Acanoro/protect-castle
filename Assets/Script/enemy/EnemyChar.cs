using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChar : MonoBehaviour
{

    public int Gold;
    public int Health;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Health -= 10;
        if (Health <= 0)
        {
            Gold += 15;
        }
    }
}
