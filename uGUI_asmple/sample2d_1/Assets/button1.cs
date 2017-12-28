using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class button1 : MonoBehaviour {

	//Subject:IObservable<T>とIObserver<T>
	Subject<string> a = new Subject<string> ();
	Subject<string> b = new Subject<string> ();

	// Use this for initialization
	void Start () {

		//zip:それぞれのストリームに送れてきたメッセージを保持し、揃ったところから出力する。
		Observable.Zip (a, b)
			.Select (_ => _ [0] + ", " + _ [1])
			.Subscribe (_ => Debug.Log ("Zip: " + _));
		a.OnNext ("A0");
		a.OnNext ("A1");
		a.OnNext ("A2");
		b.OnNext ("B0");
		b.OnNext ("B1");
		b.OnNext ("B2");

		//ZipLatest:最新から出力
		//CombineLatest:aとbで来たもん順
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick() {
		Debug.Log ("clicked!!!");
	}

}
