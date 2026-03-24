using UnityEngine;

public class Attack : MonoBehaviour
{
    private Enemy enemy;
    int dammage;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        dammage = 20;
    }

	private void OnTriggerEnter2D(Collider2D collision)
	{
        Debug.Log("Attack triggered");
		if (collision.CompareTag("Enemy"))


        {
            enemy = collision.GetComponent<Enemy>();
            Debug.Log("Enemy Hit");
            enemy.TakeDamage(dammage);
        }
	}

	//// Update is called once per frame
	//void Update()
 //   {
        
 //   }
}
