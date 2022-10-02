using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class JamesWebbController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        transform.rotation =  Quaternion.Euler (new Vector3(0f,0f,0f));
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mouseWorldPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition + Vector3.forward * 10f);
        this.GameObject().transform.LookAt(-mouseWorldPosition * 10);
        
        //Angle between mouse and this object
        //float angle = AngleBetweenPoints(transform.position, mouseWorldPosition);
        
        //Ta daa
        //transform.rotation =  Quaternion.Euler (new Vector3(0f, 0f,angle));
        
        
    }
    float AngleBetweenPoints(Vector2 a, Vector2 b) {
        return Mathf.Atan2(a.y - b.y, a.x - b.x) * Mathf.Rad2Deg;
    }
}
