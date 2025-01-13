using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class Player : MonoBehaviour
{

    private float speed = 5f;
    public float Move;
    private Rigidbody2D rb;

    //[SerializeField]
    //private Transform muzzle;

    //[SerializeField]
    //private AudioClip shooting;

    //[SerializeField]
    //private float coolDownTime = 0.5f;

    //[SerializeField]
    //private Bullet bulletPrefab;

    //private float shootTimer;



    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();


    }

    // Update is called once per frame
    void Update()
    {
        //if (Input.GetKey(KeyCode.D))
        //{
        //    transform.Translate(speed * Time.deltaTime, 0, 0);
        //}
        //else if
        //(Input.GetKey(KeyCode.A)) { 
        //    transform.Translate(-speed * Time.deltaTime, 0, 0);

        Move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(Move * speed, rb.velocity.y);


        //shootTimer += Time.deltaTime;
        //if (shootTimer > coolDownTime && Input.GetKey(KeyCode.Space))
        //{
        //    shootTimer = 0f;

        //    Instantiate(bulletPrefab, muzzle.position, Quaternion.identity);
        //}


    }
}
