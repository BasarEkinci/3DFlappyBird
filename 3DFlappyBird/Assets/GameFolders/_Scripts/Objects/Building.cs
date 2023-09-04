using UnityEngine;

public class Building : MonoBehaviour
{
    private void Update()
    {
        transform.position -= new Vector3(0, 0, 8f) * Time.deltaTime;
        if (transform.position.z <= -30f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 35f);
        }
    }
}
