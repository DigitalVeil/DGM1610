using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{

	public UnityEvent startEvent;
	public UnityEvent enableEvent;
	public UnityEvent mouseDownEvent;
	public UnityEvent updateEvent; 
	void Start () {
		startEvent.Invoke();
	}

	private void OnEnable()
	{
		enableEvent.Invoke();
	}
	private void OnMouseDown()
	{
		mouseDownEvent.Invoke();
	}
	void Update () {
		updateEvent.Invoke();
	}
}
