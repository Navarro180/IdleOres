using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TextureScroller : MonoBehaviour
{
    public float scrollSpeedX = 0;
    private float scrollSpeedY = 0;
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
            new Vector2(playerControllerRef.currentHorizontalSpeed * 
            Time.deltaTime, Time.realtimeSinceStartup * scrollSpeedY);
    }
}
