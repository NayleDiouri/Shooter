using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet2 : MonoBehaviour
{
    public GameObject bonus;
    public Transform bulletTransform;
    public Rigidbody2D monRigidBody;
    public float speed;
    private int chance;
    public float bulletHP = 5;
    // Start is called before the first frame update
    void Start()
    {
        monRigidBody.velocity = Vector3.up * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ennemies2 bullet = collision.gameObject.GetComponent<Ennemies2>();
        bulletHP -= 1; 
        bulletTransform.localScale = bulletTransform.localScale - new Vector3(gameObject.transform.localScale.x - 0.25f, gameObject.transform.localScale.x - 0.25f); 

        if (bulletHP == 0)
        {
            Destroy(gameObject);
        }
        if (collision.gameObject.tag == "enemy")
        {
            chance = Random.Range(0, 4);
            Destroy(collision.gameObject);
            if (chance == 2)
            {
                Instantiate(bonus, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            }

        }
        if (collision.gameObject.tag == "enemy2")
        {
            bullet.ennemies2HP -= 1;
            print(bullet.ennemies2HP);
            if (bullet.ennemies2HP <= 0)
            {
                Destroy(collision.gameObject);
            }
        }
    }

}
