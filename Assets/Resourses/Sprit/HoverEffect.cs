using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HoverEffect : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    [SerializeField] private Image squareToFade = null; // 这里应该绑定你的Square Image组件
    public void Start()
    {
        squareToFade.gameObject.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        squareToFade.gameObject.SetActive(true);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        squareToFade.gameObject.SetActive(false);
    }
}