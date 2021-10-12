using UnityEngine;

public class ParallaxManager
{
    private const float Coef = 0.8f;

    private Vector3 _backStartPosition;
    private Vector3 _cameraStartPosition;
    private Camera _camera;
    private Transform _backTransform;

    public ParallaxManager(Camera camera, Transform backTransform)
    {
        _backStartPosition = backTransform.position;
        _cameraStartPosition = camera.transform.position;
        _camera = camera;
        _backTransform = backTransform;
    }

    public void Update()
    {
        _backTransform.position = _backStartPosition + (_camera.transform.position - _cameraStartPosition) * Coef;
    }
}
