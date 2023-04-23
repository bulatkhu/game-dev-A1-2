using UnityEngine;

public class PlayerSwitcher : MonoBehaviour
{
    public GameObject[] players;
    private int activePlayer;
    
    void Update()
    {
        for (int i = 0; i < players.Length; i++)
        {
            if (Input.GetKeyDown((i + 1).ToString()))
            {
                SwitchPlayer(i);
            }
        }
    }

    void SwitchPlayer(int newActivePlayer)
    {
        if (newActivePlayer != activePlayer && newActivePlayer < players.Length)
        {
            PlayerController currentController = players[activePlayer].GetComponent<PlayerController>();
            PlayerController newController = players[newActivePlayer].GetComponent<PlayerController>();

            if (currentController != null && newController != null)
            {
                currentController.enabled = false;
                newController.enabled = true;
            }

            players[activePlayer].SetActive(false);
            players[newActivePlayer].SetActive(true);
            activePlayer = newActivePlayer;
        }
    }
}