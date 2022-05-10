using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    //lr is watch distance and sr is stop distance
    public float lr = 20f, sr = 1;
    public Transform target;
    public NavMeshAgent agent;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        // agent = GetComponent<NavMeshAgent>();
       // player = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float distance = Vector3.Distance(target.position, transform.position);

        if (distance <= lr)
        {
            agent.SetDestination(target.position);
        }
        if (distance <= sr)
        {
            player.SetActive(false);

        }
    }

    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, lr);
        Gizmos.color = Color.blue;
        Gizmos.DrawWireSphere(transform.position, sr);
    }
}