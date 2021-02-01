using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SoldierParent : MonoBehaviour
{

    public int health = 100;
    public int strikeVsInfantry;
    public int strikeVsArtillery;
    public int strikeVsTank;
    public int strikeVsCity;
    public int strikeVsAntiAirCraft;
    public int strikeVsAPV;
    // Start is called before the first frame update
    void Start()
    {
        strikeVsInfantry = Random.Range(60, 80);
        strikeVsArtillery = Random.Range(50, 70);
        strikeVsTank = Random.Range(20, 40);
        strikeVsCity = Random.Range(30, 50);
        strikeVsAntiAirCraft = 100;
        strikeVsAPV = Random.Range(40, 60);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
