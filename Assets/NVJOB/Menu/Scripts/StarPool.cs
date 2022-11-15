﻿// Infinity Square/Space. The prototype of the game is open source. V1.0
// https://github.com/nvjob/Infinity-Square-Space
// #NVJOB Nicholas Veselov
// https://nvjob.pro
// MIT license (see License_NVJOB.txt)



using UnityEngine;



public class StarPool : MonoBehaviour {
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    


    public int numberStars = 10000;
    public GameObject star;

    //--------------

    static Transform stThisTransform;
    static int stNumberStars;
    static GameObject[] stStars;
            


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

        

    void Awake()
    {
        //--------------

        stThisTransform = gameObject.transform;
        stNumberStars = numberStars;
               
        stStars = new GameObject[numberStars];

        for (int i = 0; i < numberStars; i++)
        {
            stStars[i] = Instantiate(star);
            stStars[i].SetActive(false);
            stStars[i].transform.parent = stThisTransform;
        }

        //--------------
    }
       


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



    static public GameObject GiveStar()
    {
        //--------------

        for (int i = 0; i < stNumberStars; i++) if (!stStars[i].activeSelf) return stStars[i];
        return null;

        //--------------
    }



    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////


        
    static public void TakeStar(GameObject obj)
    {
        //--------------

        obj.SetActive(false);

        //--------------
    }
    


    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
}
