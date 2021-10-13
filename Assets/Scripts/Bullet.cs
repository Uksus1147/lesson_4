using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float _damage;
    private float _speed;
    private Transform _target;
    private Vector3 _targetPosition;
    public void Initialization(float damage, float lifetime, Transform target, float speed)
    {
        _damage = damage;
        _speed = speed;
        _target = target;
        _targetPosition = _target.position;
        Destroy(this.gameObject, lifetime);
    }
    public void FixedUpdate()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.fixedDeltaTime);
    }
}
