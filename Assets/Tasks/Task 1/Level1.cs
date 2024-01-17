using UnityEngine;

public class Level1 : MonoBehaviour
{
    
    
    private void Update()
    {
        var step = Time.deltaTime ;
        var transformPosition = transform.position;
        transformPosition.x += step;

        transform.position = transformPosition;
    }
}