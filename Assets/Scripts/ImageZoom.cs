using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ImageZoom : MonoBehaviour
{
    
    public Sprite currentImage;
    Vector3 defaultPosition, minSize, maxSize, scaleChange, sizeChange;
    [SerializeField] private GameObject canvas;
    [SerializeField] private Button zoomInButton, zoomOutButton, zoomReset;
    

    private void Start()
    {

        defaultPosition = this.transform.position;

        scaleChange = new Vector3(0.8f, 0.8f, 0);
        maxSize = new Vector3(5f, 5f, 0f);

    }

    public void ViewImage(Image image)
    {
        canvas.SetActive(true);

        currentImage = image.sprite;
        var imageName = image.sprite.name;
        
        if (!imageName.Contains("Dean"))
        {
            sizeChange = new Vector3(1f, 0.7f, 1f);
        }
        else
        {
            sizeChange = new Vector3(1f, 1f, 1f);
        }

        this.gameObject.transform.localScale = sizeChange;
        this.gameObject.GetComponent<Image>().sprite = currentImage;

        this.gameObject.SetActive(true);

        zoomReset.interactable = false;
        zoomInButton.interactable = true;
        zoomOutButton.interactable = false;

    }


    public void HideImage()
    {

        this.transform.position = defaultPosition;
        
        canvas.SetActive(false);

    }

    public void ZoomInButton()
    {

        zoomReset.interactable = true;
        zoomOutButton.interactable = true;

        this.transform.localScale += scaleChange;

        if (this.transform.localScale.x >= maxSize.x)
        {
            zoomInButton.interactable = false;
        }


    }

    public void ZoomOutButton()
    {

        zoomInButton.interactable = true;
        minSize = sizeChange;

        this.transform.localScale -= scaleChange;

        if (this.transform.localScale.x <= minSize.x)
        {
            zoomOutButton.interactable = false;
            zoomReset.interactable = false;
        }

    }
    public void ZoomReset()
    {

        zoomReset.interactable = false;
        zoomOutButton.interactable = false;
        zoomInButton.interactable = true;

        this.transform.localScale = sizeChange;
        this.transform.position = defaultPosition;

    }
}
