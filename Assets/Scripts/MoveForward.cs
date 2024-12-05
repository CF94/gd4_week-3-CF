using UnityEngine;

public class MoveForward : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float speed = 10f;
    public float speen = 100f;
    private float xRange = 25f;
    private float zRange = 15f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        transform.Rotate(speen * Time.deltaTime * Vector3.forward);

        if (transform.position.x < -xRange || transform.position.x > xRange || transform.position.z < -zRange || transform.position.z > zRange)
        {
            Destroy(gameObject);
        }
    }
    
}
