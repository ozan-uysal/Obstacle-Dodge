using UnityEngine;

public class Spinner : MonoBehaviour
{
    [SerializeField] Vector3 spinnerRotateVector = new Vector3(0.1f,0,0);
    void Update()
    {
        transform.Rotate(spinnerRotateVector);
    }
}
