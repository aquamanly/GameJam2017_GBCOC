﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour {
	public int maxHealth = 100;
	public int curHealth = 100;
	public float healthBarLength;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        addjustCurrentHealth(0);
	}
	void OnGUI(){
		GUI.Box (new Rect (10, 40, Screen.width / 2 / (maxHealth / curHealth), 20), curHealth + "/" + maxHealth);

  }
	public void addjustCurrentHealth(int adj){
		curHealth += adj;
		  
		if (curHealth < 1)
			curHealth = 0;

		if (curHealth > maxHealth)
			curHealth = maxHealth;
        
		if (maxHealth < 1)
			maxHealth = 1;

		healthBarLength =(Screen.width/2) *(curHealth / (float)maxHealth);
			}
}
