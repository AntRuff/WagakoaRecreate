using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CardReader : MonoBehaviour
{

	public Card card;

	public Text cardName;
	public Text type;
	public Text description;

	public Animator animator;

	public Button playButton;

  // Start is called before the first frame update
  void Start()
  {
		cardName.text = card.cardName;
		type.text = card.Type.ToString();
		description.text = card.description;
		animator.SetBool("IsInHand", true);
  }

	private void OnMouseOver()
	{
		animator.SetBool("IsViewed", true);
	}

	private void OnMouseExit()
	{
		if (!playButton.IsActive())
		{
			animator.SetBool("IsViewed", false);
		}
	}

	private void OnMouseDown()
	{
		Debug.Log("Clicked: " + this.gameObject.name);
		//playButton.gameObject.SetActive(!playButton.IsActive());

	}
}
