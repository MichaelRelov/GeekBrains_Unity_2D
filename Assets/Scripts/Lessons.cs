<<<<<<< HEAD
using System.Collections.Generic;
using UnityEngine;

public class Lessons : MonoBehaviour
{
    [SerializeField]
    private Camera _camera;

    [SerializeField]
    private SpriteRenderer _background;

    [SerializeField]
    private CharacterView _characterView;

    [SerializeField]
    private SpriteAnimationConfig _spriteAnimationConfig;
    
    [SerializeField]
    private CannonView _cannonView;

    [SerializeField] 
    private Transform _muzzleTransform;
    
    [SerializeField]
    private List<BulletView> _bulletsView;
    
    [SerializeField]
    private List<CoinView> _coinViews;

    private ParalaxManager _paralaxManager;
    private SpriteAnimator _spriteAnimator;
    private MainHeroTransformWalker _mainHeroTransformWalker;
    private AimingMuzzle _aimingMuzzle;
    private BulletsEmitter _bulletsEmitter;
    private MainHeroPhysicsWalker _mainHeroPhysicsWalker;
    private CoinsManager _coinsManager;

    private void Start()
    {
        _paralaxManager = new ParalaxManager(_camera, _background.transform);
        _spriteAnimator = new SpriteAnimator(_spriteAnimationConfig);
        _mainHeroPhysicsWalker = new MainHeroPhysicsWalker(_characterView, _spriteAnimator);
        _aimingMuzzle = new AimingMuzzle(_cannonView.transform, _characterView.transform);
        _bulletsEmitter = new BulletsEmitter(_bulletsView, _muzzleTransform.transform);
        _coinsManager = new CoinsManager(_coinViews, _spriteAnimator);
    }

    private void Update()
    {
        _paralaxManager.Update();
        _spriteAnimator.Update();
        _aimingMuzzle.Update();
        _bulletsEmitter.Update();
    }

    private void FixedUpdate()
    {
        _mainHeroPhysicsWalker.FixedUpdate();
    }

    private void OnDestroy()
    {
        _coinsManager?.Dispose();
    }
}
=======
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
>>>>>>> main
