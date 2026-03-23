using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem;

public class TreasureInventory : MonoBehaviour
{
	[SerializeField] public GameObject trasureInventory;
	public bool tresOpen;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
	{
		trasureInventory.SetActive(false);
		tresOpen = false;
	}

	public void InvActive()
	{
		Debug.Log("R was pressed");
		trasureInventory.SetActive(true);
		tresOpen = true;
	}

	public void InvInactive()
	{
		trasureInventory.SetActive(false);
		tresOpen = false;
	}


	//   // Update is called once per frame
	//   void Update()
	//   {

	//   }
}
