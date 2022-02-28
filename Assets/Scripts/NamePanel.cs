using UnityEngine.UI;
using UnityEngine;

public class NamePanel : MonoBehaviour
{
    public Image panel = null;
    Text _name = null;

    private void Awake()
    {
        _name = GetComponent<Text>();
    }

    private void FixedUpdate()
    {
        if (_name != null)
            if (_name.text.Length > 1)
            {
                if (panel != null)
                    panel.enabled = true;
            }
            else
            {
                if (panel != null)
                    panel.enabled = false;
            }
    }
}
