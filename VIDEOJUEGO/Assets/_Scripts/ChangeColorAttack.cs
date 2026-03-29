using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class ChangeColorAttack : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform starPos;

    public void ChangeColorShoot(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            Debug.Log("Disparo Change Color Bullet");
            GameObject bullet = Instantiate(bulletPrefab, starPos.position, starPos.rotation);
            Destroy(bullet, 5f);
        }

    }
}
