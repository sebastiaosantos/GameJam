using UnityEngine;
using System.Collections;

public class Pocao : MonoBehaviour {


    // vida que vai recuperar 
   public int vida;
	
	
    // ao colidir com o o personagem ele vai pegar o compomente vida que é um script e acessar o metodo para recuperar vida
    // e depois destruir o objeto que tá com o script poção
    void OnCollisionEnter2D(Collision2D colisor)
    {
        if (colisor.gameObject.tag == "Player")
        {
            // utilizando o Var o tipo da variavel vai ser do tipo do compomente que pego pelo getComponnent
           var player = colisor.gameObject.GetComponent<Vida>();
            player.Recupera(vida);
            Destroy(gameObject);
        }
    }
}
