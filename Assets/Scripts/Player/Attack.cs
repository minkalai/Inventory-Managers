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
		if (collision.tag == "Enemy")
        {
            enemy.TakeDamage(dammage);
        }
	}

	//// Update is called once per frame
	//void Update()
 //   {
        
 //   }
}
