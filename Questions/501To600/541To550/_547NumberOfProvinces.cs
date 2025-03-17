namespace Questions._501To600._541To550
{
	/// <summary>
	/// There are n cities. Some of them are connected, while some are not. If city a is connected directly with city b, and city b is connected directly with city c, then city a is connected indirectly with city c.
	//A province is a group of directly or indirectly connected cities and no other cities outside of the group.
	//You are given an n x n matrix isConnected where isConnected[i][j] = 1 if the ith city and the jth city are directly connected, and isConnected[i][j] = 0 otherwise.
	//Return the total number of provinces.

	//	Constraints:

	//1 <= n <= 200
	//n == isConnected.length
	//n == isConnected[i].length
	//isConnected[i][j] is 1 or 0.
	//isConnected[i][i] == 1
	//isConnected[i][j] == isConnected[j][i]
	/// </summary>
	public static class _547NumberOfProvinces
	{
		// For each city, if it is connected to any other city, it's N-1 province
		// We don't need to iterate on a city
		// I don't to iterate matrix[j][i] or matrix[i][i]
		public static int FindCircleNum(int[][] inputData)
		{
			var provinces = new List<int[]>();

			for (int i = 0; i < inputData.Length; i++)
			{
				for (int j = 0; j < inputData[i].Length; j++)
				{
					var connection = inputData[i][j];
					if (connection == 0)
						continue;

					var groups = provinces.Where(p => p.Intersect([i, j]).Any());
					if (!groups.Any())
					{
						if (i == j)
						{
							provinces.Add([j]);
						}
						else
							provinces.Add([i, j]);
						continue;
					}
					var group = groups.First();
					var newGroup = group.Union([j]).ToArray();
					if (groups.Count() > 1)
					{
						var seccondGroup = groups.Skip(1).First();
						var temp = newGroup.Union(seccondGroup).ToArray();
						var firstGroupIndex = provinces.Remove(group);
						var seccondGroupIndex = provinces.Remove(seccondGroup);
						newGroup = temp;
					}

					provinces.Remove(group);
					provinces.Add(newGroup);
				}
			}
			return provinces.Count;
		}
	}
}
