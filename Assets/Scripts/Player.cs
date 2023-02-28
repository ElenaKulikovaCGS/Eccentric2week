using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    [SerializeField] float Speed;
    [SerializeField] float RotationSpeed;
    //private Rigidbody _rigidbody;

    //[SerializeField] GameObject _camera;
    //private float _forwardForce;
    //float _cameraTransform;
    [SerializeField] float _speedSercetivity;
    [SerializeField] Transform _cameraTransform;
    float _yOffset;
    float _xOffset;

    public int Health;
    [SerializeField] GameObject _lossText;
    TextMeshProUGUI _healthText;
    [SerializeField] GameObject _inactiveHealthText;
    [SerializeField] GameObject _inactiveCollectText;

    void LossText()
    {
        _lossText.SetActive(enabled);
    }
    private void Start()
    {
        _healthText = FindAnyObjectByType<HealthText>().GetComponent<TextMeshProUGUI>();
        
    }
    private void Awake()
    {
     //   _rigidbody = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        
        _healthText.text = "Жизни: " + Health;
        if (Health <= 0)
        {
            LossText();
            gameObject.SetActive(false);
            _inactiveCollectText.SetActive(false);
            _inactiveHealthText.SetActive(false);

        }
    }
    private void FixedUpdate()
    {
        /*
         * float sideForce = Input.GetAxis("Horizontal") * Speed;
        _forwardForce = Input.GetAxis("Mouse Y") * _speedSercetivity;
        _rigidbody.AddForce(sideForce, _forwardForce, 0f);
        _rigidbody.AddTorque(0f, 0f, 0f);
        */
        _yOffset -= Input.GetAxis("Mouse Y") *_speedSercetivity;
        _yOffset = Mathf.Clamp(_yOffset, -2f, 2.5f);
        _xOffset -= Input.GetAxis("Mouse X") *_speedSercetivity;
        _xOffset = Mathf.Clamp(_xOffset, -38f, 38f);
        _cameraTransform.position = new Vector3(_xOffset, _yOffset, -30);

    }
}
