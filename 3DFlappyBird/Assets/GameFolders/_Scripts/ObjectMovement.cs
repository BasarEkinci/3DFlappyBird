using UnityEngine;

public class ObjectMovement : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float upperLimit;
    [SerializeField] private float lowerLimit;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;

    private float yPos;
    
    private void Update()
    {
        if (GameManager.Instance.IsGameOver || !GameManager.Instance.IsGameStarted) return;
        
        transform.position -= new Vector3(0, 0, speed) * Time.deltaTime;
        if (transform.position.z <= lowerLimit)
        {
            yPos = Random.Range(minY, maxY);
            transform.position = new Vector3(transform.position.x,yPos, upperLimit);
        }
    }
}
