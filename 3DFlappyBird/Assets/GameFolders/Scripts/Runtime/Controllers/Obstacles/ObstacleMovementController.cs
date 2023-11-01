using UnityEngine;

public class ObstacleMovementController : MonoBehaviour
{
    private void Update()
    {
        transform.position += new Vector3(0, 0, -3 * Time.deltaTime);
        if (transform.position.z <= -24.6f)
        {
            transform.position = new Vector3(-20f, -16f, 25.4f);
        }
    }
}
