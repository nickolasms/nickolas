using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum DamageType { Fogo, Corrosivo, Radiacao, eletrico}
public class Armas : MonoBehaviour
{
    public string ArmaName {get; protected set;}
    public int Dano{get; protected set;}
    public int QuantiaBalas{get; protected set;}
    public int QuantiaBalasMax{get; protected set;}
    public float VelocidadeRecarga{get; protected set;}
    public DamageType damageType;

    public bool PodeAtirar = true;
    public Transform ExitShoot;

    protected IEnumerator Recarga() 
    {
        PodeAtirar = false;
        yield return new WaitForSeconds(VelocidadeRecarga); //espera a velocidade de recarga para recarregar e poder atirar
        QuantiaBalas = QuantiaBalasMax;
        PodeAtirar = true;
        Debug.Log(QuantiaBalas + " balas");
    }

    void Update()
    {
        if(Input.GetButtonDown("Recarga"))
        {
            StartCoroutine(Recarga());
        }

        if (Input.GetButtonDown("Fire1") && PodeAtirar == true)
        {
            Shoot();
            QuantiaBalas -= 1;
            Debug.Log(QuantiaBalas+ " balas");
        }
        if(QuantiaBalas <= 0)
        {
            StartCoroutine(Recarga());
        }
    }

    public void Shoot()
    {
        RaycastHit2D hitInfo = Physics2D.Raycast(ExitShoot.position, ExitShoot.right);

        if (hitInfo) //Se o Raycast detecta colisão
        {
            inimigo enemy = hitInfo.transform.GetComponent<inimigo>(); //Cria a variavel que recebe se o Raycast acertou um inimigo
            if (enemy != null) // Se acertou um inimigo, leva dano.
            {
                enemy.TakeDamage(Dano);

            }
        }
    }

}
