using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReepAntiAirCraft : MonoBehaviour
{

    public int health = 100;
    public bool canFireAgainstPlane = true;
    public int strikeVsPlane;

    // want it to be moved far, but easily destroyed
    public int moveDistance = 4;


    // bombers only have one, so you have to be able to hit it first
    public int range = 4;

    private void Start()
    {
        strikeVsPlane = 100;
    }

}
