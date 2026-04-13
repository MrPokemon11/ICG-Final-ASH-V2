using UnityEngine;
using UnityEngine.AI;

public class FollowTheLeader : MonoBehaviour
{
    [SerializeField] private GameObject leader;
    NavMeshAgent follower;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        follower = GetComponent<NavMeshAgent>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(gameObject.transform.position, leader.transform.position) >= 1)
        {
            follower.isStopped = false;
            follower.SetDestination(leader.transform.position);
            follower.Move(Vector3.Lerp(gameObject.transform.position, leader.transform.position, Time.deltaTime));
        } else if (!follower.isStopped)
        {
            follower.isStopped = true;
        }
    }
}
