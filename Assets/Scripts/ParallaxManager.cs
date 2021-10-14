using UnityEngine;

public class ParallaxManager
{
    private const float CoefBack = 1f;
    private const float CoefMidle = 0.9f;

    private Vector3 _backStartPosition;
    private Vector3 _midleStartPosition;
    private Vector3 _cameraStartPosition;
    private Camera _camera;
    private Transform _backTransform;
    private Transform _midleTransform;

    public ParallaxManager(Camera camera, Transform backTransform, Transform midleTransform)
    {
        _backStartPosition = backTransform.position;
        _cameraStartPosition = camera.transform.position;
        _camera = camera;
        _backTransform = backTransform;
        _midleTransform = midleTransform;
    }

    public void Update()
    {
        _backTransform.position = _backStartPosition + (_camera.transform.position - _cameraStartPosition) * CoefBack;
        _midleTransform.position = _midleStartPosition + (_camera.transform.position - _cameraStartPosition) * CoefMidle;
    }
}
