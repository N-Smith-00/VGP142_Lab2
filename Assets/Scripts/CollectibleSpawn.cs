using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectibleSpawn : MonoBehaviour
{
    public GameObject[] collectibles;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(collectibles[Random.Range(0, collectibles.Length)], gameObject.transform.position, gameObject.transform.rotation);
    }
}
