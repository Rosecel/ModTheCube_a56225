using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    void Start()
    {
        // Alterar a localização do cubo aleatoriamente
        transform.position = new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f));

        // Alterar a escala do cubo aleatoriamente
        transform.localScale = Vector3.one * Random.Range(0.5f, 2f);

        // Alterar o ângulo de rotação do cubo aleatoriamente
        transform.Rotate(Random.Range(0f, 360f), Random.Range(0f, 360f), Random.Range(0f, 360f));

        // Alterar a velocidade de rotação do cubo aleatoriamente
        float rotationSpeed = Random.Range(5f, 20f);

        // Alterar a cor do material do cubo aleatoriamente
        Material material = Renderer.material;
        material.color = new Color(Random.value, Random.value, Random.value, Random.Range(0.5f, 1f)); // Cor aleatória

        // Adicionar funcionalidade extra: alterar a cor do cubo ao longo do tempo
        StartCoroutine(ChangeColorOverTime(material));
    }

    void Update()
    {
        // Rotação contínua do cubo
        transform.Rotate(10.0f * Time.deltaTime, 0.0f, 0.0f);
    }

    IEnumerator ChangeColorOverTime(Material material)
    {
        while (true)
        {
            // Aguardar um intervalo de tempo aleatório
            yield return new WaitForSeconds(Random.Range(1f, 5f));

            // Alterar a cor do material do cubo aleatoriamente
            material.color = new Color(Random.value, Random.value, Random.value, Random.Range(0.5f, 1f)); // Cor aleatória
        }
    }
}