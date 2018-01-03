using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coRoutine : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
		//StartCoroutineでコルーチンを実行
		//非同期で値が返ってきている
		StartCoroutine("coRoutineMethod1");
		StartCoroutine("coRoutineMethod1");

		//こっちだと処理が同期してる
//		StartCoroutine("coRoutineMethod2");
//		StartCoroutine("coRoutineMethod2");

	}
	
	// Update is called once per frame
	void Update () {
//		StartCoroutine("coRoutineMethod");
	}

	IEnumerator coRoutineMethod1(){
		print ("1");
		//フレームごとにreturnで処理を切ってる
		yield return null;
		print ("2");
		yield return null;
		print ("3");
		yield return null;
	}

	IEnumerator coRoutineMethod2(){
		print ("4");
		print ("5");
		print ("6");
		yield return null;
	}
}
