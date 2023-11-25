using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ennemies2 : MonoBehaviour
{
    public int ennemies2HP = 3;
    public Transform enemy2Transform;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        enemy2Transform.position = enemy2Transform.position + new Vector3(0, -0.005f);
    }
}
