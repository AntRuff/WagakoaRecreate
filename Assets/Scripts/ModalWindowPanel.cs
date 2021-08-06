using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class ModalWindowPanel : MonoBehaviour
{
	[Header("Header")]
	[SerializeField]
	private Transform _headerArea;
	[SerializeField]
	private TextMeshProUGUI _titleField;

	[Header("Content")]
	[SerializeField]
	private Transform _contentArea;
	[SerializeField]
	private Image _cardImage;
	[SerializeField]
	private Image _dealImage;

	[Header("Footer")]
	[SerializeField]
	private Transform _footerArea;
	[SerializeField]
	private Button _button1;
	[SerializeField]
	private Button _button2;
	[SerializeField]
	private Button _button3;
	[SerializeField]
	private Button _button4;

	private Action onButton1Action;
	private Action onButton2Action;
	private Action onButton3Action;
	private Action onButton4Action;

	public void Button1()
	{
		onButton1Action?.Invoke();
		//Close();
	}

	public void Button2()
	{
		onButton1Action?.Invoke();
		//Close();
	}

	public void Button3()
	{
		onButton1Action?.Invoke();
		//Close();
	}

	public void Button4()
	{
		onButton1Action?.Invoke();
		//Close();
	}
}
