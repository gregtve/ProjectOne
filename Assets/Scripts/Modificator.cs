public class Modificator : BaseSceneObject, IModificator
{
	public Stats ApplyModificator(Stats stats)
	{
		stats.HP += 100;
		return stats;
	}

	public Stats RemoveModificator(Stats stats)
	{
		stats.HP -= 100;
		return stats;
	}

}
