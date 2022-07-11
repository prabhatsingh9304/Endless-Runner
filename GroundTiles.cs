using UnityEngine;

public class GroundTiles : MonoBehaviour
{
    GroundSpawner groundSpawner;
    
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();   
    }

    private void OnTriggerExit(Collider other) {
        groundSpawner.TilesSpawner(Random.Range(0,groundSpawner.groundTiles.Length));
        Destroy(gameObject,2);        
    }

}
