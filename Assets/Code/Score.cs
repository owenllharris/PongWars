using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	int Points = 0;
	public int BuildBlocks = 5;

	public TextMesh points;
	public TextMesh blocks;

	void Update()
	{
		points.text = "Score: " + Points;
		blocks.text = "Blocks: " + BuildBlocks;
	}


	public void IncreaseScore()
	{
		Points++;
	}
}
