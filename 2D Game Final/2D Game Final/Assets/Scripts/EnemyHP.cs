using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHP : MonoBehaviour
{
    public float enemyMaxHP;
    public GameObject DeathStars; 

    public Slider hpSlider;
    public bool drops; 
    public GameObject itemDrop; 
    private float currentHP;

    void Start(){
        currentHP = enemyMaxHP;
        hpSlider.maxValue = currentHP;
        hpSlider.value = currentHP;
    }

    void Update(){

    }


    public void inflictDamage(float damage){

        hpSlider.gameObject.SetActive(true);
        currentHP -= damage;
        hpSlider.value = currentHP;
        if(currentHP<= 0) causeDeath();
    }

    void causeDeath(){
        Instantiate(DeathStars, transform.position, transform.rotation);
        Destroy(gameObject);
        if(drops) Instantiate(itemDrop, transform.position, transform.rotation);
    }
}
