using System;
using System.Collections.Generic;
using UnityEngine;

//[Serializable]
public class Unit : ControlableObject
{
	private Modificator TestModificator;

	protected override void Awake()
	{
		base.Awake();
		Modificators = new List<IModificator>();
		TestModificator = new Modificator();
		Debug.Log(CurrentStats.HP);
	}

	public void FirstButton()
	{
		AddModificator(TestModificator);
		StatsToConsole();
	}

	public void SecondButton()
	{
		RemoveModificator(TestModificator);
		StatsToConsole();
	}

	private void StatsToConsole()
	{
		Debug.Log($"{CurrentStats.HP}, {Modificators.Count}");
	}
}
