using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomInitialParticleColor : MonoBehaviour
{

    public ParticleSystem ParticleSystem;


    private void Awake()
    {

        Color colorFresco = new Color(Random.Range(0, 255f), Random.Range(0, 255f), Random.Range(0, 255f), 255f);

        Color colorFresco2 = new Color(Random.Range(0, 255f), Random.Range(0, 255f), Random.Range(0, 255f), 255f);


        var main = ParticleSystem.main;


        main.startColor = new Color(Random.Range(0, 255f), Random.Range(0, 255f), Random.Range(0, 255f), 255f);


        Debug.Log($"el color random es: {colorFresco}");


        var main2 = ParticleSystem.main;
        main.startColor = new ParticleSystem.MinMaxGradient(colorFresco, colorFresco2);



        var randomColors = new ParticleSystem.MinMaxGradient(colorFresco, colorFresco2);
        randomColors.mode = ParticleSystemGradientMode.RandomColor;
        main.startColor = randomColors;
    }

}
