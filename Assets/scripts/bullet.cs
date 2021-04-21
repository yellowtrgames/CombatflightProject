using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{

    public float yspeed;
    public float secoundstowait;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Destroybullet());
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 position = transform.position;
        position.y += yspeed;
        transform.position = position;
    }


    IEnumerator Destroybullet()
    {
        yield return new WaitForSeconds(secoundstowait);
        Destroy(gameObject);

    }

    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.tag == "asteroid")
        {
            Destroy(hit.gameObject);
            Destroy(gameObject);
        }

    }


    
    
}
