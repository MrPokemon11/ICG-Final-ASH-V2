using UnityEngine;

public class Spin : MonoBehaviour
{
    public bool isSpinning = false;
    public float spinSpeed = 10f;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isSpinning)
        {
            transform.Rotate(Vector3.up * spinSpeed * Time.deltaTime);
        }
    }
}
