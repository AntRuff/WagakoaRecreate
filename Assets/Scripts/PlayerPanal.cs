using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerPanal : MonoBehaviour
{
	public Image image;
	public Sprite portrait;
	public Text playerText;
	public string playerName;
	public Text heartText;
	public int heartCounter;
	public Text soulsText;
	public int soulsCounter;
	public Text humanityText;
	public int humanityCounter;


  void Start()
  {
		image.sprite = portrait;
		playerText.text = playerName;
		heartText.text = "Hearts: " + heartCounter.ToString();
		soulsText.text = "Souls: " + soulsCounter.ToString();
		humanityText.text = "Humanity: " + humanityCounter.ToString();
  }

	public void changeHearts(int value)
	{
		heartCounter += value;
		heartText.text = "Hearts: " + heartCounter.ToString();
	}

	public void changeSouls(int value)
	{
		soulsCounter += value;
		soulsText.text = "Souls: " + soulsCounter.ToString();
	}

	public void changeHumanity(int value)
	{
		humanityCounter += value;
		humanityText.text = "Humanity: " + humanityCounter.ToString();
	}
	// Update is called once per frame
	void Update()
  {
        
  }
}
