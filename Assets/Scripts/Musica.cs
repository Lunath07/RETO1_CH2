using UnityEngine;
using UnityEngine.SceneManagement;

public class Musica : MonoBehaviour
{
    private static AudioSource musica;

    private void Awake()
    {
        if (musica == null)
        {
            musica = GetComponent<AudioSource>();
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    
    public void PlayMusic()
    {
        if (musica.isPlaying) return;
        musica.Play();
    }
    public void StopMusic()
    {
        musica.Stop();
        
    }
}