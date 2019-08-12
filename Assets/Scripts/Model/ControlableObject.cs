using System.Collections.Generic;
using UnityEngine;

public class ControlableObject : SceneObjectBase, IModificable
{
	public List<IModificator> Modificators;
	[SerializeField] private Stats _baseStats;
	[HideInInspector] public Stats CurrentStats;

	public void AddModificator(IModificator modificator)
	{
		Modificators.Add(modificator);
		CurrentStats = modificator.ApplyModificator(CurrentStats);
	}

	public void RemoveModificator(IModificator modificator)
	{
		if (Modificators.Remove(modificator))
			CurrentStats = modificator.RemoveModificator(CurrentStats);
	}
}
