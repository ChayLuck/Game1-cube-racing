using UnityEngine;
using UnityEngine.SceneManagement;
public class won : MonoBehaviour

{
    public void LoadNextLevel ()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }


}
