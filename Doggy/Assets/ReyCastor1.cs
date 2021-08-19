using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReyCastor1 : MonoBehaviour
{
    // Start is called before the first frame update
   
    //public int _life = 4;



    public float _speed = 3f;

    public int life = 1;


    void Start()
    {
        //.............................. 7+ 2+ 0 = x + 1 

        transform.position = new Vector3(-7.78f, -2.5f, 0);
        

        

    }

    // Update is called once per frame
    void Update()
    {
        Movement();

      

    }

    void Movement()
    {
        transform.Translate(Vector3.up * _speed * Time.deltaTime);

        if (transform.position.y < 2.86f)
        {

            transform.position = new Vector3(transform.position.x, 2.5f, 0);
        }

    }



}
