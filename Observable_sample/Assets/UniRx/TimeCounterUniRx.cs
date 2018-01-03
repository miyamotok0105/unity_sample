using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;

public class TimeCounterUniRx : MonoBehaviour
{
	//イベントを発行する核となるインスタンス
	//Subjectが上手いことやってくれる
	private Subject<int> timerSubject = new Subject<int>();

	//イベントの購読側だけを公開
	//IObservableの処理を公開して他のクラスからSubscribeして実行する
	public IObservable<int> OnTimeChanged
	{
		get { return timerSubject; }
	} 

	void Start()
	{
		//StartCoroutineはコルーチン呼び出し
		StartCoroutine(TimerCoroutine());
	}

	IEnumerator TimerCoroutine()
	{
		//100からカウントダウン
		var time = 100;
		while (time > 0)
		{
			time--;

			//イベントを発行
			timerSubject.OnNext(time);

			//1秒待つ
			yield return new WaitForSeconds(1);
		}
	}
}
