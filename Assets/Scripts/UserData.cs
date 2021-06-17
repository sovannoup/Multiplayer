using Mirror;
using System;
using UnityEngine;
using UnityEngine.UI;

public class UserData : NetworkBehaviour
{
    [SyncVar]
    public string playerName;
    public static event Action<UserData, string> OnMessage;
    public GameObject m_NameText;

    public override void OnStartServer()
    {
        base.OnStartServer();
        color = UnityEngine.Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        displayName = playerName;
    }

    // Color32 packs to 4 bytes
    [SyncVar(hook = nameof(SetColor))]
    public Color32 color = Color.red;

    [SyncVar(hook = nameof(SetName))]
    public string displayName = "";

    // Unity clones the material when GetComponent<Renderer>().material is called
    // Cache it here and destroy it in OnDestroy to prevent a memory leak
    Material cachedMaterial;

    private void SetName(string oldname, string newName)
    {
        m_NameText.GetComponent<Text>().text = newName ?? displayName;
    }

    void SetColor(Color32 _, Color32 newColor)
    {
        if (cachedMaterial == null) cachedMaterial = GetComponentInChildren<Renderer>().material;
        cachedMaterial.color = newColor;
    }

    void OnDestroy()
    {
        Destroy(cachedMaterial);
    }

[Command]
    public void CmdSend(string message)
    {
        if (message.Trim() != "")
            RpcReceive(message.Trim());
    }

    [ClientRpc]
    public void RpcReceive(string message)
    {
        OnMessage?.Invoke(this, message);
    }
}