using UnityEngine;

public class DetectCollisions : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.tag == "Projectile")
        {
            //Destroy the object
            Destroy(other.gameObject);

            //Destroy ourselves
            Destroy(gameObject);

            //Update the score
            GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().score++;

            Debug.Log(GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerController>().score);
        }
    }
}
