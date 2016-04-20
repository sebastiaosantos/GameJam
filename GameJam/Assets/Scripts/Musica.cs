using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Musica : MonoBehaviour
{

    public Sprite musicOn;
    public Sprite musicOff;
    public bool ativo;

    // Use this for initialization
    void Start()
    {
        // por algum motivo deixar no start o var para pegar o tipo de variavel automaticamente ele não fica disponível para usar no código
        // se for feito no uptade ele já aceita
        // var  music = gameObject.GetComponent<AudioSource>();
             gameObject.GetComponent<AudioSource>().Play();

    }

    // Update is called once per frame
    void Update()
    {

      


    }

  public  void AtivarEDesativarMusica()
    {
        if(ativo)
        {
            ativo = false;
        }
        else
        {
            ativo = true;
        }

        if (ativo)
        {
            gameObject.GetComponent<AudioSource>().mute = false;
            gameObject.GetComponent<Image>().sprite = musicOn;

        }
        else {
            gameObject.GetComponent<AudioSource>().mute = true;
            gameObject.GetComponent<Image>().sprite = musicOff;
        }
    }

 

}