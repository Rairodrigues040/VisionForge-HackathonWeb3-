//biblioteca padrão da Unity.
using UnityEngine;

public class AreaProximidade : MonoBehaviour
{
    //Aqui o script vai receber um outro script e vai armazena-lo na variável 'medico'
    public MedicoPedido medico;

    /*Essa variável do tipo booleano vai ser resposável por dizer, se o contato entre o 
    gameObject com a tag 'player' é verdadeiro ou falso*/
    private bool jogadorEntrou = false;

    /* Esta variável controla se o jogador já entrou na área.
   Começa como false e passa para true na primeira entrada. */
    private void OnTriggerEnter(Collider other)
    {
        //mostra no console qual objeto entrou no trigger
        Debug.Log("Algo entrou: " + other.name);

        /* Verifica se o objeto que entrou possui a tag "Player"
        e se o jogador ainda não entrou anteriormente na área. */
        if (other.CompareTag("Player") && !jogadorEntrou)
        {
            //ele atribui um novo valor á variável booleana e mostra que 'o jogador entrou na area (trigger)'
            jogadorEntrou = true;

            //mostra outra mensagem no console
            Debug.Log("Jogador entrou na área!");

            //chama a função 'PedirNovoInstrumento' do script 'MedicoPedido'
            medico.PedirNovoInstrumento();
        }
    }
}