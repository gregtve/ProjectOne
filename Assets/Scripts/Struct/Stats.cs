using System;
using UnityEngine;

[Serializable]
public struct Stats
{
	[HideInInspector] public Int64 OwnerId;
	public int HP;
	public int Damage;
	public int Defence;
	public float BuildTime;
	public float AttackDelay;
	public float MoveSpeed;
	public float AttackRange;
	public ResourcePack[] Cost;
	public float ProduceDelay;
	public ResourcePack[] ProdusedResource;
}
