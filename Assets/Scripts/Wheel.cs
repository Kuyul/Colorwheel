using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Destroy colliding gameobject if the colour of the wheel matches the sphere
        if (gameObject.tag == collision.tag)
        {
            collision.gameObject.SetActive(false);
            Instantiate(GameControl.instance.pe1, collision.transform.position, Quaternion.identity);
        }

        else
        {
            //Pattern objects have a collider attached to them, the game shouldn't end when the wheel meets the collider
            if (collision.tag != "pattern")
            {
               GameControl.instance.EndGame();
            }
        }
    }
}
