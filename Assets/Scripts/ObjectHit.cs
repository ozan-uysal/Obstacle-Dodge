using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    MeshRenderer ObstacleMr;

    private void Start()
    {
     ObstacleMr = GetComponent<MeshRenderer>();    
    }
    private void OnCollisionEnter(Collision other)
     {
        Debug.Log(other.gameObject.name);
        if(other.gameObject.tag == "player")
        {
            ObstacleMr.material.color =Color.red;
        }
        else
        {
            ObstacleMr.material.color = Color.black;
        }
    }
}
