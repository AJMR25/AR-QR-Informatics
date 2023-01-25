using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocationPaths : MonoBehaviour
{
    [SerializeField] private GameObject[] pathLocationsImages;
    //private bool ceaActive, chsActive, citeActive, cmaActive, cssActive;
    [SerializeField] private GameObject pathImages, mapImage;
    private Sprite ceaPath, chsPath, citePath, cmaPath, cssPath, casPath, imageDefault;

    private void Start()
    {

        imageDefault = mapImage.GetComponent<Image>().sprite;
        ceaPath = pathLocationsImages[0].GetComponent<Image>().sprite;
        chsPath = pathLocationsImages[1].GetComponent<Image>().sprite;
        citePath = pathLocationsImages[2].GetComponent<Image>().sprite;
        cmaPath = pathLocationsImages[3].GetComponent<Image>().sprite;
        cssPath = pathLocationsImages[4].GetComponent<Image>().sprite;
        casPath = pathLocationsImages[5].GetComponent<Image>().sprite;
    }
    public void LocationOnClick(Button depButton)
    {

        if (depButton.name.Contains("CEA"))
        {

            mapImage.GetComponent<Image>().sprite = ceaPath;

        }
        if (depButton.name.Contains("CHS"))
        {

            mapImage.GetComponent<Image>().sprite = chsPath;

        }
        if (depButton.name.Contains("CITE"))
        {

            mapImage.GetComponent<Image>().sprite = citePath;

        }
        if (depButton.name.Contains("CMA"))
        {

            mapImage.GetComponent<Image>().sprite = cmaPath;

        }
        if (depButton.name.Contains("CSS"))
        {

            mapImage.GetComponent<Image>().sprite = cssPath;

        }
        if (depButton.name.Contains("CAS"))
        {

            mapImage.GetComponent<Image>().sprite = casPath;

        }

    }

}
