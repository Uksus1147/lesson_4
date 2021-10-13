using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private Vector3 _direct;      
    public float speed = 2;
    public float Rotatespeed = 100f;
    //private GameObject _bulletPrefab;
    //public Transform _spawnBulletPoint;
    //private float damage = 2f;
    
   

    private void Awake()
    {
        _direct = Vector3.zero;
    }
    private void Update()
    {
        _direct.x = Input.GetAxis("Horizontal");
        _direct.z = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        Move();
        //Fire();

        transform.Rotate(0, Input.GetAxis("Mouse X") * Rotatespeed * Time.fixedDeltaTime, 0);
        

    }
    private void Move()
    {
        Vector3 direction = _direct * speed * Time.fixedDeltaTime;
        transform.Translate(direction);
    }
    //private void Fire()
   // {
    //    GameObject bulletObject = Instantiate(_bulletPrefab, _spawnBulletPoint.position, _spawnBulletPoint.rotation);
   //     Bullet bullet = bulletObject.transform.gameObject.GetComponent<Bullet>();
    //    bullet.Initialization(damage, 3f, null);  
    //}
}
