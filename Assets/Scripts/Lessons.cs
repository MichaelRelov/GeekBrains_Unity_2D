using UnityEngine;

public class Lessons : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private SpriteRenderer _background;
    [SerializeField] private SpriteRenderer _middleground;
    [SerializeField] private CharacterView _characterView;
    [SerializeField] private SpriteAnimationConfig _spriteAnimationConfig;

    private ParallaxManager _parallaxManager;
    private SpriteAnimator _spriteAnimator;
    private MainHeroWalker _mainHeroWalker;

    private void Start()
    {
        _parallaxManager = new ParallaxManager(_camera, _background.transform, _middleground.transform);
        _spriteAnimator = new SpriteAnimator(_spriteAnimationConfig);
        _mainHeroWalker = new MainHeroWalker(_characterView, _spriteAnimator);
    }

    private void Update()
    {
        _parallaxManager.Update();
        _spriteAnimator.Update();
        _mainHeroWalker.Update();
    }

    private void FixedUpdate()
    {
        
    }

    private void OnDestroy()
    {
        
    }
}
