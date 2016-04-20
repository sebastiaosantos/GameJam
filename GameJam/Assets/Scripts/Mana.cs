using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class Mana : MonoBehaviour {
   
    
    // Vida
    // define um range pro tanto de vida que ele pode ter.
    // define já o tanto de vida maxima dele e depois pega uma imagem que vai ser a imagem da barra de vida e depois a variavel que vai armazenar 
    // a vida atual do jogador e por fim um componente de texto pra mostrar quanto ele tem de life.
    [Range(0, 200)]
    public float manaCheia = 100;
    public Image barraDeMana;
    public float manaAtual;
    public Text manaText;

    


    // Use this for initialization
    void Start()
    {
        // ao iniciar defini ele com vida maxima logo
        manaAtual = manaCheia;

    }

    // Update is called once per frame
    void Update()
    {

        // mostra no componente de texto a Mana cheia e a Mana atual dele
        manaText.text = (manaCheia.ToString()) + "/" + (manaAtual.ToString());

     
       


        // faz comparação para ele não ter mais do que  Mana cheia e não ficar com menos que 0 de Mana
        if (manaAtual >= manaCheia)
        {
            manaAtual = manaCheia;

        }
        else if (manaAtual <= 0)
        {
            manaAtual = 0;
       //     SceneManager.LoadScene("Jogo");


        }
    }
    // função pra diminuir a barra de Mana
    public void TirarMana(float value)
    {
        manaAtual -= value;
        barraDeMana.fillAmount = ((1 / manaCheia) * manaAtual);
        // o 1 equivale a barra cheia do FillAmount.

    }

    // função pra aumentar a barra de vida
    public void RecuperaMana(float value)
    {
        manaAtual += value;
        barraDeMana.fillAmount = ((1 / manaCheia) * manaAtual);
        // o 1 equivale a barra cheia do FillAmount.

    }
}
