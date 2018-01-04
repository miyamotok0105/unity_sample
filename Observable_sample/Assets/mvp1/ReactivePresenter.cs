using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ReactivePresenter : MonoBehaviour
{
	// Presenter is aware of its View (binded in the inspector)
	public Button MyButton;
	public Toggle MyToggle;

	// State-Change-Events from Model by ReactiveProperty
	Enemy enemy = new Enemy(1000);

	void Start()
	{
		// Rx supplies user events from Views and Models in a reactive manner 
		MyButton.OnClickAsObservable().Subscribe(_ => enemy.CurrentHp.Value -= 99);
		MyToggle.OnValueChangedAsObservable().SubscribeToInteractable(MyButton);

		// Models notify Presenters via Rx, and Presenters update their views
		enemy.CurrentHp.SubscribeToText(MyText);
		enemy.IsDead.Where(isDead => isDead == true)
			.Subscribe(_ =>
				{
					MyToggle.interactable = MyButton.interactable = false;
				});
	}

	// Use this for initialization
//	void Start () {
//
//	}

	// Update is called once per frame
	void Update () {

	}
}

// The Model. All property notify when their values change
public class Enemy
{
	public ReactiveProperty<long> CurrentHp { get; private set; }

	public ReactiveProperty<bool> IsDead { get; private set; }

	public Enemy(int initialHp)
	{
		// Declarative Property
		CurrentHp = new ReactiveProperty<long>(initialHp);
		IsDead = CurrentHp.Select(x => x <= 0).ToReactiveProperty();
	}
}


