using UnityEngine;
using UnityEngine.UI;

public class TimerView : MonoBehaviour
{
	//それぞれインスタンスはインスペクタビューから設定

	[SerializeField] private TimeCounter timeCounter; 

	void Start()
	{
		timeCounter.OnTimeChanged += time => // =>は「ラムダ式」と呼ばれる匿名関数の記法
		{
			print(time.ToString());
		};
	}
}