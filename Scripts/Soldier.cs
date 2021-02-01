using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Soldier : SoldierParent
{
    int i = 0;
    [SerializeField]
    int speed = 3;

    [SerializeField]
    GameObject rocket;

    [SerializeField]
    public bool isOnBattleMap = false;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //   if (!isOnBattleMap)
      //  {
            i++;
            if (i > 125)
            {
                StartCoroutine(WaitAndFire());
                i = 0;
            }


            //// Do shoot direction forward, and then destroy when they need to explode
            //// if transform.y > somenumber, then destroy
            //Vector3 shootDirection;
            //shootDirection = Input.mousePosition;
            //shootDirection.z = 0.0f;
            //shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);
            //shootDirection = shootDirection - transform.position;
            ////...instantiating the rocket
            ///* Rigidbody2D*/
            //GameObject bulletInstance = Instantiate(rocket, transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) /*as Rigidbody2D*/;
            //Rigidbody2D bulletBody = bulletInstance.GetComponent<Rigidbody2D>();
            //bulletBody.velocity = new Vector2(shootDirection.x * speed, shootDirection.y * speed);

            if (Random.Range(.01f, 2f) < .02f)
            {
                StartCoroutine(Explode());
            }
            //  }

        }

        IEnumerator Explode()
        {
            yield return new WaitForSeconds(2f);
            ParticleSystem exp = GetComponent<ParticleSystem>();
            exp.Play();
            // Destroy(exp, exp.main.duration);
        }

        //public IEnumerator CallExplosion()
        //{
        //    yield return StartCoroutine("Explode");

        //}

        IEnumerator WaitAndFire()
        {

            yield return new WaitForSeconds(.7f);
            // Do shoot direction forward, and then destroy when they need to explode
            // if transform.y > somenumber, then destroy
            Vector3 shootDirection;
            // shootDirection = Input.mousePosition;
            shootDirection = new Vector3(transform.position.x, transform.position.y, transform.position.z);
            shootDirection.z = 0.0f;
            //  shootDirection = Camera.main.ScreenToWorldPoint(shootDirection);
            //transform.position.y = transform.position.y += .01f;
            Vector3 tom = new Vector3(transform.position.x, transform.position.y + 7, 0);
            shootDirection = new Vector3(transform.position.x, tom.y, transform.position.z);
            //...instantiating the rocket
            /* Rigidbody2D*/
            GameObject bulletInstance = Instantiate(rocket, transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) /*as Rigidbody2D*/;
            Rigidbody2D bulletBody = bulletInstance.GetComponent<Rigidbody2D>();
            bulletBody.velocity = new Vector2(0, shootDirection.y * speed);


        }
    }


