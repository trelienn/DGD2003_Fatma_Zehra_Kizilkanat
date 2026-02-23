using UnityEngine;

public class GimbalLockDemonstrater : MonoBehaviour
{
public Transform outerRing;
public Transform middleRing;
public Transform innerRing;
[Header("Settings")]
[Range(-180, 180)] public float outerRotation;
[Range(-180, 180)] public float middleRotation;
[Range(-180, 180)] public float innerRotation;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {        
    }

    // Update is called once per frame
    void Update()
    {
outerRing.localRotation = Quaternion.Euler(0, 0, outerRotation);
middleRing.localRotation = Quaternion.Euler(0, middleRotation, 0);
innerRing.localRotation = Quaternion.Euler(0, 0, innerRotation);
        
    }
}
