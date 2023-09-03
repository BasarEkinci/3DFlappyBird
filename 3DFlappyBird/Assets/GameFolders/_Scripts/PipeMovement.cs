using UnityEngine;

public class PipeMovement : MonoBehaviour
{
    private void Update()
    {
        transform.position += new Vector3(0, 0, -10) * Time.deltaTime;

        if (transform.position.z <= -18f)
        {
            float yPos = Random.Range(0, 14);
            transform.position = new Vector3(transform.position.x, yPos, 15);
        }
    }
}
