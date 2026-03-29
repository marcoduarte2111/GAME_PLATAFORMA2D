using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShootLimitedBullets : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform starPos;
    [HideInInspector] public int maxBullets = 3;

    public void ShootLimitedBullets(InputAction.CallbackContext context)
    {
        if (context.started)
        {
             if(maxBullets > 0)
            {
                    Debug.Log("Disparo LimitedBullet");
                    GameObject bullet = Instantiate(bulletPrefab, starPos.position, starPos.rotation);
                    maxBullets--;
                    Destroy(bullet, 5f);
                }
            else
                {
                    Debug.Log("No more bullets!");
                }
        }
    
    }
}

