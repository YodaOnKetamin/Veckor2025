using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;

    private int index;

    [SerializeField] private AudioClip[] dialogueTypingSoundClips;
    [Range(1, 5)]
    [SerializeField] private int frequencyLevel = 2;
    [Range(-3, 3)]
    [SerializeField] private float minPitch = 0.5f;
    [Range(-3, 3)]
    [SerializeField] private float maxPitch = 3f;

    [SerializeField] private bool stopAudioSource;

    private AudioSource audioSource;

    private void Start()
    {
        textComponent.text = string.Empty;
        StartDialogue();

        audioSource = this.gameObject.AddComponent<AudioSource>();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
            }
        }
    }

    private void StartDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        //Type each character 1 by 1
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;

            PlayDialogueSound(c);

            yield return new WaitForSeconds(textSpeed);
        }
    }

    private void PlayDialogueSound(int currentDisplayedCharacterCount)
    {
        //kollar om antalet bokstäver är delbart med det man har ställt frequencyLevel till, ifall det är sant spelas ljudet tex varanan bokstav bokstav 
        //frequencyLevel ändras med slider 
        if (currentDisplayedCharacterCount % frequencyLevel == 0)
        {
            if (stopAudioSource)
            {
                audioSource.Stop();
            }
            //spelar clip 
            int randomIndex = Random.Range(0, dialogueTypingSoundClips.Length);
            AudioClip soundClip = dialogueTypingSoundClips[randomIndex];
            //pitch
            audioSource.pitch = Random.Range(minPitch, maxPitch);
            // spelar ljud
            audioSource.PlayOneShot(soundClip);
        }
    }

    private void NextLine()
    {
        if (index < lines.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }
}
