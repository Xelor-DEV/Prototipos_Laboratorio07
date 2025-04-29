using UnityEngine;

public class BulletAttack : MonoBehaviour, IAttackable
{
    [SerializeField] private GameObject bullet;

    public void Attack(Vector2 position)
    {
        Vector3 tmp = Camera.main.ScreenToWorldPoint(position, Camera.MonoOrStereoscopicEye.Mono);
        Vector3 direction = (tmp - transform.position).normalized;

        GameObject tmpBullet = Instantiate(bullet, transform.position, Quaternion.identity);
        tmpBullet.GetComponent<Bullet>().direction = direction;
    }
}