using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UniRx;

public class TimerViewUniRx : MonoBehaviour
{
	//それぞれインスタンスはインスペクタビューから設定

	[SerializeField] private TimeCounterUniRx timeCounter;

	void Start()
	{
		//タイマのカウンタが変化したイベントを受けて更新する
		timeCounter.OnTimeChanged.Subscribe(time =>
			{
				print(time.ToString());
			});
	}
}

