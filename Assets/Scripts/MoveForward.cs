using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 10f;
    public float xRange = 15f;
    public float zRange = 9f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);

        if (transform.position.x < -xRange || transform.position.x > xRange || transform.position.z < -zRange || transform.position.z > zRange)
        {
            Destroy(gameObject);
        }
    }

    
}
