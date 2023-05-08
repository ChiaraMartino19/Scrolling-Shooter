using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed;
    public GameObject bulletPrefab;
    public Transform player;
    public Vector2 spawnOffset;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector2 spawnPosition = (Vector2)player.position + spawnOffset;
            GameObject newBullet = Instantiate(bulletPrefab, spawnPosition, player.rotation);
            Rigidbody2D rb = newBullet.GetComponent<Rigidbody2D>();
            rb.velocity = new Vector2(bulletSpeed, 0f);
        }
    }

}
