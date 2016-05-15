using UnityEngine;
using System.Collections;

public class SpawnMonster : MonoBehaviour
{

    private bool hasSpawn;
	private Vector3 spawnPos;
	private Vector3 distance;
    // Use this for initialization
    void Start()
    {
		spawnPos = gameObject.transform.position;
		foreach (Transform child in transform) {
			child.gameObject.SetActive (false);
		} 
		hasSpawn = false;

    }

    void Update()
    {
		distance.x = Mathf.Abs(spawnPos.x - PlayerControllerV3.ppos.x);

        if (hasSpawn == false)
        {
			if ((distance.x < 15f)) {
				foreach (Transform child in transform) {
					child.gameObject.SetActive (true);
					child.transform.position = spawnPos;
				} 
				hasSpawn = true;
			} 
        }
		if (hasSpawn == true)
		{
			if ((distance.x > 30f)) {
				foreach (Transform child in transform) {
					child.gameObject.SetActive (false);
				} 
				hasSpawn = false;
			} 
		}

    }
}
