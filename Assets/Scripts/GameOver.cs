using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour {

    public GameObject[] Enemies;
    public GameObject GameOverObject;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (CheckIfAllDead())
        {
            GameOverObject.SetActive(true);
            Time.timeScale = 0;
        }
        
	}

    bool CheckIfAllDead()
    {
        for(int i = 0; i < Enemies.Length; i++)
        {
            if(Enemies[i] != null)
            {
                return false;
            }
        }
        return true;
    }
}
