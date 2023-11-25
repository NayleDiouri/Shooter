using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemies : MonoBehaviour
{
    public Transform enemyTransform;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        enemyTransform.position = enemyTransform.position + new Vector3(0, -0.005f);
    }
}
