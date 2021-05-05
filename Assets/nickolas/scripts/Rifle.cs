using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : Armas
{
    public void Awake() 
    {
        ArmaName = "Rifle";
        Dano = 9;
        QuantiaBalas = 10;
        QuantiaBalasMax = 10;
        VelocidadeRecarga = 3;
        damageType = DamageType.Radiacao;
    }
}
