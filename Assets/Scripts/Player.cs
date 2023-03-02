using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    /*
     * [SerializeField] float Speed;
    [SerializeField] float _speedSencetivity;
    [SerializeField] Transform _cameraTransform;
    float _yOffset;
    float _xOffset;
    public Rigidbody Rigidbody;
    */
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
        //ограничение перемещения камеры, в теории должно было помочь, чтобы камера не вылезала за границу фона
        _yOffset -= Input.GetAxis("Mouse Y") * _speedSencetivity;
        _yOffset = Mathf.Clamp(_yOffset, -2f, 2.5f);
        _xOffset -= Input.GetAxis("Mouse X") *_speedSencetivity;
        _xOffset = Mathf.Clamp(_xOffset, -30f, 30f);
        _cameraTransform.position = new Vector3(_xOffset, _yOffset, -30f);
        //полёт самолёта
        Vector3 inputVector = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0f);
        Vector3 speedVector = inputVector * Speed;
        Rigidbody.velocity = new Vector3(speedVector.x, speedVector.y, Rigidbody.velocity.z);
        */
    }
}
