using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomInitialParticleColor : MonoBehaviour
{

    public ParticleSystem ParticleSystem;


    private void Awake()
    {
        
        Color colorFresco = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f), 255f);

        Color colorFresco2 = new Color(Random.Range(0, 1f), Random.Range(0, 1f), Random.Range(0, 1f), 255f);
        
        //con la variable Color hay que usar valores entre 0 y 1f
        //si quieres usar valores entre 0 y 255f hay que usar la variable Color32
        //Hassen Code
        ParticleSystem.MainModule psMain = GetComponent<ParticleSystem>().main;
        psMain.startColor = new ParticleSystem.MinMaxGradient(colorFresco, colorFresco2);

    }

}
