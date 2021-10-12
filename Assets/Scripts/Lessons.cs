using UnityEngine;

public class Lessons : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private SpriteRenderer _background;
    [SerializeField] private CharacterView _characterView;
    [SerializeField] private SpriteAnimationConfig _spriteAnimationConfig;

    private ParallaxManager _parallaxManager;
    private SpriteAnimator _spriteAnimator;

    private void Start()
    {
        _parallaxManager = new ParallaxManager(_camera, _background.transform);
        _spriteAnimator = new SpriteAnimator(_spriteAnimationConfig);
        _spriteAnimator.StartAnimation(_characterView.SpriteRenderer, Track.walk, true, 10f);
    }

    private void Update()
    {
        _parallaxManager.Update();
        _spriteAnimator.Update();
    }

    private void FixedUpdate()
    {
        
    }

    private void OnDestroy()
    {
        
    }
}
