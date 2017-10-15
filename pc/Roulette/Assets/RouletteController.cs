using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RouletteController : MonoBehaviour {

	//unity側え設定したオブジェクト
	//SpriteRenderer (スプライト)：スプライト表示
	//Rigidbody 2D：物理挙動
	//Collider 2D：2Dの衝突判定
	//BoxCollider2D：2Dの矩形の衝突判定
	//CircleCollider2D：2Dの円の衝突判定

	float rotSpeed = 0; // 回転速度

	void Start() {
	}

	void Update() {
		// マウスが押されたら回転速度を設定する
		if(Input.GetMouseButtonDown(0)) {
			this.rotSpeed = 10;
		}

		//Transform：オブジェクトの位置、回転、スケールを扱うクラス
		// 回転速度分、ルーレットを回転させる
		transform.Rotate(0, 0, this.rotSpeed);
		Debug.Log (rotSpeed);

		// ルーレットを減速させる（追加）
		this.rotSpeed *= 0.96f;
	}
}