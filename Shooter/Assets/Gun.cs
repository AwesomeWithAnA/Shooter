using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    public int BulletSpeed = 1000;
    public GameObject Bullet;

    public GameObject Camera;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetMouseButtonDown(0)) {
            Vector3 BulletPosition = transform.position+(transform.forward*2);
            GameObject bullet = Instantiate(Bullet, BulletPosition, transform.rotation);
            bullet.GetComponent<Rigidbody>().AddForce(Camera.transform.forward*BulletSpeed);
            Destroy(bullet, 2);
        }
    }
}
