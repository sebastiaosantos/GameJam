using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    public float velocidade;
    public float forcaPulo;
    private bool estaNoChao;
    public Transform chaoVerificador;
    public Transform spritePlayer;
    private Animator animator;
    public LayerMask piso;

    public Transform posicaoAtaque;


    // ataque
    public GameObject ataque;
    private bool podeAtacar;



    //Tudo que ocorre quando o personagem e criado
    void Start()
    {
        animator = spritePlayer.GetComponent<Animator>();

        podeAtacar = true;

    }

    //Tudo que ocorre enquanto o personagem existe
    void Update()
    {
        Movimentacao();

        Ataque();


    }

   
    //Responsavel pela movimentacao do personagem
    void Movimentacao()
    {


        //Verifica se esta no chao
        estaNoChao = Physics2D.OverlapCircle(chaoVerificador.position, 0.2f, piso);

        animator.SetBool("chao", estaNoChao);

        //Seta no paramentro movimento, um valor 0 ou maior que 0. Ira ativar a condicao para mudar de animacao
        animator.SetFloat("movimento", Mathf.Abs(Input.GetAxisRaw("Horizontal")));

        //Anda para a direita
        if (Input.GetAxisRaw("Horizontal") > 0)
        {
            transform.Translate(Vector2.right * velocidade * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 0);
            
        }

        //Anda para a esquerda
        if (Input.GetAxisRaw("Horizontal") < 0)
        {
            transform.Translate(Vector2.right * velocidade * Time.deltaTime);
            transform.eulerAngles = new Vector2(0, 180);
        }

      

        //Responsavel pelo pulo
        if (Input.GetButtonDown("Jump") && estaNoChao)
        {
            GetComponent<Rigidbody2D>().AddForce(transform.up * forcaPulo);
        }
    }

    // responsavel pelo ataque
    void Ataque()
    {
        var player = GetComponent<Mana>();

        // quando eu clico com o botão ele mostra a animação
        if (Input.GetButtonDown("Fire1") && podeAtacar == true && player.manaAtual >= 10) 
        {
            animator.SetBool("atacar", true);
            //var player = GetComponent<Mana>();
            player.TirarMana(10f);
            podeAtacar = false;
        }

    }

    public void FinalDoAtaque()
    {
        animator.SetBool("atacar", false);
        podeAtacar = true;
        Instantiate(ataque, posicaoAtaque.transform.position, posicaoAtaque.transform.rotation);

    }
}

