using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehaviour : MonoBehaviour
{
    public GameObject target;
    public float minHeight = 4.0f;
    public float cameraHeightFactor = 1.5f;

    private float height;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void LateUpdate()
    {
        transform.position = new Vector3(0, target.transform.position.y + height, 0);
        height = minHeight + 2f * cameraHeightFactor;
    }
}
