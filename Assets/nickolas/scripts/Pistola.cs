using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistola : Armas
{
    public void Awake() 
    {
        ArmaName = "Pistola";
        Dano = 1;
        QuantiaBalas = 9;
        QuantiaBalasMax = 9;
        VelocidadeRecarga = 1;
        
    }
}
