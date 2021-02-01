using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapController : MonoBehaviour
{
    // Start is called before the first frame update

    [SerializeField]
    public GameObject myPrefab;


    [SerializeField]
    Vector2 tankPosition;

    [SerializeField]
    public GameObject ReepTank;

    [SerializeField]
    public Transform trans;

    [SerializeField]
    public Transform trans1;

    public Vector3 worldPosition;

    [SerializeField]
    public GameObject America;

    public Vector3 vect;

    private bool flag;



    private void Awake()
    {
        //RepublicanTank reepTank1 = FindObjectOfType<RepublicanTank>();
        //trans1 = reepTank1.GetComponentInChildren<Transform>();

        //// replace with one object, then reassign values
        //Vector3 v3 = new Vector3(trans1.transform.position.x, trans1.transform.position.y, 3);
        //Instantiate(myPrefab, new Vector3(trans1.transform.position.x + 2, trans1.transform.position.y + 2, 3), Quaternion.identity);
        //Instantiate(myPrefab, new Vector3(trans1.transform.position.x + 4, trans1.transform.position.y + 4, 3), Quaternion.identity);
        //Instantiate(myPrefab, new Vector3(trans1.transform.position.x + 6, trans1.transform.position.y + 6, 3), Quaternion.identity);
        //Instantiate(myPrefab, new Vector3(trans1.transform.position.x + 8, trans1.transform.position.y + 8, 3), Quaternion.identity);


    }
    void Start()
    {


        //america = new America();
    }

    void Update()
    {

        RepublicanTank reepTank1 = FindObjectOfType<RepublicanTank>();
        trans1 = reepTank1.GetComponentInChildren<Transform>();

        // replace with one object, then reassign values


        // need to pool objects. Too much memory use
        Vector3 v3 = new Vector3(trans1.transform.position.x, trans1.transform.position.y, 3);
        Instantiate(myPrefab, new Vector3(trans1.transform.position.x + 2, trans1.transform.position.y + 2, 3), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(trans1.transform.position.x + 4, trans1.transform.position.y + 4, 3), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(trans1.transform.position.x + 6, trans1.transform.position.y + 6, 3), Quaternion.identity);
        Instantiate(myPrefab, new Vector3(trans1.transform.position.x + 8, trans1.transform.position.y + 8, 3), Quaternion.identity);
       


        if (Input.GetMouseButtonDown(0))
        {
            //RaycastHit hit;

            //if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
            //{

            // now need to use coroutine, and possibly pub sub

            Debug.Log("Pressed");
            RepublicanTank reepTank = FindObjectOfType<RepublicanTank>();
            int movement = reepTank.GetMovement;
            // Instantiate at position (0, 0, 0) and zero rotation.
            // Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            trans = reepTank.GetComponentInChildren<Transform>();
            worldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            GameObject america = Instantiate(America, new Vector3(0, 0, 0), Quaternion.identity);

            //// america.coordinates = worldPosition;
            //// set cords from here, then test, yes, watch order

            //vect.x = america.GetComponentInChildren<America>().X;
            //vect.y = america.GetComponentInChildren<America>().Y;
            //vect.z = 1;
            vect = america.GetComponentInChildren<America>().cords;
            worldPosition = vect;

            Debug.Log($"Vector.x = {vect.x}, vector.y = {vect.y}");
            //if (comp)
            //{
            //    Debug.Log("Fucking works");
            //}
            // Want to get vect.x - 2, etc for how many moves and then highlight it.

            StartCoroutine(WaitAndMove());

            //  flag = true;

        }
    }


    // control + R, control + R to rename
    IEnumerator WaitAndMove()
    {

        yield return new WaitForSeconds(2);
        trans.position = new Vector3(worldPosition.x, worldPosition.y, trans.position.z);
    }


}

//void Start()
//{
//    //RepublicanTank reepTank = FindObjectOfType<RepublicanTank>();
//    //trans = reepTank.GetComponentInChildren<Transform>();
//    //trans.position.Set(trans.position.x, trans.position.y + 1, trans.position.z);

//    // tankPosition = reepTank.GetComponent<transform.position>();
//    // want to do coroutine and have move four spaces so I can see it. 
//}

//// Update is called once per frame
//void Update()
//{
//    if (Input.GetKeyDown("space")){
//        Debug.Log("Pressed");
//        RepublicanTank reepTank = FindObjectOfType<RepublicanTank>();
//        trans = reepTank.GetComponentInChildren<Transform>();
//        trans.position = new Vector3(trans.position.x, trans.position.y + 2, trans.position.z);

//    }

//}

