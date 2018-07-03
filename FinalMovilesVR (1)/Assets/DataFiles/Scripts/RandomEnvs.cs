using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomEnvs : MonoBehaviour {

	public GameObject [] diffTreeRocks;
	public GameObject [] diffGrassRocks;
    public GameObject [] diffMonteRocks;
    int num;
	void Start () {
        num=7 - ChangeScenes.currentLevel;
        for (int k = 0; k < Random.Range(20 / num, 20 / num); k++)
        {
            MonteRockCount();
        }
		for (int i = 0; i < Random.Range (600/num, 700/num); i++) {
			TreeRockCount ();
		}

		for (int j = 0; j < Random.Range (1000/num, 1200/num); j++) {
            GrassRockCount();
        }
       
    }

	void TreeRockCount () {
		int treeRockIdx = Random.Range (0, diffTreeRocks.Length);
		GameObject randomTreeRock = Instantiate (diffTreeRocks [treeRockIdx]);
		randomTreeRock.transform.parent = transform;
		randomTreeRock.transform.localPosition = new Vector3(Random.Range (-95, 95), 0.0f, Random.Range (-95, 95));
	}

	void GrassRockCount () {
		int grassRockIdx = Random.Range (0, diffGrassRocks.Length);
		GameObject randomGrassRock = Instantiate (diffGrassRocks [grassRockIdx]);
		randomGrassRock.transform.parent = transform;
		randomGrassRock.transform.localPosition = new Vector3(Random.Range (-95, 95), 0.0f, Random.Range (-95, 95));
	}
    void MonteRockCount()
    {
        int monteRockIdx = Random.Range(0, diffMonteRocks.Length);
        GameObject randomMonteRock = Instantiate(diffMonteRocks[monteRockIdx]);
        randomMonteRock.transform.parent = transform;
        randomMonteRock.transform.localPosition = new Vector3(Random.Range(-95, 95), 0.0f, Random.Range(-95, 95));
    }
}
