using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChangeBullet : MonoBehaviour
{
    private Rigidbody2D _rb;
    public float speed;


    // Start is called before the first frame update
    void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
    }

    private void OnEnable()
    {
        _rb.velocity = transform.right * speed;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            collision.GetComponent<SpriteRenderer>().color = UnityEngine.Color.green;
        }
        else if (collision.CompareTag("Wall"))
        {
            Destroy(gameObject);
        }


    }
}
