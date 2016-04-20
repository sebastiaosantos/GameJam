using UnityEngine;
using System.Collections;

public class Camera : MonoBehaviour {

    // Variável publica do Tipo Tansform para pegar o tranform do Player
    private Transform player;

	// Use this for initialization
	void Start () {

        //  variavel player vai receber o transforme do objeto que tá com a Tag "Player" no caso nosso personagem
        player = GameObject.FindGameObjectWithTag("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {

        // Criamos uma variavel para pegar a posição do player a posição x e y a Z mantemos da camera mesmo para não se aproximar ou afastar do player
        Vector3 novaPosicao = new Vector3(player.position.x, player.position.y+0.8f, transform.position.z);

        // a posição da camera vai receber um vetor 3.Lerp que vai pegar a posição que ela tá e mover para nova posição que é onde o player tá.
        transform.position = Vector3.Lerp(transform.position, novaPosicao, Time.time);

    }
}
