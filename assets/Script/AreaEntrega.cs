//biblioteca padrão da Unity.
using UnityEngine;

/*Essa classe servirá para definir a área de entrega, o gameObject que tiver esse script atribuido, 
vai detectar qualquer objeto que entra no trigger, se o objeto for igual á um instrumento,
ele avisa o medico */
public class AreaEntrega : MonoBehaviour
{
    //Aqui o script vai receber um outro script e vai armazena-lo na variável 'medico'
    public MedicoPedido medico;

    //Esse é um método que detecta se algum collider entrou no trigger
    private void OnTriggerEnter(Collider other)
    {
        /*aqui ele cria uma variável que vai armazenar o resultado do método 'other.GetComponent<Instrumento>()'
        esse método procura um componente 'instrumento' dentro do objeto*/
        Instrumento instrumento = other.GetComponent<Instrumento>();

        /*Se o resultado que o método retornar for diferente de nulo, ele executa uma ação*/
        if (instrumento != null)
        {
            /*Ele aciona o script 'MedicoPedido' e chama a função 'VerificarInstrumento' 
            e envia um valor para ela*/
            medico.VerificarInstrumento(instrumento);
        }
    }
}