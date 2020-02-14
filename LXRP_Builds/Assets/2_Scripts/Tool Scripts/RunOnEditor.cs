using UnityEngine;
using System.Collections;

public class RunOnEditor : MonoBehaviour
{
    [SerializeField] Camera ARCamera = null;

    private void Start()
    {

    }
    private void Awake()
    {
        if (Application.isEditor || !Application.isMobilePlatform)
        {
            Destroy(ARCamera.gameObject);
        }
        else
        {
            Destroy(this.gameObject);
        }
    }
}
