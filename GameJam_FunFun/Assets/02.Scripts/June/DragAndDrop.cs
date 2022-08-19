using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

    public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
    {
        private bool tagSpawn = false;
        public static Vector2 DefaultPos;

        void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
        {
            tagSpawn = false;
            DefaultPos = this.transform.localPosition;
        }

        void IDragHandler.OnDrag(PointerEventData eventData)
        {
            Vector2 currentPos = eventData.position;
            this.transform.localPosition = currentPos;
        }

        void IEndDragHandler.OnEndDrag(PointerEventData eventData)
        {
            tagSpawn = true;
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            this.transform.localPosition = DefaultPos;
        }

        private void OnTriggerExit2D(Collider2D other)
        {
        
            if(other.gameObject.CompareTag("WeaponSpawner") && tagSpawn)
            {
                Collider2D newCol = other;
                Debug.Log(newCol.transform.position);
                SkillSlot.Instance.FindIndexer(this.gameObject, newCol);

            }
        }
        
        
    }
