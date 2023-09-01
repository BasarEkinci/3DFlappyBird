using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    private void Update()
    {
        transform.position += new Vector3(0, 0, -10) * Time.deltaTime;
        if (transform.position.z <= -26.8f)
            transform.position = new Vector3(transform.position.x, transform.position.y, 28.8f);
    }
}
