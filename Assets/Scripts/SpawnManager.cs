using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject player;
    public GameObject projectileBananna;
    public GameObject projectileCarrot;
    public GameObject projectileCookie;
    float time;
    public float fireRate = 1f;
    void Start()
    {
        time= Time.time;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Instantiate(projectileBananna, transform.position, Quaternion.identity);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            if (Time.time - time > fireRate)
            {
                Instantiate(projectileCarrot, transform.position, Quaternion.identity);
                time = Time.time;
            }        
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Instantiate(projectileCookie, transform.position, Quaternion.identity);
        }
    }    
    

}