using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (gameObject.tag == "1")
        {
            if (collision.tag == "1")
            {
                collision.gameObject.SetActive(false);
            }
            else if (collision.tag != "1" && collision.tag != "pattern")
            {
                GameControl.instance.EndGame();
            }
        }

        if (gameObject.tag == "2")
        {
            if (collision.tag == "2")
            {
                collision.gameObject.SetActive(false);
            }
            else if (collision.tag != "2" && collision.tag != "pattern")
            {
                GameControl.instance.EndGame();
            }
        }

        if (gameObject.tag == "3")
        {
            if (collision.tag == "3")
            {
                collision.gameObject.SetActive(false);
            }
            else if (collision.tag != "3" && collision.tag != "pattern")
            {
                GameControl.instance.EndGame();
            }
        }

        if (gameObject.tag == "4")
        {
            if (collision.tag == "4")
            {
                collision.gameObject.SetActive(false);
            }
            else if(collision.tag != "4" && collision.tag != "pattern")
            {
                GameControl.instance.EndGame();
            }
        }
    }
}
