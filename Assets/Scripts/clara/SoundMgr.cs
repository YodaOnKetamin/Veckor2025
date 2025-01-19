using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SoundMgr : MonoBehaviour
{
    [SerializeField] private AudioMixer audioMixer;

    public void SetVolume(float sliderValue)
    {
        audioMixer.SetFloat("MasterVolume", Mathf.Log10(sliderValue) * 20);

    }

   /* [SerializeField] Slider volumeSlider;

    // Start is called before the first frame update
    void Start()
    {
        //ifall man inte har satt slidern på något så blir det 100%
        if (!PlayerPrefs.HasKey("musicVolume"))
        {
            PlayerPrefs.SetFloat("musicVolume", 1);
            Load();
        }
        //annars det man har satt den på innan 
        else
        {
            Load();
        }
    }

    public void ChangeVolume()
    {
        AudioListener.volume = volumeSlider.value;
        Save();
    }

    private void Load()
    {
        //ger det man sätter den på
        volumeSlider.value = PlayerPrefs.GetFloat("musicVolume");
    }
   
    private void Save()
    {
        //gör så att man kan spara den volume man sätter den på
        PlayerPrefs.SetFloat("musicVolume", volumeSlider.value);
    }
   */
}
