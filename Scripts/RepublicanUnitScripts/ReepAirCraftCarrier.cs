using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReepAirCraftCarrier : MonoBehaviour, CanLaunchPlane
{
    // CanLaunchPlane is a marker interface
    // ides is if CanLaunchPlane, then, or something, look up marker interface

    public bool goesOnWater = true;
    public bool canLaunchPlane = true;

    public int health = 100;
}
