
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenceController : IntroController
{ 
    public static ScenceController instance;
    [SerializeField] Animator transitionAnim;

    private void Awake()
    {
        
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void NextLevel()
    {
        
        StartCoroutine(LoadLevel());
    }


    public void LoadScene(string sceneName)
    {
        
        SceneManager.LoadSceneAsync(sceneName);
    }

    IEnumerator LoadLevel()
    {
        
        transitionAnim.SetTrigger("End");
        yield return new WaitForSeconds(1f);
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex + 1);
        transitionAnim.SetTrigger("Start");
        

    }
}
