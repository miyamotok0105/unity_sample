using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class OnNextSubscribe : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Subject<string> subject = new Subject<string>();
		//Subscribeはsubjectにメソッドを登録する処理
		subject.Subscribe(msg => Debug.Log("Subscribe1:" + msg));
		subject.Subscribe(msg => Debug.Log("Subscribe2:" + msg));
		subject.Subscribe(msg => Debug.Log("Subscribe3:" + msg));
		//OnNextはテキストを登録した関数に投げる処理。
		subject.OnNext("こんにちは");
		subject.OnNext("おはよう");

		Subject<string> subject2 = new Subject<string>();
		subject2
			.Where(x => x == "hello")
			.Subscribe(msg => Debug.Log("Subscribe4:" + msg));
		subject2.OnNext("hello");
		subject2.OnNext("good morning");
		//メッセージが発行されてからSubscribeに到達する１連の流れをUniRxではストリームと言ってる
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
