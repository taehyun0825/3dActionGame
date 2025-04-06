using UnityEngine;
using UnityEngine.UI;

public class Flow : MonoBehaviour
{

    public Transform target;
    public Vector3 offset;


    void Update()
    {
        transform.position = target.position + offset;

    }
}
