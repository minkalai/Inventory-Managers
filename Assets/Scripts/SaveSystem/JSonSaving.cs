using UnityEngine;
using System.IO;

public class JSonSaving : MonoBehaviour
{
	public static JSonSaving Instance;
	public string saveName = "SaveFile";

	private string FullPath => Path.Combine(Application.persistentDataPath, saveName + ".json");

	private void Awake()
	{
		Instance = this;
	}

	public void SaveData()
	{
		GameStateManager.Instance.SaveGameState();

		string json = JsonUtility.ToJson(GameStateManager.Instance.gameState, true);
		File.WriteAllText(FullPath, json);

		Debug.Log("Game Saved To: " + FullPath);
	}

	public void LoadData()
	{
		if (!File.Exists(FullPath))
		{
			Debug.Log("No Save File Found.");
			return;
		}

		string json = File.ReadAllText(FullPath);
		GameState loadedData = JsonUtility.FromJson<GameState>(json);

		GameStateManager.Instance.gameState = loadedData;

		foreach (MapState mapState in GameStateManager.Instance.gameState.mapStates)
		{
			mapState.InitializeDictionary();
		}

		GameStateManager.Instance.InitializeMap(GameStateManager.Instance.currentMapID);

		Debug.Log("Game Loaded.");
	}

	public bool SaveFileExists()
	{
		return File.Exists(FullPath);
	}

	private void OnApplicationQuit()
	{
		SaveData();
	}
}
