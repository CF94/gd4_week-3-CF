using UnityEngine;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float xRange = 15f;
    public float zRange = 9f;
    public float infinteScroll = 0;
    public float boundaries = 0;   
    //public GameObject projectilePrefab;

    public int score;
    public TMP_Text scoreText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");           
        
        //Method 1
        
        //transform.Translate(Vector3.right * Time.deltaTime * moveSpeed * horizontal);
        //transform.Translate(Vector3.forward * Time.deltaTime * moveSpeed * vertical);

        //Method 2

        Vector3 moveDir = new Vector3(horizontal, 0, vertical).normalized;
        transform.Translate(moveDir * moveSpeed * Time.deltaTime, Space.World);

        transform.rotation = Quaternion.LookRotation(moveDir);

        //Boundaries

        if (boundaries > 0)
        {

            {
                if (transform.position.x < -xRange)
                {
                    transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
                }

                if (transform.position.x > xRange)
                {
                    transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
                }

                if (transform.position.z < -zRange)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
                }

                if (transform.position.z > zRange)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
                }
            }

        }

        //Infinte Scrolling

        if (infinteScroll > 0) 
        
        {

            {
                if (transform.position.x < -xRange)
                {
                    transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
                }

                if (transform.position.x > xRange)
                {
                    transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
                }

                if (transform.position.z < -zRange)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, zRange);
                }

                if (transform.position.z > zRange)
                {
                    transform.position = new Vector3(transform.position.x, transform.position.y, -zRange);
                }
            }

        }

        //scoreText.text = "Score: " + score;
    }    
}
