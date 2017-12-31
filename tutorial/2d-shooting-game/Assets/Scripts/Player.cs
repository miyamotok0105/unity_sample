using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
	public float speed = 5;
	public GameObject bullet;
	Spaceship spaceship;

	IEnumerator Start ()
	{
		spaceship = GetComponent<Spaceship> ();

		while (true) {
			spaceship.Shot (transform);
			GetComponent<AudioSource>().Play();

			yield return new WaitForSeconds (spaceship.shotDelay);

//			Instantiate (bullet, transform.position, transform.rotation);
//			// 0.05秒待つ
//			yield return new WaitForSeconds (0.05f);
		}
	}

	// Use this for initialization
//	void Start () {
//		while (true) {
//			Instantiate (bullet, transform.position, transform.rotation);
//			// 0.05秒待つ
//			yield return new WaitForSeconds (0.05f);
//		}
//	}
	
	// Update is called once per frame
	void Update () {
		// 右・左
		float x = Input.GetAxisRaw ("Horizontal");

		// 上・下
		float y = Input.GetAxisRaw ("Vertical");

		// 移動する向きを求める
		Vector2 direction = new Vector2 (x, y).normalized;

		// 移動する向きとスピードを代入する
//		GetComponent<Rigidbody2D>().velocity = direction * speed;

		spaceship.Move (direction);
	}

	void OnTriggerEnter2D (Collider2D c)
	{
		string layerName = LayerMask.LayerToName(c.gameObject.layer);

		if( layerName == "Bullet (Enemy)")
		{
			// 弾の削除
			Destroy(c.gameObject);
		}

		if( layerName == "Bullet (Enemy)" || layerName == "Enemy")
		{
			// 爆発する
			spaceship.Explosion();

			// プレイヤーを削除
			Destroy (gameObject);
		}
	}
}
