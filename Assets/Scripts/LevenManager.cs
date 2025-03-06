using UnityEngine;
using UnityEngine.SceneManagement;

public class LevenManager : MonoBehaviour
{
    static private LevenManager _instance;
    static public LevenManager Instance
    {
        get { return _instance; }
        private set { }
    }

    private void Awake()
    {
        if(_instance != null && _instance != this)
        {
            Destroy(this);
        }
        else
        {
            _instance = this;
            DontDestroyOnLoad(_instance);
        }
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape)) {
            Application.Quit();
        }
        //else if (SceneManager.GetActiveScene().name == "Menu" && Input.GetKeyUp(KeyCode.Space))
        //{
        //    SceneManager.LoadScene("SampleScene");
        //}
    }

    public void LoadScene(string newScene)
    {
        SceneManager.LoadScene(newScene);
    }
}
