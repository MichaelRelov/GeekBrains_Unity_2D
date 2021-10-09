using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lessons : MonoBehaviour
{
    [SerializeField] private Camera _camera;
    [SerializeField] private SpriteRenderer _background;

    private ParallaxManager _parallaxManager;


    private void Start()
    {
        _parallaxManager = new ParallaxManager(_camera, _background.transform);
    }

    private void Update()
    {
        _parallaxManager.Update();
    }

    private void FixedUpdate()
    {
        
    }

    private void OnDestroy()
    {
        
    }
}
