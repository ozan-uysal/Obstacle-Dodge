using Unity.VisualScripting;
using UnityEngine;

public class FlierToTrigerVolume : MonoBehaviour
{
    [SerializeField] Transform trigerVolume;
    [SerializeField] float moveSpeed = 0.1f;
    Vector3 trigerVolumePosition;
    void Start()
    {
      trigerVolumePosition = trigerVolume.transform.position;
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, trigerVolumePosition, moveSpeed);
    }
}
