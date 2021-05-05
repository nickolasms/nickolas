using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AK47 : Armas
{
    public void Awake() 
    {
        ArmaName = "AK47";
        Dano = 7;
        QuantiaBalas = 25;
        QuantiaBalasMax = 25;
        VelocidadeRecarga = 2;
        damageType = DamageType.Fogo;
    }
  
}
