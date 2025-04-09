using UnityEngine;

public class ChestOpener : MonoBehaviour
{
    private Animator animator;
    private bool isOpened = false;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void OnMouseDown()
    {
        if (!isOpened)
        {
            animator.SetTrigger("Open");
            isOpened = true;
        }
    }
}