using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



[System.Serializable]
public class Cores
{
    public Color verde;
    public Color laranja;
    public Color vermelho;
}

public class Vida : MonoBehaviour {

    // Vida
    // define um range pro tanto de vida que ele pode ter.
    // define já o tanto de vida maxima dele e depois pega uma imagem que vai ser a imagem da barra de vida e depois a variavel que vai armazenar 
    // a vida atual do jogador e por fim um componente de texto pra mostrar quanto ele tem de life.
    [Range(0, 200)]
    public float vidaCheia = 100;
    public Image barraDeVida;
    public float vidaAtual;
    public Text hpText;


    // instancia a classe Cores na classe principal para poder acessar ela
    public Cores cor;
   
   

    // Use this for initialization
    void Start () {
        // ao iniciar defini ele com vida maxima logo
        vidaAtual = vidaCheia;

    }

    // Update is called once per frame
    void Update () {

        // mostra no componente de texto a vida cheia e a vida atual dele
        hpText.text = (vidaCheia.ToString()) + "/" + (vidaAtual.ToString());

        // mudar a cor da barra de vida
        if (barraDeVida.fillAmount * 100 <= 50f && barraDeVida.fillAmount * 100 > 30f)
        {
            barraDeVida.color = cor.laranja;
        }

        if (barraDeVida.fillAmount * 100 > 50f)
        {
            barraDeVida.color = cor.verde;
        }

        if (barraDeVida.fillAmount * 100 <= 30f)
        {
            barraDeVida.color = cor.vermelho;
        }

       
        // faz comparação para ele não ter mais do que  vida cheia e não ficar com menos que 0 de vida
        if (vidaAtual >= vidaCheia)
        {
            vidaAtual = vidaCheia;

        }
        else if (vidaAtual <= 0)
        {
            vidaAtual = 0;
            SceneManager.LoadScene("Jogo");


        }
    }
    // função pra diminuir a barra de vida
    public void Damage(float value)
    {
        vidaAtual -= value;
        barraDeVida.fillAmount = ((1 / vidaCheia) * vidaAtual);
        // o 1 equivale a barra cheia do FillAmount.
 
    }

    // função pra aumentar a barra de vida
    public void Recupera(float value)
    {
        vidaAtual += value;
        barraDeVida.fillAmount = ((1 / vidaCheia) * vidaAtual);
        // o 1 equivale a barra cheia do FillAmount.

    }
}
