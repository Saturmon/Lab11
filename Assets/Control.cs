using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour
{
    private Rigidbody2D _compRigidbody;
    public float speedx;
    public float speedy;
    public int direccionx;
    public int direcciony;
    private SpriteRenderer _spriteRenderer;
    private void Awake()
    {
        _compRigidbody = GetComponent<Rigidbody2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    private void FixedUpdate()
    {
        _compRigidbody.velocity = new Vector2(speedx * direccionx,speedy * direcciony);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "HorizontalWall")
        {
            if(direccionx == 1)
            {
                direccionx = -1;
                _spriteRenderer.flipX = true;
            }
            else if(direccionx == -1)
            {
                direccionx = 1;
                _spriteRenderer.flipX = false;
            }
        }
        if(collision.gameObject.tag == "VerticalWall")
        {
            if(direcciony == 1)
            {
                direcciony = -1;
                _spriteRenderer.flipY = true;
            }
            else if(direcciony == -1)
            {
                direcciony = 1;
                _spriteRenderer.flipY = false;
            }
        }
    }

}
