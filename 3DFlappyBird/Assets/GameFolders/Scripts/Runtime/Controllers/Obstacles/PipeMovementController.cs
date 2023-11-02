using System;
using DG.Tweening;
using GameFolders.Scripts.Runtime.Data.UnityObjects;
using GameFolders.Scripts.Runtime.Data.ValueObjects;
using UnityEngine;
using Random = UnityEngine.Random;

namespace GameFolders.Scripts.Runtime.Controllers.Obstacles
{
    public class PipeMovementController : MonoBehaviour
    {
        private float moveSpeed;
        private float _yPos;
        private Vector3 _newPos;
        private GameData _data;

        private void Awake()
        {
            _data = GetData();
            moveSpeed = _data.GameSpeed;
        }

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

        private GameData GetData()
        {
            return Resources.Load<CD_GameData>("Data/CD_GameData").gameData;
        }
    }
}