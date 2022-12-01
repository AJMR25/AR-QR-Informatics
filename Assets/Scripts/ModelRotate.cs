using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ModelRotate : MonoBehaviour
{
    private Vector3 _rotation;
    private Vector2 startPos;
    private Vector2 direction;
    private Touch screenTouch;
    private Vector3 currentScale;
    private float _speed;
    private bool isRotating;
    [SerializeField] private GameObject citeModel;
    [SerializeField] private Slider _horizontalRotation;
    [SerializeField] private Slider _verticalRotation;
    [SerializeField] private Slider _resize;

    private float _horizontalValue;
    private float _verticalValue;
    private float _resizeValue;
    void Start()
    {
        //isRotating = true;

        //currentScale = this.transform.localScale;
        if (GameObject.ReferenceEquals(this.gameObject, citeModel))
        {
            _resize.value = 5.25f;
            _resize.maxValue = 10.25f;
        }

    }

    void Update()
    {
        
        _horizontalValue = _horizontalRotation.value;
        _verticalValue = _verticalRotation.value;
        _resizeValue = _resize.value;

        Vector3 scale = new Vector3(_resizeValue, _resizeValue, _resizeValue);

        this.transform.rotation = Quaternion.Euler(_verticalValue, _horizontalValue, 0f);
        this.transform.localScale = scale;
        
    }
        /*transform.Rotate(_rotation * _speed * Time.deltaTime);

        if (SimpleInput.GetButtonDown("OnRotateRight"))
        {
            
            if (isRotating)
            {
                isRotating = false;
                _rotation = new(0f, -20f, -10f);
                _speed = 20;

            }
            else
            {
                isRotating = true;
                _rotation = new(0f, 0f, 0f);
                _speed = 0;

            }

        }
        */
    
}
