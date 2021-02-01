using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.ParticleSystemJobs;

[RequireComponent(typeof(ParticleSystem))]
public class DemocratTank : TankParent
{
    public bool isDemocratTank = true;

    public int cycleCount = 60;
    // public float probability = .05f;
    public float repeatInterval = 1.5f;

    int i = 0;
    [SerializeField]
    int speed = 3;

    [SerializeField]
    GameObject rocket;
    private void Start()
    {

    }
    private void Update()
    {

        i++;
        if (i > 175)
        {
            StartCoroutine(WaitAndFire());
            i = 0;
        }

        // create coroutine pause and then move it three frames
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            StartCoroutine(WaitAndPrint());
            //   LetsDoThis();

            //transform.position = new Vector3(transform.position.x - 1, transform.position.y, 0);
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.position = new Vector3(transform.position.x + 1, transform.position.y, 0);
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y + 1, 0);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.position = new Vector3(transform.position.x, transform.position.y - 1, 0);
        }

        // StartCoroutine(CallExplosion());

        if (Random.Range(.01f, 2f) < .02f)
        {
            StartCoroutine(Explode());
        }
    }

    public IEnumerator Explode()
    {
        yield return new WaitForSeconds(2f);
        ParticleSystem exp = GetComponent<ParticleSystem>();
        exp.Play();
        // Destroy(exp, exp.main.duration);
    }

    //public IEnumerator Explode()
    //{
    //    yield return new WaitForSeconds(1);
    //    ParticleSystem exp = GetComponent<ParticleSystem>();
    //    exp.Play();
    //    Destroy(gameObject, exp.main.duration);
    //}

    public IEnumerator CallExplosion()
    {
        yield return StartCoroutine("Explode");

    }
    public IEnumerator LetsDoThis()
    {
        yield return StartCoroutine("WaitAndPrint");

    }
    IEnumerator WaitAndPrint()
    {
        // suspend execution for 5 seconds
        yield return new WaitForSeconds(2);
        transform.position = new Vector3(transform.position.x - 1, transform.position.y, 0);
    }

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
        Vector3 tom = new Vector3(transform.position.x + 4, transform.position.y + 7, 0);
        shootDirection = new Vector3(tom.x, tom.y, transform.position.z);
        //...instantiating the rocket
        /* Rigidbody2D*/
        GameObject bulletInstance = Instantiate(rocket, transform.position, Quaternion.Euler(new Vector3(0, 0, 0))) /*as Rigidbody2D*/;
        Rigidbody2D bulletBody = bulletInstance.GetComponent<Rigidbody2D>();
        bulletBody.velocity = new Vector2(0, shootDirection.y * speed);


    }
}
