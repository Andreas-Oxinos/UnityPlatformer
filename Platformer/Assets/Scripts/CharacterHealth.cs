﻿using UnityEngine;
using System.Collections;

public class CharacterHealth : MonoBehaviour
{
    public int health = 3;
    private MovementScript movementScript;
    public float timer;
    public ParticleSystemRenderer aura;
    private Color auraColor;
    public float waitTime = 2.0f;
    void Awake()
    {
        movementScript = GetComponent<MovementScript>();
        aura = GetComponent<ParticleSystemRenderer>();
    }

    void Update()
    {
        if ( health == 3)
        {
            auraColor = new Color(0.0f, 1.0f, 1.0f, 0.05f);
            aura.material.SetColor("_TintColor", auraColor);
        }
        if ( health == 2)
        {
            auraColor = new Color(1.0f, 1.0f, 0.0f, 0.05f);
            aura.material.SetColor("_TintColor", auraColor);
        }
        if ( health == 1)
        {
            auraColor = new Color(1.0f, 0.0f, 0.0f, 0.05f);
            aura.material.SetColor("_TintColor", auraColor);
        }
        if ( health == 0)
        {
            movementScript.enabled = false;
            LevelReset();
        }
    }

    void LevelReset()
    {
        timer += Time.deltaTime;
        if(timer >= waitTime)
        {
            Application.LoadLevel(0);
        }
    }
}
