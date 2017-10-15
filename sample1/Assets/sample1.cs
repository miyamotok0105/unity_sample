using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sample1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		print ("start...");
		this.sampleMethod1 ();
		this.sampleMethod2 ();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void sampleMethod1 () {
		print ("sampleMethod1...");

		int answer = 10;
		answer++;
		Debug.Log(answer);

		string str1 = "happy ";
		string str2 = "birthday";
		string message;

		message = str1 + str2;
		Debug.Log(message);

		str1 += str2;
		Debug.Log(str1);

		string str = "happy ";
		int num = 123;

		message = str + num;
		Debug.Log (message);

		int herbNum = 1;
		if(herbNum == 1) {
			Debug.Log("HP‚ª50‰ñ•œ");
		}

		int hp = 200;
		if(hp >= 100) {
			Debug.Log("UŒ‚I");
		} else {
			Debug.Log("–hŒäI");
		}
	}

	void sampleMethod2 () {
		print ("sampleMethod2...");

		int x = 1;
		int y = 0;
		if(x == 1) {
			y = 2;
			Debug.Log(x);
			Debug.Log(y);
		}
		Debug.Log(y);

		for(int i = 0; i < 5; i++) {
			Debug.Log(i);
		}
		for(int i = 0; i < 10; i += 2) {
			Debug.Log(i);
		}
		// Hello, Worldをコンソールウインドウに表示する
		Debug.Log("Hello, World");
		for(int i = 3; i <= 5; i++) {
			Debug.Log(i);
		}
		for(int i = 3; i >= 0; i--) {
			Debug.Log(i);
		}
		int sum = 0;
		for(int i = 1; i <= 10; i++) {
			sum += i;
		}
		Debug.Log(sum);
		int[] array = new int[5];

		array[0] = 2;
		array[1] = 10;
		array[2] = 5;
		array[3] = 15;
		array[4] = 3;

		for(int i = 0; i < 5; i++) {
			Debug.Log(array[i]);
		}
		int[] points = {83, 99, 52, 93, 15};

		for(int i = 0; i < points.Length; i++) {
			if(points[i] >= 90) {
				Debug.Log(points[i]);
			}
		}
		int[] points2 = {83, 99, 52, 93, 15};

		sum = 0;
		for(int i = 0; i < points2.Length; i++) {
			sum += points2[i];
		}

		int average = sum / points2.Length;
		Debug.Log(average);

		int answer;
		answer = Add(2, 3);
		Debug.Log(answer);


		Player myPlayer = new Player();
		myPlayer.Attack();
		myPlayer.Damage(30);

		int age;
		age = 30;
		Debug.Log(age);

		//2D ベクトルと位置の表現
		Vector2 playerPos = new Vector2(3.0f, 4.0f);
		playerPos.x += 8.0f;
		playerPos.y += 5.0f;
		Debug.Log(playerPos);


		Vector2 startPos = new Vector2(2.0f, 1.0f);
		Vector2 endPos = new Vector2(8.0f, 5.0f);
		Vector2 dir = endPos - startPos;
		Debug.Log(dir);

		//magnitude：２点間距離
		float len = dir.magnitude;
		Debug.Log(len);

		float height1 = 160.5f;
		float height2;
		height2 = height1;
		Debug.Log(height2);

		int answer2 = 10;
		answer2 += 5;
		Debug.Log(answer2);

	}


	public class Player {

		private int hp = 100;
		private int power = 50;

		public void Attack() {
			Debug.Log(this.power + "のダメージを与えた");
		}
		public void Damage(int damage) {
			this.hp -= damage;
			Debug.Log(damage + "のダメージを受けた");
		}
	}

	int Add(int a, int b) {
		int c = a + b;
		return c;
	}

	void sampleMethod3 () {

	}

	void sampleMethod4 () {

	}

	void sampleMethod5 () {

	}
}
