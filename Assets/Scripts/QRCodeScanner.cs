using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;
using ZXing;

public class QRCodeScanner : MonoBehaviour
{

    [SerializeField] private AspectRatioFitter aspectRatioFitter;
    [SerializeField] private RawImage background;
    [SerializeField] private RectTransform scanQRHUD;
    [SerializeField] private TextMeshProUGUI responseUIText;

    private WebCamTexture webCamTexture;
    private bool isCamAvailable;
    
    void Start()
    {

        HandleCamera();

    }
    
    void Update()
    {

        HandleCameraRender();

        if (SimpleInput.GetButtonDown("OnScanQR"))
        {

            OnScanQR();

        }

    }

    private void HandleCamera()
    {

        WebCamDevice[] devices = WebCamTexture.devices;

        if (devices.Length == 0)
        {

            isCamAvailable = false;
            return;

        }

        for (int i = 0; i < devices.Length; i++)
        {

            if (devices[i].isFrontFacing == false)
            {

                webCamTexture = new WebCamTexture(devices[i].name, (int)scanQRHUD.rect.width, (int)scanQRHUD.rect.height);

            }

        }

        webCamTexture.Play();
        background.texture = webCamTexture;
        isCamAvailable = true;

    }

    private void OnScanQR()
    {

        PlayerPrefs.SetInt("model", -1);

        try
        {

            IBarcodeReader barcodeReader = new BarcodeReader();
            Result result = barcodeReader.Decode(webCamTexture.GetPixels32(), webCamTexture.width, webCamTexture.height);

            if (result != null)
            {

                OnViewModel(GetCode(result.Text.ToLower()));

            }
            else
            {

                responseUIText.text = "FAILED TO READ QR CODE";
                int countdown = 2;
                StartCoroutine(FailedToStart(countdown));
            }

        }
        catch
        {

            responseUIText.text = "FAILED IN TRY";
            int countdown = 2;
            StartCoroutine(FailedToStart(countdown));

        }

    }

    private void HandleCameraRender()
    {

        if (isCamAvailable == false)
        {

            return;

        }

        float ratio = (float)webCamTexture.width / (float)webCamTexture.height;
        aspectRatioFitter.aspectRatio = ratio;

        int orientation = -webCamTexture.videoRotationAngle;
        background.rectTransform.localEulerAngles = new Vector3(0, 0, orientation);

    }

    private int GetCode(string _result)
    {

        if (_result.Contains("architecture"))
        {

            return 0;

        }
        else if (_result.Contains("health"))
        {

            return 1;

        }
        else if (_result.Contains("technology"))
        {

            return 2;

        }
        else if (_result.Contains("accountancy"))
        {

            return 3;

        }
        else if (_result.Contains("social"))
        {

            return 4;

        }
        if (_result.Contains("arts"))
        {

            return 5;

        }

        return 6;

    }

    private void OnViewModel(int _result)
    {

        PlayerPrefs.SetInt("model", _result);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }

    IEnumerator FailedToStart(int _countdown)
    {

        while (_countdown > 0)
        {

            yield return new WaitForSeconds(1f);

            _countdown--;

        }

        responseUIText.text = "";

    }

}
