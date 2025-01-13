using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    public void playgame() {
        SceneManager.LoadSceneAsync("SampleScene");
    }
}
