using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class TreasureInventory : MonoBehaviour
{
	[SerializeField] public GameObject trasureInventory;


	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		trasureInventory.SetActive(false);
	}

	public void InvActive()
	{
		Debug.Log("R was pressed");
		trasureInventory.SetActive(true);
	}

	public void InvInactive()
	{
		trasureInventory.SetActive(false);
	}

	
	//   // Update is called once per frame
	//   void Update()
	//   {

	//   }
}
