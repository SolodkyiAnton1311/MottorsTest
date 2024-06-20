
using UnityEngine;


public class WebcamController : MonoBehaviour
{
    private WebCamTexture _webCam;
    [SerializeField] private Material _material;

    private void Start()
    {
        _webCam = new WebCamTexture();
        _material.mainTexture = _webCam;
        _webCam.Play();
    }
}
