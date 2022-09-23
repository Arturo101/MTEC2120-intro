using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
public int myVar = 0;
public bool isPressed = false;
public GameObject prefab;
    // Start is called before the first frame update
    void Start()
    {
	Instantiate(prefab, Vector3.zero, Quaternion.identity);
	
        
    }

    // Update is called once per frame
    void Update()
    {
	//Debug.Log(Input.mousePosition);
	
	if (Input.GetMouseButtonDown(0))
	{
	Debug.Log("Mouse button pressed.");
	isPressed =true;
	
	}
	if (Input.GetMouseButtonUp(0))
	{
	Debug.Log("Mouse button pressed.");
	isPressed = false;
	}
        
    }
}
