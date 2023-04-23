using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.00f;
    private float[] speedMultipliers = { 1.0f, 2.0f, 4.0f };
    private int currentSpeedIndex = 0;
    private SpriteRenderer[] spriteRenderers;

    void Start()
    {
        spriteRenderers = GetComponentsInChildren<SpriteRenderer>();
    }
    
    void Update()
    {
        Move();
        HandleColorChange();
    }

    void Move()
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

    void HandleColorChange()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            ChangeColor();
        }
    }
    
    void ChangeColor()
    {
        foreach (SpriteRenderer sr in spriteRenderers)
        {
            sr.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));;
        }
    }
}
