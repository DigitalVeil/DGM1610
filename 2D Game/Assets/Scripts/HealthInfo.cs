using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthInfo : MonoBehaviour
{
    public int health;
    public int healthBar;

    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite missingHeart;

    void Update()
    {
        if (health > healthBar)
        {
            health = healthBar; 
        }
        
        
        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = missingHeart;
            }
            
            if (i < healthBar)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false; 
            }
        }
    }
}
