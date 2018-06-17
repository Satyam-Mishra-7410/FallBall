
using UnityEngine;

public class Rotator : MonoBehaviour
{
    public float _RotationSpeed = 100.0f;
	
	// Update is called once per frame
	void Update ()
    {
        transform.Rotate(0.0f, 0.0f, _RotationSpeed * Time.deltaTime);		
	}
}
