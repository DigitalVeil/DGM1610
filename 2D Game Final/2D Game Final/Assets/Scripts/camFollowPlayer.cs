using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Vector3 = UnityEngine.Vector3;

public class camFollowPlayer : MonoBehaviour
{

    public Transform target;
    public float smoothing;

    private Vector3 offset;
    public float lowY; 
    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.position;

       
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 targetCamPos = target.position + offset;

        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
        
        if(transform.position.y < lowY) transform.position = new Vector3(transform.position.x, lowY, transform.position.z);
    }
}
