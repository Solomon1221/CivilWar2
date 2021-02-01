using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemAntiAircraft : MonoBehaviour
{
    public int health = 100;
    public bool canFireAgainstPlane = true;
    public int strikeVsPlane;

    // want it to be moved far, but easily destroyed
    public int moveDistance = 5;

    private void Start()
    {
        strikeVsPlane = 100;
    }
}
