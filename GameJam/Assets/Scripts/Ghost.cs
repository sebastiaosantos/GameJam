using UnityEngine;
using System.Collections;

public class Ghost : MonoBehaviour {

    public float intervaloAtaque;
    private float contagemIntervalo;
    private bool atacou;
    public float distanciaAtaque;


    public GameObject ataque;
    public GameObject player;

    private Animator animator;

    public Transform posAtaque;
    private float distancia;

    // Use this for initialization
    void Start () {
        animator = gameObject.transform.GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update () {

        var distancia = (player.transform.position.x - transform.position.x);
        if (distancia > 0)
        {
            transform.eulerAngles = new Vector2(0, 0);
        }
        else {
            transform.eulerAngles = new Vector2(0, 180);
        }

        if (!atacou && Mathf.Abs(distancia) <= distanciaAtaque)
        {
            animator.SetTrigger("atacou");
            gameObject.GetComponent<AudioSource>().Play();
            Instantiate(ataque, posAtaque.transform.position, posAtaque.transform.rotation);
            atacou = true;


        }
        if (atacou)
        {
            contagemIntervalo += Time.deltaTime;
            if (contagemIntervalo >= intervaloAtaque)
            {
                atacou = false;
                contagemIntervalo = 0;
            }
        }
    }


}

