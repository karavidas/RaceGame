using UnityEngine;
using System.Collections;

public class on_off_light : MonoBehaviour
{

	public Light[] lights;
	
	void Start ()
	{
		foreach (Light light in lights)
		{
			light .enabled = !light .enabled;
		}
	}
}

