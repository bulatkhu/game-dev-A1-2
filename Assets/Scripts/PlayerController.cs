using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float speed = 3f;
    SpriteRenderer sr;
    void Awake() => sr = GetComponent<SpriteRenderer>();

    void Update()
    {
        Move();
        HandleColorChange();
    }

    void Move()
    {
        Vector3 moveVector = Vector3.zero;

        // Get input and save state in moveVector
        if (Input.GetKey(KeyCode.W)) moveVector.y = 1;
        if (Input.GetKey(KeyCode.A)) moveVector.x = -1;
        if (Input.GetKey(KeyCode.S)) moveVector.y = -1;
        if (Input.GetKey(KeyCode.D)) moveVector.x = 1;

        // change speed
        if (Input.GetKeyUp(KeyCode.LeftShift) || Input.GetKeyUp(KeyCode.RightShift))
        {
            if (speed == 3f) speed = 6f;
            else if (speed == 6f) speed = 12f;
            else if (speed == 12f) speed = 3f;
        }

        // Normalize vector, so that magnitude for diagonal movement is also 1
        moveVector.Normalize();

        // Frame rate independent movement
        transform.position += Time.deltaTime * speed * moveVector;

        Vector3 characterScale = transform.localScale;
        if (moveVector.x < 0)
            characterScale.x = -1;
        else if (moveVector.x > 0)
            characterScale.x = 1;
        transform.localScale = characterScale;
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
        var spriteRenderers = GetComponentsInChildren<SpriteRenderer>();
        
        foreach (var sr in spriteRenderers)
        {
            sr.color = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));;
        }
    }
}
