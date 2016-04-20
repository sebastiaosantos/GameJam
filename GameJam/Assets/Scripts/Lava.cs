using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Lava : MonoBehaviour {

    // Variável publica do Tipo Tansform para pegar o tranform do Player
    private Transform player;

    // Use this for initialization
    void Start () {

        //  variavel player vai receber o transforme do objeto que tá com a Tag "Player" no caso nosso personagem
        player = GameObject.FindGameObjectWithTag("Player").transform;

    }

    // Update is called once per frame
    void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D colisor)
    {
        if (colisor.gameObject.tag == "Player")
        {
            var player = colisor.gameObject.GetComponent<Vida>();
            player.Damage(player.vidaCheia);
        }
    }
   
   
}
