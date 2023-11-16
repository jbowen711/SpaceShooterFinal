using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    float yPosition;
    [SerializeField] GameObject laser;
    [SerializeField] GameObject laser2;
    void Start()
    {
        yPosition = transform.position.y;
        
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 convertedPosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(convertedPosition.x, yPosition, 0);

        if (Input.GetButtonDown("FireLaser"))
        {
            Instantiate(laser, transform.position, Quaternion.identity);
        }
        else if (Input.GetButtonDown("FireLaser2"))
        {
            Instantiate(laser2, transform.position, Quaternion.identity);
        }

        
        


    }
}
