using UnityEngine;
using Unity.Cinemachine;

public class ManualAutomaticDolly : MonoBehaviour
{
    public float DollySpeed;
    [SerializeField] private GameObject cameraObject;
    private CinemachineSplineDolly splineDolly;
    private bool isMoving = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        splineDolly = cameraObject.GetComponent<CinemachineSplineDolly>();
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoving)
        {
            splineDolly.CameraPosition += DollySpeed * Time.deltaTime;

            if(splineDolly.CameraPosition >= 1f)
            {
                splineDolly.CameraPosition = 1f;
                isMoving = false;
            }
            cameraObject.transform.rotation = new Quaternion(0, cameraObject.transform.rotation.y, 0, cameraObject.transform.rotation.w);
        }
    }

    public void startMoving()
    {
        isMoving = true;
    }
}
