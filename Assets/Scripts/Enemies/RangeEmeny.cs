using UnityEngine;

public class RangeEmeny : Enemy
{
	//public override void Attack()
	//{
	//    throw new System.NotImplementedException();
	//}

	//public override void Die()
	//{
	//    throw new System.NotImplementedException();
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
	//    HP -= 1;
	//}

	[Header("Projectile Info")]
	public GameObject projectilePrefab;
	public Transform projectileSpawnLocation;
	public float projectileSpeed = 1.0f;
	public override void Attack()
	{
		// instantiate a projectile
		// give the projectile a direction + velocity
		// projectile handles collisions 

		GameObject obj = Instantiate(projectilePrefab, projectileSpawnLocation.position, Quaternion.identity);
		SimpleProjectile projectile = obj.GetComponent<SimpleProjectile>();
		Vector2 tmp = transform.position;
		Vector2 projectileVelocity = tmp - playerPosition;
		projectileVelocity.Normalize();
		projectileVelocity *= projectileSpeed;
		projectile.InstantiateProjectile(-projectileVelocity);
	}


	public override void Die()
	{
		//throw new System.NotImplementedException();
		this.gameObject.SetActive(false);
	}


}
