using UnityEngine;
using Random = UnityEngine.Random;

public class Cloud : MonoBehaviour
{
    [SerializeField] float speed;

    private void Update()
    {
        transform.position -= new Vector3(0, 0, speed)* Time.deltaTime;
        if (transform.position.z <= -40f)
        {
            float yPos = Random.Range(20, 35);
            transform.position = new Vector3(transform.position.x, yPos, 50f);
        }
    }
}
