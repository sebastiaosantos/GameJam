using UnityEngine;
using System.Collections;

public class PlataformaCai : MonoBehaviour {

    public float duracaoCair;
    private float tempo;
    private bool pisou;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (pisou)
        {
            tempo += Time.deltaTime;

            if (tempo >= duracaoCair)
            {
                // adiconar o ridfbody nele para adicionar a fisica e ele cair e depois destruir ele em 3 segundos
                gameObject.AddComponent<Rigidbody2D>();
                Destroy(gameObject, 3f);
            }
        }

    }

    // ao colidir com o personagem ele vai passar o pisou para True
    void OnCollisionEnter2D(Collision2D colisor)
    {
        if (colisor.gameObject.name == "Player")
        {
            pisou = true;
        }
    }

}
