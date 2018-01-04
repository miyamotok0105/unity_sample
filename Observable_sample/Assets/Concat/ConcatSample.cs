using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class ConcatSample : MonoBehaviour {

	// Use this for initialization
	void Start () {

		print ("Concat============");
		//【Concat】
		//Concatでストリームを結合してる
		Observable
		// 0,1,2と値を発行する
			.Range(0, 3).Select(i => "1st: " + i)
			.Concat(
				// 5,6,7,8,9と値を発行する
				Observable.Range(5, 5).Select(i => "2nd: " + i)
			)
			.Subscribe(s => Debug.Log("OnNext: " + s));

		//上と同じ
		Observable
			.Concat(
				// 0,1,2と値を発行する
				Observable.Range(0, 3).Select(i => "1st: " + i),
				// 5,6,7,8,9と値を発行する
				Observable.Range(5, 5).Select(i => "2nd: " + i)
			)
			// 講読
			.Subscribe(s => Debug.Log("OnNext: " + s));

		print ("StartWith============");
		//【StartWith】
		//StartWithのストリームが初めに来る。
		Observable
		// 1,2,3,4と値を発行するシーケンス
			.Range(1, 4)
			// 頭に10,20,30をつける
			.StartWith(10, 20, 30)
			// 購読
			.Subscribe(s => Debug.Log("OnNext: " + s));

		print ("Network operations============");
		ObservableWWW.Get("http://google.co.jp/")
			.Subscribe(
				x => Debug.Log(x.Substring(0, 100)), // onSuccess
				ex => Debug.LogException(ex)); // onError

		print ("Network operations2============");
		// composing asynchronous sequence with LINQ query expressions
		var query = from google in ObservableWWW.Get("http://google.com/")
			from bing in ObservableWWW.Get("http://bing.com/")
			from unknown in ObservableWWW.Get(google + bing)
			select new { google, bing, unknown };

		var cancel = query.Subscribe(x => Debug.Log(x));

		// Call Dispose is cancel.
		cancel.Dispose();

		print ("Network operations3============");
		// Observable.WhenAll is for parallel asynchronous operation
		// (It's like Observable.Zip but specialized for single async operations like Task.WhenAll)
		var parallel = Observable.WhenAll(
			ObservableWWW.Get("http://google.com/"),
			ObservableWWW.Get("http://bing.com/"),
			ObservableWWW.Get("http://unity3d.com/"));

		parallel.Subscribe(xs =>
			{
				Debug.Log(xs[0].Substring(0, 100)); // google
				Debug.Log(xs[1].Substring(0, 100)); // bing
				Debug.Log(xs[2].Substring(0, 100)); // unity
			});


		print ("SelectMany============");
		//【SelectMany】
		//SelectManyはselectとmerge
		//コルーチンAsyncAを呼び出してAsyncBをmerge
		var cancel2 = Observable.FromCoroutine(AsyncA)
			.SelectMany(AsyncB)
			.Subscribe();


		
	}

	IEnumerator AsyncA()
	{
		Debug.Log("a start");
		yield return new WaitForSeconds(1);
		Debug.Log("a end");
	}

	IEnumerator AsyncB()
	{
		Debug.Log("b start");
		yield return new WaitForEndOfFrame();
		Debug.Log("b end");
	}


	// Update is called once per frame
	void Update () {
		
	}
}
