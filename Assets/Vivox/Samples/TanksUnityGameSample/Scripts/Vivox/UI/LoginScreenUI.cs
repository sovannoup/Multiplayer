using System;
using UnityEngine;
using UnityEngine.Android;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LoginScreenUI : MonoBehaviour
{
    public Button confirmButton;
    public GameObject LoginScreen;
    public GameObject lobbyScreen;
    public InputField playerName;

    private bool PermissionsDenied;
    private EventSystem _evtSystem;

    private void Awake()
    {
        _evtSystem = FindObjectOfType<EventSystem>();
        confirmButton.onClick.AddListener(() => { conFirmServer(); });
    }
    private void Start()
    {
        confirmButton.interactable = false;
        _evtSystem.SetSelectedGameObject(confirmButton.gameObject, null);
    }
    public void saveName()
    {

    }
    public void selectedOne()
    {
        confirmButton.interactable = true;
    }
    private void conFirmServer()
    {
        confirmButton.interactable = false;
        if (Permission.HasUserAuthorizedPermission(Permission.Microphone))
        {
            // The user authorized use of the microphone.
            LoginToVivox();
        }
        else
        {
            // Check if the users has already denied permissions
            if (PermissionsDenied)
            {
                PermissionsDenied = false;
                LoginToVivox();
            }
            else
            {
                PermissionsDenied = true;
                confirmButton.interactable = true;
                // We do not have permission to use the microphone.
                // Ask for permission or proceed without the functionality enabled.
                Permission.RequestUserPermission(Permission.Microphone);
            }
        }
    }

    private void LoginToVivox()
    {
        confirmButton.interactable = false;
        LoginScreen.SetActive(false);
        confirmButton.interactable = true;
        lobbyScreen.SetActive(true);
    }
}