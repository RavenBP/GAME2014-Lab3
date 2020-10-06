using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    public float verticalSpeed;
    public float verticalBoundary;
    public BulletManager bulletManager;

    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    // Move bullet on y axis only
    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed, 0.0f);
    }

    // "Resetting" the bullet back to a position so it can be reused
    private void _CheckBounds()
    {
        if (transform.position.y > verticalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }
}
