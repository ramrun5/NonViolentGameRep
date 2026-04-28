using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayButtonMenuScreenYas : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayGame() //Funktion för att starta spelet när man trycker på "play".
    {
        SceneManager.LoadSceneAsync("Main Game");
    }

}
