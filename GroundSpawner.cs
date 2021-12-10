using System.Collections;
Using System.Collections.Generic;
Using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
	public GameObject groundTile;
	Vector3nexSpawnPoint;
    // Start is called before the first frame update
	void SpawnTile() {
	GameOject temp = Intantiate(groundTile, nextSpawnPoint, Quaternion.identity)
	nextSpawnPoint = temp.transform.GetChild(1).transform.position;
}
    private void Start()
    {
      	for (int i = 0; i < 15; i++){
		SpawnTile();

    }

    // Update is called once per frame

}
