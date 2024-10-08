using System;
using UnityEngine;
using UnityEngine.Pool;

public class Launcher : MonoBehaviour {
    [SerializeField] Bullet bulletPrefab;
    private IObjectPool<Bullet> bulletPool;

    private void Awake()
    {
        bulletPool = new ObjectPool<Bullet>(
            OnCreate, OnGet, OnRelease, OnDestroy_P,maxSize: 3);
    }

    private Bullet OnCreate()
    {
        Bullet bullet = Instantiate(bulletPrefab);
        bullet.SetPool(bulletPool);
        return bullet;
    }
    private void OnGet(Bullet bullet) { 
        bullet.gameObject.SetActive(true);
        bullet.transform.position = transform.position;
    }
    private void OnRelease(Bullet bullet) 
        => bullet.gameObject.SetActive(false);
    private void OnDestroy_P(Bullet bullet) 
        => Destroy(bullet.gameObject);


    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            bulletPool.Get();
        }
    }
}