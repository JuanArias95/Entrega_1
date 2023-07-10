using UnityEngine;
using UnityEngine.UI;

public class ControlJuego : MonoBehaviour
{
    public GameObject pauseMenu;
    public Button btnPausa;
    public Button btnReanudar;

    // Start is called before the first frame update
    void Start()
    {
        btnPausa.onClick.AddListener(PausarJuego);
        btnReanudar.onClick.AddListener(ReanudarJuego);
    }

    void PausarJuego()
    {
        Time.timeScale = 0f;
        pauseMenu.SetActive(true);
    }

    void ReanudarJuego()
    {
        Time.timeScale = 1f;
        pauseMenu.SetActive(false);
    }
}
