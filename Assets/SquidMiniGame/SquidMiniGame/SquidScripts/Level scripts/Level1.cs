using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1 : GameController_Script
{
    public float victorTime = 200.0f;
    private float countTime = 0;
    // Start is called before the first frame update
    public override void Start()
    {
        StartCoroutine(asteroidSpawnWaves());
    }
    public void FixedUpdate()
    {
        countTime += Time.fixedDeltaTime;
        if(countTime >= victorTime)
            UnityEngine.SceneManagement.SceneManager.LoadScene("Scene_01");
    }
}
