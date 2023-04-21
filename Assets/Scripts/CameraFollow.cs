using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public Vector3 offset;
    public float followSpeed = 2f;

    void LateUpdate()
    {
        Vector3 newPosition = new Vector3(target.position.x, target.position.y, -10f); 
        transform.position = Vector3.Slerp(transform.position, newPosition, followSpeed * Time.deltaTime); 
    }
}