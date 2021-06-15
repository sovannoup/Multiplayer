using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LoginScreen : MonoBehaviour
{
    public Button loginButton;
    public InputField DisplayNameInput;
    public GameObject networkManager;

    private int defaultMaxStringLength = 9;
    private EventSystem _evtSystem;

    private void Awake()
    {
        _evtSystem = FindObjectOfType<EventSystem>();
#if !(UNITY_STANDALONE || UNITY_IOS || UNITY_ANDROID)
        DisplayNameInput.interactable = false;
#else
        DisplayNameInput.onEndEdit.AddListener((string text) => { loginToBase(); });
#endif
        loginButton.onClick.AddListener(() => { loginToBase(); });
    }

    private void loginToBase()
    {
        
    }
}
