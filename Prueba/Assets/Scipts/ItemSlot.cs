using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    private GameManager theManager;
    private GameObject myself;
    [SerializeField] RectTransform resetPlace;
    private void Awake()
    {
        myself = this.gameObject;
        theManager = FindObjectOfType<GameManager>();
    }
    public void OnDrop(PointerEventData eventData )
    {
        if (eventData.pointerDrag != null && eventData.pointerDrag.tag == myself.tag)
        {
            eventData.pointerDrag.SetActive(false);
            theManager.score++;
            Debug.Log(theManager.score);
        }
        else
        {
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = resetPlace.anchoredPosition;
        }
    }
}
