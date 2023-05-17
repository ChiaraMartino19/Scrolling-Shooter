using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour
{
    public Transform player;
    public float distance;
    public Transform pointShoot;
    public GameObject bulletPrefab;
    private float time;
    public float startTime;
    [SerializeField] private ParticleSystem particles;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        time = startTime;
    }

    void Update()
    {
        if(player != null)
        {


            float distanceToPlayer = Vector2.Distance(transform.position, player.position);

            if (distanceToPlayer <= distance) 
            {
                if (player.position.x > transform.position.x)
                {
                    transform.localScale = new Vector2(1, -1);
                }
                else
                {
                    transform.localScale = new Vector2(1, 1);
                }

                if (time <= 0)
                {
                    Instantiate(bulletPrefab, pointShoot.position, Quaternion.identity);
                    time = startTime;
                }
                else
                {
                    time -= Time.deltaTime;
                }

                particles.Play();
            }
        }
    }
}
