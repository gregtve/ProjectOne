using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Unit : BaseSceneObject, IModificatable
{

	public List<IModificator> Modificators;
	public Stats CurrentStats;
	private Modificator TestModificator;

	private void Awake()
	{
		Modificators = new List<IModificator>();
		TestModificator = new Modificator();
		Debug.Log(CurrentStats.HP);
	}

	public void FirstButton()
	{
		AddModificator(TestModificator);
		Debug.Log(CurrentStats.HP);
	}

	public void SecondButton()
	{
		RemoveModificator(TestModificator);
		Debug.Log(CurrentStats.HP);
	}

	public void AddModificator(IModificator modificator)
	{
		Modificators.Add(modificator);
		CurrentStats = modificator.ApplyModificator(CurrentStats);
	}

	public void RemoveModificator(IModificator modificator)
	{
		if (Modificators.Remove(modificator)) CurrentStats = modificator.RemoveModificator(CurrentStats);
	}
}
