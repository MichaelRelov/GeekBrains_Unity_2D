using UnityEngine;

public class CharacterView : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer _spriteRenderer;

    [SerializeField]
    private Collider2D _collider;

    [SerializeField]
    private Rigidbody2D _rigidbody;

    [Header("Settings")]
    [SerializeField]
    private float _walkSpeed = 1f;

    [SerializeField]
    private float _animationsSpeed = 3f;
    
    [SerializeField]
    private float _jumpStartSpeed = 2f;
    
    [SerializeField]
    private float _movingThresh = 0.1f;
    
    [SerializeField]
    private float _flyThresh = 0.4f;
    
    [SerializeField]
    private float _groundLevel = 0.5f;
    
    [SerializeField]
    private float _acceleration = -10f;

    public SpriteRenderer SpriteRenderer => _spriteRenderer;

    public Collider2D Collider => _collider;

    public Rigidbody2D Rigidbody => _rigidbody;

    public float WalkSpeed => _walkSpeed;

    public float AnimationsSpeed => _animationsSpeed;

    public float JumpStartSpeed => _jumpStartSpeed;

    public float MovingThresh => _movingThresh;

    public float FlyThresh => _flyThresh;

    public float GroundLevel => _groundLevel;

    public float Acceleration => _acceleration;
}
