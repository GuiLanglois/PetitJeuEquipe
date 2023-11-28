using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{

    public static LevelManager Instance;
    // Start is called before the first frame update

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    private void Awake()
    {
        if(Instance == null)
        {Instance = this;
        DontDestroyOnLoad(gameObject);
        
        }
        else
        {
             Destroy(gameObject);
        }
    }

    // Update is called once per frame
    public void LoadScene(string scene)
    {
        SceneManager.LoadScene(scene.ToString());
    }

        public void NewGame()
    {
        SceneManager.LoadScene(Scene.BoissyLoicSceneExterieur.ToString());
    }
        public void Scene1()
        {
            SceneManager.LoadScene(Scene.ReyNicolasInterieur.ToString());
        }
            public void LoadMainMenu()
    {
        SceneManager.LoadScene(Scene.MainMenu.ToString());
    }

                public void QuitGame()
    {
        Application.Quit();
    }

    public async void LoadAsyncScene(Scene scenename)
    {
        var sceneLoad = SceneManager.LoadSceneAsync(scenename.ToString());
        sceneLoad.allowSceneActivation = true;

       /* _loadCanvas.SetActive(true);
        do{
            await Task.Delay(100);
            _progressbar.fillAmount = Scene.load.progress;
        }
        while(sceneLoad.progress < 0.9f);

        sceneLoad.allowSceneActivation = true;
        
        _loadCanvas.SetActive(true);*/
    }

    public enum Scene{
        MainMenu,
        ReyNicolasInterieur,
        BoissyLoicSceneExterieur,
    }
}
