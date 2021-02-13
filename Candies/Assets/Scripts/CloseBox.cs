using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseBox : MonoBehaviour
{
    public GameObject done, gameText;
    private Animation anim;
    private bool finish;

    private void Start() {
        anim = GetComponent<Animation>();
    }

    private void Update() {
        if(MoveCandies.count == 8 && !finish) {
            finish = true;
            done.SetActive(true);
            gameText.SetActive(false);
            anim.Play();
        }
    }
}
