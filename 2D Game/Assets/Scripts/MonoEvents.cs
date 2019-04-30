using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{

	public UnityEvent startEvent;
	public UnityEvent enableEvent;
	public UnityEvent triggerEnterEvent;
	public UnityEvent updateEvent;
	public UnityEvent collisionEnterEvent;
	void Start () {
		startEvent.Invoke();
	}

	private void OnEnable()
	{
		enableEvent.Invoke();
	}

	private void OnTriggerEnter(Collider other)
	{
		triggerEnterEvent.Invoke();
	}

	private void OnCollisionEnter(Collision other)
	{
		collisionEnterEvent.Invoke();
	}

	void Update () {
		updateEvent.Invoke();
	}
}
