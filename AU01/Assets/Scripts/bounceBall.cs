using UnityEngine;

public class bounceBall : MonoBehaviour
{
    public Animator anim;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("b"))
        {
            Debug.Log("bounce");
            anim.SetTrigger("bounce");
        }
    }
}
