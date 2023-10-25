using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bonus : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        MovementEtTir player = collision.gameObject.GetComponent<MovementEtTir>();
        if (player != null)
        {
            player.bonusShoot = true;
            Destroy(gameObject);
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }




}
