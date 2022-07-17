using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace PN.UI
{
    public class Draggables : MonoBehaviour, IPointerClickHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
    {
        private CanvasGroup canvasGroup;

        private Canvas parentCanvas;
        private Transform defaultParent;
        private Vector3 defaultPos;

        private IDroppables parentSlot;


        private void Awake()
        {
            canvasGroup = GetComponent<CanvasGroup>();
            parentCanvas = GetComponentInParent<Canvas>();
            parentSlot = GetComponentInParent<IDroppables>();
        }

        public void OnPointerClick(PointerEventData eventData)
        {

        }

        public void OnBeginDrag(PointerEventData eventData)
        {
            defaultParent = transform.parent;
            defaultPos = transform.position;
            canvasGroup.blocksRaycasts = false;
            transform.SetParent(parentCanvas.transform, true);
            canvasGroup.alpha = 0.6f;
        }

        public void OnEndDrag(PointerEventData eventData)
        {
            canvasGroup.blocksRaycasts = true;
            canvasGroup.alpha = 1f;
            transform.position = defaultPos;
            transform.SetParent(defaultParent, true);

            IDroppables slot = GetSlot(eventData);
            if (slot != null)
            {
                DropItemIntoSlot(slot);
            }
        }

        private IDroppables GetSlot(PointerEventData eventData)
        {
            if (eventData.pointerEnter)
            {
                return eventData.pointerEnter.GetComponentInParent<IDroppables>();
            }
            return null;
        }

        private void DropItemIntoSlot(IDroppables slot)
        {
            //check if you are hovering over the same spot the item is already in
            if (object.ReferenceEquals(slot, parentSlot)) return;

            if (slot.GetItem() == null || parentSlot.GetItem() == null)
            {
                //check if there is an item inside of slot and pointed slot
                //if any is true then just drop currently held item inside of slot
                DropItemInSlot(slot);
            }
            else
            {
                SwapItem(slot, parentSlot);
            }
        }

        private void SwapItem(IDroppables slot, IDroppables parentSlot)
        {
            //get reference to item before restting state
            var removedParentItem = parentSlot.GetItem();
            var removedDestItem = slot.GetItem();

            if (removedDestItem == null || removedParentItem == null) return;

            //Do Swap
            parentSlot.RemoveItem();
            slot.RemoveItem();

            slot.AddItem(removedParentItem);
            parentSlot.AddItem(removedDestItem);

        }

        private void DropItemInSlot(IDroppables slot)
        {
            var item = parentSlot.GetItem();
            if (item != null)
            {
                parentSlot.RemoveItem();
                slot.AddItem(item);
            }
        }

        public void OnDrag(PointerEventData eventData)
        {
            transform.position = eventData.position;
        }
    }

}

