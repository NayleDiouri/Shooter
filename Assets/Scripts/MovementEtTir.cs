using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementEtTir : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bullet2;
    public GameObject laser;

    public Transform parent;
    public Transform limitL;
    public Transform limitR;
    public bool bonusShoot;

    public float speed = 0.2f;
    public shootMods myShootMods;


    public enum shootMods
    {
        shootMod1,
        shootMod2,
        shootMod3
    }

    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        switch (myShootMods)
        {
            case shootMods.shootMod1:
                break;
            case shootMods.shootMod2:
                break;
            case shootMods.shootMod3:
                break;
            default:
                break;
        }
        if (Input.GetKeyDown(KeyCode.C) && myShootMods == shootMods.shootMod1)
        {
            myShootMods = shootMods.shootMod2;
        }
        else if (Input.GetKeyDown(KeyCode.C) && myShootMods == shootMods.shootMod2)
        {
            myShootMods = shootMods.shootMod3;
        }
        else if (Input.GetKeyDown(KeyCode.C) && myShootMods == shootMods.shootMod3)
        {
            myShootMods = shootMods.shootMod1;
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * speed;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * speed;
        }
        if (Input.GetKeyDown(KeyCode.Space) && myShootMods == shootMods.shootMod1)
        {
            Instantiate(bullet, parent.position, parent.rotation);
            if (bonusShoot == true)
            {
                Instantiate(bullet, new Vector2(parent.position.x + 0.5f, parent.position.y - 0.1f), parent.rotation);
                Instantiate(bullet, new Vector2(parent.position.x - 0.5f, parent.position.y - 0.2f), parent.rotation);
            }
        }
        if (Input.GetKeyDown(KeyCode.Space) && myShootMods == shootMods.shootMod2)
        {
            Instantiate(bullet2, new Vector2(parent.position.x, parent.position.y + 0.5f), parent.rotation);
        }

        if (Input.GetKeyDown(KeyCode.Space) && myShootMods == shootMods.shootMod3)
        {
            Instantiate(laser, new Vector2(parent.position.x, parent.position.y + 6f), parent.rotation);
            Invoke("destroyLaser", 0.2f);
        }

        if (transform.position.x < limitL.position.x)
        {
            transform.position = new Vector3(limitR.position.x, transform.position.y, transform.position.z);
        }
        if (transform.position.x > limitR.position.x)
        {
            transform.position = new Vector3(limitL.position.x, transform.position.y, transform.position.z);
        }
    }
    public void destroyLaser()
    {
        Destroy(laser);
    }

}