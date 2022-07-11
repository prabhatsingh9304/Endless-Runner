
using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] groundTiles;
    private Vector3 nextSpawnPt;
    private Vector3 nextWaveSpawnPt = new Vector3(0f,-11.29688f,0f);
    private GameObject tile;
    public int numberOfTiles = 3;
    public GameObject wave;
    public Transform player;
    void Start()
    {
        for(int i=0;i<=3;i++)
        {
            TilesSpawner(0);
        }
        for(int i=0;i<2;i++)
        {
            WaveSpawner();
        }
        
    }
    public void TilesSpawner(int tileIndex)
    {
        tile = Instantiate(groundTiles[tileIndex],nextSpawnPt,Quaternion.identity);
        nextSpawnPt = tile.transform.GetChild(0).transform.position;
    }
    public void WaveSpawner()
    {
        wave = Instantiate(wave,nextWaveSpawnPt,Quaternion.identity);
        nextWaveSpawnPt = wave.transform.GetChild(0).transform.position;

    }

    // Update is called once per frame
}
