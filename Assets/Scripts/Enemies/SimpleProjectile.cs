using System.Collections;
using UnityEngine;

public class SimpleProjectile : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed = 1.0f;
    public float duration = 1.0f;
    public PlayerController player;
    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    public void InstantiateProjectile(Vector2 velocity)
    {
        rb.linearVelocity = velocity * speed;
        StartCoroutine(ProjectileTimer());

    }

    public IEnumerator ProjectileTimer()
    {
        yield return new WaitForSeconds(duration);
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // add the logic of what happens to the player on impact
        // -hp
        // etc
        if (collision.gameObject.tag == "Player")
        {
            player.healthbar -= 20;
        }

    }
}
