using UnityEngine;

public class FollowPlayer : MonoBehaviour {

    public Transform _PlayerTransform;

    public void Update()
    {
        if(_PlayerTransform.position.y != transform.position.y)
        {
            transform.position = new Vector3(transform.position.x, _PlayerTransform.position.y, transform.position.z);
        }
    }
}
