using UnityEngine;

public class Graph : MonoBehaviour
{

    [SerializeField]
    Transform pointPrefab;

    void Awake ()
    {
        Instantiate(pointPrefab);
    }
}
