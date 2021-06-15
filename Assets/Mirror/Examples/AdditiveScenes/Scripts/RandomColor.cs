using UnityEngine;
using UnityEngine.UI;

namespace Mirror.Examples.Additive
{
    public class RandomColor : NetworkBehaviour
    {
        public GameObject m_NameText;
        public override void OnStartServer()
        {
            base.OnStartServer();
            color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
        }

        // Color32 packs to 4 bytes
        [SyncVar(hook = nameof(SetColor))]
        public Color32 color = Color.black;

        [SyncVar(hook = nameof(SetName))]
        public string displayName = "";

        // Unity clones the material when GetComponent<Renderer>().material is called
        // Cache it here and destroy it in OnDestroy to prevent a memory leak
        Material cachedMaterial;

        private void DisplayNameText(string newName = null)
        {
            if (isLocalPlayer)
            {
                m_NameText.SetActive(false);
            }
            else
            {
                m_NameText.GetComponent<Text>().text = newName ?? displayName;
            }
        }

        private void SetName(string oldname, string newName)
        {
            DisplayNameText(newName);
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
    }
}
