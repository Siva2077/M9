using UnityEngine;

[System.Serializable]
public class BackgroundElement
{
    public MeshRenderer background;
    [Range(0, 1)] public float scrollSpeed;
    [HideInInspector] public Material backgroundMaterial;
}

public class BackgroundElement : MonoBehaviour
{
    private const float SCROLL_MULTIPLIER = 0.01f;

    [SerializeField] private BackgroundElement[] backgroundElements;

    private void Start()
    {
        foreach (BackgroundElement element in backgroundElements)
        {
            element.backgroundMaterial = element.background.material;
        }
    }

    private void Update()
    {
        foreach (BackgroundElement element in backgroundElements)
        {
            element.backgroundMaterial.mainTextureOffset = new Vector2(transform.position.x * element.scrollSpeed * SCROLL_MULTIPLIER, 0);
        }
    }
}
