using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public GameObject bonus;
    public Rigidbody2D myRigidBody;
    public float speed;
    private int chance;
    // Start is called before the first frame update
    void Start()
    {
        myRigidBody.velocity = Vector3.up * speed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Ennemies2 bullet = collision.gameObject.GetComponent<Ennemies2>();

        if (collision.gameObject.tag == "enemy")
        {
            chance = Random.Range(0, 10);
            Destroy(collision.gameObject);
            Destroy(gameObject);
            if (chance == 2)
            {
                Instantiate(bonus, collision.gameObject.transform.position, collision.gameObject.transform.rotation);
            }

        }
        if (collision.gameObject.tag == "enemy2")
        {
            bullet.ennemies2HP -= 1;
            Destroy(gameObject);
            print(bullet.ennemies2HP);
            if (bullet.ennemies2HP <= 0)
            {
                Destroy(collision.gameObject);
            }
        }
    }



}
