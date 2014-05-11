using UnityEngine;
using System.Collections;

public class SwordDestruction : MonoBehaviour
{
    public float lifeSpan = 2.0f;

    void Start()
    {
        Destroy(gameObject, lifeSpan);
    }
}
