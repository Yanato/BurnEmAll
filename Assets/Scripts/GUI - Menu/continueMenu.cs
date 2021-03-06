﻿using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class continueMenu : MonoBehaviour {

	public GameObject Camera;
	public GameObject Player;

	public GameObject sky1;
	public GameObject sky2;

	public GameObject moutain1;
	public GameObject moutain2;

	public GameObject tuto;
	public static bool isTuto;

	public static Vector3 CheckpointPosition;

	void Start(){

	}

	void Update(){

		if (isTuto) {
			tuto.SetActive (true);
		} else {
			tuto.SetActive (false);
		}


		if (Checkpoint.takePos == true) {
			CheckpointPosition = Camera.GetComponent<Transform> ().position;
			Debug.Log (CheckpointPosition);
			Checkpoint.takePos = false;
		}

			if(MainMenu.checkpointe ==true){
				Camera.transform.position = new Vector3 (CheckpointPosition.x, 0, -10);
				Player.transform.position = new Vector3 (Camera.transform.position.x, 0, 5);
			MainMenu.checkpointe = false;
			}
	}

	public void ContinueTuto(){
		isTuto = false;
	}

	public void Continue (){

		HealthBar.isContinue = false;
		HealthBar.cur_health = 100;
		if (Checkpoint.check == true) {
			Camera.transform.position = new Vector3 (CheckpointPosition.x, 0, 5);
			Player.transform.position = new Vector3 (Camera.transform.position.x, 0, 5);
			moutain1.transform.position = new Vector3 (Camera.transform.position.x, -0.8f, 8f);
			moutain2.transform.position = new Vector3 (Camera.transform.position.x, 0f, 9f);


		} else {
			HealthBar.isDead = false;
			HealthBar.cur_health = 100;
			HealthBar.life = 3;
			SceneManager.LoadScene ("Level1");
			Checkpoint.check = false;

		}
		Debug.Log (Camera.transform.position);
		Transform character = Player.GetComponent<Transform>();
		character.rotation = Quaternion.Euler (0, 0, 0);
		character.GetComponent<PlayerControllerV3> ().enabled = true;
		sky1.transform.position = new Vector3 (0, 2, sky1.transform.position.z); // faire attention à ou on place le checkpoint
		sky2.transform.position = new Vector3 (18, 2, sky2.transform.position.z);

		PlayerControllerV3.disableEnnemy = true;



	}

	public void Exit (){
		SceneManager.LoadScene ("Menu");
		HealthBar.isContinue = false;
	}
}
