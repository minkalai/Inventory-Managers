using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;
using System.ComponentModel;
using NUnit.Framework.Constraints;

public class Spawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public List<EnemySO> spawnPool = new();

    [ContextMenu("Spawn Enemy")]
    public void Spawn()
    {
        Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];
        GameObject objectToSpawn = spawnPool[Random.Range(0, spawnPool.Count)].prefab;
        GameObject tmp = Instantiate(objectToSpawn, spawnPoint.position, Quaternion.identity);
        tmp.GetComponent<Enemy>().HP = new();
        
    }
}
