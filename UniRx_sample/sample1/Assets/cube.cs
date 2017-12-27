using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown (0)) {
//			print ("get mouse button!!");

			//光を飛ばして物体を検出する
//			Ray ray = new Ray();
//			RaycastHit hit = new RaycastHit();
//			ray = Camera.main.ScreenPointToRay(Input.mousePosition);
			//Rayを飛ばしてオブジェクトがあればtrue 
//			if (Physics.Raycast(ray.origin, ray.direction, out hit, Mathf.Infinity))
//			{
//				print (hit.collider.gameObject.ToString());
//
////				if(hit.collider.gameObject.CompareTag("cubeTag1"))
////				{
////					print ("hit");
////					//hit.collider.gameObject.GetComponent<CubeControl>().OnUserAction();
////				}
//			}


		}

	}
}
