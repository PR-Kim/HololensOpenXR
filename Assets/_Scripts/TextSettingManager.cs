using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class TextSettingManager : MonoBehaviour
{
    public TextMeshPro Title;
    public TextMeshPro Content;

    // Start is called before the first frame update
    private void OnDisable() {
        Title.text = "";
        Content.text = "";
    }
    public void setTitle(string args) {
        Title.text = args;
    }
    public void setContent(string args) {
        Content.text = args;
    }
}
