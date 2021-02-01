using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AmericaIntro : MonoBehaviour
{

    [SerializeField]
    public GameObject verticleLine;

    [SerializeField]
    public GameObject HorozontalLine;


    Color color;
    private void Awake()
    {
        //for (int i = -10; i <= 10; i++)
        //{
        //    Vector3 start = new Vector3(i, -5, -3);
        //    Vector3 end = new Vector3(i, 5, -3);
        //    DrawLine(start, end, color, 0.2f);
        //}

        //for (int i = -5; i <= 5; i++)
        //{
        //    Vector3 start = new Vector3(-10, i, -3);
        //    Vector3 end = new Vector3(10, i, -3);
        //    DrawLine(start, end, color, 0.2f);
        //}

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
            }
        }


        StartCoroutine(WaitAndPrint());
    }



    private void Start()
    {
        StartCoroutine(WaitAndLoad());
    }


    void DrawVerticleLine(Vector3 start, Vector3 end, Color color, int i, int f, float duration = 0.2f)
    {
        //Instantiate(verticleLine.position, transform);

        GameObject vl = Instantiate(verticleLine, new Vector3(i, f, 0), Quaternion.identity);

    }

    void DrawHorozontalLine(Vector3 start, Vector3 end, Color color, int i, int f, float duration = 0.2f)
    {
        GameObject vl = Instantiate(HorozontalLine, new Vector3(f, i, 0), Quaternion.identity);

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

        // GameObject.Destroy(myLine, duration);
    }
}
