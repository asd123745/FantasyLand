using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class LookItem : MonoBehaviour,IPointerEnterHandler,
    IPointerExitHandler, IGvrPointerHoverHandler
{
    private Animator anim;
    private readonly int hashIsOpen = Animator.StringToHash("IsOpen");
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }
    public void OnBoxeOpen(bool isOpen)
    {
        anim.SetBool(hashIsOpen, isOpen);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnLookItemBox(bool isLookAt)
    {
        Debug.Log(isLookAt);
        MoveCtl.isStopped = isLookAt;
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        MoveCtl.isStopped = true;
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        MoveCtl.isStopped = false;
    }
    public void OnGvrPointerHover(PointerEventData eventData)
    {
        Debug.Log("Reticle On");

    }
}
