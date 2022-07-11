using UnityEngine;

public class WaveTiles : MonoBehaviour
{
    // Start is called before the first frame update
    GroundSpawner groundSpawner;
    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
    }

    // Update is called once per frame
    private void OnTriggerExit(Collider other) {
        groundSpawner.WaveSpawner();
        Destroy(gameObject,2);
    }
}
