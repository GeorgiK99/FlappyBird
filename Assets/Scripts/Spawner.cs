using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public float spawnRate = 1f;
    public float minHeight = -1f;
    public float maxHeight = 1f;
    
    private void OnEnable()
    {
        InvokeRepeating(nameof(Spawn), spawnRate,spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnDisable()
    {
        CancelInvoke(nameof(Spawn));
    }
    private void Spawn()
    {
        GameObject pipe = Instantiate(prefab,transform.position,Quaternion.identity);
        pipe.transform.position += Vector3.up * Random.Range(minHeight,maxHeight);
    }
}
