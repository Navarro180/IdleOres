using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LavaTextureScroller : MonoBehaviour
{
    public float scrollSpeedX = 0;
    private MeshRenderer meshRenderer;

    public PlayerController playerControllerRef;

    // Start is called before the first frame update
    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        meshRenderer.material.mainTextureOffset += 
            new Vector2(playerControllerRef.currentHorizontalSpeed * scrollSpeedX *
            Time.deltaTime, 0);
    }
}
