using UnityEngine;
using UnityEngine.AI;

public class FollowPlayerWithNavMesh : MonoBehaviour
{
    // 플레이어 오브젝트를 참조하기 위한 변수
    public Transform player;

    // NavMeshAgent 컴포넌트를 참조하기 위한 변수
    private NavMeshAgent agent;

    void Start()
    {
        // NavMeshAgent 컴포넌트를 가져옵니다.
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // 매 프레임마다 플레이어 위치로 목적지를 설정
        agent.SetDestination(player.position);
    }
}