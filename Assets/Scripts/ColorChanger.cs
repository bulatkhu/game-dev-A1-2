using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private SpriteRenderer[] spriteRenderers;

    void Start()
    {
        spriteRenderers = GetComponentsInChildren<SpriteRenderer>();
    }

    void Update()
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