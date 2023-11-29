using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LateDestroy : MonoBehaviour
{
    public void destroyLate(float time)
    {
        Destroy(gameObject, time);
    }
}
