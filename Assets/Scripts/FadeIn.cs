using UnityEngine;

public class FadeIn : MonoBehaviour
{
    [SerializeField] private GameObject Aurora;
    [SerializeField] private float fadeSpeed = 0.2f;
    
    private bool fadeIn = false;
    private Material auroraMaterial;
    private float opacity;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        auroraMaterial = Aurora.GetComponent<Renderer>().material;

    }

    // Update is called once per frame
    void Update()
    {
        if (fadeIn && opacity >= 0f)
        {
            opacity = auroraMaterial.GetFloat("_Opacity");
            auroraMaterial.SetFloat("_Opacity", opacity - Time.deltaTime * fadeSpeed);
        }
    }

    public void StartFadeIn()
    {
        fadeIn = true;
    }
}
