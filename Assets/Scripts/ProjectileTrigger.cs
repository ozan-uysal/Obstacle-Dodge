using UnityEngine;

public class ProjectileTrigger : MonoBehaviour
{
    [SerializeField] GameObject projectile;

    private void Start() 
    {
        projectile.SetActive(false);
    }
    private void Update()
    {
        DestroyWhenReached();
    }

    private void OnTriggerEnter(Collider other) 
    {
       
        if(other.gameObject.tag == "player")
        {
            projectile.SetActive(true);
        }
    }

      void DestroyWhenReached()
    {
        if(gameObject.transform.position == projectile.transform.position)
         {
            Destroy(projectile);
            Destroy(gameObject);
         }
    }
}
