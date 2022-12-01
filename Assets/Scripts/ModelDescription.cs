using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ModelDescription : MonoBehaviour
{
    [SerializeField] private GameObject[] contentDescription;
    [SerializeField] private TextMeshProUGUI contenDepartment;

    void Start()
    {
        int model = PlayerPrefs.GetInt("model", 5);
        DisplayDescription(model);
    }

    void DisplayDescription(int _model)
    {

        
        contentDescription[_model].SetActive(true);
        

    }
}
