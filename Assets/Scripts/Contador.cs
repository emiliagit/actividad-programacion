using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour
{
    public TextMeshProUGUI contadorText;
    public float tiempoInicial = 3f; 

    void Start()
    {
        StartCoroutine(ContadorRegresivo());
    }

    IEnumerator ContadorRegresivo()
    {
        float tiempoRestante = tiempoInicial;

        while (tiempoRestante > 0)
        {
            // Actualiza el texto del contador.
            contadorText.text = tiempoRestante.ToString();
            yield return new WaitForSeconds(1f);

            tiempoRestante--;
        }

            contadorText.text = "¡Comienza el juego!";


            yield return new WaitForSeconds(1f);

            contadorText.gameObject.SetActive(false);
    }
}

    