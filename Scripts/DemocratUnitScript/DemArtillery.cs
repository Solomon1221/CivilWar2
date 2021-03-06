﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemArtillery : MonoBehaviour
{
    public int health = 100;
    public int strikeVsInfantry;
    public int strikeVsArtillery;
    public int strikeVsTank;
    public int strikeVsCity;
    public int strikeVsAntiAirCraft;
    public int strikeVsAPV;
    public int range = 5;

    private void Start()
    {
        strikeVsInfantry = Random.Range(30, 60);
        strikeVsArtillery = Random.Range(30, 50);
        strikeVsTank = Random.Range(20, 40);
        strikeVsCity = Random.Range(40, 70);
        strikeVsAntiAirCraft = 100;
        strikeVsAPV = Random.Range(30, 40);
    }
  
}
