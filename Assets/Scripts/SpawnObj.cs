using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObj : MonoBehaviour
{
    [SerializeField] private GameObject obj;
    public string tag="bucket";
    [SerializeField] private Vector3 center;
    [SerializeField] private Vector3 size;
    
    public float radius;
    void Start()
    {
        Spawnobj();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Spawnobj();
        }
    }
    public void Spawnobj()
    {
        Vector3 pos = center + new Vector3(Random.Range(-size.x / 2, size.x / 2), 2,Random.Range(-size.z / 2, size.z / 2));
        Instantiate(obj, pos, Quaternion.identity);
    }
     void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(1, 0, 0, 0.5F);
        Gizmos.DrawCube(center, size);
        Gizmos.DrawSphere(center,radius);
    }
}
