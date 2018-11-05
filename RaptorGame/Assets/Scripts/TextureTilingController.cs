using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class TextureTilingController : MonoBehaviour {
    public float repeatEvery = 5;

    // Use this for initialization
    void Start() {
        gameObject.GetComponent<Renderer>().material.mainTextureScale = new Vector2(gameObject.transform.localScale.x / repeatEvery, 1f);
    }
}