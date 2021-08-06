using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestUpdater : MonoBehaviour
{

	public List<PlayerPanal> players;

  // Update is called once per frame
  void Update()
  {
		if (Input.GetKeyDown(KeyCode.Alpha1))
		{
			players[Random.Range(0, players.Count)].changeHearts(Random.Range(-3, 4));
			Debug.Log("Alpha1 Pressed");
		}

		if (Input.GetKeyDown(KeyCode.Alpha2))
		{
			players[Random.Range(0, players.Count)].changeSouls(Random.Range(-3, 4));
			Debug.Log("Alpha2 Pressed");
		}

		if (Input.GetKeyDown(KeyCode.Alpha3))
		{
			players[Random.Range(0, players.Count)].changeHumanity(Random.Range(-3, 4));
			Debug.Log("Alpha3 Pressed");
		}
	}

}
