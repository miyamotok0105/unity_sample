using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowController : MonoBehaviour {

	GameObject player;

	void Start() {
		this.player = GameObject.Find("player");
	}

	void Update() {
		transform.Translate(0, -0.1f, 0);

		//playerのy座標が-5.0以下いなったら削除されるが、そんな座標に行くことはるのだろうか。。。
		if(transform.position.y < -5.0f) {
			//Destroy 関数によりゲームオブジェクトそのものに影響を与えずに個別コンポーネントを削除
			Destroy(gameObject);
		}

		// 当たり判定
		Vector2 p1 = transform.position; // 矢の中心座標
		Vector2 p2 = this.player.transform.position; // プレイヤの中心座標
		Vector2 dir = p1 - p2;
		//magnitude：ベクトルの長さ
		float d = dir.magnitude;
		float r1 = 0.5f; // 矢の半径
		float r2 = 1.0f; // プレイヤの半径

		if(d < r1 + r2) {
			// 監督スクリプトにプレイヤと衝突したことを伝える
			GameObject director = GameObject.Find("GameDirector");
			//他のコンポーネントのメソッドを呼んでる
			director.GetComponent<GameDirector>().DecreaseHp();

			// 衝突した場合は矢を消す
			Destroy(gameObject);
		}
	}
}