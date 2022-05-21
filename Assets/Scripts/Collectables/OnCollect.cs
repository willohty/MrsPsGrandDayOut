using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollect : MonoBehaviour
{
    Collectables collect;
    // Start is called before the first frame update
    void Start()
    {
        collect = GameObject.Find("Collectables").GetComponent<Collectables>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        collect.PlayCollectSounds();
        collect.IncreaseCollectedCounter();
        AudioSource.PlayClipAtPoint(collect.collectPossumSound, transform.position);
        Destroy(gameObject);
    }
}

