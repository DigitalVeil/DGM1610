using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHP : MonoBehaviour
{
    public float fullHP;
    private float currentHP;

    public NewGame GameState; 
    public GameObject DeathStars;
    public Slider HPSlider;
    public Text deathScreen;
    public Text winScreen; 

    
    PlayerController controlMovement;

    void Start()
    {
        currentHP = fullHP;

        controlMovement = GetComponent<PlayerController>();
        HPSlider.maxValue = fullHP;
        HPSlider.value = fullHP; 
    }

    void Update()
    {
      
    }


    public void damageTaken(float damage)
    {
        if (damage <= 0) return;
        currentHP -= damage;
        HPSlider.value = currentHP; 
        if (currentHP <= 0)
        {
            causeDeath();
        }
    }




    public void addHealth(float healthGain)
    {
        currentHP += healthGain;
        if (currentHP > fullHP) currentHP = fullHP;
        HPSlider.value = currentHP;
    }
    public void causeDeath()
    {
        Instantiate(DeathStars, transform.position, transform.rotation);
        Destroy(gameObject);
        Animator gameOverAnimator = deathScreen.GetComponent<Animator>();
        gameOverAnimator.SetTrigger("GameOver");
        GameState.restartGame();
    }

    public void winGame()
    {
        Destroy(gameObject);
        Animator winAnimator = winScreen.GetComponent<Animator>(); 
        winAnimator.SetTrigger("GameOver");
        GameState.restartGame();
    }
}
