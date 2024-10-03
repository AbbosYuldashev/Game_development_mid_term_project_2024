using UnityEngine;
using UnityEngine.SceneManagement;

public class ShipSelectionManager : MonoBehaviour
{
    public GameObject[] ships; // Array to store ship prefabs
    private int selectedShipIndex;

    void Start()
    {
        selectedShipIndex = 0; // Default ship index
    }

    public void SelectShip(int index)
    {
        selectedShipIndex = index;
        PlayerPrefs.SetInt("SelectedShipIndex", selectedShipIndex);
    }

    public void StartGame()
    {
        SceneManager.LoadScene("GameScene"); // Name of your main game scene
    }
}
