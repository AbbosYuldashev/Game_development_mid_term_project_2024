using UnityEngine;
using UnityEngine.UI;

public class SettingsManager : MonoBehaviour
{
    public Slider backgroundMusicSlider;
    public Slider shootingSoundSlider;
    public Button muteBackgroundMusicButton;
    public Button muteShootingSoundButton;

    private AudioSource backgroundMusicSource;
    private AudioSource shootingSoundSource;
    private bool isBackgroundMusicMuted = false;
    private bool isShootingSoundMuted = false;

    void Start()
    {
        // Set up volume controls
        backgroundMusicSlider.onValueChanged.AddListener(SetBackgroundMusicVolume);
        shootingSoundSlider.onValueChanged.AddListener(SetShootingSoundVolume);

        // Set up mute/unmute buttons
        muteBackgroundMusicButton.onClick.AddListener(ToggleBackgroundMusicMute);
        muteShootingSoundButton.onClick.AddListener(ToggleShootingSoundMute);

        // Find the audio sources in the scene
        backgroundMusicSource = GameObject.Find("BackgroundMusic").GetComponent<AudioSource>();
        shootingSoundSource = GameObject.Find("ShootingSound").GetComponent<AudioSource>();

        // Set initial slider values based on current audio source volumes
        backgroundMusicSlider.value = backgroundMusicSource.volume;
        shootingSoundSlider.value = shootingSoundSource.volume;
    }

    // Adjust background music volume
    public void SetBackgroundMusicVolume(float volume)
    {
        if (!isBackgroundMusicMuted)
        {
            backgroundMusicSource.volume = volume;
        }

        // Automatically mute if volume is set to 0
        if (volume == 0 && !isBackgroundMusicMuted)
        {
            ToggleBackgroundMusicMute();
        }
        else if (volume > 0 && isBackgroundMusicMuted)
        {
            ToggleBackgroundMusicMute(); // Unmute when volume is greater than 0
        }
    }

    // Mute/unmute background music
    public void ToggleBackgroundMusicMute()
    {
        isBackgroundMusicMuted = !isBackgroundMusicMuted;
        backgroundMusicSource.mute = isBackgroundMusicMuted;
        muteBackgroundMusicButton.GetComponentInChildren<Text>().text = isBackgroundMusicMuted ? "Unmute Background Music" : "Mute Background Music";

        // Set slider to 0 if muted
        if (isBackgroundMusicMuted)
        {
            backgroundMusicSlider.value = 0;
        }
    }

    // Adjust shooting sound volume
    public void SetShootingSoundVolume(float volume)
    {
        if (!isShootingSoundMuted)
        {
            shootingSoundSource.volume = volume;
        }

        // Automatically mute if volume is set to 0
        if (volume == 0 && !isShootingSoundMuted)
        {
            ToggleShootingSoundMute();
        }
        else if (volume > 0 && isShootingSoundMuted)
        {
            ToggleShootingSoundMute(); // Unmute when volume is greater than 0
        }
    }

    // Mute/unmute shooting sounds
    public void ToggleShootingSoundMute()
    {
        isShootingSoundMuted = !isShootingSoundMuted;
        shootingSoundSource.mute = isShootingSoundMuted;
        muteShootingSoundButton.GetComponentInChildren<Text>().text = isShootingSoundMuted ? "Unmute Shooting Sounds" : "Mute Shooting Sounds";

        // Set slider to 0 if muted
        if (isShootingSoundMuted)
        {
            shootingSoundSlider.value = 0;
        }
    }
}
