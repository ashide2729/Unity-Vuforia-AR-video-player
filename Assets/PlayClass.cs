using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayClass : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var vp = gameObject.AddComponent<UnityEngine.Video.VideoPlayer>();
        // vp.url = "http://myserver.com/mymovie.mp4";

        vp.isLooping = true;
        vp.renderMode = UnityEngine.Video.VideoRenderMode.MaterialOverride;
        vp.targetMaterialRenderer = GetComponent<Renderer>();
        vp.targetMaterialProperty = "_MainTex";

        vp.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
