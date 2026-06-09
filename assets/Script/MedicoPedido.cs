//biblioteca padrão da Unity.
using UnityEngine;

/* Esta classe controla os pedidos do médico.
   Ela sorteia instrumentos, reproduz os áudios dos pedidos
   e verifica se o instrumento entregue está correto. */
public class MedicoPedido : MonoBehaviour
{
    //Armazena qual instrumento o médico está pedindo no momento.
    public TipoInstrumento instrumentoAtual;

    //Aqui está a referencia ao objeto que vai reproduzir os sons
    public AudioSource audioSource;

    //aqui ficam as variáveis que armazenam os audios pedindo os instrumentos.
    [Header("Áudios Instrumentos")]
    public AudioClip bisturiAudio;
    public AudioClip afastadorAudio;
    public AudioClip tesouraAudio;
    public AudioClip pincaTesouraAudio;
    public AudioClip pincaAudio;

    //aqui ficam as variáveis que armazenam os audios de feedback.
    [Header("Áudios Feedback")]
    public AudioClip corretoAudio;
    public AudioClip erradoAudio;

    //essa função define aleatóriamente qual vai ser novo objeto que o médico vai pedir
    public void PedirNovoInstrumento()
    {
        /*ele cria uma variável que vai armazenar algum número aleatório entre 0 e 4 range( 0 1, 2, 3, 4, '5') 
        o cinco nunca retorna, por que o range está de zero até ele*/
        int valor = Random.Range(0, 5);

        /* Converte o número sorteado para um valor do enum TipoInstrumento.
        Exemplo:
        0 -> Bisturi
        1 -> Afastador
        2 -> Tesoura
        etc. */
        instrumentoAtual = (TipoInstrumento)valor;

        //Com o item atribuido, chama a função de audio.
        TocarAudioInstrumento();
    }

    /*essa é a função que relaciona o tipo de instrumento ao audio relativo á esse instrumento.
    Como são várias opções, é preferível usar um switch do que vários if´s e else´s*/
    void TocarAudioInstrumento()
    {
        //se o instrumento atual for igual...
        switch (instrumentoAtual)
        {
            //a bisturi, chame o audio do bisturi
            case TipoInstrumento.Bisturi:
                audioSource.PlayOneShot(bisturiAudio);
                break;

            //a afastador, chame o audio do afastador
            case TipoInstrumento.Afastador:
                audioSource.PlayOneShot(afastadorAudio);
                break;

            //a tesoura, chame o audio da tesoura
            case TipoInstrumento.Tesoura:
                audioSource.PlayOneShot(tesouraAudio);
                break;

            //a pinça tesoura, chame o audio doa pinça tesoura
            case TipoInstrumento.PincaTesoura:
                audioSource.PlayOneShot(pincaTesouraAudio);
                break;

            //a pinça, chame o audio do pinça
            case TipoInstrumento.Pinca:
                audioSource.PlayOneShot(pincaAudio);
                break;
        }
    }

   /* Esta função recebe o instrumento entregue pelo jogador
   e compara seu tipo com o instrumento solicitado pelo médico. */
    public void VerificarInstrumento(Instrumento instrumento)
    {
        //se o valor da variável instrumento é igual a variável atual
        if (instrumento.tipo == instrumentoAtual)
        {
            //toca o audio de feedback positivo
            audioSource.PlayOneShot(corretoAudio);

            //após 2 segundos, chama a função
            Invoke(nameof(PedirNovoInstrumento), 2f);
        }
        //caso contrário
        else
        {
            //audio de feedback negativo
            audioSource.PlayOneShot(erradoAudio);
        }
    }
}