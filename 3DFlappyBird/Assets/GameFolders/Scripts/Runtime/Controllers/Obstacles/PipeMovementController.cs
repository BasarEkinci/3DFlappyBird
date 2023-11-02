using UnityEngine;

namespace GameFolders.Scripts.Runtime.Controllers.Obstacles
{
    public class PipeMovementController : MonoBehaviour
    {
        internal void Move(float moveSpeed)
        {
            Vector3 moveMultiplier = new Vector3(0, 0, moveSpeed);
            transform.position += moveMultiplier * Time.deltaTime;
        }

        internal void SetPosition(float yPos,float zBound)
        {
            if (transform.position.z <= zBound)
            {
                yPos = Random.Range(-8, 9);
                transform.position = new Vector3(-20, yPos, 25);
            }     
        }
    }
}