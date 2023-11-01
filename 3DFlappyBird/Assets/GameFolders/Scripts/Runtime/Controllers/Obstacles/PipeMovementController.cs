using UnityEngine;

namespace GameFolders.Scripts.Runtime.Controllers.Obstacles
{
    public class PipeMovementController : MonoBehaviour
    {
        [SerializeField] private float moveSpeed;
        private float _yPos;
        private Vector3 _newPos;
        private void Update()
        {
            SetPos();
            Move();
        }
        private void Move()
        {
            var move = new Vector3(0, 0, -moveSpeed * Time.deltaTime);
            transform.position += move;
        }
        private void SetPos()
        {
            if (transform.position.z <= -14f)
            {
                _yPos = Random.Range(-6, 9);
                _newPos = new Vector3(-20, _yPos, 25);
                transform.position = _newPos;
            }
        }
    }
}