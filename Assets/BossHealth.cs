using UnityEngine;
using UnityEngine.UI;

public class BossHealth : MonoBehaviour
{
    public Slider healthBar; // Reference to the UI slider for the health bar

    private void Start()
    {

        healthBar.gameObject.SetActive(false); // Initialize the slider's value
    }

    private void Update()
    {
        if (EnemySpawner.is_boss_spawn)
        {
            healthBar.value = BossEnemyController.boss_health;
        }
        
        
    }
    
}
