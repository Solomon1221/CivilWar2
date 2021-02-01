using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemGunBoat : MonoBehaviour
{
    public bool goesOnWater = true;
    public int health = 100;
    public int range = 5;
    public int strikeVsInfantry;
    public int strikeVsArtillery;
    public int strikeVsTank;
    public int strikeVsCity;
    public int strikeVsAntiAirCraft;
    public int strikeVsAPV;
    public int strikeVsAirCraftCarrier;
    public int strikeVsGunBoat;


    private void Start()
    {
        strikeVsInfantry = Random.Range(30, 60);
        strikeVsArtillery = Random.Range(30, 50);
        strikeVsTank = Random.Range(20, 40);
        strikeVsCity = Random.Range(40, 70);
        strikeVsAntiAirCraft = 100;
        strikeVsAPV = Random.Range(30, 40);
        strikeVsAirCraftCarrier = Random.Range(30, 40);
        strikeVsGunBoat = Random.Range(20, 40);
    }
}
