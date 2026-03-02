using JetBrains.Annotations;
using TMPro;
using UnityEngine;
using UnityEngine.Tilemaps;

public class PlayerController : MonoBehaviour
{
    [SerializeField] public TextMeshProUGUI coins, health;
	//[SerializeField] public EnemySpawner reset;
    public int coinCount, healthbar, maxHealth;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coinCount = 0;
        coins.text = coinCount.ToString();
		maxHealth = 100;
		healthbar = maxHealth;
		health.text = healthbar.ToString();	
	}

    // Update is called once per frame
    void Update()
    {
        
    }

	//private void OnTriggerEnter(Collider other)
	//{
	//	GameObject triggerObject = other.gameObject;
 //       //Tilemap object = other.GetComponent<Tilemap>();

	//	if (other.tag == "Treasure")
 //       {
 //           Debug.Log("Treasure Hit");
 //           coinCount++;
 //           triggerObject.gameObject.SetActive(false);
 //           //other.gameObject.SetActive(false); 
	//	}
	//}

	private void OnTriggerEnter2D(Collider2D collision)
	{
        GameObject triggerObject = collision.gameObject;

		if(collision.tag == "Treasure")
        {
			Debug.Log("Treasure Hit");
			coinCount += 30;
			coins.text = coinCount.ToString();
			triggerObject.gameObject.SetActive(false);
		}

		if (collision.tag == "Tavern")
		{
			//reset enemy health
			//reset.ResetAllEnemyHealth();
			GameStateManager.Instance.ResetEnemies();
			GameStateManager.Instance.InitializeMap(GameStateManager.Instance.currentMapID);
		}
	}
}
