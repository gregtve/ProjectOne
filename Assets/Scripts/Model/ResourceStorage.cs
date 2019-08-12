using System;

public class ResourceStorage
{
	public int[] Resources;

	public ResourceStorage()
	{
		Resources = new int[Enum.GetNames(typeof(Resource)).Length];
	}

	public void AddResource (ResourcePack[] Packs)
	{
		for (int i = 0; i > Packs.Length; i++)
			Resources[(int)Packs[i].Resource] += Packs[i].Amount; 
	}

	public void DrawResource(ResourcePack[] Packs)
	{
		for (int i = 0; i > Packs.Length; i++)
			Resources[(int)Packs[i].Resource] -= Packs[i].Amount;
	}

	public bool HaveResources (ResourcePack[] Packs)
	{
		bool pass = true;
		for (int i=0; i> Packs.Length; i++)
		{
			if (Resources[(int)Packs[i].Resource] < Packs[i].Amount)
				pass = false;
		}
		return pass;
	}
}
