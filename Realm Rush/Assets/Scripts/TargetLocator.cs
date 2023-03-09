using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TargetLocator : MonoBehaviour
{
    [SerializeField] Transform weapon;
     Transform enemy;
    void Start()
    {
        enemy = FindObjectOfType<enemyMover>().transform;
    }
    void Update()
    {
        weapon.LookAt(enemy);
    }
}
