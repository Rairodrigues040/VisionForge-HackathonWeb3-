//biblioteca padrão da Unity.
using UnityEngine;

//Essa classe vai chamar um outro script, para definir qual instrumento o médico vai pedir
public class Instrumento : MonoBehaviour
{
    /* Eles estão declarando uma variável pública chamada 'tipo' do tipo 'TipoInstrumento'.
    Essa variável permite definir, pelo Inspector da Unity, qual é o tipo deste instrumento.
    Cada GameObject que possuir este script poderá ser identificado como Bisturi,
    Pinça, Tesoura, etc., através da lista suspensa do enum 'TipoInstrumento'.*/
    public TipoInstrumento tipo;
}