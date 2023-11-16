using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circ : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] GameManager gameManager;
    [SerializeField] float speed = 10f;
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        transform.position -= new Vector3(0, speed, 0) * Time.deltaTime;

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            GameManager.instance.InitiatedGameOver();
        }
        else if (collision.gameObject.tag == "Laser2")
        {
            GameManager.instance.IncreaseScore(20);


            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
        else if (collision.gameObject.tag == "Laser")
        {
            GameManager.instance.IncreaseScore(10);


            Destroy(gameObject);
            Destroy(collision.gameObject);

        }
    }
}
