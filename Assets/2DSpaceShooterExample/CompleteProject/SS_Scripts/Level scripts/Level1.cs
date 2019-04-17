using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : GameController_Script
{
    // Start is called before the first frame update
    public override void Start()
    {
        StartCoroutine(asteroidSpawnWaves());
    }
}
