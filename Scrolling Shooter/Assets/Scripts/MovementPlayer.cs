using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MovementPlayer : MonoBehaviour
{
    public float velocity = 5f;
    [SerializeField] private ParticleSystem particles;



    void Update()
    {


        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector2 direction = new Vector2(horizontal, vertical);
        transform.position += new Vector3(direction.x, direction.y, 0) * velocity * Time.deltaTime;
        particles.Play();
    }


    public bool CanShoot()
    {
        return transform.localScale.y > 0.0f;
    }

}
    

