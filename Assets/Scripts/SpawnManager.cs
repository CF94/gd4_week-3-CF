using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created    
    public GameObject projectileBananna;
    public GameObject projectileCarrot;
    public GameObject projectileCookie;
    float carrotSpeed = 0.5f;
    float cookieSpeed = 0.1f;
    float time;
    void Start()
    {
        time= Time.time;
    }
    // Update is called once per frame
    void Update()
    {        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Instantiate(projectileBananna, transform.position, transform.rotation);
        }
        if (Input.GetKey(KeyCode.Alpha2))
        {
            if (Time.time - time > carrotSpeed)
            {
                Instantiate(projectileCarrot, transform.position, transform.rotation);
                time = Time.time;
            }                
        }
        if (Input.GetKey(KeyCode.Alpha3))
        {
            if (Time.time - time > cookieSpeed)
            {
                Instantiate(projectileCookie, transform.position, transform.rotation);
                time = Time.time;
            }               
        }
    }

}