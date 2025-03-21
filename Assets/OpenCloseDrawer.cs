using UnityEngine;

public class OpenCloseDrawer : MonoBehaviour
{
    Animator animator;
    bool isOpen = false;
    public bool isAnimationFinished = true;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void OnMouseOver() //toimii GUIn / Colliderien kanssa
    {

        if (isAnimationFinished)
        {
            if (Input.GetMouseButtonDown(0))
            {
                isAnimationFinished = false;

                if (!isOpen)
                {
                    animator.Play("DrawerOpen");
                    isOpen = true;
                }

                else
                {
                    animator.Play("DrawerClose");
                    isOpen = false;
                }
            }
        }
       
    }

    public void FinishAnimation()
    {
        isAnimationFinished = true;
    }

}
