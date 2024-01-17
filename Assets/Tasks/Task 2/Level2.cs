using UnityEngine;

public class Level2 : MonoBehaviour
{
    private float _speed = 10;
    
    private void LateUpdate()
    {
        var step = Time.deltaTime * _speed;
        var transformPosition = transform.position;
        transformPosition.x += step;

        transform.position = transformPosition;
    }
}