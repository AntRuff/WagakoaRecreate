using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
	public enum type { Action, Event, Deal };
	public type Type;
	public string cardName;
	public string description;
}
