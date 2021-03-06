﻿using System;
using System.Collections.Generic;

public class ScoreComponents{

	public float maxTime { get; set; }
	public float timeTaken { get; set; }

	public int amountOfVirusFlipped { get; set; }

	public int moves { get; set; }
	public int movePerfect { get; set; }

	public bool won { get; set; }

	public List<KeyValuePair<int, int>> ingredients { get; set; }

	public int matchedCards;

	public ScoreComponents()
	{
		won = false;
	}

}
