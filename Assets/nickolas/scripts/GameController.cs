using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    
    public inimigo VerHP;

    public GameObject pistola, ak47, rifle, minigun, bazuca;

    
    public void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            pistola.SetActive(true);
            ak47.SetActive(false);
            rifle.SetActive(false);
            minigun.SetActive(false);
            bazuca.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.Alpha2))
        {
            pistola.SetActive(false);
            ak47.SetActive(true);
            rifle.SetActive(false);
            minigun.SetActive(false);
            bazuca.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.Alpha3))
        {
            pistola.SetActive(false);
            ak47.SetActive(false);
            rifle.SetActive(true);
            minigun.SetActive(false);
            bazuca.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.Alpha4))
        {
            pistola.SetActive(false);
            ak47.SetActive(false);
            rifle.SetActive(false);
            minigun.SetActive(true);
            bazuca.SetActive(false);
        }

        if(Input.GetKeyDown(KeyCode.Alpha5))
        {
            pistola.SetActive(false);
            ak47.SetActive(false);
            rifle.SetActive(false);
            minigun.SetActive(false);
            bazuca.SetActive(true);
        }
    }
}
