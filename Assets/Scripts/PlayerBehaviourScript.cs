using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 5.00f;
    private float[] speedMultipliers = { 1.0f, 2.0f, 4.0f };
    private int currentSpeedIndex = 0;   
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        
        Vector3 rightMovement = new Vector3(moveHorizontal, 0f, 0f) * moveSpeed * Time.deltaTime;
        Vector3 upMovement = new Vector3(0f, moveVertical, 0f) * moveSpeed * Time.deltaTime;

        // Check if the Shift key is held down
        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            currentSpeedIndex = (currentSpeedIndex + 1) % speedMultipliers.Length;
        }
        
        float speedMultiplier = speedMultipliers[currentSpeedIndex];
        
        rightMovement *= speedMultiplier;
        upMovement *= speedMultiplier;

        transform.position += rightMovement + upMovement;
    }
}
