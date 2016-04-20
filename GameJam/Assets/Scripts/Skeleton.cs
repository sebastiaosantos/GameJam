using UnityEngine;
using System.Collections;

public class Skeleton : MonoBehaviour {


    public float velocidade;
    public bool direcao;
    public float duracaoDirecao;

    private float tempoNaDirecao;
    private Animator animator;

    // Use this for initialization
    void Start () {

        animator = gameObject.transform.GetComponent<Animator>();

    }
	
	// Update is called once per frame
	void Update () {
        // se direcao for true ele irar andar para direita
        if (direcao)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }
        else {
            transform.eulerAngles = new Vector2(0, 180);
        }
        transform.Translate(Vector2.right * velocidade * Time.deltaTime);

        tempoNaDirecao += Time.deltaTime;
        if (tempoNaDirecao >= duracaoDirecao)
        {
            tempoNaDirecao = 0;
            direcao = !direcao;
        }

    }
    // se o player colidir com o skeleto ele ativa o Trigger da animação e mostra ele atacando e depois tira vida do personagem e empurra ele pra trás;
    void OnCollisionEnter2D(Collision2D colisor)
    {
        if (colisor.gameObject.tag == "Player")
        {
            gameObject.GetComponent<AudioSource>().Play();
            animator.SetTrigger("atacou");
            var player = colisor.gameObject.transform.GetComponent<Vida>();

            player.Damage(10f);
            colisor.gameObject.transform.Translate(-Vector2.right);
        }
    }
}
