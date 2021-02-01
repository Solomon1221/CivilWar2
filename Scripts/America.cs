using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class America : MonoBehaviour
{
    [SerializeField]
    public GameObject verticleLine;

    [SerializeField]
    public GameObject HorozontalLine;

    public int X;

    public int Y;
    int x
    {
        get { return X; }
        set { X = value; }
    }
    int y
    {
        get { return Y; }
        set { Y = value; }
    }
    public Vector3 coordinates
    {
        get { return coordinates; }
        set { coordinates = value; }
    }

    Vector3 vect = new Vector3(0, 0, 0);

    public Vector3 cords;

    Vector3 start = new Vector3(0, -5, -3);
    Vector3 end = new Vector3(0, 5, -3);
    bool flag;

    Color color;

    private void Awake()
    {
        for (int i = -50; i <= 50; i += 2)
        {
            Vector3 start = new Vector3(i, -30, -3);
            Vector3 end = new Vector3(i, 30, -3);

            for (int f = -50; f <= 50; f += 2)
            {
                DrawVerticleLine(start, end, color, i, f, 0.2f);
                //Vector3 start = new Vector3(-40, i, -3);
                //Vector3 end = new Vector3(40, i, -3);
                DrawHorozontalLine(start, end, color, i, f, 0.2f);
                // Not geting mousePosition
                // button not getting pressed, try passing mouse position from MapController
                // had to put it into world point first
                Vector3 v = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                if (v.x > i && v.x < i + 2 && v.y > f && v.y < f + 2)
                {
                    cords.x = i + 1;
                    // all you have to do is figure out the y coords
                   // if(v.y )
                    cords.y = f + 1;
                    cords.z = 0;

                    
                    

                }
            }
        }



        //for (int i = -30; i <= 30; i += 2)
        //{
        //    Vector3 start = new Vector3(-40, i, -3);
        //    Vector3 end = new Vector3(40, i, -3);
        //    DrawHorozontalLine(start, end, color, i, 0.2f);
        //}


        //  StartCoroutine(WaitAndPrint());

    }

    private void Start()
    {

        //SceneManager.LoadSceneAsync("SampleScene");
        //  StartCoroutine(WaitAndLoad());
    }

    IEnumerator WaitAndLoad()
    {

        yield return new WaitForSeconds(5);
        SceneManager.LoadSceneAsync("SampleScene");

    }
    IEnumerator WaitAndPrint()
    {
        // suspend execution for 5 seconds
        for (double i = .15; i < 25; i += .15)
        {
            float scale = (float)i;
            yield return new WaitForSeconds(.3f);
            gameObject.transform.localScale += new Vector3(scale, scale, 1);
        }
    }
    private void Update()
    {

    }
    //{
    //    if (flag == false)
    //    {
    //        SceneManager.LoadSceneAsync("SampleScene");
    //        flag = true;
    //    }
    // SceneManager.LoadSceneAsync("Opening");
    //  DrawLine(start, end, color, 0.2f) ;
    //}

    void DrawVerticleLine(Vector3 start, Vector3 end, Color color, int i, int f, float duration = 0.2f)
    {
        //Instantiate(verticleLine.position, transform);

        GameObject vl = Instantiate(verticleLine, new Vector3(i, f, 0), Quaternion.identity);

    }

    // might have to have pub sub

    void DrawHorozontalLine(Vector3 start, Vector3 end, Color color, int i, int f, float duration = 0.2f)
    {
        GameObject hl = Instantiate(HorozontalLine, new Vector3(f, i, 0), Quaternion.identity);

    }
    void DrawLine(Vector3 start, Vector3 end, Color color, float duration = 0.2f)
    {
        GameObject myLine = new GameObject();
        myLine.transform.position = start;
        myLine.AddComponent<LineRenderer>();
        LineRenderer lr = myLine.GetComponent<LineRenderer>();
        //lr.material = new Material(Shader.Find("Particles/Alpha Blended Premultiply"));
        lr.SetColors(color, color);
        lr.SetWidth(0.02f, 0.02f);
        lr.SetPosition(0, start);
        lr.SetPosition(1, end);

        //// GameObject.Destroy(myLine, duration);
    }
}
