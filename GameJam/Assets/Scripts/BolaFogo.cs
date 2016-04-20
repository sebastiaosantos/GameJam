using UnityEngine;
using System.Collections;

public class BolaFogo : MonoBehaviour {


    private float posicaoY = 0f;


    // Use this for initialization
    void Start () {

        Destroy(gameObject, 2f);
       GetComponent<Rigidbody2D>().AddForce(transform.up * 400f);
        posicaoY = transform.position.y;
    }
	
	// Update is called once per frame
	void Update () {

        if (posicaoY > transform.position.y)
        { //Descendo
            transform.eulerAngles = new Vector2(180, 0);
        }
        posicaoY = transform.position.y;

    }

    // ao colidir com o player irar causar dano pegando o compomente Vida que é script exclusivo para vida
    void OnCollisionEnter2D(Collision2D colisor)
    {
        if (colisor.gameObject.tag == "Player")
        {
            var player = colisor.gameObject.GetComponent<Vida>();
            player.Damage(10f);
        }
        Destroy(gameObject);
    }
    
}
