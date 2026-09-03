using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 6, -9);
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame (after the vehicle moves, for smooth camera movement)
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }
}
