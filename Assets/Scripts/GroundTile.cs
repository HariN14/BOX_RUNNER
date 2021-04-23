
using UnityEngine;

public class GroundTile : MonoBehaviour
{
   Ground_Spawner groundSpawner;
       void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<Ground_Spawner>();
        SpawnObsticles();
    }

    private void OnTriggerExit (Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }
    void Update()
    {
        
    }

    public GameObject obsticle;

    void SpawnObsticles()
    {
        int obsticleSpawnIndex = Random.Range(2,5);
        Transform spawnPoint = transform.GetChild(obsticleSpawnIndex).transform;

        Instantiate(obsticle,spawnPoint.position,Quaternion.identity,transform);
    }
}
