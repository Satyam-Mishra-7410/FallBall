using UnityEngine;

public class Player : MonoBehaviour {

    public float _JumpForce = 10.0f;
    private Rigidbody2D _RigidBodySelf;
    private SpriteRenderer _SpriteRenderer;
    private string _CurrentColor;

    public Color _ColorBlue;
    public Color _ColorYellow;
    public Color _ColorPink;
    public Color _ColorPurple;

    private void Start()
    {
        _RigidBodySelf = GetComponent<Rigidbody2D>();
        _SpriteRenderer = GetComponent<SpriteRenderer>();
        SetRandomColor();
    }

    private void Update ()
    {
		if(Input.GetButtonDown("Jump") || Input.GetMouseButtonDown(0))
        {
            _RigidBodySelf.velocity = Vector2.up * _JumpForce;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "ColorChanger")
        {
            SetRandomColor();
        }

        if (collision.tag != _CurrentColor)
        {
            Debug.Log("BOOOOOO!!");
        }
    }

    private void SetRandomColor()
    {
        int index = Random.Range(0, 4);
        switch(index)
        {
            case 0:
                _CurrentColor = "Blue";
                _SpriteRenderer.color = _ColorBlue;
                break;
            case 1:
                _CurrentColor = "Yellow";
                _SpriteRenderer.color = _ColorYellow;
                break;
            case 2:
                _CurrentColor = "Pink";
                _SpriteRenderer.color = _ColorPink;
                break;
            case 3:
                _CurrentColor = "Purple";
                _SpriteRenderer.color = _ColorPurple;
                break;
        }
    }
}
