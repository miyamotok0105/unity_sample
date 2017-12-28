using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class button3 : MonoBehaviour {

	public Button btn3;

	// Use this for initialization
	void Start () {

		btn3
			.OnClickAsObservable()
			.Skip(4)
			.Subscribe( _ =>
				{
					Debug.Log("Hellow World!");
				});


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick() {
		Debug.Log ("clicked3!!!");
	}
}
