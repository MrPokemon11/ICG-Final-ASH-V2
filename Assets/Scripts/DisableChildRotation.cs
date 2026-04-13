using UnityEngine;

public class DisableChildRotation : MonoBehaviour
{
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        Vector3 parentEuler = transform.parent.eulerAngles;
        transform.rotation = Quaternion.Euler(0, parentEuler.y, 0);
    }
}
