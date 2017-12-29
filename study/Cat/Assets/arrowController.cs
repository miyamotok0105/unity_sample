using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrowController : MonoBehaviour {

	GameObject player;

	void Start () {
		this.player = GameObject.Find ("player");	
	}

	void Update () {
		transform.Translate (0, -0.1f, 0);

		if (transform.position.y < -5.0f) {
			Destroy (gameObject);
		}
		Vector2 p1 = transform.position; //矢の座標
		Vector2 p2 = this.player.transform.position; //プレイヤーの座標
		Vector2 dir = p1 - p2;
		float d = dir.magnitude; //dirの長さmagnitude
		float r1 = 0.5f;
		float r2 = 1.0f;
		//二つの物体の半径r1+r2が物体のposition-positionの値と比べて小さければ衝突している。
		if (d < r1 + r2) {
			//衝突を監督に伝える
			GameObject director = GameObject.Find("GameDirector");
			director.GetComponent<GameDirector> ().DecreaseHp();

			Destroy (gameObject);
		}
	}
}
