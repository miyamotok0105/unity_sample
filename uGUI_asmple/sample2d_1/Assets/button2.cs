using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class button2 : MonoBehaviour {

//	public button2
	public Button btn2;
	
	// Use this for initialization
	void Start () {

		btn2.onClick.AddListener(() =>
			{
				Debug.Log("Hellow World!");
			});


	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick() {
		Debug.Log ("clicked2!!!");
	}
}
