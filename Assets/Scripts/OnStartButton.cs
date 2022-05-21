using UnityEngine;

public class OnStartButton : MonoBehaviour
{
    public PlayerMove PlayerMove;
    public TimerScript timer;
    public GameObject titlescreen;
    void Start()
    {
        titlescreen.SetActive(true);
    }
    public void ClickButton()
    {
        PlayerMove.AllowPlayerMovement();
        timer.TimerStart();
        titlescreen.SetActive(false);
    }
}