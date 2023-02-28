using UnityEngine;
using Cinemachine;

public class ShakeCamera : MonoBehaviour
{
    private CinemachineVirtualCamera cinemachineVirtualCamera;
    public static ShakeCamera Instance { get; set; }
    float ShakeTime;

    public void ShakeCameraFunc(float Coundown , float Intensity )
    {
        CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin =
        cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>();
        cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = Intensity ;
        ShakeTime = Coundown;
    }

    void Start()
    {
        cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();
        Instance = this;
        
    }
    void Update()
    {
        if (ShakeTime > 0)
        {
            ShakeTime -= Time.deltaTime;
            
        }
        if (ShakeTime <= 0f)
        {
            //Stop Shaking
            CinemachineBasicMultiChannelPerlin cinemachineBasicMultiChannelPerlin =
            cinemachineVirtualCamera.GetCinemachineComponent<CinemachineBasicMultiChannelPerlin>(); 

            cinemachineBasicMultiChannelPerlin.m_AmplitudeGain = 0;           
        }
    }
    
}
