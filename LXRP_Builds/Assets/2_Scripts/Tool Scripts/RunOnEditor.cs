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
        // Destroy AR camera object if running in editor or as non-mobile stand alone build
        if (Application.isEditor)
        {
            Destroy(ARCamera.gameObject);
        }
        else // Destroy "regular" camera if running a mobile device build
        {
            Destroy(this.gameObject);
        }
    }
}
