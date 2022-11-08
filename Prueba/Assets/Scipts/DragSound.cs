using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragSound : MonoBehaviour, IBeginDragHandler
{
    private AudioSource mySource;
    private void Awake()
    {
        mySource = GetComponent<AudioSource>();
    }
    public void OnBeginDrag(PointerEventData eventData)
    {
        mySource.Play();
    }
}
