using UnityEngine;
using UnityEngine.Pool;

public class Bullet : MonoBehaviour {
    [SerializeField] Vector3 speed;
    private IObjectPool<Bullet> Pool;

    public void SetPool(IObjectPool<Bullet> pool)
    {
        Pool = pool;
    }

    private void Update() {
        transform.position += speed * Time.deltaTime;
    }

    private void OnBecameInvisible() {
        Pool.Release(this);
    }
}