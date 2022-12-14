using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Canvas))]
public class EmojiBubble : MonoBehaviour
{
    private Camera mainCamera;
    private bool isCleared = true;
    public RectTransform rectTransform;
    public float panelMarginHeight = 30;
    public float panelMarginWidth = 30;
    public GameObject bubble;
    private void Start()
    {
        mainCamera = Camera.main;
        //rectTransform.GetComponent<RectTransform>();
    }

    private void LateUpdate()
    {
        if (mainCamera != null)
        {
            //transform.LookAt(2*transform.position - mainCamera.transform.position);
            transform.LookAt(transform.position + Camera.main.transform.rotation * Vector3.forward, Camera.main.transform.rotation * Vector3.up);

        }
    }

    public void SetEmoji(List<GameObject> emojis)
    {
        if (emojis.Count > 0)
        {
            isCleared = false;
            bubble.transform.DetachChildren();
            float emojiWidth = emojis[0].GetComponent<RectTransform>().sizeDelta.x;
            float emojiHeight = emojis[0].GetComponent<RectTransform>().sizeDelta.y;
            rectTransform.sizeDelta = new Vector2(2 * panelMarginWidth + emojis.Count * emojiWidth, 2 * panelMarginHeight + emojiHeight);
            foreach (GameObject emoji in emojis)
            {
                GameObject icon = Instantiate(emoji);
                icon.transform.SetParent(bubble.transform);
                icon.GetComponent<RectTransform>().anchoredPosition3D = new Vector3(emojis.IndexOf(emoji) * emojiWidth + panelMarginWidth + emojiWidth / 2, 0, 0);
                icon.GetComponent<RectTransform>().localRotation = Quaternion.identity;
                icon.GetComponent<RectTransform>().localScale = Vector3.one;
            }
        }
    }

    public void ClearEmoji()
    {
        isCleared = true;
        bubble.transform.DetachChildren();
    }

    public void ShowEmoji()
    {
        if (!isCleared)
            bubble.SetActive(true);
    }

    public void HideEmoji()
    {
        bubble.SetActive(false);
    }
}
