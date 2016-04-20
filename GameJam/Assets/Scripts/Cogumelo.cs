using UnityEngine;
using System.Collections;

public class Cogumelo : MonoBehaviour {

    public float forcaPulo = 500f;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    // ao colidir com algo ele  vai fazer determinada ação
    void OnCollisionEnter2D(Collision2D colisor)
    {
        // ele pega o que colidiu (colisor) e pega o gameObjetc dele no caso o personagem e pega o componente Rigidbody2D e adiciona uma força nele
        colisor.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.up * forcaPulo);
      
    }
}
