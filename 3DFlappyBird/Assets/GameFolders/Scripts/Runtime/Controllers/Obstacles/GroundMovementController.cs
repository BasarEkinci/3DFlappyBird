using UnityEngine;

namespace GameFolders.Scripts.Runtime.Controllers.Obstacles
{
    public class GroundMovementController : MonoBehaviour
    {
        internal void Move(float moveSpeed)
        {
            transform.position += new Vector3(0, 0, moveSpeed) * Time.deltaTime;
        }

        internal void SetPosition(float zBound,float newZPos)
        {
            if (transform.position.z <= zBound)
            {
                transform.position = new Vector3(0, 0, newZPos);
            }
        }
    }
}