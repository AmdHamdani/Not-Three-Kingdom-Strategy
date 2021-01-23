using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginView : MonoBehaviour
{
    [SerializeField] private InputField emailField;
    [SerializeField] private InputField passwordField;
    [SerializeField] private Button loginButton;
    [SerializeField] private Button registerButton;

    private LoginController controller = new LoginController();

    private void Start()
    {
        controller.Init();

        loginButton.onClick.AddListener(() => controller.Login(emailField.text, passwordField.text));
        registerButton.onClick.AddListener(() => controller.Register(emailField.text, passwordField.text));
    }
}
