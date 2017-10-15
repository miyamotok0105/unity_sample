using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // UIを使うので忘れずに追加

public class GameDirector : MonoBehaviour {

	GameObject hpGauge;

	void Start() {
		//GameObject.Find：シーン内のオブジェクトを取得する関数
		//注意：対象がアクティブになっていないときはnullになる
		this.hpGauge = GameObject.Find("hpGauge");
	}

	public void DecreaseHp() {
		//GetComponent；コンポーネントにアクセス
		//fillAmount：どのくらいImageを描画するかを0~1の範囲で設定
		this.hpGauge.GetComponent<Image> ().fillAmount -= 0.1f;
	}
}