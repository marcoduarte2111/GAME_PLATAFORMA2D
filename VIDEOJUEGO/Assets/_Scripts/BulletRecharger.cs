using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRecharger : MonoBehaviour
{
    private Rigidbody2D _rb;


    // Start is called before the first frame update
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            collision.GetComponent<PlayerShootLimitedBullets>().maxBullets = 3;
            Destroy(gameObject);
        }
    }
}
