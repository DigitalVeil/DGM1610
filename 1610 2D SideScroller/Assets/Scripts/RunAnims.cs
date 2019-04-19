using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunAnims : MonoBehaviour
{

    private Animator animate;
    public float Speed; 
    // Start is called before the first frame update
    void Start()
    {
        animate = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        animate.SetFloat("Speed", Speed);
    }
}
