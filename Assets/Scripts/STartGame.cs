using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class STartGame : MonoBehaviour
{
	[SerializeField] Button playButton, ResumeFromSave;
	[SerializeField] GameObject STartPanel;

	// Start is called once before the first execution of Update after the MonoBehaviour is created
	void Start()
    {
        playButton.onClick.AddListener(OnPlay);
		ResumeFromSave.onClick.AddListener(ResumeGameFromMenu);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
	public void OnPlay()
	{
		SceneManager.LoadScene("Tiles");
	}

	public void ResumeGameFromMenu()
	{
		if (JSonSaving.Instance.SaveFileExists())
		{
			JSonSaving.Instance.LoadData();
		}
	}
}
