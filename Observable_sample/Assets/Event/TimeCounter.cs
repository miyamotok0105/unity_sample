﻿using System.Collections;
using UnityEngine;

/// <summary>
/// 100からカウントダウンし値を通知するサンプル
/// </summary>
public class TimeCounter : MonoBehaviour
{
	/// <summary>
	/// イベントハンドラ（イベントメッセージの型定義）
	/// </summary>
	public delegate void TimerEventHandler(int time);

	/// <summary>
	/// イベント
	/// </summary>
	public event TimerEventHandler OnTimeChanged;


	void Start()
	{
		//StartCoroutineはコルーチンの実行
		//コルーチンは処理を途中で止めて再実行したりする。
		StartCoroutine(TimerCoroutine());
	}

	//IEnumeratorのインターフェースはコルーチンの宣言
	IEnumerator TimerCoroutine()
	{
		//100からカウントダウン
		var time = 100;
		while (time > 0)
		{
			time--;
			//イベント通知
			OnTimeChanged(time);

			//1秒待つ
			yield return new WaitForSeconds(1);
		}
	}
}