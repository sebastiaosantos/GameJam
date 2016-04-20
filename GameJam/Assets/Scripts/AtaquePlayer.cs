using UnityEngine;
using System.Collections;
using System;

public class AtaquePlayer : MonoBehaviour
{

    public float velocidade;
    // Use this for initialization
    void Start()
    {

        Destroy(gameObject, 5f);
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(Vector2.right * velocidade * Time.deltaTime);


    }

    void OnCollisionEnter2D(Collision2D colisor)
    {
        if (colisor.gameObject.tag == "Inimigo")
        {

            Destroy(colisor.gameObject);

            Destroy(gameObject);
        }

    }
}


