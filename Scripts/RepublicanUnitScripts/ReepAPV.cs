using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReepAPV : MonoBehaviour
{
    public int health = 100;
    public int strikeVsInfantry;
    public int strikeVsArtillery;
    public int strikeVsTank;
    public int strikeVsCity;
    public int strikeVsAntiAirCraft;
    public int strikeVsAPV;
    // firing range
    public int range = 1;
    // this is going to be the amount it can move
    public int mobility;

    private void Start()
    {
        strikeVsInfantry = Random.Range(50, 80);
        strikeVsArtillery = Random.Range(40, 60);
        strikeVsTank = Random.Range(20, 40);
        strikeVsCity = Random.Range(20, 50);
        strikeVsAntiAirCraft = 100;
        strikeVsAPV = Random.Range(20, 40);
    }
}
