using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bazuca : Armas
{
    public void Awake() 
    {
        ArmaName = "Bazuca";
        Dano = 10;
        QuantiaBalas = 1;
        QuantiaBalasMax = 1;
        VelocidadeRecarga = 5;
        damageType = DamageType.eletrico;
    }
}
