//Biblioteca padrão do unity
using UnityEngine;


public class AreaTutorial : MonoBehaviour
{
    //Armazena a referência ao componente que irá reproduzir o áudio.
    public AudioSource audioSource;

    //Essa variável controla se o tutorial já foi reproduzido.
    private bool jaExecutou = false;

    //Esse método é chamado automaticamente quando algum Collider entra na área Trigger.
    private void OnTriggerEnter(Collider other)
    {
        /*Aqui ele verifica duas coisas: O objeto que entrou possui a tag "Player"? O áudio ainda não foi reproduzido?
        Somente se ambas forem verdadeiras o código continua.*/
        if (other.CompareTag("Player") && !jaExecutou)
        {
            //Marca como executado e Impede que o áudio seja reproduzido novamente.
            jaExecutou = true;

            //Manda o AudioSource tocar o áudio configurado nele.
            audioSource.Play();
        }
    }
}