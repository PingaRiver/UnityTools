using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Character : MonoBehaviour
{
    [SerializeField] public string Name;
    [SerializeField] public Color Color;
    [SerializeField] public Font Font;

	// Use this for initialization
	void Start ()
	{
	    gameObject.transform.name = Name;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
