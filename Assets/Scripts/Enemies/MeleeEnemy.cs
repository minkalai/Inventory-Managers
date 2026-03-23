using System.Runtime.CompilerServices;
using UnityEngine;

public class MeleeEnemy : Enemy
{
	//public override void Attack()
	//{
	//    throw new System.NotImplementedException();
	//}

	//public override void Die()
	//{
	//    HP -= 5;
	//}

	//public override void Patrol()
	//{
	//    throw new System.NotImplementedException();
	//}

	//public override void Pursue()
	//{
	//    throw new System.NotImplementedException();
	//}

	//public override void TakeDamage()
	//{
	//    throw new System.NotImplementedException();
	//}

	//public PlayerController player;
	[SerializeField] public GameObject treasure;

	private void Start()
	{
		treasure.SetActive(false);
	}
	public override void Attack()
	{
		PlayerController.instance.healthbar -= 10;
	}

	public override void Die()
	{
		if (HP >= 0)
		{
			this.gameObject.SetActive(false);
			treasure.SetActive(true);
		}
		
	}
}
