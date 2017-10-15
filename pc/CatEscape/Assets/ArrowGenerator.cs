using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowGenerator : MonoBehaviour {

	public GameObject arrowPrefab;
	float span = 1.0f;
	float delta = 0;

	void Update() {
		this.delta += Time.deltaTime;
		if(this.delta > this.span) {
			this.delta = 0;
			//Instantiate：オブジェクトを生成
			GameObject go = Instantiate(arrowPrefab) as GameObject;
			int px = Random.Range(-6, 7);
			//Vector3：構造体
			go.transform.position = new Vector3(px, 7, 0);
		}
	}
}