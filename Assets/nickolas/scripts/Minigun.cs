using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Minigun : Armas
{
   public void Awake() 
    {
        ArmaName = "Minigun";
        Dano = 6;
        QuantiaBalas = 200;
        QuantiaBalasMax = 200;
        VelocidadeRecarga = 5;
        damageType = DamageType.Corrosivo;
    }
}
